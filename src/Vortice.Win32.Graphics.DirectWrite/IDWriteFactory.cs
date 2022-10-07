// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.DirectWrite;

public unsafe partial struct IDWriteFactory
{
    public ComPtr<IDWriteTextFormat> CreateTextFormat(
        ReadOnlySpan<char> fontFamilyName,
        float fontSize,
        FontWeight fontWeight = FontWeight.Normal,
        FontStyle fontStyle = FontStyle.Normal,
        FontStretch fontStretch = FontStretch.Normal)
    {
        using ComPtr<IDWriteTextFormat> textFormat = default;

        fixed (char* fontFamilyNamePtr = fontFamilyName)
        {
            CreateTextFormat(
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

    public ComPtr<IDWriteTextFormat> CreateTextFormat(
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
                CreateTextFormat(
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

    public ComPtr<IDWriteTextFormat> CreateTextFormat(
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
                CreateTextFormat(
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
