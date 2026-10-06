// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D3D12;

namespace Vortice.Win32.Graphics;

unsafe partial struct D3D12_BARRIER_GROUP
{
    public D3D12_BARRIER_GROUP(uint numBarriers, D3D12_BUFFER_BARRIER* pBarriers)
    {
        Type = D3D12_BARRIER_TYPE_BUFFER;
        NumBarriers = numBarriers;
        Anonymous.pBufferBarriers = pBarriers;
    }

    public D3D12_BARRIER_GROUP(uint numBarriers, D3D12_TEXTURE_BARRIER* pBarriers)
    {
        Type = D3D12_BARRIER_TYPE_TEXTURE;
        NumBarriers = numBarriers;
        Anonymous.pTextureBarriers = pBarriers;
    }

    public D3D12_BARRIER_GROUP(uint numBarriers, D3D12_GLOBAL_BARRIER* pBarriers)
    {
        Type = D3D12_BARRIER_TYPE_GLOBAL;
        NumBarriers = numBarriers;
        Anonymous.pGlobalBarriers = pBarriers;
    }
}
