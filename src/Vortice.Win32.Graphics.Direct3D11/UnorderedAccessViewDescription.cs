// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Dxgi.Common;

namespace Win32.Graphics.Direct3D11;

public unsafe partial struct UnorderedAccessViewDescription
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UnorderedAccessViewDescription"/> struct.
    /// </summary>
    /// <param name="viewDimension">The <see cref="UavDimension"/></param>
    /// <param name="format">The <see cref="Format"/> to use or <see cref="Format.Unknown"/>.</param>
    /// <param name="mipSlice">The index of the mipmap level to use mip slice or FirstElement for BUFFER.</param>
    /// <param name="firstArraySlice">The index of the first texture to use in an array of textures or NumElements for BUFFER or FirstWSlice for TEXTURE3D.</param>
    /// <param name="arraySize">Number of textures in the array or WSize for TEXTURE3D.</param>
    /// <param name="flags"><see cref="BufferUavFlags"/> options flags for the resource.</param>
    public UnorderedAccessViewDescription(
        UavDimension viewDimension,
        Format format = Format.Unknown,
        uint mipSlice = 0,
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1),
        BufferUavFlags flags = BufferUavFlags.None)
    {
        Format = format;
        ViewDimension = viewDimension;
        Anonymous = default;

        switch (viewDimension)
        {
            case UavDimension.Buffer:
                Anonymous.Buffer.FirstElement = mipSlice;
                Anonymous.Buffer.NumElements = firstArraySlice;
                Anonymous.Buffer.Flags = flags;
                break;
            case UavDimension.Texture1D:
                Anonymous.Texture1D.MipSlice = mipSlice;
                break;
            case UavDimension.Texture1DArray:
                Anonymous.Texture1DArray.MipSlice = mipSlice;
                Anonymous.Texture1DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture1DArray.ArraySize = arraySize;
                break;
            case UavDimension.Texture2D:
                Anonymous.Texture2D.MipSlice = mipSlice;
                break;
            case UavDimension.Texture2DArray:
                Anonymous.Texture2DArray.MipSlice = mipSlice;
                Anonymous.Texture2DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DArray.ArraySize = arraySize;
                break;
            case UavDimension.Texture3D:
                Anonymous.Texture3D.MipSlice = mipSlice;
                Anonymous.Texture3D.FirstWSlice = firstArraySlice;
                Anonymous.Texture3D.WSize = arraySize;
                break;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="UnorderedAccessViewDescription"/> struct.
    /// </summary>
    /// <param name="buffer"></param>
    /// <param name="format"></param>
    /// <param name="firstElement"></param>
    /// <param name="numElements"></param>
    /// <param name="flags"><see cref="BufferUavFlags"/> options flags for the resource.</param>
    public UnorderedAccessViewDescription(
        ID3D11Buffer* buffer,
        Format format,
        uint firstElement = 0,
        uint numElements = 0,
        BufferUavFlags flags = BufferUavFlags.None) 
    {
        Format = format;
        ViewDimension = UavDimension.Buffer;
        Anonymous = default;
        Anonymous.Buffer.FirstElement = firstElement;
        Anonymous.Buffer.NumElements = numElements;
        Anonymous.Buffer.Flags = flags;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="UnorderedAccessViewDescription"/> struct.
    /// </summary>
    /// <param name="texture"></param>
    /// <param name="isArray"></param>
    /// <param name="format"></param>
    /// <param name="mipSlice"></param>
    /// <param name="firstArraySlice"></param>
    /// <param name="arraySize"></param>
    public UnorderedAccessViewDescription(
        ID3D11Texture1D* texture,
        bool isArray,
        Format format = Format.Unknown,
        uint mipSlice = 0,
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1))
    {
        ViewDimension = isArray ? UavDimension.Texture1DArray : UavDimension.Texture1D;

        if (format == Format.Unknown
            || (arraySize == unchecked((uint)-1) && (UavDimension.Texture1DArray == ViewDimension)))
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
            case UavDimension.Texture1D:
                Anonymous.Texture1D.MipSlice = mipSlice;
                break;
            case UavDimension.Texture1DArray:
                Anonymous.Texture1DArray.MipSlice = mipSlice;
                Anonymous.Texture1DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture1DArray.ArraySize = arraySize;
                break;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="UnorderedAccessViewDescription"/> struct.
    /// </summary>
    /// <param name="texture"></param>
    /// <param name="viewDimension"></param>
    /// <param name="format"></param>
    /// <param name="mipSlice"></param>
    /// <param name="firstArraySlice"></param>
    /// <param name="arraySize"></param>
    public UnorderedAccessViewDescription(
        ID3D11Texture2D* texture,
        UavDimension viewDimension,
        Format format = Format.Unknown,
        uint mipSlice = 0,
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1)) 
    {
        ViewDimension = viewDimension;

        if (format == Format.Unknown
            || (arraySize == unchecked((uint)-1) && (viewDimension == UavDimension.Texture2DArray)))
        {
            Texture2DDescription textureDesc;
            texture->GetDesc(&textureDesc);

            if (format == Format.Unknown)
                format = textureDesc.Format;
            if (arraySize == unchecked((uint)-1))
                arraySize = textureDesc.ArraySize - firstArraySlice;
        }

        Format = format;
        Anonymous = default;

        switch (viewDimension)
        {
            case UavDimension.Texture2D:
                Anonymous.Texture2D.MipSlice = mipSlice;
                break;
            case UavDimension.Texture2DArray:
                Anonymous.Texture2DArray.MipSlice = mipSlice;
                Anonymous.Texture2DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DArray.ArraySize = arraySize;
                break;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="UnorderedAccessViewDescription"/> struct.
    /// </summary>
    /// <param name="texture"></param>
    /// <param name="viewDimension"></param>
    /// <param name="format"></param>
    /// <param name="mipSlice"></param>
    /// <param name="firstWSlice"></param>
    /// <param name="wSize"></param>
    public UnorderedAccessViewDescription(
        ID3D11Texture3D* texture,
        UavDimension viewDimension,
        Format format = Format.Unknown,
        uint mipSlice = 0,
        uint firstWSlice = 0,
        uint wSize = unchecked((uint)-1))
    {
        ViewDimension = viewDimension;

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
