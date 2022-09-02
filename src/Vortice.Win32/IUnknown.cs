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
    public HResult QueryInterface(Guid* riid, void** ppvObject)
    {
#if NET6_0_OR_GREATER
        return ((delegate* unmanaged<IUnknown*, Guid*, void**, int>)(lpVtbl[0]))((IUnknown*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
        return ((delegate* unmanaged[Stdcall]<IUnknown*, Guid*, void**, int>)(lpVtbl[0]))((IUnknown*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public uint AddRef()
    {
#if NET6_0_OR_GREATER
        return ((delegate* unmanaged<IUnknown*, uint>)(lpVtbl[1]))((IUnknown*)Unsafe.AsPointer(ref this));
#else
        return ((delegate* unmanaged[Stdcall]<IUnknown*, uint>)(lpVtbl[1]))((IUnknown*)Unsafe.AsPointer(ref this));
#endif
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public uint Release()
    {
#if NET6_0_OR_GREATER
        return ((delegate* unmanaged<IUnknown*, uint>)(lpVtbl[2]))((IUnknown*)Unsafe.AsPointer(ref this));
#else
        return ((delegate* unmanaged[Stdcall]<IUnknown*, uint>)(lpVtbl[2]))((IUnknown*)Unsafe.AsPointer(ref this));
#endif
    }

    public interface Interface
    {
        [VtblIndex(0)]
        HResult QueryInterface(Guid* riid, void** ppvObject);

        [VtblIndex(1)]
        uint AddRef();

        [VtblIndex(2)]
        uint Release();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
#if NET6_0_OR_GREATER
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        public delegate* unmanaged<TSelf*, uint> AddRef;

        public delegate* unmanaged<TSelf*, uint> Release;
#else
        public delegate* unmanaged[Stdcall]<TSelf*, Guid*, void**, int> QueryInterface;

        public delegate* unmanaged[Stdcall]<TSelf*, uint> AddRef;

        public delegate* unmanaged[Stdcall]<TSelf*, uint> Release;
#endif
    }
}
