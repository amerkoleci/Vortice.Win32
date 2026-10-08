// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Drawing;
using static Vortice.Win32.Graphics.D2D1;

namespace Vortice.Win32.Graphics;

public partial struct D2D1_HWND_RENDER_TARGET_PROPERTIES    
{
    public D2D1_HWND_RENDER_TARGET_PROPERTIES(
        nint hwnd,
        Size pixelSize = default,
        D2D1_PRESENT_OPTIONS presentOptions = D2D1_PRESENT_OPTIONS_NONE)
    {
        this.hwnd = hwnd;
        this.pixelSize = pixelSize;
        this.presentOptions = presentOptions;
    }
}
