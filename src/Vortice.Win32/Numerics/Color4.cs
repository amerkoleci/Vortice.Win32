﻿// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Globalization;
using System.Runtime.Intrinsics;
using System.Text;
using static Win32.Numerics.VectorUtilities;

namespace Win32.Numerics;

[Serializable]
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public readonly struct Color4
{
    private readonly Vector128<float> _value;

    /// <summary>
    /// Initializes a new instance of the <see cref="Color4"/> struct.
    /// </summary>
    /// <param name="value">The value that will be assigned to all components.</param>
    public Color4(float value)
    {
        _value = Vector128.Create(value, value, value, value);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Color4" /> struct.
    /// </summary>
    /// <param name="red">The value of the red component.</param>
    /// <param name="green">The value of the green component.</param>
    /// <param name="blue">The value of the blue component.</param>
    /// <param name="alpha">The value of the alpha component.</param>
    public Color4(float red, float green, float blue, float alpha = 1.0f)
    {
        _value = Vector128.Create(red, green, blue, alpha);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Color4"/> struct.
    /// </summary>
    /// <param name="value">The red, green, blue, and alpha components of the color.</param>
    public Color4(in Vector4 value)
    {
        _value = value.AsVector128();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Color4"/> struct.
    /// </summary>
    /// <param name="value">The red, green, and blue components of the color.</param>
    /// <param name="alpha">The alpha component of the color.</param>
    public Color4(in Vector3 value, float alpha)
    {
        _value = Vector128.Create(value.X, value.Y, value.Z, alpha);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Color4" /> struct.
    /// </summary>
    /// <param name="values">The span of elements to assign to the vector.</param>
    public Color4(ReadOnlySpan<float> values)
    {
        if (values.Length < 4)
        {
            throw new ArgumentOutOfRangeException(nameof(values), "There must be 4 uint values.");
        }

        this = Unsafe.ReadUnaligned<Color4>(ref Unsafe.As<float, byte>(ref MemoryMarshal.GetReference(values)));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Color4" /> struct.
    /// </summary>
    /// <param name="value">The value of the vector.</param>
    public Color4(Vector128<float> value)
    {
        _value = value;
    }

    /// <summary>Gets the value of the red component.</summary>
    public float R
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => _value.ToScalar();
    }

    /// <summary>Gets the value of the green component.</summary>
    public float G
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => _value.GetElement(1);
    }

    /// <summary>Gets the value of the blue component.</summary>
    public float B
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => _value.GetElement(2);
    }

    /// <summary>Gets the value of the alpha component.</summary>
    public float A
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => _value.GetElement(3);
    }

    public readonly float this[int index]
    {
        get => GetElement(this, index);
    }

    /// <summary>Compares two colors to determine equality.</summary>
    /// <param name="left">The color to compare with <paramref name="right" />.</param>
    /// <param name="right">The color to compare with <paramref name="left" />.</param>
    /// <returns><c>true</c> if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, <c>false</c>.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(Color4 left, Color4 right)
    {
        return CompareEqualAll(left._value, right._value);
    }

    /// <summary>Compares two colors to determine equality.</summary>
    /// <param name="left">The color to compare with <paramref name="right" />.</param>
    /// <param name="right">The color to compare with <paramref name="left" />.</param>
    /// <returns><c>true</c> if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, <c>false</c>.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(Color4 left, Color4 right)
    {
        return CompareNotEqualAny(left._value, right._value);
    }

    /// <inheritdoc />
    public override bool Equals(object? obj) => obj is Color4 other && Equals(other);

    /// <inheritdoc />
    public bool Equals(Color4 other) => this == other;

    /// <inheritdoc />
    public override int GetHashCode() => HashCode.Combine(R, G, B, A);

    /// <inheritdoc />
    public override string ToString() => ToString(format: null, formatProvider: null);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        var separator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;

        return new StringBuilder(9 + (separator.Length * 3))
            .Append('<')
            .Append(R.ToString(format, formatProvider))
            .Append(separator)
            .Append(' ')
            .Append(G.ToString(format, formatProvider))
            .Append(separator)
            .Append(' ')
            .Append(B.ToString(format, formatProvider))
            .Append(separator)
            .Append(' ')
            .Append(A.ToString(format, formatProvider))
            .Append('>')
            .ToString();
    }

    internal const int Count = 4;

    internal static float GetElement(Color4 vector, int index)
    {
        if (index >= Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        return GetElementUnsafe(ref vector, index);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static float GetElementUnsafe(ref Color4 vector, int index)
    {
        Debug.Assert(index is >= 0 and < Count);

        return Unsafe.Add(ref Unsafe.As<Color4, float>(ref vector), index);
    }
}
