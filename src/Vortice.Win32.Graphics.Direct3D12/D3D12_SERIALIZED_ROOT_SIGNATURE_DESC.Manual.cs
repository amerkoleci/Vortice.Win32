// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Graphics;

public unsafe partial struct D3D12_SERIALIZED_ROOT_SIGNATURE_DESC
{
    public static ref readonly D3D12_SERIALIZED_ROOT_SIGNATURE_DESC DEFAULT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00,
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<D3D12_SERIALIZED_ROOT_SIGNATURE_DESC>());
            return ref Unsafe.As<byte, D3D12_SERIALIZED_ROOT_SIGNATURE_DESC>(ref MemoryMarshal.GetReference(data));
        }
    }

    public D3D12_SERIALIZED_ROOT_SIGNATURE_DESC([NativeTypeName("const void *")] void* pData, [NativeTypeName("SIZE_T")] nuint size)
    {
        pSerializedBlob = pData;
        SerializedBlobSizeInBytes = size;
    }
}
