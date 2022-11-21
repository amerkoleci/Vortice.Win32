// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Win32.Graphics.Direct3D12.Apis;

namespace Win32.Graphics.Direct3D12;

public unsafe partial struct DescriptorRange1
{
    public DescriptorRange1(DescriptorRangeType rangeType, uint numDescriptors, uint baseShaderRegister, uint registerSpace = 0, DescriptorRangeFlags flags = DescriptorRangeFlags.None, uint offsetInDescriptorsFromTableStart = D3D12_DESCRIPTOR_RANGE_OFFSET_APPEND)
    {
        Init(out this, rangeType, numDescriptors, baseShaderRegister, registerSpace, flags, offsetInDescriptorsFromTableStart);
    }

    public void Init(DescriptorRangeType rangeType, uint numDescriptors, uint baseShaderRegister, uint registerSpace = 0, DescriptorRangeFlags flags = DescriptorRangeFlags.None, uint offsetInDescriptorsFromTableStart = D3D12_DESCRIPTOR_RANGE_OFFSET_APPEND)
    {
        Init(out this, rangeType, numDescriptors, baseShaderRegister, registerSpace, flags, offsetInDescriptorsFromTableStart);
    }

    public static void Init(out DescriptorRange1 range, DescriptorRangeType rangeType, uint numDescriptors, uint baseShaderRegister, uint registerSpace = 0, DescriptorRangeFlags flags = DescriptorRangeFlags.None, uint offsetInDescriptorsFromTableStart = D3D12_DESCRIPTOR_RANGE_OFFSET_APPEND)
    {
        range.RangeType = rangeType;
        range.NumDescriptors = numDescriptors;
        range.BaseShaderRegister = baseShaderRegister;
        range.RegisterSpace = registerSpace;
        range.Flags = flags;
        range.OffsetInDescriptorsFromTableStart = offsetInDescriptorsFromTableStart;
    }
}
