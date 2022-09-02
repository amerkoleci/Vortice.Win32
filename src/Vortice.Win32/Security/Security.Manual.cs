// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Security;

public unsafe partial struct SECURITY_ATTRIBUTES
{
    [NativeTypeName("DWORD")]
    public uint nLength;

    [NativeTypeName("LPVOID")]
    public void* lpSecurityDescriptor;

    [NativeTypeName("BOOL")]
    public Bool32 bInheritHandle;
}

