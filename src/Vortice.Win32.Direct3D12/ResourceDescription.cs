// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Dxgi.Common;
using static Win32.Graphics.Direct3D12.Apis;

namespace Win32.Graphics.Direct3D12;

public unsafe partial struct ResourceDescription : IEquatable<ResourceDescription>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ResourceDescription"/> struct.
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
    public ResourceDescription(
        ResourceDimension dimension,
        ulong alignment,
        ulong width,
        uint height,
        ushort depthOrArraySize,
        ushort mipLevels,
        Format format,
        uint sampleCount,
        uint sampleQuality,
        TextureLayout layout,
        ResourceFlags flags)
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

    public static ResourceDescription Buffer(in ResourceAllocationInfo resourceAllocInfo, ResourceFlags flags = ResourceFlags.None)
    {
        return new ResourceDescription(
            ResourceDimension.Buffer,
            resourceAllocInfo.Alignment,
            resourceAllocInfo.SizeInBytes,
            1, 1, 1, Format.Unknown, 1, 0, TextureLayout.RowMajor, flags);
    }

    public static ResourceDescription Buffer(
        ulong sizeInBytes,
        ResourceFlags flags = ResourceFlags.None,
        ulong alignment = 0)
    {
        return new ResourceDescription(ResourceDimension.Buffer, alignment, sizeInBytes, 1, 1, 1, Format.Unknown, 1, 0, TextureLayout.RowMajor, flags);
    }

    public static ResourceDescription Tex1D(Format format,
        ulong width,
        ushort arraySize = 1,
        ushort mipLevels = 0,
        ResourceFlags flags = ResourceFlags.None,
        TextureLayout layout = TextureLayout.Unknown,
        ulong alignment = 0)
    {
        return new ResourceDescription(ResourceDimension.Texture1D, alignment, width, 1, arraySize, mipLevels, format, 1, 0, layout, flags);
    }

    public static ResourceDescription Tex2D(Format format,
        ulong width,
        uint height,
        ushort arraySize = 1,
        ushort mipLevels = 0,
        uint sampleCount = 1,
        uint sampleQuality = 0,
        ResourceFlags flags = ResourceFlags.None,
        TextureLayout layout = TextureLayout.Unknown,
        ulong alignment = 0)
    {
        return new ResourceDescription(ResourceDimension.Texture2D,
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

    public static ResourceDescription Texture3D(Format format,
        ulong width,
        uint height,
        ushort depth,
        ushort mipLevels = 0,
        ResourceFlags flags = ResourceFlags.None,
        TextureLayout layout = TextureLayout.Unknown,
        ulong alignment = 0)
    {
        return new ResourceDescription(
            ResourceDimension.Texture3D,
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

    public ushort Depth => ((Dimension == ResourceDimension.Texture3D) ? DepthOrArraySize : (ushort)(1));

    public ushort ArraySize => ((Dimension != ResourceDimension.Texture3D) ? DepthOrArraySize : (ushort)(1));

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

    public static bool operator ==(in ResourceDescription left, in ResourceDescription right)
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

    public static bool operator !=(in ResourceDescription left, in ResourceDescription right)
    {
        return !(left == right);
    }

    public override bool Equals(object? obj) => (obj is ResourceDescription other) && Equals(other);

    public bool Equals(ResourceDescription other) => this == other;

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
