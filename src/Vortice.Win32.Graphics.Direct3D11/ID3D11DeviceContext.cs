// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Win32.Apis;
using static Win32.Graphics.Direct3D11.Apis;

namespace Win32.Graphics.Direct3D11;

public unsafe partial struct ID3D11DeviceContext
{
    public void RSSetViewport(float x, float y, float width, float height, float minDepth = 0.0f, float maxDepth = 1.0f)
    {
        var viewport = new Viewport(x, y, width, height, minDepth, maxDepth);
        RSSetViewports(1, &viewport);
    }

    public void RSSetViewport(Viewport viewport)
    {
        RSSetViewports(1, &viewport);
    }

    public void RSSetScissorRect(int x, int y, int width, int height)
    {
        RawRect rawRect = new(x, y, x + width, y + height);
        RSSetScissorRects(1, &rawRect);
    }

    public void RSSetScissorRect(RawRect rect)
    {
        RSSetScissorRects(1, &rect);
    }

    public void OMSetBlendState(ID3D11BlendState* blendState, float* blendFactor)
    {
        OMSetBlendState(blendState, blendFactor, D3D11_DEFAULT_SAMPLE_MASK);
    }

    public void OMSetBlendState(ID3D11BlendState* blendState)
    {
        OMSetBlendState(blendState, null, D3D11_DEFAULT_SAMPLE_MASK);
    }

    public void IASetVertexBuffer(int slot, ID3D11Buffer* buffer, uint stride, uint offset = 0)
    {
        IASetVertexBuffers((uint)slot, 1, buffer == null ? null : &buffer, &stride, &offset);
    }

    public void VSSetShader(ID3D11VertexShader* shader)
    {
        VSSetShader(shader, null, 0);
    }

    public void VSSetShaderResource(uint slot, ID3D11ShaderResourceView* view)
    {
        VSSetShaderResources(slot, 1, view != null ? &view : null);
    }

    public void VSSetSampler(uint slot, ID3D11SamplerState* sampler)
    {
        VSSetSamplers(slot, 1, sampler != null ? &sampler : null);
    }

    public void VSSetConstantBuffer(uint slot, ID3D11Buffer* constantBuffer)
    {
        VSSetConstantBuffers(slot, 1, constantBuffer != null ? &constantBuffer : null);
    }

    public void PSSetShader(ID3D11PixelShader* shader)
    {
        PSSetShader(shader, null, 0);
    }

    public void PSSetShaderResource(uint slot, ID3D11ShaderResourceView* view)
    {
        PSSetShaderResources(slot, 1, view != null ? &view : null);
    }

    public void PSSetSampler(uint slot, ID3D11SamplerState* sampler)
    {
        PSSetSamplers(slot, 1, sampler != null ? &sampler : null);
    }

    public void PSSetConstantBuffer(uint slot, ID3D11Buffer* constantBuffer)
    {
        PSSetConstantBuffers(slot, 1, constantBuffer != null ? &constantBuffer : null);
    }

    public void CSSetShader(ID3D11ComputeShader* shader)
    {
        CSSetShader(shader, null, 0);
    }

    public void CSSetShaderResource(uint slot, ID3D11ShaderResourceView* view)
    {
        CSSetShaderResources(slot, 1, view != null ? &view : null);
    }

    public void CSSetSampler(uint slot, ID3D11SamplerState* sampler)
    {
        CSSetSamplers(slot, 1, sampler != null ? &sampler : null);
    }

    public void CSSetConstantBuffer(uint slot, ID3D11Buffer* constantBuffer)
    {
        CSSetConstantBuffers(slot, 1, constantBuffer != null ? &constantBuffer : null);
    }

    public void UnsetRenderTargets()
    {
        OMSetRenderTargets(0, null, null);
    }

    public void OMSetRenderTargets(ID3D11RenderTargetView* renderTargetView, ID3D11DepthStencilView* depthStencilView = null)
    {
        OMSetRenderTargets(1,
            renderTargetView == null ? null : &renderTargetView,
            depthStencilView);
    }

    public void ClearRenderTargetView(ID3D11RenderTargetView* renderTargetView, Color4 color)
    {
        ClearRenderTargetView(renderTargetView, (float*)&color);
    }

    public void ClearUnorderedAccessViewFloat(ID3D11UnorderedAccessView* unorderedAccessView, Color4 color)
    {
        ClearUnorderedAccessViewFloat(unorderedAccessView, (float*)&color);
    }

    public HResult Map(ID3D11Texture2D* resource,
        uint mipSlice, uint arraySlice,
        MapMode mode, MapFlags flags,
        MappedSubresource* pMappedResource, out uint subresource, out uint mipSize)
    {
        subresource = resource->CalculateSubResourceIndex(mipSlice, arraySlice, out mipSize);
        return Map((ID3D11Resource*)resource, subresource, mode, flags, pMappedResource);
    }

    public Span<T> Map<T>(ID3D11Texture2D* resource,
        uint mipSlice, uint arraySlice,
        MapMode mode = MapMode.Read, MapFlags flags = MapFlags.None) where T : unmanaged
    {
        uint subresource = resource->CalculateSubResourceIndex(mipSlice, arraySlice, out uint mipSize);
        MappedSubresource mappedSubresource;
        ThrowIfFailed(Map((ID3D11Resource*)resource, subresource, mode, flags, &mappedSubresource));

        Span<byte> source = new(mappedSubresource.pData, (int)(mipSize * mappedSubresource.RowPitch));
        return global::System.Runtime.InteropServices.MemoryMarshal.Cast<byte, T>(source);
    }

    public void Unmap(ID3D11Texture1D* resource, uint mipSlice, uint arraySlice)
    {
        uint subresource = resource->CalculateSubResourceIndex(mipSlice, arraySlice, out _);
        Unmap((ID3D11Resource*)resource, subresource);
    }

    public void Unmap(ID3D11Texture2D* resource, uint mipSlice, uint arraySlice)
    {
        uint subresource = resource->CalculateSubResourceIndex(mipSlice, arraySlice, out _);
        Unmap((ID3D11Resource*)resource, subresource);
    }

    public void Unmap(ID3D11Texture3D* resource, uint mipSlice, uint arraySlice)
    {
        uint subresource = resource->CalculateSubResourceIndex(mipSlice, arraySlice, out _);
        Unmap((ID3D11Resource*)resource, subresource);
    }

    public ComPtr<ID3D11CommandList> FinishCommandList(bool RestoreDeferredContextState = false)
    {
        using ComPtr<ID3D11CommandList> commandList = default;
        ThrowIfFailed(FinishCommandList(RestoreDeferredContextState, commandList.GetAddressOf()));

        return commandList.Move();
    }
}
