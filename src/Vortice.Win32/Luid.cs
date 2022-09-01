// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Runtime.CompilerServices;

namespace Win32;

/// <summary>
/// A locally unique identifier for a graphics device.
/// </summary>
public readonly struct Luid : IEquatable<Luid>
#if NET6_0_OR_GREATER
    , ISpanFormattable
#endif
{
    /// <summary>
    /// The low bits of the luid.
    /// </summary>
    private readonly uint _lowPart;

    /// <summary>
    /// The high bits of the luid.
    /// </summary>
    private readonly int _highPart;

    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Equals(Luid other)
    {
        return
            _lowPart == other._lowPart &&
            _highPart == other._highPart;
    }

    /// <inheritdoc/>
    public override bool Equals(object? other)
    {
        return other is Luid luid && Equals(luid);
    }

    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override int GetHashCode()
    {
        return HashCode.Combine(_lowPart, _highPart);
    }

    /// <inheritdoc/>
    public override string ToString()
    {
        return (((long)this._highPart) << 32 | this._lowPart).ToString();
    }

#if NET6_0_OR_GREATER
    /// <inheritdoc/>
    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        return (((long)_highPart) << 32 | _lowPart).ToString(format, formatProvider);
    }

    /// <inheritdoc/>
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
    {
        return (((long)_highPart) << 32 | _lowPart).TryFormat(destination, out charsWritten, format, provider);
    }
#endif

    /// <summary>
    /// Check whether two <see cref="Luid"/> values are equal.
    /// </summary>
    /// <param name="a">The first <see cref="Luid"/> value to compare.</param>
    /// <param name="b">The second <see cref="Luid"/> value to compare.</param>
    /// <returns>Whether <paramref name="a"/> and <paramref name="b"/> are the same.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(Luid a, Luid b) => a.Equals(b);

    /// <summary>
    /// Check whether two <see cref="Luid"/> values are different.
    /// </summary>
    /// <param name="a">The first <see cref="Luid"/> value to compare.</param>
    /// <param name="b">The second <see cref="Luid"/> value to compare.</param>
    /// <returns>Whether <paramref name="a"/> and <paramref name="b"/> are different.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(Luid a, Luid b) => !a.Equals(b);
}
