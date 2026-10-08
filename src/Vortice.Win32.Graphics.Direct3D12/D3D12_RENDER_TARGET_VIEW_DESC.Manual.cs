// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.DXGICommon;
using static Vortice.Win32.Graphics.D3D12;

namespace Vortice.Win32.Graphics;

public unsafe partial struct D3D12_RENDER_TARGET_VIEW_DESC
{
    /// <summary>
    /// Initializes a new instance of the <see cref="D3D12_RENDER_TARGET_VIEW_DESC"/> struct.
    /// </summary>
    /// <param name="viewDimension">The <see cref="D3D12_RTV_DIMENSION"/></param>
    /// <param name="format">The <see cref="DXGI_FORMAT"/> to use or <see cref="DXGI_FORMAT_UNKNOWN"/>.</param>
    /// <param name="mipSlice">The index of the mipmap level to use mip slice. or first element for <see cref="D3D12_RTV_DIMENSION_BUFFER"/>.</param>
    /// <param name="firstArraySlice">The index of the first texture to use in an array of textures or NumElements for <see cref="D3D12_RTV_DIMENSION_BUFFER"/>, FirstWSlice for <see cref="D3D12_RTV_DIMENSION_TEXTURE3D"/>.</param>
    /// <param name="arraySize">Number of textures in the array or WSize for <see cref="D3D12_RTV_DIMENSION_TEXTURE3D"/>. </param>
    public D3D12_RENDER_TARGET_VIEW_DESC(
        D3D12_RTV_DIMENSION viewDimension,
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
            case D3D12_RTV_DIMENSION_BUFFER:
                Buffer.FirstElement = mipSlice;
                Buffer.NumElements = firstArraySlice;
                break;
            case D3D12_RTV_DIMENSION_TEXTURE1D:
                Texture1D.MipSlice = mipSlice;
                break;
            case D3D12_RTV_DIMENSION_TEXTURE1DARRAY:
                Texture1DArray.MipSlice = mipSlice;
                Texture1DArray.FirstArraySlice = firstArraySlice;
                Texture1DArray.ArraySize = arraySize;
                break;
            case D3D12_RTV_DIMENSION_TEXTURE2D:
                Texture2D.MipSlice = mipSlice;
                break;
            case D3D12_RTV_DIMENSION_TEXTURE2DARRAY:
                Texture2DArray.MipSlice = mipSlice;
                Texture2DArray.FirstArraySlice = firstArraySlice;
                Texture2DArray.ArraySize = arraySize;
                break;
            case D3D12_RTV_DIMENSION_TEXTURE2DMS:
                break;
            case D3D12_RTV_DIMENSION_TEXTURE2DMSARRAY:
                Texture2DMSArray.FirstArraySlice = firstArraySlice;
                Texture2DMSArray.ArraySize = arraySize;
                break;
            case D3D12_RTV_DIMENSION_TEXTURE3D:
                Texture3D.MipSlice = mipSlice;
                Texture3D.FirstWSlice = firstArraySlice;
                Texture3D.WSize = arraySize;
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="D3D12_RENDER_TARGET_VIEW_DESC"/> struct.
    /// </summary>
    public D3D12_RENDER_TARGET_VIEW_DESC(
        ID3D12Resource* texture,
        D3D12_RTV_DIMENSION viewDimension = D3D12_RTV_DIMENSION_UNKNOWN,
        DXGI_FORMAT format = DXGI_FORMAT_UNKNOWN,
        uint mipSlice = 0,
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1),
        uint planeSlice = 0)
    {
        ViewDimension = viewDimension;
        if (viewDimension == D3D12_RTV_DIMENSION_UNKNOWN ||
            format == DXGI_FORMAT_UNKNOWN ||
            arraySize == unchecked((uint)-1))
        {
            D3D12_RESOURCE_DESC resourceDesc = texture->GetDesc();

            if (viewDimension == D3D12_RTV_DIMENSION_UNKNOWN)
            {
                switch (resourceDesc.Dimension)
                {
                    case D3D12_RESOURCE_DIMENSION_BUFFER:
                        viewDimension = D3D12_RTV_DIMENSION_BUFFER;
                        break;
                    case D3D12_RESOURCE_DIMENSION_TEXTURE1D:
                        viewDimension = resourceDesc.DepthOrArraySize > 1 ? D3D12_RTV_DIMENSION_TEXTURE1DARRAY : D3D12_RTV_DIMENSION_TEXTURE1D;
                        break;
                    case D3D12_RESOURCE_DIMENSION_TEXTURE2D:
                        if (resourceDesc.SampleDesc.Count > 1)
                        {
                            viewDimension = resourceDesc.DepthOrArraySize > 1 ? D3D12_RTV_DIMENSION_TEXTURE2DMSARRAY : D3D12_RTV_DIMENSION_TEXTURE2DMS;
                        }
                        else
                        {
                            viewDimension = resourceDesc.DepthOrArraySize > 1 ? D3D12_RTV_DIMENSION_TEXTURE2DARRAY : D3D12_RTV_DIMENSION_TEXTURE2D;
                        }
                        break;
                    case D3D12_RESOURCE_DIMENSION_TEXTURE3D:
                        viewDimension = D3D12_RTV_DIMENSION_TEXTURE3D;
                        break;
                }
            }

            if (format == DXGI_FORMAT_UNKNOWN)
            {
                format = resourceDesc.Format;
            }

            bool isArray =
               viewDimension == D3D12_RTV_DIMENSION_TEXTURE2DARRAY ||
               viewDimension == D3D12_RTV_DIMENSION_TEXTURE2DMSARRAY;

            if (arraySize == unchecked((uint)-1) &&
                isArray)
            {
                arraySize = resourceDesc.ArraySize - firstArraySlice;
            }
        }

        Format = format;
        Anonymous = default;
        switch (viewDimension)
        {
            case D3D12_RTV_DIMENSION_BUFFER:
                Anonymous.Buffer.FirstElement = firstArraySlice;
                Anonymous.Buffer.NumElements = arraySize;
                break;
            case D3D12_RTV_DIMENSION_TEXTURE1D:
                Anonymous.Texture1D.MipSlice = mipSlice;
                break;
            case D3D12_RTV_DIMENSION_TEXTURE1DARRAY:
                Anonymous.Texture1DArray.MipSlice = mipSlice;
                Anonymous.Texture1DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture1DArray.ArraySize = arraySize;
                break;
            case D3D12_RTV_DIMENSION_TEXTURE2D:
                Anonymous.Texture2D.MipSlice = mipSlice;
                Anonymous.Texture2D.PlaneSlice = planeSlice;
                break;
            case D3D12_RTV_DIMENSION_TEXTURE2DARRAY:
                Anonymous.Texture2DArray.MipSlice = mipSlice;
                Anonymous.Texture2DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DArray.ArraySize = arraySize;
                Anonymous.Texture2DArray.PlaneSlice = planeSlice;
                break;
            case D3D12_RTV_DIMENSION_TEXTURE2DMS:
                break;
            case D3D12_RTV_DIMENSION_TEXTURE2DMSARRAY:
                Anonymous.Texture2DMSArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DMSArray.ArraySize = arraySize;
                break;
            case D3D12_RTV_DIMENSION_TEXTURE3D:
                Anonymous.Texture3D.MipSlice = mipSlice;
                Anonymous.Texture3D.FirstWSlice = firstArraySlice;
                Anonymous.Texture3D.WSize = arraySize;
                break;
            default:
                break;
        }
    }
}
