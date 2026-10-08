// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.DXGICommon;
using static Vortice.Win32.Graphics.D3D12;

namespace Vortice.Win32.Graphics;

public unsafe partial struct D3D12_RESOURCE_DESC1 : IEquatable<D3D12_RESOURCE_DESC1>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="D3D12_RESOURCE_DESC1"/> struct.
    /// </summary>
    public D3D12_RESOURCE_DESC1(
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
        D3D12_RESOURCE_FLAGS flags,
        uint samplerFeedbackMipRegionWidth = 0,
        uint samplerFeedbackMipRegionHeight = 0,
        uint samplerFeedbackMipRegionDepth = 0)
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
        SamplerFeedbackMipRegion = new(
            samplerFeedbackMipRegionWidth,
            samplerFeedbackMipRegionHeight,
            samplerFeedbackMipRegionDepth);
    }

    public static D3D12_RESOURCE_DESC1 Buffer(in D3D12_RESOURCE_ALLOCATION_INFO resourceAllocInfo, D3D12_RESOURCE_FLAGS flags = D3D12_RESOURCE_FLAG_NONE)
    {
        return new(
            D3D12_RESOURCE_DIMENSION_BUFFER,
            resourceAllocInfo.Alignment,
            resourceAllocInfo.SizeInBytes,
            1, 1, 1, DXGI_FORMAT_UNKNOWN, 1, 0, D3D12_TEXTURE_LAYOUT_ROW_MAJOR,
            flags,
            0, 0, 0);
    }

    public static D3D12_RESOURCE_DESC1 Buffer(
        ulong sizeInBytes,
        D3D12_RESOURCE_FLAGS flags = D3D12_RESOURCE_FLAG_NONE,
        ulong alignment = 0)
    {
        return new(
            D3D12_RESOURCE_DIMENSION_BUFFER,
            alignment,
            sizeInBytes,
            1, 1, 1,
            DXGI_FORMAT_UNKNOWN, 1, 0, D3D12_TEXTURE_LAYOUT_ROW_MAJOR,
            flags,
            0, 0, 0);
    }

    public static D3D12_RESOURCE_DESC1 Tex1D(DXGI_FORMAT format,
        ulong width,
        ushort arraySize = 1,
        ushort mipLevels = 0,
        D3D12_RESOURCE_FLAGS flags = D3D12_RESOURCE_FLAG_NONE,
        D3D12_TEXTURE_LAYOUT layout = D3D12_TEXTURE_LAYOUT_UNKNOWN,
        ulong alignment = 0)
    {
        return new(D3D12_RESOURCE_DIMENSION_TEXTURE1D, alignment, width, 1, arraySize, mipLevels, format, 1, 0, layout, flags, 0, 0, 0);
    }

    public static D3D12_RESOURCE_DESC1 Tex2D(DXGI_FORMAT format,
        ulong width,
        uint height,
        ushort arraySize = 1,
        ushort mipLevels = 0,
        uint sampleCount = 1,
        uint sampleQuality = 0,
        D3D12_RESOURCE_FLAGS flags = D3D12_RESOURCE_FLAG_NONE,
        D3D12_TEXTURE_LAYOUT layout = D3D12_TEXTURE_LAYOUT_UNKNOWN,
        ulong alignment = 0,
        uint samplerFeedbackMipRegionWidth = 0,
        uint samplerFeedbackMipRegionHeight = 0,
        uint samplerFeedbackMipRegionDepth = 0)
    {
        return new(D3D12_RESOURCE_DIMENSION_TEXTURE2D,
            alignment,
            width,
            height,
            arraySize,
            mipLevels,
            format,
            sampleCount,
            sampleQuality,
            layout,
            flags,
            samplerFeedbackMipRegionWidth,
            samplerFeedbackMipRegionHeight,
            samplerFeedbackMipRegionDepth);
    }

    public static D3D12_RESOURCE_DESC1 Texture3D(DXGI_FORMAT format,
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
            flags,
            0, 0, 0);
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

    public static bool operator ==(in D3D12_RESOURCE_DESC1 left, in D3D12_RESOURCE_DESC1 right)
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
            && (left.Flags == right.Flags)
            && (left.SamplerFeedbackMipRegion == right.SamplerFeedbackMipRegion);
    }

    public static bool operator !=(in D3D12_RESOURCE_DESC1 left, in D3D12_RESOURCE_DESC1 right)
    {
        return !(left == right);
    }

    public override bool Equals([NotNullWhen(true)] object? obj) => (obj is D3D12_RESOURCE_DESC1 other) && Equals(other);

    public bool Equals(D3D12_RESOURCE_DESC1 other) => this == other;

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
            hashCode.Add(SamplerFeedbackMipRegion);
        }
        return hashCode.ToHashCode();
    }
}
