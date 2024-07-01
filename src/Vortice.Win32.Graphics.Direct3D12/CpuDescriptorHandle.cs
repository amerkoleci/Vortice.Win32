// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D12;

public unsafe partial struct CpuDescriptorHandle : IEquatable<CpuDescriptorHandle>
{
    public static CpuDescriptorHandle Default => default;

    public CpuDescriptorHandle(in CpuDescriptorHandle other, int offsetScaledByIncrementSize)
    {
        InitOffsetted(out this, other, offsetScaledByIncrementSize);
    }

    public CpuDescriptorHandle(in CpuDescriptorHandle other, int offsetInDescriptors, uint descriptorIncrementSize)
    {
        InitOffsetted(out this, other, offsetInDescriptors, descriptorIncrementSize);
    }

    public CpuDescriptorHandle Offset(int offsetInDescriptors, uint descriptorIncrementSize)
    {
        ptr = unchecked((nuint)((long)ptr + ((long)offsetInDescriptors * (long)descriptorIncrementSize)));
        return this;
    }

    public CpuDescriptorHandle Offset(int offsetScaledByIncrementSize)
    {
        ptr = unchecked((nuint)((long)ptr + (long)offsetScaledByIncrementSize));
        return this;
    }

    public static bool operator ==(in CpuDescriptorHandle left, in CpuDescriptorHandle right)
        => (left.ptr == right.ptr);

    public static bool operator !=(in CpuDescriptorHandle left, in CpuDescriptorHandle right)
        => (left.ptr != right.ptr);

    public void InitOffsetted(in CpuDescriptorHandle @base, int offsetScaledByIncrementSize)
    {
        InitOffsetted(out this, @base, offsetScaledByIncrementSize);
    }

    public void InitOffsetted(in CpuDescriptorHandle @base, int offsetInDescriptors, uint descriptorIncrementSize)
    {
        InitOffsetted(out this, @base, offsetInDescriptors, descriptorIncrementSize);
    }

    public static void InitOffsetted(out CpuDescriptorHandle handle, in CpuDescriptorHandle @base, int offsetScaledByIncrementSize)
    {
        handle.ptr = (nuint)((long)@base.ptr + (long)offsetScaledByIncrementSize);
    }

    public static void InitOffsetted(out CpuDescriptorHandle handle, in CpuDescriptorHandle @base, int offsetInDescriptors, uint descriptorIncrementSize)
    {
        handle.ptr = (nuint)((long)@base.ptr + ((long)offsetInDescriptors * (long)descriptorIncrementSize));
    }

    public override bool Equals(object? obj) => (obj is CpuDescriptorHandle other) && Equals(other);

    public bool Equals(CpuDescriptorHandle other) => this == other;

    public override int GetHashCode() => ptr.GetHashCode();
}
