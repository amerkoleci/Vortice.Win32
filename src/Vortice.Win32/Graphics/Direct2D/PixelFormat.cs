// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Dxgi.Common;

namespace Win32.Graphics.Direct2D.Common;

public partial struct PixelFormat
{
    /// <summary>
    /// An unkown <see cref="PixelFormat"/> with <see cref="Format"/> to <see cref="Format.Unknown"/> and <see cref="AlphaMode"/> to <see cref="AlphaMode.Unknown"/>.
    /// </summary>
    public static PixelFormat Unknown => new(Format.Unknown, AlphaMode.Unknown);

    /// <summary>
    /// A Premultiplied <see cref="PixelFormat"/> with <see cref="Format"/> to <see cref="Format.Unknown"/> and <see cref="AlphaMode"/> to <see cref="AlphaMode.Premultiplied"/>.
    /// </summary>
    public static PixelFormat Premultiplied => new(Format.Unknown, AlphaMode.Premultiplied);

    /// <summary>
    /// Initializes a new instance of the <see cref="PixelFormat"/> struct.
    /// </summary>
    /// <param name="format">The <see cref="Format"/> to use.</param>
    /// <param name="alphaMode">A value that specifies whether the alpha channel is using pre-multiplied alpha, straight alpha, whether it should be ignored and considered opaque, or whether it is unknown.</param>
    public PixelFormat(Format format = Format.Unknown, AlphaMode alphaMode = AlphaMode.Unknown)
    {
        this.format = format;
        this.alphaMode = alphaMode;
    }
}
