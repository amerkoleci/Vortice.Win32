// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Graphics;

public partial struct D3D12_VERTEX_BUFFER_VIEW
{
    /// <summary>
    /// Initializes a new instance of the <see cref="D3D12_VERTEX_BUFFER_VIEW"/> struct.
    /// </summary>
    /// <param name="bufferLocation">Specifies a gpu virtual address that identifies the address of the buffer.</param>
    /// <param name="sizeInBytes">Specifies the size in bytes of the buffer.</param>
    /// <param name="strideInBytes">Specifies the size in bytes of each vertex entry.</param>
    public D3D12_VERTEX_BUFFER_VIEW(ulong bufferLocation, uint sizeInBytes, uint strideInBytes)
    {
        BufferLocation = bufferLocation;
        SizeInBytes = sizeInBytes;
        StrideInBytes = strideInBytes;
    }
}
