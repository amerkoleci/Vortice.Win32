// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.DXGICommon;
using static Vortice.Win32.Graphics.D2D1Common;

namespace Vortice.Win32.Graphics;

public partial struct D2D1_PIXEL_FORMAT
{
    /// <summary>
    /// An unkown <see cref="D2D1_PIXEL_FORMAT"/> with <see cref="DXGI_FORMAT"/> to <see cref="DXGI_FORMAT_UNKNOWN"/> and <see cref="D2D1_ALPHA_MODE"/> to <see cref="D2D1_ALPHA_MODE_UNKNOWN"/>.
    /// </summary>
    public static D2D1_PIXEL_FORMAT Unknown => new(DXGI_FORMAT_UNKNOWN, D2D1_ALPHA_MODE_UNKNOWN);

    /// <summary>
    /// A Premultiplied <see cref="D2D1_PIXEL_FORMAT"/> with <see cref="DXGI_FORMAT"/> to <see cref="DXGI_FORMAT_UNKNOWN "/> and <see cref="D2D1_ALPHA_MODE"/> to <see cref="D2D1_ALPHA_MODE_PREMULTIPLIED"/>.
    /// </summary>
    public static D2D1_PIXEL_FORMAT Premultiplied => new(DXGI_FORMAT_UNKNOWN, D2D1_ALPHA_MODE_PREMULTIPLIED);

    /// <summary>
    /// Initializes a new instance of the <see cref="D2D1_PIXEL_FORMAT"/> struct.
    /// </summary>
    /// <param name="format">The <see cref="DXGI_FORMAT"/> to use.</param>
    /// <param name="alphaMode">A value that specifies whether the alpha channel is using pre-multiplied alpha, straight alpha, whether it should be ignored and considered opaque, or whether it is unknown.</param>
    public D2D1_PIXEL_FORMAT(DXGI_FORMAT format = DXGI_FORMAT_UNKNOWN, D2D1_ALPHA_MODE alphaMode = D2D1_ALPHA_MODE_UNKNOWN)
    {
        this.format = format;
        this.alphaMode = alphaMode;
    }
}
