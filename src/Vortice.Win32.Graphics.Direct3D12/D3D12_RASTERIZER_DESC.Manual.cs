// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D3D12;

namespace Vortice.Win32.Graphics;

public partial struct D3D12_RASTERIZER_DESC
{
    /// <summary>
    /// A built-in description with settings with settings for not culling any primitives.
    /// </summary>
    public static D3D12_RASTERIZER_DESC CullNone => new(D3D12_FILL_MODE_SOLID, D3D12_CULL_MODE_NONE);

    /// <summary>
    /// A built-in description with settings for culling primitives with clockwise winding order.
    /// </summary>
    public static D3D12_RASTERIZER_DESC CullClockwise => new(D3D12_FILL_MODE_SOLID, D3D12_CULL_MODE_FRONT);

    /// <summary>
    /// A built-in description with settings for culling primitives with counter-clockwise winding order.
    /// </summary>
    public static D3D12_RASTERIZER_DESC CullCounterClockwise => new(D3D12_FILL_MODE_SOLID, D3D12_CULL_MODE_BACK);

    /// <summary>
    /// A built-in description with settings for not culling any primitives and wireframe fill mode.
    /// </summary>
    public static D3D12_RASTERIZER_DESC Wireframe => new(D3D12_FILL_MODE_WIREFRAME, D3D12_CULL_MODE_BACK);

    /// <summary>
    /// Initializes a new instance of the <see cref="D3D12_RASTERIZER_DESC"/> class.
    /// </summary>
    public D3D12_RASTERIZER_DESC(
        D3D12_FILL_MODE fillMode,
        D3D12_CULL_MODE cullMode,
        bool frontCounterClockwise = false,
        int depthBias = D3D12_DEFAULT_DEPTH_BIAS,
        float depthBiasClamp = D3D12_DEFAULT_DEPTH_BIAS_CLAMP,
        float slopeScaledDepthBias = D3D12_DEFAULT_SLOPE_SCALED_DEPTH_BIAS,
        bool depthClipEnable = true,
        bool multisampleEnable = true,
        bool antialiasedLineEnable = false,
        uint forcedSampleCount = 0,
        D3D12_CONSERVATIVE_RASTERIZATION_MODE conservativeRaster = D3D12_CONSERVATIVE_RASTERIZATION_MODE_OFF)
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
