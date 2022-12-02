// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Com;

namespace Win32.Graphics.Imaging;

public unsafe partial struct IWICPersistStream
{
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

