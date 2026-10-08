// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.DXGICommon;
using static Vortice.Win32.Graphics.D3D;
using static Vortice.Win32.Graphics.D3D11;

namespace Vortice.Win32.Graphics;

public unsafe partial struct D3D11_SHADER_RESOURCE_VIEW_DESC 
{
    /// <summary>
    /// Initializes a new instance of the <see cref="D3D11_SHADER_RESOURCE_VIEW_DESC"/> struct.
    /// </summary>
    /// <param name="viewDimension">The <see cref="SrvDimension"/></param>
    /// <param name="format">The <see cref="Format"/> to use or <see cref="Format.Unknown"/>.</param>
    /// <param name="mostDetailedMip">Index of the most detailed mipmap level to use or first element for <see cref="D3D11_SRV_DIMENSION_BUFFER"/> or <see cref="D3D11_SRV_DIMENSION_BUFFEREX"/>.</param>
    /// <param name="mipLevels">The maximum number of mipmap levels for the view of the texture or num elements for <see cref="D3D11_SRV_DIMENSION_BUFFER"/> or <see cref="D3D11_SRV_DIMENSION_BUFFEREX"/>.</param>
    /// <param name="firstArraySlice">The index of the first texture to use in an array of textures or First2DArrayFace for <see cref="D3D11_SRV_DIMENSION_TEXTURECUBEARRAY"/>. </param>
    /// <param name="arraySize">Number of textures in the array or num cubes for <see cref="D3D11_SRV_DIMENSION_TEXTURECUBEARRAY"/>. </param>
    /// <param name="flags"><see cref="D3D11_BUFFEREX_SRV_FLAG"/> for <see cref="D3D11_SRV_DIMENSION_BUFFEREX"/>.</param>
    public D3D11_SHADER_RESOURCE_VIEW_DESC(
        D3D_SRV_DIMENSION viewDimension,
        DXGI_FORMAT format = DXGI_FORMAT_UNKNOWN,
        uint mostDetailedMip = 0,
        uint mipLevels = unchecked((uint)-1),
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1),
        D3D11_BUFFEREX_SRV_FLAG flags = 0)
    {
        Format = format;
        ViewDimension = viewDimension;
        Anonymous = default;

        switch (viewDimension)
        {
            case D3D_SRV_DIMENSION_BUFFER:
                Anonymous.Buffer.FirstElement = mostDetailedMip;
                Anonymous.Buffer.NumElements = mipLevels;
                break;
            case D3D_SRV_DIMENSION_TEXTURE1D:
                Anonymous.Texture1D.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture1D.MipLevels = mipLevels;
                break;
            case D3D_SRV_DIMENSION_TEXTURE1DARRAY:
                Anonymous.Texture1DArray.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture1DArray.MipLevels = mipLevels;
                Anonymous.Texture1DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture1DArray.ArraySize = arraySize;
                break;
            case D3D_SRV_DIMENSION_TEXTURE2D:
                Anonymous.Texture2D.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture2D.MipLevels = mipLevels;
                break;
            case D3D_SRV_DIMENSION_TEXTURE2DARRAY:
                Anonymous.Texture2DArray.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture2DArray.MipLevels = mipLevels;
                Anonymous.Texture2DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DArray.ArraySize = arraySize;
                break;
            case D3D_SRV_DIMENSION_TEXTURE2DMS:
                break;
            case D3D_SRV_DIMENSION_TEXTURE2DMSARRAY:
                Anonymous.Texture2DMSArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DMSArray.ArraySize = arraySize;
                break;
            case D3D_SRV_DIMENSION_TEXTURE3D:
                Anonymous.Texture3D.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture3D.MipLevels = mipLevels;
                break;
            case D3D_SRV_DIMENSION_TEXTURECUBE:
                Anonymous.TextureCube.MostDetailedMip = mostDetailedMip;
                Anonymous.TextureCube.MipLevels = mipLevels;
                break;
            case D3D_SRV_DIMENSION_TEXTURECUBEARRAY:
                Anonymous.TextureCubeArray.MostDetailedMip = mostDetailedMip;
                Anonymous.TextureCubeArray.MipLevels = mipLevels;
                Anonymous.TextureCubeArray.First2DArrayFace = firstArraySlice;
                Anonymous.TextureCubeArray.NumCubes = arraySize;
                break;
            case D3D_SRV_DIMENSION_BUFFEREX:
                Anonymous.BufferEx.FirstElement = mostDetailedMip;
                Anonymous.BufferEx.NumElements = mipLevels;
                Anonymous.BufferEx.Flags = flags;
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="D3D11_SHADER_RESOURCE_VIEW_DESC"/> struct.
    /// </summary>
    /// <param name="buffer">Unused <see cref="ID3D11Buffer"/> </param>
    /// <param name="format"></param>
    /// <param name="firstElement"></param>
    /// <param name="numElements"></param>
    /// <param name="flags"></param>
    public D3D11_SHADER_RESOURCE_VIEW_DESC(
        ID3D11Buffer* buffer,
        DXGI_FORMAT format,
        uint firstElement,
        uint numElements,
        D3D11_BUFFEREX_SRV_FLAG flags = 0)
    {
        Format = format;
        ViewDimension = D3D_SRV_DIMENSION_BUFFEREX;

        Anonymous = default;
        Anonymous.BufferEx.FirstElement = firstElement;
        Anonymous.BufferEx.NumElements = numElements;
        Anonymous.BufferEx.Flags = flags;
    }

    public D3D11_SHADER_RESOURCE_VIEW_DESC(
        ID3D11Texture1D* texture,
        bool isArray,
        DXGI_FORMAT format = DXGI_FORMAT_UNKNOWN,
        uint mostDetailedMip = 0,
        uint mipLevels = unchecked((uint)-1),
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1))
    {
        ViewDimension = isArray ? D3D_SRV_DIMENSION_TEXTURE1DARRAY : D3D_SRV_DIMENSION_TEXTURE1D;
        if (format == DXGI_FORMAT_UNKNOWN
            || mipLevels == unchecked((uint)-1)
            || (arraySize == unchecked((uint)-1) && D3D_SRV_DIMENSION_TEXTURE1DARRAY == ViewDimension))
        {
            D3D11_TEXTURE1D_DESC textureDesc;
            texture->GetDesc(&textureDesc);

            if (format == DXGI_FORMAT_UNKNOWN)
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
            case D3D_SRV_DIMENSION_TEXTURE1D:
                Anonymous.Texture1D.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture1D.MipLevels = mipLevels;
                break;
            case D3D_SRV_DIMENSION_TEXTURE1DARRAY:
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
    /// Initializes a new instance of the <see cref="D3D11_SHADER_RESOURCE_VIEW_DESC"/> struct.
    /// </summary>
    /// <param name="texture"></param>
    /// <param name="viewDimension"></param>
    /// <param name="format"></param>
    /// <param name="mostDetailedMip"></param>
    /// <param name="mipLevels"></param>
    /// <param name="firstArraySlice"></param>
    /// <param name="arraySize"></param>
    public D3D11_SHADER_RESOURCE_VIEW_DESC(
        ID3D11Texture2D* texture,
        D3D_SRV_DIMENSION viewDimension,
        DXGI_FORMAT format = DXGI_FORMAT_UNKNOWN,
        uint mostDetailedMip = 0,
        uint mipLevels = unchecked((uint)-1),
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1))
    {
        ViewDimension = viewDimension;
        if (format == DXGI_FORMAT_UNKNOWN
            || (mipLevels == unchecked((uint)-1) && viewDimension != D3D_SRV_DIMENSION_TEXTURE2DMS && viewDimension != D3D_SRV_DIMENSION_TEXTURE2DMSARRAY)
            || (arraySize == unchecked((uint)-1) && (D3D_SRV_DIMENSION_TEXTURE2DARRAY == viewDimension || D3D_SRV_DIMENSION_TEXTURE2DMSARRAY == viewDimension || D3D_SRV_DIMENSION_TEXTURECUBEARRAY == viewDimension)))
        {
            D3D11_TEXTURE2D_DESC textureDesc;
            texture->GetDesc(&textureDesc);

            if (format == DXGI_FORMAT_UNKNOWN)
                format = textureDesc.Format;
            if (unchecked((uint)-1) == mipLevels)
                mipLevels = textureDesc.MipLevels - mostDetailedMip;
            if (unchecked((uint)-1) == arraySize)
            {
                arraySize = textureDesc.ArraySize - firstArraySlice;
                if (viewDimension == D3D_SRV_DIMENSION_TEXTURECUBEARRAY)
                    arraySize /= 6;
            }
        }

        Format = format;
        Anonymous = default;

        switch (viewDimension)
        {
            case D3D_SRV_DIMENSION_TEXTURE2D:
                Anonymous.Texture2D.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture2D.MipLevels = mipLevels;
                break;
            case D3D_SRV_DIMENSION_TEXTURE2DARRAY:
                Anonymous.Texture2DArray.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture2DArray.MipLevels = mipLevels;
                Anonymous.Texture2DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DArray.ArraySize = arraySize;
                break;
            case D3D_SRV_DIMENSION_TEXTURE2DMS:
                break;
            case D3D_SRV_DIMENSION_TEXTURE2DMSARRAY:
                Anonymous.Texture2DMSArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DMSArray.ArraySize = arraySize;
                break;
            case D3D_SRV_DIMENSION_TEXTURECUBE:
                Anonymous.TextureCube.MostDetailedMip = mostDetailedMip;
                Anonymous.TextureCube.MipLevels = mipLevels;
                break;
            case D3D_SRV_DIMENSION_TEXTURECUBEARRAY:
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
    /// Initializes a new instance of the <see cref="D3D11_SHADER_RESOURCE_VIEW_DESC"/> struct.
    /// </summary>
    /// <param name="texture"></param>
    /// <param name="format"></param>
    /// <param name="mostDetailedMip"></param>
    /// <param name="mipLevels"></param>
    public D3D11_SHADER_RESOURCE_VIEW_DESC(
        ID3D11Texture3D* texture,
        DXGI_FORMAT format = DXGI_FORMAT_UNKNOWN,
        uint mostDetailedMip = 0,
        uint mipLevels = unchecked((uint)-1))
    {
        ViewDimension = D3D_SRV_DIMENSION_TEXTURE3D;
        if (format == DXGI_FORMAT_UNKNOWN || mipLevels == unchecked((uint)-1))
        {
            D3D11_TEXTURE3D_DESC textureDesc;
            texture->GetDesc(&textureDesc);

            if (format == DXGI_FORMAT_UNKNOWN)
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
