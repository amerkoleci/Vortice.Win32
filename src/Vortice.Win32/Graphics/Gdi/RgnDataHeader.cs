// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Gdi;

/// <unmanaged>RGNDATAHEADER</unmanaged>
public partial struct RgnDataHeader
{
    /// <summary>
    /// The size, in bytes, of the header.
    /// </summary>
    public uint Size;

    /// <summary>
    /// The type of region. This value must be RDH_RECTANGLES.
    /// </summary>
    public uint iType;

    /// <summary>
    /// The number of rectangles that make up the region.
    /// </summary>
    public uint nCount;

    /// <summary>
    /// The size of the <see cref="RgnData"/> buffer required to receive the <see cref="RawRect"/> structures that make up the region.
    /// If the size is not known, this member can be zero.
    /// </summary>
    public uint nRgnSize;

    /// <summary>
    /// A bounding rectangle for the region in logical units.
    /// </summary>
    public RawRect rcBound;
}
