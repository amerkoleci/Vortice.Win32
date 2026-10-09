// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Graphics;

public unsafe partial struct D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS : IEquatable<D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS>
{
    public static bool operator ==(in D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS left, in D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS right)
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

    public static bool operator !=(in D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS left, in D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS right)
        => !(left == right);

    public override bool Equals([NotNullWhen(true)] object? obj) => (obj is D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS other) && Equals(other);

    public readonly bool Equals(D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS other) => this == other;

    public override readonly int GetHashCode() => HashCode.Combine((nuint)pSrcResource, (nuint)(pDstResource), SubresourceCount, Format, ResolveMode, PreserveResolveSource);
}
