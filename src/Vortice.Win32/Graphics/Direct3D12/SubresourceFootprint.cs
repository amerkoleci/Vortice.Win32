// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Dxgi.Common;

namespace Win32.Graphics.Direct3D12;

public unsafe partial struct SubresourceFootprint
{
    public SubresourceFootprint(Format format, uint width, uint height, uint depth, uint rowPitch)
    {
        Format = format;
        Width = width;
        Height = height;
        Depth = depth;
        RowPitch = rowPitch;
    }

    public SubresourceFootprint(in ResourceDescription resourceDesc, uint rowPitch)
    {
        Format = resourceDesc.Format;
        Width = (uint)resourceDesc.Width;
        Height = resourceDesc.Height;
        Depth = (resourceDesc.Dimension == ResourceDimension.Texture3D ? resourceDesc.DepthOrArraySize : 1u);
        RowPitch = rowPitch;
    }
}
