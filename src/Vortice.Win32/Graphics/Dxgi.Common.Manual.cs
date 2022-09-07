// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Dxgi.Common;

public partial struct Rgb
{
    /// <summary>
    /// Initialize instance of <see cref="Rgb"/> struct.
    /// </summary>
    /// <param name="red"></param>
    /// <param name="green"></param>
    /// <param name="blue"></param>
    public Rgb(float red, float green, float blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }

    public override string ToString()
    {
        return $"{nameof(Rgb)}(Red: {Red}, Green: {Green}, Blue: {Blue})";
    }
}

public partial struct Rational
{
    /// <summary>
    /// Initialize instance of <see cref="Rational"/> struct.
    /// </summary>
    /// <param name="numerator"></param>
    /// <param name="denominator"></param>
    public Rational(uint numerator, uint denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }

    public override string ToString()
    {
        return $"{nameof(Rational)}(Numerator: {Numerator}, Denominator: {Denominator})";
    }
}

public partial struct SampleDescription
{
    /// <summary>
    /// A <see cref="SampleDescription"/> with Count=1 and Quality=0.
    /// </summary>
    public static readonly SampleDescription Default = new(1, 0);

    /// <summary>
    /// Initializes a new instance of the <see cref="SampleDescription"/> struct.
    /// </summary>
    /// <param name="count"></param>
    /// <param name="quality"></param>
    public SampleDescription(uint count, uint quality)
    {
        Count = count;
        Quality = quality;
    }

    public override string ToString() => $"Count: {Count}, Quality: {Quality}";
}

