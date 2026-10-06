// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.Direct3D12.Apis;

namespace Vortice.Win32.Graphics.Direct3D12;

public unsafe partial struct BlendDescription
{
    /// <summary>
    /// A built-in description with settings for opaque blend, that is overwriting the source with the destination data.
    /// </summary>
    public static BlendDescription Opaque => new(D3D12_BLEND_ONE, D3D12_BLEND_ZERO);

    /// <summary>
    /// A built-in description with settings for alpha blend, that is blending the source and destination data using alpha.
    /// </summary>
    public static BlendDescription AlphaBlend => new(D3D12_BLEND_ONE, D3D12_BLEND_INV_SRC_ALPHA);

    /// <summary>
    /// A built-in description with settings for additive blend, that is adding the destination data to the source data without using alpha.
    /// </summary>
    public static BlendDescription Additive => new(D3D12_BLEND_SRC_ALPHA, D3D12_BLEND_ONE);

    /// <summary>
    /// A built-in description with settings for blending with non-premultipled alpha, that is blending source and destination data using alpha while assuming the color data contains no alpha information.
    /// </summary>
    public static BlendDescription NonPremultiplied => new(D3D12_BLEND_SRC_ALPHA, D3D12_BLEND_INV_SRC_ALPHA);

    /// <summary>
    /// Initializes a new instance of the <see cref="BlendDescription"/> struct.
    /// </summary>
    /// <param name="srcBlend">The source blend.</param>
    /// <param name="destBlend">The destination blend.</param>
    public BlendDescription(D3D12_BLEND srcBlend, D3D12_BLEND destBlend)
        : this()
    {
        AlphaToCoverageEnable = false;
        IndependentBlendEnable = false;

        for (int i = 0; i < D3D12_SIMULTANEOUS_RENDER_TARGET_COUNT; i++)
        {
            RenderTarget[i].BlendEnable = srcBlend != D3D12_BLEND_ONE || destBlend != D3D12_BLEND_ZERO;
            RenderTarget[i].LogicOp = D3D12_LOGIC_OP_NOOP;
            RenderTarget[i].SrcBlend = srcBlend;
            RenderTarget[i].DestBlend = destBlend;
            RenderTarget[i].BlendOp = D3D12_BLEND_OP_ADD;
            RenderTarget[i].SrcBlendAlpha = srcBlend;
            RenderTarget[i].DestBlendAlpha = destBlend;
            RenderTarget[i].BlendOpAlpha = D3D12_BLEND_OP_ADD;
            RenderTarget[i].RenderTargetWriteMask = D3D12_COLOR_WRITE_ENABLE_ALL;
        }
    }
}
