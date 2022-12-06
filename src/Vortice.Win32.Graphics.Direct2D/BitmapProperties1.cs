// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Direct2D.Common;

namespace Win32.Graphics.Direct2D;

public partial struct BitmapProperties1
{
    public unsafe BitmapProperties1(
        BitmapOptions bitmapOptions = BitmapOptions.None,
        PixelFormat pixelFormat = default, float dpiX = 96.0f, float dpiY = 96.0f, ID2D1ColorContext* colorContext = null)
    {
        this.pixelFormat = pixelFormat;
        this.dpiX = dpiX;
        this.dpiY = dpiY;
        this.bitmapOptions = bitmapOptions;
        this.colorContext = colorContext;
    }
}
