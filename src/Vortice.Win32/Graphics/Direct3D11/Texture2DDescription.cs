// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Dxgi.Common;
using static Win32.Graphics.Direct3D11.Apis;

namespace Win32.Graphics.Direct3D11;

public partial struct Texture2DDescription
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Texture2DDescription"/> struct.
    /// </summary>
    /// <param name="format">Texture format.</param>
    /// <param name="width">Texture width (in texels).</param>
    /// <param name="height">Texture height (in texels).</param>
    /// <param name="arraySize">Number of textures in the array.</param>
    /// <param name="mipLevels">The maximum number of mipmap levels in the texture.</param>
    /// <param name="bindFlags">The <see cref="Direct3D11.BindFlags"/> for binding to pipeline stages.</param>
    /// <param name="usage">Value that identifies how the texture is to be read from and written to.</param>
    /// <param name="cpuAccessFlags">The <see cref="CpuAccessFlags"/> to specify the types of CPU access allowed.</param>
    /// <param name="sampleCount">Specifies multisampling parameters for the texture.</param>
    /// <param name="sampleQuality">Specifies multisampling parameters for the texture.</param>
    /// <param name="miscFlags">The <see cref="ResourceMiscFlags"/> that identify other, less common resource options. </param>
    public Texture2DDescription(
        Format format,
        uint width,
        uint height,
        uint arraySize = 1,
        uint mipLevels = 0,
        BindFlags bindFlags = BindFlags.ShaderResource,
        Usage usage = Usage.Default,
        CpuAccessFlags cpuAccessFlags = CpuAccessFlags.None,
        uint sampleCount = 1,
        uint sampleQuality = 0,
        ResourceMiscFlags miscFlags = ResourceMiscFlags.None)
    {
        if (format == Format.Unknown)
            throw new ArgumentException($"format need to be valid", nameof(format));

        if (width < 1 || width > D3D11_REQ_TEXTURE2D_U_OR_V_DIMENSION)
            throw new ArgumentException($"Width need to be in range 1-{D3D11_REQ_TEXTURE2D_U_OR_V_DIMENSION}", nameof(width));

        if (height < 1 || height > D3D11_REQ_TEXTURE2D_U_OR_V_DIMENSION)
            throw new ArgumentException($"Height need to be in range 1-{D3D11_REQ_TEXTURE2D_U_OR_V_DIMENSION}", nameof(height));

        if (arraySize < 1 || arraySize > D3D11_REQ_TEXTURE2D_ARRAY_AXIS_DIMENSION)
            throw new ArgumentException($"Array size need to be in range 1-{D3D11_REQ_TEXTURE2D_ARRAY_AXIS_DIMENSION}", nameof(arraySize));

        Width = width;
        Height = height;
        MipLevels = mipLevels;
        ArraySize = arraySize;
        Format = format;
        SampleDesc = new(sampleCount, sampleQuality);
        Usage = usage;
        BindFlags = bindFlags;
        CPUAccessFlags = cpuAccessFlags;
        MiscFlags = miscFlags;
    }
}
