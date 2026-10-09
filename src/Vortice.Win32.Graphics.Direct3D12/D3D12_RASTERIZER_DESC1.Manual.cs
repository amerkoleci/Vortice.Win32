// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Graphics;

public partial struct D3D12_RASTERIZER_DESC1
{
    public static ref readonly D3D12_RASTERIZER_DESC1 DEFAULT
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
                0x00, 0x00, 0x00, 0x00,
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<D3D12_RASTERIZER_DESC1>());
            return ref Unsafe.As<byte, D3D12_RASTERIZER_DESC1>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="D3D12_RASTERIZER_DESC1"/> class.
    /// </summary>
    public D3D12_RASTERIZER_DESC1(D3D12_FILL_MODE fillMode, D3D12_CULL_MODE cullMode, bool frontCounterClockwise, float depthBias, float depthBiasClamp, float slopeScaledDepthBias, bool depthClipEnable, bool multisampleEnable, bool antialiasedLineEnable, uint forcedSampleCount, D3D12_CONSERVATIVE_RASTERIZATION_MODE conservativeRaster)
    {
        FillMode = fillMode;
        CullMode = cullMode;
        FrontCounterClockwise = frontCounterClockwise;
        DepthBias = depthBias;
        DepthBiasClamp = depthBiasClamp;
        SlopeScaledDepthBias = slopeScaledDepthBias;
        DepthClipEnable = depthClipEnable;
        MultisampleEnable = multisampleEnable;
        AntialiasedLineEnable = antialiasedLineEnable;
        ForcedSampleCount = forcedSampleCount;
        ConservativeRaster = conservativeRaster;
    }

    public D3D12_RASTERIZER_DESC1(in D3D12_RASTERIZER_DESC o)
    {
        FillMode = o.FillMode;
        CullMode = o.CullMode;
        FrontCounterClockwise = o.FrontCounterClockwise;
        DepthBias = (float)(o.DepthBias);
        DepthBiasClamp = o.DepthBiasClamp;
        SlopeScaledDepthBias = o.SlopeScaledDepthBias;
        DepthClipEnable = o.DepthClipEnable;
        MultisampleEnable = o.MultisampleEnable;
        AntialiasedLineEnable = o.AntialiasedLineEnable;
        ForcedSampleCount = o.ForcedSampleCount;
        ConservativeRaster = o.ConservativeRaster;
    }


    public unsafe D3D12_RASTERIZER_DESC1(D3D12_RASTERIZER_DESC* o)
    {
        FillMode = o->FillMode;
        CullMode = o->CullMode;
        FrontCounterClockwise = o->FrontCounterClockwise;
        DepthBias = (float)(o->DepthBias);
        DepthBiasClamp = o->DepthBiasClamp;
        SlopeScaledDepthBias = o->SlopeScaledDepthBias;
        DepthClipEnable = o->DepthClipEnable;
        MultisampleEnable = o->MultisampleEnable;
        AntialiasedLineEnable = o->AntialiasedLineEnable;
        ForcedSampleCount = o->ForcedSampleCount;
        ConservativeRaster = o->ConservativeRaster;
    }

    public static explicit operator D3D12_RASTERIZER_DESC(in D3D12_RASTERIZER_DESC1 value)
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
            MultisampleEnable = value.MultisampleEnable,
            AntialiasedLineEnable = value.AntialiasedLineEnable,
            ForcedSampleCount = value.ForcedSampleCount,
            ConservativeRaster = value.ConservativeRaster
        };
        return o;
    }
}
