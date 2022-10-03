// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Win32.Graphics.Direct3D11.Apis;

namespace Win32.Graphics.Direct3D11;

public unsafe partial struct MappedSubresource
{
    public Span<byte> AsSpan(int length) => new(pData, length);

    public Span<T> AsSpan<T>(int length) where T : unmanaged
    {
        return new Span<T>(pData, length);
    }

    public Span<T> AsSpan<T>(ID3D11Buffer* buffer) where T : unmanaged
    {
        BufferDescription desc;
        buffer->GetDesc(&desc);

        Span<byte> source = new(pData, (int)desc.ByteWidth);
        return global::System.Runtime.InteropServices.MemoryMarshal.Cast<byte, T>(source);
    }

    public Span<T> AsSpan<T>(ID3D11Texture1D* resource, uint mipSlice, uint arraySlice) where T : unmanaged
    {
        resource->CalculateSubResourceIndex(mipSlice, arraySlice, out uint mipSize);

        Span<byte> source = new(pData, (int)(mipSize * RowPitch));
        return global::System.Runtime.InteropServices.MemoryMarshal.Cast<byte, T>(source);
    }

    public Span<T> AsSpan<T>(ID3D11Texture2D* resource, uint mipSlice, uint arraySlice) where T : unmanaged
    {
        resource->CalculateSubResourceIndex(mipSlice, arraySlice, out uint mipSize);

        Span<byte> source = new Span<byte>(pData, (int)(mipSize * RowPitch));
        return global::System.Runtime.InteropServices.MemoryMarshal.Cast<byte, T>(source);
    }

    public Span<T> AsSpan<T>(ID3D11Texture3D* resource, uint mipSlice, uint arraySlice) where T : unmanaged
    {
        resource->CalculateSubResourceIndex(mipSlice, arraySlice, out uint mipSize);

        Span<byte> source = new(pData, (int)(mipSize * DepthPitch));
        return global::System.Runtime.InteropServices.MemoryMarshal.Cast<byte, T>(source);
    }
}
