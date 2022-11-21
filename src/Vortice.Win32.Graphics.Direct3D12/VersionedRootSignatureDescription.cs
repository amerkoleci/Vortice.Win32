// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Dxgi.Common;
using static Win32.Graphics.Direct3D12.Apis;

namespace Win32.Graphics.Direct3D12;

public unsafe partial struct VersionedRootSignatureDescription
{
    public VersionedRootSignatureDescription(in RootSignatureDescription other)
    {
        Unsafe.SkipInit(out this);

        Version = RootSignatureVersion.V1_0;
        Anonymous.Desc_1_0 = other;
    }

    public VersionedRootSignatureDescription(in RootSignatureDescription1 other)
    {
        Unsafe.SkipInit(out this);

        Version = RootSignatureVersion.V1_1;
        Anonymous.Desc_1_1 = other;
    }

    public VersionedRootSignatureDescription(uint numParameters, RootParameter* _pParameters, uint numStaticSamplers = 0, StaticSamplerDescription* _pStaticSamplers = null, RootSignatureFlags flags = RootSignatureFlags.None)
    {
        Init_1_0(out this, numParameters, _pParameters, numStaticSamplers, _pStaticSamplers, flags);
    }

    public VersionedRootSignatureDescription(uint numParameters, RootParameter1* _pParameters, uint numStaticSamplers = 0, StaticSamplerDescription* _pStaticSamplers = null, RootSignatureFlags flags = RootSignatureFlags.None)
    {
        Init_1_1(out this, numParameters, _pParameters, numStaticSamplers, _pStaticSamplers, flags);
    }

    public void Init_1_0(
        uint numParameters, RootParameter* parameters,
        uint numStaticSamplers = 0, StaticSamplerDescription* staticSamplers = null,
        RootSignatureFlags flags = RootSignatureFlags.None)
    {
        Init_1_0(out this, numParameters, parameters, numStaticSamplers, staticSamplers, flags);
    }

    public static void Init_1_0(out VersionedRootSignatureDescription desc,
        uint numParameters, RootParameter* parameters,
        uint numStaticSamplers = 0, StaticSamplerDescription* staticSamplers = null,
        RootSignatureFlags flags = RootSignatureFlags.None)
    {
        desc = default;

        desc.Version = RootSignatureVersion.V1_0;
        desc.Anonymous.Desc_1_0.NumParameters = numParameters;
        desc.Anonymous.Desc_1_0.pParameters = parameters;
        desc.Anonymous.Desc_1_0.NumStaticSamplers = numStaticSamplers;
        desc.Anonymous.Desc_1_0.pStaticSamplers = staticSamplers;
        desc.Anonymous.Desc_1_0.Flags = flags;
    }

    public void Init_1_1(
        uint numParameters, RootParameter1* parameters,
        uint numStaticSamplers = 0, StaticSamplerDescription* staticSamplers = null,
        RootSignatureFlags flags = RootSignatureFlags.None)
    {
        Init_1_1(out this, numParameters, parameters, numStaticSamplers, staticSamplers, flags);
    }

    public static void Init_1_1(
        out VersionedRootSignatureDescription desc,
        uint numParameters, RootParameter1* parameters,
        uint numStaticSamplers = 0, StaticSamplerDescription* staticSamplers = null,
        RootSignatureFlags flags = RootSignatureFlags.None)
    {
        desc = default;

        desc.Version = RootSignatureVersion.V1_1;
        desc.Anonymous.Desc_1_1.NumParameters = numParameters;
        desc.Anonymous.Desc_1_1.pParameters = parameters;
        desc.Anonymous.Desc_1_1.NumStaticSamplers = numStaticSamplers;
        desc.Anonymous.Desc_1_1.pStaticSamplers = staticSamplers;
        desc.Anonymous.Desc_1_1.Flags = flags;
    }
}
