// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Reflection;
using System.Runtime.InteropServices;
using Win32;
using Win32.Graphics.Dxgi;
using Win32.Graphics.Direct3D11;
using static Win32.Apis;
using static Win32.Graphics.Dxgi.Apis;
using static Win32.Graphics.Direct3D11.Apis;
using Win32.Graphics.Direct3D;

namespace ClearScreen;

public static unsafe class Program
{
    public static void Main()
    {
        using ComPtr<IDXGIFactory1> factory = default;
        HResult hr = CreateDXGIFactory1(__uuidof<IDXGIFactory4>(), (void**)&factory);

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
                adapter.Get()->GetDesc1(&desc);

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
                adapter.Get()->GetDesc1(&desc);

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

        using ComPtr<ID3D11Device> d3dDevice = default;
        FeatureLevel featureLevel;
        using ComPtr<ID3D11DeviceContext> immediateContext = default;

        D3D11CreateDevice(
            (IDXGIAdapter*)adapter.Get(),
            DriverType.Hardware,
            CreateDeviceFlag.None,
            featureLevels,
            d3dDevice.GetAddressOf(),
            &featureLevel,
            immediateContext.GetAddressOf()).ThrowIfFailed();
    }
}
