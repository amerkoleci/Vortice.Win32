// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Apis;
using static Vortice.Win32.StringUtilities;
using static Vortice.Win32.Graphics.DXGI;

namespace Vortice.Win32.Graphics;

public unsafe partial struct DXGI_ADAPTER_DESC
{
    /// <include file='Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC::Description"]/*' />
    public readonly string GetDescription()
    {
        fixed (char* ptr = Description)
        {
            return GetString(ptr, 128) ?? string.Empty;
        }
    }
}

public unsafe partial struct DXGI_ADAPTER_DESC1
{
    /// <include file='Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1::Description"]/*' />
    public readonly string GetDescription()
    {
        fixed (char* ptr = Description)
        {
            return GetString(ptr, 128) ?? string.Empty;
        }
    }
}

public unsafe partial struct DXGI_ADAPTER_DESC2
{
    /// <include file='Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC2::Description"]/*' />
    public readonly string GetDescription()
    {
        fixed (char* ptr = Description)
        {
            return GetString(ptr, 128) ?? string.Empty;
        }
    }
}

public static unsafe class IDXGIFactory5Extensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsTearingSupported<TDXGIFactory5>(ref this TDXGIFactory5 self)
        where TDXGIFactory5 : unmanaged, IDXGIFactory5.Interface
    {
        Bool32 supported = default;
        HResult hr = self.CheckFeatureSupport(DXGI_FEATURE_PRESENT_ALLOW_TEARING, &supported, sizeof(Bool32));
        return hr.Success && supported == true;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TFeature CheckFeatureSupport<TDXGIFactory5, TFeature>(ref this TDXGIFactory5 self, DXGI_FEATURE feature)
        where TDXGIFactory5 : unmanaged, IDXGIFactory5.Interface
        where TFeature : unmanaged
    {
        TFeature featureData = default;
        self.CheckFeatureSupport(feature, &featureData, sizeof(TFeature)).ThrowIfFailed();
        return featureData;
    }
}
