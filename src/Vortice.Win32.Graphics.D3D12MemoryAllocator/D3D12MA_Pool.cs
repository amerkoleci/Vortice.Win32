// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Graphics.D3D12MemoryAllocator;

public readonly record struct D3D12MA_Pool(nint Handle)
{
    public bool IsNull => Handle == 0;
    public static D3D12MA_Pool Null => default;
}
