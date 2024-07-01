// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Win32.Graphics.Direct3D12.Apis;

namespace Win32.Graphics.Direct3D12;

public unsafe partial struct StaticSamplerDescription1
{
    /// <summary>
    /// Initializes a new instance of the <see cref="StaticSamplerDescription1"/> struct.
    /// </summary>
    /// <param name="samplerDescription">Sampler description</param>
    /// <param name="shaderVisibility">The shader visibility</param>
    /// <param name="shaderRegister">The shader register</param>
    /// <param name="registerSpace">The register space</param>
    /// <param name="flags"></param>
    /// <param name="borderColor">The <see cref="StaticBorderColor"/> value</param>
    public StaticSamplerDescription1(
        in SamplerDescription samplerDescription,
        ShaderVisibility shaderVisibility,
        uint shaderRegister,
        uint registerSpace = 0,
        SamplerFlags flags = SamplerFlags.None,
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
        Flags = flags;
    }

    public StaticSamplerDescription1(
        uint shaderRegister,
        Filter filter = Filter.Anisotropic,
        TextureAddressMode addressU = TextureAddressMode.Wrap,
        TextureAddressMode addressV = TextureAddressMode.Wrap,
        TextureAddressMode addressW = TextureAddressMode.Wrap,
        float mipLODBias = 0,
        uint maxAnisotropy = 16,
        ComparisonFunction comparisonFunc = ComparisonFunction.LessEqual,
        StaticBorderColor borderColor = StaticBorderColor.OpaqueWhite,
        float minLOD = 0,
        float maxLOD = D3D12_FLOAT32_MAX,
        ShaderVisibility shaderVisibility = ShaderVisibility.All,
        uint registerSpace = 0,
        SamplerFlags flags = SamplerFlags.None)
    {
        Init(out this, shaderRegister, filter, addressU, addressV, addressW, mipLODBias, maxAnisotropy, comparisonFunc, borderColor, minLOD, maxLOD, shaderVisibility, registerSpace, flags);
    }

    public static void Init(out StaticSamplerDescription1 samplerDesc,
        uint shaderRegister,
        Filter filter = Filter.Anisotropic,
        TextureAddressMode addressU = TextureAddressMode.Wrap,
        TextureAddressMode addressV = TextureAddressMode.Wrap,
        TextureAddressMode addressW = TextureAddressMode.Wrap,
        float mipLODBias = 0,
        uint maxAnisotropy = 16,
        ComparisonFunction comparisonFunc = ComparisonFunction.LessEqual,
        StaticBorderColor borderColor = StaticBorderColor.OpaqueWhite,
        float minLOD = 0,
        float maxLOD = D3D12_FLOAT32_MAX,
        ShaderVisibility shaderVisibility = ShaderVisibility.All,
        uint registerSpace = 0,
        SamplerFlags flags = SamplerFlags.None)
    {
        samplerDesc.ShaderRegister = shaderRegister;
        samplerDesc.Filter = filter;
        samplerDesc.AddressU = addressU;
        samplerDesc.AddressV = addressV;
        samplerDesc.AddressW = addressW;
        samplerDesc.MipLODBias = mipLODBias;
        samplerDesc.MaxAnisotropy = maxAnisotropy;
        samplerDesc.ComparisonFunc = comparisonFunc;
        samplerDesc.BorderColor = borderColor;
        samplerDesc.MinLOD = minLOD;
        samplerDesc.MaxLOD = maxLOD;
        samplerDesc.ShaderVisibility = shaderVisibility;
        samplerDesc.RegisterSpace = registerSpace;
        samplerDesc.Flags = flags;
    }

    public void Init(uint shaderRegister,
        Filter filter = Filter.Anisotropic,
        TextureAddressMode addressU = TextureAddressMode.Wrap,
        TextureAddressMode addressV = TextureAddressMode.Wrap,
        TextureAddressMode addressW = TextureAddressMode.Wrap,
        float mipLODBias = 0, uint maxAnisotropy = 16,
        ComparisonFunction comparisonFunc = ComparisonFunction.LessEqual,
        StaticBorderColor borderColor = StaticBorderColor.OpaqueWhite,
        float minLOD = 0,
        float maxLOD = D3D12_FLOAT32_MAX,
        ShaderVisibility shaderVisibility = ShaderVisibility.All,
        uint registerSpace = 0,
        SamplerFlags flags = SamplerFlags.None)
    {
        Init(out this, shaderRegister, filter, addressU, addressV, addressW, mipLODBias, maxAnisotropy, comparisonFunc, borderColor, minLOD, maxLOD, shaderVisibility, registerSpace, flags);
    }
}
