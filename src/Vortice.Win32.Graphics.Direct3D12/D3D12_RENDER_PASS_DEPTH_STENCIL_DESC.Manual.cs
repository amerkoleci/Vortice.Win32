// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Graphics;

public partial struct D3D12_RENDER_PASS_DEPTH_STENCIL_DESC : IEquatable<D3D12_RENDER_PASS_DEPTH_STENCIL_DESC>
{
    public static bool operator ==(in D3D12_RENDER_PASS_DEPTH_STENCIL_DESC left, in D3D12_RENDER_PASS_DEPTH_STENCIL_DESC right)
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

    public static bool operator !=(in D3D12_RENDER_PASS_DEPTH_STENCIL_DESC left, in D3D12_RENDER_PASS_DEPTH_STENCIL_DESC right)
        => !(left == right);

    public override bool Equals(object? obj) => (obj is D3D12_RENDER_PASS_DEPTH_STENCIL_DESC other) && Equals(other);

    public bool Equals(D3D12_RENDER_PASS_DEPTH_STENCIL_DESC other) => this == other;

    public override int GetHashCode()
    {
        return HashCode.Combine(cpuDescriptor, DepthBeginningAccess, StencilBeginningAccess, DepthEndingAccess, StencilEndingAccess);
    }
}
