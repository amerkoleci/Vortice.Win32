// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Win32.Graphics.Direct3D12.Apis;

namespace Win32.Graphics.Direct3D12;

public unsafe partial struct StaticSamplerDescription
{
    /// <summary>
    /// Initializes a new instance of the <see cref="StaticSamplerDescription"/> struct.
    /// </summary>
    /// <param name="shaderVisibility">The shader visibility.</param>
    /// <param name="shaderRegister">The shader register.</param>
    /// <param name="registerSpace">The register space.</param>
    public StaticSamplerDescription(
        ShaderVisibility shaderVisibility,
        uint shaderRegister,
        uint registerSpace)
    {
        Filter = Filter.MinMagMipLinear;
        AddressU = TextureAddressMode.Clamp;
        AddressV = TextureAddressMode.Clamp;
        AddressW = TextureAddressMode.Clamp;
        MipLODBias = 0.0f;
        MaxAnisotropy = 1;
        ComparisonFunc = ComparisonFunction.Never;
        BorderColor = StaticBorderColor.TransparentBlack;
        MinLOD = float.MinValue;
        MaxLOD = float.MaxValue;

        ShaderRegister = shaderRegister;
        RegisterSpace = registerSpace;
        ShaderVisibility = shaderVisibility;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="StaticSamplerDescription"/> struct.
    /// </summary>
    /// <param name="samplerDescription">Sampler description</param>
    /// <param name="shaderVisibility">The shader visibility</param>
    /// <param name="shaderRegister">The shader register</param>
    /// <param name="registerSpace">The register space</param>
    /// <param name="borderColor">The <see cref="StaticBorderColor"/> value</param>
    public StaticSamplerDescription(
        in SamplerDescription samplerDescription,
        ShaderVisibility shaderVisibility,
        uint shaderRegister,
        uint registerSpace,
        StaticBorderColor borderColor = StaticBorderColor.OpaqueWhite) : this()
    {
        ShaderVisibility = shaderVisibility;
        ShaderRegister = shaderRegister;
        RegisterSpace = registerSpace;
        BorderColor = borderColor;
        Filter = samplerDescription.Filter;
        AddressU = samplerDescription.AddressU;
        AddressV = samplerDescription.AddressV;
        AddressW = samplerDescription.AddressW;
        MinLOD = samplerDescription.MinLOD;
        MaxLOD = samplerDescription.MaxLOD;
        MipLODBias = samplerDescription.MipLODBias;
        MaxAnisotropy = samplerDescription.MaxAnisotropy;
        ComparisonFunc = samplerDescription.ComparisonFunc;
    }
}
