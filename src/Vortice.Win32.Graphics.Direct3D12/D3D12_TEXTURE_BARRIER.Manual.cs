// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D3D12;

namespace Vortice.Win32.Graphics;

[NativeTypeName("struct CD3DX12_TEXTURE_BARRIER : D3D12_TEXTURE_BARRIER")]
[NativeInheritance("D3D12_TEXTURE_BARRIER")]
public unsafe partial struct D3D12_TEXTURE_BARRIER
{
    public D3D12_TEXTURE_BARRIER(D3D12_BARRIER_SYNC syncBefore, D3D12_BARRIER_SYNC syncAfter, D3D12_BARRIER_ACCESS accessBefore, D3D12_BARRIER_ACCESS accessAfter, D3D12_BARRIER_LAYOUT layoutBefore, D3D12_BARRIER_LAYOUT layoutAfter, ID3D12Resource* pRes, [NativeTypeName("const D3D12_BARRIER_SUBRESOURCE_RANGE &")] D3D12_BARRIER_SUBRESOURCE_RANGE* subresources, D3D12_TEXTURE_BARRIER_FLAGS flag = D3D12_TEXTURE_BARRIER_FLAG_NONE)
    {
        SyncBefore = syncBefore;
        SyncAfter = syncAfter;
        AccessBefore = accessBefore;
        AccessAfter = accessAfter;
        LayoutBefore = layoutBefore;
        LayoutAfter = layoutAfter;
        pResource = pRes;
        Subresources = *subresources;
        Flags = flag;
    }
}
