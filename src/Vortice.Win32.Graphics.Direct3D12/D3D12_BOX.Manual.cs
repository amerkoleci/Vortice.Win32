// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Graphics;

public partial struct D3D12_BOX : IEquatable<D3D12_BOX>
{
    public D3D12_BOX(int left, int right)
    {
        this.left = (uint)left;
        top = 0;
        front = 0;
        this.right = (uint)right;
        bottom = 1;
        back = 1;
    }

    public D3D12_BOX(int Left, int Top, int Right, int Bottom)
    {
        left = (uint)Left;
        top = (uint)Top;
        front = 0;
        right = (uint)Right;
        bottom = (uint)Bottom;
        back = 1;
    }

    public D3D12_BOX(int Left, int Top, int Front, int Right, int Bottom, int Back)
    {
        left = (uint)Left;
        top = (uint)Top;
        front = (uint)Front;
        right = (uint)Right;
        bottom = (uint)Bottom;
        back = (uint)Back;
    }

    public static bool operator ==(in D3D12_BOX left, in D3D12_BOX right)
        => (left.left == right.left)
        && (left.top == right.top)
        && (left.front == right.front)
        && (left.right == right.right)
        && (left.bottom == right.bottom)
        && (left.back == right.back);

    public static bool operator !=(in D3D12_BOX left, in D3D12_BOX right)
        => !(left == right);

    public override bool Equals([NotNullWhen(true)] object? obj) => (obj is D3D12_BOX other) && Equals(other);

    public bool Equals(D3D12_BOX other) => this == other;

    public override int GetHashCode()
    {
        return HashCode.Combine(left, top, front, right, bottom, back);
    }
}
