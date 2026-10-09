// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Graphics;

[NativeTypeName("struct CD3DX12_BUFFER_BARRIER : D3D12_BUFFER_BARRIER")]
[NativeInheritance("D3D12_BUFFER_BARRIER")]
public unsafe partial struct D3D12_BUFFER_BARRIER
{
    public D3D12_BUFFER_BARRIER(D3D12_BARRIER_SYNC syncBefore, D3D12_BARRIER_SYNC syncAfter, D3D12_BARRIER_ACCESS accessBefore, D3D12_BARRIER_ACCESS accessAfter, ID3D12Resource* pResource)
    {
        SyncBefore = syncBefore;
        SyncAfter = syncAfter;
        AccessBefore = accessBefore;
        AccessAfter = accessAfter;
        this.pResource = pResource;
        Offset = 0;
        Size = 0xffffffffffffffffUL;
    }
}
