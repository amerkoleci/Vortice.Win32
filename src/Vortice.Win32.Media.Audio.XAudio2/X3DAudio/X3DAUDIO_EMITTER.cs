// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Media.Audio;

/// <unmanaged>X3DAUDIO_EMITTER</unmanaged>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct X3DAUDIO_EMITTER
{
    public X3DAUDIO_CONE* pCone;

    public Vector3 OrientFront;

    public Vector3 OrientTop;

    public Vector3 Position;

    public Vector3 Velocity;

    public float InnerRadius;

    public float InnerRadiusAngle;

    public uint ChannelCount;

    public float ChannelRadius;

    public float* pChannelAzimuths;

    public X3DAUDIO_DISTANCE_CURVE* pVolumeCurve;

    public X3DAUDIO_DISTANCE_CURVE* pLFECurve;

    public X3DAUDIO_DISTANCE_CURVE* pLPFDirectCurve;

    public X3DAUDIO_DISTANCE_CURVE* pLPFReverbCurve;

    public X3DAUDIO_DISTANCE_CURVE* pReverbCurve;

    public float CurveDistanceScaler;

    public float DopplerScaler;
}


