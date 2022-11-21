// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D12;

public unsafe partial struct RenderPassRenderTargetDescription : IEquatable<RenderPassRenderTargetDescription>
{
    public static bool operator ==(in RenderPassRenderTargetDescription left, in RenderPassRenderTargetDescription right)
    {
        if (left.cpuDescriptor.ptr != right.cpuDescriptor.ptr)
        {
            return false;
        }

        if (!(left.BeginningAccess == right.BeginningAccess))
        {
            return false;
        }

        if (!(left.EndingAccess == right.EndingAccess))
        {
            return false;
        }

        return true;
    }

    public static bool operator !=(in RenderPassRenderTargetDescription left, in RenderPassRenderTargetDescription right)
        => !(left == right);

    public override bool Equals(object? obj) => (obj is RenderPassRenderTargetDescription other) && Equals(other);

    public bool Equals(RenderPassRenderTargetDescription other) => this == other;

    public override int GetHashCode()
    {
        return HashCode.Combine(cpuDescriptor, BeginningAccess, EndingAccess);
    }
}
