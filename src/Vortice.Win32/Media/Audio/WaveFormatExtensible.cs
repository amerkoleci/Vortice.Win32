// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Media.Audio;

/// <unmanaged>WAVEFORMATEXTENSIBLE</unmanaged>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct WaveFormatExtensible
{
    public WaveFormatEx Format;

    [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/include/10.0.22621.0/shared/mmreg.h:2525:5)")]
    public _Samples_e__Union Samples;

    [NativeTypeName("DWORD")]
    public uint dwChannelMask;

    public Guid SubFormat;

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public partial struct _Samples_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("WORD")]
        public ushort wValidBitsPerSample;

        [FieldOffset(0)]
        [NativeTypeName("WORD")]
        public ushort wSamplesPerBlock;

        [FieldOffset(0)]
        [NativeTypeName("WORD")]
        public ushort wReserved;
    }
}
