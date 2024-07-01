// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Media.Audio.XAudio2;

public static unsafe partial class Apis
{
    public static HResult X3DAudioInitialize(uint SpeakerChannelMask, out X3DAudioHandle Instance)
    {
        return X3DAudioInitialize(SpeakerChannelMask, X3DAUDIO_SPEED_OF_SOUND, out Instance);
    }

    public static void X3DAudioCalculate(in X3DAudioHandle Instance, X3DAudioListener* pListener, X3DAudioEmitter* pEmitter, X3DCalculateFlags Flags, X3DAudioDSPSettings* pDSPSettings)
    {
        X3DAudioCalculate(Instance, pListener, pEmitter, (uint)Flags, pDSPSettings);
    }

    [LibraryImport("xaudio2_9")]
    public static partial HResult X3DAudioInitialize(uint SpeakerChannelMask, float SpeedOfSound, out X3DAudioHandle Instance);

    [LibraryImport("xaudio2_9")]
    public static partial void X3DAudioCalculate(in X3DAudioHandle Instance, X3DAudioListener* pListener, X3DAudioEmitter* pEmitter, uint Flags, X3DAudioDSPSettings* pDSPSettings);

    [LibraryImport("xaudio2_9")]
    public static partial void X3DAudioCalculate(X3DAudioHandle* Instance, X3DAudioListener* pListener, X3DAudioEmitter* pEmitter, uint Flags, X3DAudioDSPSettings* pDSPSettings);
}
