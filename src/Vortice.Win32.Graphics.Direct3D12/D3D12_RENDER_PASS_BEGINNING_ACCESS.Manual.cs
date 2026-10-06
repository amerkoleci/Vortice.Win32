// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D3D12;

namespace Vortice.Win32.Graphics;

public partial struct D3D12_RENDER_PASS_BEGINNING_ACCESS : IEquatable<D3D12_RENDER_PASS_BEGINNING_ACCESS>
{
    public static bool operator ==(in D3D12_RENDER_PASS_BEGINNING_ACCESS left, in D3D12_RENDER_PASS_BEGINNING_ACCESS right)
    {
        if (left.Type != right.Type)
        {
            return false;
        }

        if (left.Type == D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_CLEAR && !(left.Anonymous.Clear == right.Anonymous.Clear))
        {
            return false;
        }

        return true;
    }

    public static bool operator !=(in D3D12_RENDER_PASS_BEGINNING_ACCESS left, in D3D12_RENDER_PASS_BEGINNING_ACCESS right)
        => !(left == right);

    public override bool Equals([NotNullWhen(true)] object? obj) => (obj is D3D12_RENDER_PASS_BEGINNING_ACCESS other) && Equals(other);

    public bool Equals(D3D12_RENDER_PASS_BEGINNING_ACCESS other) => this == other;

    public override int GetHashCode()
    {
        var hashCode = new HashCode();
        {
            hashCode.Add(Type);

            if (Type == D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_CLEAR)
            {
                hashCode.Add(Anonymous.Clear);
            }
        }
        return hashCode.ToHashCode();
    }
}
