// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Media.Audio.XAudio2;

/// <unmanaged>X3DAUDIO_LISTENER</unmanaged>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct X3DAudioListener
{
    public Vector3 OrientFront;

    public Vector3 OrientTop;

    public Vector3 Position;

    public Vector3 Velocity;

    public unsafe X3DAudioCone* pCone;
}


