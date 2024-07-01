// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Win32.Graphics.Direct3D12.Apis;

namespace Win32.Graphics.Direct3D12;

public partial struct RasterizerDescription
{
    /// <summary>
    /// A built-in description with settings with settings for not culling any primitives.
    /// </summary>
    public static readonly RasterizerDescription CullNone = new(FillMode.Solid, CullMode.None);

    /// <summary>
    /// A built-in description with settings for culling primitives with clockwise winding order.
    /// </summary>
    public static readonly RasterizerDescription CullClockwise = new(FillMode.Solid, CullMode.Front);

    /// <summary>
    /// A built-in description with settings for culling primitives with counter-clockwise winding order.
    /// </summary>
    public static readonly RasterizerDescription CullCounterClockwise = new(FillMode.Solid, CullMode.Back);

    /// <summary>
    /// A built-in description with settings for not culling any primitives and wireframe fill mode.
    /// </summary>
    public static readonly RasterizerDescription Wireframe = new(FillMode.Wireframe, CullMode.Back);

    /// <summary>
    /// Initializes a new instance of the <see cref="RasterizerDescription"/> class.
    /// </summary>
    public RasterizerDescription(
        FillMode fillMode,
        CullMode cullMode,
        bool frontCounterClockwise = false,
        int depthBias = D3D12_DEFAULT_DEPTH_BIAS,
        float depthBiasClamp = D3D12_DEFAULT_DEPTH_BIAS_CLAMP,
        float slopeScaledDepthBias = D3D12_DEFAULT_SLOPE_SCALED_DEPTH_BIAS,
        bool depthClipEnable = true,
        bool multisampleEnable = true,
        bool antialiasedLineEnable = false,
        uint forcedSampleCount = 0,
        ConservativeRasterizationMode conservativeRaster = ConservativeRasterizationMode.Off)
    {
        CullMode = cullMode;
        FillMode = fillMode;
        FrontCounterClockwise = false;
        DepthBias = depthBias;
        DepthBiasClamp = depthBiasClamp;
        SlopeScaledDepthBias = slopeScaledDepthBias;
        DepthClipEnable = depthClipEnable;
        MultisampleEnable = multisampleEnable;
        AntialiasedLineEnable = antialiasedLineEnable;
        ForcedSampleCount = forcedSampleCount;
        ConservativeRaster = conservativeRaster;
    }
}
