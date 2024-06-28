﻿// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

#pragma warning disable CS0169

namespace Win32.Com;

/// <summary>
/// Variant COM.
/// </summary>
/// <unmanaged>PROPVARIANT</unmanaged>
[NativeTypeName("struct PROPVARIANT")]
public unsafe partial struct Variant
{
    private VariantFullType vt;
    private readonly ushort reserved1;
    private readonly ushort reserved2;
    private readonly ushort reserved3;
    private VariantValue variantValue;

    /// <summary>
    /// Gets the type of the element.
    /// </summary>
    /// <value>
    /// The type of the element.
    /// </value>
    public VariantElementType ElementType
    {
        get => vt.ElementType;
        set => vt = new(value, vt.Type);
    }

    /// <summary>
    /// Gets the type.
    /// </summary>
    public VariantType Type
    {
        get => vt.Type;
        set => vt = new(vt.ElementType, value);
    }

#if TODO
    /// <summary>
    /// Gets or sets the value.
    /// </summary>
    /// <value>
    /// The value.
    /// </value>
    public unsafe object Value
    {
        get
        {
            switch (Type)
            {
                case VariantType.Default:
                    switch (ElementType)
                    {
                        case VariantElementType.Empty:
                        case VariantElementType.Null:
                            return null;
                        case VariantElementType.Blob:
                            {
                                var buffer = new byte[(int)variantValue.recordValue.RecordInfo];
                                if (buffer.Length > 0)
                                {
                                    MemoryHelpers.Read<byte>(variantValue.recordValue.RecordPointer, buffer,
                                                             buffer.Length);
                                }

                                return buffer;
                            }
                        case VariantElementType.Bool:
                            return variantValue.intValue != 0;
                        case VariantElementType.Byte:
                            return variantValue.signedByteValue;
                        case VariantElementType.UByte:
                            return variantValue.byteValue;
                        case VariantElementType.UShort:
                            return variantValue.ushortValue;
                        case VariantElementType.Short:
                            return variantValue.shortValue;
                        case VariantElementType.UInt:
                        case VariantElementType.UInt1:
                            return variantValue.uintValue;
                        case VariantElementType.Int:
                        case VariantElementType.Int1:
                            return variantValue.intValue;
                        case VariantElementType.ULong:
                            return variantValue.ulongValue;
                        case VariantElementType.Long:
                            return variantValue.longValue;
                        case VariantElementType.Float:
                            return variantValue.floatValue;
                        case VariantElementType.Double:
                            return variantValue.doubleValue;
                        case VariantElementType.BinaryString:
                            throw new NotSupportedException();
                        case VariantElementType.StringPointer:
                            return Marshal.PtrToStringAnsi(variantValue.pointerValue);
                        case VariantElementType.WStringPointer:
                            return Marshal.PtrToStringUni(variantValue.pointerValue);
                        case VariantElementType.ComUnknown:
                        case VariantElementType.Dispatch:
                            return new ComObject(variantValue.pointerValue);
                        case VariantElementType.IntPointer:
                        case VariantElementType.Pointer:
                            return variantValue.pointerValue;
                        case VariantElementType.FileTime:
                            return DateTime.FromFileTime(variantValue.longValue);
                        default:
                            return null;
                    }
                case VariantType.Vector:
                    var size = (int)variantValue.recordValue.RecordInfo;
                    var recordValuePointer = variantValue.recordValue.RecordPointer;
                    switch (ElementType)
                    {
                        case VariantElementType.Bool:
                            {
                                Span<Bool32> span = stackalloc Bool32[size];
                                MemoryHelpers.Read<Bool32>(recordValuePointer, span, size);
                                return BooleanHelpers.ConvertToBoolArray(span);
                            }
                        case VariantElementType.Byte:
                            {
                                var array = new sbyte[size];
                                MemoryHelpers.Read<sbyte>(recordValuePointer, array, size);
                                return array;
                            }
                        case VariantElementType.UByte:
                            {
                                var array = new byte[size];
                                MemoryHelpers.Read<byte>(recordValuePointer, array, size);
                                return array;
                            }
                        case VariantElementType.UShort:
                            {
                                var array = new ushort[size];
                                MemoryHelpers.Read<ushort>(recordValuePointer, array, size);
                                return array;
                            }
                        case VariantElementType.Short:
                            {
                                var array = new short[size];
                                MemoryHelpers.Read<short>(recordValuePointer, array, size);
                                return array;
                            }
                        case VariantElementType.UInt:
                        case VariantElementType.UInt1:
                            {
                                var array = new uint[size];
                                MemoryHelpers.Read<uint>(recordValuePointer, array, size);
                                return array;
                            }
                        case VariantElementType.Int:
                        case VariantElementType.Int1:
                            {
                                var array = new int[size];
                                MemoryHelpers.Read<int>(recordValuePointer, array, size);
                                return array;
                            }
                        case VariantElementType.ULong:
                            {
                                var array = new ulong[size];
                                MemoryHelpers.Read<ulong>(recordValuePointer, array, size);
                                return array;
                            }
                        case VariantElementType.Long:
                            {
                                var array = new long[size];
                                MemoryHelpers.Read<long>(recordValuePointer, array, size);
                                return array;
                            }
                        case VariantElementType.Float:
                            {
                                var array = new float[size];
                                MemoryHelpers.Read<float>(recordValuePointer, array, size);
                                return array;
                            }
                        case VariantElementType.Double:
                            {
                                var array = new double[size];
                                MemoryHelpers.Read<double>(recordValuePointer, array, size);
                                return array;
                            }
                        case VariantElementType.BinaryString:
                            {
                                throw new NotSupportedException();
                            }
                        case VariantElementType.StringPointer:
                            {
                                var array = new string[size];
                                for (var i = 0; i < size; i++)
                                    array[i] = Marshal.PtrToStringAnsi(
                                        ((IntPtr*)recordValuePointer)[i]
                                    );
                                return array;
                            }
                        case VariantElementType.WStringPointer:
                            {
                                var array = new string[size];
                                for (var i = 0; i < size; i++)
                                    array[i] = Marshal.PtrToStringUni(
                                        ((IntPtr*)recordValuePointer)[i]
                                    );
                                return array;
                            }
                        case VariantElementType.ComUnknown:
                        case VariantElementType.Dispatch:
                            {
                                var comArray = new ComObject[size];
                                for (var i = 0; i < size; i++)
                                    comArray[i] = new ComObject(((IntPtr*)recordValuePointer)[i]);
                                return comArray;
                            }
                        case VariantElementType.IntPointer:
                        case VariantElementType.Pointer:
                            {
                                var array = new IntPtr[size];
                                MemoryHelpers.Read<IntPtr>(recordValuePointer, array, size);
                                return array;
                            }
                        case VariantElementType.FileTime:
                            {
                                var fileTimeArray = new DateTime[size];
                                for (var i = 0; i < size; i++)
                                    fileTimeArray[i] =
                                        DateTime.FromFileTime(((long*)recordValuePointer)[i]);
                                return fileTimeArray;
                            }
                        default:
                            return null;
                    }
            }

            return null;
        }
        set
        {
            if (value == null)
            {
                Type = VariantType.Default;
                ElementType = VariantElementType.Null;
                return;
            }

            var type = value.GetType();

            Type = VariantType.Default;
            if (type.GetType().IsPrimitive)
            {
                if (type == typeof(byte))
                {
                    ElementType = VariantElementType.UByte;
                    variantValue.byteValue = (byte)value;
                    return;
                }

                if (type == typeof(sbyte))
                {
                    ElementType = VariantElementType.Byte;
                    variantValue.signedByteValue = (sbyte)value;
                    return;
                }

                if (type == typeof(int))
                {
                    ElementType = VariantElementType.Int;
                    variantValue.intValue = (int)value;
                    return;
                }

                if (type == typeof(uint))
                {
                    ElementType = VariantElementType.UInt;
                    variantValue.uintValue = (uint)value;
                    return;
                }

                if (type == typeof(long))
                {
                    ElementType = VariantElementType.Long;
                    variantValue.longValue = (long)value;
                    return;
                }

                if (type == typeof(ulong))
                {
                    ElementType = VariantElementType.ULong;
                    variantValue.ulongValue = (ulong)value;
                    return;
                }

                if (type == typeof(short))
                {
                    ElementType = VariantElementType.Short;
                    variantValue.shortValue = (short)value;
                    return;
                }

                if (type == typeof(ushort))
                {
                    ElementType = VariantElementType.UShort;
                    variantValue.ushortValue = (ushort)value;
                    return;
                }

                if (type == typeof(float))
                {
                    ElementType = VariantElementType.Float;
                    variantValue.floatValue = (float)value;
                    return;
                }

                if (type == typeof(double))
                {
                    ElementType = VariantElementType.Double;
                    variantValue.doubleValue = (double)value;
                    return;
                }
            }
            else
            {
                switch (value)
                {
                    case ComObject obj:
                        ElementType = VariantElementType.ComUnknown;
                        variantValue.pointerValue = obj.NativePointer;
                        return;
                    case DateTime dateTime:
                        ElementType = VariantElementType.FileTime;
                        variantValue.longValue = dateTime.ToFileTime();
                        return;
                    case string str:
                        ElementType = VariantElementType.WStringPointer;
                        variantValue.pointerValue = Marshal.StringToCoTaskMemUni(str);
                        return;
                }
            }

            throw new ArgumentException(
                string.Format(CultureInfo.InvariantCulture, "Type [{0}] is not handled", type.Name)
            );
        }
    } 
#endif

    [StructLayout(LayoutKind.Explicit)]
    private struct VariantValue
    {
        [FieldOffset(0)] public sbyte signedByteValue;
        [FieldOffset(0)] public byte byteValue;
        [FieldOffset(0)] public short shortValue;
        [FieldOffset(0)] public ushort ushortValue;
        [FieldOffset(0)] public int intValue;
        [FieldOffset(0)] public uint uintValue;
        [FieldOffset(0)] public long longValue;
        [FieldOffset(0)] public ulong ulongValue;
        [FieldOffset(0)] public LargeInteger largeIntergerValue;
        [FieldOffset(0)] public ULargeInteger ulargeIntergerValue;
        [FieldOffset(0)] public float floatValue;
        [FieldOffset(0)] public double doubleValue;
        [FieldOffset(0)] public short boolValue;
        [FieldOffset(0)] public IntPtr pointerValue;
        [FieldOffset(0)] public IUnknown* unkownValue;
        [FieldOffset(0)] public IStream* pStream;
        [FieldOffset(0)] public CurrencyValue currencyValue;
        [FieldOffset(0)] public RecordValue recordValue;

        [StructLayout(LayoutKind.Sequential)]
        public struct CurrencyLowHigh
        {
            public uint LowValue;
            public int HighValue;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct CurrencyValue
        {
            [FieldOffset(0)] public CurrencyLowHigh LowHigh;
            [FieldOffset(0)] public long longValue;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RecordValue
        {
            public IntPtr RecordInfo;
            public IntPtr RecordPointer;
        }
    }
}
