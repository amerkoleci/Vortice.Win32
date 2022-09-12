// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Win32.Com;

[Guid("00000002-0000-0000-C000-000000000046")]
[NativeTypeName("struct IMalloc : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMalloc
{
    public static ref readonly Guid IID_IMalloc
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x02, 0x00, 0x00, 0x00,
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

    public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMalloc));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
    public void* Alloc([NativeTypeName("SIZE_T")] nuint cb)
    {
        return ((delegate* unmanaged[Stdcall]<IMalloc*, nuint, void*>)(lpVtbl[3]))((IMalloc*)Unsafe.AsPointer(ref this), cb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void* Realloc(void* pv, [NativeTypeName("SIZE_T")] nuint cb)
    {
        return ((delegate* unmanaged[Stdcall]<IMalloc*, void*, nuint, void*>)(lpVtbl[4]))((IMalloc*)Unsafe.AsPointer(ref this), pv, cb);
    }

    /// <include file='IMalloc.xml' path='doc/member[@name="IMalloc.Free"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void Free(void* pv)
    {
        ((delegate* unmanaged[Stdcall]<IMalloc*, void*, void>)(lpVtbl[5]))((IMalloc*)Unsafe.AsPointer(ref this), pv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("SIZE_T")]
    public nuint GetSize(void* pv)
    {
        return ((delegate* unmanaged[Stdcall]<IMalloc*, void*, nuint>)(lpVtbl[6]))((IMalloc*)Unsafe.AsPointer(ref this), pv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public int DidAlloc(void* pv)
    {
        return ((delegate* unmanaged[Stdcall]<IMalloc*, void*, int>)(lpVtbl[7]))((IMalloc*)Unsafe.AsPointer(ref this), pv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void HeapMinimize()
    {
        ((delegate* unmanaged[Stdcall]<IMalloc*, void>)(lpVtbl[8]))((IMalloc*)Unsafe.AsPointer(ref this));
    }
}
