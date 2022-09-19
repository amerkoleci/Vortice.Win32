// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Runtime.CompilerServices;
using Win32.Graphics.Imaging.D2D;
using static Win32.Apis;

namespace Win32.Graphics.Imaging;

public static unsafe partial class Apis
{
    public static HResult CreateWICImagingFactory(IWICImagingFactory** factory)
    {
        return CoCreateInstance(
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in CLSID_WICImagingFactory)),
            null,
            CLSCTX_INPROC_SERVER,
            __uuidof<IWICImagingFactory>(),
            (void**)factory);
    }

    public static HResult CreateWICImagingFactory(IWICImagingFactory2** factory)
    {
        return CoCreateInstance(
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in CLSID_WICImagingFactory2)),
            null,
            CLSCTX_INPROC_SERVER,
            __uuidof<IWICImagingFactory2>(),
            (void**)factory);
    }
}
