// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Media.Audio;

/// <unmanaged>PCMWAVEFORMAT</unmanaged>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct PCMWaveFormat
{
    public WaveFormat wf;

    [NativeTypeName("WORD")]
    public ushort wBitsPerSample;
}
