// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Graphics;

public partial struct D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES
{
    public D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES(in Vector2 center, in Vector2 gradientOriginOffset, float radiusX, float radiusY)
    {
        this.center = center;
        this.gradientOriginOffset = gradientOriginOffset;
        this.radiusX = radiusX;
        this.radiusY = radiusY;
    }
}
