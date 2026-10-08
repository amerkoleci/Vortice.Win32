// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D2D1;

namespace Vortice.Win32.Graphics;

public partial struct D2D1_BITMAP_PROPERTIES1
{
    public unsafe D2D1_BITMAP_PROPERTIES1(
        D2D1_BITMAP_OPTIONS bitmapOptions = D2D1_BITMAP_OPTIONS_NONE,
        D2D1_PIXEL_FORMAT pixelFormat = default, float dpiX = 96.0f, float dpiY = 96.0f, ID2D1ColorContext* colorContext = null)
    {
        this.pixelFormat = pixelFormat;
        this.dpiX = dpiX;
        this.dpiY = dpiY;
        this.bitmapOptions = bitmapOptions;
        this.colorContext = colorContext;
    }
}
