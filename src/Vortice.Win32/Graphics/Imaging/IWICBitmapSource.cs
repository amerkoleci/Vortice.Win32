// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Drawing;

namespace Win32.Graphics.Imaging;

public unsafe partial struct IWICBitmapSource
{
    public HResult CopyPixels<T>(int stride, ReadOnlySpan<T> data)
        where T : unmanaged
    {
        fixed (T* dataPtr = data)
        {
            return CopyPixels(null, (uint)stride, (uint)(data.Length * sizeof(T)), (byte*)dataPtr);
        }
    }

    public HResult CopyPixels<T>(Rectangle rect, int stride, ReadOnlySpan<T> data)
        where T : unmanaged
    {
        fixed (T* dataPtr = data)
        {
            return CopyPixels(&rect, (uint)stride, (uint)(data.Length * sizeof(T)), (byte*)dataPtr);
        }
    }
}
