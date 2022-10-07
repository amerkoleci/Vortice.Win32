// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Runtime.CompilerServices;

namespace Win32.Graphics.Direct3D.Dxc;

public static unsafe partial class Apis
{
    public static HResult DxcCreateInstance(in Guid rclsid, Guid* riid, void** ppv)
    {
        return DxcCreateInstance(
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in rclsid)),
            riid,
            ppv);
    }

    public static HResult DxcCreateInstance2(Com.IMalloc* pMalloc, in Guid rclsid, Guid* riid, void** ppv)
    {
        return DxcCreateInstance2(
            pMalloc,
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in rclsid)),
            riid,
            ppv);
    }
}
