// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D12;

public unsafe partial struct GpuDescriptorHandle : IEquatable<GpuDescriptorHandle>
{
    public static GpuDescriptorHandle Default => default;

    public GpuDescriptorHandle(in GpuDescriptorHandle other, int offsetScaledByIncrementSize)
    {
        InitOffsetted(out this, other, offsetScaledByIncrementSize);
    }

    public GpuDescriptorHandle(in GpuDescriptorHandle other, int offsetInDescriptors, uint descriptorIncrementSize)
    {
        InitOffsetted(out this, other, offsetInDescriptors, descriptorIncrementSize);
    }

    public GpuDescriptorHandle Offset(int offsetInDescriptors, uint descriptorIncrementSize)
    {
        ptr = (ulong)((long)ptr + ((long)offsetInDescriptors * (long)descriptorIncrementSize));
        return this;
    }

    public GpuDescriptorHandle Offset(int offsetScaledByIncrementSize)
    {
        ptr = (ulong)((long)ptr + (long)offsetScaledByIncrementSize);
        return this;
    }


    public static bool operator ==(in GpuDescriptorHandle left, in GpuDescriptorHandle right)
        => (left.ptr == right.ptr);

    public static bool operator !=(in GpuDescriptorHandle left, in GpuDescriptorHandle right)
        => (left.ptr != right.ptr);

    public void InitOffsetted(in GpuDescriptorHandle @base, int offsetScaledByIncrementSize)
    {
        InitOffsetted(out this, @base, offsetScaledByIncrementSize);
    }

    public void InitOffsetted(in GpuDescriptorHandle @base, int offsetInDescriptors, uint descriptorIncrementSize)
    {
        InitOffsetted(out this, @base, offsetInDescriptors, descriptorIncrementSize);
    }

    public static void InitOffsetted(out GpuDescriptorHandle handle, in GpuDescriptorHandle @base, int offsetScaledByIncrementSize)
    {
        handle.ptr = (ulong)((long)@base.ptr + (long)offsetScaledByIncrementSize);
    }

    public static void InitOffsetted(out GpuDescriptorHandle handle, in GpuDescriptorHandle @base, int offsetInDescriptors, uint descriptorIncrementSize)
    {
        handle.ptr = (ulong)((long)@base.ptr + ((long)offsetInDescriptors * (long)descriptorIncrementSize));
    }

    public override bool Equals(object? obj) => (obj is GpuDescriptorHandle other) && Equals(other);

    public bool Equals(GpuDescriptorHandle other) => this == other;

    public override int GetHashCode() => ptr.GetHashCode();
}
