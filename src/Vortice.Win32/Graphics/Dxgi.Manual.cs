// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Win32.Graphics.Dxgi.Apis;
using static Win32.StringUtilities;

namespace Win32.Graphics.Dxgi;

public unsafe partial struct AdapterDescription
{
    /// <include file='../Generated/DXGI.xml' path='doc/member[@name="DXGI_ADAPTER_DESC::Description"]/*' />
    public readonly string DescriptionStr
    {
        get
        {
            fixed (ushort* ptr = Description)
            {
                return GetString(ptr, 128) ?? string.Empty;
            }
        }
    }
}

public unsafe partial struct AdapterDescription1
{
    /// <include file='../Generated/DXGI.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1::Description"]/*' />
    public readonly string DescriptionStr
    {
        get
        {
            fixed (ushort* ptr = Description)
            {
                return GetString(ptr, 128) ?? string.Empty;
            }
        }
    }
}

public unsafe partial struct AdapterDescription2
{
    public readonly ReadOnlySpan<ushort> DescriptionSpan
    {
        get
        {
            fixed (ushort* ptr = Description)
            {
                return GetUtf16Span(ptr, 128);
            }
        }
    }

    /// <include file='../Generated/DXGI.xml' path='doc/member[@name="DXGI_ADAPTER_DESC2::Description"]/*' />
    public readonly string DescriptionStr
    {
        get
        {
            fixed (ushort* ptr = Description)
            {
                return GetString(ptr, 128) ?? string.Empty;
            }
        }
    }
}

public unsafe partial struct IDXGIFactory5
{
    public TFeature CheckFeatureSupport<TFeature>(Feature feature)
        where TFeature : unmanaged
    {
        TFeature featureData = default;
        CheckFeatureSupport(feature, &featureData, (uint)sizeof(TFeature)).ThrowIfFailed();
        return featureData;
    }
}

public unsafe partial struct IDXGIFactory6
{
    public TFeature CheckFeatureSupport<TFeature>(Feature feature)
        where TFeature : unmanaged
    {
        TFeature featureData = default;
        CheckFeatureSupport(feature, &featureData, (uint)sizeof(TFeature)).ThrowIfFailed();
        return featureData;
    }
}

public unsafe partial struct IDXGIFactory7
{
    public TFeature CheckFeatureSupport<TFeature>(Feature feature)
        where TFeature : unmanaged
    {
        TFeature featureData = default;
        CheckFeatureSupport(feature, &featureData, (uint)sizeof(TFeature)).ThrowIfFailed();
        return featureData;
    }
}
