// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Direct3D12;
using static Win32.Apis;
using static Win32.Graphics.D3D12MemoryAllocator.Apis;

namespace Win32.Graphics.D3D12MemoryAllocator;

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct Allocation : IEquatable<Allocation>
{
    public Allocation(nint handle) { Handle = handle; }
    public nint Handle { get; }
    public bool IsNull => Handle == 0;
    public bool IsNotNull => Handle != 0;
    public static Allocation Null => new(0);
    public static implicit operator Allocation(nint handle) => new(handle);
    public static implicit operator nint(Allocation handle) => handle.Handle;
    public static bool operator ==(Allocation left, Allocation right) => left.Handle == right.Handle;
    public static bool operator !=(Allocation left, Allocation right) => left.Handle != right.Handle;
    public static bool operator ==(Allocation left, nint right) => left.Handle == right;
    public static bool operator !=(Allocation left, nint right) => left.Handle != right;
    public bool Equals(Allocation other) => Handle == other.Handle;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Allocation handle && Equals(handle);
    /// <inheritdoc/>
    public override int GetHashCode() => Handle.GetHashCode();
    private string DebuggerDisplay => $"{nameof(Allocation)} [0x{Handle:X}]";

    public uint AddRef() => D3D12MA_Allocation_AddRef(Handle);
    public uint Release() => D3D12MA_Allocation_Release(Handle);
    public ulong Offset => D3D12MA_Allocation_GetOffset(Handle);
    public ulong Alignment => D3D12MA_Allocation_GetAlignment(Handle);
    public ulong Size => D3D12MA_Allocation_GetSize(Handle);
    public unsafe ID3D12Resource* Resource
    {
        get => D3D12MA_Allocation_GetResource(Handle);
        set => D3D12MA_Allocation_SetResource(Handle, value);
    }

    public unsafe ID3D12Heap* Heap => D3D12MA_Allocation_GetHeap(Handle);
}
