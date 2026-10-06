// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Graphics;

public partial struct DXGI_RGB
{
    /// <summary>
    /// Initialize instance of <see cref="Rgb"/> struct.
    /// </summary>
    /// <param name="red"></param>
    /// <param name="green"></param>
    /// <param name="blue"></param>
    public DXGI_RGB(float red, float green, float blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }

    public override string ToString()
    {
        return $"(Red: {Red}, Green: {Green}, Blue: {Blue})";
    }
}

public partial struct DXGI_RATIONAL
{
    /// <summary>
    /// Initialize instance of <see cref="DXGI_RATIONAL"/> struct.
    /// </summary>
    /// <param name="numerator"></param>
    /// <param name="denominator"></param>
    public DXGI_RATIONAL(uint numerator, uint denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }

    public override string ToString()
    {
        return $"(Numerator: {Numerator}, Denominator: {Denominator}";
    }
}

public partial struct DXGI_SAMPLE_DESC
{
    /// <summary>
    /// A <see cref="DXGI_SAMPLE_DESC"/> with Count=1 and Quality=0.
    /// </summary>
    public static DXGI_SAMPLE_DESC Default => new(1, 0);

    /// <summary>
    /// Initializes a new instance of the <see cref="DXGI_SAMPLE_DESC"/> struct.
    /// </summary>
    /// <param name="count"></param>
    /// <param name="quality"></param>
    public DXGI_SAMPLE_DESC(uint count, uint quality)
    {
        Count = count;
        Quality = quality;
    }

    public override string ToString() => $"Count: {Count}, Quality: {Quality}";
}

