// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

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

    public ComPtr<ID3D11CommandList> FinishCommandList(bool RestoreDeferredContextState = false)
    {
        using ComPtr<ID3D11CommandList> commandList = default;
        FinishCommandList(RestoreDeferredContextState, commandList.GetAddressOf()).ThrowIfFailed();

        return commandList.Move();
    }
}
