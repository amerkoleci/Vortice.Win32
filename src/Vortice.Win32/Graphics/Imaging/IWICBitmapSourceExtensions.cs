// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Drawing;

namespace Win32.Graphics.Imaging;

/// <summary>
/// A <see langword="class"/> with extensions for the <see cref="IWICBitmapSource"/> type.
/// </summary>
public static unsafe class IWICBitmapSourceExtensions
{
    public static HResult CopyPixels<T>(this ref IWICBitmapSource source, int stride, ReadOnlySpan<T> data)
        where T : unmanaged
    {
        fixed (T* dataPtr = data)
        {
            return source.CopyPixels(null, (uint)stride, (uint)(data.Length * sizeof(T)), (byte*)dataPtr);
        }
    }

    public static HResult CopyPixels<T>(this ref IWICBitmapSource source, Rectangle rect, int stride, ReadOnlySpan<T> data)
        where T : unmanaged
    {
        fixed (T* dataPtr = data)
        {
            return source.CopyPixels(&rect, (uint)stride, (uint)(data.Length * sizeof(T)), (byte*)dataPtr);
        }
    }
}
