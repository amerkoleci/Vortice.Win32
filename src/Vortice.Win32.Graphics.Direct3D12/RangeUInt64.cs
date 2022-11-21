// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Dxgi.Common;

namespace Win32.Graphics.Direct3D12;

public partial struct RangeUInt64
{
    public RangeUInt64(ulong begin, ulong end)
    {
        Begin = begin;
        End = end;
    }
}
