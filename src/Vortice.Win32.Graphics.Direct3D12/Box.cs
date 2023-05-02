// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D12;

public partial struct Box : IEquatable<Box>
{
    public Box(int left, int right)
    {
        this.left = (uint)left;
        top = 0;
        front = 0;
        this.right = (uint)right;
        bottom = 1;
        back = 1;
    }

    public Box(int Left, int Top, int Right, int Bottom)
    {
        left = (uint)Left;
        top = (uint)Top;
        front = 0;
        right = (uint)Right;
        bottom = (uint)Bottom;
        back = 1;
    }

    public Box(int Left, int Top, int Front, int Right, int Bottom, int Back)
    {
        left = (uint)Left;
        top = (uint)Top;
        front = (uint)Front;
        right = (uint)Right;
        bottom = (uint)Bottom;
        back = (uint)Back;
    }

    public static bool operator ==(in Box left, in Box right)
        => (left.left == right.left)
        && (left.top == right.top)
        && (left.front == right.front)
        && (left.right == right.right)
        && (left.bottom == right.bottom)
        && (left.back == right.back);

    public static bool operator !=(in Box left, in Box right)
        => !(left == right);

    public override bool Equals(object? obj) => (obj is Box other) && Equals(other);

    public bool Equals(Box other) => this == other;

    public override int GetHashCode()
    {
        return HashCode.Combine(left, top, front, right, bottom, back);
    }
}
