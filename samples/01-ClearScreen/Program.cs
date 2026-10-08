// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Numerics;
using Vortice.Win32;
using Vortice.Win32.Graphics;
using static Vortice.Win32.Apis;
using static Vortice.Win32.Graphics.DXGICommon;
using static Vortice.Win32.Graphics.D3D;
using static Vortice.Win32.Graphics.DXGI;
using static Vortice.Win32.Graphics.D3D11;
using static Vortice.Win32.Graphics.D3D12;
using static Vortice.Win32.Graphics.DXC;
using static Vortice.Win32.Graphics.D2D1;
using static Vortice.Win32.Graphics.WIC;
using static Vortice.Win32.Graphics.DWrite;
using static Vortice.Win32.Media.Audio.XAudio2;
using Vortice.Win32.Media.Audio;
using static Vortice.Win32.Graphics.D3D12MA;

namespace ClearScreen;

public static unsafe class Program
{
#if DEBUG
    static bool SdkLayersAvailable()
    {
        HResult hr = D3D11CreateDevice(
            null,
            D3D_DRIVER_TYPE_NULL,       // There is no need to create a real hardware device.
            IntPtr.Zero,
            D3D11_CREATE_DEVICE_DEBUG,  // Check for the SDK layers.
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

    private static void TestDxc()
    {
        using ComPtr<IDxcCompiler3> compiler = default;
        DxcCreateInstance(CLSID_DxcCompiler, __uuidof<IDxcCompiler3>(), (void**)compiler.GetAddressOf());
    }

    private static void TestWic()
    {
        string assetsPath = Path.Combine(AppContext.BaseDirectory, "Assets", "Textures");
        string textureFile = Path.Combine(assetsPath, "10points.png");

        using ComPtr<IWICImagingFactory2> wicImagingFactory = default;
        CreateWICImagingFactory2(wicImagingFactory.GetAddressOf()).ThrowIfFailed();

        using ComPtr<IWICBitmapDecoder> decoder =
            ((IWICImagingFactory*)wicImagingFactory.Get())->CreateDecoderFromFilename(textureFile);

        using ComPtr<IWICBitmapFrameDecode> wicBitmapFrameDecode = default;

        // Get the first frame of the loaded image (if more are present, they will be ignored)
        decoder.Get()->GetFrame(0, wicBitmapFrameDecode.GetAddressOf()).ThrowIfFailed();

        uint width;
        uint height;
        Guid pixelFormat;

        wicBitmapFrameDecode.Get()->GetSize(&width, &height).ThrowIfFailed();
        wicBitmapFrameDecode.Get()->GetPixelFormat(&pixelFormat).ThrowIfFailed();
        //wicBitmapFrameDecode.Get()->CopyPixels(rowPitch, pixels);
    }

    private static void TestD2D1AndDWrite()
    {
        using ComPtr<ID2D1Effect> effect = default;
        //effect.Get()->SetInput();

        using ComPtr<ID2D1Factory2> d2d1Factory2 = default;

        D2D1CreateFactory(D2D1_FACTORY_TYPE_MULTI_THREADED,
            __uuidof<ID2D1Factory2>(),
            default,
             (void**)d2d1Factory2.GetAddressOf()).ThrowIfFailed();

        using ComPtr<IDWriteFactory> dwriteFactory = default;
        DWriteCreateFactory(DWRITE_FACTORY_TYPE_SHARED, __uuidof<IDWriteFactory>(), (void**)dwriteFactory.GetAddressOf()).ThrowIfFailed();

        using ComPtr<IDWriteTextFormat> textFormat =
            dwriteFactory.Get()->CreateTextFormat(
                "Gabriola".AsSpan(),        // Font family name.
                72.0f,
                fontWeight: DWRITE_FONT_WEIGHT_REGULAR,
                localeName: "en-us".AsSpan()
                );

        textFormat.Get()->SetTextAlignment(DWRITE_TEXT_ALIGNMENT_CENTER).ThrowIfFailed();
        textFormat.Get()->SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT_CENTER).ThrowIfFailed();
    }

    public static void Main()
    {
        X3DAudioInitialize(0u, X3DAUDIO_SPEED_OF_SOUND, out X3DAUDIO_HANDLE handle).ThrowIfFailed();

        TestDxc();
        TestWic();
        TestD2D1AndDWrite();

        using ComPtr<IDXGIFactory2> factory = default;
        DXGI_CREATE_FACTORY_FLAGS factoryFlags = 0;

#if DEBUG
        {
            using ComPtr<IDXGIInfoQueue> dxgiInfoQueue = default;
            if (DXGIGetDebugInterface1(0, __uuidof<IDXGIInfoQueue>(), (void**)dxgiInfoQueue.GetAddressOf()).Success)
            {
                factoryFlags = DXGI_CREATE_FACTORY_DEBUG;

                dxgiInfoQueue.Get()->SetBreakOnSeverity(DXGI_DEBUG_ALL, DXGI_INFO_QUEUE_MESSAGE_SEVERITY_ERROR, true);
                dxgiInfoQueue.Get()->SetBreakOnSeverity(DXGI_DEBUG_ALL, DXGI_INFO_QUEUE_MESSAGE_SEVERITY_CORRUPTION, true);
            }
        }
#endif

        HResult hr = CreateDXGIFactory2(factoryFlags, __uuidof<IDXGIFactory2>(), (void**)&factory);

        {
            using ComPtr<IDXGIFactory5> factory5 = default;
            if (factory.CopyTo(&factory5).Success)
            {
                var test = factory5.Get()->IsTearingSupported();
                //bool isTearingSupported = factory5.Get()->CheckFeatureSupport<Bool32>(Win32.Graphics.Dxgi.Feature.PresentAllowTearing);
            }
        }

        using ComPtr<IDXGIAdapter1> adapter = default;
        bool supportD3D12 = false;

        using ComPtr<IDXGIFactory6> factory6 = default;
        if (factory.CopyTo(&factory6).Success)
        {
            for (uint adapterIndex = 0;
                factory6.Get()->EnumAdapterByGpuPreference(
                    adapterIndex,
                    DXGI_GPU_PREFERENCE_HIGH_PERFORMANCE,
                    __uuidof<IDXGIAdapter1>(),
                    (void**)adapter.ReleaseAndGetAddressOf()).Success;
                adapterIndex++)
            {
                DXGI_ADAPTER_DESC1 desc = default;
                adapter.Get()->GetDesc1(&desc).ThrowIfFailed();

                if ((desc.Flags & DXGI_ADAPTER_FLAG_SOFTWARE) != 0)
                    continue;

                // Check to see if the adapter supports Direct3D 12, but don't create the actual device yet.
                if (D3D12CreateDevice((IUnknown*)adapter.Get(), D3D_FEATURE_LEVEL_11_0, __uuidof<ID3D12Device>(), null).Success)
                {
                    supportD3D12 = true;
                    break;
                }

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
                DXGI_ADAPTER_DESC1 desc = default;
                adapter.Get()->GetDesc1(&desc).ThrowIfFailed();

                if ((desc.Flags & DXGI_ADAPTER_FLAG_SOFTWARE) != 0)
                    continue;

                // Check to see if the adapter supports Direct3D 12, but don't create the actual device yet.
                if (D3D12CreateDevice((IUnknown*)adapter.Get(), D3D_FEATURE_LEVEL_11_0, __uuidof<ID3D12Device>(), null).Success)
                {
                    supportD3D12 = true;
                    break;
                }

                //string name = desc.DescriptionStr;
                break;
            }
        }

        if (supportD3D12)
        {
            using ComPtr<ID3D12Device> device = default;

            // Create the DX12 API device object.
            hr = D3D12CreateDevice(
                (IUnknown*)adapter.Get(),
                D3D_FEATURE_LEVEL_11_0,
                __uuidof<ID3D12Device>(),
                 (void**)device.GetAddressOf()
                );
            hr.ThrowIfFailed();

            D3D12MA_ALLOCATOR_DESC allocatorDesc = new()
            {
                pDevice = device.Get(),
                pAdapter = (IDXGIAdapter*)adapter.Get()
            };
            hr = D3D12MA_CreateAllocator(in allocatorDesc, out D3D12MA_Allocator allocator);

            D3D12MA_ALLOCATION_DESC allocationDesc = new();
            allocationDesc.HeapType = D3D12_HEAP_TYPE.D3D12_HEAP_TYPE_DEFAULT;

            using ComPtr<ID3D12Resource> buffer = default;
            D3D12_RESOURCE_DESC bufferDesc = D3D12_RESOURCE_DESC.Buffer(256u);

            D3D12MA_Allocation allocation = default;
            hr = allocator.CreateResource<ID3D12Resource>(&allocationDesc, in bufferDesc, D3D12_RESOURCE_STATES.D3D12_RESOURCE_STATE_COMMON,
                null, &allocation, buffer.GetAddressOf());
            //var test = allocator.IsUMA;
            hr.ThrowIfFailed();
            uint cnt = allocation.Release();
        }
        else
        {

            ReadOnlySpan<D3D_FEATURE_LEVEL> featureLevels =
            [
                D3D_FEATURE_LEVEL_11_0
            ];

            D3D11_CREATE_DEVICE_FLAG creationFlags = D3D11_CREATE_DEVICE_BGRA_SUPPORT;
#if DEBUG
            if (SdkLayersAvailable())
            {
                // If the project is in a debug build, enable debugging via SDK Layers with this flag.
                creationFlags |= D3D11_CREATE_DEVICE_DEBUG;
            }
#endif

            using ComPtr<ID3D11Device> tempDevice = default;
            D3D_FEATURE_LEVEL featureLevel;
            using ComPtr<ID3D11DeviceContext> tempImmediateContext = default;

            D3D11CreateDevice(
                (IDXGIAdapter*)adapter.Get(),
                D3D_DRIVER_TYPE.D3D_DRIVER_TYPE_UNKNOWN,
                creationFlags,
                featureLevels,
                tempDevice.GetAddressOf(),
                &featureLevel,
                tempImmediateContext.GetAddressOf()).ThrowIfFailed();

#if DEBUG
            using ComPtr<ID3D11Debug> d3dDebug = default;
            if (tempDevice.CopyTo(&d3dDebug).Success)
            {
                using ComPtr<ID3D11InfoQueue> d3dInfoQueue = default;
                if (d3dDebug.CopyTo(&d3dInfoQueue).Success)
                {
                    d3dInfoQueue.Get()->SetBreakOnSeverity(D3D11_MESSAGE_SEVERITY_CORRUPTION, true);
                    d3dInfoQueue.Get()->SetBreakOnSeverity(D3D11_MESSAGE_SEVERITY_ERROR, true);

                    D3D11_MESSAGE_ID* hide = stackalloc D3D11_MESSAGE_ID[1]
                    {
                        D3D11_MESSAGE_ID_SETPRIVATEDATA_CHANGINGPARAMS,
                    };

                    D3D11_INFO_QUEUE_FILTER filter = new();
                    filter.DenyList.NumIDs = 1u;
                    filter.DenyList.pIDList = hide;
                    d3dInfoQueue.Get()->AddStorageFilterEntries(&filter);
                }
            }
#endif

            using ComPtr<ID3D11Device1> d3dDevice = default;
            using ComPtr<ID3D11DeviceContext1> immediateContext = default;

            tempDevice.CopyTo(&d3dDevice).ThrowIfFailed();
            tempImmediateContext.CopyTo(&immediateContext).ThrowIfFailed();

            ReadOnlySpan<VertexPositionColor> triangleVertices = stackalloc VertexPositionColor[]
            {
                new VertexPositionColor(new Vector3(0f, 0.5f, 0.0f), new Vector4(1.0f, 0.0f, 0.0f, 1.0f)),
                new VertexPositionColor(new Vector3(0.5f, -0.5f, 0.0f), new Vector4(0.0f, 1.0f, 0.0f, 1.0f)),
                new VertexPositionColor(new Vector3(-0.5f, -0.5f, 0.0f), new Vector4(0.0f, 0.0f, 1.0f, 1.0f))
            };

            using ComPtr<ID3D11Buffer> vertexBuffer = ((ID3D11Device*)d3dDevice.Get())->CreateBuffer(triangleVertices, D3D11_BIND_VERTEX_BUFFER);

            using ComPtr<ID3D11Texture2D> depthStencilTexture = default;
            using ComPtr<ID3D11DepthStencilView> depthStencilTextureView = default;

            D3D11_TEXTURE2D_DESC texture2DDesc = new(DXGI_FORMAT_D32_FLOAT, 256, 256, 1, 1, D3D11_BIND_DEPTH_STENCIL);
            tempDevice.Get()->CreateTexture2D(&texture2DDesc, null, depthStencilTexture.GetAddressOf()).ThrowIfFailed();
            depthStencilTexture.Get()->GetDesc(&texture2DDesc);
            depthStencilTexture.Get()->SetDebugName("CIAO");

            tempDevice.Get()->CreateDepthStencilView(
                (ID3D11Resource*)depthStencilTexture.Get(), null, depthStencilTextureView.GetAddressOf()).ThrowIfFailed();
        }
    }
}
