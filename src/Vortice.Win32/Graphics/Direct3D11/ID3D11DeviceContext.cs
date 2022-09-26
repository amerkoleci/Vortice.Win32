// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

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


    public ComPtr<ID3D11CommandList> FinishCommandList(bool RestoreDeferredContextState = false)
    {
        using ComPtr<ID3D11CommandList> commandList = default;
        FinishCommandList(RestoreDeferredContextState, commandList.GetAddressOf()).ThrowIfFailed();

        return commandList.Move();
    }
}
