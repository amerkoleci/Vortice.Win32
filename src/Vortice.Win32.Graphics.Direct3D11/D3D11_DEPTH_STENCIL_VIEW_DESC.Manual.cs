// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.DXGICommon;
using static Vortice.Win32.Graphics.D3D11;

namespace Vortice.Win32.Graphics;

public unsafe partial struct D3D11_DEPTH_STENCIL_VIEW_DESC
{
    /// <summary>
    /// Initializes a new instance of the <see cref="D3D11_DEPTH_STENCIL_DESC"/> struct.
    /// </summary>
    /// <param name="viewDimension">The <see cref="D3D11_DSV_DIMENSION"/></param>
    /// <param name="format">The <see cref="DXGI_FORMAT"/> to use or <see cref="DXGI_FORMAT_UNKNOWN"/>.</param>
    /// <param name="mipSlice">The index of the mipmap level to use mip slice.</param>
    /// <param name="firstArraySlice">The index of the first texture to use in an array of textures.</param>
    /// <param name="arraySize">Number of textures in the array.</param>
    /// <param name="flags"></param>
    public D3D11_DEPTH_STENCIL_VIEW_DESC(
        D3D11_DSV_DIMENSION viewDimension,
        DXGI_FORMAT format = DXGI_FORMAT_UNKNOWN,
        uint mipSlice = 0,
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1),
        D3D11_DSV_FLAG flags = 0)
    {
        Format = format;
        ViewDimension = viewDimension;
        Flags = flags;
        Anonymous = default;

        switch (viewDimension)
        {
            case D3D11_DSV_DIMENSION_TEXTURE1D:
                Anonymous.Texture1D.MipSlice = mipSlice;
                break;
            case D3D11_DSV_DIMENSION_TEXTURE1DARRAY:
                Anonymous.Texture1DArray.MipSlice = mipSlice;
                Anonymous.Texture1DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture1DArray.ArraySize = arraySize;
                break;
            case D3D11_DSV_DIMENSION_TEXTURE2D:
                Anonymous.Texture2D.MipSlice = mipSlice;
                break;
            case D3D11_DSV_DIMENSION_TEXTURE2DARRAY:
                Anonymous.Texture2DArray.MipSlice = mipSlice;
                Anonymous.Texture2DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DArray.ArraySize = arraySize;
                break;
            case D3D11_DSV_DIMENSION_TEXTURE2DMS:
                break;
            case D3D11_DSV_DIMENSION_TEXTURE2DMSARRAY:
                Anonymous.Texture2DMSArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DMSArray.ArraySize = arraySize;
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="D3D11_DEPTH_STENCIL_VIEW_DESC"/> struct.
    /// </summary>
    /// <param name="texture"></param>
    /// <param name="isArray"></param>
    /// <param name="format"></param>
    /// <param name="mipSlice"></param>
    /// <param name="firstArraySlice"></param>
    /// <param name="arraySize"></param>
    /// <param name="flags"></param>
    public D3D11_DEPTH_STENCIL_VIEW_DESC(
        ID3D11Texture1D* texture,
        bool isArray,
        DXGI_FORMAT format = DXGI_FORMAT_UNKNOWN,
        uint mipSlice = 0,
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1),
        D3D11_DSV_FLAG flags = 0)
    {
        ViewDimension = isArray ? D3D11_DSV_DIMENSION_TEXTURE1DARRAY : D3D11_DSV_DIMENSION_TEXTURE1D;
        Flags = flags;
        Anonymous = default;

        if (format == DXGI_FORMAT_UNKNOWN
            || (arraySize == unchecked((uint)-1) && D3D11_DSV_DIMENSION_TEXTURE1DARRAY == ViewDimension))
        {
            D3D11_TEXTURE1D_DESC textureDesc;
            texture->GetDesc(&textureDesc);

            if (format == DXGI_FORMAT_UNKNOWN)
                format = textureDesc.Format;
            if (arraySize == unchecked((uint)-1))
                arraySize = textureDesc.ArraySize - firstArraySlice;
        }

        Format = format;
        switch (ViewDimension)
        {
            case D3D11_DSV_DIMENSION_TEXTURE1D:
                Anonymous.Texture1D.MipSlice = mipSlice;
                break;
            case D3D11_DSV_DIMENSION_TEXTURE1DARRAY:
                Anonymous.Texture1DArray.MipSlice = mipSlice;
                Anonymous.Texture1DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture1DArray.ArraySize = arraySize;
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="D3D11_DEPTH_STENCIL_VIEW_DESC"/> struct.
    /// </summary>
    /// <param name="texture"></param>
    /// <param name="viewDimension"></param>
    /// <param name="format"></param>
    /// <param name="mipSlice"></param>
    /// <param name="firstArraySlice"></param>
    /// <param name="arraySize"></param>
    /// <param name="flags"></param>
    public D3D11_DEPTH_STENCIL_VIEW_DESC(
        ID3D11Texture2D* texture,
        D3D11_DSV_DIMENSION viewDimension,
        DXGI_FORMAT format = DXGI_FORMAT_UNKNOWN,
        uint mipSlice = 0,
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1),
        D3D11_DSV_FLAG flags = 0) 
    {
        ViewDimension = viewDimension;
        Flags = flags;
        Anonymous = default;

        if (format == DXGI_FORMAT_UNKNOWN
            || (arraySize == unchecked((uint)-1) && (D3D11_DSV_DIMENSION_TEXTURE2DARRAY == viewDimension || D3D11_DSV_DIMENSION_TEXTURE2DMSARRAY == viewDimension)))
        {
            D3D11_TEXTURE2D_DESC textureDesc;
            texture->GetDesc(&textureDesc);

            if (format == DXGI_FORMAT_UNKNOWN)
                format = textureDesc.Format;
            if (arraySize == unchecked((uint)-1))
                arraySize = textureDesc.ArraySize - firstArraySlice;
        }

        Format = format;
        switch (viewDimension)
        {
            case D3D11_DSV_DIMENSION_TEXTURE2D:
                Anonymous.Texture2D.MipSlice = mipSlice;
                break;
            case D3D11_DSV_DIMENSION_TEXTURE2DARRAY:
                Anonymous.Texture2DArray.MipSlice = mipSlice;
                Anonymous.Texture2DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DArray.ArraySize = arraySize;
                break;
            case D3D11_DSV_DIMENSION_TEXTURE2DMS:
                break;
            case D3D11_DSV_DIMENSION_TEXTURE2DMSARRAY:
                Anonymous.Texture2DMSArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DMSArray.ArraySize = arraySize;
                break;
            default:
                break;
        }
    }
}
