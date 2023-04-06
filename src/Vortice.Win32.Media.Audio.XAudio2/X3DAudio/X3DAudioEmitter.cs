// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Media.Audio.XAudio2;

/// <unmanaged>X3DAUDIO_EMITTER</unmanaged>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct X3DAudioEmitter
{
    public X3DAudioCone* pCone;

    public Vector3 OrientFront;

    public Vector3 OrientTop;

    public Vector3 Position;

    public Vector3 Velocity;

    public float InnerRadius;

    public float InnerRadiusAngle;

    public uint ChannelCount;

    public float ChannelRadius;

    public float* pChannelAzimuths;

    public X3DAudioDistanceCurve* pVolumeCurve;

    public X3DAudioDistanceCurve* pLFECurve;

    public X3DAudioDistanceCurve* pLPFDirectCurve;

    public X3DAudioDistanceCurve* pLPFReverbCurve;

    public X3DAudioDistanceCurve* pReverbCurve;

    public float CurveDistanceScaler;

    public float DopplerScaler;
}


