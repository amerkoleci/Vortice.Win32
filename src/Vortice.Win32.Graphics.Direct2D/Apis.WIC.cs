// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Apis;
using static Vortice.Win32.Graphics.WIC;

namespace Vortice.Win32.Graphics;

public static unsafe partial class D2D1
{
    public static HResult CreateWICImagingFactory2(IWICImagingFactory2** factory)
    {
        return CoCreateInstance(
            (Guid*)Unsafe.AsPointer(in CLSID_WICImagingFactory2),
            null,
            CLSCTX_INPROC_SERVER,
            __uuidof<IWICImagingFactory2>(),
            (void**)factory);
    }
}
