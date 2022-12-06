// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Direct2D.Common;

namespace Win32.Graphics.Direct2D;

public partial struct BitmapProperties
{
    public BitmapProperties(PixelFormat pixelFormat = default, float dpiX = 96.0f, float dpiY = 96.0f)
    {
        this.pixelFormat = pixelFormat;
        this.dpiX = dpiX;
        this.dpiY = dpiY;
    }
}
