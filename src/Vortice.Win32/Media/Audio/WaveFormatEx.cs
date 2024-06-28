// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Media.Audio;

/// <unmanaged>WAVEFORMATEX</unmanaged>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct WaveFormatEx
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

    [NativeTypeName("WORD")]
    public ushort wBitsPerSample;

    [NativeTypeName("WORD")]
    public ushort cbSize;
}
