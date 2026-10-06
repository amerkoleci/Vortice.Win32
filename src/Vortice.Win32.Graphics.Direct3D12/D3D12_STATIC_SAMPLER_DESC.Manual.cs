// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D3D12;

namespace Vortice.Win32.Graphics;

public unsafe partial struct D3D12_STATIC_SAMPLER_DESC
{
    /// <summary>
    /// Initializes a new instance of the <see cref="D3D12_STATIC_SAMPLER_DESC"/> struct.
    /// </summary>
    /// <param name="samplerDescription">Sampler description</param>
    /// <param name="shaderVisibility">The shader visibility</param>
    /// <param name="shaderRegister">The shader register</param>
    /// <param name="registerSpace">The register space</param>
    /// <param name="borderColor">The <see cref="D3D12_STATIC_BORDER_COLOR"/> value</param>
    public D3D12_STATIC_SAMPLER_DESC(
        in D3D12_SAMPLER_DESC samplerDescription,
        D3D12_SHADER_VISIBILITY shaderVisibility,
        uint shaderRegister,
        uint registerSpace = 0,
        D3D12_STATIC_BORDER_COLOR borderColor = D3D12_STATIC_BORDER_COLOR_OPAQUE_WHITE) 
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

    public D3D12_STATIC_SAMPLER_DESC(uint shaderRegister, D3D12_FILTER filter = D3D12_FILTER_ANISOTROPIC, D3D12_TEXTURE_ADDRESS_MODE addressU = D3D12_TEXTURE_ADDRESS_MODE_WRAP, D3D12_TEXTURE_ADDRESS_MODE addressV = D3D12_TEXTURE_ADDRESS_MODE_WRAP, D3D12_TEXTURE_ADDRESS_MODE addressW = D3D12_TEXTURE_ADDRESS_MODE_WRAP, float mipLODBias = 0, uint maxAnisotropy = 16, D3D12_COMPARISON_FUNC comparisonFunc = D3D12_COMPARISON_FUNC_LESS_EQUAL, D3D12_STATIC_BORDER_COLOR borderColor = D3D12_STATIC_BORDER_COLOR_OPAQUE_WHITE, float minLOD = 0.0f, float maxLOD = (3.402823466e+38f), D3D12_SHADER_VISIBILITY shaderVisibility = D3D12_SHADER_VISIBILITY_ALL, uint registerSpace = 0)
    {
        Init(shaderRegister, filter, addressU, addressV, addressW, mipLODBias, maxAnisotropy, comparisonFunc, borderColor, minLOD, maxLOD, shaderVisibility, registerSpace);
    }

    public void Init(uint shaderRegister, D3D12_FILTER filter = D3D12_FILTER_ANISOTROPIC, D3D12_TEXTURE_ADDRESS_MODE addressU = D3D12_TEXTURE_ADDRESS_MODE_WRAP, D3D12_TEXTURE_ADDRESS_MODE addressV = D3D12_TEXTURE_ADDRESS_MODE_WRAP, D3D12_TEXTURE_ADDRESS_MODE addressW = D3D12_TEXTURE_ADDRESS_MODE_WRAP, float mipLODBias = 0, uint maxAnisotropy = 16, D3D12_COMPARISON_FUNC comparisonFunc = D3D12_COMPARISON_FUNC_LESS_EQUAL, D3D12_STATIC_BORDER_COLOR borderColor = D3D12_STATIC_BORDER_COLOR_OPAQUE_WHITE, float minLOD = 0.0f, float maxLOD = (3.402823466e+38f), D3D12_SHADER_VISIBILITY shaderVisibility = D3D12_SHADER_VISIBILITY_ALL, uint registerSpace = 0)
    {
        Init(ref this, shaderRegister, filter, addressU, addressV, addressW, mipLODBias, maxAnisotropy, comparisonFunc, borderColor, minLOD, maxLOD, shaderVisibility, registerSpace);
    }

    public static void Init([NativeTypeName("D3D12_STATIC_SAMPLER_DESC &")] ref D3D12_STATIC_SAMPLER_DESC samplerDesc, uint shaderRegister, D3D12_FILTER filter = D3D12_FILTER_ANISOTROPIC, D3D12_TEXTURE_ADDRESS_MODE addressU = D3D12_TEXTURE_ADDRESS_MODE_WRAP, D3D12_TEXTURE_ADDRESS_MODE addressV = D3D12_TEXTURE_ADDRESS_MODE_WRAP, D3D12_TEXTURE_ADDRESS_MODE addressW = D3D12_TEXTURE_ADDRESS_MODE_WRAP, float mipLODBias = 0, uint maxAnisotropy = 16, D3D12_COMPARISON_FUNC comparisonFunc = D3D12_COMPARISON_FUNC_LESS_EQUAL, D3D12_STATIC_BORDER_COLOR borderColor = D3D12_STATIC_BORDER_COLOR_OPAQUE_WHITE, float minLOD = 0.0f, float maxLOD = (3.402823466e+38f), D3D12_SHADER_VISIBILITY shaderVisibility = D3D12_SHADER_VISIBILITY_ALL, uint registerSpace = 0)
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
    }
}
