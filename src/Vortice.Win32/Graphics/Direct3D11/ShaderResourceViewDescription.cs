// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Xml.Serialization;
using Win32.Graphics.Direct3D;
using Win32.Graphics.Dxgi.Common;

namespace Win32.Graphics.Direct3D11;

public unsafe partial struct ShaderResourceViewDescription
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ShaderResourceViewDescription"/> struct.
    /// </summary>
    /// <param name="viewDimension">The <see cref="SrvDimension"/></param>
    /// <param name="format">The <see cref="Format"/> to use or <see cref="Format.Unknown"/>.</param>
    /// <param name="mostDetailedMip">Index of the most detailed mipmap level to use or first element for <see cref="SrvDimension.Buffer"/> or <see cref="SrvDimension.BufferExtended"/>.</param>
    /// <param name="mipLevels">The maximum number of mipmap levels for the view of the texture or num elements for <see cref="SrvDimension.Buffer"/> or <see cref="SrvDimension.BufferExtended"/>.</param>
    /// <param name="firstArraySlice">The index of the first texture to use in an array of textures or First2DArrayFace for <see cref="SrvDimension.TextureCubeArray"/>. </param>
    /// <param name="arraySize">Number of textures in the array or num cubes for <see cref="SrvDimension.TextureCubeArray"/>. </param>
    /// <param name="flags"><see cref="BufferExtendedSrvFlags"/> for <see cref="SrvDimension.BufferExtended"/>.</param>
    public ShaderResourceViewDescription(
        SrvDimension viewDimension,
        Format format = Format.Unknown,
        uint mostDetailedMip = 0,
        uint mipLevels = unchecked((uint)-1),
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1),
        BufferExtendedSrvFlags flags = BufferExtendedSrvFlags.None)
    {
        Format = format;
        ViewDimension = viewDimension;
        Anonymous = default;

        switch (viewDimension)
        {
            case SrvDimension.Buffer:
                Anonymous.Buffer.FirstElement = mostDetailedMip;
                Anonymous.Buffer.NumElements = mipLevels;
                break;
            case SrvDimension.Texture1D:
                Anonymous.Texture1D.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture1D.MipLevels = mipLevels;
                break;
            case SrvDimension.Texture1DArray:
                Anonymous.Texture1DArray.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture1DArray.MipLevels = mipLevels;
                Anonymous.Texture1DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture1DArray.ArraySize = arraySize;
                break;
            case SrvDimension.Texture2D:
                Anonymous.Texture2D.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture2D.MipLevels = mipLevels;
                break;
            case SrvDimension.Texture2DArray:
                Anonymous.Texture2DArray.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture2DArray.MipLevels = mipLevels;
                Anonymous.Texture2DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DArray.ArraySize = arraySize;
                break;
            case SrvDimension.Texture2DMs:
                break;
            case SrvDimension.Texture2DMsArray:
                Anonymous.Texture2DMSArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DMSArray.ArraySize = arraySize;
                break;
            case SrvDimension.Texture3D:
                Anonymous.Texture3D.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture3D.MipLevels = mipLevels;
                break;
            case SrvDimension.TextureCube:
                Anonymous.TextureCube.MostDetailedMip = mostDetailedMip;
                Anonymous.TextureCube.MipLevels = mipLevels;
                break;
            case SrvDimension.TextureCubeArray:
                Anonymous.TextureCubeArray.MostDetailedMip = mostDetailedMip;
                Anonymous.TextureCubeArray.MipLevels = mipLevels;
                Anonymous.TextureCubeArray.First2DArrayFace = firstArraySlice;
                Anonymous.TextureCubeArray.NumCubes = arraySize;
                break;
            case SrvDimension.BufferExtended:
                Anonymous.BufferEx.FirstElement = mostDetailedMip;
                Anonymous.BufferEx.NumElements = mipLevels;
                BufferEx.Flags = flags;
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ShaderResourceViewDescription"/> struct.
    /// </summary>
    /// <param name="buffer">Unused <see cref="ID3D11Buffer"/> </param>
    /// <param name="format"></param>
    /// <param name="firstElement"></param>
    /// <param name="numElements"></param>
    /// <param name="flags"></param>
    public ShaderResourceViewDescription(
        ID3D11Buffer* buffer,
        Format format,
        uint firstElement,
        uint numElements,
        BufferExtendedSrvFlags flags = BufferExtendedSrvFlags.None)
    {
        Format = format;
        ViewDimension = SrvDimension.BufferExtended;

        Anonymous = default;
        Anonymous.BufferEx.FirstElement = firstElement;
        Anonymous.BufferEx.NumElements = numElements;
        Anonymous.BufferEx.Flags = flags;
    }

    public ShaderResourceViewDescription(
        ID3D11Texture1D* texture,
        bool isArray,
        Format format = Format.Unknown,
        uint mostDetailedMip = 0,
        uint mipLevels = unchecked((uint)-1),
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1))
    {
        ViewDimension = isArray ? SrvDimension.Texture1DArray : SrvDimension.Texture1D;
        if (format == Format.Unknown
            || mipLevels == unchecked((uint)-1)
            || (arraySize == unchecked((uint)-1) && SrvDimension.Texture1DArray == ViewDimension))
        {
            Texture1DDescription textureDesc;
            texture->GetDesc(&textureDesc);

            if (format == Format.Unknown)
                format = textureDesc.Format;
            if (mipLevels == unchecked((uint)-1))
                mipLevels = textureDesc.MipLevels - mostDetailedMip;
            if (arraySize == unchecked((uint)-1))
                arraySize = textureDesc.ArraySize - firstArraySlice;
        }

        Format = format;
        Anonymous = default;

        switch (ViewDimension)
        {
            case SrvDimension.Texture1D:
                Anonymous.Texture1D.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture1D.MipLevels = mipLevels;
                break;
            case SrvDimension.Texture1DArray:
                Anonymous.Texture1DArray.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture1DArray.MipLevels = mipLevels;
                Anonymous.Texture1DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture1DArray.ArraySize = arraySize;
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ShaderResourceViewDescription"/> struct.
    /// </summary>
    /// <param name="texture"></param>
    /// <param name="viewDimension"></param>
    /// <param name="format"></param>
    /// <param name="mostDetailedMip"></param>
    /// <param name="mipLevels"></param>
    /// <param name="firstArraySlice"></param>
    /// <param name="arraySize"></param>
    public ShaderResourceViewDescription(
        ID3D11Texture2D* texture,
        SrvDimension viewDimension,
        Format format = Format.Unknown,
        uint mostDetailedMip = 0,
        uint mipLevels = unchecked((uint)-1),
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1))
    {
        ViewDimension = viewDimension;
        if (format == Format.Unknown
            || (mipLevels == unchecked((uint)-1) && viewDimension != SrvDimension.Texture2DMs && viewDimension != SrvDimension.Texture2DMsArray)
            || (arraySize == unchecked((uint)-1) && (SrvDimension.Texture2DArray == viewDimension || SrvDimension.Texture2DMsArray == viewDimension || SrvDimension.TextureCubeArray == viewDimension)))
        {
            Texture2DDescription textureDesc;
            texture->GetDesc(&textureDesc);

            if (format == Format.Unknown)
                format = textureDesc.Format;
            if (unchecked((uint)-1) == mipLevels)
                mipLevels = textureDesc.MipLevels - mostDetailedMip;
            if (unchecked((uint)-1) == arraySize)
            {
                arraySize = textureDesc.ArraySize - firstArraySlice;
                if (viewDimension == SrvDimension.TextureCubeArray)
                    arraySize /= 6;
            }
        }

        Format = format;
        Anonymous = default;

        switch (viewDimension)
        {
            case SrvDimension.Texture2D:
                Anonymous.Texture2D.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture2D.MipLevels = mipLevels;
                break;
            case SrvDimension.Texture2DArray:
                Anonymous.Texture2DArray.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture2DArray.MipLevels = mipLevels;
                Anonymous.Texture2DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DArray.ArraySize = arraySize;
                break;
            case SrvDimension.Texture2DMs:
                break;
            case SrvDimension.Texture2DMsArray:
                Anonymous.Texture2DMSArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DMSArray.ArraySize = arraySize;
                break;
            case SrvDimension.TextureCube:
                Anonymous.TextureCube.MostDetailedMip = mostDetailedMip;
                Anonymous.TextureCube.MipLevels = mipLevels;
                break;
            case SrvDimension.TextureCubeArray:
                Anonymous.TextureCubeArray.MostDetailedMip = mostDetailedMip;
                Anonymous.TextureCubeArray.MipLevels = mipLevels;
                Anonymous.TextureCubeArray.First2DArrayFace = firstArraySlice;
                Anonymous.TextureCubeArray.NumCubes = arraySize;
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ShaderResourceViewDescription"/> struct.
    /// </summary>
    /// <param name="texture"></param>
    /// <param name="format"></param>
    /// <param name="mostDetailedMip"></param>
    /// <param name="mipLevels"></param>
    public ShaderResourceViewDescription(
        ID3D11Texture3D* texture,
        Format format = Format.Unknown,
        uint mostDetailedMip = 0,
        uint mipLevels = unchecked((uint)-1))
    {
        ViewDimension = SrvDimension.Texture3D;
        if (format == Format.Unknown || mipLevels == unchecked((uint)-1))
        {
            Texture3DDescription textureDesc;
            texture->GetDesc(&textureDesc);

            if (format == Format.Unknown)
                format = textureDesc.Format;
            if (mipLevels == unchecked((uint)-1))
                mipLevels = textureDesc.MipLevels - mostDetailedMip;
        }

        Format = format;
        Anonymous = default;

        Anonymous.Texture3D.MostDetailedMip = mostDetailedMip;
        Anonymous.Texture3D.MipLevels = mipLevels;
    }
}
