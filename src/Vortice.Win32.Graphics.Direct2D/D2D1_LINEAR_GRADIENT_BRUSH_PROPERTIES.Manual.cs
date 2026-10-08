// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Graphics;

public partial struct D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES
{
    public D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES(in Vector2 startPoint, in Vector2 endPoint)
    {
        this.startPoint = startPoint;
        this.endPoint = endPoint;
    }
}
