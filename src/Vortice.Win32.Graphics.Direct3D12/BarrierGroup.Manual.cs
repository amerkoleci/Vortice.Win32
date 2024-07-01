// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D12;

unsafe partial struct BarrierGroup
{
    public BarrierGroup(uint numBarriers, BufferBarrier* pBarriers)
    {
        Type = BarrierType.Buffer;
        NumBarriers = numBarriers;
        Anonymous.pBufferBarriers = pBarriers;
    }

    public BarrierGroup(uint numBarriers, TextureBarrier* pBarriers)
    {
        Type = BarrierType.Texture;
        NumBarriers = numBarriers;
        Anonymous.pTextureBarriers = pBarriers;
    }

    public BarrierGroup(uint numBarriers, GlobalBarrier* pBarriers)
    {
        Type = BarrierType.Global;
        NumBarriers = numBarriers;
        Anonymous.pGlobalBarriers = pBarriers;
    }
}
