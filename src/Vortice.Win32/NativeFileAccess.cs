// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32;

[Flags]
public enum NativeFileAccess : uint
{
    None = 0,
    [NativeTypeName("#define GENERIC_READ (0x80000000L)")]
    GenericRead = 0x80000000u,
    [NativeTypeName("#define GENERIC_WRITE (0x40000000L)")]
    GenericWrite = 0x40000000u,
}

public static class NativeFileAccessExtensions
{
    public static NativeFileAccess ToNative(this FileAccess access)
    {
        switch (access)
        {
            case FileAccess.Read:
                return NativeFileAccess.GenericRead;

            case FileAccess.Write:
                return NativeFileAccess.GenericWrite;

            case FileAccess.ReadWrite:
                return NativeFileAccess.GenericRead | NativeFileAccess.GenericWrite;
            default:
                return NativeFileAccess.None;
        }
    }
}
