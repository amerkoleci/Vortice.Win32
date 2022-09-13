// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D11;

public unsafe partial struct DepthStencilOpDescription
{
    /// <summary>
    /// A built-in description with default values.
    /// </summary>
    public static readonly DepthStencilOpDescription Default = new(StencilOp.Keep, StencilOp.Keep, StencilOp.Keep, ComparisonFunc.Always);

    /// <summary>
    /// Initializes a new instance of the <see cref="DepthStencilOpDescription"/> struct.
    /// </summary>
    /// <param name="stencilFailOp">A <see cref="StencilOp"/> value that identifies the stencil operation to perform when stencil testing fails.</param>
    /// <param name="stencilDepthFailOp">A <see cref="StencilOp"/> value that identifies the stencil operation to perform when stencil testing passes and depth testing fails.</param>
    /// <param name="stencilPassOp">A <see cref="StencilOp"/> value that identifies the stencil operation to perform when stencil testing and depth testing both pass.</param>
    /// <param name="stencilFunc">A <see cref="ComparisonFunc"/> value that identifies the function that compares stencil data against existing stencil data.</param>
    public DepthStencilOpDescription(StencilOp stencilFailOp, StencilOp stencilDepthFailOp, StencilOp stencilPassOp, ComparisonFunc stencilFunc)
    {
        StencilFailOp = stencilFailOp;
        StencilDepthFailOp = stencilDepthFailOp;
        StencilPassOp = stencilPassOp;
        StencilFunc = stencilFunc;
    }
}
