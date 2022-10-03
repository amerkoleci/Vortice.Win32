// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D12;

public partial struct DepthStencilValue
{
    public DepthStencilValue(float depth, byte stencil)
    {
        Depth = depth;
        Stencil = stencil;
    }
}
