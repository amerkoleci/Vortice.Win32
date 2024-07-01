// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Dxgi.Common;

namespace Win32.Graphics.Direct3D12;

public unsafe partial struct ClearValue : IEquatable<ClearValue>
{
    public ClearValue(Format format, float* color)
    {
        Unsafe.SkipInit(out this);

        Format = format;
        Anonymous.Color[0] = color[0];
        Anonymous.Color[1] = color[1];
        Anonymous.Color[2] = color[2];
        Anonymous.Color[3] = color[3];
    }

    public ClearValue(Format format, float depth, byte stencil)
    {
        Format = format;
        Anonymous.DepthStencil.Depth = depth;
        Anonymous.DepthStencil.Stencil = stencil;
    }

    public static bool operator ==(in ClearValue left, in ClearValue right)
    {
        if (left.Format != right.Format)
        {
            return false;
        }

        if (left.Format == Format.D24UnormS8Uint ||
            left.Format == Format.D16Unorm ||
            left.Format == Format.D32Float ||
            left.Format == Format.D32FloatS8X24Uint)
        {
            return (left.Anonymous.DepthStencil.Depth == right.Anonymous.DepthStencil.Depth) && (left.Anonymous.DepthStencil.Stencil == right.Anonymous.DepthStencil.Stencil);
        }
        else
        {
            return (left.Anonymous.Color[0] == right.Anonymous.Color[0]) && (left.Anonymous.Color[1] == right.Anonymous.Color[1]) && (left.Anonymous.Color[2] == right.Anonymous.Color[2]) && (left.Anonymous.Color[3] == right.Anonymous.Color[3]);
        }
    }

    public static bool operator !=(in ClearValue left, in ClearValue right)
        => !(left == right);

    public override bool Equals(object? obj) => (obj is ClearValue other) && Equals(other);

    public bool Equals(ClearValue other) => this == other;

    public override int GetHashCode()
    {
        var hashCode = new HashCode();
        {
            hashCode.Add(Format);

            if (Format == Format.D24UnormS8Uint ||
                Format == Format.D16Unorm ||
                Format == Format.D32Float ||
                Format == Format.D32FloatS8X24Uint)
            {
                hashCode.Add(Anonymous.DepthStencil);
            }
            else
            {
                hashCode.Add(Anonymous.Color[0]);
                hashCode.Add(Anonymous.Color[1]);
                hashCode.Add(Anonymous.Color[2]);
                hashCode.Add(Anonymous.Color[3]);
            }
        }
        return hashCode.ToHashCode();
    }
}
