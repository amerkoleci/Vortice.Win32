// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D3D12;

namespace Vortice.Win32.Graphics;

public unsafe partial struct D3D12_VERSIONED_ROOT_SIGNATURE_DESC
{
    public static ref readonly D3D12_VERSIONED_ROOT_SIGNATURE_DESC DEFAULT
    {
        get
        {
            ReadOnlySpan<byte> data;

            if (Environment.Is64BitProcess)
            {
                data = [
                    0x02, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00
                ];
            }
            else
            {
                data = [
                    0x02, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00
                ];
            }

            Debug.Assert(data.Length == Unsafe.SizeOf<D3D12_VERSIONED_ROOT_SIGNATURE_DESC>());
            return ref Unsafe.As<byte, D3D12_VERSIONED_ROOT_SIGNATURE_DESC>(ref MemoryMarshal.GetReference(data));
        }
    }

    public D3D12_VERSIONED_ROOT_SIGNATURE_DESC([NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC &")] in D3D12_ROOT_SIGNATURE_DESC o)
    {
        Version = D3D_ROOT_SIGNATURE_VERSION_1_0;
        Anonymous.Desc_1_0 = o;
    }

    public D3D12_VERSIONED_ROOT_SIGNATURE_DESC([NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC1 &")] in D3D12_ROOT_SIGNATURE_DESC1 o)
    {
        Version = D3D_ROOT_SIGNATURE_VERSION_1_1;
        Anonymous.Desc_1_1 = o;
    }

    public D3D12_VERSIONED_ROOT_SIGNATURE_DESC([NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC2 &")] in D3D12_ROOT_SIGNATURE_DESC2 o)
    {
        Version = D3D_ROOT_SIGNATURE_VERSION_1_2;
        Anonymous.Desc_1_2 = o;
    }

    public D3D12_VERSIONED_ROOT_SIGNATURE_DESC(uint numParameters, [NativeTypeName("const D3D12_ROOT_PARAMETER *")] D3D12_ROOT_PARAMETER* _pParameters, uint numStaticSamplers = 0, [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")] D3D12_STATIC_SAMPLER_DESC* _pStaticSamplers = null, D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE)
    {
        Init_1_0(numParameters, _pParameters, numStaticSamplers, _pStaticSamplers, flags);
    }

    public D3D12_VERSIONED_ROOT_SIGNATURE_DESC(uint numParameters, [NativeTypeName("const D3D12_ROOT_PARAMETER1 *")] D3D12_ROOT_PARAMETER1* _pParameters, uint numStaticSamplers = 0, [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")] D3D12_STATIC_SAMPLER_DESC* _pStaticSamplers = null, D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE)
    {
        Init_1_1(numParameters, _pParameters, numStaticSamplers, _pStaticSamplers, flags);
    }

    public void Init_1_0(uint numParameters, [NativeTypeName("const D3D12_ROOT_PARAMETER *")] D3D12_ROOT_PARAMETER* _pParameters, uint numStaticSamplers = 0, [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")] D3D12_STATIC_SAMPLER_DESC* _pStaticSamplers = null, D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE)
    {
        Init_1_0(ref this, numParameters, _pParameters, numStaticSamplers, _pStaticSamplers, flags);
    }

    public static void Init_1_0([NativeTypeName("D3D12_VERSIONED_ROOT_SIGNATURE_DESC &")] ref D3D12_VERSIONED_ROOT_SIGNATURE_DESC desc, uint numParameters, [NativeTypeName("const D3D12_ROOT_PARAMETER *")] D3D12_ROOT_PARAMETER* _pParameters, uint numStaticSamplers = 0, [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")] D3D12_STATIC_SAMPLER_DESC* _pStaticSamplers = null, D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE)
    {
        desc.Version = D3D_ROOT_SIGNATURE_VERSION_1_0;
        desc.Anonymous.Desc_1_0.NumParameters = numParameters;
        desc.Anonymous.Desc_1_0.pParameters = _pParameters;
        desc.Anonymous.Desc_1_0.NumStaticSamplers = numStaticSamplers;
        desc.Anonymous.Desc_1_0.pStaticSamplers = _pStaticSamplers;
        desc.Anonymous.Desc_1_0.Flags = flags;
    }

    public void Init_1_1(uint numParameters, [NativeTypeName("const D3D12_ROOT_PARAMETER1 *")] D3D12_ROOT_PARAMETER1* _pParameters, uint numStaticSamplers = 0, [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")] D3D12_STATIC_SAMPLER_DESC* _pStaticSamplers = null, D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE)
    {
        Init_1_1(ref this, numParameters, _pParameters, numStaticSamplers, _pStaticSamplers, flags);
    }

    public static void Init_1_1([NativeTypeName("D3D12_VERSIONED_ROOT_SIGNATURE_DESC &")] ref D3D12_VERSIONED_ROOT_SIGNATURE_DESC desc, uint numParameters, [NativeTypeName("const D3D12_ROOT_PARAMETER1 *")] D3D12_ROOT_PARAMETER1* _pParameters, uint numStaticSamplers = 0, [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")] D3D12_STATIC_SAMPLER_DESC* _pStaticSamplers = null, D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE)
    {
        desc.Version = D3D_ROOT_SIGNATURE_VERSION_1_1;
        desc.Anonymous.Desc_1_1.NumParameters = numParameters;
        desc.Anonymous.Desc_1_1.pParameters = _pParameters;
        desc.Anonymous.Desc_1_1.NumStaticSamplers = numStaticSamplers;
        desc.Anonymous.Desc_1_1.pStaticSamplers = _pStaticSamplers;
        desc.Anonymous.Desc_1_1.Flags = flags;
    }

    public static void Init_1_2([NativeTypeName("D3D12_VERSIONED_ROOT_SIGNATURE_DESC &")] ref D3D12_VERSIONED_ROOT_SIGNATURE_DESC desc, uint numParameters, [NativeTypeName("const D3D12_ROOT_PARAMETER1 *")] D3D12_ROOT_PARAMETER1* _pParameters, uint numStaticSamplers = 0, [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC1 *")] D3D12_STATIC_SAMPLER_DESC1* _pStaticSamplers = null, D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE)
    {
        desc.Version = D3D_ROOT_SIGNATURE_VERSION_1_2;
        desc.Anonymous.Desc_1_2.NumParameters = numParameters;
        desc.Anonymous.Desc_1_2.pParameters = _pParameters;
        desc.Anonymous.Desc_1_2.NumStaticSamplers = numStaticSamplers;
        desc.Anonymous.Desc_1_2.pStaticSamplers = _pStaticSamplers;
        desc.Anonymous.Desc_1_2.Flags = flags;
    }
}
