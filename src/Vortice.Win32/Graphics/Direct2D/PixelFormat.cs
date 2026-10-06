// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Vortice.Win32.Graphics.Dxgi.Common;

namespace Vortice.Win32.Graphics;

public partial struct D2D1_PIXEL_FORMAT
{
    /// <summary>
    /// An unkown <see cref="D2D1_PIXEL_FORMAT"/> with <see cref="Format"/> to <see cref="Format.Unknown"/> and <see cref="AlphaMode"/> to <see cref="AlphaMode.Unknown"/>.
    /// </summary>
    public static D2D1_PIXEL_FORMAT Unknown => new(Format.Unknown, AlphaMode.Unknown);

    /// <summary>
    /// A Premultiplied <see cref="D2D1_PIXEL_FORMAT"/> with <see cref="Format"/> to <see cref="Format.Unknown"/> and <see cref="AlphaMode"/> to <see cref="AlphaMode.Premultiplied"/>.
    /// </summary>
    public static D2D1_PIXEL_FORMAT Premultiplied => new(Format.Unknown, AlphaMode.Premultiplied);

    /// <summary>
    /// Initializes a new instance of the <see cref="D2D1_PIXEL_FORMAT"/> struct.
    /// </summary>
    /// <param name="format">The <see cref="DXGI_FORMAT"/> to use.</param>
    /// <param name="alphaMode">A value that specifies whether the alpha channel is using pre-multiplied alpha, straight alpha, whether it should be ignored and considered opaque, or whether it is unknown.</param>
    public PixelFormat(DXGI_FORMAT format = DXGI_FORMAT_UNKNOWN, AlphaMode alphaMode = AlphaMode.Unknown)
    {
        this.format = format;
        this.alphaMode = alphaMode;
    }
}
