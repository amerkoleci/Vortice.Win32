// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Drawing;
using System.Runtime.CompilerServices;
using Win32.Graphics.Direct2D.Common;
using Win32.Graphics.Direct3D11;
using Win32.Graphics.Imaging;

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
        CreateEffect((Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in effectId)), effect.GetAddressOf()).ThrowIfFailed();
        return effect.Move();
    }
}
