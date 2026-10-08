// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.DXGICommon;
using static Vortice.Win32.Graphics.D3D11;

namespace Vortice.Win32.Graphics;

public unsafe partial struct D3D11_RENDER_TARGET_VIEW_DESC
{
    /// <summary>
    /// Initializes a new instance of the <see cref="D3D11_RENDER_TARGET_VIEW_DESC"/> struct.
    /// </summary>
    /// <param name="viewDimension">The <see cref="D3D11_RTV_DIMENSION"/></param>
    /// <param name="format">The <see cref="DXGI_FORMAT"/> to use or <see cref="DXGI_FORMAT_UNKNOWN"/>.</param>
    /// <param name="mipSlice">The index of the mipmap level to use mip slice. or first element for <see cref="D3D11_RTV_DIMENSION_BUFFER"/>.</param>
    /// <param name="firstArraySlice">The index of the first texture to use in an array of textures or NumElements for <see cref="D3D11_RTV_DIMENSION_BUFFER"/>, FirstWSlice for <see cref="D3D11_RTV_DIMENSION_TEXTURE3D"/>.</param>
    /// <param name="arraySize">Number of textures in the array or WSize for <see cref="D3D11_RTV_DIMENSION_TEXTURE3D"/>. </param>
    public D3D11_RENDER_TARGET_VIEW_DESC(
        D3D11_RTV_DIMENSION viewDimension,
        DXGI_FORMAT format = DXGI_FORMAT_UNKNOWN,
        uint mipSlice = 0,
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1))
    {
        Format = format;
        ViewDimension = viewDimension;
        Anonymous = default;

        switch (viewDimension)
        {
            case D3D11_RTV_DIMENSION_BUFFER:
                Buffer.FirstElement = mipSlice;
                Buffer.NumElements = firstArraySlice;
                break;
            case D3D11_RTV_DIMENSION_TEXTURE1D:
                Texture1D.MipSlice = mipSlice;
                break;
            case D3D11_RTV_DIMENSION_TEXTURE1DARRAY:
                Texture1DArray.MipSlice = mipSlice;
                Texture1DArray.FirstArraySlice = firstArraySlice;
                Texture1DArray.ArraySize = arraySize;
                break;
            case D3D11_RTV_DIMENSION_TEXTURE2D:
                Texture2D.MipSlice = mipSlice;
                break;
            case D3D11_RTV_DIMENSION_TEXTURE2DARRAY:
                Texture2DArray.MipSlice = mipSlice;
                Texture2DArray.FirstArraySlice = firstArraySlice;
                Texture2DArray.ArraySize = arraySize;
                break;
            case D3D11_RTV_DIMENSION_TEXTURE2DMS:
                break;
            case D3D11_RTV_DIMENSION_TEXTURE2DMSARRAY:
                Texture2DMSArray.FirstArraySlice = firstArraySlice;
                Texture2DMSArray.ArraySize = arraySize;
                break;
            case D3D11_RTV_DIMENSION_TEXTURE3D:
                Texture3D.MipSlice = mipSlice;
                Texture3D.FirstWSlice = firstArraySlice;
                Texture3D.WSize = arraySize;
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="D3D11_RENDER_TARGET_VIEW_DESC"/> struct.
    /// </summary>
    /// <param name="buffer">Unused <see cref="ID3D11Buffer"/> </param>
    /// <param name="format"></param>
    /// <param name="firstElement"></param>
    /// <param name="numElements"></param>
    public D3D11_RENDER_TARGET_VIEW_DESC(
        ID3D11Buffer* buffer,
        DXGI_FORMAT format,
        uint firstElement,
        uint numElements)
    {
        Format = format;
        ViewDimension = D3D11_RTV_DIMENSION_BUFFER;
        Anonymous = default;

        Anonymous.Buffer.FirstElement = firstElement;
        Anonymous.Buffer.NumElements = numElements;
    }

    public D3D11_RENDER_TARGET_VIEW_DESC(
        ID3D11Texture1D* texture,
        bool isArray,
        DXGI_FORMAT format = DXGI_FORMAT_UNKNOWN,
        uint mipSlice = 0,
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1))
    {
        ViewDimension = isArray ? D3D11_RTV_DIMENSION_TEXTURE1DARRAY : D3D11_RTV_DIMENSION_TEXTURE1D;
        if (format == DXGI_FORMAT_UNKNOWN
            || (arraySize == unchecked((uint)-1) && D3D11_RTV_DIMENSION_TEXTURE1DARRAY == ViewDimension))
        {
            D3D11_TEXTURE1D_DESC textureDesc;
            texture->GetDesc(&textureDesc);

            if (format == DXGI_FORMAT_UNKNOWN)
                format = textureDesc.Format;
            if (arraySize == unchecked((uint)-1))
                arraySize = textureDesc.ArraySize - firstArraySlice;
        }

        Format = format;
        Anonymous = default;

        switch (ViewDimension)
        {
            case D3D11_RTV_DIMENSION_TEXTURE1D:
                Anonymous.Texture1D.MipSlice = mipSlice;
                break;
            case D3D11_RTV_DIMENSION_TEXTURE1DARRAY:
                Anonymous.Texture1DArray.MipSlice = mipSlice;
                Anonymous.Texture1DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture1DArray.ArraySize = arraySize;
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="D3D11_RENDER_TARGET_VIEW_DESC"/> struct.
    /// </summary>
    /// <param name="texture"></param>
    /// <param name="viewDimension"></param>
    /// <param name="format"></param>
    /// <param name="mipSlice"></param>
    /// <param name="firstArraySlice"></param>
    /// <param name="arraySize"></param>
    public D3D11_RENDER_TARGET_VIEW_DESC(
        ID3D11Texture2D* texture,
        D3D11_RTV_DIMENSION viewDimension,
        DXGI_FORMAT format = DXGI_FORMAT_UNKNOWN,
        uint mipSlice = 0,
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1))
    {
        ViewDimension = viewDimension;
        if (format == DXGI_FORMAT_UNKNOWN
            || (arraySize == unchecked((uint)-1) && (D3D11_RTV_DIMENSION_TEXTURE2DARRAY == viewDimension || D3D11_RTV_DIMENSION_TEXTURE2DMSARRAY == viewDimension)))
        {
            D3D11_TEXTURE2D_DESC textureDesc;
            texture->GetDesc(&textureDesc);

            if (format == DXGI_FORMAT_UNKNOWN)
                format = textureDesc.Format;
            if (arraySize == unchecked((uint)-1))
            {
                arraySize = textureDesc.ArraySize - firstArraySlice;
            }
        }

        Format = format;
        Anonymous = default;
        switch (viewDimension)
        {
            case D3D11_RTV_DIMENSION_TEXTURE2D:
                Anonymous.Texture2D.MipSlice = mipSlice;
                break;
            case D3D11_RTV_DIMENSION_TEXTURE2DARRAY:
                Anonymous.Texture2DArray.MipSlice = mipSlice;
                Anonymous.Texture2DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DArray.ArraySize = arraySize;
                break;
            case D3D11_RTV_DIMENSION_TEXTURE2DMS:
                break;
            case D3D11_RTV_DIMENSION_TEXTURE2DMSARRAY:
                Anonymous.Texture2DMSArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DMSArray.ArraySize = arraySize;
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="D3D11_RENDER_TARGET_VIEW_DESC"/> struct.
    /// </summary>
    /// <param name="texture"></param>
    /// <param name="format"></param>
    /// <param name="mipSlice"></param>
    /// <param name="firstWSlice"></param>
    /// <param name="wSize"></param>
    public D3D11_RENDER_TARGET_VIEW_DESC(
        ID3D11Texture3D* texture,
        DXGI_FORMAT format = DXGI_FORMAT_UNKNOWN,
        uint mipSlice = 0,
        uint firstWSlice = 0,
        uint wSize = unchecked((uint)-1))
    {
        ViewDimension = D3D11_RTV_DIMENSION_TEXTURE3D;
        if (format == DXGI_FORMAT_UNKNOWN || wSize == unchecked((uint)-1))
        {
            D3D11_TEXTURE3D_DESC textureDesc;
            texture->GetDesc(&textureDesc);

            if (format == DXGI_FORMAT_UNKNOWN)
                format = textureDesc.Format;
            if (wSize == unchecked((uint)-1))
                wSize = textureDesc.Depth - firstWSlice;
        }

        Format = format;
        Anonymous = default;

        Anonymous.Texture3D.MipSlice = mipSlice;
        Anonymous.Texture3D.FirstWSlice = firstWSlice;
        Anonymous.Texture3D.WSize = wSize;
    }
}
