// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Win32.Apis;
using static Win32.StringUtilities;

namespace Win32.Graphics.Dxgi;

public unsafe partial struct AdapterDescription
{
    /// <include file='Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC::Description"]/*' />
    public readonly string GetDescription()
    {
        fixed (ushort* ptr = Description)
        {
            return GetString(ptr, 128) ?? string.Empty;
        }
    }
}

public unsafe partial struct AdapterDescription1
{
    /// <include file='Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1::Description"]/*' />
    public readonly string GetDescription()
    {
        fixed (ushort* ptr = Description)
        {
            return GetString(ptr, 128) ?? string.Empty;
        }
    }
}

public unsafe partial struct AdapterDescription2
{
    /// <include file='Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC2::Description"]/*' />
    public readonly string GetDescription()
    {
        fixed (ushort* ptr = Description)
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
        HResult hr = self.CheckFeatureSupport(Feature.PresentAllowTearing, &supported, sizeof(Bool32));
        return hr.Success && supported == true;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TFeature CheckFeatureSupport<TDXGIFactory5, TFeature>(ref this TDXGIFactory5 self, Feature feature)
        where TDXGIFactory5 : unmanaged, IDXGIFactory5.Interface
        where TFeature : unmanaged
    {
        TFeature featureData = default;
        ThrowIfFailed(self.CheckFeatureSupport(feature, &featureData, sizeof(TFeature)));
        return featureData;
    }
}
