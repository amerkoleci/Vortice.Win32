// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Globalization;
using System.Text;
using static Vortice.Win32.Graphics.D3D12;

namespace Vortice.Win32.Graphics;

public partial struct D3D12_VIEWPORT : IEquatable<D3D12_VIEWPORT>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="D3D12_VIEWPORT"/> struct.
    /// </summary>
    /// <param name="width">The width of the viewport in pixels.</param>
    /// <param name="height">The height of the viewport in pixels.</param>
    public D3D12_VIEWPORT(float width, float height)
    {
        TopLeftX = 0.0f;
        TopLeftY = 0.0f;
        Width = width;
        Height = height;
        MinDepth = 0.0f;
        MaxDepth = 1.0f;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="D3D12_VIEWPORT"/> struct.
    /// </summary>
    /// <param name="x">The x coordinate of the upper-left corner of the viewport in pixels.</param>
    /// <param name="y">The y coordinate of the upper-left corner of the viewport in pixels.</param>
    /// <param name="width">The width of the viewport in pixels.</param>
    /// <param name="height">The height of the viewport in pixels.</param>
    public D3D12_VIEWPORT(float x, float y, float width, float height)
    {
        TopLeftX = x;
        TopLeftY = y;
        Width = width;
        Height = height;
        MinDepth = 0.0f;
        MaxDepth = 1.0f;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="D3D12_VIEWPORT"/> struct.
    /// </summary>
    /// <param name="x">The x coordinate of the upper-left corner of the viewport in pixels.</param>
    /// <param name="y">The y coordinate of the upper-left corner of the viewport in pixels.</param>
    /// <param name="width">The width of the viewport in pixels.</param>
    /// <param name="height">The height of the viewport in pixels.</param>
    /// <param name="minDepth">The minimum depth of the clip volume.</param>
    /// <param name="maxDepth">The maximum depth of the clip volume.</param>
    public D3D12_VIEWPORT(float x, float y, float width, float height, float minDepth, float maxDepth)
    {
        TopLeftX = x;
        TopLeftY = y;
        Width = width;
        Height = height;
        MinDepth = minDepth;
        MaxDepth = maxDepth;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="D3D12_VIEWPORT"/> struct.
    /// </summary>
    /// <param name="bounds">A <see cref="Vector4"/> that defines the location and size of the viewport in a render target.</param>
    public D3D12_VIEWPORT(in Vector4 bounds)
    {
        TopLeftX = bounds.X;
        TopLeftY = bounds.Y;
        Width = bounds.Z;
        Height = bounds.W;
        MinDepth = 0.0f;
        MaxDepth = 1.0f;
    }

    /// <summary>
    /// Gets the aspect ratio used by the viewport.
    /// </summary>
    /// <value>The aspect ratio.</value>
    public readonly float AspectRatio
    {
        get
        {
            if (Width == 0.0f || Height == 0.0f)
                return 0.0f;

            return Width / Height;
        }
    }
    /// <summary>
    /// Compares two <see cref="D3D12_VIEWPORT"/> objects for equality.
    /// </summary>
    /// <param name="left">The <see cref="D3D12_VIEWPORT"/> on the left hand of the operand.</param>
    /// <param name="right">The <see cref="D3D12_VIEWPORT"/> on the right hand of the operand.</param>
    /// <returns>
    /// True if the current left is equal to the <paramref name="right"/> parameter; otherwise, false.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(D3D12_VIEWPORT left, D3D12_VIEWPORT right) => left.Equals(right);

    /// <summary>
    /// Compares two <see cref="D3D12_VIEWPORT"/> objects for inequality.
    /// </summary>
    /// <param name="left">The <see cref="D3D12_VIEWPORT"/> on the left hand of the operand.</param>
    /// <param name="right">The <see cref="D3D12_VIEWPORT"/> on the right hand of the operand.</param>
    /// <returns>
    /// True if the current left is unequal to the <paramref name="right"/> parameter; otherwise, false.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(D3D12_VIEWPORT left, D3D12_VIEWPORT right) => !left.Equals(right);

    /// <inheritdoc />
    public override readonly bool Equals([NotNullWhen(true)] object? obj) => obj is D3D12_VIEWPORT other && Equals(other);

    /// <summary>
    /// Determines whether the specified <see cref="D3D12_VIEWPORT"/> is equal to this instance.
    /// </summary>
    /// <param name="other">The <see cref="D3D12_VIEWPORT"/> to compare with this instance.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly bool Equals(D3D12_VIEWPORT other)
    {
        return
            TopLeftX == other.TopLeftX &&
            TopLeftY == other.TopLeftY &&
            Width == other.Width &&
            Height == other.Height &&
            MinDepth == other.MinDepth &&
            MaxDepth == other.MaxDepth;
    }

    /// <inheritdoc/>
    public override readonly int GetHashCode() => HashCode.Combine(TopLeftX, TopLeftY, Width, Height, MinDepth, MaxDepth);

    /// <inheritdoc />
    public override readonly string ToString() => ToString(format: null, formatProvider: null);

    /// <inheritdoc />
    public readonly string ToString(string? format, IFormatProvider? formatProvider)
    {
        string separator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;

        return new StringBuilder(9 + (separator.Length * 3))
            .Append('<')
            .Append(TopLeftX.ToString(format, formatProvider))
            .Append(separator)
            .Append(' ')
            .Append(TopLeftY.ToString(format, formatProvider))
            .Append(separator)
            .Append(' ')
            .Append(Width.ToString(format, formatProvider))
            .Append(separator)
            .Append(' ')
            .Append(Height.ToString(format, formatProvider))
            .Append(separator)
            .Append(' ')
            .Append(MinDepth.ToString(format, formatProvider))
            .Append(separator)
            .Append(' ')
            .Append(MaxDepth.ToString(format, formatProvider))
            .Append(' ')
            .Append('>')
            .ToString();
    }
}
