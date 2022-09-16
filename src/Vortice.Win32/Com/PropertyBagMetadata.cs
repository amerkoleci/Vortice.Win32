// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Win32.StringUtilities;

namespace Win32.Com;

public enum PropertyBagMetadataType
{
    Undefined,
    Data,
    Url,
    Object,
    Stream,
    Storage,
    Moniker
}

/// <unmanaged>PROPBAG2</unmanaged>
[NativeTypeName("struct PROPBAG2")]
public unsafe partial struct PropertyBagMetadata
{
    public PropertyBagMetadataType Type;
    public VariantFullType VariantType;
    public ushort ClipboardFormat;
    public uint Hint;
    public ushort* pstrName;
    public Guid ClassId;

    public readonly string? GetName()
    {
        return GetString(pstrName);
    }
}
