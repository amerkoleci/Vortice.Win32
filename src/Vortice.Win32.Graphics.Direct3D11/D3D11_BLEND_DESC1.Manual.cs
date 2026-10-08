// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D3D11;

namespace Vortice.Win32.Graphics;

public partial struct D3D11_BLEND_DESC1
{
    /// <summary>
    /// A built-in description with settings for opaque blend, that is overwriting the source with the destination data.
    /// </summary>
    public static D3D11_BLEND_DESC1 Opaque => new(D3D11_BLEND_ONE, D3D11_BLEND_ZERO);

    /// <summary>
    /// A built-in description with settings for alpha blend, that is blending the source and destination data using alpha.
    /// </summary>
    public static D3D11_BLEND_DESC1 AlphaBlend => new(D3D11_BLEND_ONE, D3D11_BLEND_INV_SRC_ALPHA);

    /// <summary>
    /// A built-in description with settings for additive blend, that is adding the destination data to the source data without using alpha.
    /// </summary>
    public static D3D11_BLEND_DESC1 Additive => new(D3D11_BLEND_SRC_ALPHA, D3D11_BLEND_ONE);

    /// <summary>
    /// A built-in description with settings for blending with non-premultipled alpha, that is blending source and destination data using alpha while assuming the color data contains no alpha information.
    /// </summary>
    public static D3D11_BLEND_DESC1 NonPremultiplied => new(D3D11_BLEND_SRC_ALPHA, D3D11_BLEND_INV_SRC_ALPHA);

    /// <summary>
    /// Initializes a new instance of the <see cref="D3D11_BLEND_DESC1"/> struct.
    /// </summary>
    /// <param name="sourceBlend">The source blend.</param>
    /// <param name="destinationBlend">The destination blend.</param>
    public D3D11_BLEND_DESC1(D3D11_BLEND sourceBlend, D3D11_BLEND destinationBlend)
        : this(sourceBlend, destinationBlend, sourceBlend, destinationBlend)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="D3D11_BLEND_DESC1"/> struct.
    /// </summary>
    /// <param name="sourceBlend">The source blend.</param>
    /// <param name="destinationBlend">The destination blend.</param>
    /// <param name="srcBlendAlpha">The source alpha blend.</param>
    /// <param name="destBlendAlpha">The destination alpha blend.</param>
    public D3D11_BLEND_DESC1(D3D11_BLEND sourceBlend, D3D11_BLEND destinationBlend, D3D11_BLEND srcBlendAlpha, D3D11_BLEND destBlendAlpha)
    {
        AlphaToCoverageEnable = false;
        IndependentBlendEnable = false;

        for (int i = 0; i < D3D11_SIMULTANEOUS_RENDER_TARGET_COUNT; i++)
        {
            RenderTarget[i].SrcBlend = sourceBlend;
            RenderTarget[i].DestBlend = destinationBlend;
            RenderTarget[i].BlendOp = D3D11_BLEND_OP_ADD;
            RenderTarget[i].SrcBlendAlpha = srcBlendAlpha;
            RenderTarget[i].DestBlendAlpha = destBlendAlpha;
            RenderTarget[i].BlendOpAlpha = D3D11_BLEND_OP_ADD;
            RenderTarget[i].LogicOp = D3D11_LOGIC_OP_NOOP;
            RenderTarget[i].RenderTargetWriteMask = D3D11_COLOR_WRITE_ENABLE_ALL;
            RenderTarget[i].BlendEnable = IsBlendEnabled(in RenderTarget[i]);
        }
    }

    private static bool IsBlendEnabled(in D3D11_RENDER_TARGET_BLEND_DESC1 renderTarget)
    {
        return renderTarget.BlendOp != D3D11_BLEND_OP_ADD
                || renderTarget.SrcBlend != D3D11_BLEND_ONE
                || renderTarget.DestBlendAlpha != D3D11_BLEND_ZERO
                || renderTarget.BlendOp != D3D11_BLEND_OP_ADD
                || renderTarget.SrcBlend != D3D11_BLEND_ONE
                || renderTarget.DestBlend != D3D11_BLEND_ZERO;
    }
}
