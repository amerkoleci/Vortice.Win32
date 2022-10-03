// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Dxgi.Common;

namespace Win32.Graphics.Direct3D11;

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
    /// <param name="buffer">Unused <see cref="ID3D11Buffer"/> </param>
    /// <param name="format"></param>
    /// <param name="firstElement"></param>
    /// <param name="numElements"></param>
    public RenderTargetViewDescription(
        ID3D11Buffer* buffer,
        Format format,
        uint firstElement,
        uint numElements)
    {
        Format = format;
        ViewDimension = RtvDimension.Buffer;
        Anonymous = default;

        Anonymous.Buffer.FirstElement = firstElement;
        Anonymous.Buffer.NumElements = numElements;
    }

    public RenderTargetViewDescription(
        ID3D11Texture1D* texture,
        bool isArray,
        Format format = Format.Unknown,
        uint mipSlice = 0,
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1))
    {
        ViewDimension = isArray ? RtvDimension.Texture1DArray : RtvDimension.Texture1D;
        if (format == Format.Unknown
            || (arraySize == unchecked((uint)-1) && RtvDimension.Texture1DArray == ViewDimension))
        {
            Texture1DDescription textureDesc;
            texture->GetDesc(&textureDesc);

            if (format == Format.Unknown)
                format = textureDesc.Format;
            if (arraySize == unchecked((uint)-1))
                arraySize = textureDesc.ArraySize - firstArraySlice;
        }

        Format = format;
        Anonymous = default;

        switch (ViewDimension)
        {
            case RtvDimension.Texture1D:
                Anonymous.Texture1D.MipSlice = mipSlice;
                break;
            case RtvDimension.Texture1DArray:
                Anonymous.Texture1DArray.MipSlice = mipSlice;
                Anonymous.Texture1DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture1DArray.ArraySize = arraySize;
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RenderTargetViewDescription"/> struct.
    /// </summary>
    /// <param name="texture"></param>
    /// <param name="viewDimension"></param>
    /// <param name="format"></param>
    /// <param name="mipSlice"></param>
    /// <param name="firstArraySlice"></param>
    /// <param name="arraySize"></param>
    public RenderTargetViewDescription(
        ID3D11Texture2D* texture,
        RtvDimension viewDimension,
        Format format = Format.Unknown,
        uint mipSlice = 0,
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1))
    {
        ViewDimension = viewDimension;
        if (format == Format.Unknown
            || (arraySize == unchecked((uint)-1) && (RtvDimension.Texture2DArray == viewDimension || RtvDimension.Texture2DMsArray == viewDimension)))
        {
            Texture2DDescription textureDesc;
            texture->GetDesc(&textureDesc);

            if (format == Format.Unknown)
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
            case RtvDimension.Texture2D:
                Anonymous.Texture2D.MipSlice = mipSlice;
                break;
            case RtvDimension.Texture2DArray:
                Anonymous.Texture2DArray.MipSlice = mipSlice;
                Anonymous.Texture2DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DArray.ArraySize = arraySize;
                break;
            case RtvDimension.Texture2DMs:
                break;
            case RtvDimension.Texture2DMsArray:
                Anonymous.Texture2DMSArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DMSArray.ArraySize = arraySize;
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RenderTargetViewDescription"/> struct.
    /// </summary>
    /// <param name="texture"></param>
    /// <param name="format"></param>
    /// <param name="mipSlice"></param>
    /// <param name="firstWSlice"></param>
    /// <param name="wSize"></param>
    public RenderTargetViewDescription(
        ID3D11Texture3D* texture,
        Format format = Format.Unknown,
        uint mipSlice = 0,
        uint firstWSlice = 0,
        uint wSize = unchecked((uint)-1))
    {
        ViewDimension = RtvDimension.Texture3D;
        if (format == Format.Unknown || wSize == unchecked((uint)-1))
        {
            Texture3DDescription textureDesc;
            texture->GetDesc(&textureDesc);

            if (format == Format.Unknown)
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
