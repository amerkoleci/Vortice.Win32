// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Diagnostics;
using System.Drawing;

namespace Win32;

/// <summary>
/// Defines an integer rectangle (Left, Top, Right, Bottom)
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 4)]
[DebuggerDisplay("Left: {Left}, Top: {Top}, Right: {Right}, Bottom: {Bottom}")]
public readonly struct RawRect
{
    public RawRect(int left, int top, int right, int bottom)
    {
        Left = left;
        Top = top;
        Right = right;
        Bottom = bottom;
    }

    /// <summary>
    /// The left position.
    /// </summary>
    public readonly int Left;

    /// <summary>
    /// The top position.
    /// </summary>
    public readonly int Top;

    /// <summary>
    /// The right position
    /// </summary>
    public readonly int Right;

    /// <summary>
    /// The bottom position.
    /// </summary>
    public readonly int Bottom;

    /// <inheritdoc/>
    public override string ToString()
    {
        return $"{nameof(Left)}: {Left}, {nameof(Top)}: {Top}, {nameof(Right)}: {Right}, {nameof(Bottom)}: {Bottom}";
    }

    /// <summary>
    /// Performs an implicit conversion from <see cre ="RawRect"/> to <see cref="Rectangle" />.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator Rectangle(RawRect value) => Rectangle.FromLTRB(value.Left, value.Top, value.Right, value.Bottom);

    /// <summary>
    /// Performs an implicit conversion from <see cre ="Rectangle"/> to <see cref="RawRect" />.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator RawRect(Rectangle value) => new(value.Left, value.Top, value.Right, value.Bottom);
}
