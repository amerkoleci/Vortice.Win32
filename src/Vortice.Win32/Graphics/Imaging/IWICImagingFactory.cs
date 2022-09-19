// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Imaging;

public unsafe partial struct IWICImagingFactory
{
    public ComPtr<IWICBitmapDecoder> CreateDecoderFromFilename(
        string filename,
        FileAccess desiredAccess = FileAccess.Read,
        WICDecodeOptions metadataOptions = WICDecodeOptions.CacheOnDemand)
    {
        return CreateDecoderFromFilename(filename.AsSpan(), desiredAccess, metadataOptions);
    }

    public ComPtr<IWICBitmapDecoder> CreateDecoderFromFilename(
        ReadOnlySpan<char> filename,
        FileAccess desiredAccess = FileAccess.Read,
        WICDecodeOptions metadataOptions = WICDecodeOptions.CacheOnDemand)
    {
        NativeFileAccess nativeAccess = desiredAccess.ToNative();

        using ComPtr<IWICBitmapDecoder> decoder = default;

        fixed (char* filenamePtr = filename)
        {
            CreateDecoderFromFilename(
                (ushort*)filenamePtr,
                null,
                nativeAccess,
                metadataOptions,
                decoder.GetAddressOf()).ThrowIfFailed();

            return decoder.Move();
        }
    }
}
