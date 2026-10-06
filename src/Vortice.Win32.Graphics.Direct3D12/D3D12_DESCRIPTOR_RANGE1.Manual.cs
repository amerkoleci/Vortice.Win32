// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D3D12;

namespace Vortice.Win32.Graphics;

public unsafe partial struct D3D12_DESCRIPTOR_RANGE1
{
    public D3D12_DESCRIPTOR_RANGE1(D3D12_DESCRIPTOR_RANGE_TYPE rangeType, uint numDescriptors, uint baseShaderRegister, uint registerSpace = 0, D3D12_DESCRIPTOR_RANGE_FLAGS flags = D3D12_DESCRIPTOR_RANGE_FLAG_NONE, uint offsetInDescriptorsFromTableStart = (0xffffffff))
    {
        Init(rangeType, numDescriptors, baseShaderRegister, registerSpace, flags, offsetInDescriptorsFromTableStart);
    }

    public void Init(D3D12_DESCRIPTOR_RANGE_TYPE rangeType, uint numDescriptors, uint baseShaderRegister, uint registerSpace = 0, D3D12_DESCRIPTOR_RANGE_FLAGS flags = D3D12_DESCRIPTOR_RANGE_FLAG_NONE, uint offsetInDescriptorsFromTableStart = (0xffffffff))
    {
        Init(ref this, rangeType, numDescriptors, baseShaderRegister, registerSpace, flags, offsetInDescriptorsFromTableStart);
    }

    public static void Init([NativeTypeName("D3D12_DESCRIPTOR_RANGE1 &")] ref D3D12_DESCRIPTOR_RANGE1 range, D3D12_DESCRIPTOR_RANGE_TYPE rangeType, uint numDescriptors, uint baseShaderRegister, uint registerSpace = 0, D3D12_DESCRIPTOR_RANGE_FLAGS flags = D3D12_DESCRIPTOR_RANGE_FLAG_NONE, uint offsetInDescriptorsFromTableStart = (0xffffffff))
    {
        range.RangeType = rangeType;
        range.NumDescriptors = numDescriptors;
        range.BaseShaderRegister = baseShaderRegister;
        range.RegisterSpace = registerSpace;
        range.Flags = flags;
        range.OffsetInDescriptorsFromTableStart = offsetInDescriptorsFromTableStart;
    }
}
