// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Graphics;

public partial struct D3D12_DEPTH_STENCIL_VALUE
{
    public D3D12_DEPTH_STENCIL_VALUE(float depth, byte stencil)
    {
        Depth = depth;
        Stencil = stencil;
    }
}
