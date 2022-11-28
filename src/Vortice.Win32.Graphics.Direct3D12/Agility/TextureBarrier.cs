// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D12;

/// <unmanaged>D3D12_TEXTURE_BARRIER</unmanaged>
public unsafe partial struct TextureBarrier
{
    public BarrierSync SyncBefore;
    public BarrierSync SyncAfter;
    public BarrierAccess AccessBefore;
    public BarrierAccess AccessAfter;
    public BarrierLayout LayoutBefore;
    public BarrierLayout LayoutAfter;
    public ID3D12Resource* pResource;
    public BarrierSubResourceRange Subresources;
    public TextureBarrierFlags Flags;
}
