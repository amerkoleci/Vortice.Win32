// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32;

[StructLayout(LayoutKind.Explicit)]
[NativeTypeName("LARGE_INTEGER")]
public partial struct LargeInteger
{
    [FieldOffset(0)]
    public _Anonymous_e__Struct Anonymous;

    [FieldOffset(0)]
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
            return ref Anonymous.LowPart;
        }
    }

    [UnscopedRef]
    public ref int HighPart
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.HighPart;
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

    public static implicit operator long(LargeInteger value) => value.QuadPart;

    public static implicit operator LargeInteger(long value)
    {
        Unsafe.SkipInit(out LargeInteger result);
        result.QuadPart = value;
        return result;
    }
}
