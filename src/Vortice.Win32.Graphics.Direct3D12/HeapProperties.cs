// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.Direct3D12.Apis;

namespace Vortice.Win32.Graphics.Direct3D12;

public partial struct HeapProperties : IEquatable<HeapProperties>
{
    public HeapProperties(D3D12_CPU_PAGE_PROPERTY cpuPageProperty,
        D3D12_MEMORY_POOL memoryPoolPreference,
        uint creationNodeMask = 1,
        uint nodeMask = 1)
    {
        Type = D3D12_HEAP_TYPE_CUSTOM;
        CPUPageProperty = cpuPageProperty;
        MemoryPoolPreference = memoryPoolPreference;
        CreationNodeMask = creationNodeMask;
        VisibleNodeMask = nodeMask;
    }

    public HeapProperties(D3D12_HEAP_TYPE type, uint creationNodeMask = 1, uint nodeMask = 1)
    {
        Type = type;
        CPUPageProperty = D3D12_CPU_PAGE_PROPERTY_UNKNOWN;
        MemoryPoolPreference = D3D12_MEMORY_POOL_UNKNOWN;
        CreationNodeMask = creationNodeMask;
        VisibleNodeMask = nodeMask;
    }

    public bool IsCPUAccessible
    {
        get
        {
            return (Type == D3D12_HEAP_TYPE_UPLOAD)
                || (Type == D3D12_HEAP_TYPE_READBACK)
                || ((Type == D3D12_HEAP_TYPE_CUSTOM) && ((CPUPageProperty == D3D12_CPU_PAGE_PROPERTY_WRITE_COMBINE) || (CPUPageProperty == D3D12_CPU_PAGE_PROPERTY_WRITE_BACK)));
        }
    }

    public static bool operator ==(in HeapProperties left, in HeapProperties right)
    {
        return (left.Type == right.Type)
            && (left.CPUPageProperty == right.CPUPageProperty)
            && (left.MemoryPoolPreference == right.MemoryPoolPreference)
            && (left.CreationNodeMask == right.CreationNodeMask)
            && (left.VisibleNodeMask == right.VisibleNodeMask);
    }

    public static bool operator !=(in HeapProperties left, in HeapProperties right)
        => !(left == right);

    public override bool Equals(object? obj) => (obj is HeapProperties other) && Equals(other);

    public bool Equals(HeapProperties other) => this == other;

    public override int GetHashCode() => HashCode.Combine(Type, CPUPageProperty, MemoryPoolPreference, CreationNodeMask, VisibleNodeMask);
}
