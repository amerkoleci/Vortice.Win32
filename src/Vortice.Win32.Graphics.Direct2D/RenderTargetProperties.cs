// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Direct2D.Common;

namespace Win32.Graphics.Direct2D;

public partial struct RenderTargetProperties
{
    public RenderTargetProperties(
        RenderTargetType type = RenderTargetType.Default,
        PixelFormat pixelFormat = default,
        float dpiX = 0.0f,
        float dpiY = 0.0f,
        RenderTargetUsage usage = RenderTargetUsage.None,
        FeatureLevel minLevel = FeatureLevel.Default)
    {
        this.type = type;
        this.pixelFormat = pixelFormat;
        this.dpiX = dpiX;
        this.dpiY = dpiY;
        this.usage = usage;
        this.minLevel = minLevel;
    }
}
