// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.


namespace Vortice.Win32.Graphics;

public partial struct D2D1_BRUSH_PROPERTIES
{
    public D2D1_BRUSH_PROPERTIES(float opacity = 1.0f)
    {
        this.opacity = opacity;
        transform = Matrix3x2.Identity;
    }

    public D2D1_BRUSH_PROPERTIES(float opacity, in Matrix3x2 transform)
    {
        this.opacity = opacity;
        this.transform = transform;
    }
}
