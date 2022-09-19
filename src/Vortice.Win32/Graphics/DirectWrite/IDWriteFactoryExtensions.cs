// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Runtime.InteropServices.ComTypes;
using Win32.Graphics.Imaging;

namespace Win32.Graphics.DirectWrite;

/// <summary>
/// A <see langword="class"/> with extensions for the <see cref="IDWriteFactory"/> type.
/// </summary>
public static unsafe class IDWriteFactoryExtensions
{
    public static ComPtr<IDWriteTextFormat> CreateTextFormat(
        this ref IDWriteFactory factory,
        ReadOnlySpan<char> fontFamilyName,
        float fontSize,
        FontWeight fontWeight = FontWeight.Normal,
        FontStyle fontStyle = FontStyle.Normal,
        FontStretch fontStretch = FontStretch.Normal)
    {
        using ComPtr<IDWriteTextFormat> textFormat = default;

        fixed (char* fontFamilyNamePtr = fontFamilyName)
        {
            factory.CreateTextFormat(
                (ushort*)fontFamilyNamePtr,
                null,
                fontWeight,
                fontStyle,
                fontStretch,
                fontSize,
                null,
                textFormat.GetAddressOf()).ThrowIfFailed();

            return textFormat.Move();
        }
    }

    public static ComPtr<IDWriteTextFormat> CreateTextFormat(
        this ref IDWriteFactory factory,
        ReadOnlySpan<char> fontFamilyName,
        float fontSize,
        ReadOnlySpan<char> localeName,
        FontWeight fontWeight = FontWeight.Normal,
        FontStyle fontStyle = FontStyle.Normal,
        FontStretch fontStretch = FontStretch.Normal)
    {
        using ComPtr<IDWriteTextFormat> textFormat = default;

        fixed (char* fontFamilyNamePtr = fontFamilyName)
        {
            fixed (char* localeNamePtr = localeName)
            {
                factory.CreateTextFormat(
                    (ushort*)fontFamilyNamePtr,
                    null,
                    fontWeight,
                    fontStyle,
                    fontStretch,
                    fontSize,
                    (ushort*)localeNamePtr,
                    textFormat.GetAddressOf()).ThrowIfFailed();
            }

            return textFormat.Move();
        }
    }

    public static ComPtr<IDWriteTextFormat> CreateTextFormat(
        this ref IDWriteFactory factory,
        ReadOnlySpan<char> fontFamilyName,
        IDWriteFontCollection* fontCollection,
        float fontSize,
        ReadOnlySpan<char> localeName,
        FontWeight fontWeight = FontWeight.Normal,
        FontStyle fontStyle = FontStyle.Normal,
        FontStretch fontStretch = FontStretch.Normal)
    {
        using ComPtr<IDWriteTextFormat> textFormat = default;

        fixed (char* fontFamilyNamePtr = fontFamilyName)
        {
            fixed (char* localeNamePtr = localeName)
            {
                factory.CreateTextFormat(
                    (ushort*)fontFamilyNamePtr,
                    fontCollection,
                    fontWeight,
                    fontStyle,
                    fontStretch,
                    fontSize,
                    (ushort*)localeNamePtr,
                    textFormat.GetAddressOf()).ThrowIfFailed();
            }

            return textFormat.Move();
        }
    }
}
