// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Media.Audio.XAudio2;

/// <unmanaged>X3DAUDIO_CONE</unmanaged>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct X3DAudioCone
{
    [NativeTypeName("FLOAT32")]
    public float InnerAngle;

    [NativeTypeName("FLOAT32")]
    public float OuterAngle;

    [NativeTypeName("FLOAT32")]
    public float InnerVolume;

    [NativeTypeName("FLOAT32")]
    public float OuterVolume;

    [NativeTypeName("FLOAT32")]
    public float InnerLPF;
}


