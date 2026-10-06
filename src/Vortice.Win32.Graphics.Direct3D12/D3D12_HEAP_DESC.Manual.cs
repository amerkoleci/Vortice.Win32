// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D3D12;

namespace Vortice.Win32.Graphics;

public unsafe partial struct D3D12_HEAP_DESC : IEquatable<D3D12_HEAP_DESC>
{
    public D3D12_HEAP_DESC(ulong size,
        D3D12_HEAP_PROPERTIES properties,
        ulong alignment = 0,
        D3D12_HEAP_FLAGS flags = D3D12_HEAP_FLAG_NONE)
    {
        SizeInBytes = size;
        Properties = properties;
        Alignment = alignment;
        Flags = flags;
    }

    public D3D12_HEAP_DESC(ulong size,
        D3D12_HEAP_TYPE type,
        ulong alignment = 0,
        D3D12_HEAP_FLAGS flags = D3D12_HEAP_FLAG_NONE)
    {
        SizeInBytes = size;
        Properties = new D3D12_HEAP_PROPERTIES(type);
        Alignment = alignment;
        Flags = flags;
    }

    public D3D12_HEAP_DESC(ulong size,
        D3D12_CPU_PAGE_PROPERTY cpuPageProperty,
        D3D12_MEMORY_POOL memoryPoolPreference,
        ulong alignment = 0,
        D3D12_HEAP_FLAGS flags = D3D12_HEAP_FLAG_NONE)
    {
        SizeInBytes = size;
        Properties = new D3D12_HEAP_PROPERTIES(cpuPageProperty, memoryPoolPreference);
        Alignment = alignment;
        Flags = flags;
    }

    public D3D12_HEAP_DESC(in D3D12_RESOURCE_ALLOCATION_INFO resourceAllocInfo,
        D3D12_HEAP_PROPERTIES properties,
        D3D12_HEAP_FLAGS flags = D3D12_HEAP_FLAG_NONE)
    {
        SizeInBytes = resourceAllocInfo.SizeInBytes;
        Properties = properties;
        Alignment = resourceAllocInfo.Alignment;
        Flags = flags;
    }

    public D3D12_HEAP_DESC(in D3D12_RESOURCE_ALLOCATION_INFO resourceAllocInfo,
        D3D12_HEAP_TYPE type,
        D3D12_HEAP_FLAGS flags = D3D12_HEAP_FLAG_NONE)
    {
        SizeInBytes = resourceAllocInfo.SizeInBytes;
        Properties = new(type);
        Alignment = resourceAllocInfo.Alignment;
        Flags = flags;
    }

    public D3D12_HEAP_DESC(in D3D12_RESOURCE_ALLOCATION_INFO resAllocInfo,
        D3D12_CPU_PAGE_PROPERTY cpuPageProperty,
        D3D12_MEMORY_POOL memoryPoolPreference,
        D3D12_HEAP_FLAGS flags = D3D12_HEAP_FLAG_NONE)
    {
        SizeInBytes = resAllocInfo.SizeInBytes;
        Properties = new(cpuPageProperty, memoryPoolPreference);
        Alignment = resAllocInfo.Alignment;
        Flags = flags;
    }

    public bool IsCPUAccessible => Properties.IsCPUAccessible;

    public static bool operator ==(in D3D12_HEAP_DESC left, in D3D12_HEAP_DESC right)
    {
        return (left.SizeInBytes == right.SizeInBytes)
            && (left.Properties == right.Properties)
            && (left.Alignment == right.Alignment)
            && (left.Flags == right.Flags);
    }

    public static bool operator !=(in D3D12_HEAP_DESC left, in D3D12_HEAP_DESC right)
        => !(left == right);

    public override bool Equals([NotNullWhen(true)] object? obj) => (obj is D3D12_HEAP_DESC other) && Equals(other);

    public bool Equals(D3D12_HEAP_DESC other) => this == other;

    public override int GetHashCode() => HashCode.Combine(SizeInBytes, Properties, Alignment, Flags);
}
