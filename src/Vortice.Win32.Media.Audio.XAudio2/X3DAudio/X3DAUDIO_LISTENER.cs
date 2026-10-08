// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Media.Audio;

/// <unmanaged>X3DAUDIO_LISTENER</unmanaged>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct X3DAUDIO_LISTENER
{
    public Vector3 OrientFront;

    public Vector3 OrientTop;

    public Vector3 Position;

    public Vector3 Velocity;

    public unsafe X3DAUDIO_CONE* pCone;
}


