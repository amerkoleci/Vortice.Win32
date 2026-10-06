// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.Direct3D12.Apis;

namespace Vortice.Win32.Graphics.Direct3D12;

public unsafe partial struct DepthStencilOperationDescription
{
    /// <summary>
    /// A built-in description with default values.
    /// </summary>
    public static readonly DepthStencilOperationDescription Default = new(D3D12_STENCIL_OP_KEEP, D3D12_STENCIL_OP_KEEP, D3D12_STENCIL_OP_KEEP, D3D12_COMPARISON_FUNC_ALWAYS);

    /// <summary>
    /// Initializes a new instance of the <see cref="DepthStencilOperationDescription"/> struct.
    /// </summary>
    /// <param name="stencilFailOp">A <see cref="D3D12_STENCIL_OP"/> value that identifies the stencil operation to perform when stencil testing fails.</param>
    /// <param name="stencilDepthFailOp">A <see cref="D3D12_STENCIL_OP"/> value that identifies the stencil operation to perform when stencil testing passes and depth testing fails.</param>
    /// <param name="stencilPassOp">A <see cref="D3D12_STENCIL_OP"/> value that identifies the stencil operation to perform when stencil testing and depth testing both pass.</param>
    /// <param name="stencilFunc">A <see cref="D3D12_COMPARISON_FUNC"/> value that identifies the function that compares stencil data against existing stencil data.</param>
    public DepthStencilOperationDescription(D3D12_STENCIL_OP stencilFailOp, D3D12_STENCIL_OP stencilDepthFailOp, D3D12_STENCIL_OP stencilPassOp, D3D12_COMPARISON_FUNC stencilFunc)
    {
        StencilFailOp = stencilFailOp;
        StencilDepthFailOp = stencilDepthFailOp;
        StencilPassOp = stencilPassOp;
        StencilFunc = stencilFunc;
    }
}
