// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D12;

public unsafe partial struct SubresourceRangeUInt64
{
    public SubresourceRangeUInt64(uint subresource, RangeUInt64* range)
    {
        Subresource = subresource;
        Range = *range;
    }

    public SubresourceRangeUInt64(uint subresource, ulong begin, ulong end)
    {
        Subresource = subresource;
        Range.Begin = begin;
        Range.End = end;
    }
}
