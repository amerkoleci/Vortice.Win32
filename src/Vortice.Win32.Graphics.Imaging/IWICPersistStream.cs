// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Win32.Com;

namespace Win32.Graphics.Imaging;

public unsafe partial struct IWICPersistStream
{
    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[Stdcall]<IWICPersistStream*, Guid*, void**, int>)(lpVtbl[0]))((IWICPersistStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[Stdcall]<IWICPersistStream*, uint>)(lpVtbl[1]))((IWICPersistStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[Stdcall]<IWICPersistStream*, uint>)(lpVtbl[2]))((IWICPersistStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IPersist.GetClassID" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult GetClassID(Guid* pClassID)
    {
        return ((delegate* unmanaged[Stdcall]<IWICPersistStream*, Guid*, int>)(lpVtbl[3]))((IWICPersistStream*)Unsafe.AsPointer(ref this), pClassID);
    }

    /// <inheritdoc cref="IPersistStream.IsDirty" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult IsDirty()
    {
        return ((delegate* unmanaged[Stdcall]<IWICPersistStream*, int>)(lpVtbl[4]))((IWICPersistStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IPersistStream.Load" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult Load(IStream* pStm)
    {
        return ((delegate* unmanaged[Stdcall]<IWICPersistStream*, IStream*, int>)(lpVtbl[5]))((IWICPersistStream*)Unsafe.AsPointer(ref this), pStm);
    }

    /// <inheritdoc cref="IPersistStream.Save" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HResult Save(IStream* pStm, Bool32 fClearDirty)
    {
        return ((delegate* unmanaged[Stdcall]<IWICPersistStream*, IStream*, Bool32, int>)(lpVtbl[6]))((IWICPersistStream*)Unsafe.AsPointer(ref this), pStm, fClearDirty);
    }

    /// <inheritdoc cref="IPersistStream.GetSizeMax" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult GetSizeMax(ULargeInteger* pcbSize)
    {
        return ((delegate* unmanaged[Stdcall]<IWICPersistStream*, ULargeInteger*, int>)(lpVtbl[7]))((IWICPersistStream*)Unsafe.AsPointer(ref this), pcbSize);
    }
}

