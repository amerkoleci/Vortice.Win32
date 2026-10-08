// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Apis;
using static Vortice.Win32.Graphics.DWrite;

namespace Vortice.Win32.Graphics;

public unsafe partial struct IDWriteFactory
{
    public ComPtr<IDWriteTextFormat> CreateTextFormat(
        ReadOnlySpan<char> fontFamilyName,
        float fontSize,
        DWRITE_FONT_WEIGHT fontWeight = DWRITE_FONT_WEIGHT_NORMAL,
        DWRITE_FONT_STYLE fontStyle = DWRITE_FONT_STYLE_NORMAL,
        DWRITE_FONT_STRETCH fontStretch = DWRITE_FONT_STRETCH_NORMAL)
    {
        using ComPtr<IDWriteTextFormat> textFormat = default;

        fixed (char* fontFamilyNamePtr = fontFamilyName)
        {
            CreateTextFormat(
                fontFamilyNamePtr,
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
        DWRITE_FONT_WEIGHT fontWeight = DWRITE_FONT_WEIGHT_NORMAL,
        DWRITE_FONT_STYLE fontStyle = DWRITE_FONT_STYLE_NORMAL,
        DWRITE_FONT_STRETCH fontStretch = DWRITE_FONT_STRETCH_NORMAL)
    {
        using ComPtr<IDWriteTextFormat> textFormat = default;

        fixed (char* fontFamilyNamePtr = fontFamilyName)
        {
            fixed (char* localeNamePtr = localeName)
            {
                CreateTextFormat(
                    fontFamilyNamePtr,
                    null,
                    fontWeight,
                    fontStyle,
                    fontStretch,
                    fontSize,
                    localeNamePtr,
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
        DWRITE_FONT_WEIGHT fontWeight = DWRITE_FONT_WEIGHT_NORMAL,
        DWRITE_FONT_STYLE fontStyle = DWRITE_FONT_STYLE_NORMAL,
        DWRITE_FONT_STRETCH fontStretch = DWRITE_FONT_STRETCH_NORMAL)
    {
        using ComPtr<IDWriteTextFormat> textFormat = default;

        fixed (char* fontFamilyNamePtr = fontFamilyName)
        {
            fixed (char* localeNamePtr = localeName)
            {
                CreateTextFormat(
                    fontFamilyNamePtr,
                    fontCollection,
                    fontWeight,
                    fontStyle,
                    fontStretch,
                    fontSize,
                    localeNamePtr,
                    textFormat.GetAddressOf()).ThrowIfFailed();
            }

            return textFormat.Move();
        }
    }
}
