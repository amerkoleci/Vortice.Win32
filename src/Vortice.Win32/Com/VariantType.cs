// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Com;

/// <summary>
/// Type of a variant
/// </summary>
[Flags]
public enum VariantType : ushort
{
    /// <summary>
    /// Simple value
    /// </summary>
    Default = 0x0000,

    /// <summary>
    /// Vector value.
    /// </summary>
    Vector = 0x1000,

    /// <summary>
    /// Array value.
    /// </summary>
    Array = 0x2000,

    /// <summary>
    /// By reference.
    /// </summary>
    ByRef = 0x4000,

    /// <summary>
    /// Reserved value.
    /// </summary>
    Reserved = 0x8000,
}
