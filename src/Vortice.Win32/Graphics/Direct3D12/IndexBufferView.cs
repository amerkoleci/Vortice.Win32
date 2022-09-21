// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Dxgi.Common;

namespace Win32.Graphics.Direct3D12;

public unsafe partial struct IndexBufferView
{
    /// <summary>
    /// Initializes a new instance of the <see cref="IndexBufferView"/> struct.
    /// </summary>
    /// <param name="bufferLocation">Specifies a gpu virtual address that identifies the address of the buffer.</param>
    /// <param name="sizeInBytes">Specifies the size in bytes of the index buffer.</param>
    /// <param name="format">Specifies the <see cref="Format"/> for the index-buffer format.</param>
    public IndexBufferView(ulong bufferLocation, uint sizeInBytes, Format format)
    {
        BufferLocation = bufferLocation;
        SizeInBytes = sizeInBytes;
        Format = format;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="IndexBufferView"/> struct.
    /// </summary>
    /// <param name="bufferLocation">Specifies a gpu virtual address that identifies the address of the buffer.</param>
    /// <param name="sizeInBytes">Specifies the size in bytes of the index buffer.</param>
    /// <param name="is32Bit">Specifies if index buffer is 32 bit or 16 bit sized.</param>
    public IndexBufferView(ulong bufferLocation, uint sizeInBytes, bool is32Bit = false)
        : this(bufferLocation, sizeInBytes, is32Bit ? Format.R32Uint : Format.R16Uint)
    {
    }
}
