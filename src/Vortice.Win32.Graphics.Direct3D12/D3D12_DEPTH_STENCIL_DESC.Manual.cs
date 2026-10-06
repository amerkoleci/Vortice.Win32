// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D3D12;

namespace Vortice.Win32.Graphics;

public partial struct D3D12_DEPTH_STENCIL_DESC
{
    /// <summary>
    /// A built-in description with settings for not using a depth stencil buffer.
    /// </summary>
    public static D3D12_DEPTH_STENCIL_DESC None => new(false, false, D3D12_COMPARISON_FUNC_LESS_EQUAL);

    /// <summary>
    /// A built-in description with default settings for using a depth stencil buffer.
    /// </summary>
    public static D3D12_DEPTH_STENCIL_DESC Default => new(true, true, D3D12_COMPARISON_FUNC_LESS_EQUAL);

    /// <summary>
    /// A built-in description with settings for enabling a read-only depth stencil buffer.
    /// </summary>
    public static D3D12_DEPTH_STENCIL_DESC Read => new(true, false, D3D12_COMPARISON_FUNC_LESS_EQUAL);

    /// <summary>
    /// A built-in description with default settings for using a reverse depth stencil buffer.
    /// </summary>
    public static D3D12_DEPTH_STENCIL_DESC ReverseZ => new(true, true, D3D12_COMPARISON_FUNC_GREATER_EQUAL);

    /// <summary>
    /// A built-in description with default settings for using a reverse read-only depth stencil buffer.
    /// </summary>
    public static D3D12_DEPTH_STENCIL_DESC ReadReverseZ => new(true, false, D3D12_COMPARISON_FUNC_GREATER_EQUAL);

    /// <summary>
    /// Initializes a new instance of the <see cref="D3D12_DEPTH_STENCIL_DESC"/> struct.
    /// </summary>
    public D3D12_DEPTH_STENCIL_DESC(
        bool depthEnable,
        bool depthWriteEnable,
        D3D12_COMPARISON_FUNC depthFunc,
        bool stencilEnable = false,
        byte stencilReadMask = (byte)D3D12_DEFAULT_STENCIL_READ_MASK,
        byte stencilWriteMask = (byte)D3D12_DEFAULT_STENCIL_WRITE_MASK,
        D3D12_STENCIL_OP frontStencilFailOp = D3D12_STENCIL_OP_KEEP,
        D3D12_STENCIL_OP frontStencilDepthFailOp = D3D12_STENCIL_OP_KEEP,
        D3D12_STENCIL_OP frontStencilPassOp = D3D12_STENCIL_OP_KEEP,
        D3D12_COMPARISON_FUNC frontStencilFunc = D3D12_COMPARISON_FUNC_ALWAYS,
        D3D12_STENCIL_OP backStencilFailOp = D3D12_STENCIL_OP_KEEP,
        D3D12_STENCIL_OP backStencilDepthFailOp = D3D12_STENCIL_OP_KEEP,
        D3D12_STENCIL_OP backStencilPassOp = D3D12_STENCIL_OP_KEEP,
        D3D12_COMPARISON_FUNC backStencilFunc = D3D12_COMPARISON_FUNC_ALWAYS)
    {
        DepthEnable = depthEnable;
        DepthWriteMask = depthWriteEnable ? D3D12_DEPTH_WRITE_MASK_ALL : D3D12_DEPTH_WRITE_MASK_ZERO;
        DepthFunc = depthFunc;
        StencilEnable = stencilEnable;
        StencilReadMask = stencilReadMask;
        StencilWriteMask = stencilWriteMask;
        FrontFace = new(frontStencilFailOp, frontStencilDepthFailOp, frontStencilPassOp, frontStencilFunc);
        BackFace = new(backStencilFailOp, backStencilDepthFailOp, backStencilPassOp, backStencilFunc);
    }
}
