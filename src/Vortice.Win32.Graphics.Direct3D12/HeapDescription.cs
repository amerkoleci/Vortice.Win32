// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D12;

public unsafe partial struct HeapDescription : IEquatable<HeapDescription>
{
    public HeapDescription(ulong size,
        HeapProperties properties,
        ulong alignment = 0,
        HeapFlags flags = HeapFlags.None)
    {
        SizeInBytes = size;
        Properties = properties;
        Alignment = alignment;
        Flags = flags;
    }

    public HeapDescription(ulong size,
        HeapType type,
        ulong alignment = 0,
        HeapFlags flags = HeapFlags.None)
    {
        SizeInBytes = size;
        Properties = new HeapProperties(type);
        Alignment = alignment;
        Flags = flags;
    }

    public HeapDescription(ulong size,
        CpuPageProperty cpuPageProperty,
        MemoryPool memoryPoolPreference,
        ulong alignment = 0,
        HeapFlags flags = HeapFlags.None)
    {
        SizeInBytes = size;
        Properties = new HeapProperties(cpuPageProperty, memoryPoolPreference);
        Alignment = alignment;
        Flags = flags;
    }

    public HeapDescription(in ResourceAllocationInfo resourceAllocInfo,
        HeapProperties properties,
        HeapFlags flags = HeapFlags.None)
    {
        SizeInBytes = resourceAllocInfo.SizeInBytes;
        Properties = properties;
        Alignment = resourceAllocInfo.Alignment;
        Flags = flags;
    }

    public HeapDescription(in ResourceAllocationInfo resourceAllocInfo,
        HeapType type,
        HeapFlags flags = HeapFlags.None)
    {
        SizeInBytes = resourceAllocInfo.SizeInBytes;
        Properties = new HeapProperties(type);
        Alignment = resourceAllocInfo.Alignment;
        Flags = flags;
    }

    public HeapDescription(in ResourceAllocationInfo resAllocInfo,
        CpuPageProperty cpuPageProperty,
        MemoryPool memoryPoolPreference,
        HeapFlags flags = HeapFlags.None)
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
