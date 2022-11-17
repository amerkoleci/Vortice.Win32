// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Gdi;

/// <summary>
/// Specifies the color and usage of an entry in a logical palette.
/// </summary>
/// <unmanaged>PALETTEENTRY</unmanaged>
public partial struct PaletteEntry
{
    /// <summary>
    /// The red intensity value for the palette entry.
    /// </summary>
    public byte Red;

    /// <summary>
    /// The green intensity value for the palette entry.
    /// </summary>
    public byte Green;

    /// <summary>
    /// The blue intensity value for the palette entry.
    /// </summary>
    public byte Blue;

    /// <summary>
    /// The alpha intensity value for the palette entry. Note that as of DirectX 8, this member is treated differently than documented for Windows.
    /// </summary>
    public byte Flags;
}
