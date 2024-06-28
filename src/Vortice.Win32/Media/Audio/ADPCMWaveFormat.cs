// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Media.Audio;

/// <unmanaged>ADPCMWAVEFORMAT</unmanaged>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct ADPCMWaveFormat
{
    public WaveFormatEx wfx;

    [NativeTypeName("WORD")]
    public ushort wSamplesPerBlock;

    [NativeTypeName("WORD")]
    public ushort wNumCoef;

    [NativeTypeName("ADPCMCOEFSET[]")]
    public _aCoef_e__FixedBuffer aCoef;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _aCoef_e__FixedBuffer
    {
        public ADPCMCoefSet e0;

        [UnscopedRef]
        public ref ADPCMCoefSet this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<ADPCMCoefSet> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
