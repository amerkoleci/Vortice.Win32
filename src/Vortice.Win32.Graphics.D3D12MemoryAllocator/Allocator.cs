// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Vortice.Win32.Graphics.Direct3D12;
using Vortice.Win32.Graphics.Dxgi.Common;
using static Vortice.Win32.Apis;
using static Vortice.Win32.Graphics.D3D12MemoryAllocator.Apis;

namespace Vortice.Win32.Graphics.D3D12MemoryAllocator;

public readonly unsafe record struct D3D12MA_Allocator(nint Handle)
{
    public bool IsNull => Handle == 0;
    public static D3D12MA_Allocator Null => default;

    public uint AddRef() => D3D12MA_Allocator_AddRef(Handle);
    public uint Release() => D3D12MA_Allocator_Release(Handle);

    public bool IsUMA => D3D12MA_Allocator_IsUMA(Handle);
    public bool IsCacheCoherentUMA => D3D12MA_Allocator_IsCacheCoherentUMA(Handle);
    public bool IsGPUUploadHeapSupported => D3D12MA_Allocator_IsGPUUploadHeapSupported(Handle);

    public ulong GetMemoryCapacity(uint memorySegmentGroup) => D3D12MA_Allocator_GetMemoryCapacity(Handle, memorySegmentGroup);

    public HResult CreateResource(D3D12MA_ALLOCATION_DESC* pAllocDesc,
        in ResourceDescription resourceDesc,
        D3D12_RESOURCE_STATES initialResourceState,
        ClearValue* pOptimizedClearValue,
        D3D12MA_Allocation* allocation, Guid* riidResource, void** ppvResource)
    {
        fixed (ResourceDescription* pResourceDesc = &resourceDesc)
        {
            return D3D12MA_Allocator_CreateResource(Handle, pAllocDesc, pResourceDesc, initialResourceState, pOptimizedClearValue, allocation, riidResource, ppvResource);
        }
    }

    public HResult CreateResource<TResource>(D3D12MA_ALLOCATION_DESC* pAllocDesc,
        in ResourceDescription resourceDesc,
        D3D12_RESOURCE_STATES initialResourceState,
        ClearValue* pOptimizedClearValue,
        D3D12MA_Allocation* allocation, TResource** ppvResource)
        where TResource : unmanaged, ID3D12Resource.Interface
    {
        fixed (ResourceDescription* pResourceDesc = &resourceDesc)
        {
            return D3D12MA_Allocator_CreateResource(Handle,
                pAllocDesc,
                pResourceDesc,
                initialResourceState,
                pOptimizedClearValue,
                allocation,
                __uuidof<TResource>(), (void**)ppvResource);
        }
    }

    public HResult CreateResource2(D3D12MA_ALLOCATION_DESC* pAllocDesc,
        ResourceDescription1* pResourceDesc,
        D3D12_RESOURCE_STATES initialResourceState,
        ClearValue* pOptimizedClearValue,
        D3D12MA_Allocation* allocation, Guid* riidResource, void** ppvResource)
    {
        return D3D12MA_Allocator_CreateResource2(Handle, pAllocDesc, pResourceDesc, initialResourceState, pOptimizedClearValue, allocation, riidResource, ppvResource);
    }

    public HResult CreateResource3(D3D12MA_ALLOCATION_DESC* pAllocDesc,
        ResourceDescription1* pResourceDesc,
        D3D12_BARRIER_LAYOUT initialLayout,
        ClearValue* pOptimizedClearValue,
        uint numCastableFormats, Format* pCastableFormats,
        D3D12MA_Allocation* allocation, Guid* riidResource, void** ppvResource)
    {
        return D3D12MA_Allocator_CreateResource3(Handle, pAllocDesc, pResourceDesc, initialLayout,
            pOptimizedClearValue,
            numCastableFormats, pCastableFormats,
            allocation, riidResource, ppvResource);
    }
}
