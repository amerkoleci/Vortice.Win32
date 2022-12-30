// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Win32.Graphics.Direct3D12.Apis;

namespace Win32.Graphics.Direct3D12;

public unsafe partial struct BlendDescription
{
    /// <summary>
    /// A built-in description with settings for opaque blend, that is overwriting the source with the destination data.
    /// </summary>
    public static readonly BlendDescription Opaque = new(Blend.One, Blend.Zero);

    /// <summary>
    /// A built-in description with settings for alpha blend, that is blending the source and destination data using alpha.
    /// </summary>
    public static readonly BlendDescription AlphaBlend = new(Blend.One, Blend.InverseSrcAlpha);

    /// <summary>
    /// A built-in description with settings for additive blend, that is adding the destination data to the source data without using alpha.
    /// </summary>
    public static readonly BlendDescription Additive = new(Blend.SrcAlpha, Blend.One);

    /// <summary>
    /// A built-in description with settings for blending with non-premultipled alpha, that is blending source and destination data using alpha while assuming the color data contains no alpha information.
    /// </summary>
    public static readonly BlendDescription NonPremultiplied = new(Blend.SrcAlpha, Blend.InverseSrcAlpha);

    /// <summary>
    /// Initializes a new instance of the <see cref="BlendDescription"/> struct.
    /// </summary>
    /// <param name="srcBlend">The source blend.</param>
    /// <param name="destBlend">The destination blend.</param>
    public BlendDescription(Blend srcBlend, Blend destBlend)
        : this()
    {
        AlphaToCoverageEnable = false;
        IndependentBlendEnable = false;

        for (int i = 0; i < D3D12_SIMULTANEOUS_RENDER_TARGET_COUNT; i++)
        {
            RenderTarget[i].BlendEnable = srcBlend != Blend.One || destBlend != Blend.Zero;
            RenderTarget[i].LogicOp = LogicOperation.Noop;
            RenderTarget[i].SrcBlend = srcBlend;
            RenderTarget[i].DestBlend = destBlend;
            RenderTarget[i].BlendOp = BlendOperation.Add;
            RenderTarget[i].SrcBlendAlpha = srcBlend;
            RenderTarget[i].DestBlendAlpha = destBlend;
            RenderTarget[i].BlendOpAlpha = BlendOperation.Add;
            RenderTarget[i].RenderTargetWriteMask = ColorWriteEnable.All;
        }
    }
}
