// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Win32.Graphics.Dxgi.Apis;
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
    public static TFeature CheckFeatureSupport<TFeature>(this ref IDXGIFactory5 factory, Feature feature)
        where TFeature : unmanaged
    {
        TFeature featureData = default;
        factory.CheckFeatureSupport(feature, &featureData, sizeof(TFeature)).ThrowIfFailed();
        return featureData;
    }
}
