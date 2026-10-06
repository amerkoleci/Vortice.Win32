// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Vortice.Win32.Graphics.Direct3D12;
using Vortice.Win32.Graphics.Dxgi;

namespace Vortice.Win32.Graphics.D3D12MemoryAllocator;

/// <unmanaged>D3D12MA_ALLOCATION_CALLBACKS</unmanaged>
public unsafe partial struct D3D12MA_ALLOCATION_CALLBACKS
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
public unsafe partial struct D3D12MA_ALLOCATOR_DESC
{
    public AllocatorFlags Flags;
    public ID3D12Device* pDevice;
    public ulong PreferredBlockSize;
    public D3D12MA_ALLOCATION_CALLBACKS* pAllocationCallbacks;
    public IDXGIAdapter* pAdapter;
}

public unsafe partial struct D3D12MA_POOL_DESC
{
    public PoolFlags Flags;
    public HeapProperties HeapProperties;
    public D3D12_HEAP_FLAGS HeapFlags;
    public ulong BlockSize;
    public uint MinBlockCount;
    public uint MaxBlockCount;
    public ulong MinAllocationAlignment;
    public ID3D12ProtectedResourceSession* pProtectedSession;
    public D3D12_RESIDENCY_PRIORITY ResidencyPriority;
}

/// <unmanaged>D3D12MA_VIRTUAL_BLOCK_DESC</unmanaged>
public unsafe partial struct D3D12MA_VIRTUAL_BLOCK_DESC
{
    public VirtualBlockFlags Flags;
    public ulong Size;
    public D3D12MA_ALLOCATION_CALLBACKS* pAllocationCallbacks;
}

/// <unmanaged>D3D12MA_ALLOCATION_DESC</unmanaged>
public unsafe partial struct D3D12MA_ALLOCATION_DESC
{
    public AllocationFlags Flags;
    public D3D12_HEAP_TYPE HeapType;
    public D3D12_HEAP_FLAGS ExtraHeapFlags;
    public D3D12MA_Pool CustomPool;
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
