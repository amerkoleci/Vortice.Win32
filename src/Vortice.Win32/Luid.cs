// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32;

/// <summary>
/// A locally unique identifier for a graphics device.
/// </summary>
/// <unmanaged>LUID</unmanaged>
[NativeTypeName("LUID")]
public struct LUID : IEquatable<LUID>
    , ISpanFormattable
{
    /// <summary>
    /// The low bits of the luid.
    /// </summary>
    public uint LowPart;

    /// <summary>
    /// The high bits of the luid.
    /// </summary>
    public int HighPart;

    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(LUID other)
    {
        return
            LowPart == other.LowPart &&
            HighPart == other.HighPart;
    }

    /// <inheritdoc/>
    public override readonly bool Equals(object? other)
    {
        return other is LUID luid && Equals(luid);
    }

    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override readonly int GetHashCode()
    {
        return HashCode.Combine(LowPart, HighPart);
    }

    /// <inheritdoc/>
    public override readonly string ToString()
    {
        return (((long)HighPart) << 32 | LowPart).ToString();
    }

    public readonly long ToInt64()
    {
        LARGE_INTEGER val = new();
        val.Anonymous.LowPart = LowPart;
        val.Anonymous.HighPart = HighPart;
        return val.QuadPart;
    }

    public static LUID FromInt64(long Int64)
    {
        LARGE_INTEGER val = new()
        {
            QuadPart = Int64
        };

        LUID luid = new()
        {
            LowPart = val.Anonymous.LowPart,
            HighPart = val.Anonymous.HighPart
        };
        return luid;
    }

    /// <inheritdoc/>
    public readonly string ToString(string? format, IFormatProvider? formatProvider)
    {
        return (((long)HighPart) << 32 | LowPart).ToString(format, formatProvider);
    }

    /// <inheritdoc/>
    public readonly bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
    {
        return (((long)HighPart) << 32 | LowPart).TryFormat(destination, out charsWritten, format, provider);
    }

    /// <summary>
    /// Check whether two <see cref="LUID"/> values are equal.
    /// </summary>
    /// <param name="left">The first <see cref="LUID"/> value to compare.</param>
    /// <param name="right">The second <see cref="LUID"/> value to compare.</param>
    /// <returns>Whether <paramref name="left"/> and <paramref name="right"/> are the same.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(LUID left, LUID right) => left.Equals(right);

    /// <summary>
    /// Check whether two <see cref="LUID"/> values are different.
    /// </summary>
    /// <param name="left">The first <see cref="LUID"/> value to compare.</param>
    /// <param name="right">The second <see cref="LUID"/> value to compare.</param>
    /// <returns>Whether <paramref name="left"/> and <paramref name="right"/> are different.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(LUID left, LUID right) => !left.Equals(right);
}
