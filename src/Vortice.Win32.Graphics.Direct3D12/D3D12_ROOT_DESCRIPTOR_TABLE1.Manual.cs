// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Graphics;

public unsafe partial struct D3D12_ROOT_DESCRIPTOR_TABLE1
{
    public D3D12_ROOT_DESCRIPTOR_TABLE1(uint numDescriptorRanges, [NativeTypeName("const D3D12_DESCRIPTOR_RANGE1 *")] D3D12_DESCRIPTOR_RANGE1* _pDescriptorRanges)
    {
        Init(numDescriptorRanges, _pDescriptorRanges);
    }

    public void Init(uint numDescriptorRanges, [NativeTypeName("const D3D12_DESCRIPTOR_RANGE1 *")] D3D12_DESCRIPTOR_RANGE1* _pDescriptorRanges)
    {
        Init(ref this, numDescriptorRanges, _pDescriptorRanges);
    }

    public static void Init([NativeTypeName("D3D12_ROOT_DESCRIPTOR_TABLE1 &")] ref D3D12_ROOT_DESCRIPTOR_TABLE1 rootDescriptorTable, uint numDescriptorRanges, [NativeTypeName("const D3D12_DESCRIPTOR_RANGE1 *")] D3D12_DESCRIPTOR_RANGE1* _pDescriptorRanges)
    {
        rootDescriptorTable.NumDescriptorRanges = numDescriptorRanges;
        rootDescriptorTable.pDescriptorRanges = _pDescriptorRanges;
    }
}
