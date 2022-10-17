// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D12;

public partial struct ID3D12Object
{
    public unsafe HResult SetName(ReadOnlySpan<char> name)
    {
        fixed (char* namePtr = name)
        {
            return SetName((ushort*)namePtr);
        }
    }

    public unsafe HResult SetName(string name)
    {
        fixed (char* namePtr = name)
        {
            return SetName((ushort*)namePtr);
        }
    }
}
