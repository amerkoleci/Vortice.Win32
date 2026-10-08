// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D2D1;

namespace Vortice.Win32.Graphics;

public partial struct D2D1_IMAGE_BRUSH_PROPERTIES 
{
    public D2D1_IMAGE_BRUSH_PROPERTIES(in RectF sourceRectangle,
        D2D1_EXTEND_MODE extendModeX = D2D1_EXTEND_MODE_CLAMP,
        D2D1_EXTEND_MODE extendModeY = D2D1_EXTEND_MODE_CLAMP,
        D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR)
    {
        this.sourceRectangle = sourceRectangle;
        this.extendModeX = extendModeX;
        this.extendModeY = extendModeY;
        this.interpolationMode = interpolationMode;
    }
}
