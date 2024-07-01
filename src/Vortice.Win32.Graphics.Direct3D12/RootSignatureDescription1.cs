// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D12;

public unsafe partial struct RootSignatureDescription1
{
    public RootSignatureDescription1(
        uint numParameters, RootParameter1* parameters,
        uint numStaticSamplers = 0, StaticSamplerDescription* staticSamplers = null,
        RootSignatureFlags flags = RootSignatureFlags.None)
    {
        Init(out this, numParameters, parameters, numStaticSamplers, staticSamplers, flags);
    }

    public void Init(
        uint numParameters, RootParameter1* parameters,
        uint numStaticSamplers = 0, StaticSamplerDescription* staticSamplers = null,
        RootSignatureFlags flags = RootSignatureFlags.None)
    {
        Init(out this, numParameters, parameters, numStaticSamplers, staticSamplers, flags);
    }

    public static void Init(
        out RootSignatureDescription1 desc,
        uint numParameters, RootParameter1* parameters,
        uint numStaticSamplers = 0, StaticSamplerDescription* staticSamplers = null,
        RootSignatureFlags flags = RootSignatureFlags.None)
    {
        desc.NumParameters = numParameters;
        desc.pParameters = parameters;
        desc.NumStaticSamplers = numStaticSamplers;
        desc.pStaticSamplers = staticSamplers;
        desc.Flags = flags;
    }
}
