// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.Direct3D12.Apis;

namespace Vortice.Win32.Graphics.Direct3D12;

unsafe partial struct BarrierGroup
{
    public BarrierGroup(uint numBarriers, BufferBarrier* pBarriers)
    {
        Type = D3D12_BARRIER_TYPE_BUFFER;
        NumBarriers = numBarriers;
        Anonymous.pBufferBarriers = pBarriers;
    }

    public BarrierGroup(uint numBarriers, TextureBarrier* pBarriers)
    {
        Type = D3D12_BARRIER_TYPE_TEXTURE;
        NumBarriers = numBarriers;
        Anonymous.pTextureBarriers = pBarriers;
    }

    public BarrierGroup(uint numBarriers, GlobalBarrier* pBarriers)
    {
        Type = D3D12_BARRIER_TYPE_GLOBAL;
        NumBarriers = numBarriers;
        Anonymous.pGlobalBarriers = pBarriers;
    }
}
