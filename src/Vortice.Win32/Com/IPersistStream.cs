// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Com;

[Guid("00000109-0000-0000-C000-000000000046")]
[NativeTypeName("struct IPersistStream : IPersist")]
[NativeInheritance("IPersist")]
public unsafe partial struct IPersistStream : IPersistStream.Interface, INativeGuid
{
    public static ref readonly Guid IID_IPersistStream
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x09, 0x01, 0x00, 0x00,
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

#if NET6_0_OR_GREATER
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPersistStream));
#else
    public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPersistStream));
#endif

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Stdcall]<IPersistStream*, Guid*, void**, int>)(lpVtbl[0]))((IPersistStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[Stdcall]<IPersistStream*, uint>)(lpVtbl[1]))((IPersistStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[Stdcall]<IPersistStream*, uint>)(lpVtbl[2]))((IPersistStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IPersist.GetClassID" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
    {
        return ((delegate* unmanaged[Stdcall]<IPersistStream*, Guid*, int>)(lpVtbl[3]))((IPersistStream*)Unsafe.AsPointer(ref this), pClassID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult IsDirty()
    {
        return ((delegate* unmanaged[Stdcall]<IPersistStream*, int>)(lpVtbl[4]))((IPersistStream*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult Load(IStream* pStm)
    {
        return ((delegate* unmanaged[Stdcall]<IPersistStream*, IStream*, int>)(lpVtbl[5]))((IPersistStream*)Unsafe.AsPointer(ref this), pStm);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HResult Save(IStream* pStm, Bool32 fClearDirty)
    {
        return ((delegate* unmanaged[Stdcall]<IPersistStream*, IStream*, Bool32, int>)(lpVtbl[6]))((IPersistStream*)Unsafe.AsPointer(ref this), pStm, fClearDirty);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult GetSizeMax(ULargeInteger* pcbSize)
    {
        return ((delegate* unmanaged[Stdcall]<IPersistStream*, ULargeInteger*, int>)(lpVtbl[7]))((IPersistStream*)Unsafe.AsPointer(ref this), pcbSize);
    }

    public interface Interface : IPersist.Interface
    {
        [VtblIndex(4)]
        HResult IsDirty();

        [VtblIndex(5)]
        HResult Load(IStream* pStm);

        [VtblIndex(6)]
        HResult Save(IStream* pStm, Bool32 fClearDirty);

        [VtblIndex(7)]
        HResult GetSizeMax(ULargeInteger* pcbSize);
    }
}
