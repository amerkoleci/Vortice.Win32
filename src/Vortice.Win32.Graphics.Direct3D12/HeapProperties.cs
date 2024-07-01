// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D12;

public partial struct HeapProperties : IEquatable<HeapProperties>
{
    public HeapProperties(CpuPageProperty cpuPageProperty,
        MemoryPool memoryPoolPreference,
        uint creationNodeMask = 1,
        uint nodeMask = 1)
    {
        Type = HeapType.Custom;
        CPUPageProperty = cpuPageProperty;
        MemoryPoolPreference = memoryPoolPreference;
        CreationNodeMask = creationNodeMask;
        VisibleNodeMask = nodeMask;
    }

    public HeapProperties(HeapType type, uint creationNodeMask = 1, uint nodeMask = 1)
    {
        Type = type;
        CPUPageProperty = CpuPageProperty.Unknown;
        MemoryPoolPreference = MemoryPool.Unknown;
        CreationNodeMask = creationNodeMask;
        VisibleNodeMask = nodeMask;
    }

    public bool IsCPUAccessible
    {
        get
        {
            return (Type == HeapType.Upload)
                || (Type == HeapType.Readback)
                || ((Type == HeapType.Custom) && ((CPUPageProperty == CpuPageProperty.WriteCombine) || (CPUPageProperty == CpuPageProperty.WriteBack)));
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
