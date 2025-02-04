// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Direct3D12;
using Win32.Graphics.Dxgi.Common;

namespace Win32.Graphics.D3D12MemoryAllocator;

public static unsafe partial class Apis
{
    private const string LibraryName = "D3D12MA";

    [LibraryImport(LibraryName, EntryPoint = "D3D12MA_CreateAllocator")]
    public static partial HResult CreateAllocator(in AllocatorDesc desc, out Allocator allocator);

    [LibraryImport(LibraryName, EntryPoint = "D3D12MA_CreateVirtualBlock")]
    public static partial HResult CreateVirtualBlock(in VirtualBlockDesc desc, out VirtualBlock virtualBlock);

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
    internal static partial HResult D3D12MA_Allocator_CreateResource(nint pSelf, AllocationDesc* allocationDesc, ResourceDescription* resourceDesc, ResourceStates initialResourceState, ClearValue* pOptimizedClearValue, Allocation* allocation, Guid* riidResource, void** ppvResource);
    [LibraryImport(LibraryName)]
    internal static partial HResult D3D12MA_Allocator_CreateResource2(nint pSelf, AllocationDesc* allocationDesc, ResourceDescription1* pResourceDesc, ResourceStates initialResourceState, ClearValue* pOptimizedClearValue, Allocation* ppAllocation, Guid* riidResource, void** ppvResource);
    [LibraryImport(LibraryName)]
    internal static partial HResult D3D12MA_Allocator_CreateResource3(nint pSelf, AllocationDesc* allocationDesc, ResourceDescription1* pResourceDesc, BarrierLayout InitialLayout, ClearValue* pOptimizedClearValue, uint NumCastableFormats, Format* pCastableFormats, Allocation* ppAllocation, Guid* riidResource, void** ppvResource);
    [LibraryImport(LibraryName)]
    internal static partial HResult D3D12MA_Allocator_AllocateMemory(nint pSelf, AllocationDesc* pAllocDesc, ResourceAllocationInfo* pAllocInfo, Allocation* ppAllocation);
    [LibraryImport(LibraryName)]
    internal static partial HResult D3D12MA_Allocator_CreateAliasingResource(nint pSelf, Allocation* pAllocation, ulong AllocationLocalOffset, ResourceDescription* pResourceDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource);
    [LibraryImport(LibraryName)]
    internal static partial HResult D3D12MA_Allocator_CreateAliasingResource1(nint pSelf, Allocation* pAllocation, ulong AllocationLocalOffset, ResourceDescription* pResourceDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource);
    [LibraryImport(LibraryName)]
    internal static partial HResult D3D12MA_Allocator_CreateAliasingResource2(nint pSelf, Allocation* pAllocation, ulong AllocationLocalOffset, ResourceDescription* pResourceDesc, BarrierLayout InitialLayout, ClearValue* pOptimizedClearValue, uint NumCastableFormats, Format* pCastableFormats, Guid* riidResource, void** ppvResource);

    [LibraryImport(LibraryName)]
    internal static partial HResult D3D12MA_Allocator_CreatePool(nint pSelf, PoolDesc* pPoolDesc, Pool* ppPool);
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
    internal static partial uint D3D12MA_Allocation_AddRef(nint pSelf);
    [LibraryImport(LibraryName)]
    internal static partial uint D3D12MA_Allocation_Release(nint pSelf);

    [LibraryImport(LibraryName)]
    internal static partial ulong D3D12MA_Allocation_GetOffset(nint pSelf);
    [LibraryImport(LibraryName)]
    internal static partial ulong D3D12MA_Allocation_GetAlignment(nint pSelf);
    [LibraryImport(LibraryName)]
    internal static partial ulong D3D12MA_Allocation_GetSize(nint pSelf);
    [LibraryImport(LibraryName)]
    internal static partial ID3D12Resource* D3D12MA_Allocation_GetResource(nint pSelf);

    [LibraryImport(LibraryName)]
    internal static partial void D3D12MA_Allocation_SetResource(nint pSelf, ID3D12Resource* pResource);
    [LibraryImport(LibraryName)]
    internal static partial ID3D12Heap* D3D12MA_Allocation_GetHeap(nint pSelf);
    [LibraryImport(LibraryName)]
    internal static partial void D3D12MA_Allocation_SetPrivateData(nint pSelf, void* pPrivateData);
    [LibraryImport(LibraryName)]
    internal static partial void* D3D12MA_Allocation_GetPrivateData(nint pSelf);
    [LibraryImport(LibraryName)]
    internal static partial void D3D12MA_Allocation_SetName(nint pSelf, char* Name);
    [LibraryImport(LibraryName)]
    internal static partial char* D3D12MA_Allocation_GetName(nint pSelf);
    #endregion
}
