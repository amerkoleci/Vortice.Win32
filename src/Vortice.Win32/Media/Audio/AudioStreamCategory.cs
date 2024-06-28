// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Media.Audio;

/// <unmanaged>AUDIO_STREAM_CATEGORY</unmanaged>
public enum AudioStreamCategory
{
    Other = 0,
    ForegroundOnlyMedia = 1,
    Communications = 3,
    Alerts = 4,
    SoundEffects = 5,
    GameEffects = 6,
    GameMedia = 7,
    GameChat = 8,
    Speech = 9,
    Movie = 10,
    Media = 11,
    FarFieldSpeech = 12,
    UniformSpeech = 13,
    VoiceTyping = 14,
}
