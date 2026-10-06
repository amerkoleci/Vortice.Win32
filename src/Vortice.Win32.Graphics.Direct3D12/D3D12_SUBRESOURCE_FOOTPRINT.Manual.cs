// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Vortice.Win32.Graphics.Dxgi.Common;
using static Vortice.Win32.Graphics.D3D12;

namespace Vortice.Win32.Graphics;

public unsafe partial struct D3D12_SUBRESOURCE_FOOTPRINT
{
    public D3D12_SUBRESOURCE_FOOTPRINT(Format format, uint width, uint height, uint depth, uint rowPitch)
    {
        Format = format;
        Width = width;
        Height = height;
        Depth = depth;
        RowPitch = rowPitch;
    }

    public D3D12_SUBRESOURCE_FOOTPRINT(in D3D12_RESOURCE_DESC resourceDesc, uint rowPitch)
    {
        Format = resourceDesc.Format;
        Width = (uint)resourceDesc.Width;
        Height = resourceDesc.Height;
        Depth = (resourceDesc.Dimension == D3D12_RESOURCE_DIMENSION_TEXTURE3D ? resourceDesc.DepthOrArraySize : 1u);
        RowPitch = rowPitch;
    }
}
