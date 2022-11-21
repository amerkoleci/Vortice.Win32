// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Win32.Graphics.Direct3D12.Apis;

namespace Win32.Graphics.Direct3D12;

public unsafe partial struct ResourceBarrier
{
    public static ResourceBarrier InitTransition(
        ID3D12Resource* pResource,
        ResourceStates stateBefore,
        ResourceStates stateAfter,
        uint subresource = D3D12_RESOURCE_BARRIER_ALL_SUBRESOURCES,
        ResourceBarrierFlags flags = ResourceBarrierFlags.None)
    {
        ResourceBarrier result = default;
        result.Type = ResourceBarrierType.Transition;
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
        result.Type = ResourceBarrierType.Aliasing;
        result.Anonymous.Aliasing.pResourceBefore = pResourceBefore;
        result.Anonymous.Aliasing.pResourceAfter = pResourceAfter;
        return result;
    }

    public static ResourceBarrier InitUAV(ID3D12Resource* pResource)
    {
        ResourceBarrier result = default;
        result.Type = ResourceBarrierType.Uav;
        result.Anonymous.UAV.pResource = pResource;
        return result;
    }
}
