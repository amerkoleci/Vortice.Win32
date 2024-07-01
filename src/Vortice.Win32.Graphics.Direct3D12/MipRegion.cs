// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Dxgi.Common;

namespace Win32.Graphics.Direct3D12;

public unsafe partial struct MipRegion : IEquatable<MipRegion>
{
    public MipRegion(uint width, uint height, uint depth)
    {
        Width = width;
        Height = height;
        Depth = depth;
    }

    public static bool operator ==(in MipRegion left, in MipRegion right)
    {
        return
            left.Width == right.Width &&
            left.Height == right.Height &&
            left.Depth == right.Depth;
    }

    public static bool operator !=(in MipRegion left, in MipRegion right)
        => !(left == right);

    public override bool Equals(object? obj) => (obj is MipRegion other) && Equals(other);

    public bool Equals(MipRegion other) => this == other;

    public override int GetHashCode()
    {
        return HashCode.Combine(Width, Height, Depth);
    }
}
