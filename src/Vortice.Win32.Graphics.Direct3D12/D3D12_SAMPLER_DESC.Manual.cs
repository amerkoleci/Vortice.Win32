// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D3D12;

namespace Vortice.Win32.Graphics;

public partial struct D3D12_SAMPLER_DESC
{
    public static D3D12_SAMPLER_DESC PointWrap => new(D3D12_FILTER_MIN_MAG_MIP_POINT, D3D12_TEXTURE_ADDRESS_MODE_WRAP, D3D12_TEXTURE_ADDRESS_MODE_WRAP, D3D12_TEXTURE_ADDRESS_MODE_WRAP);
    public static D3D12_SAMPLER_DESC PointClamp => new(D3D12_FILTER_MIN_MAG_MIP_POINT, D3D12_TEXTURE_ADDRESS_MODE_CLAMP, D3D12_TEXTURE_ADDRESS_MODE_CLAMP, D3D12_TEXTURE_ADDRESS_MODE_CLAMP);

    public static D3D12_SAMPLER_DESC LinearWrap => new(D3D12_FILTER_MIN_MAG_MIP_LINEAR, D3D12_TEXTURE_ADDRESS_MODE_WRAP, D3D12_TEXTURE_ADDRESS_MODE_WRAP, D3D12_TEXTURE_ADDRESS_MODE_WRAP);
    public static D3D12_SAMPLER_DESC LinearClamp => new(D3D12_FILTER_MIN_MAG_MIP_LINEAR, D3D12_TEXTURE_ADDRESS_MODE_CLAMP, D3D12_TEXTURE_ADDRESS_MODE_CLAMP, D3D12_TEXTURE_ADDRESS_MODE_CLAMP);

    public static D3D12_SAMPLER_DESC AnisotropicWrap => new(D3D12_FILTER_ANISOTROPIC, D3D12_TEXTURE_ADDRESS_MODE_WRAP, D3D12_TEXTURE_ADDRESS_MODE_WRAP, D3D12_TEXTURE_ADDRESS_MODE_WRAP, 0.0f, D3D12_MAX_MAXANISOTROPY);
    public static D3D12_SAMPLER_DESC AnisotropicClamp => new(D3D12_FILTER_ANISOTROPIC, D3D12_TEXTURE_ADDRESS_MODE_CLAMP, D3D12_TEXTURE_ADDRESS_MODE_CLAMP, D3D12_TEXTURE_ADDRESS_MODE_CLAMP, 0.0f, D3D12_MAX_MAXANISOTROPY);

    /// <summary>
    /// Initializes a new instance of the <see cref="D3D12_SAMPLER_DESC"/> struct.
    /// </summary>
    /// <param name="filter">Filtering method to use when sampling a texture.</param>
    /// <param name="addressU">Method to use for resolving a u texture coordinate that is outside the 0 to 1 range.</param>
    /// <param name="addressV">Method to use for resolving a v texture coordinate that is outside the 0 to 1 range.</param>
    /// <param name="addressW">Method to use for resolving a w texture coordinate that is outside the 0 to 1 range.</param>
    /// <param name="mipLODBias">Offset from the calculated mipmap level.</param>
    /// <param name="maxAnisotropy">Clamping value used if <see cref="D3D12_FILTER_ANISOTROPIC"/> or <see cref="D3D12_FILTER_COMPARISON_ANISOTROPIC"/> is specified in Filter. Valid values are between 1 and 16.</param>
    /// <param name="comparisonFunction">A function that compares sampled data against existing sampled data. </param>
    /// <param name="borderColor">Border color to use if <see cref="D3D12_TEXTURE_ADDRESS_MODE_BORDER"/> is specified for AddressU, AddressV, or AddressW.</param>
    /// <param name="minLOD">Lower end of the mipmap range to clamp access to, where 0 is the largest and most detailed mipmap level and any level higher than that is less detailed.</param>
    /// <param name="maxLOD">Upper end of the mipmap range to clamp access to, where 0 is the largest and most detailed mipmap level and any level higher than that is less detailed. This value must be greater than or equal to MinLOD. </param>
    public unsafe D3D12_SAMPLER_DESC(
        D3D12_FILTER filter,
        D3D12_TEXTURE_ADDRESS_MODE addressU,
        D3D12_TEXTURE_ADDRESS_MODE addressV,
        D3D12_TEXTURE_ADDRESS_MODE addressW,
        float mipLODBias,
        uint maxAnisotropy,
        D3D12_COMPARISON_FUNC comparisonFunction,
        Color4 borderColor,
        float minLOD,
        float maxLOD)
    {
        Filter = filter;
        AddressU = addressU;
        AddressV = addressV;
        AddressW = addressW;
        MipLODBias = mipLODBias;
        MaxAnisotropy = maxAnisotropy;
        ComparisonFunc = comparisonFunction;
        BorderColor[0] = borderColor.R;
        BorderColor[1] = borderColor.G;
        BorderColor[2] = borderColor.B;
        BorderColor[3] = borderColor.A;
        MinLOD = minLOD;
        MaxLOD = maxLOD;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="D3D12_SAMPLER_DESC"/> struct.
    /// </summary>
    /// <param name="filter">Filtering method to use when sampling a texture.</param>
    /// <param name="addressU">Method to use for resolving a u texture coordinate that is outside the 0 to 1 range.</param>
    /// <param name="addressV">Method to use for resolving a v texture coordinate that is outside the 0 to 1 range.</param>
    /// <param name="addressW">Method to use for resolving a w texture coordinate that is outside the 0 to 1 range.</param>
    /// <param name="mipLODBias">Offset from the calculated mipmap level.</param>
    /// <param name="maxAnisotropy">Clamping value used if <see cref="D3D12_FILTER_ANISOTROPIC"/> or <see cref="D3D12_FILTER_COMPARISON_ANISOTROPIC"/> is specified in Filter. Valid values are between 1 and 16.</param>
    /// <param name="comparisonFunction">A function that compares sampled data against existing sampled data. </param>
    /// <param name="minLOD">Lower end of the mipmap range to clamp access to, where 0 is the largest and most detailed mipmap level and any level higher than that is less detailed.</param>
    /// <param name="maxLOD">Upper end of the mipmap range to clamp access to, where 0 is the largest and most detailed mipmap level and any level higher than that is less detailed. This value must be greater than or equal to MinLOD. </param>
    public unsafe D3D12_SAMPLER_DESC(
        D3D12_FILTER filter,
        D3D12_TEXTURE_ADDRESS_MODE addressU,
        D3D12_TEXTURE_ADDRESS_MODE addressV,
        D3D12_TEXTURE_ADDRESS_MODE addressW,
        float mipLODBias = 0.0f,
        uint maxAnisotropy = 1,
        D3D12_COMPARISON_FUNC comparisonFunction = D3D12_COMPARISON_FUNC_NEVER,
        float minLOD = float.MinValue,
        float maxLOD = float.MaxValue)
    {
        Filter = filter;
        AddressU = addressU;
        AddressV = addressV;
        AddressW = addressW;
        MipLODBias = mipLODBias;
        MaxAnisotropy = maxAnisotropy;
        ComparisonFunc = comparisonFunction;
        BorderColor[0] = 1.0f;
        BorderColor[1] = 1.0f;
        BorderColor[2] = 1.0f;
        BorderColor[3] = 1.0f;
        MinLOD = minLOD;
        MaxLOD = maxLOD;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="D3D12_SAMPLER_DESC"/> struct.
    /// </summary>
    /// <param name="filter">Filtering method to use when sampling a texture.</param>
    /// <param name="address">Method to use for resolving a u, v e w texture coordinate that is outside the 0 to 1 range.</param>
    /// <param name="mipLODBias">Offset from the calculated mipmap level.</param>
    /// <param name="maxAnisotropy">Clamping value used if <see cref="D3D12_FILTER_ANISOTROPIC"/> or <see cref="D3D12_FILTER_COMPARISON_ANISOTROPIC"/> is specified in Filter. Valid values are between 1 and 16.</param>
    /// <param name="comparisonFunction">A function that compares sampled data against existing sampled data. </param>
    /// <param name="minLOD">Lower end of the mipmap range to clamp access to, where 0 is the largest and most detailed mipmap level and any level higher than that is less detailed.</param>
    /// <param name="maxLOD">Upper end of the mipmap range to clamp access to, where 0 is the largest and most detailed mipmap level and any level higher than that is less detailed. This value must be greater than or equal to MinLOD. </param>
    public unsafe D3D12_SAMPLER_DESC(
        D3D12_FILTER filter,
        D3D12_TEXTURE_ADDRESS_MODE address,
        float mipLODBias = 0.0f,
        uint maxAnisotropy = 1,
        D3D12_COMPARISON_FUNC comparisonFunction = D3D12_COMPARISON_FUNC_NEVER,
        float minLOD = float.MinValue,
        float maxLOD = float.MaxValue)
    {
        Filter = filter;
        AddressU = address;
        AddressV = address;
        AddressW = address;
        MipLODBias = mipLODBias;
        MaxAnisotropy = maxAnisotropy;
        ComparisonFunc = comparisonFunction;
        BorderColor[0] = 1.0f;
        BorderColor[1] = 1.0f;
        BorderColor[2] = 1.0f;
        BorderColor[3] = 1.0f;
        MinLOD = minLOD;
        MaxLOD = maxLOD;
    }
}
