// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.DXGICommon;

namespace Vortice.Win32.Graphics;

public unsafe partial struct D3D12_CLEAR_VALUE : IEquatable<D3D12_CLEAR_VALUE>
{
    public D3D12_CLEAR_VALUE(DXGI_FORMAT format, float* color)
    {
        Unsafe.SkipInit(out this);

        Format = format;
        Anonymous.Color[0] = color[0];
        Anonymous.Color[1] = color[1];
        Anonymous.Color[2] = color[2];
        Anonymous.Color[3] = color[3];
    }

    public D3D12_CLEAR_VALUE(DXGI_FORMAT format, float depth, byte stencil)
    {
        Format = format;
        Anonymous.DepthStencil.Depth = depth;
        Anonymous.DepthStencil.Stencil = stencil;
    }

    public static bool operator ==(in D3D12_CLEAR_VALUE left, in D3D12_CLEAR_VALUE right)
    {
        if (left.Format != right.Format)
        {
            return false;
        }

        if (left.Format == DXGI_FORMAT_D24_UNORM_S8_UINT ||
            left.Format == DXGI_FORMAT_D16_UNORM ||
            left.Format == DXGI_FORMAT_D32_FLOAT ||
            left.Format == DXGI_FORMAT_D32_FLOAT_S8X24_UINT)
        {
            return (left.Anonymous.DepthStencil.Depth == right.Anonymous.DepthStencil.Depth) && (left.Anonymous.DepthStencil.Stencil == right.Anonymous.DepthStencil.Stencil);
        }
        else
        {
            return (left.Anonymous.Color[0] == right.Anonymous.Color[0]) && (left.Anonymous.Color[1] == right.Anonymous.Color[1]) && (left.Anonymous.Color[2] == right.Anonymous.Color[2]) && (left.Anonymous.Color[3] == right.Anonymous.Color[3]);
        }
    }

    public static bool operator !=(in D3D12_CLEAR_VALUE left, in D3D12_CLEAR_VALUE right)
        => !(left == right);

    public override bool Equals([NotNullWhen(true)] object? obj) => (obj is D3D12_CLEAR_VALUE other) && Equals(other);

    public bool Equals(D3D12_CLEAR_VALUE other) => this == other;

    public override int GetHashCode()
    {
        var hashCode = new HashCode();
        {
            hashCode.Add(Format);

            if (Format == DXGI_FORMAT.DXGI_FORMAT_D24_UNORM_S8_UINT ||
                Format == DXGI_FORMAT.DXGI_FORMAT_D16_UNORM ||
                Format == DXGI_FORMAT.DXGI_FORMAT_D32_FLOAT ||
                Format == DXGI_FORMAT.DXGI_FORMAT_D32_FLOAT_S8X24_UINT)
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
