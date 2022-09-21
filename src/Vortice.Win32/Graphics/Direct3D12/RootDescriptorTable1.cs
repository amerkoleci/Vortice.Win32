// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D12;

public unsafe partial struct RootDescriptorTable1
{
    public RootDescriptorTable1(uint numDescriptorRanges, DescriptorRange1* descriptorRanges)
    {
        Init(out this, numDescriptorRanges, descriptorRanges);
    }

    public void Init(uint numDescriptorRanges, DescriptorRange1* descriptorRanges)
    {
        Init(out this, numDescriptorRanges, descriptorRanges);
    }

    public static void Init(out RootDescriptorTable1 rootDescriptorTable,
        uint numDescriptorRanges, DescriptorRange1* descriptorRanges)
    {
        rootDescriptorTable.NumDescriptorRanges = numDescriptorRanges;
        rootDescriptorTable.pDescriptorRanges = descriptorRanges;
    }
}
