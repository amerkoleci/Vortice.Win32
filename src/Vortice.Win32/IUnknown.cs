// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32;

[Guid("00000000-0000-0000-C000-000000000046")]
public unsafe partial struct IUnknown : IUnknown.Interface, INativeGuid
{
    public static ref readonly Guid IID_IUnknown
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x00, 0x00, 0x00, 0x00,
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

    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUnknown));

    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HResult QueryInterface(Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUnknown*, Guid*, void**, int>)(lpVtbl[0]))((IUnknown*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUnknown*, uint>)(lpVtbl[1]))((IUnknown*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUnknown*, uint>)(lpVtbl[2]))((IUnknown*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : INativeGuid
    {
        [VtblIndex(0)]
        HResult QueryInterface(Guid* riid, void** ppvObject);

        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        uint AddRef();

        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        uint Release();
    }
}
