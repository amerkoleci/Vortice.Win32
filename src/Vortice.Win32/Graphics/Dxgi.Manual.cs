// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Win32.Graphics.Dxgi.Apis;

namespace Win32.Graphics.Dxgi;

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
