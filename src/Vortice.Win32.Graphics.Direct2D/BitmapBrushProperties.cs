// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct2D;

public partial struct BitmapBrushProperties
{
    public BitmapBrushProperties(
        ExtendMode extendModeX = ExtendMode.Clamp,
        ExtendMode extendModeY = ExtendMode.Clamp,
        BitmapInterpolationMode interpolationMode = BitmapInterpolationMode.Linear)
    {
        this.extendModeX = extendModeX;
        this.extendModeY = extendModeY;
        this.interpolationMode = interpolationMode;
    }
}
