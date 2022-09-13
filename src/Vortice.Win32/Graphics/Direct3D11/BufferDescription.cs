// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D11;

public unsafe partial struct BufferDescription
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BufferDescription"/> struct.
    /// </summary>
    /// <param name="byteWidth">The size in bytes.</param>
    /// <param name="bindFlags">The bind flags.</param>
    /// <param name="usage">The usage.</param>
    /// <param name="cpuAccessFlags">The CPU access flags.</param>
    /// <param name="miscFlags">The option flags.</param>
    /// <param name="structureByteStride">The structure byte stride.</param>
    public BufferDescription(uint byteWidth,
        BindFlags bindFlags,
        Usage usage = Usage.Default,
        CpuAccessFlags cpuAccessFlags = CpuAccessFlags.None,
        ResourceMiscFlags miscFlags = ResourceMiscFlags.None,
        uint structureByteStride = 0)
    {
        ByteWidth = byteWidth;
        BindFlags = bindFlags;
        Usage = usage;
        CPUAccessFlags = cpuAccessFlags;
        MiscFlags = miscFlags;
        StructureByteStride = structureByteStride;
    }
}
