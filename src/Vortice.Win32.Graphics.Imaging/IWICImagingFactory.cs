// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Win32.Apis;

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
            ThrowIfFailed(CreateDecoderFromFilename(
                filenamePtr,
                null,
                nativeAccess,
                metadataOptions,
                decoder.GetAddressOf()));

            return decoder.Move();
        }
    }
}
