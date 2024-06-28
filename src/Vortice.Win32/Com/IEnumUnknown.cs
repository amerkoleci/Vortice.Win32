// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Win32.Com;

[Guid("00000100-0000-0000-C000-000000000046")]
[NativeTypeName("struct IEnumUnknown : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumUnknown
{
    public static ref readonly Guid IID_IEnumUnknown
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x00, 0x01, 0x00, 0x00,
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


    public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumUnknown));

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
    public HResult Next([NativeTypeName("ULONG")] uint celt, IUnknown** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
    {
        return ((delegate* unmanaged[Stdcall]<IEnumUnknown*, uint, IUnknown**, uint*, int>)(lpVtbl[3]))((IEnumUnknown*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult Skip([NativeTypeName("ULONG")] uint celt)
    {
        return ((delegate* unmanaged[Stdcall]<IEnumUnknown*, uint, int>)(lpVtbl[4]))((IEnumUnknown*)Unsafe.AsPointer(ref this), celt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult Reset()
    {
        return ((delegate* unmanaged[Stdcall]<IEnumUnknown*, int>)(lpVtbl[5]))((IEnumUnknown*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HResult Clone(IEnumUnknown** ppenum)
    {
        return ((delegate* unmanaged[Stdcall]<IEnumUnknown*, IEnumUnknown**, int>)(lpVtbl[6]))((IEnumUnknown*)Unsafe.AsPointer(ref this), ppenum);
    }
}
