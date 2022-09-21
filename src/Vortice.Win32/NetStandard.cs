// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

#if !NET6_0_OR_GREATER

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

#endif
