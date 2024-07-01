// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D12;

public unsafe partial struct RenderPassEndingAccessResolveParameters : IEquatable<RenderPassEndingAccessResolveParameters>
{
    public static bool operator ==(in RenderPassEndingAccessResolveParameters left, in RenderPassEndingAccessResolveParameters right)
    {
        if (left.pSrcResource != right.pSrcResource)
        {
            return false;
        }

        if (left.pDstResource != right.pDstResource)
        {
            return false;
        }

        if (left.SubresourceCount != right.SubresourceCount)
        {
            return false;
        }

        if (left.Format != right.Format)
        {
            return false;
        }

        if (left.ResolveMode != right.ResolveMode)
        {
            return false;
        }

        if (left.PreserveResolveSource != right.PreserveResolveSource)
        {
            return false;
        }

        return true;
    }

    public static bool operator !=(in RenderPassEndingAccessResolveParameters left, in RenderPassEndingAccessResolveParameters right)
        => !(left == right);

    public override bool Equals(object? obj) => (obj is RenderPassEndingAccessResolveParameters other) && Equals(other);

    public bool Equals(RenderPassEndingAccessResolveParameters other) => this == other;

    public override int GetHashCode()
    {
        return HashCode.Combine(
            (nuint)pSrcResource,
            (nuint)pDstResource,
            SubresourceCount,
            (nuint)pSubresourceParameters,
            Format,
            ResolveMode,
            PreserveResolveSource);
    }
}
