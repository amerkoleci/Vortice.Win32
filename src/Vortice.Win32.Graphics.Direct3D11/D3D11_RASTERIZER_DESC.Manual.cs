// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D3D11;

namespace Vortice.Win32.Graphics;

public partial struct D3D11_RASTERIZER_DESC
{
    /// <summary>
    /// A built-in description with settings with settings for not culling any primitives.
    /// </summary>
    public static D3D11_RASTERIZER_DESC CullNone => new(D3D11_CULL_NONE, D3D11_FILL_SOLID);

    /// <summary>
    /// A built-in description with settings for culling primitives with clockwise winding order.
    /// </summary>
    public static D3D11_RASTERIZER_DESC CullFront => new(D3D11_CULL_FRONT, D3D11_FILL_SOLID);

    /// <summary>
    /// A built-in description with settings for culling primitives with counter-clockwise winding order.
    /// </summary>
    public static D3D11_RASTERIZER_DESC CullBack => new(D3D11_CULL_BACK, D3D11_FILL_SOLID);

    /// <summary>
    /// A built-in description with settings for not culling any primitives and wireframe fill mode.
    /// </summary>
    public static D3D11_RASTERIZER_DESC Wireframe => new(D3D11_CULL_NONE, D3D11_FILL_WIREFRAME);

    /// <summary>
    /// Initializes a new instance of the <see cref="D3D11_RASTERIZER_DESC"/> struct.
    /// </summary>
    /// <param name="cullMode">A <see cref="D3D11_CULL_MODE"/> value that specifies that triangles facing the specified direction are not drawn..</param>
    /// <param name="fillMode">A <see cref="D3D11_FILL_MODE"/> value that specifies the fill mode to use when rendering.</param>
    public D3D11_RASTERIZER_DESC(D3D11_CULL_MODE cullMode, D3D11_FILL_MODE fillMode)
    {
        CullMode = cullMode;
        FillMode = fillMode;
        FrontCounterClockwise = false;
        DepthBias = (int)D3D11_DEFAULT_DEPTH_BIAS;
        DepthBiasClamp = D3D11_DEFAULT_DEPTH_BIAS_CLAMP;
        SlopeScaledDepthBias = D3D11_DEFAULT_SLOPE_SCALED_DEPTH_BIAS;
        DepthClipEnable = true;
        ScissorEnable = false;
        MultisampleEnable = true;
        AntialiasedLineEnable = false;
    }
}
