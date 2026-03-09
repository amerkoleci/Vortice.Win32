// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Vortice.Win32;

/// <unmanaged>HANDLE</unmanaged>
public readonly unsafe partial struct Handle(void* value) : IComparable, IComparable<Handle>, IEquatable<Handle>, IFormattable
{
    public readonly void* Value = value;

    public static Handle InvalidValue => new((void*)(-1));

    public static Handle Null => new(null);

    public static bool operator ==(Handle left, Handle right) => left.Value == right.Value;

    public static bool operator !=(Handle left, Handle right) => left.Value != right.Value;

    public static bool operator <(Handle left, Handle right) => left.Value < right.Value;

    public static bool operator <=(Handle left, Handle right) => left.Value <= right.Value;

    public static bool operator >(Handle left, Handle right) => left.Value > right.Value;

    public static bool operator >=(Handle left, Handle right) => left.Value >= right.Value;

    public static explicit operator Handle(void* value) => new(value);

    public static implicit operator void*(Handle value) => value.Value;

    public static explicit operator Handle(byte value) => new(unchecked((void*)(value)));

    public static explicit operator byte(Handle value) => (byte)(value.Value);

    public static explicit operator Handle(short value) => new(unchecked((void*)(value)));

    public static explicit operator short(Handle value) => (short)(value.Value);

    public static explicit operator Handle(int value) => new(unchecked((void*)(value)));

    public static explicit operator int(Handle value) => (int)(value.Value);

    public static explicit operator Handle(long value) => new(unchecked((void*)(value)));

    public static explicit operator long(Handle value) => (long)(value.Value);

    public static explicit operator Handle(nint value) => new(unchecked((void*)(value)));

    public static implicit operator nint(Handle value) => (nint)(value.Value);

    public static explicit operator Handle(sbyte value) => new(unchecked((void*)(value)));

    public static explicit operator sbyte(Handle value) => (sbyte)(value.Value);

    public static explicit operator Handle(ushort value) => new(unchecked((void*)(value)));

    public static explicit operator ushort(Handle value) => (ushort)(value.Value);

    public static explicit operator Handle(uint value) => new(unchecked((void*)(value)));

    public static explicit operator uint(Handle value) => (uint)(value.Value);

    public static explicit operator Handle(ulong value) => new(unchecked((void*)(value)));

    public static explicit operator ulong(Handle value) => (ulong)(value.Value);

    public static explicit operator Handle(nuint value) => new(unchecked((void*)(value)));

    public static implicit operator nuint(Handle value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Handle other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HANDLE.");
    }

    public int CompareTo(Handle other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Handle other) && Equals(other);

    public bool Equals(Handle other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
