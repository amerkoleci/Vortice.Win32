// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Media.Audio;

/// <unmanaged>ADPCMCOEFSET</unmanaged>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct ADPCMCoefSet
{
    public short iCoef1;

    public short iCoef2;
}
