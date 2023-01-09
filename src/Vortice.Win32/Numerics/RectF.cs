// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Drawing;

namespace Win32.Numerics;

/// <summary>
/// Defines a floating-point rectangle (Left, Top, Right, Bottom)
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 4)]
[DebuggerDisplay("Left: {Left}, Top: {Top}, Right: {Right}, Bottom: {Bottom}")]
public struct RectF : IEquatable<RectF>
{
    public static RectF Empty => new ();

    public RectF(float left, float top, float right, float bottom)
    {
        Left = left;
        Top = top;
        Right = right;
        Bottom = bottom;
    }

    /// <summary>
    /// The left position.
    /// </summary>
    public float Left;

    /// <summary>
    /// The top position.
    /// </summary>
    public float Top;

    /// <summary>
    /// The right position
    /// </summary>
    public float Right;

    /// <summary>
    /// The bottom position.
    /// </summary>
    public float Bottom;

    public readonly float Width => Right - Left;

    public readonly float Height => Bottom - Top;

    public PointF Location
    {
        readonly get => new PointF(Left, Top);
        set => this = RectF.Create(value, Size);
    }

    public SizeF Size
    {
        readonly get => new(Width, Height);
        set
        {
            Right = Left + value.Width;
            Bottom = Top + value.Height;
        }
    }

    public readonly float CenterX => Left + (Width / 2f);

    public readonly float CenterY => Top + (Height / 2f);

    public void Offset(float x, float y)
    {
        Left += x;
        Top += y;
        Right += x;
        Bottom += y;
    }

    public void Offset(PointF pos) => Offset(pos.X, pos.Y);

    public static RectF Create(PointF location, SizeF size) => Create(location.X, location.Y, size.Width, size.Height);

    public static RectF Create(SizeF size) => Create(PointF.Empty, size);

    public static RectF Create(float width, float height) => new(0.0f, 0.0f, width, height);

    public static RectF Create(float x, float y, float width, float height) => new(x, y, x + width, y + height);

    public static RectF Inflate(RectF rect, float x, float y)
    {
        var r = new RectF(rect.Left, rect.Top, rect.Right, rect.Bottom);
        r.Inflate(x, y);
        return r;
    }

    public void Inflate(SizeF size) => Inflate(size.Width, size.Height);

    public void Inflate(float x, float y)
    {
        Left -= x;
        Top -= y;
        Right += x;
        Bottom += y;
    }

    public readonly bool Contains(float x, float y)
    {
        return (x >= Left) && (x < Right) && (y >= Top) && (y < Bottom);
    }

    public readonly bool Contains(Point pt) => Contains(pt.X, pt.Y);
    public readonly bool Contains(PointF pt) => Contains(pt.X, pt.Y);

    public readonly bool Contains(RectF rect) =>
        (Left <= rect.Left) && (Right >= rect.Right) &&
        (Top <= rect.Top) && (Bottom >= rect.Bottom);

    public readonly bool IntersectsWith(RectF rect)
    {
        return (Left < rect.Right) && (Right > rect.Left) && (Top < rect.Bottom) && (Bottom > rect.Top);
    }

    public readonly bool IntersectsWithInclusive(RectF rect)
    {
        return (Left <= rect.Right) && (Right >= rect.Left) && (Top <= rect.Bottom) && (Bottom >= rect.Top);
    }

    public static RectF Intersect(RectF left, RectF right)
    {
        if (!left.IntersectsWithInclusive(right))
        {
            return Empty;
        }

        return new RectF(
            Math.Max(left.Left, right.Left),
            Math.Max(left.Top, right.Top),
            Math.Min(left.Right, right.Right),
            Math.Min(left.Bottom, right.Bottom)
            );
    }

    public void Intersect(RectF rect)
    {
        this = Intersect(this, rect);
    }

    public static RectF Union(RectF left, RectF right)
    {
        return new(
            Math.Min(left.Left, right.Left),
            Math.Min(left.Top, right.Top),
            Math.Max(left.Right, right.Right),
            Math.Max(left.Bottom, right.Bottom)
            );
    }

    public void Union(RectF rect)
    {
        this = Union(this, rect);
    }

    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is RectF value && Equals(value);

    /// <summary>
    /// Determines whether the specified <see cref="RectF"/> is equal to this instance.
    /// </summary>
    /// <param name="other">The <see cref="RectF"/> to compare with this instance.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Equals(RectF other)
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
    /// Compares two <see cref="RectF"/> objects for equality.
    /// </summary>
    /// <param name="left">The <see cref="RectF"/> on the left hand of the operand.</param>
    /// <param name="right">The <see cref="RectF"/> on the right hand of the operand.</param>
    /// <returns>
    /// True if the current left is equal to the <paramref name="right"/> parameter; otherwise, false.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(RectF left, RectF right) => left.Equals(right);

    /// <summary>
    /// Compares two <see cref="RectF"/> objects for inequality.
    /// </summary>
    /// <param name="left">The <see cref="RectF"/> on the left hand of the operand.</param>
    /// <param name="right">The <see cref="RectF"/> on the right hand of the operand.</param>
    /// <returns>
    /// True if the current left is unequal to the <paramref name="right"/> parameter; otherwise, false.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(RectF left, RectF right) => !left.Equals(right);

    /// <summary>
    /// Performs an implicit conversion from <see cref="RectF"/> to <see cref="RectangleF" />.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator RectangleF(RectF value) => RectangleF.FromLTRB(value.Left, value.Top, value.Right, value.Bottom);

    /// <summary>
    /// Performs an implicit conversion from <see cre ="RectangleF"/> to <see cref="RectF" />.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator RectF(RectangleF value) => new(value.Left, value.Top, value.Right, value.Bottom);

    public static implicit operator RectF(Rect r) => new(r.Left, r.Top, r.Right, r.Bottom);
}
