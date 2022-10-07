// Copyright � Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Win32.StringUtilities;

namespace Win32.Graphics.Direct3D11;

public unsafe partial struct ID3D11DeviceChild
{
    public static ref readonly Guid WKPDID_D3DDebugObjectName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x22, 0x8C, 0x9B, 0x42,
                0x88, 0x91,
                0x0C, 0x4B,
                0x87,
                0x42,
                0xAC,
                0xB0,
                0xBF,
                0x85,
                0xC2,
                0x00
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

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