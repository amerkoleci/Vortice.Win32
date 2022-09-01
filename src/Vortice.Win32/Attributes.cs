// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.
// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Diagnostics;

namespace Win32;

/// <summary>Defines the type of a member as it was used in the native signature.</summary>
[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = false, Inherited = true)]
[Conditional("DEBUG")]
internal sealed partial class NativeTypeNameAttribute : Attribute
{
    /// <summary>Initializes a new instance of the <see cref="NativeTypeNameAttribute" /> class.</summary>
    /// <param name="name">The name of the type that was used in the native signature.</param>
    public NativeTypeNameAttribute(string name)
    {
        Name = name;
    }

    /// <summary>Gets the name of the type that was used in the native signature.</summary>
    public string Name { get; }
}

/// <summary>Defines the vtbl index of a method as it was in the native signature.</summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
[Conditional("DEBUG")]
internal sealed partial class VtblIndexAttribute : Attribute
{
    /// <summary>Initializes a new instance of the <see cref="VtblIndexAttribute" /> class.</summary>
    /// <param name="index">The vtbl index of a method as it was in the native signature.</param>
    public VtblIndexAttribute(uint index)
    {
        Index = index;
    }

    /// <summary>Gets the vtbl index of a method as it was in the native signature.</summary>
    public uint Index { get; }
}
