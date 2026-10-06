// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Graphics;

public unsafe partial struct D3D12_SUBRESOURCE_RANGE_UINT64
{
    public D3D12_SUBRESOURCE_RANGE_UINT64(uint subresource, D3D12_RANGE_UINT64* range)
    {
        Subresource = subresource;
        Range = *range;
    }

    public D3D12_SUBRESOURCE_RANGE_UINT64(uint subresource, ulong begin, ulong end)
    {
        Subresource = subresource;
        Range.Begin = begin;
        Range.End = end;
    }
}
