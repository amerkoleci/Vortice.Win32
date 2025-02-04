// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Direct3D12;
using Win32.Graphics.Dxgi;

namespace Win32.Graphics.D3D12MemoryAllocator;

/// <unmanaged>D3D12MA_ALLOCATION_CALLBACKS</unmanaged>
public unsafe partial struct AllocationCallbacks
{
    /// <summary>Allocation function.</summary>
    /// <unmanaged>D3D12MA_AllocateFunctionType</unmanaged>
    public delegate* unmanaged<nuint, nuint, void*, void*> pAllocate;

    /// <summary>Dellocation function.</summary>
    /// <unmanaged>D3D12MA_FreeFunctionType</unmanaged>
    public delegate* unmanaged<void*, void*, void> pFree;

    /// <summary>Custom data that will be passed to allocation and deallocation functions as <c>pUserData</c> parameter.</summary>
    public void* pPrivateData;
}

/// <unmanaged>D3D12MA_ALLOCATOR_DESC</unmanaged>
public unsafe partial struct AllocatorDesc
{
    public AllocatorFlags Flags;
    public ID3D12Device* pDevice;
    public ulong PreferredBlockSize;
    public AllocationCallbacks* pAllocationCallbacks;
    public IDXGIAdapter* pAdapter;
}

/// <unmanaged>D3D12MA_POOL_DESC</unmanaged>
public unsafe partial struct PoolDesc
{
    public PoolFlags Flags;
    public HeapProperties HeapProperties;
    public HeapFlags HeapFlags;
    public ulong BlockSize;
    public uint MinBlockCount;
    public uint MaxBlockCount;
    public ulong MinAllocationAlignment;
    public ID3D12ProtectedResourceSession* pProtectedSession;
    public ResidencyPriority ResidencyPriority;
}

/// <unmanaged>D3D12MA_VIRTUAL_BLOCK_DESC</unmanaged>
public unsafe partial struct VirtualBlockDesc
{
    public VirtualBlockFlags Flags;
    public ulong Size;
    public AllocationCallbacks* pAllocationCallbacks;
}

/// <unmanaged>D3D12MA_ALLOCATION_DESC</unmanaged>
public unsafe partial struct AllocationDesc
{
    public AllocationFlags Flags;
    public HeapType HeapType;
    public HeapFlags ExtraHeapFlags;
    public Pool* CustomPool;
    public void* pPrivateData;
}

/// <unmanaged>D3D12MA_VIRTUAL_ALLOCATION_DESC</unmanaged>
public unsafe partial struct D3D12MA_VIRTUAL_ALLOCATION_DESC
{
    public VirtualAllocationFlags Flags;
    public ulong Size;
    public ulong Alignment;
    public void* pPrivateData;
}

public unsafe partial struct D3D12MA_VIRTUAL_ALLOCATION_INFO
{
    public ulong Offset;
    public ulong Size;
    public void* pPrivateData;
}
