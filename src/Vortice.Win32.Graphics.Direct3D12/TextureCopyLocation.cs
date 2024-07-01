// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D12;

public unsafe partial struct TextureCopyLocation
{
    public TextureCopyLocation(ID3D12Resource* resource)
    {
        Unsafe.SkipInit(out this);

        pResource = resource;
        Type = TextureCopyType.SubresourceIndex;
        Anonymous.PlacedFootprint = new PlacedSubresourceFootprint();
    }

    public TextureCopyLocation(ID3D12Resource* resource, in PlacedSubresourceFootprint footprint)
    {
        Unsafe.SkipInit(out this);

        pResource = resource;
        Type = TextureCopyType.PlacedFootprint;
        Anonymous.PlacedFootprint = footprint;
    }

    public TextureCopyLocation(ID3D12Resource* resource, uint subresourceIndex)
    {
        Unsafe.SkipInit(out this);

        pResource = resource;
        Type = TextureCopyType.SubresourceIndex;
        Anonymous.PlacedFootprint = new PlacedSubresourceFootprint();
        Anonymous.SubresourceIndex = subresourceIndex;
    }
}
