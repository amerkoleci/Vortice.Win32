// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Win32.Graphics.Direct3D12.Apis;

namespace Win32.Graphics.Direct3D12;

public static unsafe class ID3D12GraphicsCommandListExtensions
{
    public static void ResourceBarrierTransition<TD3D12GraphicsCommandList>(
        ref this TD3D12GraphicsCommandList self,
        ID3D12Resource* resource,
        ResourceStates stateBefore,
        ResourceStates stateAfter,
        uint subresource = D3D12_RESOURCE_BARRIER_ALL_SUBRESOURCES,
        ResourceBarrierFlags flags = ResourceBarrierFlags.None)
        where TD3D12GraphicsCommandList : unmanaged, ID3D12GraphicsCommandList.Interface
    {
        ResourceBarrier barrier = Direct3D12.ResourceBarrier.InitTransition(resource, stateBefore, stateAfter, subresource, flags);
        self.ResourceBarrier(1u, &barrier);
    }

    public static void ResourceBarrierAliasing<TD3D12GraphicsCommandList>(
        ref this TD3D12GraphicsCommandList self,
        ID3D12Resource* resourceBefore,
        ID3D12Resource* resourceAfter)
        where TD3D12GraphicsCommandList : unmanaged, ID3D12GraphicsCommandList.Interface
    {
        ResourceBarrier barrier = Direct3D12.ResourceBarrier.InitAliasing(resourceBefore, resourceAfter);
        self.ResourceBarrier(1u, &barrier);
    }

    public static void ResourceBarrierUAV<TD3D12GraphicsCommandList>(
        ref this TD3D12GraphicsCommandList self, ID3D12Resource* resource)
        where TD3D12GraphicsCommandList : unmanaged, ID3D12GraphicsCommandList.Interface
    {
        ResourceBarrier barrier = Direct3D12.ResourceBarrier.InitUAV(resource);
        self.ResourceBarrier(1u, &barrier);
    }

    public static void ResourceBarrier<TD3D12GraphicsCommandList>(ref this TD3D12GraphicsCommandList self, ResourceBarrier barrier)
        where TD3D12GraphicsCommandList : unmanaged, ID3D12GraphicsCommandList.Interface
    {
        self.ResourceBarrier(1u, &barrier);
    }

    public static void ResourceBarrier<TD3D12GraphicsCommandList>(
        ref this TD3D12GraphicsCommandList self, ResourceBarrier[] barriers)
        where TD3D12GraphicsCommandList : unmanaged, ID3D12GraphicsCommandList.Interface
    {
        fixed (ResourceBarrier* pBarriers = barriers)
        {
            self.ResourceBarrier((uint)barriers.Length, pBarriers);
        }
    }

    public static void ResourceBarrier<TD3D12GraphicsCommandList>(
        ref this TD3D12GraphicsCommandList self, int numBarriers, ResourceBarrier[] barriers)
        where TD3D12GraphicsCommandList : unmanaged, ID3D12GraphicsCommandList.Interface
    {
        fixed (ResourceBarrier* pBarriers = barriers)
        {
            self.ResourceBarrier((uint)numBarriers, pBarriers);
        }
    }

    public static void ResourceBarrier<TD3D12GraphicsCommandList>(
        ref this TD3D12GraphicsCommandList self, ReadOnlySpan<ResourceBarrier> barriers)
        where TD3D12GraphicsCommandList : unmanaged, ID3D12GraphicsCommandList.Interface
    {
        fixed (ResourceBarrier* pBarriers = barriers)
        {
            self.ResourceBarrier((uint)barriers.Length, pBarriers);
        }
    }

    public static void ResourceBarrier<TD3D12GraphicsCommandList>(
        ref this TD3D12GraphicsCommandList self, int numBarriers, ReadOnlySpan<ResourceBarrier> barriers)
        where TD3D12GraphicsCommandList : unmanaged, ID3D12GraphicsCommandList.Interface
    {
        fixed (ResourceBarrier* pBarriers = barriers)
        {
            self.ResourceBarrier((uint)numBarriers, pBarriers);
        }
    }
}
