// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Win32.Apis;

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
            ThrowIfFailed(CreateTextFormat(
                fontFamilyNamePtr,
                null,
                fontWeight,
                fontStyle,
                fontStretch,
                fontSize,
                null,
                textFormat.GetAddressOf()));

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
                ThrowIfFailed(CreateTextFormat(
                    fontFamilyNamePtr,
                    null,
                    fontWeight,
                    fontStyle,
                    fontStretch,
                    fontSize,
                    localeNamePtr,
                    textFormat.GetAddressOf())
                    );
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
                ThrowIfFailed(CreateTextFormat(
                    fontFamilyNamePtr,
                    fontCollection,
                    fontWeight,
                    fontStyle,
                    fontStretch,
                    fontSize,
                    localeNamePtr,
                    textFormat.GetAddressOf()));
            }

            return textFormat.Move();
        }
    }
}
