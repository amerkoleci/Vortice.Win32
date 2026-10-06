// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Graphics;

public partial struct D2D1_GRADIENT_STOP
{
    public D2D1_GRADIENT_STOP(float position, in Color4 color)
    {
        this.position = position;
        this.color = color;
    }
}
