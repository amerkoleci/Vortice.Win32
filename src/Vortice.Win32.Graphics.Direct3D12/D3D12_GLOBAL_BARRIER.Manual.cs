// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Graphics;

[NativeTypeName("struct CD3DX12_GLOBAL_BARRIER : D3D12_GLOBAL_BARRIER")]
[NativeInheritance("D3D12_GLOBAL_BARRIER")]
public partial struct D3D12_GLOBAL_BARRIER
{
    public D3D12_GLOBAL_BARRIER(D3D12_BARRIER_SYNC syncBefore, D3D12_BARRIER_SYNC syncAfter, D3D12_BARRIER_ACCESS accessBefore, D3D12_BARRIER_ACCESS accessAfter)
    {
        SyncBefore = syncBefore;
        SyncAfter = syncAfter;
        AccessBefore = accessBefore;
        AccessAfter = accessAfter;
    }
}

