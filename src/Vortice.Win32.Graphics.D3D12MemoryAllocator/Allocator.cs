// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Direct3D12;
using Win32.Graphics.Dxgi.Common;
using static Win32.Apis;
using static Win32.Graphics.D3D12MemoryAllocator.Apis;

namespace Win32.Graphics.D3D12MemoryAllocator;

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly unsafe partial struct Allocator : IEquatable<Allocator>
{
    public Allocator(nint handle) { Handle = handle; }
    public nint Handle { get; }
    public bool IsNull => Handle == 0;
    public bool IsNotNull => Handle != 0;
    public static Allocator Null => new(0);
    public static implicit operator Allocator(nint handle) => new(handle);
    public static implicit operator nint(Allocator handle) => handle.Handle;
    public static bool operator ==(Allocator left, Allocator right) => left.Handle == right.Handle;
    public static bool operator !=(Allocator left, Allocator right) => left.Handle != right.Handle;
    public static bool operator ==(Allocator left, nint right) => left.Handle == right;
    public static bool operator !=(Allocator left, nint right) => left.Handle != right;
    public bool Equals(Allocator other) => Handle == other.Handle;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Allocator handle && Equals(handle);
    /// <inheritdoc/>
    public override int GetHashCode() => Handle.GetHashCode();
    private string DebuggerDisplay => $"{nameof(Allocator)} [0x{Handle:X}]";

    public uint AddRef() => D3D12MA_Allocator_AddRef(Handle);
    public uint Release() => D3D12MA_Allocator_Release(Handle);

    public bool IsUMA => D3D12MA_Allocator_IsUMA(Handle);
    public bool IsCacheCoherentUMA => D3D12MA_Allocator_IsCacheCoherentUMA(Handle);
    public bool IsGPUUploadHeapSupported => D3D12MA_Allocator_IsGPUUploadHeapSupported(Handle);

    public ulong GetMemoryCapacity(uint memorySegmentGroup) => D3D12MA_Allocator_GetMemoryCapacity(Handle, memorySegmentGroup);

    public HResult CreateResource(AllocationDesc* pAllocDesc,
        in ResourceDescription resourceDesc,
        ResourceStates initialResourceState,
        ClearValue* pOptimizedClearValue,
        Allocation* allocation, Guid* riidResource, void** ppvResource)
    {
        fixed (ResourceDescription* pResourceDesc = &resourceDesc)
        {
            return D3D12MA_Allocator_CreateResource(Handle, pAllocDesc, pResourceDesc, initialResourceState, pOptimizedClearValue, allocation, riidResource, ppvResource);
        }
    }

    public HResult CreateResource<TResource>(AllocationDesc* pAllocDesc,
        in ResourceDescription resourceDesc,
        ResourceStates initialResourceState,
        ClearValue* pOptimizedClearValue,
        Allocation* allocation, TResource** ppvResource)
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

    public HResult CreateResource2(AllocationDesc* pAllocDesc,
        ResourceDescription1* pResourceDesc,
        ResourceStates initialResourceState,
        ClearValue* pOptimizedClearValue,
        Allocation* allocation, Guid* riidResource, void** ppvResource)
    {
        return D3D12MA_Allocator_CreateResource2(Handle, pAllocDesc, pResourceDesc, initialResourceState, pOptimizedClearValue, allocation, riidResource, ppvResource);
    }

    public HResult CreateResource3(AllocationDesc* pAllocDesc,
        ResourceDescription1* pResourceDesc,
        BarrierLayout initialLayout,
        ClearValue* pOptimizedClearValue,
        uint numCastableFormats, Format* pCastableFormats,
        Allocation* allocation, Guid* riidResource, void** ppvResource)
    {
        return D3D12MA_Allocator_CreateResource3(Handle, pAllocDesc, pResourceDesc, initialLayout,
            pOptimizedClearValue,
            numCastableFormats, pCastableFormats,
            allocation, riidResource, ppvResource);
    }
}
