// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Drawing;

namespace Win32.Graphics.Direct2D;

public partial struct HwndRenderTargetProperties
{
    public HwndRenderTargetProperties(
        IntPtr hwnd,
        Size pixelSize = default,
        PresentOptions presentOptions = PresentOptions.None)
    {
        this.hwnd = hwnd;
        this.pixelSize = pixelSize;
        this.presentOptions = presentOptions;
    }
}
