// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Dxgi.Common;

namespace Win32.Graphics.Direct3D12;

public unsafe partial struct DepthStencilViewDescription
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DepthStencilViewDescription"/> struct.
    /// </summary>
    /// <param name="viewDimension">The <see cref="RtvDimension"/></param>
    /// <param name="format">The <see cref="Format"/> to use or <see cref="Format.Unknown"/>.</param>
    /// <param name="mipSlice">The index of the mipmap level to use mip slice. or first element for <see cref="RtvDimension.Buffer"/>.</param>
    /// <param name="firstArraySlice">The index of the first texture to use in an array of textures or NumElements for <see cref="RtvDimension.Buffer"/>, FirstWSlice for <see cref="RtvDimension.Texture3D"/>.</param>
    /// <param name="arraySize">Number of textures in the array or WSize for <see cref="RtvDimension.Texture3D"/>.</param>
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
        Anonymous = default;
        Flags = flags;

        switch (viewDimension)
        {
            case DsvDimension.Texture1D:
                Texture1D.MipSlice = mipSlice;
                break;
            case DsvDimension.Texture1DArray:
                Texture1DArray.MipSlice = mipSlice;
                Texture1DArray.FirstArraySlice = firstArraySlice;
                Texture1DArray.ArraySize = arraySize;
                break;
            case DsvDimension.Texture2D:
                Texture2D.MipSlice = mipSlice;
                break;
            case DsvDimension.Texture2DArray:
                Texture2DArray.MipSlice = mipSlice;
                Texture2DArray.FirstArraySlice = firstArraySlice;
                Texture2DArray.ArraySize = arraySize;
                break;
            case DsvDimension.Texture2DMs:
                break;
            case DsvDimension.Texture2DMsArray:
                Texture2DMSArray.FirstArraySlice = firstArraySlice;
                Texture2DMSArray.ArraySize = arraySize;
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DepthStencilViewDescription"/> struct.
    /// </summary>
    public DepthStencilViewDescription(
        ID3D12Resource* texture,
        DsvDimension viewDimension = DsvDimension.Unknown,
        Format format = Format.Unknown,
        uint mipSlice = 0,
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1),
        DsvFlags flags = DsvFlags.None)
    {
        ViewDimension = viewDimension;
        if (viewDimension == DsvDimension.Unknown ||
            format == Format.Unknown ||
            arraySize == unchecked((uint)-1))
        {
            ResourceDescription resourceDesc = texture->GetDesc();

            if (viewDimension == DsvDimension.Unknown)
            {
                switch (resourceDesc.Dimension)
                {
                    case ResourceDimension.Texture1D:
                        viewDimension = resourceDesc.DepthOrArraySize > 1 ? DsvDimension.Texture1DArray : DsvDimension.Texture1D;
                        break;
                    case ResourceDimension.Texture2D:
                        if (resourceDesc.SampleDesc.Count > 1)
                        {
                            viewDimension = resourceDesc.DepthOrArraySize > 1 ? DsvDimension.Texture2DMsArray : DsvDimension.Texture2DMs;
                        }
                        else
                        {
                            viewDimension = resourceDesc.DepthOrArraySize > 1 ? DsvDimension.Texture2DArray : DsvDimension.Texture2D;
                        }
                        break;
                }
            }

            if (format == Format.Unknown)
            {
                format = resourceDesc.Format;
            }

            bool isArray =
                viewDimension == DsvDimension.Texture2DArray ||
                viewDimension == DsvDimension.Texture2DMsArray;

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
}
