// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Media.Audio;

public static unsafe partial class XAudio2
{
    public static HResult X3DAudioInitialize(uint SpeakerChannelMask, out X3DAUDIO_HANDLE Instance)
    {
        return X3DAudioInitialize(SpeakerChannelMask, X3DAUDIO_SPEED_OF_SOUND, out Instance);
    }

    public static void X3DAudioCalculate(in X3DAUDIO_HANDLE Instance, X3DAUDIO_LISTENER* pListener, X3DAUDIO_EMITTER* pEmitter, X3DAUDIO_CALCULATE_FLAGS Flags, X3DAUDIO_DSP_SETTINGS* pDSPSettings)
    {
        X3DAudioCalculate(Instance, pListener, pEmitter, (uint)Flags, pDSPSettings);
    }

    [LibraryImport("xaudio2_9")]
    public static partial HResult X3DAudioInitialize(uint SpeakerChannelMask, float SpeedOfSound, out X3DAUDIO_HANDLE Instance);

    [LibraryImport("xaudio2_9")]
    public static partial void X3DAudioCalculate(in X3DAUDIO_HANDLE Instance, X3DAUDIO_LISTENER* pListener, X3DAUDIO_EMITTER* pEmitter, uint Flags, X3DAUDIO_DSP_SETTINGS* pDSPSettings);

    [LibraryImport("xaudio2_9")]
    public static partial void X3DAudioCalculate(X3DAUDIO_HANDLE* Instance, X3DAUDIO_LISTENER* pListener, X3DAUDIO_EMITTER* pEmitter, uint Flags, X3DAUDIO_DSP_SETTINGS* pDSPSettings);
}
