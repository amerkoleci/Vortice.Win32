// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Apis;
using static Vortice.Win32.Graphics.Imaging.Apis;

namespace Vortice.Win32.Graphics.Imaging.D2D;

public static unsafe partial class Apis
{
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
