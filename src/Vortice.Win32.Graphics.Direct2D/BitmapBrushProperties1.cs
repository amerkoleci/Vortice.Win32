// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct2D;

public partial struct BitmapBrushProperties1
{
    public BitmapBrushProperties1(
        ExtendMode extendModeX = ExtendMode.Clamp,
        ExtendMode extendModeY = ExtendMode.Clamp,
        InterpolationMode interpolationMode = InterpolationMode.Linear)
    {
        this.extendModeX = extendModeX;
        this.extendModeY = extendModeY;
        this.interpolationMode = interpolationMode;
    }
}
