// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Drawing;

namespace Win32.Numerics;

/// <summary>
/// Defines an integer rectangle (Left, Top, Right, Bottom)
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 4)]
[DebuggerDisplay("Left: {Left}, Top: {Top}, Right: {Right}, Bottom: {Bottom}")]
public struct Rect : IEquatable<Rect>
{
    public static Rect Empty => new();

    public Rect(int left, int top, int right, int bottom)
    {
        Left = left;
        Top = top;
        Right = right;
        Bottom = bottom;
    }

    /// <summary>
    /// The left position.
    /// </summary>
    public int Left;

    /// <summary>
    /// The top position.
    /// </summary>
    public int Top;

    /// <summary>
    /// The right position
    /// </summary>
    public int Right;

    /// <summary>
    /// The bottom position.
    /// </summary>
    public int Bottom;

    public readonly int Width => Right - Left;

    public readonly int Height => Bottom - Top;

    public Point Location
    {
        readonly get => new Point(Left, Top);
        set => this = Rect.Create(value, Size);
    }

    public Size Size
    {
        readonly get => new(Width, Height);
        set
        {
            Right = Left + value.Width;
            Bottom = Top + value.Height;
        }
    }

    public readonly int CenterX => Left + (Width / 2);

    public readonly int CenterY => Top + (Height / 2);

    public void Offset(int x, int y)
    {
        Left += x;
        Top += y;
        Right += x;
        Bottom += y;
    }

    public void Offset(Point pos) => Offset(pos.X, pos.Y);

    public static Rect Create(Point location, Size size) => Create(location.X, location.Y, size.Width, size.Height);

    public static Rect Create(Size size) => Create(Point.Empty, size);

    public static Rect Create(int width, int height) => new(0, 0, width, height);

    public static Rect Create(int x, int y, int width, int height) => new(x, y, x + width, y + height);

    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Rect value && Equals(value);

    public static Rect Inflate(Rect rect, int x, int y)
    {
        Rect r = new(rect.Left, rect.Top, rect.Right, rect.Bottom);
        r.Inflate(x, y);
        return r;
    }

    public void Inflate(Size size) => Inflate(size.Width, size.Height);

    public void Inflate(int x, int y)
    {
        Left -= x;
        Top -= y;
        Right += x;
        Bottom += y;
    }

    public readonly bool Contains(int x, int y)
    {
        return (x >= Left) && (x < Right) && (y >= Top) && (y < Bottom);
    }

    public readonly bool Contains(Point pt) => Contains(pt.X, pt.Y);

    public readonly bool Contains(Rect rect) =>
        (Left <= rect.Left) && (Right >= rect.Right) &&
        (Top <= rect.Top) && (Bottom >= rect.Bottom);

    public readonly bool IntersectsWith(Rect rect)
    {
        return (Left < rect.Right) && (Right > rect.Left) && (Top < rect.Bottom) && (Bottom > rect.Top);
    }

    public readonly bool IntersectsWithInclusive(Rect rect)
    {
        return (Left <= rect.Right) && (Right >= rect.Left) && (Top <= rect.Bottom) && (Bottom >= rect.Top);
    }

    public static Rect Intersect(Rect left, Rect right)
    {
        if (!left.IntersectsWithInclusive(right))
        {
            return Empty;
        }

        return new Rect(
            Math.Max(left.Left, right.Left),
            Math.Max(left.Top, right.Top),
            Math.Min(left.Right, right.Right),
            Math.Min(left.Bottom, right.Bottom)
            );
    }

    public void Intersect(Rect rect)
    {
        this = Intersect(this, rect);
    }

    public static Rect Union(Rect left, Rect right)
    {
        return new(
            Math.Min(left.Left, right.Left),
            Math.Min(left.Top, right.Top),
            Math.Max(left.Right, right.Right),
            Math.Max(left.Bottom, right.Bottom)
            );
    }

    public void Union(Rect rect)
    {
        this = Union(this, rect);
    }

    /// <summary>
    /// Determines whether the specified <see cref="Rect"/> is equal to this instance.
    /// </summary>
    /// <param name="other">The <see cref="Rect"/> to compare with this instance.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Equals(Rect other)
    {
        return
            Left == other.Left
            && Top == other.Top
            && Right == other.Right
            && Bottom == other.Bottom;
    }

    /// <inheritdoc />
    public override int GetHashCode() => HashCode.Combine(Left, Top, Right, Bottom);

    /// <inheritdoc/>
    public override string ToString()
    {
        return $"{nameof(Left)}: {Left}, {nameof(Top)}: {Top}, {nameof(Right)}: {Right}, {nameof(Bottom)}: {Bottom}";
    }

    /// <summary>
    /// Compares two <see cref="Rect"/> objects for equality.
    /// </summary>
    /// <param name="left">The <see cref="Rect"/> on the left hand of the operand.</param>
    /// <param name="right">The <see cref="Rect"/> on the right hand of the operand.</param>
    /// <returns>
    /// True if the current left is equal to the <paramref name="right"/> parameter; otherwise, false.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(Rect left, Rect right) => left.Equals(right);

    /// <summary>
    /// Compares two <see cref="Rect"/> objects for inequality.
    /// </summary>
    /// <param name="left">The <see cref="Rect"/> on the left hand of the operand.</param>
    /// <param name="right">The <see cref="Rect"/> on the right hand of the operand.</param>
    /// <returns>
    /// True if the current left is unequal to the <paramref name="right"/> parameter; otherwise, false.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(Rect left, Rect right) => !left.Equals(right);

    /// <summary>
    /// Performs an implicit conversion from <see cref="Rect"/> to <see cref="Rectangle" />.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator Rectangle(Rect value) => Rectangle.FromLTRB(value.Left, value.Top, value.Right, value.Bottom);

    /// <summary>
    /// Performs an implicit conversion from <see cre ="Rectangle"/> to <see cref="Rect" />.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator Rect(Rectangle value) => new(value.Left, value.Top, value.Right, value.Bottom);
}
