// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Media.Audio.XAudio2;

/// <unmanaged>X3DAUDIO_DSP_SETTINGS</unmanaged>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct X3DAudioDSPSettings
{
    public float* pMatrixCoefficients;

    public float* pDelayTimes;

    public uint SrcChannelCount;

    public uint DstChannelCount;

    public float LPFDirectCoefficient;

    public float LPFReverbCoefficient;

    public float ReverbLevel;

    public float DopplerFactor;

    public float EmitterToListenerAngle;

    public float EmitterToListenerDistance;

    public float EmitterVelocityComponent;

    public float ListenerVelocityComponent;
}


