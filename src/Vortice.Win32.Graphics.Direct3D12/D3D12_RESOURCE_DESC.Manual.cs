// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.DXGICommon;
using static Vortice.Win32.Graphics.D3D12;

namespace Vortice.Win32.Graphics;

public unsafe partial struct D3D12_RESOURCE_DESC : IEquatable<D3D12_RESOURCE_DESC>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="D3D12_RESOURCE_DESC"/> struct.
    /// </summary>
    /// <param name="dimension"></param>
    /// <param name="alignment"></param>
    /// <param name="width"></param>
    /// <param name="height"></param>
    /// <param name="depthOrArraySize"></param>
    /// <param name="mipLevels"></param>
    /// <param name="format"></param>
    /// <param name="sampleCount"></param>
    /// <param name="sampleQuality"></param>
    /// <param name="layout"></param>
    /// <param name="flags"></param>
    public D3D12_RESOURCE_DESC(
        D3D12_RESOURCE_DIMENSION dimension,
        ulong alignment,
        ulong width,
        uint height,
        ushort depthOrArraySize,
        ushort mipLevels,
        DXGI_FORMAT format,
        uint sampleCount,
        uint sampleQuality,
        D3D12_TEXTURE_LAYOUT layout,
        D3D12_RESOURCE_FLAGS flags = D3D12_RESOURCE_FLAG_NONE)
    {
        Dimension = dimension;
        Alignment = alignment;
        Width = width;
        Height = height;
        DepthOrArraySize = depthOrArraySize;
        MipLevels = mipLevels;
        Format = format;
        SampleDesc = new(sampleCount, sampleQuality);
        Layout = layout;
        Flags = flags;
    }

    public static D3D12_RESOURCE_DESC Buffer(in D3D12_RESOURCE_ALLOCATION_INFO resourceAllocInfo, D3D12_RESOURCE_FLAGS flags = D3D12_RESOURCE_FLAG_NONE)
    {
        return new(
            D3D12_RESOURCE_DIMENSION_BUFFER,
            resourceAllocInfo.Alignment,
            resourceAllocInfo.SizeInBytes,
            1, 1, 1, DXGI_FORMAT_UNKNOWN, 1, 0, D3D12_TEXTURE_LAYOUT_ROW_MAJOR, flags
            );
    }

    public static D3D12_RESOURCE_DESC Buffer(
        ulong sizeInBytes,
        D3D12_RESOURCE_FLAGS flags = D3D12_RESOURCE_FLAG_NONE,
        ulong alignment = 0)
    {
        return new(D3D12_RESOURCE_DIMENSION_BUFFER, alignment, sizeInBytes, 1, 1, 1, DXGI_FORMAT_UNKNOWN, 1, 0, D3D12_TEXTURE_LAYOUT_ROW_MAJOR, flags);
    }

    public static D3D12_RESOURCE_DESC Tex1D(DXGI_FORMAT format,
        ulong width,
        ushort arraySize = 1,
        ushort mipLevels = 0,
        D3D12_RESOURCE_FLAGS flags = D3D12_RESOURCE_FLAG_NONE,
        D3D12_TEXTURE_LAYOUT layout = D3D12_TEXTURE_LAYOUT_UNKNOWN,
        ulong alignment = 0)
    {
        return new(D3D12_RESOURCE_DIMENSION_TEXTURE1D, alignment, width, 1, arraySize, mipLevels, format, 1, 0, layout, flags);
    }

    public static D3D12_RESOURCE_DESC Tex2D(DXGI_FORMAT format,
        ulong width,
        uint height,
        ushort arraySize = 1,
        ushort mipLevels = 0,
        uint sampleCount = 1,
        uint sampleQuality = 0,
        D3D12_RESOURCE_FLAGS flags = D3D12_RESOURCE_FLAG_NONE,
        D3D12_TEXTURE_LAYOUT layout = D3D12_TEXTURE_LAYOUT_UNKNOWN,
        ulong alignment = 0)
    {
        return new D3D12_RESOURCE_DESC(D3D12_RESOURCE_DIMENSION_TEXTURE2D,
            alignment,
            width,
            height,
            arraySize,
            mipLevels,
            format,
            sampleCount,
            sampleQuality,
            layout,
            flags);
    }

    public static D3D12_RESOURCE_DESC Tex3D(DXGI_FORMAT format,
        ulong width,
        uint height,
        ushort depth,
        ushort mipLevels = 0,
        D3D12_RESOURCE_FLAGS flags = D3D12_RESOURCE_FLAG_NONE,
        D3D12_TEXTURE_LAYOUT layout = D3D12_TEXTURE_LAYOUT_UNKNOWN,
        ulong alignment = 0)
    {
        return new(
            D3D12_RESOURCE_DIMENSION_TEXTURE3D,
            alignment,
            width,
            height,
            depth,
            mipLevels,
            format,
            1,
            0,
            layout,
            flags);
    }

    public ushort Depth => ((Dimension == D3D12_RESOURCE_DIMENSION_TEXTURE3D) ? DepthOrArraySize : (ushort)(1));

    public ushort ArraySize => ((Dimension != D3D12_RESOURCE_DIMENSION_TEXTURE3D) ? DepthOrArraySize : (ushort)(1));

    public byte GetPlaneCount(ID3D12Device* pDevice)
    {
        return D3D12GetFormatPlaneCount(pDevice, Format);
    }

    public uint GetSubresources(ID3D12Device* pDevice)
    {
        return MipLevels * (uint)ArraySize * GetPlaneCount(pDevice);
    }

    public uint CalcSubresource(uint MipSlice, uint ArraySlice, uint PlaneSlice)
    {
        return D3D12CalcSubresource(MipSlice, ArraySlice, PlaneSlice, MipLevels, ArraySize);
    }

    public static bool operator ==(in D3D12_RESOURCE_DESC left, in D3D12_RESOURCE_DESC right)
    {
        return (left.Dimension == right.Dimension)
            && (left.Alignment == right.Alignment)
            && (left.Width == right.Width)
            && (left.Height == right.Height)
            && (left.DepthOrArraySize == right.DepthOrArraySize)
            && (left.MipLevels == right.MipLevels)
            && (left.Format == right.Format)
            && (left.SampleDesc.Count == right.SampleDesc.Count)
            && (left.SampleDesc.Quality == right.SampleDesc.Quality)
            && (left.Layout == right.Layout)
            && (left.Flags == right.Flags);
    }

    public static bool operator !=(in D3D12_RESOURCE_DESC left, in D3D12_RESOURCE_DESC right)
    {
        return !(left == right);
    }

    public override bool Equals([NotNullWhen(true)] object? obj) => (obj is D3D12_RESOURCE_DESC other) && Equals(other);

    public bool Equals(D3D12_RESOURCE_DESC other) => this == other;

    public override int GetHashCode()
    {
        var hashCode = new HashCode();
        {
            hashCode.Add(Dimension);
            hashCode.Add(Alignment);
            hashCode.Add(Width);
            hashCode.Add(Height);
            hashCode.Add(DepthOrArraySize);
            hashCode.Add(MipLevels);
            hashCode.Add(Format);
            hashCode.Add(SampleDesc);
            hashCode.Add(Layout);
            hashCode.Add(Flags);
        }
        return hashCode.ToHashCode();
    }
}
