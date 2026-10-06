// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D3D12;

namespace Vortice.Win32.Graphics;

public unsafe partial struct D3D12_TEXTURE_COPY_LOCATION
{
    public D3D12_TEXTURE_COPY_LOCATION(ID3D12Resource* resource)
    {
        Unsafe.SkipInit(out this);

        pResource = resource;
        Type = D3D12_TEXTURE_COPY_TYPE_SUBRESOURCE_INDEX;
        Anonymous.PlacedFootprint = new();
    }

    public D3D12_TEXTURE_COPY_LOCATION(ID3D12Resource* resource, in D3D12_PLACED_SUBRESOURCE_FOOTPRINT footprint)
    {
        Unsafe.SkipInit(out this);

        pResource = resource;
        Type = D3D12_TEXTURE_COPY_TYPE_PLACED_FOOTPRINT;
        Anonymous.PlacedFootprint = footprint;
    }

    public D3D12_TEXTURE_COPY_LOCATION(ID3D12Resource* resource, uint subresourceIndex)
    {
        Unsafe.SkipInit(out this);

        pResource = resource;
        Type = D3D12_TEXTURE_COPY_TYPE_SUBRESOURCE_INDEX;
        Anonymous.PlacedFootprint = new D3D12_PLACED_SUBRESOURCE_FOOTPRINT();
        Anonymous.SubresourceIndex = subresourceIndex;
    }
}
