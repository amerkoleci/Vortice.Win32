// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D2D1;

namespace Vortice.Win32.Graphics;

public partial struct D2D1_RENDER_TARGET_PROPERTIES
{
    public D2D1_RENDER_TARGET_PROPERTIES(
        D2D1_RENDER_TARGET_TYPE type = D2D1_RENDER_TARGET_TYPE_DEFAULT,
        D2D1_PIXEL_FORMAT pixelFormat = default,
        float dpiX = 0.0f,
        float dpiY = 0.0f,
        D2D1_RENDER_TARGET_USAGE usage = D2D1_RENDER_TARGET_USAGE_NONE,
        D2D1_FEATURE_LEVEL minLevel = D2D1_FEATURE_LEVEL_DEFAULT)
    {
        this.type = type;
        this.pixelFormat = pixelFormat;
        this.dpiX = dpiX;
        this.dpiY = dpiY;
        this.usage = usage;
        this.minLevel = minLevel;
    }
}
