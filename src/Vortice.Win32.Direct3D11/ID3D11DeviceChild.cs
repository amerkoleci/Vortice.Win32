// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Win32.Graphics.Direct3D.Apis;
using static Win32.StringUtilities;

namespace Win32.Graphics.Direct3D11;

public unsafe partial struct ID3D11DeviceChild
{
    public static Guid* D3DDebugObjectNameGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in WKPDID_D3DDebugObjectName));

    /// <summary>
    /// Gets or sets the debug-name for this object.
    /// </summary>
    public string? DebugName
    {
        get
        {
            sbyte* pname = stackalloc sbyte[1024];
            uint size = 1024 - 1;
            if (GetPrivateData(D3DDebugObjectNameGuid, &size, pname).Failure)
            {
                return string.Empty;
            }

            pname[size] = 0;
            return GetString(pname);
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                SetPrivateData(D3DDebugObjectNameGuid, 0, null);
            }
            else
            {
                fixed (sbyte* valuePtr = value.GetUtf8Span())
                {
                    SetPrivateData(D3DDebugObjectNameGuid, (uint)value.Length, valuePtr);
                }
            }
        }
    }
}
