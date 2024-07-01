// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Win32.Graphics.Direct3D12.Apis;

namespace Win32.Graphics.Direct3D12;

public unsafe  partial struct DescriptorRange
{
    public DescriptorRange(DescriptorRangeType rangeType, uint numDescriptors, uint baseShaderRegister, uint registerSpace = 0, uint offsetInDescriptorsFromTableStart = D3D12_DESCRIPTOR_RANGE_OFFSET_APPEND)
    {
        Init(out this, rangeType, numDescriptors, baseShaderRegister, registerSpace, offsetInDescriptorsFromTableStart);
    }

    public void Init(DescriptorRangeType rangeType, uint numDescriptors, uint baseShaderRegister, uint registerSpace = 0, uint offsetInDescriptorsFromTableStart = D3D12_DESCRIPTOR_RANGE_OFFSET_APPEND)
    {
        Init(out this, rangeType, numDescriptors, baseShaderRegister, registerSpace, offsetInDescriptorsFromTableStart);
    }

    public static void Init(out DescriptorRange range, DescriptorRangeType rangeType, uint numDescriptors, uint baseShaderRegister, uint registerSpace = 0, uint offsetInDescriptorsFromTableStart = D3D12_DESCRIPTOR_RANGE_OFFSET_APPEND)
    {
        range.RangeType = rangeType;
        range.NumDescriptors = numDescriptors;
        range.BaseShaderRegister = baseShaderRegister;
        range.RegisterSpace = registerSpace;
        range.OffsetInDescriptorsFromTableStart = offsetInDescriptorsFromTableStart;
    }
}
