// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Win32.Com;

[Guid("22F55882-280B-11D0-A8A9-00A0C90C2004")]
[NativeTypeName("struct IPropertyBag2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPropertyBag2
{
    public static ref readonly Guid IID_IPropertyBag2
    {
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x82, 0x58, 0xF5, 0x22,
                0x0B, 0x28,
                0xD0, 0x11,
                0xA8,
                0xA9,
                0x00,
                0xA0,
                0xC9,
                0x0C,
                0x20,
                0x04
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPropertyBag2));

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
    public HResult Read(uint cProperties, PropertyBagMetadata* pPropBag, IErrorLog* pErrLog, Variant* pvarValue, HResult* phrError)
    {
        return ((delegate* unmanaged[Stdcall]<IPropertyBag2*, uint, PropertyBagMetadata*, IErrorLog*, Variant*, HResult*, int>)(lpVtbl[3]))((IPropertyBag2*)Unsafe.AsPointer(ref this), cProperties, pPropBag, pErrLog, pvarValue, phrError);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult Write([NativeTypeName("ULONG")] uint cProperties, PropertyBagMetadata* pPropBag, Variant* pvarValue)
    {
        return ((delegate* unmanaged[Stdcall]<IPropertyBag2*, uint, PropertyBagMetadata*, Variant*, int>)(lpVtbl[4]))((IPropertyBag2*)Unsafe.AsPointer(ref this), cProperties, pPropBag, pvarValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult CountProperties(uint* pcProperties)
    {
        return ((delegate* unmanaged[Stdcall]<IPropertyBag2*, uint*, int>)(lpVtbl[5]))((IPropertyBag2*)Unsafe.AsPointer(ref this), pcProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HResult GetPropertyInfo(uint iProperty, uint cProperties, PropertyBagMetadata* pPropBag, uint* pcProperties)
    {
        return ((delegate* unmanaged[Stdcall]<IPropertyBag2*, uint, uint, PropertyBagMetadata*, uint*, int>)(lpVtbl[6]))((IPropertyBag2*)Unsafe.AsPointer(ref this), iProperty, cProperties, pPropBag, pcProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult LoadObject(ushort* pstrName, uint dwHint, IUnknown* pUnkObject, IErrorLog* pErrLog)
    {
        return ((delegate* unmanaged[Stdcall]<IPropertyBag2*, ushort*, uint, IUnknown*, IErrorLog*, int>)(lpVtbl[7]))((IPropertyBag2*)Unsafe.AsPointer(ref this), pstrName, dwHint, pUnkObject, pErrLog);
    }
}
