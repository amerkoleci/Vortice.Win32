// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Win32.Media.Audio.XAudio2.Apis;

namespace Win32.Media.Audio.XAudio2;

[Flags]
public enum X3DCalculateFlags : uint
{
    None = 0,
    /// <unmanaged>X3DAUDIO_CALCULATE_MATRIX</unmanaged>
	Matrix = X3DAUDIO_CALCULATE_MATRIX,
    /// <unmanaged>X3DAUDIO_CALCULATE_DELAY</unmanaged>
    Delay = X3DAUDIO_CALCULATE_DELAY,
    /// <unmanaged>X3DAUDIO_CALCULATE_LPF_DIRECT</unmanaged>
    LpfDirect = X3DAUDIO_CALCULATE_LPF_DIRECT,
    /// <unmanaged>X3DAUDIO_CALCULATE_LPF_REVERB</unmanaged>
    LpfReverb = X3DAUDIO_CALCULATE_LPF_REVERB,
    /// <unmanaged>X3DAUDIO_CALCULATE_REVERB</unmanaged>
    Reverb = X3DAUDIO_CALCULATE_REVERB,
    /// <unmanaged>X3DAUDIO_CALCULATE_DOPPLER</unmanaged>
    Doppler = X3DAUDIO_CALCULATE_DOPPLER,
    /// <unmanaged>X3DAUDIO_CALCULATE_EMITTER_ANGLE</unmanaged>
    EmitterAngle = X3DAUDIO_CALCULATE_EMITTER_ANGLE,
    /// <unmanaged>X3DAUDIO_CALCULATE_ZEROCENTER</unmanaged>
    ZeroCenter = X3DAUDIO_CALCULATE_ZEROCENTER,
    /// <unmanaged>X3DAUDIO_CALCULATE_REDIRECT_TO_LFE</unmanaged>
    RedirectToLfe = X3DAUDIO_CALCULATE_REDIRECT_TO_LFE,
}


