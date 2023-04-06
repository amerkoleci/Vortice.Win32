// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Media.Audio.XAudio2;

/// <unmanaged>X3DAUDIO_DISTANCE_CURVE</unmanaged>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct X3DAudioDistanceCurve
{
    public X3DAudioDistanceCurvePoint* pPoints;

    public uint PointCount;
}


