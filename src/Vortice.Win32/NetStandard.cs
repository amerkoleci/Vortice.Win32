// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

#if !NET6_0_OR_GREATER

using System.Text;

namespace Win32;

internal static unsafe class Extensions
{
    /// <inheritdoc cref="IComparable{T}.CompareTo(T)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int CompareTo(this nint left, nint right)
    {
        if (sizeof(nint) == sizeof(int))
        {
            return ((int)left).CompareTo((int)right);
        }

        return ((long)left).CompareTo(right);
    }

    /// <inheritdoc cref="IComparable{T}.CompareTo(T)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int CompareTo(this nuint left, nuint right)
    {
        if (sizeof(nuint) == sizeof(uint))
        {
            return ((uint)left).CompareTo((uint)right);
        }

        return ((ulong)left).CompareTo(right);
    }

    // <inheritdoc cref="IFormattable.ToString(string?, IFormatProvider?)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string ToString(this nuint value, string? format)
    {
        if (sizeof(nuint) == sizeof(uint))
        {
            return ((uint)value).ToString(format);
        }

        return ((ulong)value).ToString(format);
    }

    /// <inheritdoc cref="IFormattable.ToString(string?, IFormatProvider?)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string ToString(this nuint value, string? format, IFormatProvider? formatProvider)
    {
        if (sizeof(nuint) == sizeof(uint))
        {
            return ((uint)value).ToString(format, formatProvider);
        }

        return ((ulong)value).ToString(format, formatProvider);
    }
}

internal static class MemoryMarshal
{
    /// <inheritdoc cref="global::System.Runtime.InteropServices.MemoryMarshal.GetReference{T}(Span{T})"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref T GetReference<T>(Span<T> span)
    {
        return ref global::System.Runtime.InteropServices.MemoryMarshal.GetReference(span);
    }

    /// <inheritdoc cref="global::System.Runtime.InteropServices.MemoryMarshal.GetReference{T}(ReadOnlySpan{T})"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref T GetReference<T>(ReadOnlySpan<T> span)
    {
        return ref global::System.Runtime.InteropServices.MemoryMarshal.GetReference(span);
    }

    /// <summary>
    /// Creates a new <see cref="Span{T}"/> from a given reference.
    /// </summary>
    /// <typeparam name="T">The type of reference to wrap.</typeparam>
    /// <param name="value">The target reference.</param>
    /// <param name="length">The length of the <see cref="Span{T}"/> to create.</param>
    /// <returns>A new <see cref="Span{T}"/> wrapping <paramref name="value"/>.</returns>
    public static unsafe Span<T> CreateSpan<T>(ref T value, int length)
    {
        return new(Unsafe.AsPointer(ref value), length);
    }

    /// <summary>
    /// Creates a new <see cref="ReadOnlySpan{T}"/> from a given reference.
    /// </summary>
    /// <typeparam name="T">The type of reference to wrap.</typeparam>
    /// <param name="value">The target reference.</param>
    /// <param name="length">The length of the <see cref="Span{T}"/> to create.</param>
    /// <returns>A new <see cref="Span{T}"/> wrapping <paramref name="value"/>.</returns>
    public static unsafe ReadOnlySpan<T> CreateReadOnlySpan<T>(ref T value, int length)
    {
        return new(Unsafe.AsPointer(ref value), length);
    }
}

/// <summary>
/// A polyfill type that mirrors some methods from <see cref="Encoding"/> on .NET 5.
/// </summary>
internal static class EncodingExtensions
{
    /// <summary>
    /// Encodes into a span of bytes a set of characters from the specified read-only span.
    /// </summary>
    /// <param name="encoding">The input <see cref="Encoding"/> instance to use.</param>
    /// <param name="chars">The span containing the set of characters to encode.</param>
    /// <param name="bytes">The byte span to hold the encoded bytes.</param>
    /// <returns>The number of encoded bytes.</returns>
    public static unsafe int GetBytes(this Encoding encoding, ReadOnlySpan<char> chars, Span<byte> bytes)
    {
        fixed (char* charsPtr = &MemoryMarshal.GetReference(chars))
        fixed (byte* bytesPtr = &MemoryMarshal.GetReference(bytes))
        {
            return encoding.GetBytes(charsPtr, chars.Length, bytesPtr, bytes.Length);
        }
    }

    /// <summary>
    /// Decodes a text from a sequence of bytes.
    /// </summary>
    /// <param name="encoding">The input <see cref="Encoding"/> instance to use.</param>
    /// <param name="bytes">The byte span that holds the encoded bytes.</param>
    /// <returns>The resulting text.</returns>
    public static unsafe string GetString(this Encoding encoding, ReadOnlySpan<byte> bytes)
    {
        fixed (byte* bytesPtr = &MemoryMarshal.GetReference(bytes))
        {
            return encoding.GetString(bytesPtr, bytes.Length);
        }
    }
}

#endif
