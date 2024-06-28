// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Gdi;

/// <unmanaged>LOGFONTA</unmanaged>
public partial struct LogFontA
{
    /// <summary>
    /// The height, in logical units, of the font's character cell or character.
    /// The character height value (also known as the em height) is the character cell height value minus the internal-leading value.
    /// </summary>
    public int Height;

    /// <summary>
    /// The average width, in logical units, of characters in the font. 
    /// </summary>
    public int Width;

    /// <summary>
    /// The angle, in tenths of degrees, between the escapement vector and the x-axis of the device.
    /// The escapement vector is parallel to the base line of a row of text.
    /// </summary>
    public int Escapement;

    /// <summary>
    /// The angle, in tenths of degrees, between each character's base line and the x-axis of the device.
    /// </summary>
    public int Orientation;

    /// <summary>
    /// The weight of the font in the range 0 through 1000.
    /// For example, 400 is normal and 700 is bold. If this value is zero, a default weight is used.
    /// </summary>
    public int Weight;

    /// <summary>
    /// An italic font if set to TRUE.
    /// </summary>
    public byte Italic;

    /// <summary>
    /// An underlined font if set to TRUE.
    /// </summary>
    public byte Underline;

    /// <summary>
    /// A strikeout font if set to TRUE.
    /// </summary>
    public byte StrikeOut;

    /// <summary>
    /// The character set.
    /// </summary>
    public byte CharSet;

    /// <summary>
    /// The output precision. The output precision defines how closely the output must match the requested font's height, width, character orientation, escapement, pitch, and font type.
    /// </summary>
    public byte OutPrecision;

    public byte ClipPrecision;

    public byte Quality;

    public byte PitchAndFamily;

    public unsafe fixed sbyte FaceName[32];
}
