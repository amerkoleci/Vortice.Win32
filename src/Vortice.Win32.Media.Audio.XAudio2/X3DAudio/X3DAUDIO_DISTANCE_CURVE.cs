// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Media.Audio;

/// <unmanaged>X3DAUDIO_DISTANCE_CURVE</unmanaged>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct X3DAUDIO_DISTANCE_CURVE
{
    public X3DAUDIO_DISTANCE_CURVE_POINT* pPoints;

    public uint PointCount;
}


