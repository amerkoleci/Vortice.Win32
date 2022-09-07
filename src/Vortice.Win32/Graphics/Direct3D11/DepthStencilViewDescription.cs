// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Dxgi.Common;

namespace Win32.Graphics.Direct3D11;

public unsafe partial struct DepthStencilViewDescription
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DepthStencilViewDescription"/> struct.
    /// </summary>
    /// <param name="viewDimension">The <see cref="DsvDimension"/></param>
    /// <param name="format">The <see cref="Format"/> to use or <see cref="Format.Unknown"/>.</param>
    /// <param name="mipSlice">The index of the mipmap level to use mip slice.</param>
    /// <param name="firstArraySlice">The index of the first texture to use in an array of textures.</param>
    /// <param name="arraySize">Number of textures in the array.</param>
    /// <param name="flags"></param>
    public DepthStencilViewDescription(
        DsvDimension viewDimension,
        Format format = Format.Unknown,
        uint mipSlice = 0,
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1),
        DsvFlags flags = DsvFlags.None)
    {
        Format = format;
        ViewDimension = viewDimension;
        Flags = flags;
        Anonymous = default;

        switch (viewDimension)
        {
            case DsvDimension.Texture1D:
                Anonymous.Texture1D.MipSlice = mipSlice;
                break;
            case DsvDimension.Texture1DArray:
                Anonymous.Texture1DArray.MipSlice = mipSlice;
                Anonymous.Texture1DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture1DArray.ArraySize = arraySize;
                break;
            case DsvDimension.Texture2D:
                Anonymous.Texture2D.MipSlice = mipSlice;
                break;
            case DsvDimension.Texture2DArray:
                Anonymous.Texture2DArray.MipSlice = mipSlice;
                Anonymous.Texture2DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DArray.ArraySize = arraySize;
                break;
            case DsvDimension.Texture2DMs:
                break;
            case DsvDimension.Texture2DMsArray:
                Anonymous.Texture2DMSArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DMSArray.ArraySize = arraySize;
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DepthStencilViewDescription"/> struct.
    /// </summary>
    /// <param name="texture"></param>
    /// <param name="isArray"></param>
    /// <param name="format"></param>
    /// <param name="mipSlice"></param>
    /// <param name="firstArraySlice"></param>
    /// <param name="arraySize"></param>
    /// <param name="flags"></param>
    public DepthStencilViewDescription(
        ID3D11Texture1D* texture,
        bool isArray,
        Format format = Format.Unknown,
        uint mipSlice = 0,
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1),
        DsvFlags flags = DsvFlags.None)
    {
        ViewDimension = isArray ? DsvDimension.Texture1DArray : DsvDimension.Texture1D;
        Flags = flags;
        Anonymous = default;

        if (format == Format.Unknown
            || (arraySize == unchecked((uint)-1) && DsvDimension.Texture1DArray == ViewDimension))
        {
            Texture1DDescription textureDesc;
            texture->GetDesc(&textureDesc);

            if (format == Format.Unknown)
                format = textureDesc.Format;
            if (arraySize == unchecked((uint)-1))
                arraySize = textureDesc.ArraySize - firstArraySlice;
        }

        Format = format;
        switch (ViewDimension)
        {
            case DsvDimension.Texture1D:
                Anonymous.Texture1D.MipSlice = mipSlice;
                break;
            case DsvDimension.Texture1DArray:
                Anonymous.Texture1DArray.MipSlice = mipSlice;
                Anonymous.Texture1DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture1DArray.ArraySize = arraySize;
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DepthStencilViewDescription"/> struct.
    /// </summary>
    /// <param name="texture"></param>
    /// <param name="viewDimension"></param>
    /// <param name="format"></param>
    /// <param name="mipSlice"></param>
    /// <param name="firstArraySlice"></param>
    /// <param name="arraySize"></param>
    /// <param name="flags"></param>
    public DepthStencilViewDescription(
        ID3D11Texture2D* texture,
        DsvDimension viewDimension,
        Format format = Format.Unknown,
        uint mipSlice = 0,
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1),
        DsvFlags flags = DsvFlags.None) 
    {
        ViewDimension = viewDimension;
        Flags = flags;
        Anonymous = default;

        if (format == Format.Unknown
            || (arraySize == unchecked((uint)-1) && (DsvDimension.Texture2DArray == viewDimension || DsvDimension.Texture2DMsArray == viewDimension)))
        {
            Texture2DDescription textureDesc;
            texture->GetDesc(&textureDesc);

            if (format == Format.Unknown)
                format = textureDesc.Format;
            if (arraySize == unchecked((uint)-1))
                arraySize = textureDesc.ArraySize - firstArraySlice;
        }

        Format = format;
        switch (viewDimension)
        {
            case DsvDimension.Texture2D:
                Anonymous.Texture2D.MipSlice = mipSlice;
                break;
            case DsvDimension.Texture2DArray:
                Anonymous.Texture2DArray.MipSlice = mipSlice;
                Anonymous.Texture2DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DArray.ArraySize = arraySize;
                break;
            case DsvDimension.Texture2DMs:
                break;
            case DsvDimension.Texture2DMsArray:
                Anonymous.Texture2DMSArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DMSArray.ArraySize = arraySize;
                break;
            default:
                break;
        }
    }
}
