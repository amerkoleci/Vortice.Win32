﻿// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Text;

namespace Win32;

/// <summary>
/// Provides a set of methods to supplement for <see cref="string" />.
/// </summary>
public static unsafe class StringUtilities
{
    public static string? GetString(byte* pointer, int maxLength = -1)
    {
        return GetUtf8Span(pointer, maxLength).GetString();
    }

    public static string? GetString(char* pointer, int maxLength = -1)
    {
        return GetUtf16Span(pointer, maxLength).GetString();
    }

    /// <summary>Gets a null-terminated sequence of UTF8 characters for a string.</summary>
    /// <param name="source">The string for which to get the null-terminated UTF8 character sequence.</param>
    /// <returns>A null-terminated UTF8 character sequence created from <paramref name="source" />.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ReadOnlySpan<byte> GetUtf8Span(this string? source)
    {
        ReadOnlySpan<byte> result;

        if (source is not null)
        {
            int maxLength = Encoding.UTF8.GetMaxByteCount(source.Length);
            byte[] bytes = new byte[maxLength + 1];
            var length = Encoding.UTF8.GetBytes(source.AsSpan(), bytes);
            result = bytes.AsSpan(0, length);
        }
        else
        {
            result = null;
        }

        return result;
    }

    /// <summary>Gets a span for a null-terminated UTF8 character sequence.</summary>
    /// <param name="source">The pointer to a null-terminated UTF8 character sequence.</param>
    /// <param name="maxLength">The maxmimum length of <paramref name="source" /> or <c>-1</c> if the maximum length is unknown.</param>
    /// <returns>A span that starts at <paramref name="source" /> and extends to <paramref name="maxLength" /> or the first null character, whichever comes first.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ReadOnlySpan<byte> GetUtf8Span(byte* source, int maxLength = -1)
        => (source != null) ? GetUtf8Span(in source[0], maxLength) : null;

    /// <summary>Gets a span for a null-terminated UTF8 character sequence.</summary>
    /// <param name="source">The reference to a null-terminated UTF8 character sequence.</param>
    /// <param name="maxLength">The maxmimum length of <paramref name="source" /> or <c>-1</c> if the maximum length is unknown.</param>
    /// <returns>A span that starts at <paramref name="source" /> and extends to <paramref name="maxLength" /> or the first null character, whichever comes first.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ReadOnlySpan<byte> GetUtf8Span(in byte source, int maxLength = -1)
    {
        ReadOnlySpan<byte> result;

        if (!Unsafe.IsNullRef(in source))
        {
            if (maxLength < 0)
            {
                maxLength = int.MaxValue;
            }

            result = MemoryMarshal.CreateReadOnlySpan(in source, maxLength);
            var length = result.IndexOf((byte)'\0');

            if (length != -1)
            {
                result = result.Slice(0, length);
            }
        }
        else
        {
            result = null;
        }

        return result;
    }

    /// <summary>Gets a null-terminated sequence of UTF16 characters for a string.</summary>
    /// <param name="source">The string for which to get the null-terminated UTF16 character sequence.</param>
    /// <returns>A null-terminated UTF16 character sequence created from <paramref name="source" />.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ReadOnlySpan<char> GetUtf16Span(this string? source) => source.AsSpan();

    /// <summary>Marshals a null-terminated UTF16 string to a <see cref="ReadOnlySpan{UInt16}" />.</summary>
    /// <param name="source">The pointer to a null-terminated UTF16 string.</param>
    /// <param name="maxLength">The maxmimum length of <paramref name="source" /> or <c>-1</c> if the maximum length is unknown.</param>
    /// <returns>A <see cref="ReadOnlySpan{UInt16}" /> that starts at <paramref name="source" /> and extends to <paramref name="maxLength" /> or the first null character, whichever comes first.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ReadOnlySpan<char> GetUtf16Span(char* source, int maxLength = -1)
        => (source != null) ? GetUtf16Span(in source[0], maxLength) : null;

    /// <summary>Marshals a null-terminated UTF16 string to a <see cref="ReadOnlySpan{UInt16}" />.</summary>
    /// <param name="source">The reference to a null-terminated UTF16 string.</param>
    /// <param name="maxLength">The maxmimum length of <paramref name="source" /> or <c>-1</c> if the maximum length is unknown.</param>
    /// <returns>A <see cref="ReadOnlySpan{UInt16}" /> that starts at <paramref name="source" /> and extends to <paramref name="maxLength" /> or the first null character, whichever comes first.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ReadOnlySpan<char> GetUtf16Span(in char source, int maxLength = -1)
    {
        ReadOnlySpan<char> result;

        if (!Unsafe.IsNullRef(in source))
        {
            if (maxLength < 0)
            {
                maxLength = int.MaxValue;
            }

            result = MemoryMarshal.CreateReadOnlySpan(in source, maxLength);
            var length = result.IndexOf('\0');

            if (length != -1)
            {
                result = result.Slice(0, length);
            }
        }
        else
        {
            result = null;
        }

        return result;
    }

    /// <summary>Gets a string for a given span.</summary>
    /// <param name="span">The span for which to create the string.</param>
    /// <returns>A string created from <paramref name="span" />.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string? GetString(this ReadOnlySpan<char> span)
    {
        if (span.GetPointer() == null)
            return null;

        return new string(span);
    }

    /// <summary>Gets a string for a given span.</summary>
    /// <param name="span">The span for which to create the string.</param>
    /// <returns>A string created from <paramref name="span" />.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string? GetString(this ReadOnlySpan<byte> span)
    {
        if (span.GetPointer() == null)
            return null;

        return Encoding.UTF8.GetString(span);
    }
}
