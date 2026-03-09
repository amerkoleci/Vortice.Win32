// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.
// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Diagnostics;

namespace Vortice.Win32;

/// <summary>Defines the type of a member as it was used in the native signature.</summary>
/// <remarks>Initializes a new instance of the <see cref="NativeTypeNameAttribute" /> class.</remarks>
/// <param name="name">The name of the type that was used in the native signature.</param>
[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = false, Inherited = true)]
[Conditional("DEBUG")]
internal sealed partial class NativeTypeNameAttribute(string name) : Attribute
{
    /// <summary>Gets the name of the type that was used in the native signature.</summary>
    public string Name { get; } = name;
}

/// <summary>Defines the base type of a struct as it was in the native signature.</summary>
/// <remarks>Initializes a new instance of the <see cref="NativeInheritanceAttribute" /> class.</remarks>
/// <param name="name">The name of the base type that was inherited from in the native signature.</param>
[AttributeUsage(AttributeTargets.Struct, AllowMultiple = false, Inherited = true)]
[Conditional("DEBUG")]
internal sealed partial class NativeInheritanceAttribute(string name) : Attribute
{
    /// <summary>Gets the name of the base type that was inherited from in the native signature.</summary>
    public string Name { get; } = name;
}

/// <summary>Defines the vtbl index of a method as it was in the native signature.</summary>
/// <remarks>Initializes a new instance of the <see cref="VtblIndexAttribute" /> class.</remarks>
/// <param name="index">The vtbl index of a method as it was in the native signature.</param>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
[Conditional("DEBUG")]
internal sealed partial class VtblIndexAttribute(uint index) : Attribute
{
    /// <summary>Gets the vtbl index of a method as it was in the native signature.</summary>
    public uint Index { get; } = index;
}
