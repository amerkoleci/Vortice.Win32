// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D3D12;

namespace Vortice.Win32.Graphics;

public unsafe partial struct D3D12_DESCRIPTOR_RANGE
{
    public D3D12_DESCRIPTOR_RANGE(D3D12_DESCRIPTOR_RANGE_TYPE rangeType, uint numDescriptors, uint baseShaderRegister, uint registerSpace = 0, uint offsetInDescriptorsFromTableStart = (0xffffffff))
    {
        Init(rangeType, numDescriptors, baseShaderRegister, registerSpace, offsetInDescriptorsFromTableStart);
    }

    public void Init(D3D12_DESCRIPTOR_RANGE_TYPE rangeType, uint numDescriptors, uint baseShaderRegister, uint registerSpace = 0, uint offsetInDescriptorsFromTableStart = (0xffffffff))
    {
        Init(ref this, rangeType, numDescriptors, baseShaderRegister, registerSpace, offsetInDescriptorsFromTableStart);
    }

    public static void Init([NativeTypeName("D3D12_DESCRIPTOR_RANGE &")] ref D3D12_DESCRIPTOR_RANGE range, D3D12_DESCRIPTOR_RANGE_TYPE rangeType, uint numDescriptors, uint baseShaderRegister, uint registerSpace = 0, uint offsetInDescriptorsFromTableStart = (0xffffffff))
    {
        range.RangeType = rangeType;
        range.NumDescriptors = numDescriptors;
        range.BaseShaderRegister = baseShaderRegister;
        range.RegisterSpace = registerSpace;
        range.OffsetInDescriptorsFromTableStart = offsetInDescriptorsFromTableStart;
    }
}
