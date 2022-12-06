// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Direct2D.Common;

namespace Win32.Graphics.Direct2D;

public partial struct ImageBrushProperties
{
    public ImageBrushProperties(in RectF sourceRectangle,
        ExtendMode extendModeX = ExtendMode.Clamp,
        ExtendMode extendModeY = ExtendMode.Clamp,
        InterpolationMode interpolationMode = InterpolationMode.Linear)
    {
        this.sourceRectangle = sourceRectangle;
        this.extendModeX = extendModeX;
        this.extendModeY = extendModeY;
        this.interpolationMode = interpolationMode;
    }
}
