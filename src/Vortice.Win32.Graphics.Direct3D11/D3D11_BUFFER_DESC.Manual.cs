// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D3D11;

namespace Vortice.Win32.Graphics;

public partial struct D3D11_BUFFER_DESC
{
    /// <summary>
    /// Initializes a new instance of the <see cref="D3D11_BUFFER_DESC"/> struct.
    /// </summary>
    /// <param name="byteWidth">The size in bytes.</param>
    /// <param name="bindFlags">The bind flags.</param>
    /// <param name="usage">The usage.</param>
    /// <param name="cpuAccessFlags">The CPU access flags.</param>
    /// <param name="miscFlags">The option flags.</param>
    /// <param name="structureByteStride">The structure byte stride.</param>
    public D3D11_BUFFER_DESC(uint byteWidth,
        D3D11_BIND_FLAG bindFlags,
        D3D11_USAGE usage = D3D11_USAGE_DEFAULT,
        D3D11_CPU_ACCESS_FLAG cpuAccessFlags = 0,
        D3D11_RESOURCE_MISC_FLAG miscFlags = 0,
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
