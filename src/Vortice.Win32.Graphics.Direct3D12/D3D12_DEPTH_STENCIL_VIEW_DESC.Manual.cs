// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Vortice.Win32.Graphics.Dxgi.Common;
using static Vortice.Win32.Graphics.D3D12;

namespace Vortice.Win32.Graphics;

public unsafe partial struct D3D12_DEPTH_STENCIL_VIEW_DESC
{
    /// <summary>
    /// Initializes a new instance of the <see cref="D3D12_DEPTH_STENCIL_VIEW_DESC"/> struct.
    /// </summary>
    /// <param name="viewDimension">The <see cref="D3D12_DSV_DIMENSION"/></param>
    /// <param name="format">The <see cref="Format"/> to use or <see cref="Format.Unknown"/>.</param>
    /// <param name="mipSlice">The index of the mipmap level to use mip slice. or first element for <see cref="RtvDimension.Buffer"/>.</param>
    /// <param name="firstArraySlice">The index of the first texture to use in an array of textures or NumElements for <see cref="RtvDimension.Buffer"/>, FirstWSlice for <see cref="RtvDimension.Texture3D"/>.</param>
    /// <param name="arraySize">Number of textures in the array or WSize for <see cref="RtvDimension.Texture3D"/>.</param>
    /// <param name="flags"></param>
    public D3D12_DEPTH_STENCIL_VIEW_DESC(
        D3D12_DSV_DIMENSION viewDimension,
        Format format = Format.Unknown,
        uint mipSlice = 0,
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1),
        D3D12_DSV_FLAGS flags = D3D12_DSV_FLAG_NONE)
    {
        Format = format;
        ViewDimension = viewDimension;
        Anonymous = default;
        Flags = flags;

        switch (viewDimension)
        {
            case D3D12_DSV_DIMENSION_TEXTURE1D:
                Texture1D.MipSlice = mipSlice;
                break;
            case D3D12_DSV_DIMENSION_TEXTURE1DARRAY:
                Texture1DArray.MipSlice = mipSlice;
                Texture1DArray.FirstArraySlice = firstArraySlice;
                Texture1DArray.ArraySize = arraySize;
                break;
            case D3D12_DSV_DIMENSION_TEXTURE2D:
                Texture2D.MipSlice = mipSlice;
                break;
            case D3D12_DSV_DIMENSION_TEXTURE2DARRAY:
                Texture2DArray.MipSlice = mipSlice;
                Texture2DArray.FirstArraySlice = firstArraySlice;
                Texture2DArray.ArraySize = arraySize;
                break;
            case D3D12_DSV_DIMENSION_TEXTURE2DMS:
                break;
            case D3D12_DSV_DIMENSION_TEXTURE2DMSARRAY:
                Texture2DMSArray.FirstArraySlice = firstArraySlice;
                Texture2DMSArray.ArraySize = arraySize;
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="D3D12_DEPTH_STENCIL_VIEW_DESC"/> struct.
    /// </summary>
    public D3D12_DEPTH_STENCIL_VIEW_DESC(
        ID3D12Resource* texture,
        D3D12_DSV_DIMENSION viewDimension = D3D12_DSV_DIMENSION_UNKNOWN,
        Format format = Format.Unknown,
        uint mipSlice = 0,
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1),
        D3D12_DSV_FLAGS flags = D3D12_DSV_FLAG_NONE)
    {
        ViewDimension = viewDimension;
        if (viewDimension == D3D12_DSV_DIMENSION_UNKNOWN ||
            format == Format.Unknown ||
            arraySize == unchecked((uint)-1))
        {
            D3D12_RESOURCE_DESC resourceDesc = texture->GetDesc();

            if (viewDimension == D3D12_DSV_DIMENSION_UNKNOWN)
            {
                switch (resourceDesc.Dimension)
                {
                    case D3D12_RESOURCE_DIMENSION_TEXTURE1D:
                        viewDimension = resourceDesc.DepthOrArraySize > 1 ? D3D12_DSV_DIMENSION_TEXTURE1DARRAY : D3D12_DSV_DIMENSION_TEXTURE1D;
                        break;
                    case D3D12_RESOURCE_DIMENSION_TEXTURE2D:
                        if (resourceDesc.SampleDesc.Count > 1)
                        {
                            viewDimension = resourceDesc.DepthOrArraySize > 1 ? D3D12_DSV_DIMENSION_TEXTURE2DMSARRAY : D3D12_DSV_DIMENSION_TEXTURE2DMS;
                        }
                        else
                        {
                            viewDimension = resourceDesc.DepthOrArraySize > 1 ? D3D12_DSV_DIMENSION_TEXTURE2DARRAY : D3D12_DSV_DIMENSION_TEXTURE2D;
                        }
                        break;
                }
            }

            if (format == Format.Unknown)
            {
                format = resourceDesc.Format;
            }

            bool isArray =
                viewDimension == D3D12_DSV_DIMENSION_TEXTURE2DARRAY ||
                viewDimension == D3D12_DSV_DIMENSION_TEXTURE2DMSARRAY;

            if (arraySize == unchecked((uint)-1) &&
                isArray)
            {
                arraySize = resourceDesc.ArraySize - firstArraySlice;
            }
        }

        Format = format;
        Flags = flags;
        Anonymous = default;

        switch (viewDimension)
        {
            case D3D12_DSV_DIMENSION_TEXTURE1D:
                Anonymous.Texture1D.MipSlice = mipSlice;
                break;
            case D3D12_DSV_DIMENSION_TEXTURE1DARRAY:
                Anonymous.Texture1DArray.MipSlice = mipSlice;
                Anonymous.Texture1DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture1DArray.ArraySize = arraySize;
                break;
            case D3D12_DSV_DIMENSION_TEXTURE2D:
                Anonymous.Texture2D.MipSlice = mipSlice;
                break;
            case D3D12_DSV_DIMENSION_TEXTURE2DARRAY:
                Anonymous.Texture2DArray.MipSlice = mipSlice;
                Anonymous.Texture2DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DArray.ArraySize = arraySize;
                break;
            case D3D12_DSV_DIMENSION_TEXTURE2DMS:
                break;
            case D3D12_DSV_DIMENSION_TEXTURE2DMSARRAY:
                Anonymous.Texture2DMSArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DMSArray.ArraySize = arraySize;
                break;
            default:
                break;
        }
    }
}
