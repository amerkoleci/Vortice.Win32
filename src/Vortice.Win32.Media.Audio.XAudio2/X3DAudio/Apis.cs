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

    [DllImport("xaudio2_9", ExactSpelling = true)]
    public static extern HResult X3DAudioInitialize(uint SpeakerChannelMask, float SpeedOfSound, out X3DAudioHandle Instance);

    [DllImport("xaudio2_9", ExactSpelling = true)]
    public static extern void X3DAudioCalculate(in X3DAudioHandle Instance, X3DAudioListener* pListener, X3DAudioEmitter* pEmitter, uint Flags, X3DAudioDSPSettings* pDSPSettings);
}
