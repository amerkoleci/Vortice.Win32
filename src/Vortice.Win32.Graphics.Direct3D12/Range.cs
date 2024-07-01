// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Dxgi.Common;

namespace Win32.Graphics.Direct3D12;

public partial struct Range
{
    public Range(nuint begin, nuint end)
    {
        Begin = begin;
        End = end;
    }
}
