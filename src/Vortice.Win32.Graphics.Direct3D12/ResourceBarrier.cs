// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.Direct3D12.Apis;

namespace Vortice.Win32.Graphics.Direct3D12;

public unsafe partial struct ResourceBarrier
{
    public static ResourceBarrier InitTransition(
        ID3D12Resource* pResource,
        D3D12_RESOURCE_STATES stateBefore,
        D3D12_RESOURCE_STATES stateAfter,
        uint subresource = D3D12_RESOURCE_BARRIER_ALL_SUBRESOURCES,
        D3D12_RESOURCE_BARRIER_FLAGS flags = D3D12_RESOURCE_BARRIER_FLAG_NONE)
    {
        ResourceBarrier result = default;
        result.Type = D3D12_RESOURCE_BARRIER_TYPE_TRANSITION;
        result.Flags = flags;
        result.Anonymous.Transition.pResource = pResource;
        result.Anonymous.Transition.StateBefore = stateBefore;
        result.Anonymous.Transition.StateAfter = stateAfter;
        result.Anonymous.Transition.Subresource = subresource;
        return result;
    }

    public static ResourceBarrier InitAliasing(ID3D12Resource* pResourceBefore, ID3D12Resource* pResourceAfter)
    {
        ResourceBarrier result = default;
        result.Type = D3D12_RESOURCE_BARRIER_TYPE_ALIASING;
        result.Anonymous.Aliasing.pResourceBefore = pResourceBefore;
        result.Anonymous.Aliasing.pResourceAfter = pResourceAfter;
        return result;
    }

    public static ResourceBarrier InitUAV(ID3D12Resource* pResource)
    {
        ResourceBarrier result = default;
        result.Type =  D3D12_RESOURCE_BARRIER_TYPE_UAV;
        result.Anonymous.UAV.pResource = pResource;
        return result;
    }
}
