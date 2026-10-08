// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D3D11;

namespace Vortice.Win32.Graphics;

public partial struct D3D11_DEPTH_STENCIL_DESC
{
    /// <summary>
    /// A built-in description with settings for not using a depth stencil buffer.
    /// </summary>
    public static D3D11_DEPTH_STENCIL_DESC None => new(false, D3D11_DEPTH_WRITE_MASK_ZERO);

    /// <summary>
    /// A built-in description with default settings for using a depth stencil buffer.
    /// </summary>
    public static D3D11_DEPTH_STENCIL_DESC Default => new(true, D3D11_DEPTH_WRITE_MASK_ALL);

    /// <summary>
    /// A built-in description with settings for enabling a read-only depth stencil buffer.
    /// </summary>
    public static D3D11_DEPTH_STENCIL_DESC DepthRead => new(true, D3D11_DEPTH_WRITE_MASK_ZERO);

    /// <summary>
    /// A built-in description with settings for using a reverse depth stencil buffer.
    /// </summary>
    public static D3D11_DEPTH_STENCIL_DESC DepthReverseZ => new(true, D3D11_DEPTH_WRITE_MASK_ALL, D3D11_COMPARISON_GREATER_EQUAL);

    /// <summary>
    /// A built-in description with settings for enabling a read-only reverse depth stencil buffer.
    /// </summary>
    public static D3D11_DEPTH_STENCIL_DESC DepthReadReverseZ => new(true, D3D11_DEPTH_WRITE_MASK_ZERO, D3D11_COMPARISON_GREATER_EQUAL);

    /// <summary>
    /// Initializes a new instance of the <see cref="D3D11_DEPTH_STENCIL_DESC"/> struct.
    /// </summary>
    /// <param name="depthEnable">Enable depth testing.</param>
    /// <param name="depthWriteMask">Identify a portion of the depth-stencil buffer that can be modified by depth data.</param>
    /// <param name="depthFunc">A function that compares depth data against existing depth data. </param>
    public D3D11_DEPTH_STENCIL_DESC(
        bool depthEnable,
        D3D11_DEPTH_WRITE_MASK depthWriteMask,
        D3D11_COMPARISON_FUNC depthFunc = D3D11_COMPARISON_LESS_EQUAL)
    {
        DepthEnable = depthEnable;
        DepthWriteMask = depthWriteMask;
        DepthFunc = depthFunc;
        StencilEnable = false;
        StencilReadMask = (byte)D3D11_DEFAULT_STENCIL_READ_MASK;
        StencilWriteMask = (byte)D3D11_DEFAULT_STENCIL_WRITE_MASK;
        FrontFace = D3D11_DEPTH_STENCILOP_DESC.Default;
        BackFace = D3D11_DEPTH_STENCILOP_DESC.Default;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="D3D11_DEPTH_STENCIL_DESC"/> struct.
    /// </summary>
    /// <param name="depthEnable">Specifies whether to enable depth testing. Set this member to <b>true</b> to enable depth testing.</param>
    /// <param name="depthWriteEnable">Specifies a value that identifies a portion of the depth-stencil buffer that can be modified by depth data.</param>
    /// <param name="depthFunc">A <see cref="D3D11_COMPARISON_FUNC"/> value that identifies a function that compares depth data against existing depth data.</param>
    /// <param name="stencilEnable">Specifies whether to enable stencil testing. Set this member to <b>true</b> to enable stencil testing.</param>
    /// <param name="stencilReadMask">Identify a portion of the depth-stencil buffer for reading stencil data.</param>
    /// <param name="stencilWriteMask">Identify a portion of the depth-stencil buffer for writing stencil data.</param>
    /// <param name="frontStencilFailOp"></param>
    /// <param name="frontStencilDepthFailOp"></param>
    /// <param name="frontStencilPassOp"></param>
    /// <param name="frontStencilFunc"></param>
    /// <param name="backStencilFailOp"></param>
    /// <param name="backStencilDepthFailOp"></param>
    /// <param name="backStencilPassOp"></param>
    /// <param name="backStencilFunc"></param>
    public D3D11_DEPTH_STENCIL_DESC(
        bool depthEnable,
        bool depthWriteEnable,
        D3D11_COMPARISON_FUNC depthFunc,
        bool stencilEnable,
        byte stencilReadMask,
        byte stencilWriteMask,
        D3D11_STENCIL_OP frontStencilFailOp,
        D3D11_STENCIL_OP frontStencilDepthFailOp,
        D3D11_STENCIL_OP frontStencilPassOp,
        D3D11_COMPARISON_FUNC frontStencilFunc,
        D3D11_STENCIL_OP backStencilFailOp,
        D3D11_STENCIL_OP backStencilDepthFailOp,
        D3D11_STENCIL_OP backStencilPassOp,
        D3D11_COMPARISON_FUNC backStencilFunc)
    {
        DepthEnable = depthEnable;
        DepthWriteMask = depthWriteEnable ? D3D11_DEPTH_WRITE_MASK_ALL : D3D11_DEPTH_WRITE_MASK_ZERO;
        DepthFunc = depthFunc;
        StencilEnable = stencilEnable;
        StencilReadMask = stencilReadMask;
        StencilWriteMask = stencilWriteMask;
        FrontFace.StencilFailOp = frontStencilFailOp;
        FrontFace.StencilDepthFailOp = frontStencilDepthFailOp;
        FrontFace.StencilPassOp = frontStencilPassOp;
        FrontFace.StencilFunc = frontStencilFunc;
        BackFace.StencilFailOp = backStencilFailOp;
        BackFace.StencilDepthFailOp = backStencilDepthFailOp;
        BackFace.StencilPassOp = backStencilPassOp;
        BackFace.StencilFunc = backStencilFunc;
    }
}
