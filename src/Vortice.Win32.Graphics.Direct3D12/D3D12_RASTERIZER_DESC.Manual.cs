// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D3D12;

namespace Vortice.Win32.Graphics;

public partial struct D3D12_RASTERIZER_DESC
{
    public static ref readonly D3D12_RASTERIZER_DESC DEFAULT
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

            Debug.Assert(data.Length == Unsafe.SizeOf<D3D12_RASTERIZER_DESC>());
            return ref Unsafe.As<byte, D3D12_RASTERIZER_DESC>(ref MemoryMarshal.GetReference(data));
        }
    }

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
