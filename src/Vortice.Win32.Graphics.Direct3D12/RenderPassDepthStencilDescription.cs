// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Dxgi.Common;

namespace Win32.Graphics.Direct3D12;

public partial struct RenderPassDepthStencilDescription : IEquatable<RenderPassDepthStencilDescription>
{
    public static bool operator ==(in RenderPassDepthStencilDescription left, in RenderPassDepthStencilDescription right)
    {
        if (left.cpuDescriptor.ptr != right.cpuDescriptor.ptr)
        {
            return false;
        }

        if (!(left.DepthBeginningAccess == right.DepthBeginningAccess))
        {
            return false;
        }

        if (!(left.StencilBeginningAccess == right.StencilBeginningAccess))
        {
            return false;
        }

        if (!(left.DepthEndingAccess == right.DepthEndingAccess))
        {
            return false;
        }

        if (!(left.StencilEndingAccess == right.StencilEndingAccess))
        {
            return false;
        }

        return true;
    }

    public static bool operator !=(in RenderPassDepthStencilDescription left, in RenderPassDepthStencilDescription right)
        => !(left == right);

    public override bool Equals(object? obj) => (obj is RenderPassDepthStencilDescription other) && Equals(other);

    public bool Equals(RenderPassDepthStencilDescription other) => this == other;

    public override int GetHashCode()
    {
        return HashCode.Combine(cpuDescriptor, DepthBeginningAccess, StencilBeginningAccess, DepthEndingAccess, StencilEndingAccess);
    }
}
