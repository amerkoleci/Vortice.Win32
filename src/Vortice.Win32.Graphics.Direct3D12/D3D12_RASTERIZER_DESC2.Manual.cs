// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D3D12;

namespace Vortice.Win32.Graphics;

public partial struct D3D12_RASTERIZER_DESC2
{
    public static ref readonly D3D12_RASTERIZER_DESC2 DEFAULT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x03, 0x00, 0x00, 0x00,
                0x03, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00,
                0x01, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00,
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<D3D12_RASTERIZER_DESC2>());
            return ref Unsafe.As<byte, D3D12_RASTERIZER_DESC2>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="D3D12_RASTERIZER_DESC2"/> class.
    /// </summary>

    public D3D12_RASTERIZER_DESC2(D3D12_FILL_MODE fillMode, D3D12_CULL_MODE cullMode, bool frontCounterClockwise, float depthBias, float depthBiasClamp, float slopeScaledDepthBias, bool depthClipEnable, D3D12_LINE_RASTERIZATION_MODE lineRasterizationMode, uint forcedSampleCount, D3D12_CONSERVATIVE_RASTERIZATION_MODE conservativeRaster)
    {
        FillMode = fillMode;
        CullMode = cullMode;
        FrontCounterClockwise = frontCounterClockwise;
        DepthBias = depthBias;
        DepthBiasClamp = depthBiasClamp;
        SlopeScaledDepthBias = slopeScaledDepthBias;
        DepthClipEnable = depthClipEnable;
        LineRasterizationMode = lineRasterizationMode;
        ForcedSampleCount = forcedSampleCount;
        ConservativeRaster = conservativeRaster;
    }
    public unsafe D3D12_RASTERIZER_DESC2([NativeTypeName("const D3D12_RASTERIZER_DESC &")] D3D12_RASTERIZER_DESC* o)
    {
        FillMode = o->FillMode;
        CullMode = o->CullMode;
        FrontCounterClockwise = o->FrontCounterClockwise;
        DepthBias = (float)(o->DepthBias);
        DepthBiasClamp = o->DepthBiasClamp;
        SlopeScaledDepthBias = o->SlopeScaledDepthBias;
        DepthClipEnable = o->DepthClipEnable;
        LineRasterizationMode = D3D12_LINE_RASTERIZATION_MODE_ALIASED;
        if ((o->MultisampleEnable) != 0)
        {
            LineRasterizationMode = D3D12_LINE_RASTERIZATION_MODE_QUADRILATERAL_WIDE;
        }
        else if ((o->AntialiasedLineEnable) != 0)
        {
            LineRasterizationMode = D3D12_LINE_RASTERIZATION_MODE_ALPHA_ANTIALIASED;
        }

        ForcedSampleCount = o->ForcedSampleCount;
        ConservativeRaster = o->ConservativeRaster;
    }

    public unsafe D3D12_RASTERIZER_DESC2([NativeTypeName("const D3D12_RASTERIZER_DESC1 &")] D3D12_RASTERIZER_DESC1* o)
    {
        FillMode = o->FillMode;
        CullMode = o->CullMode;
        FrontCounterClockwise = o->FrontCounterClockwise;
        DepthBias = o->DepthBias;
        DepthBiasClamp = o->DepthBiasClamp;
        SlopeScaledDepthBias = o->SlopeScaledDepthBias;
        DepthClipEnable = o->DepthClipEnable;
        LineRasterizationMode = D3D12_LINE_RASTERIZATION_MODE_ALIASED;
        if ((o->MultisampleEnable) != 0)
        {
            LineRasterizationMode = D3D12_LINE_RASTERIZATION_MODE_QUADRILATERAL_WIDE;
        }
        else if ((o->AntialiasedLineEnable) != 0)
        {
            LineRasterizationMode = D3D12_LINE_RASTERIZATION_MODE_ALPHA_ANTIALIASED;
        }

        ForcedSampleCount = o->ForcedSampleCount;
        ConservativeRaster = o->ConservativeRaster;
    }

    public D3D12_RASTERIZER_DESC2([NativeTypeName("const D3D12_RASTERIZER_DESC &")] in D3D12_RASTERIZER_DESC o)
    {
        FillMode = o.FillMode;
        CullMode = o.CullMode;
        FrontCounterClockwise = o.FrontCounterClockwise;
        DepthBias = (float)(o.DepthBias);
        DepthBiasClamp = o.DepthBiasClamp;
        SlopeScaledDepthBias = o.SlopeScaledDepthBias;
        DepthClipEnable = o.DepthClipEnable;
        LineRasterizationMode = D3D12_LINE_RASTERIZATION_MODE_ALIASED;
        if ((o.MultisampleEnable) != 0)
        {
            LineRasterizationMode = D3D12_LINE_RASTERIZATION_MODE_QUADRILATERAL_WIDE;
        }
        else if ((o.AntialiasedLineEnable) != 0)
        {
            LineRasterizationMode = D3D12_LINE_RASTERIZATION_MODE_ALPHA_ANTIALIASED;
        }

        ForcedSampleCount = o.ForcedSampleCount;
        ConservativeRaster = o.ConservativeRaster;
    }

    public D3D12_RASTERIZER_DESC2([NativeTypeName("const D3D12_RASTERIZER_DESC1 &")] in D3D12_RASTERIZER_DESC1 o)
    {
        FillMode = o.FillMode;
        CullMode = o.CullMode;
        FrontCounterClockwise = o.FrontCounterClockwise;
        DepthBias = o.DepthBias;
        DepthBiasClamp = o.DepthBiasClamp;
        SlopeScaledDepthBias = o.SlopeScaledDepthBias;
        DepthClipEnable = o.DepthClipEnable;
        LineRasterizationMode = D3D12_LINE_RASTERIZATION_MODE_ALIASED;
        if ((o.MultisampleEnable) != 0)
        {
            LineRasterizationMode = D3D12_LINE_RASTERIZATION_MODE_QUADRILATERAL_WIDE;
        }
        else if ((o.AntialiasedLineEnable) != 0)
        {
            LineRasterizationMode = D3D12_LINE_RASTERIZATION_MODE_ALPHA_ANTIALIASED;
        }

        ForcedSampleCount = o.ForcedSampleCount;
        ConservativeRaster = o.ConservativeRaster;
    }

    public static explicit operator D3D12_RASTERIZER_DESC(in D3D12_RASTERIZER_DESC2 value)
    {
        D3D12_RASTERIZER_DESC o = new D3D12_RASTERIZER_DESC
        {
            FillMode = value.FillMode,
            CullMode = value.CullMode,
            FrontCounterClockwise = value.FrontCounterClockwise,
            DepthBias = (int)(value.DepthBias),
            DepthBiasClamp = value.DepthBiasClamp,
            SlopeScaledDepthBias = value.SlopeScaledDepthBias,
            DepthClipEnable = value.DepthClipEnable,
            MultisampleEnable = false,
            AntialiasedLineEnable = false,
            ForcedSampleCount = value.ForcedSampleCount,
            ConservativeRaster = value.ConservativeRaster,
        };

        if (value.LineRasterizationMode == D3D12_LINE_RASTERIZATION_MODE_ALPHA_ANTIALIASED)
        {
            o.AntialiasedLineEnable = 1;
        }
        else if (value.LineRasterizationMode != D3D12_LINE_RASTERIZATION_MODE_ALIASED)
        {
            o.MultisampleEnable = 1;
        }

        return o;
    }

    public static explicit operator D3D12_RASTERIZER_DESC1(in D3D12_RASTERIZER_DESC2 value)
    {
        D3D12_RASTERIZER_DESC1 o = new D3D12_RASTERIZER_DESC1
        {
            FillMode = value.FillMode,
            CullMode = value.CullMode,
            FrontCounterClockwise = value.FrontCounterClockwise,
            DepthBias = value.DepthBias,
            DepthBiasClamp = value.DepthBiasClamp,
            SlopeScaledDepthBias = value.SlopeScaledDepthBias,
            DepthClipEnable = value.DepthClipEnable,
            MultisampleEnable = false,
            AntialiasedLineEnable = false,
            ForcedSampleCount = value.ForcedSampleCount,
            ConservativeRaster = value.ConservativeRaster,
        };

        if (value.LineRasterizationMode == D3D12_LINE_RASTERIZATION_MODE_ALPHA_ANTIALIASED)
        {
            o.AntialiasedLineEnable = 1;
        }
        else if (value.LineRasterizationMode != D3D12_LINE_RASTERIZATION_MODE_ALIASED)
        {
            o.MultisampleEnable = 1;
        }

        return o;
    }
}
