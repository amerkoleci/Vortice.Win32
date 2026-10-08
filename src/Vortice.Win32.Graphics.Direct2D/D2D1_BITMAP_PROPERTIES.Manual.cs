// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Graphics;

public partial struct D2D1_BITMAP_PROPERTIES
{
    public D2D1_BITMAP_PROPERTIES(D2D1_PIXEL_FORMAT pixelFormat = default, float dpiX = 96.0f, float dpiY = 96.0f)
    {
        this.pixelFormat = pixelFormat;
        this.dpiX = dpiX;
        this.dpiY = dpiY;
    }
}
