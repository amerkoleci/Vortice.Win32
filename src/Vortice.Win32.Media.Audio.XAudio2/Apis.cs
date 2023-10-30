// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Media.Audio.XAudio2;

public static unsafe partial class Apis
{
    public static void ReverbConvertI3DL2ToNative(
        [NativeTypeName("const XAUDIO2FX_REVERB_I3DL2_PARAMETERS *")] FXReverbI3DL2Parameters* pI3DL2,
        [NativeTypeName("XAUDIO2FX_REVERB_PARAMETERS *")] FXReverbParameters* pNative,
        [Optional, DefaultParameterValue(1)] Bool32 sevenDotOneReverb)
    {
        float reflectionsDelay;
        float reverbDelay;

        if (sevenDotOneReverb != 0)
        {
            pNative->RearDelay = 20;
        }
        else
        {
            pNative->RearDelay = 5;
        }

        pNative->SideDelay = 5;
        pNative->PositionLeft = 6;
        pNative->PositionRight = 6;
        pNative->PositionMatrixLeft = 27;
        pNative->PositionMatrixRight = 27;
        pNative->RoomSize = 100.0f;
        pNative->LowEQCutoff = 4;
        pNative->HighEQCutoff = 6;
        pNative->RoomFilterMain = (float)pI3DL2->Room / 100.0f;
        pNative->RoomFilterHF = (float)pI3DL2->RoomHF / 100.0f;

        if (pI3DL2->DecayHFRatio >= 1.0f)
        {
            int index = (int)(-4.0 * Math.Log10(pI3DL2->DecayHFRatio));

            if (index < -8)
            {
                index = -8;
            }

            pNative->LowEQGain = (byte)((index < 0) ? index + 8 : 8);
            pNative->HighEQGain = 8;
            pNative->DecayTime = pI3DL2->DecayTime * pI3DL2->DecayHFRatio;
        }
        else
        {
            int index = (int)(4.0 * Math.Log10(pI3DL2->DecayHFRatio));

            if (index < -8)
            {
                index = -8;
            }

            pNative->LowEQGain = 8;
            pNative->HighEQGain = (byte)((index < 0) ? index + 8 : 8);
            pNative->DecayTime = pI3DL2->DecayTime;
        }

        reflectionsDelay = pI3DL2->ReflectionsDelay * 1000.0f;
        if (reflectionsDelay >= 300)
        {
            reflectionsDelay = (float)(300 - 1);
        }
        else if (reflectionsDelay <= 1)
        {
            reflectionsDelay = 1;
        }

        pNative->ReflectionsDelay = (uint)reflectionsDelay;
        reverbDelay = pI3DL2->ReverbDelay * 1000.0f;
        if (reverbDelay >= 85)
        {
            reverbDelay = (float)(85 - 1);
        }

        pNative->ReverbDelay = (byte)reverbDelay;
        pNative->ReflectionsGain = pI3DL2->Reflections / 100.0f;
        pNative->ReverbGain = pI3DL2->Reverb / 100.0f;
        pNative->EarlyDiffusion = (byte)(15.0f * pI3DL2->Diffusion / 100.0f);
        pNative->LateDiffusion = pNative->EarlyDiffusion;
        pNative->Density = pI3DL2->Density;
        pNative->RoomFilterFreq = pI3DL2->HFReference;
        pNative->WetDryMix = pI3DL2->WetDryMix;
        pNative->DisableLateField = 0;
    }

    public static float XAudio2DecibelsToAmplitudeRatio(float Decibels)
    {
        return MathF.Pow(10.0f, Decibels / 20.0f);
    }

    public static float XAudio2AmplitudeRatioToDecibels(float Volume)
    {
        if (Volume == 0)
        {
            return -3.402823466e+38f;
        }

        return 20.0f * MathF.Log10(Volume);
    }

    public static float XAudio2SemitonesToFrequencyRatio(float Semitones)
    {
        return MathF.Pow(2.0f, Semitones / 12.0f);
    }

    public static float XAudio2FrequencyRatioToSemitones(float FrequencyRatio)
    {
        return 39.86313713864835f * MathF.Log10(FrequencyRatio);
    }

    public static float XAudio2CutoffFrequencyToRadians(float CutoffFrequency, [NativeTypeName("UINT32")] uint SampleRate)
    {
        if ((uint)(CutoffFrequency * 6.0f) >= SampleRate)
        {
            return 1.0f;
        }

        return 2.0f * MathF.Sin((float)3.14159265358979323846 * CutoffFrequency / SampleRate);
    }

    public static float XAudio2RadiansToCutoffFrequency(float Radians, float SampleRate)
    {
        return SampleRate * MathF.Asin(Radians / 2.0f) / (float)3.14159265358979323846;
    }

    public static float XAudio2CutoffFrequencyToOnePoleCoefficient(float CutoffFrequency, [NativeTypeName("UINT32")] uint SampleRate)
    {
        if ((uint)CutoffFrequency >= SampleRate)
        {
            return 1.0f;
        }

        return (1.0f - MathF.Pow(1.0f - 2.0f * CutoffFrequency / SampleRate, 2.0f));
    }

    /// <include file='XAudio2.xml' path='doc/member[@name="XAudio2Create"]/*' />
    [DllImport("XAudio2_9", ExactSpelling = true)]
    public static extern HResult XAudio2Create([NativeTypeName("IXAudio2 **")] IXAudio2** ppXAudio2, [NativeTypeName("UINT32")] uint Flags = 0, [NativeTypeName("XAUDIO2_PROCESSOR")] uint XAudio2Processor = XAUDIO2_DEFAULT_PROCESSOR);

    /// <include file='XAudio2.xml' path='doc/member[@name="XAudio2CreateVolumeMeter"]/*' />
    public static HResult XAudio2CreateVolumeMeter([NativeTypeName("IUnknown **")] IUnknown** ppApo)
    {
        return CreateAudioVolumeMeter(ppApo);
    }

    /// <include file='XAudio2.xml' path='doc/member[@name="XAudio2CreateReverb"]/*' />
    public static HResult XAudio2CreateReverb([NativeTypeName("IUnknown **")] IUnknown** ppApo)
    {
        return CreateAudioReverb(ppApo);
    }
}
