// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.DXGICommon;
using static Vortice.Win32.Graphics.D3D11;

namespace Vortice.Win32.Graphics;

public partial struct D3D11_TEXTURE3D_DESC1
{
    /// <summary>
    /// Initializes a new instance of the <see cref="D3D11_TEXTURE3D_DESC1"/> struct.
    /// </summary>
    /// <param name="width">Texture width (in texels).</param>
    /// <param name="height">Texture height (in texels).</param>
    /// <param name="depth">Texture depth (in texels).</param>
    /// <param name="format">Texture format.</param>
    /// <param name="mipLevels">The maximum number of mipmap levels in the texture.</param>
    /// <param name="bindFlags">The <see cref="D3D11_BIND_FLAG"/> for binding to pipeline stages.</param>
    /// <param name="usage">Value that identifies how the texture is to be read from and written to.</param>
    /// <param name="cpuAccessFlags">The <see cref="D3D11_CPU_ACCESS_FLAG"/> to specify the types of CPU access allowed.</param>
    /// <param name="miscFlags">The <see cref="D3D11_RESOURCE_MISC_FLAG"/> that identify other, less common resource options. </param>
    /// <param name="textureLayout">A <see cref="D3D11_TEXTURE_LAYOUT"/> value that identifies the layout of the texture.</param>
    public D3D11_TEXTURE3D_DESC1(
        DXGI_FORMAT format,
        uint width,
        uint height,
        uint depth,
        uint mipLevels = 0,
        D3D11_BIND_FLAG bindFlags = D3D11_BIND_SHADER_RESOURCE,
        D3D11_USAGE usage = D3D11_USAGE_DEFAULT,
        D3D11_CPU_ACCESS_FLAG cpuAccessFlags = 0,
        D3D11_RESOURCE_MISC_FLAG miscFlags = 0,
        D3D11_TEXTURE_LAYOUT textureLayout = D3D11_TEXTURE_LAYOUT_UNDEFINED)
    {
        if (format == DXGI_FORMAT_UNKNOWN)
            throw new ArgumentException($"format need to be valid", nameof(format));

        if (width < 1 || width > D3D11_REQ_TEXTURE3D_U_V_OR_W_DIMENSION)
            throw new ArgumentException($"Width need to be in range 1-{D3D11_REQ_TEXTURE3D_U_V_OR_W_DIMENSION}", nameof(width));

        if (height < 1 || height > D3D11_REQ_TEXTURE3D_U_V_OR_W_DIMENSION)
            throw new ArgumentException($"Height need to be in range 1-{D3D11_REQ_TEXTURE3D_U_V_OR_W_DIMENSION}", nameof(height));

        if (depth < 1 || depth > D3D11_REQ_TEXTURE3D_U_V_OR_W_DIMENSION)
            throw new ArgumentException($"Depth need to be in range 1-{D3D11_REQ_TEXTURE3D_U_V_OR_W_DIMENSION}", nameof(depth));

        Width = width;
        Height = height;
        Depth = depth;
        MipLevels = mipLevels;
        Format = format;
        Usage = usage;
        BindFlags = bindFlags;
        CPUAccessFlags = cpuAccessFlags;
        MiscFlags = miscFlags;
        TextureLayout = textureLayout;
    }
}
