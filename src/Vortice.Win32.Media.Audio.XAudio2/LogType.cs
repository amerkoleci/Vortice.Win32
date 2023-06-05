// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Win32.Media.Audio.XAudio2.Apis;

namespace Win32.Media.Audio.XAudio2;

[Flags]
public enum LogType : uint
{
    None,
    /// <unmanaged>XAUDIO2_LOG_ERRORS</unmanaged>
    /// <unmanaged-short>XAUDIO2_LOG_ERRORS</unmanaged-short>
    Errors = XAUDIO2_LOG_ERRORS,
    /// <unmanaged>XAUDIO2_LOG_WARNINGS</unmanaged>
    /// <unmanaged-short>XAUDIO2_LOG_WARNINGS</unmanaged-short>
    Warnings = XAUDIO2_LOG_WARNINGS,
    /// <unmanaged>XAUDIO2_LOG_INFO</unmanaged>
    /// <unmanaged-short>XAUDIO2_LOG_INFO</unmanaged-short>
    Info = XAUDIO2_LOG_INFO,
    /// <unmanaged>XAUDIO2_LOG_DETAIL</unmanaged>
    /// <unmanaged-short>XAUDIO2_LOG_DETAIL</unmanaged-short>
    Detail = XAUDIO2_LOG_DETAIL,
    /// <unmanaged>XAUDIO2_LOG_API_CALLS</unmanaged>
    /// <unmanaged-short>XAUDIO2_LOG_API_CALLS</unmanaged-short>
    ApiCalls = XAUDIO2_LOG_API_CALLS,
    /// <unmanaged>XAUDIO2_LOG_FUNC_CALLS</unmanaged>
    /// <unmanaged-short>XAUDIO2_LOG_FUNC_CALLS</unmanaged-short>
    FuncCalls = XAUDIO2_LOG_FUNC_CALLS,
    /// <unmanaged>XAUDIO2_LOG_TIMING</unmanaged>
    /// <unmanaged-short>XAUDIO2_LOG_TIMING</unmanaged-short>
    Timing = XAUDIO2_LOG_TIMING,
    /// <unmanaged>XAUDIO2_LOG_LOCKS</unmanaged>
    /// <unmanaged-short>XAUDIO2_LOG_LOCKS</unmanaged-short>
    Locks = XAUDIO2_LOG_LOCKS,
    /// <unmanaged>XAUDIO2_LOG_MEMORY</unmanaged>
    /// <unmanaged-short>XAUDIO2_LOG_MEMORY</unmanaged-short>
    Memory = XAUDIO2_LOG_MEMORY,
    /// <unmanaged>XAUDIO2_LOG_STREAMING</unmanaged>
    /// <unmanaged-short>XAUDIO2_LOG_STREAMING</unmanaged-short>
    Streaming = XAUDIO2_LOG_STREAMING,
}
