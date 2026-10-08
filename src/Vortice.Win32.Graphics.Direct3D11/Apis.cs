// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D3D11;

namespace Vortice.Win32.Graphics;

public static unsafe partial class D3D11
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
        D3D_DRIVER_TYPE driverType,
        D3D11_CREATE_DEVICE_FLAG flags,
        ID3D11Device** ppDevice,
        D3D_FEATURE_LEVEL* pFeatureLevel,
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
        D3D_DRIVER_TYPE driverType,
        D3D11_CREATE_DEVICE_FLAG flags,
        ReadOnlySpan<D3D_FEATURE_LEVEL> featureLevels,
        ID3D11Device** ppDevice,
        D3D_FEATURE_LEVEL* pFeatureLevel,
        ID3D11DeviceContext** ppImmediateContext)
    {
        fixed (D3D_FEATURE_LEVEL* pfeatureLevels = featureLevels)
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
    public static D3D11_FILTER D3D11_ENCODE_BASIC_FILTER(D3D11_FILTER_TYPE min, D3D11_FILTER_TYPE mag, D3D11_FILTER_TYPE mip, D3D11_FILTER_REDUCTION_TYPE reduction)
    {
        return (D3D11_FILTER)((((int)min & (int)D3D11_FILTER_TYPE_MASK) << (int)D3D11_MIN_FILTER_SHIFT)
                            | (((int)mag & (int)D3D11_FILTER_TYPE_MASK) << (int)D3D11_MAG_FILTER_SHIFT)
                            | (((int)mip & (int)D3D11_FILTER_TYPE_MASK) << (int)D3D11_MIP_FILTER_SHIFT)
                            | (((int)reduction & (int)D3D11_FILTER_REDUCTION_TYPE_MASK) << (int)D3D11_FILTER_REDUCTION_TYPE_SHIFT));
    }

    public static D3D11_FILTER D3D11_ENCODE_ANISOTROPIC_FILTER(D3D11_FILTER_REDUCTION_TYPE reduction)
    {
        return (D3D11_FILTER)(D3D11_ANISOTROPIC_FILTERING_BIT
                            | (int)D3D11_ENCODE_BASIC_FILTER(D3D11_FILTER_TYPE_LINEAR, D3D11_FILTER_TYPE_LINEAR, D3D11_FILTER_TYPE_LINEAR, reduction));
    }

    public static D3D11_FILTER_TYPE D3D11_DECODE_MIN_FILTER(D3D11_FILTER D3D11Filter)
    {
        return (D3D11_FILTER_TYPE)(((int)D3D11Filter >> (int)D3D11_MIN_FILTER_SHIFT) & (int)D3D11_FILTER_TYPE_MASK);
    }

    public static D3D11_FILTER_TYPE D3D11_DECODE_MAG_FILTER(D3D11_FILTER D3D11Filter)
    {
        return (D3D11_FILTER_TYPE)(((int)D3D11Filter >> (int)D3D11_MAG_FILTER_SHIFT) & (int)D3D11_FILTER_TYPE_MASK);
    }

    public static D3D11_FILTER_TYPE D3D11_DECODE_MIP_FILTER(D3D11_FILTER D3D11Filter)
    {
        return (D3D11_FILTER_TYPE)(((int)D3D11Filter >> (int)D3D11_MIP_FILTER_SHIFT) & (int)D3D11_FILTER_TYPE_MASK);
    }

    public static D3D11_FILTER_REDUCTION_TYPE D3D11_DECODE_FILTER_REDUCTION(D3D11_FILTER D3D11Filter)
    {
        return (D3D11_FILTER_REDUCTION_TYPE)(((int)D3D11Filter >> (int)D3D11_FILTER_REDUCTION_TYPE_SHIFT) & (int)D3D11_FILTER_REDUCTION_TYPE_MASK);
    }

    public static bool D3D11_DECODE_IS_COMPARISON_FILTER(D3D11_FILTER D3D11Filter)
    {
        return D3D11_DECODE_FILTER_REDUCTION(D3D11Filter) == D3D11_FILTER_REDUCTION_TYPE_COMPARISON;
    }
    public static bool D3D11_DECODE_IS_ANISOTROPIC_FILTER(D3D11_FILTER D3D11Filter)
    {
        return (((int)D3D11Filter & D3D11_ANISOTROPIC_FILTERING_BIT) != 0)
            && (D3D11_FILTER_TYPE_LINEAR == D3D11_DECODE_MIN_FILTER(D3D11Filter))
            && (D3D11_FILTER_TYPE_LINEAR == D3D11_DECODE_MAG_FILTER(D3D11Filter))
            && (D3D11_FILTER_TYPE_LINEAR == D3D11_DECODE_MIP_FILTER(D3D11Filter));
    }
}
