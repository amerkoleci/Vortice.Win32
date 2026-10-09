// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Graphics;

public static unsafe class ID3D11VideoDevice2Extensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TFeature CheckFeatureSupport<TD3D11VideoDevice2, TFeature>(ref this TD3D11VideoDevice2 self, D3D11_FEATURE_VIDEO feature)
        where TD3D11VideoDevice2 : unmanaged, ID3D11VideoDevice2.Interface
        where TFeature : unmanaged
    {
        TFeature featureData = default;
        self.CheckFeatureSupport(feature, &featureData, sizeof(TFeature)).ThrowIfFailed();
        return featureData;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static HRESULT CheckFeatureSupport<TD3D11VideoDevice2, TFeature>(ref this TD3D11VideoDevice2 self, D3D11_FEATURE_VIDEO feature, ref TFeature featureData)
       where TD3D11VideoDevice2 : unmanaged, ID3D11VideoDevice2.Interface
       where TFeature : unmanaged
    {
        fixed (TFeature* featureDataPtr = &featureData)
        {
            return self.CheckFeatureSupport(feature, featureDataPtr, sizeof(TFeature));
        }
    }
}
