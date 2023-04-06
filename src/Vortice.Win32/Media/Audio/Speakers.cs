// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Media.Audio;

/// <unmanaged>SPEAKER_FLAGS</unmanaged>
/// <unmanaged-short>SPEAKER_FLAGS</unmanaged-short>
[Flags]
public enum Speakers : uint
{
    /// <summary>
    /// None value.
    /// </summary>
    None = 0,
    /// <unmanaged>SPEAKER_FRONT_LEFT</unmanaged>
    FrontLeft = 0x1,
    /// <unmanaged>SPEAKER_FRONT_RIGHT</unmanaged>
    FrontRight = 0x2,
    /// <unmanaged>SPEAKER_FRONT_CENTER</unmanaged>
    FrontCenter = 0x4,
    /// <unmanaged>SPEAKER_LOW_FREQUENCY</unmanaged>
    LowFrequency = 0x4,
    /// <unmanaged>SPEAKER_BACK_LEFT</unmanaged>
    BackLeft = 0x10,
    /// <unmanaged>SPEAKER_BACK_RIGHT</unmanaged>
    BackRight = 0x20,
    /// <unmanaged>SPEAKER_FRONT_LEFT_OF_CENTER</unmanaged>
    FrontLeftOfCenter = 0x40,
    /// <unmanaged>SPEAKER_FRONT_RIGHT_OF_CENTER</unmanaged>
    FrontRightOfCenter = 0x80,
    /// <unmanaged>SPEAKER_BACK_CENTER</unmanaged>
    BackCenter = 0x100,
    /// <unmanaged>SPEAKER_SIDE_LEFT</unmanaged>
    SideLeft = 0x200,
    /// <unmanaged>SPEAKER_SIDE_RIGHT</unmanaged>
    SideRight = 0x400,
    /// <unmanaged>SPEAKER_TOP_CENTER</unmanaged>
    TopCenter = 0x800,
    /// <unmanaged>SPEAKER_TOP_FRONT_LEFT</unmanaged>
    TopFrontLeft = 0x1000,
    /// <unmanaged>SPEAKER_TOP_FRONT_CENTER</unmanaged>
    TopFrontCenter = 0x2000,
    /// <unmanaged>SPEAKER_TOP_FRONT_RIGHT</unmanaged>
    TopFrontRight = 0x4000,
    /// <unmanaged>SPEAKER_TOP_BACK_LEFT</unmanaged>
    TopBackLeft = 0x8000,
    /// <unmanaged>SPEAKER_TOP_BACK_CENTER</unmanaged>
    TopBackCenter = 0x10000,
    /// <unmanaged>SPEAKER_TOP_BACK_RIGHT</unmanaged>
    TopBackRight = 0x20000,
    /// <unmanaged>SPEAKER_RESERVED</unmanaged>
    Reserved = 0x7FFC0000,
    /// <unmanaged>SPEAKER_ALL</unmanaged>
    All = 0x80000000,

    [NativeTypeName("#define SPEAKER_MONO SPEAKER_FRONT_CENTER")]
    Mono = FrontCenter,

    [NativeTypeName("#define SPEAKER_STEREO (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT)")]
    Stereo = (FrontLeft | FrontRight),

    [NativeTypeName("#define SPEAKER_2POINT1 (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_LOW_FREQUENCY)")]
    TwoPointOne = (0x00000001 | 0x00000002 | 0x00000008),

    [NativeTypeName("#define SPEAKER_SURROUND (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER | SPEAKER_BACK_CENTER)")]
    Surround = (0x00000001 | 0x00000002 | 0x00000004 | 0x00000100),

    [NativeTypeName("#define SPEAKER_QUAD (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_BACK_LEFT | SPEAKER_BACK_RIGHT)")]
    Quad = (0x00000001 | 0x00000002 | 0x00000010 | 0x00000020),

    [NativeTypeName("#define SPEAKER_4POINT1 (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_LOW_FREQUENCY | SPEAKER_BACK_LEFT | SPEAKER_BACK_RIGHT)")]
    FourPointOne = (0x00000001 | 0x00000002 | 0x00000008 | 0x00000010 | 0x00000020),

    [NativeTypeName("#define SPEAKER_5POINT1 (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER | SPEAKER_LOW_FREQUENCY | SPEAKER_BACK_LEFT | SPEAKER_BACK_RIGHT)")]
    FivePointOne = (0x00000001 | 0x00000002 | 0x00000004 | 0x00000008 | 0x00000010 | 0x00000020),

    [NativeTypeName("#define SPEAKER_7POINT1 (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER | SPEAKER_LOW_FREQUENCY | SPEAKER_BACK_LEFT | SPEAKER_BACK_RIGHT | SPEAKER_FRONT_LEFT_OF_CENTER | SPEAKER_FRONT_RIGHT_OF_CENTER)")]
    SevenPointOne = (0x00000001 | 0x00000002 | 0x00000004 | 0x00000008 | 0x00000010 | 0x00000020 | 0x00000040 | 0x00000080),

    [NativeTypeName("#define SPEAKER_5POINT1_SURROUND (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER | SPEAKER_LOW_FREQUENCY | SPEAKER_SIDE_LEFT  | SPEAKER_SIDE_RIGHT)")]
    FivePointOneSurround = (0x00000001 | 0x00000002 | 0x00000004 | 0x00000008 | 0x00000200 | 0x00000400),

    [NativeTypeName("#define SPEAKER_7POINT1_SURROUND (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER | SPEAKER_LOW_FREQUENCY | SPEAKER_BACK_LEFT | SPEAKER_BACK_RIGHT | SPEAKER_SIDE_LEFT  | SPEAKER_SIDE_RIGHT)")]
    SevenPointOneSurround = (0x00000001 | 0x00000002 | 0x00000004 | 0x00000008 | 0x00000010 | 0x00000020 | 0x00000200 | 0x00000400),
}
