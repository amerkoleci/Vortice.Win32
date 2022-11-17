// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Gdi;

/// <summary>
/// The RGNDATA structure contains a header and an array of rectangles that compose a region.
/// The rectangles are sorted top to bottom, left to right. They do not overlap.
/// </summary>
/// <unmanaged>RGNDATA</unmanaged>
public unsafe partial struct RgnData
{
    public RgnDataHeader rdh;

    /// <summary>
    /// Specifies an arbitrary-size buffer that contains the RECT structures that make up the region.
    /// </summary>
    [NativeTypeName("char[1]")]
    public fixed sbyte Buffer[1];
}
