// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Win32.Apis;
using static Win32.Graphics.Direct3D11.Apis;

namespace Win32.Graphics.Direct3D11;

public static unsafe class ID3D11DeviceContextExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void RSSetViewport<TD3D11DeviceContext>(
        ref this TD3D11DeviceContext self,
        float x, float y, float width, float height, float minDepth = 0.0f, float maxDepth = 1.0f)
        where TD3D11DeviceContext : unmanaged, ID3D11DeviceContext.Interface
    {
        var viewport = new Viewport(x, y, width, height, minDepth, maxDepth);
        self.RSSetViewports(1, &viewport);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void RSSetViewport<TD3D11DeviceContext>(
        ref this TD3D11DeviceContext self,
        Viewport viewport)
        where TD3D11DeviceContext : unmanaged, ID3D11DeviceContext.Interface
    {
        self.RSSetViewports(1, &viewport);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void RSSetScissorRect<TD3D11DeviceContext>(
        ref this TD3D11DeviceContext self,
        int width, int height)
        where TD3D11DeviceContext : unmanaged, ID3D11DeviceContext.Interface
    {
        Rect rawRect = Rect.Create(0, 0, width, height);
        self.RSSetScissorRects(1, &rawRect);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void RSSetScissorRect<TD3D11DeviceContext>(
        ref this TD3D11DeviceContext self,
        int x, int y, int width, int height)
        where TD3D11DeviceContext : unmanaged, ID3D11DeviceContext.Interface
    {
        Rect rawRect = Rect.Create(x, y, width, height);
        self.RSSetScissorRects(1, &rawRect);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void RSSetScissorRect<TD3D11DeviceContext>(
        ref this TD3D11DeviceContext self,
        Rect rect)
        where TD3D11DeviceContext : unmanaged, ID3D11DeviceContext.Interface
    {
        self.RSSetScissorRects(1, &rect);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void OMSetBlendState<TD3D11DeviceContext>(
        ref this TD3D11DeviceContext self,
        ID3D11BlendState* blendState)
        where TD3D11DeviceContext : unmanaged, ID3D11DeviceContext.Interface
    {
        self.OMSetBlendState(blendState, null, D3D11_DEFAULT_SAMPLE_MASK);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void OMSetBlendState<TD3D11DeviceContext>(
        ref this TD3D11DeviceContext self,
        ID3D11BlendState* blendState, float* blendFactor)
        where TD3D11DeviceContext : unmanaged, ID3D11DeviceContext.Interface
    {
        self.OMSetBlendState(blendState, blendFactor, D3D11_DEFAULT_SAMPLE_MASK);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void UnsetRenderTargets<TD3D11DeviceContext>(ref this TD3D11DeviceContext self)
        where TD3D11DeviceContext : unmanaged, ID3D11DeviceContext.Interface
    {
        self.OMSetRenderTargets(0, null, null);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void OMSetRenderTargets<TD3D11DeviceContext>(ref this TD3D11DeviceContext self,
        ID3D11RenderTargetView* renderTargetView, ID3D11DepthStencilView* depthStencilView = null)
        where TD3D11DeviceContext : unmanaged, ID3D11DeviceContext.Interface
    {
        self.OMSetRenderTargets(1,
            renderTargetView == null ? null : &renderTargetView,
            depthStencilView);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void OMSetRenderTargets<TD3D11DeviceContext>(ref this TD3D11DeviceContext self,
        ID3D11RenderTargetView*[] renderTargetViews, ID3D11DepthStencilView* depthStencilView = default)
        where TD3D11DeviceContext : unmanaged, ID3D11DeviceContext.Interface
    {
        fixed (ID3D11RenderTargetView** ppRenderTargetViews = renderTargetViews)
        {
            self.OMSetRenderTargets((uint)renderTargetViews.Length, ppRenderTargetViews, depthStencilView);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void IASetVertexBuffer<TD3D11DeviceContext>(ref this TD3D11DeviceContext self,
        int slot, ID3D11Buffer* buffer, uint stride, uint offset = 0)
        where TD3D11DeviceContext : unmanaged, ID3D11DeviceContext.Interface
    {
        self.IASetVertexBuffers((uint)slot, 1, buffer == null ? null : &buffer, &stride, &offset);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ClearRenderTargetView<TD3D11DeviceContext>(ref this TD3D11DeviceContext self, ID3D11RenderTargetView* renderTargetView, Color4 color)
        where TD3D11DeviceContext : unmanaged, ID3D11DeviceContext.Interface
    {
        self.ClearRenderTargetView(renderTargetView, (float*)&color);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ClearUnorderedAccessViewFloat<TD3D11DeviceContext>(ref this TD3D11DeviceContext self, ID3D11UnorderedAccessView* unorderedAccessView, Color4 color)
        where TD3D11DeviceContext : unmanaged, ID3D11DeviceContext.Interface
    {
        self.ClearUnorderedAccessViewFloat(unorderedAccessView, (float*)&color);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ComPtr<ID3D11CommandList> FinishCommandList<TD3D11DeviceContext>(ref this TD3D11DeviceContext self, bool restoreDeferredContextState = false)
        where TD3D11DeviceContext : unmanaged, ID3D11DeviceContext.Interface
    {
        using ComPtr<ID3D11CommandList> commandList = default;
        ThrowIfFailed(self.FinishCommandList(restoreDeferredContextState, commandList.GetAddressOf()));

        return commandList.Move();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static HResult Map<TD3D11DeviceContext>(ref this TD3D11DeviceContext self, ID3D11Texture2D* resource,
        uint mipSlice, uint arraySlice,
        MapMode mode, MapFlags flags,
        MappedSubresource* pMappedResource, out uint subresource, out uint mipSize)
        where TD3D11DeviceContext : unmanaged, ID3D11DeviceContext.Interface
    {
        subresource = resource->CalculateSubResourceIndex(mipSlice, arraySlice, out mipSize);
        return self.Map((ID3D11Resource*)resource, subresource, mode, flags, pMappedResource);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Span<T> Map<TD3D11DeviceContext, T>(ref this TD3D11DeviceContext self, ID3D11Texture2D* resource,
        uint mipSlice, uint arraySlice,
        MapMode mode = MapMode.Read, MapFlags flags = MapFlags.None)
        where TD3D11DeviceContext : unmanaged, ID3D11DeviceContext.Interface
        where T : unmanaged
    {
        uint subresource = resource->CalculateSubResourceIndex(mipSlice, arraySlice, out uint mipSize);
        MappedSubresource mappedSubresource;
        ThrowIfFailed(self.Map((ID3D11Resource*)resource, subresource, mode, flags, &mappedSubresource));

        Span<byte> source = new(mappedSubresource.pData, (int)(mipSize * mappedSubresource.RowPitch));
        return global::System.Runtime.InteropServices.MemoryMarshal.Cast<byte, T>(source);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Unmap<TD3D11DeviceContext>(ref this TD3D11DeviceContext self, ID3D11Texture1D* resource, uint mipSlice, uint arraySlice)
        where TD3D11DeviceContext : unmanaged, ID3D11DeviceContext.Interface
    {
        uint subresource = resource->CalculateSubResourceIndex(mipSlice, arraySlice, out _);
        self.Unmap((ID3D11Resource*)resource, subresource);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Unmap<TD3D11DeviceContext>(ref this TD3D11DeviceContext self, ID3D11Texture2D* resource, uint mipSlice, uint arraySlice)
        where TD3D11DeviceContext : unmanaged, ID3D11DeviceContext.Interface
    {
        uint subresource = resource->CalculateSubResourceIndex(mipSlice, arraySlice, out _);
        self.Unmap((ID3D11Resource*)resource, subresource);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Unmap<TD3D11DeviceContext>(ref this TD3D11DeviceContext self, ID3D11Texture3D* resource, uint mipSlice, uint arraySlice)
        where TD3D11DeviceContext : unmanaged, ID3D11DeviceContext.Interface
    {
        uint subresource = resource->CalculateSubResourceIndex(mipSlice, arraySlice, out _);
        self.Unmap((ID3D11Resource*)resource, subresource);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void VSSetShaderResource<TD3D11DeviceContext>(ref this TD3D11DeviceContext self, uint slot, ID3D11ShaderResourceView* view)
        where TD3D11DeviceContext : unmanaged, ID3D11DeviceContext.Interface
    {
        self.VSSetShaderResources(slot, 1, view != null ? &view : null);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void VSSetSampler<TD3D11DeviceContext>(ref this TD3D11DeviceContext self, uint slot, ID3D11SamplerState* sampler)
        where TD3D11DeviceContext : unmanaged, ID3D11DeviceContext.Interface
    {
        self.VSSetSamplers(slot, 1, sampler != null ? &sampler : null);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void VSSetConstantBuffer<TD3D11DeviceContext>(ref this TD3D11DeviceContext self, uint slot, ID3D11Buffer* constantBuffer)
        where TD3D11DeviceContext : unmanaged, ID3D11DeviceContext.Interface
    {
        self.VSSetConstantBuffers(slot, 1, constantBuffer != null ? &constantBuffer : null);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void PSSetShaderResource<TD3D11DeviceContext>(ref this TD3D11DeviceContext self, uint slot, ID3D11ShaderResourceView* view)
        where TD3D11DeviceContext : unmanaged, ID3D11DeviceContext.Interface
    {
        self.PSSetShaderResources(slot, 1, view != null ? &view : null);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void PSSetSampler<TD3D11DeviceContext>(ref this TD3D11DeviceContext self, uint slot, ID3D11SamplerState* sampler)
        where TD3D11DeviceContext : unmanaged, ID3D11DeviceContext.Interface
    {
        self.PSSetSamplers(slot, 1, sampler != null ? &sampler : null);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void PSSetConstantBuffer<TD3D11DeviceContext>(ref this TD3D11DeviceContext self, uint slot, ID3D11Buffer* constantBuffer)
        where TD3D11DeviceContext : unmanaged, ID3D11DeviceContext.Interface
    {
        self.PSSetConstantBuffers(slot, 1, constantBuffer != null ? &constantBuffer : null);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CSSetShaderResource<TD3D11DeviceContext>(ref this TD3D11DeviceContext self, uint slot, ID3D11ShaderResourceView* view)
        where TD3D11DeviceContext : unmanaged, ID3D11DeviceContext.Interface
    {
        self.CSSetShaderResources(slot, 1, view != null ? &view : null);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CSSetSampler<TD3D11DeviceContext>(ref this TD3D11DeviceContext self, uint slot, ID3D11SamplerState* sampler)
        where TD3D11DeviceContext : unmanaged, ID3D11DeviceContext.Interface
    {
        self.CSSetSamplers(slot, 1, sampler != null ? &sampler : null);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CSSetConstantBuffer<TD3D11DeviceContext>(ref this TD3D11DeviceContext self, uint slot, ID3D11Buffer* constantBuffer)
        where TD3D11DeviceContext : unmanaged, ID3D11DeviceContext.Interface
    {
        self.CSSetConstantBuffers(slot, 1, constantBuffer != null ? &constantBuffer : null);
    }
}
