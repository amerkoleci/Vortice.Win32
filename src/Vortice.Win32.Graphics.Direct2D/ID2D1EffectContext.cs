// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Apis;

namespace Vortice.Win32.Graphics;

public static unsafe class ID2D1EffectContextExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TFeature CheckFeatureSupport<TID2D1EffectContext, TFeature>(ref this TID2D1EffectContext self, D2D1_FEATURE feature)
        where TID2D1EffectContext : unmanaged, ID2D1EffectContext.Interface
        where TFeature : unmanaged
    {
        TFeature featureData = default;
        self.CheckFeatureSupport(feature, &featureData, (uint)sizeof(TFeature)).ThrowIfFailed();
        return featureData;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static HResult CheckFeatureSupport<TID2D1EffectContext, TFeature>(ref this TID2D1EffectContext self,  D2D1_FEATURE feature, ref TFeature featureData)
       where TID2D1EffectContext : unmanaged, ID2D1EffectContext.Interface
       where TFeature : unmanaged
    {
        fixed (TFeature* featureDataPtr = &featureData)
        {
            return self.CheckFeatureSupport(feature, featureDataPtr, (uint)sizeof(TFeature));
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static HResult CreateEffect<TID2D1EffectContext>(ref this TID2D1EffectContext self, in Guid effectId, ID2D1Effect** effect)
       where TID2D1EffectContext : unmanaged, ID2D1EffectContext.Interface
    {
        return self.CreateEffect((Guid*)Unsafe.AsPointer(in effectId), effect);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ComPtr<ID2D1Effect> CreateEffect<TID2D1EffectContext>(ref this TID2D1EffectContext self, in Guid effectId)
       where TID2D1EffectContext : unmanaged, ID2D1EffectContext.Interface
    {
        using ComPtr<ID2D1Effect> effect = default;
        self.CreateEffect((Guid*)Unsafe.AsPointer(in effectId), effect.GetAddressOf()).ThrowIfFailed();
        return effect.Move();
    }
}
