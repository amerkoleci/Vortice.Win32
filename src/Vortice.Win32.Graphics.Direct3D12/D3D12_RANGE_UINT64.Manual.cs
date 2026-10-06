// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Graphics;

public partial struct D3D12_RANGE_UINT64
{
    public D3D12_RANGE_UINT64(ulong begin, ulong end)
    {
        Begin = begin;
        End = end;
    }
}
