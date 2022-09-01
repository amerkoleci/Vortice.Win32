// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Runtime.CompilerServices;
using static Win32.Apis;

namespace Win32;

[Guid("00000000-0000-0000-C000-000000000046")]
public unsafe partial struct IUnknown : IUnknown.Interface
{
    public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUnknown));

    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Stdcall]<IUnknown*, Guid*, void**, int>)(lpVtbl[0]))((IUnknown*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[Stdcall]<IUnknown*, uint>)(lpVtbl[1]))((IUnknown*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[Stdcall]<IUnknown*, uint>)(lpVtbl[2]))((IUnknown*)Unsafe.AsPointer(ref this));
    }

    public interface Interface
    {
        [VtblIndex(0)]
        HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject);

        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        uint AddRef();

        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        uint Release();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<TSelf*, uint> Release;
    }
}
