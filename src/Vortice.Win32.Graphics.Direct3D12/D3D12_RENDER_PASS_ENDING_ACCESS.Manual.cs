// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D3D12;

namespace Vortice.Win32.Graphics;

public partial struct D3D12_RENDER_PASS_ENDING_ACCESS : IEquatable<D3D12_RENDER_PASS_ENDING_ACCESS>
{
    public static bool operator ==(in D3D12_RENDER_PASS_ENDING_ACCESS left, in D3D12_RENDER_PASS_ENDING_ACCESS right)
    {
        if (left.Type != right.Type)
        {
            return false;
        }

        if (left.Type == D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_RESOLVE && !(left.Anonymous.Resolve == right.Anonymous.Resolve))
        {
            return false;
        }

        return true;
    }

    public static bool operator !=(in D3D12_RENDER_PASS_ENDING_ACCESS left, in D3D12_RENDER_PASS_ENDING_ACCESS right)
        => !(left == right);

    public override bool Equals(object? obj) => (obj is D3D12_RENDER_PASS_ENDING_ACCESS other) && Equals(other);

    public bool Equals(D3D12_RENDER_PASS_ENDING_ACCESS other) => this == other;

    public override int GetHashCode()
    {
        var hashCode = new HashCode();
        {
            hashCode.Add(Type);

            if (Type == D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_RESOLVE)
            {
                hashCode.Add(Anonymous.Resolve);
            }
        }
        return hashCode.ToHashCode();
    }
}
