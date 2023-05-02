// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D12;

unsafe partial struct QueryHeapDescription
{
    public QueryHeapDescription(QueryHeapType type, uint count, uint nodeMask = 0)
    {
        Type = type;
        Count = count;
        NodeMask = nodeMask;
    }
}
