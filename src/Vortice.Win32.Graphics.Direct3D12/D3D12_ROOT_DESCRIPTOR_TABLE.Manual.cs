// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Graphics;

public unsafe partial struct D3D12_ROOT_DESCRIPTOR_TABLE
{
    public D3D12_ROOT_DESCRIPTOR_TABLE(uint numDescriptorRanges, [NativeTypeName("const D3D12_DESCRIPTOR_RANGE *")] D3D12_DESCRIPTOR_RANGE* _pDescriptorRanges)
    {
        Init(numDescriptorRanges, _pDescriptorRanges);
    }

    public void Init(uint numDescriptorRanges, [NativeTypeName("const D3D12_DESCRIPTOR_RANGE *")] D3D12_DESCRIPTOR_RANGE* _pDescriptorRanges)
    {
        Init(ref this, numDescriptorRanges, _pDescriptorRanges);
    }

    public static void Init([NativeTypeName("D3D12_ROOT_DESCRIPTOR_TABLE &")] ref D3D12_ROOT_DESCRIPTOR_TABLE rootDescriptorTable, uint numDescriptorRanges, [NativeTypeName("const D3D12_DESCRIPTOR_RANGE *")] D3D12_DESCRIPTOR_RANGE* _pDescriptorRanges)
    {
        rootDescriptorTable.NumDescriptorRanges = numDescriptorRanges;
        rootDescriptorTable.pDescriptorRanges = _pDescriptorRanges;
    }
}
