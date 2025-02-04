// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.D3D12MemoryAllocator;

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct Pool : IEquatable<Pool>
{
    public Pool(nint handle) { Handle = handle; }
    public nint Handle { get; }
    public bool IsNull => Handle == 0;
    public bool IsNotNull => Handle != 0;
    public static Pool Null => new(0);
    public static implicit operator Pool(nint handle) => new(handle);
    public static implicit operator nint(Pool handle) => handle.Handle;
    public static bool operator ==(Pool left, Pool right) => left.Handle == right.Handle;
    public static bool operator !=(Pool left, Pool right) => left.Handle != right.Handle;
    public static bool operator ==(Pool left, nint right) => left.Handle == right;
    public static bool operator !=(Pool left, nint right) => left.Handle != right;
    public bool Equals(Pool other) => Handle == other.Handle;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is Pool handle && Equals(handle);
    /// <inheritdoc/>
    public override int GetHashCode() => Handle.GetHashCode();
    private string DebuggerDisplay => $"{nameof(Pool)} [0x{Handle:X}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct VirtualBlock : IEquatable<VirtualBlock>
{
    public VirtualBlock(nint handle) { Handle = handle; }
    public nint Handle { get; }
    public bool IsNull => Handle == 0;
    public bool IsNotNull => Handle != 0;
    public static VirtualBlock Null => new(0);
    public static implicit operator VirtualBlock(nint handle) => new(handle);
    public static implicit operator nint(VirtualBlock handle) => handle.Handle;
    public static bool operator ==(VirtualBlock left, VirtualBlock right) => left.Handle == right.Handle;
    public static bool operator !=(VirtualBlock left, VirtualBlock right) => left.Handle != right.Handle;
    public static bool operator ==(VirtualBlock left, nint right) => left.Handle == right;
    public static bool operator !=(VirtualBlock left, nint right) => left.Handle != right;
    public bool Equals(VirtualBlock other) => Handle == other.Handle;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is VirtualBlock handle && Equals(handle);
    /// <inheritdoc/>
    public override int GetHashCode() => Handle.GetHashCode();
    private string DebuggerDisplay => $"{nameof(VirtualBlock)} [0x{Handle:X}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct DefragmentationContext : IEquatable<DefragmentationContext>
{
    public DefragmentationContext(nint handle) { Handle = handle; }
    public nint Handle { get; }
    public bool IsNull => Handle == 0;
    public bool IsNotNull => Handle != 0;
    public static DefragmentationContext Null => new(0);
    public static implicit operator DefragmentationContext(nint handle) => new(handle);
    public static implicit operator nint(DefragmentationContext handle) => handle.Handle;
    public static bool operator ==(DefragmentationContext left, DefragmentationContext right) => left.Handle == right.Handle;
    public static bool operator !=(DefragmentationContext left, DefragmentationContext right) => left.Handle != right.Handle;
    public static bool operator ==(DefragmentationContext left, nint right) => left.Handle == right;
    public static bool operator !=(DefragmentationContext left, nint right) => left.Handle != right;
    public bool Equals(DefragmentationContext other) => Handle == other.Handle;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is DefragmentationContext handle && Equals(handle);
    /// <inheritdoc/>
    public override int GetHashCode() => Handle.GetHashCode();
    private string DebuggerDisplay => $"{nameof(DefragmentationContext)} [0x{Handle:X}]";
}
