// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D3D12;

namespace Vortice.Win32.Graphics;

public unsafe partial struct D3D12_DEPTH_STENCIL_DESC1
{
    /// <summary>
    /// A built-in description with settings for not using a depth stencil buffer.
    /// </summary>
    public static D3D12_DEPTH_STENCIL_DESC1 None => new(false, false, D3D12_COMPARISON_FUNC_LESS_EQUAL);

    /// <summary>
    /// A built-in description with default settings for using a depth stencil buffer.
    /// </summary>
    public static D3D12_DEPTH_STENCIL_DESC1 Default => new(true, true, D3D12_COMPARISON_FUNC_LESS_EQUAL);

    /// <summary>
    /// A built-in description with settings for enabling a read-only depth stencil buffer.
    /// </summary>
    public static D3D12_DEPTH_STENCIL_DESC1 Read => new(true, false, D3D12_COMPARISON_FUNC_LESS_EQUAL);

    /// <summary>
    /// A built-in description with default settings for using a reverse depth stencil buffer.
    /// </summary>
    public static D3D12_DEPTH_STENCIL_DESC1 ReverseZ => new(true, true, D3D12_COMPARISON_FUNC_GREATER_EQUAL);

    /// <summary>
    /// A built-in description with default settings for using a reverse read-only depth stencil buffer.
    /// </summary>
    public static D3D12_DEPTH_STENCIL_DESC1 ReadReverseZ => new(true, false, D3D12_COMPARISON_FUNC_GREATER_EQUAL);

    public D3D12_DEPTH_STENCIL_DESC1([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC &")] D3D12_DEPTH_STENCIL_DESC* o)
    {
        DepthEnable = o->DepthEnable;
        DepthWriteMask = o->DepthWriteMask;
        DepthFunc = o->DepthFunc;
        StencilEnable = o->StencilEnable;
        StencilReadMask = o->StencilReadMask;
        StencilWriteMask = o->StencilWriteMask;
        FrontFace.StencilFailOp = o->FrontFace.StencilFailOp;
        FrontFace.StencilDepthFailOp = o->FrontFace.StencilDepthFailOp;
        FrontFace.StencilPassOp = o->FrontFace.StencilPassOp;
        FrontFace.StencilFunc = o->FrontFace.StencilFunc;
        BackFace.StencilFailOp = o->BackFace.StencilFailOp;
        BackFace.StencilDepthFailOp = o->BackFace.StencilDepthFailOp;
        BackFace.StencilPassOp = o->BackFace.StencilPassOp;
        BackFace.StencilFunc = o->BackFace.StencilFunc;
        DepthBoundsTestEnable = 0;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="D3D12_DEPTH_STENCIL_DESC1"/> struct.
    /// </summary>
    public D3D12_DEPTH_STENCIL_DESC1(
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
        D3D12_COMPARISON_FUNC backStencilFunc = D3D12_COMPARISON_FUNC_ALWAYS,
        bool depthBoundsTestEnable = false)
    {
        DepthEnable = depthEnable;
        DepthWriteMask = depthWriteEnable ? D3D12_DEPTH_WRITE_MASK_ALL : D3D12_DEPTH_WRITE_MASK_ZERO;
        DepthFunc = depthFunc;
        StencilEnable = stencilEnable;
        StencilReadMask = stencilReadMask;
        StencilWriteMask = stencilWriteMask;
        FrontFace = new(frontStencilFailOp, frontStencilDepthFailOp, frontStencilPassOp, frontStencilFunc);
        BackFace = new(backStencilFailOp, backStencilDepthFailOp, backStencilPassOp, backStencilFunc);
        DepthBoundsTestEnable = depthBoundsTestEnable;
    }
}
