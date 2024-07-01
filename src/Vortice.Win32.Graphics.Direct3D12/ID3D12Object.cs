// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D12;

public static unsafe class ID3D12ObjectExtensions
{
    public static void SetName<TID3D12Object>(ref this TID3D12Object self, ReadOnlySpan<char> name)
        where TID3D12Object : unmanaged, ID3D12Object.Interface
    {
        fixed (char* namePtr = name)
        {
            _ = self.SetName(namePtr);
        }
    }

    public static void SetName<TID3D12Object>(ref this TID3D12Object self, string name)
        where TID3D12Object : unmanaged, ID3D12Object.Interface
    {
        fixed (char* namePtr = name)
        {
            _ = self.SetName(namePtr);
        }
    }
}
