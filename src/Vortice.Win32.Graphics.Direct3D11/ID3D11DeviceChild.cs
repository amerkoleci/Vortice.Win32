// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.StringUtilities;
using static Vortice.Win32.Graphics.D3D;

namespace Vortice.Win32.Graphics;

public static unsafe class ID3D11DeviceChildExtensions
{
    public static string? GetDebugName<TD3D11DeviceChild>(ref this TD3D11DeviceChild self)
        where TD3D11DeviceChild : unmanaged, ID3D11DeviceChild.Interface
    {
        byte* pname = stackalloc byte[1024];
        uint size = 1024 - 1;
        var guid = WKPDID_D3DDebugObjectName;
        if (self.GetPrivateData(&guid, &size, pname).Failure)
        {
            return string.Empty;
        }

        pname[size] = 0;
        return GetString(pname);
    }

    public static void SetDebugName<TD3D11DeviceChild>(ref this TD3D11DeviceChild self, string? value)
        where TD3D11DeviceChild : unmanaged, ID3D11DeviceChild.Interface
    {
        var guid = WKPDID_D3DDebugObjectName;
        if (string.IsNullOrEmpty(value))
        {
            _ = self.SetPrivateData(&guid, 0, null);
        }
        else
        {
            fixed (byte* valuePtr = value.GetUtf8Span())
            {
                _ = self.SetPrivateData(&guid, (uint)value!.Length, valuePtr);
            }
        }
    }
}
