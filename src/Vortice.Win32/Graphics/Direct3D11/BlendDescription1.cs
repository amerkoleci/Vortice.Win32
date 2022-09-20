// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Win32.Graphics.Direct3D11.Apis;

namespace Win32.Graphics.Direct3D11;

public unsafe partial struct BlendDescription1
{
    /// <summary>
    /// A built-in description with settings for opaque blend, that is overwriting the source with the destination data.
    /// </summary>
    public static readonly BlendDescription1 Opaque = new(Blend.One, Blend.Zero);

    /// <summary>
    /// A built-in description with settings for alpha blend, that is blending the source and destination data using alpha.
    /// </summary>
    public static readonly BlendDescription1 AlphaBlend = new(Blend.One, Blend.InvSrcAlpha);

    /// <summary>
    /// A built-in description with settings for additive blend, that is adding the destination data to the source data without using alpha.
    /// </summary>
    public static readonly BlendDescription1 Additive = new(Blend.SrcAlpha, Blend.One);

    /// <summary>
    /// A built-in description with settings for blending with non-premultipled alpha, that is blending source and destination data using alpha while assuming the color data contains no alpha information.
    /// </summary>
    public static readonly BlendDescription NonPremultiplied = new(Blend.SrcAlpha, Blend.InvSrcAlpha);

    /// <summary>
    /// Initializes a new instance of the <see cref="BlendDescription1"/> struct.
    /// </summary>
    /// <param name="sourceBlend">The source blend.</param>
    /// <param name="destinationBlend">The destination blend.</param>
    public BlendDescription1(Blend sourceBlend, Blend destinationBlend)
        : this(sourceBlend, destinationBlend, sourceBlend, destinationBlend)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BlendDescription1"/> struct.
    /// </summary>
    /// <param name="sourceBlend">The source blend.</param>
    /// <param name="destinationBlend">The destination blend.</param>
    /// <param name="srcBlendAlpha">The source alpha blend.</param>
    /// <param name="destBlendAlpha">The destination alpha blend.</param>
    public BlendDescription1(Blend sourceBlend, Blend destinationBlend, Blend srcBlendAlpha, Blend destBlendAlpha)
        : this()
    {
        AlphaToCoverageEnable = false;
        IndependentBlendEnable = false;

        for (int i = 0; i < D3D11_SIMULTANEOUS_RENDER_TARGET_COUNT; i++)
        {
            RenderTarget[i].SrcBlend = sourceBlend;
            RenderTarget[i].DestBlend = destinationBlend;
            RenderTarget[i].BlendOp = BlendOp.Add;
            RenderTarget[i].SrcBlendAlpha = srcBlendAlpha;
            RenderTarget[i].DestBlendAlpha = destBlendAlpha;
            RenderTarget[i].BlendOpAlpha = BlendOp.Add;
            RenderTarget[i].LogicOp = LogicOp.Noop;
            RenderTarget[i].RenderTargetWriteMask = ColorWriteEnable.All;
            RenderTarget[i].BlendEnable = IsBlendEnabled(ref RenderTarget[i]);
        }
    }

    private static bool IsBlendEnabled(ref RenderTargetBlendDescription1 renderTarget)
    {
        return renderTarget.BlendOp != BlendOp.Add
                || renderTarget.SrcBlend != Blend.One
                || renderTarget.DestBlendAlpha != Blend.Zero
                || renderTarget.BlendOp != BlendOp.Add
                || renderTarget.SrcBlend != Blend.One
                || renderTarget.DestBlend != Blend.Zero;
    }
}
