// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Dxgi;

namespace Win32.Graphics.Direct3D12;

public unsafe partial struct ID3D12Device
{
    public TFeature CheckFeatureSupport<TFeature>(Feature feature)
        where TFeature : unmanaged
    {
        TFeature featureData = default;
        CheckFeatureSupport(feature, &featureData, (uint)sizeof(TFeature)).ThrowIfFailed();
        return featureData;
    }
}
