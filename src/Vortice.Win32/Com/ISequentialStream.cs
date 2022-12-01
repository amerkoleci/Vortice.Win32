// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Com;

[Guid("0C733A30-2A1C-11CE-ADE5-00AA0044773D")]
[NativeTypeName("struct ISequentialStream : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISequentialStream : ISequentialStream.Interface, INativeGuid
{
    public static ref readonly Guid IID_ISequentialStream
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x30, 0x3A, 0x73, 0x0C,
                0x1C, 0x2A,
                0xCE, 0x11,
                0xAD,
                0xE5,
                0x00,
                0xAA,
                0x00,
                0x44,
                0x77,
                0x3D
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

#if NET6_0_OR_GREATER
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISequentialStream));
#else
    public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISequentialStream));
#endif

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HResult QueryInterface(Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Stdcall]<ISequentialStream*, Guid*, void**, int>)(lpVtbl[0]))((ISequentialStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[Stdcall]<ISequentialStream*, uint>)(lpVtbl[1]))((ISequentialStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[Stdcall]<ISequentialStream*, uint>)(lpVtbl[2]))((ISequentialStream*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult Read(void* pv, uint cb, uint* pcbRead)
    {
        return ((delegate* unmanaged[Stdcall]<ISequentialStream*, void*, uint, uint*, int>)(lpVtbl[3]))((ISequentialStream*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult Write(void* pv, uint cb, uint* pcbWritten)
    {
        return ((delegate* unmanaged[Stdcall]<ISequentialStream*, void*, uint, uint*, int>)(lpVtbl[4]))((ISequentialStream*)Unsafe.AsPointer(ref this), pv, cb, pcbWritten);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HResult Read(void* pv, uint cb, uint* pcbRead);

        [VtblIndex(4)]
        HResult Write(void* pv, uint cb, uint* pcbWritten);
    }
}
