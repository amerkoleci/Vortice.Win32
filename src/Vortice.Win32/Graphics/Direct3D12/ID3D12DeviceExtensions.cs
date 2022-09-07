// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Dxgi;

namespace Win32.Graphics.Direct3D12;

/// <summary>
/// A <see langword="class"/> with extensions for the <see cref="ID3D12Device"/> type.
/// </summary>
public static unsafe class ID3D12DeviceExtensions
{
    public static TFeature CheckFeatureSupport<TFeature>(this ref ID3D12Device device, Feature feature)
        where TFeature : unmanaged
    {
        TFeature featureData = default;
        device.CheckFeatureSupport(feature, &featureData, (uint)sizeof(TFeature)).ThrowIfFailed();
        return featureData;
    }
}
