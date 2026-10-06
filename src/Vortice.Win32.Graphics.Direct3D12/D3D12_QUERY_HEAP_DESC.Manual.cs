// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Graphics;

unsafe partial struct D3D12_QUERY_HEAP_DESC
{
    public D3D12_QUERY_HEAP_DESC(D3D12_QUERY_HEAP_TYPE type, uint count, uint nodeMask = 0)
    {
        Type = type;
        Count = count;
        NodeMask = nodeMask;
    }
}
