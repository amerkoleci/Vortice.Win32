// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D3D12;

namespace Vortice.Win32.Graphics;

public static unsafe class ID3D12GraphicsCommandListExtensions
{
    public static void ResourceBarrierTransition<TD3D12GraphicsCommandList>(
        ref this TD3D12GraphicsCommandList self,
        ID3D12Resource* resource,
        D3D12_RESOURCE_STATES stateBefore,
        D3D12_RESOURCE_STATES stateAfter,
        uint subresource = D3D12_RESOURCE_BARRIER_ALL_SUBRESOURCES,
        D3D12_RESOURCE_BARRIER_FLAGS flags = D3D12_RESOURCE_BARRIER_FLAG_NONE)
        where TD3D12GraphicsCommandList : unmanaged, ID3D12GraphicsCommandList.Interface
    {
        D3D12_RESOURCE_BARRIER barrier = D3D12_RESOURCE_BARRIER.InitTransition(resource, stateBefore, stateAfter, subresource, flags);
        self.ResourceBarrier(1u, &barrier);
    }

    public static void ResourceBarrierAliasing<TD3D12GraphicsCommandList>(
        ref this TD3D12GraphicsCommandList self,
        ID3D12Resource* resourceBefore,
        ID3D12Resource* resourceAfter)
        where TD3D12GraphicsCommandList : unmanaged, ID3D12GraphicsCommandList.Interface
    {
        D3D12_RESOURCE_BARRIER barrier = D3D12_RESOURCE_BARRIER.InitAliasing(resourceBefore, resourceAfter);
        self.ResourceBarrier(1u, &barrier);
    }

    public static void ResourceBarrierUAV<TD3D12GraphicsCommandList>(
        ref this TD3D12GraphicsCommandList self, ID3D12Resource* resource)
        where TD3D12GraphicsCommandList : unmanaged, ID3D12GraphicsCommandList.Interface
    {
        D3D12_RESOURCE_BARRIER barrier = D3D12_RESOURCE_BARRIER.InitUAV(resource);
        self.ResourceBarrier(1u, &barrier);
    }

    public static void ResourceBarrier<TD3D12GraphicsCommandList>(ref this TD3D12GraphicsCommandList self, D3D12_RESOURCE_BARRIER barrier)
        where TD3D12GraphicsCommandList : unmanaged, ID3D12GraphicsCommandList.Interface
    {
        self.ResourceBarrier(1u, &barrier);
    }

    public static void ResourceBarrier<TD3D12GraphicsCommandList>(
        ref this TD3D12GraphicsCommandList self, Span<D3D12_RESOURCE_BARRIER> barriers)
        where TD3D12GraphicsCommandList : unmanaged, ID3D12GraphicsCommandList.Interface
    {
        fixed (D3D12_RESOURCE_BARRIER* pBarriers = barriers)
        {
            self.ResourceBarrier((uint)barriers.Length, pBarriers);
        }
    }

    public static void ResourceBarrier<TD3D12GraphicsCommandList>(
        ref this TD3D12GraphicsCommandList self, int numBarriers, Span<D3D12_RESOURCE_BARRIER> barriers)
        where TD3D12GraphicsCommandList : unmanaged, ID3D12GraphicsCommandList.Interface
    {
        fixed (D3D12_RESOURCE_BARRIER* pBarriers = barriers)
        {
            self.ResourceBarrier((uint)numBarriers, pBarriers);
        }
    }

    public static void ResourceBarrier<TD3D12GraphicsCommandList>(
        ref this TD3D12GraphicsCommandList self, ReadOnlySpan<D3D12_RESOURCE_BARRIER> barriers)
        where TD3D12GraphicsCommandList : unmanaged, ID3D12GraphicsCommandList.Interface
    {
        fixed (D3D12_RESOURCE_BARRIER* pBarriers = barriers)
        {
            self.ResourceBarrier((uint)barriers.Length, pBarriers);
        }
    }

    public static void ResourceBarrier<TD3D12GraphicsCommandList>(
        ref this TD3D12GraphicsCommandList self, int numBarriers, ReadOnlySpan<D3D12_RESOURCE_BARRIER> barriers)
        where TD3D12GraphicsCommandList : unmanaged, ID3D12GraphicsCommandList.Interface
    {
        fixed (D3D12_RESOURCE_BARRIER* pBarriers = barriers)
        {
            self.ResourceBarrier((uint)numBarriers, pBarriers);
        }
    }
}
