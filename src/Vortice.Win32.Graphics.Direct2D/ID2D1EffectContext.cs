// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Win32.Apis;

namespace Win32.Graphics.Direct2D;

public unsafe partial struct ID2D1EffectContext
{
    public HResult CreateEffect(in Guid effectId, ID2D1Effect** effect)
    {
        return CreateEffect((Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in effectId)), effect);
    }

    public ComPtr<ID2D1Effect> CreateEffect(in Guid effectId)
    {
        using ComPtr<ID2D1Effect> effect = default;
        ThrowIfFailed(CreateEffect((Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in effectId)), effect.GetAddressOf()));
        return effect.Move();
    }
}
