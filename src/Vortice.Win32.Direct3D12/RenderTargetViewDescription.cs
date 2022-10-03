// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Dxgi.Common;

namespace Win32.Graphics.Direct3D12;

public unsafe partial struct RenderTargetViewDescription
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RenderTargetViewDescription"/> struct.
    /// </summary>
    /// <param name="viewDimension">The <see cref="RtvDimension"/></param>
    /// <param name="format">The <see cref="Format"/> to use or <see cref="Format.Unknown"/>.</param>
    /// <param name="mipSlice">The index of the mipmap level to use mip slice. or first element for <see cref="RtvDimension.Buffer"/>.</param>
    /// <param name="firstArraySlice">The index of the first texture to use in an array of textures or NumElements for <see cref="RtvDimension.Buffer"/>, FirstWSlice for <see cref="RtvDimension.Texture3D"/>.</param>
    /// <param name="arraySize">Number of textures in the array or WSize for <see cref="RtvDimension.Texture3D"/>. </param>
    public RenderTargetViewDescription(
        RtvDimension viewDimension,
        Format format = Format.Unknown,
        uint mipSlice = 0,
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1))
    {
        Format = format;
        ViewDimension = viewDimension;
        Anonymous = default;

        switch (viewDimension)
        {
            case RtvDimension.Buffer:
                Buffer.FirstElement = mipSlice;
                Buffer.NumElements = firstArraySlice;
                break;
            case RtvDimension.Texture1D:
                Texture1D.MipSlice = mipSlice;
                break;
            case RtvDimension.Texture1DArray:
                Texture1DArray.MipSlice = mipSlice;
                Texture1DArray.FirstArraySlice = firstArraySlice;
                Texture1DArray.ArraySize = arraySize;
                break;
            case RtvDimension.Texture2D:
                Texture2D.MipSlice = mipSlice;
                break;
            case RtvDimension.Texture2DArray:
                Texture2DArray.MipSlice = mipSlice;
                Texture2DArray.FirstArraySlice = firstArraySlice;
                Texture2DArray.ArraySize = arraySize;
                break;
            case RtvDimension.Texture2DMs:
                break;
            case RtvDimension.Texture2DMsArray:
                Texture2DMSArray.FirstArraySlice = firstArraySlice;
                Texture2DMSArray.ArraySize = arraySize;
                break;
            case RtvDimension.Texture3D:
                Texture3D.MipSlice = mipSlice;
                Texture3D.FirstWSlice = firstArraySlice;
                Texture3D.WSize = arraySize;
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RenderTargetViewDescription"/> struct.
    /// </summary>
    public RenderTargetViewDescription(
        ID3D12Resource* texture,
        RtvDimension viewDimension = RtvDimension.Unknown,
        Format format = Format.Unknown,
        uint mipSlice = 0,
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1),
        uint planeSlice = 0)
    {
        ViewDimension = viewDimension;
        if (viewDimension == RtvDimension.Unknown ||
            format == Format.Unknown ||
            arraySize == unchecked((uint)-1))
        {
            ResourceDescription resourceDesc = texture->GetDesc();

            if (viewDimension == RtvDimension.Unknown)
            {
                switch (resourceDesc.Dimension)
                {
                    case ResourceDimension.Buffer:
                        viewDimension = RtvDimension.Buffer;
                        break;
                    case ResourceDimension.Texture1D:
                        viewDimension = resourceDesc.DepthOrArraySize > 1 ? RtvDimension.Texture1DArray : RtvDimension.Texture1D;
                        break;
                    case ResourceDimension.Texture2D:
                        if (resourceDesc.SampleDesc.Count > 1)
                        {
                            viewDimension = resourceDesc.DepthOrArraySize > 1 ? RtvDimension.Texture2DMsArray : RtvDimension.Texture2DMs;
                        }
                        else
                        {
                            viewDimension = resourceDesc.DepthOrArraySize > 1 ? RtvDimension.Texture2DArray : RtvDimension.Texture2D;
                        }
                        break;
                    case ResourceDimension.Texture3D:
                        viewDimension = RtvDimension.Texture3D;
                        break;
                }
            }

            if (format == Format.Unknown)
            {
                format = resourceDesc.Format;
            }

            bool isArray =
               viewDimension == RtvDimension.Texture2DArray ||
               viewDimension == RtvDimension.Texture2DMsArray;

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
            case RtvDimension.Buffer:
                Anonymous.Buffer.FirstElement = firstArraySlice;
                Anonymous.Buffer.NumElements = arraySize;
                break;
            case RtvDimension.Texture1D:
                Anonymous.Texture1D.MipSlice = mipSlice;
                break;
            case RtvDimension.Texture1DArray:
                Anonymous.Texture1DArray.MipSlice = mipSlice;
                Anonymous.Texture1DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture1DArray.ArraySize = arraySize;
                break;
            case RtvDimension.Texture2D:
                Anonymous.Texture2D.MipSlice = mipSlice;
                Anonymous.Texture2D.PlaneSlice = planeSlice;
                break;
            case RtvDimension.Texture2DArray:
                Anonymous.Texture2DArray.MipSlice = mipSlice;
                Anonymous.Texture2DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DArray.ArraySize = arraySize;
                Anonymous.Texture2DArray.PlaneSlice = planeSlice;
                break;
            case RtvDimension.Texture2DMs:
                break;
            case RtvDimension.Texture2DMsArray:
                Anonymous.Texture2DMSArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DMSArray.ArraySize = arraySize;
                break;
            case RtvDimension.Texture3D:
                Anonymous.Texture3D.MipSlice = mipSlice;
                Anonymous.Texture3D.FirstWSlice = firstArraySlice;
                Anonymous.Texture3D.WSize = arraySize;
                break;
            default:
                break;
        }
    }
}
