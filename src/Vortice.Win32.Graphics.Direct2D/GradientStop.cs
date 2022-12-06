// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct2D;

public partial struct GradientStop
{
    public GradientStop(float position, in Color4 color)
    {
        this.position = position;
        this.color = color;
    }
}
