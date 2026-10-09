// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Vortice.Win32.Com;

namespace Vortice.Win32.Graphics;

public unsafe partial struct IWICPersistStream
{
    /// <inheritdoc cref="IPersist.GetClassID" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassID(Guid* pClassID)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICPersistStream*, Guid*, int>)(lpVtbl[3]))((IWICPersistStream*)Unsafe.AsPointer(ref this), pClassID);
    }

    /// <inheritdoc cref="IPersistStream.IsDirty" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT IsDirty()
    {
        return ((delegate* unmanaged[MemberFunction]<IWICPersistStream*, int>)(lpVtbl[4]))((IWICPersistStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IPersistStream.Load" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Load(IStream* pStm)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICPersistStream*, IStream*, int>)(lpVtbl[5]))((IWICPersistStream*)Unsafe.AsPointer(ref this), pStm);
    }

    /// <inheritdoc cref="IPersistStream.Save" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Save(IStream* pStm, Bool32 fClearDirty)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICPersistStream*, IStream*, Bool32, int>)(lpVtbl[6]))((IWICPersistStream*)Unsafe.AsPointer(ref this), pStm, fClearDirty);
    }

    /// <inheritdoc cref="IPersistStream.GetSizeMax" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSizeMax(ULARGE_INTEGER* pcbSize)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICPersistStream*, ULARGE_INTEGER*, int>)(lpVtbl[7]))((IWICPersistStream*)Unsafe.AsPointer(ref this), pcbSize);
    }
}

