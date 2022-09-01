// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

#if NETSTANDARD2_0
using MemoryMarshal = Win32.MemoryMarshal;
#endif

namespace Win32;

[StructLayout(LayoutKind.Explicit)]
[NativeTypeName("LARGE_INTEGER")]
public partial struct LargeInterger
{
    [FieldOffset(0)]
    public _Anonymous_e__Struct Anonymous;

    [FieldOffset(0)]
    [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um/winnt.h:879:5)")]
    public _u_e__Struct u;

    [FieldOffset(0)]
    [NativeTypeName("LONGLONG")]
    public long QuadPart;

    [UnscopedRef]
    public ref uint LowPart
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
#if NET7_0_OR_GREATER
            return ref Anonymous.LowPart;
#else
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.LowPart, 1));
#endif
        }
    }

    [UnscopedRef]
    public ref int HighPart
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
#if NET7_0_OR_GREATER
            return ref Anonymous.HighPart;
#else
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.HighPart, 1));
#endif
        }
    }

    public partial struct _Anonymous_e__Struct
    {
        [NativeTypeName("DWORD")]
        public uint LowPart;

        [NativeTypeName("LONG")]
        public int HighPart;
    }

    public partial struct _u_e__Struct
    {
        [NativeTypeName("DWORD")]
        public uint LowPart;
        [NativeTypeName("LONG")]
        public int HighPart;
    }
}
