// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.
using static Vortice.Win32.Graphics.DXGICommon;
using static Vortice.Win32.Graphics.D3D11;

namespace Vortice.Win32.Graphics;

public unsafe partial struct D3D11_UNORDERED_ACCESS_VIEW_DESC
{
    /// <summary>
    /// Initializes a new instance of the <see cref="D3D11_UNORDERED_ACCESS_VIEW_DESC"/> struct.
    /// </summary>
    /// <param name="viewDimension">The <see cref="D3D11_UAV_DIMENSION"/></param>
    /// <param name="format">The <see cref="DXGI_FORMAT"/> to use or <see cref="DXGI_FORMAT_UNKNOWN"/>.</param>
    /// <param name="mipSlice">The index of the mipmap level to use mip slice or FirstElement for BUFFER.</param>
    /// <param name="firstArraySlice">The index of the first texture to use in an array of textures or NumElements for BUFFER or FirstWSlice for TEXTURE3D.</param>
    /// <param name="arraySize">Number of textures in the array or WSize for TEXTURE3D.</param>
    /// <param name="flags"><see cref="D3D11_BUFFER_UAV_FLAG"/> options flags for the resource.</param>
    public D3D11_UNORDERED_ACCESS_VIEW_DESC(
        D3D11_UAV_DIMENSION viewDimension,
        DXGI_FORMAT format = DXGI_FORMAT_UNKNOWN,
        uint mipSlice = 0,
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1),
        D3D11_BUFFER_UAV_FLAG flags = 0)
    {
        Format = format;
        ViewDimension = viewDimension;
        Anonymous = default;

        switch (viewDimension)
        {
            case D3D11_UAV_DIMENSION_BUFFER:
                Anonymous.Buffer.FirstElement = mipSlice;
                Anonymous.Buffer.NumElements = firstArraySlice;
                Anonymous.Buffer.Flags = flags;
                break;
            case D3D11_UAV_DIMENSION_TEXTURE1D:
                Anonymous.Texture1D.MipSlice = mipSlice;
                break;
            case D3D11_UAV_DIMENSION_TEXTURE1DARRAY:
                Anonymous.Texture1DArray.MipSlice = mipSlice;
                Anonymous.Texture1DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture1DArray.ArraySize = arraySize;
                break;
            case D3D11_UAV_DIMENSION_TEXTURE2D:
                Anonymous.Texture2D.MipSlice = mipSlice;
                break;
            case D3D11_UAV_DIMENSION_TEXTURE2DARRAY:
                Anonymous.Texture2DArray.MipSlice = mipSlice;
                Anonymous.Texture2DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DArray.ArraySize = arraySize;
                break;
            case D3D11_UAV_DIMENSION_TEXTURE3D:
                Anonymous.Texture3D.MipSlice = mipSlice;
                Anonymous.Texture3D.FirstWSlice = firstArraySlice;
                Anonymous.Texture3D.WSize = arraySize;
                break;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="D3D11_UNORDERED_ACCESS_VIEW_DESC"/> struct.
    /// </summary>
    /// <param name="buffer"></param>
    /// <param name="format"></param>
    /// <param name="firstElement"></param>
    /// <param name="numElements"></param>
    /// <param name="flags"><see cref="BufferUavFlags"/> options flags for the resource.</param>
    public D3D11_UNORDERED_ACCESS_VIEW_DESC(
        ID3D11Buffer* buffer,
        DXGI_FORMAT format,
        uint firstElement = 0,
        uint numElements = 0,
        D3D11_BUFFER_UAV_FLAG flags = 0) 
    {
        Format = format;
        ViewDimension = D3D11_UAV_DIMENSION_BUFFER;
        Anonymous = default;
        Anonymous.Buffer.FirstElement = firstElement;
        Anonymous.Buffer.NumElements = numElements;
        Anonymous.Buffer.Flags = flags;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="D3D11_UNORDERED_ACCESS_VIEW_DESC"/> struct.
    /// </summary>
    /// <param name="texture"></param>
    /// <param name="isArray"></param>
    /// <param name="format"></param>
    /// <param name="mipSlice"></param>
    /// <param name="firstArraySlice"></param>
    /// <param name="arraySize"></param>
    public D3D11_UNORDERED_ACCESS_VIEW_DESC(
        ID3D11Texture1D* texture,
        bool isArray,
        DXGI_FORMAT format = DXGI_FORMAT_UNKNOWN,
        uint mipSlice = 0,
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1))
    {
        ViewDimension = isArray ? D3D11_UAV_DIMENSION_TEXTURE1DARRAY : D3D11_UAV_DIMENSION_TEXTURE1D;

        if (format == DXGI_FORMAT_UNKNOWN
            || (arraySize == unchecked((uint)-1) && (D3D11_UAV_DIMENSION_TEXTURE1DARRAY == ViewDimension)))
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
            case D3D11_UAV_DIMENSION_TEXTURE1D:
                Anonymous.Texture1D.MipSlice = mipSlice;
                break;
            case D3D11_UAV_DIMENSION_TEXTURE1DARRAY:
                Anonymous.Texture1DArray.MipSlice = mipSlice;
                Anonymous.Texture1DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture1DArray.ArraySize = arraySize;
                break;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="D3D11_UNORDERED_ACCESS_VIEW_DESC"/> struct.
    /// </summary>
    /// <param name="texture"></param>
    /// <param name="viewDimension"></param>
    /// <param name="format"></param>
    /// <param name="mipSlice"></param>
    /// <param name="firstArraySlice"></param>
    /// <param name="arraySize"></param>
    public D3D11_UNORDERED_ACCESS_VIEW_DESC(
        ID3D11Texture2D* texture,
        D3D11_UAV_DIMENSION viewDimension,
        DXGI_FORMAT format = DXGI_FORMAT_UNKNOWN,
        uint mipSlice = 0,
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1)) 
    {
        ViewDimension = viewDimension;

        if (format == DXGI_FORMAT_UNKNOWN
            || (arraySize == unchecked((uint)-1) && (viewDimension == D3D11_UAV_DIMENSION_TEXTURE2DARRAY)))
        {
            D3D11_TEXTURE2D_DESC textureDesc;
            texture->GetDesc(&textureDesc);

            if (format == DXGI_FORMAT_UNKNOWN)
                format = textureDesc.Format;
            if (arraySize == unchecked((uint)-1))
                arraySize = textureDesc.ArraySize - firstArraySlice;
        }

        Format = format;
        Anonymous = default;

        switch (viewDimension)
        {
            case D3D11_UAV_DIMENSION_TEXTURE2D:
                Anonymous.Texture2D.MipSlice = mipSlice;
                break;
            case D3D11_UAV_DIMENSION_TEXTURE2DARRAY:
                Anonymous.Texture2DArray.MipSlice = mipSlice;
                Anonymous.Texture2DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DArray.ArraySize = arraySize;
                break;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="D3D11_UNORDERED_ACCESS_VIEW_DESC"/> struct.
    /// </summary>
    /// <param name="texture"></param>
    /// <param name="viewDimension"></param>
    /// <param name="format"></param>
    /// <param name="mipSlice"></param>
    /// <param name="firstWSlice"></param>
    /// <param name="wSize"></param>
    public D3D11_UNORDERED_ACCESS_VIEW_DESC(
        ID3D11Texture3D* texture,
        D3D11_UAV_DIMENSION viewDimension,
        DXGI_FORMAT format = DXGI_FORMAT_UNKNOWN,
        uint mipSlice = 0,
        uint firstWSlice = 0,
        uint wSize = unchecked((uint)-1))
    {
        ViewDimension = viewDimension;

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
