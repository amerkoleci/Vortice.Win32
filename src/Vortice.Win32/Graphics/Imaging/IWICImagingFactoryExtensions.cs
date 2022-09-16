// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Imaging;

/// <summary>
/// A <see langword="class"/> with extensions for the <see cref="IWICImagingFactory"/> type.
/// </summary>
public static unsafe class IWICImagingFactoryExtensions
{
    public static ComPtr<IWICBitmapDecoder> CreateDecoderFromFilename(
        this ref IWICImagingFactory factory,
        string filename,
        FileAccess desiredAccess = FileAccess.Read,
        WICDecodeOptions metadataOptions = WICDecodeOptions.CacheOnDemand)
    {
        return CreateDecoderFromFilename(ref factory, filename.AsSpan(), desiredAccess, metadataOptions);
    }

    public static ComPtr<IWICBitmapDecoder> CreateDecoderFromFilename(
        this ref IWICImagingFactory factory,
        ReadOnlySpan<char> filename,
        FileAccess desiredAccess = FileAccess.Read,
        WICDecodeOptions metadataOptions = WICDecodeOptions.CacheOnDemand)
    {
        NativeFileAccess nativeAccess = desiredAccess.ToNative();

        using ComPtr<IWICBitmapDecoder> decoder = default;

        fixed (char* filenamePtr = filename)
        {
            factory.CreateDecoderFromFilename(
                (ushort*)filenamePtr,
                null,
                nativeAccess,
                metadataOptions,
                decoder.GetAddressOf()).ThrowIfFailed();

            return decoder.Move();
        }
    }
}
