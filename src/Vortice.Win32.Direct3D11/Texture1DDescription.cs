// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Dxgi.Common;
using static Win32.Graphics.Direct3D11.Apis;

namespace Win32.Graphics.Direct3D11;

public partial struct Texture1DDescription
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Texture1DDescription"/> struct.
    /// </summary>
    /// <param name="format">Texture format.</param>
    /// <param name="width">Texture width (in texels).</param>
    /// <param name="arraySize">Number of textures in the array.</param>
    /// <param name="mipLevels">The maximum number of mipmap levels in the texture.</param>
    /// <param name="bindFlags">The <see cref="Direct3D11.BindFlags"/> for binding to pipeline stages.</param>
    /// <param name="usage">Value that identifies how the texture is to be read from and written to.</param>
    /// <param name="cpuAccessFlags">The <see cref="Direct3D11.CpuAccessFlags"/> to specify the types of CPU access allowed.</param>
    /// <param name="miscFlags">The <see cref="ResourceMiscFlags"/> that identify other, less common resource options. </param>
    public Texture1DDescription(
        Format format,
        uint width,
        uint arraySize = 1,
        uint mipLevels = 0,
        BindFlags bindFlags = BindFlags.ShaderResource,
        Usage usage = Usage.Default,
        CpuAccessFlags cpuAccessFlags = CpuAccessFlags.None,
        ResourceMiscFlags miscFlags = ResourceMiscFlags.None)
    {
        if (format == Format.Unknown)
            throw new ArgumentException($"format need to be valid", nameof(format));

        if (width < 1 || width > D3D11_REQ_TEXTURE1D_U_DIMENSION)
            throw new ArgumentException($"Width need to be in range 1-{D3D11_REQ_TEXTURE1D_U_DIMENSION}", nameof(width));

        if (arraySize < 1 || arraySize > D3D11_REQ_TEXTURE1D_ARRAY_AXIS_DIMENSION)
            throw new ArgumentException($"Array size need to be in range 1-{D3D11_REQ_TEXTURE1D_ARRAY_AXIS_DIMENSION}", nameof(arraySize));

        Width = width;
        MipLevels = mipLevels;
        ArraySize = arraySize;
        Format = format;
        Usage = usage;
        BindFlags = bindFlags;
        CPUAccessFlags = cpuAccessFlags;
        MiscFlags = miscFlags;
    }
}
