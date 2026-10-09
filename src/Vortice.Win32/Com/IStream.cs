// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Com;

[Guid("0000000C-0000-0000-C000-000000000046")]
[NativeTypeName("struct IStream : ISequentialStream")]
[NativeInheritance("ISequentialStream")]
public unsafe partial struct IStream : IStream.Interface, INativeGuid
{
    public static ref readonly Guid IID_IStream
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x0C, 0x00, 0x00, 0x00,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IStream);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStream*, Guid*, void**, int>)(lpVtbl[0]))((IStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStream*, uint>)(lpVtbl[1]))((IStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStream*, uint>)(lpVtbl[2]))((IStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISequentialStream.Read" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Read(void* pv, uint cb, uint* pcbRead)
    {
        return ((delegate* unmanaged[MemberFunction]<IStream*, void*, uint, uint*, int>)(lpVtbl[3]))((IStream*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
    }

    /// <inheritdoc cref="ISequentialStream.Write" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Write(void* pv, uint cb, uint* pcbWritten)
    {
        return ((delegate* unmanaged[MemberFunction]<IStream*, void*, uint, uint*, int>)(lpVtbl[4]))((IStream*)Unsafe.AsPointer(ref this), pv, cb, pcbWritten);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Seek(LARGE_INTEGER dlibMove, uint dwOrigin, ULARGE_INTEGER* plibNewPosition)
    {
        return ((delegate* unmanaged[MemberFunction]<IStream*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int>)(lpVtbl[5]))((IStream*)Unsafe.AsPointer(ref this), dlibMove, dwOrigin, plibNewPosition);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetSize(ULARGE_INTEGER libNewSize)
    {
        return ((delegate* unmanaged[MemberFunction]<IStream*, ULARGE_INTEGER, int>)(lpVtbl[6]))((IStream*)Unsafe.AsPointer(ref this), libNewSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CopyTo(IStream* pstm, ULARGE_INTEGER cb, ULARGE_INTEGER* pcbRead, ULARGE_INTEGER* pcbWritten)
    {
        return ((delegate* unmanaged[MemberFunction]<IStream*, IStream*, ULARGE_INTEGER, ULARGE_INTEGER*, ULARGE_INTEGER*, int>)(lpVtbl[7]))((IStream*)Unsafe.AsPointer(ref this), pstm, cb, pcbRead, pcbWritten);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Commit(uint grfCommitFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IStream*, uint, int>)(lpVtbl[8]))((IStream*)Unsafe.AsPointer(ref this), grfCommitFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Revert()
    {
        return ((delegate* unmanaged[MemberFunction]<IStream*, int>)(lpVtbl[9]))((IStream*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT LockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, uint dwLockType)
    {
        return ((delegate* unmanaged[MemberFunction]<IStream*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[10]))((IStream*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT UnlockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, uint dwLockType)
    {
        return ((delegate* unmanaged[MemberFunction]<IStream*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[11]))((IStream*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
    }

    ///// <include file='IStream.xml' path='doc/member[@name="IStream.Stat"]/*' />
    //[MethodImpl(MethodImplOptions.AggressiveInlining)]
    //[VtblIndex(12)]
    //public HRESULT Stat(STATSTG* pstatstg, uint grfStatFlag)
    //{
    //    return ((delegate* unmanaged[MemberFunction]<IStream*, STATSTG*, uint, int>)(lpVtbl[12]))((IStream*)Unsafe.AsPointer(ref this), pstatstg, grfStatFlag);
    //}

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Clone(IStream** ppstm)
    {
        return ((delegate* unmanaged[MemberFunction]<IStream*, IStream**, int>)(lpVtbl[13]))((IStream*)Unsafe.AsPointer(ref this), ppstm);
    }

    public interface Interface : ISequentialStream.Interface
    {
        [VtblIndex(5)]
        HRESULT Seek(LARGE_INTEGER dlibMove, uint dwOrigin, ULARGE_INTEGER* plibNewPosition);

        [VtblIndex(6)]
        HRESULT SetSize(ULARGE_INTEGER libNewSize);

        [VtblIndex(7)]
        HRESULT CopyTo(IStream* pstm, ULARGE_INTEGER cb, ULARGE_INTEGER* pcbRead, ULARGE_INTEGER* pcbWritten);

        [VtblIndex(8)]
        HRESULT Commit( uint grfCommitFlags);

        [VtblIndex(9)]
        HRESULT Revert();

        [VtblIndex(10)]
        HRESULT LockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, uint dwLockType);

        [VtblIndex(11)]
        HRESULT UnlockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, uint dwLockType);

        //[VtblIndex(12)]
        //HResult Stat(STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag);

        [VtblIndex(13)]
        HRESULT Clone(IStream** ppstm);
    }
}
