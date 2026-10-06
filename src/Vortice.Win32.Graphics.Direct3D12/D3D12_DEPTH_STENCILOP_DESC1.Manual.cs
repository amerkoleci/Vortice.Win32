// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D3D12;

namespace Vortice.Win32.Graphics;

public partial struct D3D12_DEPTH_STENCILOP_DESC1
{
    /// <summary>
    /// A built-in description with default values.
    /// </summary>
    public static D3D12_DEPTH_STENCILOP_DESC1 Default => new(D3D12_STENCIL_OP_KEEP, D3D12_STENCIL_OP_KEEP, D3D12_STENCIL_OP_KEEP, D3D12_COMPARISON_FUNC_ALWAYS, (byte)D3D12_DEFAULT_STENCIL_READ_MASK, (byte)D3D12_DEFAULT_STENCIL_WRITE_MASK);

    /// <summary>
    /// Initializes a new instance of the <see cref="D3D12_DEPTH_STENCILOP_DESC"/> struct.
    /// </summary>
    /// <param name="stencilFailOp">A <see cref="D3D12_STENCIL_OP"/> value that identifies the stencil operation to perform when stencil testing fails.</param>
    /// <param name="stencilDepthFailOp">A <see cref="D3D12_STENCIL_OP"/> value that identifies the stencil operation to perform when stencil testing passes and depth testing fails.</param>
    /// <param name="stencilPassOp">A <see cref="D3D12_STENCIL_OP"/> value that identifies the stencil operation to perform when stencil testing and depth testing both pass.</param>
    /// <param name="stencilFunc">A <see cref="D3D12_COMPARISON_FUNC"/> value that identifies the function that compares stencil data against existing stencil data.</param>
    /// <param name="stencilReadMask">A mask that determines the bits of the stencil buffer that can be read.</param>
    /// <param name="stencilWriteMask">A mask that determines the bits of the stencil buffer that can be written.</param>
    public D3D12_DEPTH_STENCILOP_DESC1(
        D3D12_STENCIL_OP stencilFailOp,
        D3D12_STENCIL_OP stencilDepthFailOp,
        D3D12_STENCIL_OP stencilPassOp,
        D3D12_COMPARISON_FUNC stencilFunc,
        byte stencilReadMask,
        byte stencilWriteMask)
    {
        StencilFailOp = stencilFailOp;
        StencilDepthFailOp = stencilDepthFailOp;
        StencilPassOp = stencilPassOp;
        StencilFunc = stencilFunc;
        StencilReadMask = stencilReadMask;
        StencilWriteMask = stencilWriteMask;
    }
}
