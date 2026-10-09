// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D3D12;

namespace Vortice.Win32.Graphics;

public unsafe partial struct D3D12_VIEW_INSTANCING_DESC
{
    public static ref readonly D3D12_VIEW_INSTANCING_DESC DEFAULT
    {
        get
        {
            ReadOnlySpan<byte> data;

            if (Environment.Is64BitProcess)
            {
                data = [
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00
                ];
            }
            else
            {
                data = [
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00
                ];
            }

            Debug.Assert(data.Length == Unsafe.SizeOf<D3D12_VIEW_INSTANCING_DESC>());
            return ref Unsafe.As<byte, D3D12_VIEW_INSTANCING_DESC>(ref MemoryMarshal.GetReference(data));
        }
    }
}
