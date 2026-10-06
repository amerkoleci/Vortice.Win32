// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Graphics;

public unsafe partial struct D3D12_RENDER_PASS_RENDER_TARGET_DESC : IEquatable<D3D12_RENDER_PASS_RENDER_TARGET_DESC>
{
    public static bool operator ==(in D3D12_RENDER_PASS_RENDER_TARGET_DESC left, in D3D12_RENDER_PASS_RENDER_TARGET_DESC right)
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

    public static bool operator !=(in D3D12_RENDER_PASS_RENDER_TARGET_DESC left, in D3D12_RENDER_PASS_RENDER_TARGET_DESC right)
        => !(left == right);

    public override bool Equals(object? obj) => (obj is D3D12_RENDER_PASS_RENDER_TARGET_DESC other) && Equals(other);

    public bool Equals(D3D12_RENDER_PASS_RENDER_TARGET_DESC other) => this == other;

    public override int GetHashCode()
    {
        return HashCode.Combine(cpuDescriptor, BeginningAccess, EndingAccess);
    }
}
