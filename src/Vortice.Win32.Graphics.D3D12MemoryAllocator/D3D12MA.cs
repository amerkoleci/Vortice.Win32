// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Graphics;

public static unsafe partial class D3D12MA
{
    private const string LibraryName = "D3D12MA";

    [LibraryImport(LibraryName, EntryPoint = "D3D12MA_CreateAllocator")]
    public static partial HResult D3D12MA_CreateAllocator(in D3D12MA_ALLOCATOR_DESC desc, out D3D12MA_Allocator allocator);

    [LibraryImport(LibraryName, EntryPoint = "D3D12MA_CreateAllocator")]
    public static partial HResult D3D12MA_CreateAllocator(D3D12MA_ALLOCATOR_DESC* pDesc, D3D12MA_Allocator* ppAllocator);

    [LibraryImport(LibraryName, EntryPoint = "D3D12MA_CreateVirtualBlock")]
    public static partial HResult CreateVirtualBlock(in D3D12MA_VIRTUAL_BLOCK_DESC desc, out VirtualBlock virtualBlock);

    [LibraryImport(LibraryName)]
    internal static partial uint D3D12MA_Allocator_AddRef(nint pSelf);
    [LibraryImport(LibraryName)]
    internal static partial uint D3D12MA_Allocator_Release(nint pSelf);

    [LibraryImport(LibraryName)]
    [return: MarshalAs(UnmanagedType.Bool)]
    internal static partial bool D3D12MA_Allocator_IsUMA(nint pSelf);

    [LibraryImport(LibraryName)]
    [return: MarshalAs(UnmanagedType.Bool)]
    internal static partial bool D3D12MA_Allocator_IsCacheCoherentUMA(nint pSelf);

    [LibraryImport(LibraryName)]
    [return: MarshalAs(UnmanagedType.Bool)]
    internal static partial bool D3D12MA_Allocator_IsGPUUploadHeapSupported(nint pSelf);

    [LibraryImport(LibraryName)]
    internal static partial ulong D3D12MA_Allocator_GetMemoryCapacity(nint pSelf, uint memorySegmentGroup);
    [LibraryImport(LibraryName)]
    internal static partial HResult D3D12MA_Allocator_CreateResource(nint pSelf, D3D12MA_ALLOCATION_DESC* allocationDesc, D3D12_RESOURCE_DESC* resourceDesc, D3D12_RESOURCE_STATES initialResourceState, D3D12_CLEAR_VALUE* pOptimizedClearValue, D3D12MA_Allocation* allocation, Guid* riidResource, void** ppvResource);
    [LibraryImport(LibraryName)]
    internal static partial HResult D3D12MA_Allocator_CreateResource2(nint pSelf, D3D12MA_ALLOCATION_DESC* allocationDesc, D3D12_RESOURCE_DESC1* pResourceDesc, D3D12_RESOURCE_STATES initialResourceState, D3D12_CLEAR_VALUE* pOptimizedClearValue, D3D12MA_Allocation* ppAllocation, Guid* riidResource, void** ppvResource);
    [LibraryImport(LibraryName)]
    internal static partial HResult D3D12MA_Allocator_CreateResource3(nint pSelf, D3D12MA_ALLOCATION_DESC* allocationDesc, D3D12_RESOURCE_DESC1* pResourceDesc, D3D12_BARRIER_LAYOUT InitialLayout, D3D12_CLEAR_VALUE* pOptimizedClearValue, uint NumCastableFormats, DXGI_FORMAT* pCastableFormats, D3D12MA_Allocation* ppAllocation, Guid* riidResource, void** ppvResource);
    [LibraryImport(LibraryName)]
    internal static partial HResult D3D12MA_Allocator_AllocateMemory(nint pSelf, D3D12MA_ALLOCATION_DESC* pAllocDesc, D3D12_RESOURCE_ALLOCATION_INFO* pAllocInfo, D3D12MA_Allocation* ppAllocation);
    [LibraryImport(LibraryName)]
    internal static partial HResult D3D12MA_Allocator_CreateAliasingResource(nint pSelf, D3D12MA_Allocation* pAllocation, ulong AllocationLocalOffset, D3D12_RESOURCE_DESC* pResourceDesc, D3D12_RESOURCE_STATES InitialResourceState, D3D12_CLEAR_VALUE* pOptimizedClearValue, Guid* riidResource, void** ppvResource);
    [LibraryImport(LibraryName)]
    internal static partial HResult D3D12MA_Allocator_CreateAliasingResource1(nint pSelf, D3D12MA_Allocation* pAllocation, ulong AllocationLocalOffset, D3D12_RESOURCE_DESC* pResourceDesc, D3D12_RESOURCE_STATES InitialResourceState, D3D12_CLEAR_VALUE* pOptimizedClearValue, Guid* riidResource, void** ppvResource);
    [LibraryImport(LibraryName)]
    internal static partial HResult D3D12MA_Allocator_CreateAliasingResource2(nint pSelf, D3D12MA_Allocation* pAllocation, ulong AllocationLocalOffset, D3D12_RESOURCE_DESC* pResourceDesc, D3D12_BARRIER_LAYOUT InitialLayout, D3D12_CLEAR_VALUE* pOptimizedClearValue, uint NumCastableFormats, DXGI_FORMAT* pCastableFormats, Guid* riidResource, void** ppvResource);

    [LibraryImport(LibraryName)]
    internal static partial HResult D3D12MA_Allocator_CreatePool(nint pSelf, D3D12MA_POOL_DESC* pPoolDesc, out D3D12MA_Pool pool);
    [LibraryImport(LibraryName)]
    internal static partial void D3D12MA_Allocator_SetCurrentFrameIndex(nint pSelf, uint frameIndex);
    //[LibraryImport(LibraryName)]
    //internal static partial void D3D12MA_Allocator_GetBudget(nint pSelf, D3D12MABudget* pLocalBudget, D3D12MABudget* pNonLocalBudget);
    //[LibraryImport(LibraryName)]
    //internal static partial void D3D12MA_Allocator_CalculateStatistics(nint pSelf, D3D12MATotalStatistics* pStats);
    [LibraryImport(LibraryName)]
    internal static partial void D3D12MA_Allocator_BuildStatsString(nint pSelf, char** ppStatsString, Bool32 DetailedMap);
    [LibraryImport(LibraryName)]
    internal static partial void D3D12MA_Allocator_FreeStatsString(nint pSelf, char* pStatsString);
    //[LibraryImport(LibraryName)]
    //internal static partial void D3D12MA_Allocator_BeginDefragmentation(void* pSelf, const D3D12MA_DEFRAGMENTATION_DESC* pDesc, D3D12MA_DefragmentationContext** ppContext);

    #region Allocation
    [LibraryImport(LibraryName)]
    internal static partial uint D3D12MA_Allocation_AddRef(D3D12MA_Allocation pSelf);
    [LibraryImport(LibraryName)]
    internal static partial uint D3D12MA_Allocation_Release(D3D12MA_Allocation pSelf);

    [LibraryImport(LibraryName)]
    internal static partial ulong D3D12MA_Allocation_GetOffset(D3D12MA_Allocation pSelf);
    [LibraryImport(LibraryName)]
    internal static partial ulong D3D12MA_Allocation_GetAlignment(D3D12MA_Allocation pSelf);
    [LibraryImport(LibraryName)]
    internal static partial ulong D3D12MA_Allocation_GetSize(D3D12MA_Allocation pSelf);
    [LibraryImport(LibraryName)]
    internal static partial ID3D12Resource* D3D12MA_Allocation_GetResource(D3D12MA_Allocation pSelf);

    [LibraryImport(LibraryName)]
    internal static partial void D3D12MA_Allocation_SetResource(D3D12MA_Allocation pSelf, ID3D12Resource* pResource);
    [LibraryImport(LibraryName)]
    internal static partial ID3D12Heap* D3D12MA_Allocation_GetHeap(D3D12MA_Allocation pSelf);
    [LibraryImport(LibraryName)]
    internal static partial void D3D12MA_Allocation_SetPrivateData(D3D12MA_Allocation pSelf, void* pPrivateData);
    [LibraryImport(LibraryName)]
    internal static partial void* D3D12MA_Allocation_GetPrivateData(D3D12MA_Allocation pSelf);
    [LibraryImport(LibraryName)]
    internal static partial void D3D12MA_Allocation_SetName(D3D12MA_Allocation pSelf, char* Name);
    [LibraryImport(LibraryName)]
    internal static partial char* D3D12MA_Allocation_GetName(D3D12MA_Allocation pSelf);
    #endregion
}
