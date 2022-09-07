// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32;
using Win32.Graphics.Direct3D;
using Win32.Graphics.Direct3D11;
using Win32.Graphics.Dxgi;
using static Win32.Apis;
using static Win32.Graphics.Direct3D11.Apis;
using static Win32.Graphics.Dxgi.Apis;
using MessageId = Win32.Graphics.Direct3D11.MessageId;
using InfoQueueFilter = Win32.Graphics.Direct3D11.InfoQueueFilter;

namespace ClearScreen;

public static unsafe class Program
{
#if DEBUG
    static bool SdkLayersAvailable()
    {
        HResult hr = D3D11CreateDevice(
            null,
            DriverType.Null,       // There is no need to create a real hardware device.
            IntPtr.Zero,
            CreateDeviceFlag.Debug,  // Check for the SDK layers.
            null,                    // Any feature level will do.
            0,
            D3D11_SDK_VERSION,
            null,                    // No need to keep the D3D device reference.
            null,                    // No need to know the feature level.
            null                     // No need to keep the D3D device context reference.
            );

        return hr.Success;
    }
#endif

    public static void Main()
    {
        using ComPtr<IDXGIFactory2> factory = default;
        uint factoryFlags = 0;
#if DEBUG
        {
            using ComPtr<IDXGIInfoQueue> dxgiInfoQueue = default;
            if (DXGIGetDebugInterface1(0, __uuidof<IDXGIInfoQueue>(), (void**)dxgiInfoQueue.GetAddressOf()).Success)
            {
                factoryFlags = DXGI_CREATE_FACTORY_DEBUG;

                dxgiInfoQueue.Get()->SetBreakOnSeverity(DXGI_DEBUG_ALL, InfoQueueMessageSeverity.Error, true);
                dxgiInfoQueue.Get()->SetBreakOnSeverity(DXGI_DEBUG_ALL, InfoQueueMessageSeverity.Corruption, true);
            }
        }
#endif

        HResult hr = CreateDXGIFactory2(factoryFlags, __uuidof<IDXGIFactory2>(), (void**)&factory);

        {
            using ComPtr<IDXGIFactory5> factory5 = default;
            if (factory.CopyTo(&factory5).Success)
            {
                bool isTearingSupported = factory5.Get()->CheckFeatureSupport<Bool32>(Win32.Graphics.Dxgi.Feature.PresentAllowTearing);
            }
        }

        using ComPtr<IDXGIAdapter1> adapter = default;

        using ComPtr<IDXGIFactory6> factory6 = default;
        if (factory.CopyTo(&factory6).Success)
        {
            for (uint adapterIndex = 0;
                factory6.Get()->EnumAdapterByGpuPreference(
                    adapterIndex,
                    GpuPreference.HighPerformance,
                    __uuidof<IDXGIAdapter1>(),
                    (void**)adapter.ReleaseAndGetAddressOf()).Success;
                adapterIndex++)
            {
                AdapterDescription1 desc = default;
                adapter.Get()->GetDesc1(&desc).ThrowIfFailed();

                if ((desc.Flags & AdapterFlags.Software) != AdapterFlags.None)
                    continue;

                break;
                //string name = desc.DescriptionStr;
            }
        }

        if (adapter.Get() == null)
        {
            for (uint adapterIndex = 0;
                factory.Get()->EnumAdapters1(adapterIndex, adapter.ReleaseAndGetAddressOf()).Success;
                adapterIndex++)
            {
                AdapterDescription1 desc = default;
                adapter.Get()->GetDesc1(&desc).ThrowIfFailed();

                if ((desc.Flags & AdapterFlags.Software) != AdapterFlags.None)
                    continue;

                //string name = desc.DescriptionStr;
                break;
            }
        }

        ReadOnlySpan<FeatureLevel> featureLevels = stackalloc FeatureLevel[1]
        {
            FeatureLevel.Level_11_0
        };

        CreateDeviceFlag creationFlags = CreateDeviceFlag.BgraSupport;
#if DEBUG
        if (SdkLayersAvailable())
        {
            // If the project is in a debug build, enable debugging via SDK Layers with this flag.
            creationFlags |= CreateDeviceFlag.Debug;
        }
#endif

        using ComPtr<ID3D11Device> tempDevice = default;
        FeatureLevel featureLevel;
        using ComPtr<ID3D11DeviceContext> immediateContext = default;

        D3D11CreateDevice(
            (IDXGIAdapter*)adapter.Get(),
            DriverType.Unknown,
            creationFlags,
            featureLevels,
            tempDevice.GetAddressOf(),
            &featureLevel,
            immediateContext.GetAddressOf()).ThrowIfFailed();

#if DEBUG
        using ComPtr<ID3D11Debug> d3dDebug = default;
        if (tempDevice.CopyTo(&d3dDebug).Success)
        {
            using ComPtr<ID3D11InfoQueue> d3dInfoQueue = default;
            if (d3dDebug.CopyTo(&d3dInfoQueue).Success)
            {
                d3dInfoQueue.Get()->SetBreakOnSeverity(MessageSeverity.Corruption, true);
                d3dInfoQueue.Get()->SetBreakOnSeverity(MessageSeverity.Error, true);

                MessageId* hide = stackalloc MessageId[1]
                {
                    MessageId.SetprivatedataChangingparams,
                };

                InfoQueueFilter filter = new();
                filter.DenyList.NumIDs = 1u;
                filter.DenyList.pIDList = hide;
                d3dInfoQueue.Get()->AddStorageFilterEntries(&filter);
            }
        }
#endif
    }
}
