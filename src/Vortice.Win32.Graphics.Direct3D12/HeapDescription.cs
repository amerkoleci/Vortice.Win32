// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.
using static Vortice.Win32.Graphics.Direct3D12.Apis;

namespace Vortice.Win32.Graphics.Direct3D12;

public unsafe partial struct HeapDescription : IEquatable<HeapDescription>
{
    public HeapDescription(ulong size,
        HeapProperties properties,
        ulong alignment = 0,
        D3D12_HEAP_FLAGS flags = D3D12_HEAP_FLAG_NONE)
    {
        SizeInBytes = size;
        Properties = properties;
        Alignment = alignment;
        Flags = flags;
    }

    public HeapDescription(ulong size,
        D3D12_HEAP_TYPE type,
        ulong alignment = 0,
        D3D12_HEAP_FLAGS flags = D3D12_HEAP_FLAG_NONE)
    {
        SizeInBytes = size;
        Properties = new HeapProperties(type);
        Alignment = alignment;
        Flags = flags;
    }

    public HeapDescription(ulong size,
        D3D12_CPU_PAGE_PROPERTY cpuPageProperty,
        D3D12_MEMORY_POOL memoryPoolPreference,
        ulong alignment = 0,
        D3D12_HEAP_FLAGS flags = D3D12_HEAP_FLAG_NONE)
    {
        SizeInBytes = size;
        Properties = new HeapProperties(cpuPageProperty, memoryPoolPreference);
        Alignment = alignment;
        Flags = flags;
    }

    public HeapDescription(in ResourceAllocationInfo resourceAllocInfo,
        HeapProperties properties,
        D3D12_HEAP_FLAGS flags = D3D12_HEAP_FLAG_NONE)
    {
        SizeInBytes = resourceAllocInfo.SizeInBytes;
        Properties = properties;
        Alignment = resourceAllocInfo.Alignment;
        Flags = flags;
    }

    public HeapDescription(in ResourceAllocationInfo resourceAllocInfo,
        D3D12_HEAP_TYPE type,
        D3D12_HEAP_FLAGS flags = D3D12_HEAP_FLAG_NONE)
    {
        SizeInBytes = resourceAllocInfo.SizeInBytes;
        Properties = new HeapProperties(type);
        Alignment = resourceAllocInfo.Alignment;
        Flags = flags;
    }

    public HeapDescription(in ResourceAllocationInfo resAllocInfo,
        D3D12_CPU_PAGE_PROPERTY cpuPageProperty,
        D3D12_MEMORY_POOL memoryPoolPreference,
        D3D12_HEAP_FLAGS flags = D3D12_HEAP_FLAG_NONE)
    {
        SizeInBytes = resAllocInfo.SizeInBytes;
        Properties = new HeapProperties(cpuPageProperty, memoryPoolPreference);
        Alignment = resAllocInfo.Alignment;
        Flags = flags;
    }

    public bool IsCPUAccessible => Properties.IsCPUAccessible;

    public static bool operator ==(in HeapDescription left, in HeapDescription right)
    {
        return (left.SizeInBytes == right.SizeInBytes)
            && (left.Properties == right.Properties)
            && (left.Alignment == right.Alignment)
            && (left.Flags == right.Flags);
    }

    public static bool operator !=(in HeapDescription left, in HeapDescription right)
        => !(left == right);

    public override bool Equals(object? obj) => (obj is HeapDescription other) && Equals(other);

    public bool Equals(HeapDescription other) => this == other;

    public override int GetHashCode() => HashCode.Combine(SizeInBytes, Properties, Alignment, Flags);
}
