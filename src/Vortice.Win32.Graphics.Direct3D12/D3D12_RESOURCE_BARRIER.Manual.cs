// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D3D12;

namespace Vortice.Win32.Graphics;

public unsafe partial struct D3D12_RESOURCE_BARRIER
{
    [return: NativeTypeName("CD3DX12_RESOURCE_BARRIER")]
    public static D3D12_RESOURCE_BARRIER InitTransition(ID3D12Resource* pResource, D3D12_RESOURCE_STATES stateBefore, D3D12_RESOURCE_STATES stateAfter, uint subresource = (0xffffffff), D3D12_RESOURCE_BARRIER_FLAGS flags = D3D12_RESOURCE_BARRIER_FLAG_NONE)
    {
        Unsafe.SkipInit(out D3D12_RESOURCE_BARRIER result);

        result.Type = D3D12_RESOURCE_BARRIER_TYPE_TRANSITION;
        result.Flags = flags;
        result.Anonymous.Transition.pResource = pResource;
        result.Anonymous.Transition.StateBefore = stateBefore;
        result.Anonymous.Transition.StateAfter = stateAfter;
        result.Anonymous.Transition.Subresource = subresource;

        return result;
    }

    [return: NativeTypeName("CD3DX12_RESOURCE_BARRIER")]
    public static D3D12_RESOURCE_BARRIER InitAliasing(ID3D12Resource* pResourceBefore, ID3D12Resource* pResourceAfter)
    {
        Unsafe.SkipInit(out D3D12_RESOURCE_BARRIER result);

        result.Type = D3D12_RESOURCE_BARRIER_TYPE_ALIASING;
        result.Flags = D3D12_RESOURCE_BARRIER_FLAG_NONE;
        result.Aliasing.pResourceBefore = pResourceBefore;
        result.Aliasing.pResourceAfter = pResourceAfter;

        return result;
    }

    [return: NativeTypeName("CD3DX12_RESOURCE_BARRIER")]
    public static D3D12_RESOURCE_BARRIER InitUAV(ID3D12Resource* pResource)
    {
        Unsafe.SkipInit(out D3D12_RESOURCE_BARRIER result);

        result.Type = D3D12_RESOURCE_BARRIER_TYPE_UAV;
        result.Flags = D3D12_RESOURCE_BARRIER_FLAG_NONE;
        result.Anonymous.UAV.pResource = pResource;

        return result;
    }
}
