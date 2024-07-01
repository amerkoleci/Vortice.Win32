// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D12;

public unsafe partial struct VertexBufferView
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VertexBufferView"/> struct.
    /// </summary>
    /// <param name="bufferLocation">Specifies a gpu virtual address that identifies the address of the buffer.</param>
    /// <param name="sizeInBytes">Specifies the size in bytes of the buffer.</param>
    /// <param name="strideInBytes">Specifies the size in bytes of each vertex entry.</param>
    public VertexBufferView(ulong bufferLocation, uint sizeInBytes, uint strideInBytes)
    {
        BufferLocation = bufferLocation;
        SizeInBytes = sizeInBytes;
        StrideInBytes = strideInBytes;
    }
}
