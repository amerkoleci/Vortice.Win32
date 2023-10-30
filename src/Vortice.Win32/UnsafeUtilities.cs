// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32;

/// <summary>Provides a set of methods to supplement or replace <see cref="Unsafe" /> and <see cref="MemoryMarshal" />.</summary>
public static unsafe class UnsafeUtilities
{
    /// <inheritdoc cref="Unsafe.As{TFrom, TTo}(ref TFrom)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ReadOnlySpan<TTo> As<TFrom, TTo>(this ReadOnlySpan<TFrom> span)
        where TFrom : unmanaged
        where TTo : unmanaged
    {
        return CreateReadOnlySpan(in AsReadOnly<TFrom, TTo>(in span.GetReference()), span.Length);
    }

    /// <inheritdoc cref="Unsafe.As{TFrom, TTo}(ref TFrom)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly TTo AsReadOnly<TFrom, TTo>(in TFrom source)
        => ref Unsafe.As<TFrom, TTo>(ref Unsafe.AsRef(in source));

    /// <inheritdoc cref="MemoryMarshal.GetReference{T}(ReadOnlySpan{T})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly T GetReference<T>(this ReadOnlySpan<T> span) => ref MemoryMarshal.GetReference(span);

    /// <inheritdoc cref="Unsafe.IsNullRef{T}(ref T)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsNullRef<T>(in T source) => Unsafe.IsNullRef(ref Unsafe.AsRef(in source));

    /// <inheritdoc cref="MemoryMarshal.CreateReadOnlySpan{T}(ref T, int)" />
    public static ReadOnlySpan<T> CreateReadOnlySpan<T>(in T reference, int length) => MemoryMarshal.CreateReadOnlySpan(ref Unsafe.AsRef(in reference), length);

    /// <summary>Returns a pointer to the element of the span at index zero.</summary>
    /// <typeparam name="T">The type of items in <paramref name="span" />.</typeparam>
    /// <param name="span">The span from which the pointer is retrieved.</param>
    /// <returns>A pointer to the item at index zero of <paramref name="span" />.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T* GetPointer<T>(this ReadOnlySpan<T> span)
        where T : unmanaged => (T*)Unsafe.AsPointer(ref Unsafe.AsRef(in span.GetReference()));

#if NETSTANDARD2_0
    /// <summary>
    /// Creates a new read-only span for a <see langword="null"/>-terminated UTF-8 string.
    /// </summary>
    /// <param name="value">The pointer to the <see langword="null"/>-terminated string of bytes.</param>
    /// <returns>A read-only span representing the specified <see langword="null"/>-terminated string, or an empty span if the pointer is <see langword="null"/>.</returns>
    /// <remarks>The returned span does not include the <see langword="null"/> terminator, nor does it validate the well-formedness of the UTF-8 data.</remarks>
    /// <exception cref="ArgumentException">The string is longer than <see cref="int.MaxValue"/>.</exception>
    public static unsafe ReadOnlySpan<byte> CreateReadOnlySpanFromNullTerminated(byte* value)
    {
        for (int i = 0; i < int.MaxValue; i++)
        {
            // Stop when the null-terminator has been found
            if (value[i] == 0)
            {
                return new(value, i);
            }
        }

        throw new ArgumentException("The string must be null-terminated.");
    }
#endif
}
