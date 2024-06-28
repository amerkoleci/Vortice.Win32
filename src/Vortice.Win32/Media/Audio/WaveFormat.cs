// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Media.Audio;

/// <unmanaged>WAVEFORMAT</unmanaged>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct WaveFormat
{
    [NativeTypeName("WORD")]
    public ushort wFormatTag;

    [NativeTypeName("WORD")]
    public ushort nChannels;

    [NativeTypeName("DWORD")]
    public uint nSamplesPerSec;

    [NativeTypeName("DWORD")]
    public uint nAvgBytesPerSec;

    [NativeTypeName("WORD")]
    public ushort nBlockAlign;
}
