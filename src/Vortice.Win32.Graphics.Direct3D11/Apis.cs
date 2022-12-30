// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Direct3D;
using Win32.Graphics.Dxgi;

namespace Win32.Graphics.Direct3D11;

public static unsafe partial class Apis
{
    public static uint D3D11CalcSubresource(uint MipSlice, uint ArraySlice, uint MipLevels)
    {
        return MipSlice + ArraySlice * MipLevels;
    }

    /// <summary>
    /// Calculates the resulting size at a single level for an original size.
    /// </summary>
    /// <param name="mipLevel">The mip level to get the size.</param>
    /// <param name="baseSize">Size of the base.</param>
    /// <returns>
    /// Size of the mipLevel
    /// </returns>
    public static uint D3D11CalculateMipSize(uint mipLevel, uint baseSize)
    {
        baseSize = baseSize >> (int)mipLevel;
        return baseSize > 0 ? baseSize : 1;
    }

    public static HResult D3D11CreateDevice(
        IDXGIAdapter* adapter,
        DriverType driverType,
        CreateDeviceFlags flags,
        ID3D11Device** ppDevice,
        FeatureLevel* pFeatureLevel,
        ID3D11DeviceContext** ppImmediateContext)
    {
        return D3D11CreateDevice(
            adapter,
            driverType,
            IntPtr.Zero,
            flags,
            null,
            0u,
            D3D11_SDK_VERSION,
            ppDevice,
            pFeatureLevel,
            ppImmediateContext);
    }

    public static HResult D3D11CreateDevice(
        IDXGIAdapter* pAdapter,
        DriverType driverType,
        CreateDeviceFlags flags,
        ReadOnlySpan<FeatureLevel> featureLevels,
        ID3D11Device** ppDevice,
        FeatureLevel* pFeatureLevel,
        ID3D11DeviceContext** ppImmediateContext)
    {
        fixed (FeatureLevel* pfeatureLevels = featureLevels)
        {
            return D3D11CreateDevice(
                pAdapter,
                driverType,
                IntPtr.Zero,
                flags,
                pfeatureLevels,
                (uint)featureLevels.Length,
                D3D11_SDK_VERSION,
                ppDevice,
                pFeatureLevel,
                ppImmediateContext);
        }
    }

    public static Filter EncodeBasicFilter(FilterType min, FilterType mag, FilterType mip, FilterReductionType reduction)
    {
        return (Filter)((((uint)min & D3D11_FILTER_TYPE_MASK) << unchecked((int)D3D11_MIN_FILTER_SHIFT))
            | (((uint)mag & D3D11_FILTER_TYPE_MASK) << unchecked((int)D3D11_MAG_FILTER_SHIFT))
            | (((uint)mip & D3D11_FILTER_TYPE_MASK) << unchecked((int)D3D11_MIP_FILTER_SHIFT))
            | (((uint)reduction & D3D11_FILTER_REDUCTION_TYPE_MASK) << unchecked((int)D3D11_FILTER_REDUCTION_TYPE_SHIFT)));
    }

    public static Filter EncodeAnisotropicFilter(FilterReductionType reduction)
    {
        return (Filter)(D3D11_ANISOTROPIC_FILTERING_BIT
            | (int)EncodeBasicFilter(FilterType.Linear, FilterType.Linear, FilterType.Linear, reduction));
    }

    public static FilterType DecodeMinFilter(Filter D3D11Filter)
    {
        return (FilterType)(((uint)D3D11Filter >> unchecked((int)D3D11_MIN_FILTER_SHIFT)) & D3D11_FILTER_TYPE_MASK);
    }

    public static FilterType DecodeMagFilter(Filter D3D11Filter)
    {
        return (FilterType)(((uint)D3D11Filter >> unchecked((int)D3D11_MAG_FILTER_SHIFT)) & D3D11_FILTER_TYPE_MASK);
    }

    public static FilterType DecodeMipFilter(Filter D3D11Filter)
    {
        return (FilterType)(((uint)D3D11Filter >> unchecked((int)D3D11_MIP_FILTER_SHIFT)) & D3D11_FILTER_TYPE_MASK);
    }

    public static FilterReductionType DecodeFilterReduction(Filter D3D11Filter)
    {
        return (FilterReductionType)(((uint)D3D11Filter >> unchecked((int)D3D11_FILTER_REDUCTION_TYPE_SHIFT)) & D3D11_FILTER_REDUCTION_TYPE_MASK);
    }

    public static bool DecodeisComparisonFilter(Filter D3D11Filter)
    {
        return DecodeFilterReduction(D3D11Filter) == FilterReductionType.Comparison;
    }

    public static bool DecodeIsAnisotropicFilter(Filter D3D11Filter)
    {
        return (((int)D3D11Filter & D3D11_ANISOTROPIC_FILTERING_BIT) != 0)
            && (FilterType.Linear == DecodeMinFilter(D3D11Filter))
            && (FilterType.Linear == DecodeMagFilter(D3D11Filter))
            && (FilterType.Linear == DecodeMipFilter(D3D11Filter));
    }
}
