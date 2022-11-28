// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D12;

/// <unmanaged>D3D12_BARRIER_SUBRESOURCE_RANGE</unmanaged>
public partial struct BarrierSubResourceRange
{
    public uint IndexOrFirstMipLevel;
    public uint NumMipLevels;
    public uint FirstArraySlice;
    public uint NumArraySlices;
    public uint FirstPlane;
    public uint NumPlanes;
}
