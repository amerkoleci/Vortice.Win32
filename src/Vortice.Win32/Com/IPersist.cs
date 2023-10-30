// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Com;

[Guid("0000010C-0000-0000-C000-000000000046")]
[NativeTypeName("struct IPersist : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPersist : IPersist.Interface, INativeGuid
{
    public static ref readonly Guid IID_IPersist
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x0C, 0x01, 0x00, 0x00,
                0x00, 0x00,
                0x00, 0x00,
                0xC0,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x46
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPersist));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPersist*, Guid*, void**, int>)(lpVtbl[0]))((IPersist*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPersist*, uint>)(lpVtbl[1]))((IPersist*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPersist*, uint>)(lpVtbl[2]))((IPersist*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
    {
        return ((delegate* unmanaged[MemberFunction]<IPersist*, Guid*, int>)(lpVtbl[3]))((IPersist*)Unsafe.AsPointer(ref this), pClassID);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HResult GetClassID([NativeTypeName("CLSID *")] Guid* pClassID);
    }
}
