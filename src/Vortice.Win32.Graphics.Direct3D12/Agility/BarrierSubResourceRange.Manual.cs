// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D12;

unsafe partial struct BarrierSubResourceRange
{
    public BarrierSubResourceRange(uint subresource)
    {
        IndexOrFirstMipLevel = subresource;
        NumMipLevels = 0;
        FirstArraySlice = 0;
        NumArraySlices = 0;
        FirstPlane = 0;
        NumPlanes = 0;
    }

    public BarrierSubResourceRange(
        uint firstMipLevel,
        uint numMips,
        uint firstArraySlice,
        uint numArraySlices,
        uint firstPlane = 0,
        uint numPlanes = 1)
    {
        IndexOrFirstMipLevel = firstMipLevel;
        NumMipLevels = numMips;
        FirstArraySlice = firstArraySlice;
        NumArraySlices = numArraySlices;
        FirstPlane = firstPlane;
        NumPlanes = numPlanes;
    }
}
