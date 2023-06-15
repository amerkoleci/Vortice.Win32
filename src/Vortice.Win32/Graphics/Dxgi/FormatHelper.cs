// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Dxgi.Common;

/// <summary>
/// Helper to use with <see cref="Format"/>.
/// </summary>
public static class FormatHelper
{
    /// <summary>
    /// Return the BPP for a given <see cref="Format"/>.
    /// </summary>
    /// <param name="format">The DXGI format.</param>
    /// <returns>BPP of </returns>
    public static int BitsPerPixel(this Format format)
    {
        switch (format)
        {
            case Format.R32G32B32A32Typeless:
            case Format.R32G32B32A32Float:
            case Format.R32G32B32A32Uint:
            case Format.R32G32B32A32Sint:
                return 128;

            case Format.R32G32B32Typeless:
            case Format.R32G32B32Float:
            case Format.R32G32B32Uint:
            case Format.R32G32B32Sint:
                return 96;

            case Format.R16G16B16A16Typeless:
            case Format.R16G16B16A16Float:
            case Format.R16G16B16A16Unorm:
            case Format.R16G16B16A16Uint:
            case Format.R16G16B16A16Snorm:
            case Format.R16G16B16A16Sint:
            case Format.R32G32Typeless:
            case Format.R32G32Float:
            case Format.R32G32Uint:
            case Format.R32G32Sint:
            case Format.R32G8X24Typeless:
            case Format.D32FloatS8X24Uint:
            case Format.R32FloatX8X24Typeless:
            case Format.X32TypelessG8X24Uint:
            case Format.Y416:
            case Format.Y210:
            case Format.Y216:
                return 64;

            case Format.R10G10B10A2Typeless:
            case Format.R10G10B10A2Unorm:
            case Format.R10G10B10A2Uint:
            case Format.R11G11B10Float:
            case Format.R8G8B8A8Typeless:
            case Format.R8G8B8A8Unorm:
            case Format.R8G8B8A8UnormSrgb:
            case Format.R8G8B8A8Snorm:
            case Format.R8G8B8A8Uint:
            case Format.R8G8B8A8Sint:
            case Format.R16G16Typeless:
            case Format.R16G16Float:
            case Format.R16G16Unorm:
            case Format.R16G16Snorm:
            case Format.R16G16Uint:
            case Format.R16G16Sint:
            case Format.R32Typeless:
            case Format.D32Float:
            case Format.R32Float:
            case Format.R32Uint:
            case Format.R32Sint:
            case Format.R24G8Typeless:
            case Format.D24UnormS8Uint:
            case Format.R24UnormX8Typeless:
            case Format.X24TypelessG8Uint:
            case Format.R9G9B9E5SharedExp:
            case Format.R8G8_B8G8Unorm:
            case Format.G8R8_G8B8Unorm:
            case Format.B8G8R8A8Unorm:
            case Format.B8G8R8X8Unorm:
            case Format.R10G10B10XRBiasA2Unorm:
            case Format.B8G8R8A8Typeless:
            case Format.B8G8R8A8UnormSrgb:
            case Format.B8G8R8X8Typeless:
            case Format.B8G8R8X8UnormSrgb:
            case Format.AYUV:
            case Format.Y410:
            case Format.YUY2:
            case Format.Xbox_R10G10B10_7E3_A2Float:
            case Format.Xbox_R10G10B10_6E4_A2Float:
            case Format.Xbox_R10G10B10Snorm_A2Unorm:
                return 32;

            case Format.P010:
            case Format.P016:
            case Format.Xbox_D16Unorm_S8Uint:
            case Format.Xbox_R16Unorm_X8Typeless:
            case Format.Xbox_X16Typeless_G8Uint:
            case Format.V408:
                return 24;

            case Format.R8G8Typeless:
            case Format.R8G8Unorm:
            case Format.R8G8Uint:
            case Format.R8G8Snorm:
            case Format.R8G8Sint:
            case Format.R16Typeless:
            case Format.R16Float:
            case Format.D16Unorm:
            case Format.R16Unorm:
            case Format.R16Uint:
            case Format.R16Snorm:
            case Format.R16Sint:
            case Format.B5G6R5Unorm:
            case Format.B5G5R5A1Unorm:
            case Format.A8P8:
            case Format.B4G4R4A4Unorm:
            case Format.P208:
            case Format.V208:
            case Format.A4B4G4R4Unorm:
                return 16;

            case Format.NV12:
            case Format.Opaque420:
            case Format.NV11:
                return 12;

            case Format.R8Typeless:
            case Format.R8Unorm:
            case Format.R8Uint:
            case Format.R8Snorm:
            case Format.R8Sint:
            case Format.A8Unorm:
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
            case Format.AI44:
            case Format.IA44:
            case Format.P8:
            case Format.Xbox_R4G4Unorm:
                return 8;

            case Format.R1Unorm:
                return 1;

            case Format.BC1Typeless:
            case Format.BC1Unorm:
            case Format.BC1UnormSrgb:
            case Format.BC4Typeless:
            case Format.BC4Unorm:
            case Format.BC4Snorm:
                return 4;

            default:
                return 0;
        }
    }

    public static int BitsPerColor(this Format format)
    {
        switch (format)
        {
            case Format.R32G32B32A32Typeless:
            case Format.R32G32B32A32Float:
            case Format.R32G32B32A32Uint:
            case Format.R32G32B32A32Sint:
            case Format.R32G32B32Typeless:
            case Format.R32G32B32Float:
            case Format.R32G32B32Uint:
            case Format.R32G32B32Sint:
            case Format.R32G32Typeless:
            case Format.R32G32Float:
            case Format.R32G32Uint:
            case Format.R32G32Sint:
            case Format.R32G8X24Typeless:
            case Format.D32FloatS8X24Uint:
            case Format.R32FloatX8X24Typeless:
            case Format.X32TypelessG8X24Uint:
            case Format.R32Typeless:
            case Format.D32Float:
            case Format.R32Float:
            case Format.R32Uint:
            case Format.R32Sint:
                return 32;

            case Format.R24G8Typeless:
            case Format.D24UnormS8Uint:
            case Format.R24UnormX8Typeless:
            case Format.X24TypelessG8Uint:
                return 24;

            case Format.R16G16B16A16Typeless:
            case Format.R16G16B16A16Float:
            case Format.R16G16B16A16Unorm:
            case Format.R16G16B16A16Uint:
            case Format.R16G16B16A16Snorm:
            case Format.R16G16B16A16Sint:
            case Format.R16G16Typeless:
            case Format.R16G16Float:
            case Format.R16G16Unorm:
            case Format.R16G16Uint:
            case Format.R16G16Snorm:
            case Format.R16G16Sint:
            case Format.R16Typeless:
            case Format.R16Float:
            case Format.D16Unorm:
            case Format.R16Unorm:
            case Format.R16Uint:
            case Format.R16Snorm:
            case Format.R16Sint:
            case Format.BC6HTypeless:
            case Format.BC6HUF16:
            case Format.BC6HSF16:
            case Format.Y416:
            case Format.P016:
            case Format.Y216:
            case Format.Xbox_D16Unorm_S8Uint:
            case Format.Xbox_R16Unorm_X8Typeless:
            case Format.Xbox_X16Typeless_G8Uint:
                return 16;

            case Format.R9G9B9E5SharedExp:
                return 14;

            case Format.R11G11B10Float:
                return 11;

            case Format.R10G10B10A2Typeless:
            case Format.R10G10B10A2Unorm:
            case Format.R10G10B10A2Uint:
            case Format.R10G10B10XRBiasA2Unorm:
            case Format.Y410:
            case Format.P010:
            case Format.Y210:
            case Format.Xbox_R10G10B10_7E3_A2Float:
            case Format.Xbox_R10G10B10_6E4_A2Float:
            case Format.Xbox_R10G10B10Snorm_A2Unorm:
                return 10;

            case Format.R8G8B8A8Typeless:
            case Format.R8G8B8A8Unorm:
            case Format.R8G8B8A8UnormSrgb:
            case Format.R8G8B8A8Uint:
            case Format.R8G8B8A8Snorm:
            case Format.R8G8B8A8Sint:
            case Format.R8G8Typeless:
            case Format.R8G8Unorm:
            case Format.R8G8Uint:
            case Format.R8G8Snorm:
            case Format.R8G8Sint:
            case Format.R8Typeless:
            case Format.R8Unorm:
            case Format.R8Uint:
            case Format.R8Snorm:
            case Format.R8Sint:
            case Format.A8Unorm:
            case Format.R8G8_B8G8Unorm:
            case Format.G8R8_G8B8Unorm:
            case Format.BC4Typeless:
            case Format.BC4Unorm:
            case Format.BC4Snorm:
            case Format.BC5Typeless:
            case Format.BC5Unorm:
            case Format.BC5Snorm:
            case Format.B8G8R8A8Unorm:
            case Format.B8G8R8X8Unorm:
            case Format.B8G8R8A8Typeless:
            case Format.B8G8R8A8UnormSrgb:
            case Format.B8G8R8X8Typeless:
            case Format.B8G8R8X8UnormSrgb:
            case Format.AYUV:
            case Format.NV12:
            case Format.Opaque420:
            case Format.YUY2:
            case Format.NV11:
            case Format.P208:
            case Format.V208:
            case Format.V408:
                return 8;

            case Format.BC7Typeless:
            case Format.BC7Unorm:
            case Format.BC7UnormSrgb:
                return 7;

            case Format.BC1Typeless:
            case Format.BC1Unorm:
            case Format.BC1UnormSrgb:
            case Format.BC2Typeless:
            case Format.BC2Unorm:
            case Format.BC2UnormSrgb:
            case Format.BC3Typeless:
            case Format.BC3Unorm:
            case Format.BC3UnormSrgb:
            case Format.B5G6R5Unorm:
                return 6;

            case Format.B5G5R5A1Unorm:
                return 5;

            case Format.B4G4R4A4Unorm:
            case Format.Xbox_R4G4Unorm:
            case Format.A4B4G4R4Unorm:
                return 4;

            case Format.R1Unorm:
                return 1;

            // Palettized formats return 0 for this function
            case Format.AI44:
            case Format.IA44:
            case Format.P8:
            case Format.A8P8:
            default:
                return 0;
        }
    }

    /// <summary>
    /// Returns true if the <see cref="Format"/> is valid.
    /// </summary>
    /// <param name="format">A format to validate</param>
    /// <returns>True if the <see cref="Format"/> is valid.</returns>
    public static bool IsValid(this Format format)
    {
        return ((int)(format) >= 1 && (int)(format) <= 191);
    }

    /// <summary>
    /// Returns true if the <see cref="Format"/> is a compressed format.
    /// </summary>
    /// <param name="format">The format to check for compressed.</param>
    /// <returns>True if the <see cref="Format"/> is a compressed format</returns>
    public static bool IsCompressed(this Format format)
    {
        switch (format)
        {
            case Format.BC1Typeless:
            case Format.BC1Unorm:
            case Format.BC1UnormSrgb:
            case Format.BC2Typeless:
            case Format.BC2Unorm:
            case Format.BC2UnormSrgb:
            case Format.BC3Typeless:
            case Format.BC3Unorm:
            case Format.BC3UnormSrgb:
            case Format.BC4Typeless:
            case Format.BC4Unorm:
            case Format.BC4Snorm:
            case Format.BC5Typeless:
            case Format.BC5Unorm:
            case Format.BC5Snorm:
            case Format.BC6HTypeless:
            case Format.BC6HUF16:
            case Format.BC6HSF16:
            case Format.BC7Typeless:
            case Format.BC7Unorm:
            case Format.BC7UnormSrgb:
                return true;

            default:
                return false;
        }
    }

    /// <summary>
    /// Determines whether the specified <see cref="Format"/> is packed.
    /// </summary>
    /// <param name="format">The DXGI Format.</param>
    /// <returns><c>true</c> if the specified <see cref="Format"/> is packed; otherwise, <c>false</c>.</returns>
    public static bool IsPacked(this Format format)
    {
        switch (format)
        {
            case Format.R8G8_B8G8Unorm:
            case Format.G8R8_G8B8Unorm:
            case Format.YUY2: // 4:2:2 8-bit
            case Format.Y210: // 4:2:2 10-bit
            case Format.Y216: // 4:2:2 16-bit
                return true;

            default:
                return false;
        }
    }

    /// <summary>
    /// Determines whether the specified <see cref="Format"/> is video.
    /// </summary>
    /// <param name="format">The <see cref="Format"/>.</param>
    /// <returns><c>true</c> if the specified <see cref="Format"/> is video; otherwise, <c>false</c>.</returns>
    public static bool IsVideo(this Format format)
    {
        switch (format)
        {
            case Format.AYUV:
            case Format.Y410:
            case Format.Y416:
            case Format.NV12:
            case Format.P010:
            case Format.P016:
            case Format.YUY2:
            case Format.Y210:
            case Format.Y216:
            case Format.NV11:
            // These video formats can be used with the 3D pipeline through special view mappings

            case Format.Opaque420:
            case Format.AI44:
            case Format.IA44:
            case Format.P8:
            case Format.A8P8:
            // These are limited use video formats not usable in any way by the 3D pipeline

            case Format.P208:
            case Format.V208:
            case Format.V408:
                // These video formats are for JPEG Hardware decode (DXGI 1.4)
                return true;

            default:
                return false;
        }
    }

    public static bool IsPlanar(this Format format)
    {
        switch (format)
        {
            case Format.NV12:      // 4:2:0 8-bit
            case Format.P010:      // 4:2:0 10-bit
            case Format.P016:      // 4:2:0 16-bit
            case Format.Opaque420:// 4:2:0 8-bit
            case Format.NV11:      // 4:1:1 8-bit

            case Format.P208: // 4:2:2 8-bit
            case Format.V208: // 4:4:0 8-bit
            case Format.V408: // 4:4:4 8-bit
                              // These are JPEG Hardware decode formats (DXGI 1.4)
            case Format.Xbox_D16Unorm_S8Uint:
            case Format.Xbox_R16Unorm_X8Typeless:
            case Format.Xbox_X16Typeless_G8Uint:
                // These are Xbox One platform specific types
                return true;

            default:
                return false;
        }
    }

    public static bool IsPalettized(this Format format)
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

    public static bool IsDepthStencil(this Format format)
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
    /// <param name="format">The <see cref="Format"/>.</param>
    /// <returns><c>true</c> if the specified <see cref="Format"/> is a SRGB format; otherwise, <c>false</c>.</returns>
    public static bool IsSRGB(this Format format)
    {
        switch (format)
        {
            case Format.R8G8B8A8UnormSrgb:
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

    public static bool IsBGR(this Format format)
    {
        switch (format)
        {
            case Format.B5G6R5Unorm:
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
