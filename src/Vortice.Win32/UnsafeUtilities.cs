// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

#if !NET6_0_OR_GREATER
using MemoryMarshal = Win32.MemoryMarshal;
#endif

namespace Win32;

/// <summary>Provides a set of methods to supplement or replace <see cref="Unsafe" /> and <see cref="MemoryMarshal" />.</summary>
public static unsafe class UnsafeUtilities
{
    /// <inheritdoc cref="Unsafe.As{T}(object)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if NET6_0_OR_GREATER
    [return: NotNullIfNotNull("o")]
#endif
    public static T? As<T>(this object? o)
        where T : class?
    {
        //Assert(o is null or T);
        return Unsafe.As<T>(o);
    }

    /// <inheritdoc cref="Unsafe.As{TFrom, TTo}(ref TFrom)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref TTo As<TFrom, TTo>(ref TFrom source)
        => ref Unsafe.As<TFrom, TTo>(ref source);

    /// <inheritdoc cref="Unsafe.As{TFrom, TTo}(ref TFrom)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Span<TTo> As<TFrom, TTo>(this Span<TFrom> span)
        where TFrom : unmanaged
        where TTo : unmanaged
    {
        //Assert(AssertionsEnabled && (SizeOf<TFrom>() == SizeOf<TTo>()));
        return CreateSpan(ref As<TFrom, TTo>(ref span.GetReference()), span.Length);
    }

    /// <inheritdoc cref="Unsafe.As{TFrom, TTo}(ref TFrom)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ReadOnlySpan<TTo> As<TFrom, TTo>(this ReadOnlySpan<TFrom> span)
        where TFrom : unmanaged
        where TTo : unmanaged
    {
        //Assert(AssertionsEnabled && (SizeOf<TFrom>() == SizeOf<TTo>()));
        return CreateReadOnlySpan(in AsReadOnly<TFrom, TTo>(in span.GetReference()), span.Length);
    }

    /// <summary>Reinterprets the given native integer as a reference.</summary>
    /// <typeparam name="T">The type of the reference.</typeparam>
    /// <param name="source">The native integer to reinterpret.</param>
    /// <returns>A reference to a value of type <typeparamref name="T" />.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref T AsRef<T>(nint source) => ref Unsafe.AsRef<T>((void*)source);

    /// <summary>Reinterprets the given native unsigned integer as a reference.</summary>
    /// <typeparam name="T">The type of the reference.</typeparam>
    /// <param name="source">The native unsigned integer to reinterpret.</param>
    /// <returns>A reference to a value of type <typeparamref name="T" />.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref T AsRef<T>(nuint source) => ref Unsafe.AsRef<T>((void*)source);

    /// <inheritdoc cref="Unsafe.AsRef{T}(in T)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref T AsRef<T>(in T source) => ref Unsafe.AsRef(in source);

    /// <inheritdoc cref="Unsafe.AsRef{T}(in T)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref TTo AsRef<TFrom, TTo>(in TFrom source)
    {
        ref var mutable = ref AsRef(in source);
        return ref As<TFrom, TTo>(ref mutable);
    }

    /// <inheritdoc cref="Unsafe.AsPointer{T}(ref T)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T* AsPointer<T>(ref T source)
        where T : unmanaged => (T*)Unsafe.AsPointer(ref source);

    /// <inheritdoc cref="Unsafe.As{TFrom, TTo}(ref TFrom)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly TTo AsReadOnly<TFrom, TTo>(in TFrom source)
        => ref Unsafe.As<TFrom, TTo>(ref AsRef(in source));

    /// <inheritdoc cref="Unsafe.AsPointer{T}(ref T)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T* AsReadOnlyPointer<T>(in T source)
        where T : unmanaged => AsPointer(ref AsRef(in source));

    /// <inheritdoc cref="Unsafe.AsRef{T}(void*)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref T AsRef<T>(void* source) => ref Unsafe.AsRef<T>(source);

    /// <inheritdoc cref="MemoryMarshal.GetArrayDataReference{T}(T[])" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref T GetReference<T>(this T[] array) => ref MemoryMarshal.GetArrayDataReference(array);

    /// <inheritdoc cref="MemoryMarshal.GetArrayDataReference{T}(T[])" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref T GetReference<T>(this T[] array, int index) => ref Unsafe.Add(ref array.GetReference(), index);

    /// <inheritdoc cref="MemoryMarshal.GetArrayDataReference{T}(T[])" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref T GetReference<T>(this T[] array, nuint index) => ref Unsafe.Add(ref array.GetReference(), index);

    /// <inheritdoc cref="MemoryMarshal.GetReference{T}(Span{T})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref T GetReference<T>(this Span<T> span) => ref MemoryMarshal.GetReference(span);

    /// <inheritdoc cref="MemoryMarshal.GetReference{T}(Span{T})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref T GetReference<T>(this Span<T> span, int index) => ref Unsafe.Add(ref MemoryMarshal.GetReference(span), index);

    /// <inheritdoc cref="MemoryMarshal.GetReference{T}(Span{T})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref T GetReference<T>(this Span<T> span, nuint index) => ref Unsafe.Add(ref MemoryMarshal.GetReference(span), index);

    /// <inheritdoc cref="MemoryMarshal.GetReference{T}(ReadOnlySpan{T})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly T GetReference<T>(this ReadOnlySpan<T> span) => ref MemoryMarshal.GetReference(span);

    /// <inheritdoc cref="MemoryMarshal.GetReference{T}(ReadOnlySpan{T})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly T GetReference<T>(this ReadOnlySpan<T> span, int index) => ref Unsafe.Add(ref MemoryMarshal.GetReference(span), index);

    /// <inheritdoc cref="MemoryMarshal.GetReference{T}(ReadOnlySpan{T})" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly T GetReference<T>(this ReadOnlySpan<T> span, nuint index) => ref Unsafe.Add(ref MemoryMarshal.GetReference(span), index);

    /// <summary>Determines if a given reference to a value of type <typeparamref name="T" /> is not a null reference.</summary>
    /// <typeparam name="T">The type of the reference</typeparam>
    /// <param name="source">The reference to check.</param>
    /// <returns><c>true</c> if <paramref name="source" /> is not a null reference; otherwise, <c>false</c>.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsNotNullRef<T>(in T source) => !IsNullRef(in source);

    /// <inheritdoc cref="Unsafe.IsNullRef{T}(ref T)" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsNullRef<T>(in T source) => Unsafe.IsNullRef(ref AsRef(in source));

    /// <inheritdoc cref="Unsafe.NullRef{T}" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref T NullRef<T>() => ref Unsafe.NullRef<T>();

    /// <inheritdoc cref="MemoryMarshal.CreateSpan{T}(ref T, int)" />
    public static Span<T> CreateSpan<T>(ref T reference, int length) => MemoryMarshal.CreateSpan(ref reference, length);

    /// <inheritdoc cref="MemoryMarshal.CreateReadOnlySpan{T}(ref T, int)" />
    public static ReadOnlySpan<T> CreateReadOnlySpan<T>(in T reference, int length) => MemoryMarshal.CreateReadOnlySpan(ref AsRef(in reference), length);

    /// <summary>Returns a pointer to the element of the span at index zero.</summary>
    /// <typeparam name="T">The type of items in <paramref name="span" />.</typeparam>
    /// <param name="span">The span from which the pointer is retrieved.</param>
    /// <returns>A pointer to the item at index zero of <paramref name="span" />.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T* GetPointer<T>(this Span<T> span)
        where T : unmanaged => AsPointer(ref span.GetReference());

    /// <summary>Returns a pointer to the element of the span at index zero.</summary>
    /// <typeparam name="T">The type of items in <paramref name="span" />.</typeparam>
    /// <param name="span">The span from which the pointer is retrieved.</param>
    /// <returns>A pointer to the item at index zero of <paramref name="span" />.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T* GetPointer<T>(this ReadOnlySpan<T> span)
        where T : unmanaged => AsPointer(ref AsRef(in span.GetReference()));
}
