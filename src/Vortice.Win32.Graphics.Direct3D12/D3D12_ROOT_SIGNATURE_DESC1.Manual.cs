// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D3D12;

namespace Vortice.Win32.Graphics;

public unsafe partial struct D3D12_ROOT_SIGNATURE_DESC1
{
    public D3D12_ROOT_SIGNATURE_DESC1(
        uint numParameters, D3D12_ROOT_PARAMETER1* parameters,
        uint numStaticSamplers = 0, D3D12_STATIC_SAMPLER_DESC* staticSamplers = null,
        D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE)
    {
        Init(ref this, numParameters, parameters, numStaticSamplers, staticSamplers, flags);
    }

    public void Init(
        uint numParameters, D3D12_ROOT_PARAMETER1* parameters,
        uint numStaticSamplers = 0, D3D12_STATIC_SAMPLER_DESC* staticSamplers = null,
        D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE)
    {
        Init(ref this, numParameters, parameters, numStaticSamplers, staticSamplers, flags);
    }

    public static void Init(
        ref D3D12_ROOT_SIGNATURE_DESC1 desc,
        uint numParameters, D3D12_ROOT_PARAMETER1* parameters,
        uint numStaticSamplers = 0, D3D12_STATIC_SAMPLER_DESC* staticSamplers = null,
        D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE)
    {
        desc.NumParameters = numParameters;
        desc.pParameters = parameters;
        desc.NumStaticSamplers = numStaticSamplers;
        desc.pStaticSamplers = staticSamplers;
        desc.Flags = flags;
    }
}
