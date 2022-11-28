// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D12;

/// <unmanaged>D3D12_BUFFER_BARRIER</unmanaged>
public unsafe partial struct BufferBarrier
{
    public BarrierSync SyncBefore;
    public BarrierSync SyncAfter;
    public BarrierAccess AccessBefore;
    public BarrierAccess AccessAfter;
    public ID3D12Resource* pResource;
    [NativeTypeName("UINT64")]
    public ulong Offset;
    [NativeTypeName("UINT64")]
    public ulong Size;
}
