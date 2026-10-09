// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D3D12;

namespace Vortice.Win32.Graphics;

public unsafe partial struct D3D12_DEPTH_STENCIL_DESC2
{
    public static ref readonly D3D12_DEPTH_STENCIL_DESC2 DEFAULT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x01, 0x00, 0x00, 0x00,
                0x01, 0x00, 0x00, 0x00,
                0x02, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00,
                0x01, 0x00, 0x00, 0x00,
                0x01, 0x00, 0x00, 0x00,
                0x01, 0x00, 0x00, 0x00,
                0x08, 0x00, 0x00, 0x00,
                0xFF, 0xFF, 0x00, 0x00,
                0x01, 0x00, 0x00, 0x00,
                0x01, 0x00, 0x00, 0x00,
                0x01, 0x00, 0x00, 0x00,
                0x08, 0x00, 0x00, 0x00,
                0xFF, 0xFF, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00,
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<D3D12_DEPTH_STENCIL_DESC2>());
            return ref Unsafe.As<byte, D3D12_DEPTH_STENCIL_DESC2>(ref MemoryMarshal.GetReference(data));
        }
    }

    public D3D12_DEPTH_STENCIL_DESC2(D3D12_DEPTH_STENCIL_DESC1* o)
    {
        DepthEnable = o->DepthEnable;
        DepthWriteMask = o->DepthWriteMask;
        DepthFunc = o->DepthFunc;
        StencilEnable = o->StencilEnable;
        FrontFace.StencilFailOp = o->FrontFace.StencilFailOp;
        FrontFace.StencilDepthFailOp = o->FrontFace.StencilDepthFailOp;
        FrontFace.StencilPassOp = o->FrontFace.StencilPassOp;
        FrontFace.StencilFunc = o->FrontFace.StencilFunc;
        FrontFace.StencilReadMask = o->StencilReadMask;
        FrontFace.StencilWriteMask = o->StencilWriteMask;
        BackFace.StencilFailOp = o->BackFace.StencilFailOp;
        BackFace.StencilDepthFailOp = o->BackFace.StencilDepthFailOp;
        BackFace.StencilPassOp = o->BackFace.StencilPassOp;
        BackFace.StencilFunc = o->BackFace.StencilFunc;
        BackFace.StencilReadMask = o->StencilReadMask;
        BackFace.StencilWriteMask = o->StencilWriteMask;
        DepthBoundsTestEnable = o->DepthBoundsTestEnable;
    }

    public D3D12_DEPTH_STENCIL_DESC2([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC &")] D3D12_DEPTH_STENCIL_DESC* o)
    {
        DepthEnable = o->DepthEnable;
        DepthWriteMask = o->DepthWriteMask;
        DepthFunc = o->DepthFunc;
        StencilEnable = o->StencilEnable;
        FrontFace.StencilFailOp = o->FrontFace.StencilFailOp;
        FrontFace.StencilDepthFailOp = o->FrontFace.StencilDepthFailOp;
        FrontFace.StencilPassOp = o->FrontFace.StencilPassOp;
        FrontFace.StencilFunc = o->FrontFace.StencilFunc;
        FrontFace.StencilReadMask = o->StencilReadMask;
        FrontFace.StencilWriteMask = o->StencilWriteMask;
        BackFace.StencilFailOp = o->BackFace.StencilFailOp;
        BackFace.StencilDepthFailOp = o->BackFace.StencilDepthFailOp;
        BackFace.StencilPassOp = o->BackFace.StencilPassOp;
        BackFace.StencilFunc = o->BackFace.StencilFunc;
        BackFace.StencilReadMask = o->StencilReadMask;
        BackFace.StencilWriteMask = o->StencilWriteMask;
        DepthBoundsTestEnable = 0;
    }


    public D3D12_DEPTH_STENCIL_DESC2(in D3D12_DEPTH_STENCIL_DESC1 o)
    {
        DepthEnable = o.DepthEnable;
        DepthWriteMask = o.DepthWriteMask;
        DepthFunc = o.DepthFunc;
        StencilEnable = o.StencilEnable;
        FrontFace.StencilFailOp = o.FrontFace.StencilFailOp;
        FrontFace.StencilDepthFailOp = o.FrontFace.StencilDepthFailOp;
        FrontFace.StencilPassOp = o.FrontFace.StencilPassOp;
        FrontFace.StencilFunc = o.FrontFace.StencilFunc;
        FrontFace.StencilReadMask = o.StencilReadMask;
        FrontFace.StencilWriteMask = o.StencilWriteMask;
        BackFace.StencilFailOp = o.BackFace.StencilFailOp;
        BackFace.StencilDepthFailOp = o.BackFace.StencilDepthFailOp;
        BackFace.StencilPassOp = o.BackFace.StencilPassOp;
        BackFace.StencilFunc = o.BackFace.StencilFunc;
        BackFace.StencilReadMask = o.StencilReadMask;
        BackFace.StencilWriteMask = o.StencilWriteMask;
        DepthBoundsTestEnable = o.DepthBoundsTestEnable;
    }

    public D3D12_DEPTH_STENCIL_DESC2(in D3D12_DEPTH_STENCIL_DESC o)
    {
        DepthEnable = o.DepthEnable;
        DepthWriteMask = o.DepthWriteMask;
        DepthFunc = o.DepthFunc;
        StencilEnable = o.StencilEnable;
        FrontFace.StencilFailOp = o.FrontFace.StencilFailOp;
        FrontFace.StencilDepthFailOp = o.FrontFace.StencilDepthFailOp;
        FrontFace.StencilPassOp = o.FrontFace.StencilPassOp;
        FrontFace.StencilFunc = o.FrontFace.StencilFunc;
        FrontFace.StencilReadMask = o.StencilReadMask;
        FrontFace.StencilWriteMask = o.StencilWriteMask;
        BackFace.StencilFailOp = o.BackFace.StencilFailOp;
        BackFace.StencilDepthFailOp = o.BackFace.StencilDepthFailOp;
        BackFace.StencilPassOp = o.BackFace.StencilPassOp;
        BackFace.StencilFunc = o.BackFace.StencilFunc;
        BackFace.StencilReadMask = o.StencilReadMask;
        BackFace.StencilWriteMask = o.StencilWriteMask;
        DepthBoundsTestEnable = 0;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="D3D12_DEPTH_STENCIL_DESC2"/> struct.
    /// </summary>
    public D3D12_DEPTH_STENCIL_DESC2(
        bool depthEnable,
        bool depthWriteEnable,
        D3D12_COMPARISON_FUNC depthFunc,
        bool stencilEnable = false,
        D3D12_STENCIL_OP frontStencilFailOp = D3D12_STENCIL_OP_KEEP,
        D3D12_STENCIL_OP frontStencilDepthFailOp = D3D12_STENCIL_OP_KEEP,
        D3D12_STENCIL_OP frontStencilPassOp = D3D12_STENCIL_OP_KEEP,
        byte frontStencilReadMask = (byte)D3D12_DEFAULT_STENCIL_READ_MASK,
        byte frontStencilWriteMask = (byte)D3D12_DEFAULT_STENCIL_WRITE_MASK,
        D3D12_COMPARISON_FUNC frontStencilFunc = D3D12_COMPARISON_FUNC_ALWAYS,
        D3D12_STENCIL_OP backStencilFailOp = D3D12_STENCIL_OP_KEEP,
        D3D12_STENCIL_OP backStencilDepthFailOp = D3D12_STENCIL_OP_KEEP,
        D3D12_STENCIL_OP backStencilPassOp = D3D12_STENCIL_OP_KEEP,
        D3D12_COMPARISON_FUNC backStencilFunc = D3D12_COMPARISON_FUNC_ALWAYS,
        byte backStencilReadMask = (byte)D3D12_DEFAULT_STENCIL_READ_MASK,
        byte backStencilWriteMask = (byte)D3D12_DEFAULT_STENCIL_WRITE_MASK,
        bool depthBoundsTestEnable = false)
    {
        DepthEnable = depthEnable;
        DepthWriteMask = depthWriteEnable ? D3D12_DEPTH_WRITE_MASK_ALL : D3D12_DEPTH_WRITE_MASK_ZERO;
        DepthFunc = depthFunc;
        StencilEnable = stencilEnable;
        FrontFace = new(frontStencilFailOp, frontStencilDepthFailOp, frontStencilPassOp, frontStencilFunc, frontStencilReadMask, frontStencilWriteMask);
        BackFace = new(backStencilFailOp, backStencilDepthFailOp, backStencilPassOp, backStencilFunc, backStencilReadMask, backStencilWriteMask);
        DepthBoundsTestEnable = depthBoundsTestEnable;
    }

    public static explicit operator D3D12_DEPTH_STENCIL_DESC(in D3D12_DEPTH_STENCIL_DESC2 value) => new D3D12_DEPTH_STENCIL_DESC
    {
        DepthEnable = value.DepthEnable,
        DepthWriteMask = value.DepthWriteMask,
        DepthFunc = value.DepthFunc,
        StencilEnable = value.StencilEnable,
        StencilReadMask = value.FrontFace.StencilReadMask,
        StencilWriteMask = value.FrontFace.StencilWriteMask,
        FrontFace = new D3D12_DEPTH_STENCILOP_DESC
        {
            StencilFailOp = value.FrontFace.StencilFailOp,
            StencilDepthFailOp = value.FrontFace.StencilDepthFailOp,
            StencilPassOp = value.FrontFace.StencilPassOp,
            StencilFunc = value.FrontFace.StencilFunc,
        },
        BackFace = new D3D12_DEPTH_STENCILOP_DESC
        {
            StencilFailOp = value.BackFace.StencilFailOp,
            StencilDepthFailOp = value.BackFace.StencilDepthFailOp,
            StencilPassOp = value.BackFace.StencilPassOp,
            StencilFunc = value.BackFace.StencilFunc,
        },
    };
}
