// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Vortice.Win32.Graphics.Dxgi.Common;

namespace Vortice.Win32.Graphics;

public unsafe partial struct D3D12_MIP_REGION : IEquatable<D3D12_MIP_REGION>
{
    public D3D12_MIP_REGION(uint width, uint height, uint depth)
    {
        Width = width;
        Height = height;
        Depth = depth;
    }

    public static bool operator ==(in D3D12_MIP_REGION left, in D3D12_MIP_REGION right)
    {
        return
            left.Width == right.Width &&
            left.Height == right.Height &&
            left.Depth == right.Depth;
    }

    public static bool operator !=(in D3D12_MIP_REGION left, in D3D12_MIP_REGION right)
        => !(left == right);

    public override bool Equals([NotNullWhen(true)] object? obj) => (obj is D3D12_MIP_REGION other) && Equals(other);

    public bool Equals(D3D12_MIP_REGION other) => this == other;

    public override int GetHashCode()
    {
        return HashCode.Combine(Width, Height, Depth);
    }
}
