// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Com;

/// <summary>
/// Type of a simple variant value.
/// </summary>
public enum VariantElementType : ushort
{
    Empty = 0,
    Null = 1,
    Short = 2,
    Int = 3,
    Float = 4,
    Double = 5,
    Currency = 6,
    Date = 7,
    BinaryString = 8,
    Dispatch = 9,
    Error = 10,
    Bool = 11,
    Variant = 12,
    ComUnknown = 13,
    Decimal = 14,
    Byte = 16,
    UByte = 17,
    UShort = 18,
    UInt = 19,
    Long = 20,
    ULong = 21,
    Int1 = 22,
    UInt1 = 23,
    Void = 24,
    Result = 25,
    Pointer = 26,
    SafeArray = 27,
    ConstantArray = 28,
    UserDefined = 29,
    StringPointer = 30,
    WStringPointer = 31,
    Recor = 36,
    IntPointer = 37,
    UIntPointer = 38,
    FileTime = 64,
    Blob = 65,
    Stream = 66,
    Storage = 67,
    StreamedObject = 68,
    StoredObject = 69,
    BlobObject = 70,
    ClipData = 71,
    Clsid = 72,
    VersionedStream = 73,
    BinaryStringBlob = 0xfff,
}
