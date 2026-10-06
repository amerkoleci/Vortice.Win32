// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Vortice.Win32.Graphics.Direct3D12;
using static Vortice.Win32.Apis;
using static Vortice.Win32.Graphics.D3D12MemoryAllocator.Apis;

namespace Vortice.Win32.Graphics.D3D12MemoryAllocator;

public readonly record struct D3D12MA_Allocation(nint Handle)
{
    public bool IsNull => Handle == 0;
    public static D3D12MA_Allocation Null => default;

    public uint AddRef() => D3D12MA_Allocation_AddRef(this);
    public uint Release() => D3D12MA_Allocation_Release(this);
    public ulong Offset => D3D12MA_Allocation_GetOffset(this);
    public ulong Alignment => D3D12MA_Allocation_GetAlignment(this);
    public ulong Size => D3D12MA_Allocation_GetSize(this);
    public unsafe ID3D12Resource* Resource
    {
        get => D3D12MA_Allocation_GetResource(this);
        set => D3D12MA_Allocation_SetResource(this, value);
    }

    public unsafe ID3D12Heap* Heap => D3D12MA_Allocation_GetHeap(this);
}
