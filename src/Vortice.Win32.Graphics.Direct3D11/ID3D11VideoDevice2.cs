// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Win32.Apis;

namespace Win32.Graphics.Direct3D11;

public static unsafe class ID3D11VideoDevice2Extensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TFeature CheckFeatureSupport<TD3D11VideoDevice2, TFeature>(ref this TD3D11VideoDevice2 self, FeatureVideo feature)
        where TD3D11VideoDevice2 : unmanaged, ID3D11VideoDevice2.Interface
        where TFeature : unmanaged
    {
        TFeature featureData = default;
        ThrowIfFailed(self.CheckFeatureSupport(feature, &featureData, sizeof(TFeature)));
        return featureData;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static HResult CheckFeatureSupport<TD3D11VideoDevice2, TFeature>(ref this TD3D11VideoDevice2 self, FeatureVideo feature, ref TFeature featureData)
       where TD3D11VideoDevice2 : unmanaged, ID3D11VideoDevice2.Interface
       where TFeature : unmanaged
    {
        fixed (TFeature* featureDataPtr = &featureData)
        {
            return self.CheckFeatureSupport(feature, featureDataPtr, sizeof(TFeature));
        }
    }
}
