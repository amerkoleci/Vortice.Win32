// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.DXGICommon;

namespace Vortice.Win32.Graphics;

/// <summary>
/// Helper to use with <see cref="DXGI_FORMAT"/>.
/// </summary>
public static class FormatHelper
{
    /// <summary>
    /// Return the BPP for a given <see cref="DXGI_FORMAT"/>.
    /// </summary>
    /// <param name="format">The DXGI format.</param>
    /// <returns>BPP of </returns>
    public static int BitsPerPixel(this DXGI_FORMAT format)
    {
        switch (format)
        {
            case DXGI_FORMAT_R32G32B32A32_TYPELESS:
            case DXGI_FORMAT_R32G32B32A32_FLOAT:
            case DXGI_FORMAT_R32G32B32A32_UINT:
            case DXGI_FORMAT_R32G32B32A32_SINT:
                return 128;

            case DXGI_FORMAT_R32G32B32_TYPELESS:
            case DXGI_FORMAT_R32G32B32_FLOAT:
            case DXGI_FORMAT_R32G32B32_UINT:
            case DXGI_FORMAT_R32G32B32_SINT:
                return 96;

            case DXGI_FORMAT_R16G16B16A16_TYPELESS:
            case DXGI_FORMAT_R16G16B16A16_FLOAT:
            case DXGI_FORMAT_R16G16B16A16_UNORM:
            case DXGI_FORMAT_R16G16B16A16_UINT:
            case DXGI_FORMAT_R16G16B16A16_SNORM:
            case DXGI_FORMAT_R16G16B16A16_SINT:
            case DXGI_FORMAT_R32G32_TYPELESS:
            case DXGI_FORMAT_R32G32_FLOAT:
            case DXGI_FORMAT_R32G32_UINT:
            case DXGI_FORMAT_R32G32_SINT:
            case DXGI_FORMAT_R32G8X24_TYPELESS:
            case DXGI_FORMAT_D32_FLOAT_S8X24_UINT:
            case DXGI_FORMAT_R32_FLOAT_X8X24_TYPELESS:
            case DXGI_FORMAT_X32_TYPELESS_G8X24_UINT:
            case DXGI_FORMAT_Y416:
            case DXGI_FORMAT_Y210:
            case DXGI_FORMAT_Y216:
                return 64;

            case DXGI_FORMAT_R10G10B10A2_TYPELESS:
            case DXGI_FORMAT_R10G10B10A2_UNORM:
            case DXGI_FORMAT_R10G10B10A2_UINT:
            case DXGI_FORMAT_R11G11B10_FLOAT:
            case DXGI_FORMAT_R8G8B8A8_TYPELESS:
            case DXGI_FORMAT_R8G8B8A8_UNORM:
            case DXGI_FORMAT_R8G8B8A8_UNORM_SRGB:
            case DXGI_FORMAT_R8G8B8A8_SNORM:
            case DXGI_FORMAT_R8G8B8A8_UINT:
            case DXGI_FORMAT_R8G8B8A8_SINT:
            case DXGI_FORMAT_R16G16_TYPELESS:
            case DXGI_FORMAT_R16G16_FLOAT:
            case DXGI_FORMAT_R16G16_UNORM:
            case DXGI_FORMAT_R16G16_SNORM:
            case DXGI_FORMAT_R16G16_UINT:
            case DXGI_FORMAT_R16G16_SINT:
            case DXGI_FORMAT_R32_TYPELESS:
            case DXGI_FORMAT_D32_FLOAT:
            case DXGI_FORMAT_R32_FLOAT:
            case DXGI_FORMAT_R32_UINT:
            case DXGI_FORMAT_R32_SINT:
            case DXGI_FORMAT_R24G8_TYPELESS:
            case DXGI_FORMAT_D24_UNORM_S8_UINT:
            case DXGI_FORMAT_R24_UNORM_X8_TYPELESS:
            case DXGI_FORMAT_X24_TYPELESS_G8_UINT:
            case DXGI_FORMAT_R9G9B9E5_SHAREDEXP:
            case DXGI_FORMAT_R8G8_B8G8_UNORM:
            case DXGI_FORMAT_G8R8_G8B8_UNORM:
            case DXGI_FORMAT_B8G8R8A8_UNORM:
            case DXGI_FORMAT_B8G8R8X8_UNORM:
            case DXGI_FORMAT_R10G10B10_XR_BIAS_A2_UNORM:
            case DXGI_FORMAT_B8G8R8A8_TYPELESS:
            case DXGI_FORMAT_B8G8R8A8_UNORM_SRGB:
            case DXGI_FORMAT_B8G8R8X8_TYPELESS:
            case DXGI_FORMAT_B8G8R8X8_UNORM_SRGB:
            case DXGI_FORMAT_AYUV:
            case DXGI_FORMAT_Y410:
            case DXGI_FORMAT_YUY2:
            case DXGI_FORMAT_XBOX_R10G10B10_7E3_A2_FLOAT:
            case DXGI_FORMAT_XBOX_R10G10B10_6E4_A2_FLOAT:
            case DXGI_FORMAT_XBOX_R10G10B10_SNORM_A2_UNORM:
                return 32;

            case DXGI_FORMAT_P010:
            case DXGI_FORMAT_P016:
            case DXGI_FORMAT_XBOX_D16_UNORM_S8_UINT:
            case DXGI_FORMAT_XBOX_R16_UNORM_X8_TYPELESS:
            case DXGI_FORMAT_XBOX_X16_TYPELESS_G8_UINT:
            case DXGI_FORMAT_V408:
                return 24;

            case DXGI_FORMAT_R8G8_TYPELESS:
            case DXGI_FORMAT_R8G8_UNORM:
            case DXGI_FORMAT_R8G8_UINT:
            case DXGI_FORMAT_R8G8_SNORM:
            case DXGI_FORMAT_R8G8_SINT:
            case DXGI_FORMAT_R16_TYPELESS:
            case DXGI_FORMAT_R16_FLOAT:
            case DXGI_FORMAT_D16_UNORM:
            case DXGI_FORMAT_R16_UNORM:
            case DXGI_FORMAT_R16_UINT:
            case DXGI_FORMAT_R16_SNORM:
            case DXGI_FORMAT_R16_SINT:
            case DXGI_FORMAT_B5G6R5_UNORM:
            case DXGI_FORMAT_B5G5R5A1_UNORM:
            case DXGI_FORMAT_A8P8:
            case DXGI_FORMAT_B4G4R4A4_UNORM:
            case DXGI_FORMAT_P208:
            case DXGI_FORMAT_V208:
            case DXGI_FORMAT_A4B4G4R4_UNORM:
                return 16;

            case DXGI_FORMAT_NV12:
            case DXGI_FORMAT_420_OPAQUE:
            case DXGI_FORMAT_NV11:
                return 12;

            case DXGI_FORMAT_R8_TYPELESS:
            case DXGI_FORMAT_R8_UNORM:
            case DXGI_FORMAT_R8_UINT:
            case DXGI_FORMAT_R8_SNORM:
            case DXGI_FORMAT_R8_SINT:
            case DXGI_FORMAT_A8_UNORM:
            case DXGI_FORMAT_BC2_TYPELESS:
            case DXGI_FORMAT_BC2_UNORM:
            case DXGI_FORMAT_BC2_UNORM_SRGB:
            case DXGI_FORMAT_BC3_TYPELESS:
            case DXGI_FORMAT_BC3_UNORM:
            case DXGI_FORMAT_BC3_UNORM_SRGB:
            case DXGI_FORMAT_BC5_TYPELESS:
            case DXGI_FORMAT_BC5_UNORM:
            case DXGI_FORMAT_BC5_SNORM:
            case DXGI_FORMAT_BC6H_TYPELESS:
            case DXGI_FORMAT_BC6H_UF16:
            case DXGI_FORMAT_BC6H_SF16:
            case DXGI_FORMAT_BC7_TYPELESS:
            case DXGI_FORMAT_BC7_UNORM:
            case DXGI_FORMAT_BC7_UNORM_SRGB:
            case DXGI_FORMAT_AI44:
            case DXGI_FORMAT_IA44:
            case DXGI_FORMAT_P8:
            case DXGI_FORMAT_XBOX_R4G4_UNORM:
                return 8;

            case DXGI_FORMAT_R1_UNORM:
                return 1;

            case DXGI_FORMAT_BC1_TYPELESS:
            case DXGI_FORMAT_BC1_UNORM:
            case DXGI_FORMAT_BC1_UNORM_SRGB:
            case DXGI_FORMAT_BC4_TYPELESS:
            case DXGI_FORMAT_BC4_UNORM:
            case DXGI_FORMAT_BC4_SNORM:
                return 4;

            default:
                return 0;
        }
    }

    public static int BitsPerColor(this DXGI_FORMAT format)
    {
        switch (format)
        {
            case DXGI_FORMAT_R32G32B32A32_TYPELESS:
            case DXGI_FORMAT_R32G32B32A32_FLOAT:
            case DXGI_FORMAT_R32G32B32A32_UINT:
            case DXGI_FORMAT_R32G32B32A32_SINT:
            case DXGI_FORMAT_R32G32B32_TYPELESS:
            case DXGI_FORMAT_R32G32B32_FLOAT:
            case DXGI_FORMAT_R32G32B32_UINT:
            case DXGI_FORMAT_R32G32B32_SINT:
            case DXGI_FORMAT_R32G32_TYPELESS:
            case DXGI_FORMAT_R32G32_FLOAT:
            case DXGI_FORMAT_R32G32_UINT:
            case DXGI_FORMAT_R32G32_SINT:
            case DXGI_FORMAT_R32G8X24_TYPELESS:
            case DXGI_FORMAT_D32_FLOAT_S8X24_UINT:
            case DXGI_FORMAT_R32_FLOAT_X8X24_TYPELESS:
            case DXGI_FORMAT_X32_TYPELESS_G8X24_UINT:
            case DXGI_FORMAT_R32_TYPELESS:
            case DXGI_FORMAT_D32_FLOAT:
            case DXGI_FORMAT_R32_FLOAT:
            case DXGI_FORMAT_R32_UINT:
            case DXGI_FORMAT_R32_SINT:
                return 32;

            case DXGI_FORMAT_R24G8_TYPELESS:
            case DXGI_FORMAT_D24_UNORM_S8_UINT:
            case DXGI_FORMAT_R24_UNORM_X8_TYPELESS:
            case DXGI_FORMAT_X24_TYPELESS_G8_UINT:
                return 24;

            case DXGI_FORMAT_R16G16B16A16_TYPELESS:
            case DXGI_FORMAT_R16G16B16A16_FLOAT:
            case DXGI_FORMAT_R16G16B16A16_UNORM:
            case DXGI_FORMAT_R16G16B16A16_UINT:
            case DXGI_FORMAT_R16G16B16A16_SNORM:
            case DXGI_FORMAT_R16G16B16A16_SINT:
            case DXGI_FORMAT_R16G16_TYPELESS:
            case DXGI_FORMAT_R16G16_FLOAT:
            case DXGI_FORMAT_R16G16_UNORM:
            case DXGI_FORMAT_R16G16_UINT:
            case DXGI_FORMAT_R16G16_SNORM:
            case DXGI_FORMAT_R16G16_SINT:
            case DXGI_FORMAT_R16_TYPELESS:
            case DXGI_FORMAT_R16_FLOAT:
            case DXGI_FORMAT_D16_UNORM:
            case DXGI_FORMAT_R16_UNORM:
            case DXGI_FORMAT_R16_UINT:
            case DXGI_FORMAT_R16_SNORM:
            case DXGI_FORMAT_R16_SINT:
            case DXGI_FORMAT_BC6H_TYPELESS:
            case DXGI_FORMAT_BC6H_UF16:
            case DXGI_FORMAT_BC6H_SF16:
            case DXGI_FORMAT_Y416:
            case DXGI_FORMAT_P016:
            case DXGI_FORMAT_Y216:
            case DXGI_FORMAT_XBOX_D16_UNORM_S8_UINT:
            case DXGI_FORMAT_XBOX_R16_UNORM_X8_TYPELESS:
            case DXGI_FORMAT_XBOX_X16_TYPELESS_G8_UINT:
                return 16;

            case DXGI_FORMAT_R9G9B9E5_SHARED_EXP:
                return 14;

            case DXGI_FORMAT_R11G11B10_FLOAT:
                return 11;

            case DXGI_FORMAT_R10G10B10A2_TYPELESS:
            case DXGI_FORMAT_R10G10B10A2_UNORM:
            case DXGI_FORMAT_R10G10B10A2_UINT:
            case DXGI_FORMAT_R10G10B10_XR_BIAS_A2_UNORM:
            case DXGI_FORMAT_Y410:
            case DXGI_FORMAT_P010:
            case DXGI_FORMAT_Y210:
            case DXGI_FORMAT_XBOX_R10G10B10_7E3_A2_FLOAT:
            case DXGI_FORMAT_XBOX_R10G10B10_6E4_A2_FLOAT:
            case DXGI_FORMAT_XBOX_R10G10B10_SNORM_A2_UNORM:
                return 10;

            case DXGI_FORMAT_R8G8B8A8_TYPELESS:
            case DXGI_FORMAT_R8G8B8A8_UNORM:
            case DXGI_FORMAT_R8G8B8A8_UNORM_SRGB:
            case DXGI_FORMAT_R8G8B8A8_UINT:
            case DXGI_FORMAT_R8G8B8A8_SNORM:
            case DXGI_FORMAT_R8G8B8A8_SINT:
            case DXGI_FORMAT_R8G8_TYPELESS:
            case DXGI_FORMAT_R8G8_UNORM:
            case DXGI_FORMAT_R8G8_UINT:
            case DXGI_FORMAT_R8G8_SNORM:
            case DXGI_FORMAT_R8G8_SINT:
            case DXGI_FORMAT_R8_TYPELESS:
            case DXGI_FORMAT_R8_UNORM:
            case DXGI_FORMAT_R8_UINT:
            case DXGI_FORMAT_R8_SNORM:
            case DXGI_FORMAT_R8_SINT:
            case DXGI_FORMAT_A8_UNORM:
            case DXGI_FORMAT_R8G8_B8G8_UNORM:
            case DXGI_FORMAT_G8R8_G8B8_UNORM:
            case DXGI_FORMAT_BC4_TYPELESS:
            case DXGI_FORMAT_BC4_UNORM:
            case DXGI_FORMAT_BC4_SNORM:
            case DXGI_FORMAT_BC5_TYPELESS:
            case DXGI_FORMAT_BC5_UNORM:
            case DXGI_FORMAT_BC5_SNORM:
            case DXGI_FORMAT_B8G8R8A8_UNORM:
            case DXGI_FORMAT_B8G8R8X8_UNORM:
            case DXGI_FORMAT_B8G8R8A8_TYPELESS:
            case DXGI_FORMAT_B8G8R8A8_UNORM_SRGB:
            case DXGI_FORMAT_B8G8R8X8_TYPELESS:
            case DXGI_FORMAT_B8G8R8X8_UNORM_SRGB:
            case DXGI_FORMAT_AYUV:
            case DXGI_FORMAT_NV12:
            case DXGI_FORMAT_420_OPAQUE:
            case DXGI_FORMAT_YUY2:
            case DXGI_FORMAT_NV11:
            case DXGI_FORMAT_P208:
            case DXGI_FORMAT_V208:
            case DXGI_FORMAT_V408:
                return 8;

            case DXGI_FORMAT_BC7_TYPELESS:
            case DXGI_FORMAT_BC7_UNORM:
            case DXGI_FORMAT_BC7_UNORM_SRGB:
                return 7;

            case DXGI_FORMAT_BC1_TYPELESS:
            case DXGI_FORMAT_BC1_UNORM:
            case DXGI_FORMAT_BC1_UNORM_SRGB:
            case DXGI_FORMAT_BC2_TYPELESS:
            case DXGI_FORMAT_BC2_UNORM:
            case DXGI_FORMAT_BC2_UNORM_SRGB:
            case DXGI_FORMAT_BC3_TYPELESS:
            case DXGI_FORMAT_BC3_UNORM:
            case DXGI_FORMAT_BC3_UNORM_SRGB:
            case DXGI_FORMAT_B5G6R5_UNORM:
                return 6;

            case DXGI_FORMAT_B5G5R5A1_UNORM:
                return 5;

            case DXGI_FORMAT_B4G4R4A4_UNORM:
            case DXGI_FORMAT_XBOX_R4G4_UNORM:
            case DXGI_FORMAT_A4B4G4R4_UNORM:
                return 4;

            case DXGI_FORMAT_R1_UNORM:
                return 1;

            // Palettized formats return 0 for this function
            case DXGI_FORMAT_AI44:
            case DXGI_FORMAT_IA44:
            case DXGI_FORMAT_P8:
            case DXGI_FORMAT_A8P8:
            default:
                return 0;
        }
    }

    /// <summary>
    /// Returns true if the <see cref="DXGI_FORMAT"/> is valid.
    /// </summary>
    /// <param name="format">A format to validate</param>
    /// <returns>True if the <see cref="DXGI_FORMAT"/> is valid.</returns>
    public static bool IsValid(this DXGI_FORMAT format)
    {
        return ((int)(format) >= 1 && (int)(format) <= 191);
    }

    /// <summary>
    /// Returns true if the <see cref="DXGI_FORMAT"/> is a compressed format.
    /// </summary>
    /// <param name="format">The format to check for compressed.</param>
    /// <returns>True if the <see cref="DXGI_FORMAT"/> is a compressed format</returns>
    public static bool IsCompressed(this DXGI_FORMAT format)
    {
        switch (format)
        {
            case DXGI_FORMAT_BC1_TYPELESS:
            case DXGI_FORMAT_BC1_UNORM:
            case DXGI_FORMAT_BC1_UNORM_SRGB:
            case DXGI_FORMAT_BC2_TYPELESS:
            case DXGI_FORMAT_BC2_UNORM:
            case DXGI_FORMAT_BC2_UNORM_SRGB:
            case DXGI_FORMAT_BC3_TYPELESS:
            case DXGI_FORMAT_BC3_UNORM:
            case DXGI_FORMAT_BC3_UNORM_SRGB:
            case DXGI_FORMAT_BC4_TYPELESS:
            case DXGI_FORMAT_BC4_UNORM:
            case DXGI_FORMAT_BC4_SNORM:
            case DXGI_FORMAT_BC5_TYPELESS:
            case DXGI_FORMAT_BC5_UNORM:
            case DXGI_FORMAT_BC5_SNORM:
            case DXGI_FORMAT_BC6H_TYPELESS:
            case DXGI_FORMAT_BC6H_UF16:
            case DXGI_FORMAT_BC6H_SF16:
            case DXGI_FORMAT_BC7_TYPELESS:
            case DXGI_FORMAT_BC7_UNORM:
            case DXGI_FORMAT_BC7_UNORM_SRGB:
                return true;

            default:
                return false;
        }
    }

    /// <summary>
    /// Determines whether the specified <see cref="DXGI_FORMAT"/> is packed.
    /// </summary>
    /// <param name="format">The DXGI Format.</param>
    /// <returns><c>true</c> if the specified <see cref="DXGI_FORMAT"/> is packed; otherwise, <c>false</c>.</returns>
    public static bool IsPacked(this DXGI_FORMAT format)
    {
        switch (format)
        {
            case DXGI_FORMAT_R8G8_B8G8_UNORM:
            case DXGI_FORMAT_G8R8_G8B8_UNORM:
            case DXGI_FORMAT_YUY2: // 4:2:2 8-bit
            case DXGI_FORMAT_Y210: // 4:2:2 10-bit
            case DXGI_FORMAT_Y216: // 4:2:2 16-bit
                return true;

            default:
                return false;
        }
    }

    /// <summary>
    /// Determines whether the specified <see cref="DXGI_FORMAT"/> is video.
    /// </summary>
    /// <param name="format">The <see cref="DXGI_FORMAT"/>.</param>
    /// <returns><c>true</c> if the specified <see cref="DXGI_FORMAT"/> is video; otherwise, <c>false</c>.</returns>
    public static bool IsVideo(this DXGI_FORMAT format)
    {
        switch (format)
        {
            case DXGI_FORMAT_AYUV:
            case DXGI_FORMAT_Y410:
            case DXGI_FORMAT_Y416:
            case DXGI_FORMAT_NV12:
            case DXGI_FORMAT_P010:
            case DXGI_FORMAT_P016:
            case DXGI_FORMAT_YUY2:
            case DXGI_FORMAT_Y210:
            case DXGI_FORMAT_Y216:
            case DXGI_FORMAT_NV11:
            // These video formats can be used with the 3D pipeline through special view mappings

            case DXGI_FORMAT_420_OPAQUE:
            case DXGI_FORMAT_AI44:
            case DXGI_FORMAT_IA44:
            case DXGI_FORMAT_P8:
            case DXGI_FORMAT_A8P8:
            // These are limited use video formats not usable in any way by the 3D pipeline

            case DXGI_FORMAT_P208:
            case DXGI_FORMAT_V208:
            case DXGI_FORMAT_V408:
                // These video formats are for JPEG Hardware decode (DXGI 1.4)
                return true;

            default:
                return false;
        }
    }

    public static bool IsPlanar(this DXGI_FORMAT format)
    {
        switch (format)
        {
            case DXGI_FORMAT_NV12:      // 4:2:0 8-bit
            case DXGI_FORMAT_P010:      // 4:2:0 10-bit
            case DXGI_FORMAT_P016:      // 4:2:0 16-bit
            case DXGI_FORMAT_420_OPAQUE:// 4:2:0 8-bit
            case DXGI_FORMAT_NV11:      // 4:1:1 8-bit

            case DXGI_FORMAT_P208: // 4:2:2 8-bit
            case DXGI_FORMAT_V208: // 4:4:0 8-bit
            case DXGI_FORMAT_V408: // 4:4:4 8-bit
                              // These are JPEG Hardware decode formats (DXGI 1.4)
            case DXGI_FORMAT_Xbox_D16Unorm_S8Uint:
            case DXGI_FORMAT_Xbox_R16Unorm_X8Typeless:
            case DXGI_FORMAT_Xbox_X16Typeless_G8Uint:
                // These are Xbox One platform specific types
                return true;

            default:
                return false;
        }
    }

    public static bool IsPalettized(this DXGI_FORMAT format)
    {
        switch (format)
        {
            case Format.AI44:
            case Format.IA44:
            case Format.P8:
            case Format.A8P8:
                return true;

            default:
                return false;
        }
    }

    public static bool IsDepthStencil(this DXGI_FORMAT format)
    {
        switch (format)
        {
            case Format.R32G8X24Typeless:
            case Format.D32FloatS8X24Uint:
            case Format.R32FloatX8X24Typeless:
            case Format.X32TypelessG8X24Uint:
            case Format.D32Float:
            case Format.R24G8Typeless:
            case Format.D24UnormS8Uint:
            case Format.R24UnormX8Typeless:
            case Format.X24TypelessG8Uint:
            case Format.D16Unorm:
            case Format.Xbox_D16Unorm_S8Uint:
            case Format.Xbox_R16Unorm_X8Typeless:
            case Format.Xbox_X16Typeless_G8Uint:
                return true;

            default:
                return false;
        }
    }

    /// <summary>
    /// Determines whether the specified <see cref="Format"/> is a SRGB format.
    /// </summary>
    /// <param name="format">The <see cref="DXGI_FORMAT"/>.</param>
    /// <returns><c>true</c> if the specified <see cref="DXGI_FORMAT"/> is a SRGB format; otherwise, <c>false</c>.</returns>
    public static bool IsSRGB(this DXGI_FORMAT format)
    {
        switch (format)
        {
            case DXGI_FORMAT_R8G8B8A8_UNORM_SRGB:
            case Format.B8G8R8A8UnormSrgb:
            case Format.B8G8R8X8UnormSrgb:
            case Format.BC1UnormSrgb:
            case Format.BC2UnormSrgb:
            case Format.BC3UnormSrgb:
            case Format.BC7UnormSrgb:
                return true;

            default:
                return false;
        }
    }

    /// <summary>
    /// Determines whether the specified <see cref="Format"/> is typeless.
    /// </summary>
    /// <param name="format">The <see cref="Format"/>.</param>
    /// <param name="partialTypeless"></param>
    /// <returns><c>true</c> if the specified <see cref="Format"/> is typeless; otherwise, <c>false</c>.</returns>
    public static bool IsTypeless(this Format format, bool partialTypeless = true)
    {
        switch (format)
        {
            case Format.R32G32B32A32Typeless:
            case Format.R32G32B32Typeless:
            case Format.R16G16B16A16Typeless:
            case Format.R32G32Typeless:
            case Format.R32G8X24Typeless:
            case Format.R10G10B10A2Typeless:
            case Format.R8G8B8A8Typeless:
            case Format.R16G16Typeless:
            case Format.R32Typeless:
            case Format.R24G8Typeless:
            case Format.R8G8Typeless:
            case Format.R16Typeless:
            case Format.R8Typeless:
            case Format.BC1Typeless:
            case Format.BC2Typeless:
            case Format.BC3Typeless:
            case Format.BC4Typeless:
            case Format.BC5Typeless:
            case Format.B8G8R8A8Typeless:
            case Format.B8G8R8X8Typeless:
            case Format.BC6HTypeless:
            case Format.BC7Typeless:
                return true;

            case Format.R32FloatX8X24Typeless:
            case Format.X32TypelessG8X24Uint:
            case Format.R24UnormX8Typeless:
            case Format.X24TypelessG8Uint:
            case Format.Xbox_R16Unorm_X8Typeless:
            case Format.Xbox_X16Typeless_G8Uint:
                return partialTypeless;

            default:
                return false;
        }
    }

    public static bool IsBGR(this DXGI_FORMAT format)
    {
        switch (format)
        {
            case DXGI_FORMAT_B5G6R5_UNORM:
            case Format.B5G5R5A1Unorm:
            case Format.B8G8R8A8Unorm:
            case Format.B8G8R8X8Unorm:
            case Format.B8G8R8A8Typeless:
            case Format.B8G8R8A8UnormSrgb:
            case Format.B8G8R8X8Typeless:
            case Format.B8G8R8X8UnormSrgb:
            case Format.B4G4R4A4Unorm:
            case Format.A4B4G4R4Unorm:
                return true;

            default:
                return false;
        }
    }

    public static void GetSurfaceInfo(
        this Format format,
        int width,
        int height,
        out int rowPitch,
        out int slicePitch,
        out int rowCount)
    {
        bool bc = false;
        bool packed = false;
        bool planar = false;
        int bpe = 0;

        switch (format)
        {
            case Format.BC1Typeless:
            case Format.BC1Unorm:
            case Format.BC1UnormSrgb:
            case Format.BC4Typeless:
            case Format.BC4Unorm:
            case Format.BC4Snorm:
                bc = true;
                bpe = 8;
                break;

            case Format.BC2Typeless:
            case Format.BC2Unorm:
            case Format.BC2UnormSrgb:
            case Format.BC3Typeless:
            case Format.BC3Unorm:
            case Format.BC3UnormSrgb:
            case Format.BC5Typeless:
            case Format.BC5Unorm:
            case Format.BC5Snorm:
            case Format.BC6HTypeless:
            case Format.BC6HUF16:
            case Format.BC6HSF16:
            case Format.BC7Typeless:
            case Format.BC7Unorm:
            case Format.BC7UnormSrgb:
                bc = true;
                bpe = 16;
                break;

            case Format.R8G8_B8G8Unorm:
            case Format.G8R8_G8B8Unorm:
            case Format.YUY2:
                packed = true;
                bpe = 4;
                break;

            case Format.Y210:
            case Format.Y216:
                packed = true;
                bpe = 8;
                break;

            case Format.NV12:
            case Format.Opaque420:
            case Format.P208:
                planar = true;
                bpe = 2;
                break;

            case Format.P010:
            case Format.P016:
                planar = true;
                bpe = 4;
                break;

            default:
                break;
        }

        if (bc)
        {
            int numBlocksWide = 0;
            if (width > 0)
            {
                numBlocksWide = Math.Max(1, (width + 3) / 4);
            }
            int numBlocksHigh = 0;
            if (height > 0)
            {
                numBlocksHigh = Math.Max(1, (height + 3) / 4);
            }
            rowPitch = numBlocksWide * bpe;
            rowCount = numBlocksHigh;
            slicePitch = rowPitch * numBlocksHigh;
        }
        else if (packed)
        {
            rowPitch = ((width + 1) >> 1) * bpe;
            rowCount = height;
            slicePitch = rowPitch * height;
        }
        else if (format == Format.NV11)
        {
            rowPitch = ((width + 3) >> 2) * 4;
            rowCount = height * 2; // Direct3D makes this simplifying assumption, although it is larger than the 4:1:1 data
            slicePitch = rowPitch * rowCount;
        }
        else if (planar)
        {
            rowPitch = ((width + 1) >> 1) * bpe;
            slicePitch = (rowPitch * height) + ((rowPitch * height + 1) >> 1);
            rowCount = (int)(height + ((height + 1u) >> 1));
        }
        else
        {
            int bpp = BitsPerPixel(format);
            rowPitch = (width * bpp + 7) / 8; // round up to nearest byte
            rowCount = height;
            slicePitch = rowPitch * height;
        }
    }

    public static void GetSurfaceInfo(this Format format, int width, int height, out int rowPitch, out int slicePitch)
    {
        GetSurfaceInfo(format, width, height, out rowPitch, out slicePitch, out _);
    }
}
