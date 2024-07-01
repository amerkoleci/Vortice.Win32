// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Win32.Graphics.Direct3D12.Apis;

namespace Win32.Graphics.Direct3D12;

public partial struct DepthStencilDescription1
{
    /// <summary>
    /// A built-in description with settings for not using a depth stencil buffer.
    /// </summary>
    public static readonly DepthStencilDescription1 None = new(false, false, ComparisonFunction.LessEqual);

    /// <summary>
    /// A built-in description with default settings for using a depth stencil buffer.
    /// </summary>
    public static readonly DepthStencilDescription1 Default = new(true, true, ComparisonFunction.LessEqual);

    /// <summary>
    /// A built-in description with settings for enabling a read-only depth stencil buffer.
    /// </summary>
    public static readonly DepthStencilDescription1 Read = new(true, false, ComparisonFunction.LessEqual);

    /// <summary>
    /// A built-in description with default settings for using a reverse depth stencil buffer.
    /// </summary>
    public static readonly DepthStencilDescription1 ReverseZ = new(true, true, ComparisonFunction.GreaterEqual);

    /// <summary>
    /// A built-in description with default settings for using a reverse read-only depth stencil buffer.
    /// </summary>
    public static readonly DepthStencilDescription1 ReadReverseZ = new(true, false, ComparisonFunction.GreaterEqual);

    /// <summary>
    /// Initializes a new instance of the <see cref="DepthStencilDescription1"/> struct.
    /// </summary>
    public DepthStencilDescription1(
        bool depthEnable,
        bool depthWriteEnable,
        ComparisonFunction depthFunc,
        bool stencilEnable = false,
        byte stencilReadMask = (byte)D3D12_DEFAULT_STENCIL_READ_MASK,
        byte stencilWriteMask = (byte)D3D12_DEFAULT_STENCIL_WRITE_MASK,
        StencilOperation frontStencilFailOp = StencilOperation.Keep,
        StencilOperation frontStencilDepthFailOp = StencilOperation.Keep,
        StencilOperation frontStencilPassOp = StencilOperation.Keep,
        ComparisonFunction frontStencilFunc = ComparisonFunction.Always,
        StencilOperation backStencilFailOp = StencilOperation.Keep,
        StencilOperation backStencilDepthFailOp = StencilOperation.Keep,
        StencilOperation backStencilPassOp = StencilOperation.Keep,
        ComparisonFunction backStencilFunc = ComparisonFunction.Always,
        bool depthBoundsTestEnable = false)
    {
        DepthEnable = depthEnable;
        DepthWriteMask = depthWriteEnable ? DepthWriteMask.All : DepthWriteMask.Zero;
        DepthFunc = depthFunc;
        StencilEnable = stencilEnable;
        StencilReadMask = stencilReadMask;
        StencilWriteMask = stencilWriteMask;
        FrontFace = new(frontStencilFailOp, frontStencilDepthFailOp, frontStencilPassOp, frontStencilFunc);
        BackFace = new(backStencilFailOp, backStencilDepthFailOp, backStencilPassOp, backStencilFunc);
        DepthBoundsTestEnable = depthBoundsTestEnable;
    }
}
