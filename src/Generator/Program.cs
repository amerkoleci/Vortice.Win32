// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Linq;
using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;

namespace Generator;

public static class Program
{
    private static readonly string[] jsons = new[]
    {
        "Graphics.Dxgi.Common.json"
    };

    private static readonly Dictionary<string, string> s_csNameMappings = new()
    {
        {"Void", "void" },
        {"Byte", "byte" },
        {"SByte", "sbyte" },
        {"Int8", "sbyte" },
        {"Int16", "short" },
        {"Int32", "int" },
        {"Int64", "long" },
        {"UInt8", "byte" },
        {"UInt16", "ushort" },
        {"UInt32", "uint" },
        {"UInt64", "ulong" },
        {"Single", "float" },
        {"Double", "double" },

        { "BOOL", "Bool32" },
    };

    private static readonly Dictionary<string, string> s_knownTypesPrefixes = new()
    {
        { "DXGI_COLOR_SPACE_TYPE", "DXGI_COLOR_SPACE" },
    };

    private static readonly Dictionary<string, string> s_knownEnumValueNames = new()
    {
        { "DXGI_FORMAT_420_OPAQUE", "Opaque420" }
    };

    private static readonly HashSet<string> s_ignoredParts = new(StringComparer.OrdinalIgnoreCase)
    {
        "DXGI"
    };

    private static readonly HashSet<string> s_preserveCaps = new(StringComparer.OrdinalIgnoreCase)
    {
    };

    public static int Main(string[] args)
    {
        string outputPath = AppContext.BaseDirectory;
        if (args.Length > 0)
        {
            outputPath = args[0];
        }

        if (!Path.IsPathRooted(outputPath))
        {
            outputPath = Path.Combine(AppContext.BaseDirectory, outputPath);
        }

        if (!Directory.Exists(outputPath))
        {
            Directory.CreateDirectory(outputPath);
        }

        foreach (string jsonFile in jsons)
        {
            string outputFolder = Path.Combine(outputPath, "Graphics");
            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);
            }

            string finalPath = Path.Combine(AppContext.BaseDirectory, "win32json", "api", jsonFile);
            string jsonData = File.ReadAllText(finalPath);
            ApiData? api = JsonConvert.DeserializeObject<ApiData>(jsonData);
            Generate(api!, outputFolder);
        }

        return 0;
    }

    private static void Generate(ApiData api, string outputPath)
    {
        using var writer = new CodeWriter(
            Path.Combine(outputPath, "Dxgi.Common.cs"),
            "Win32.Graphics.Dxgi");

        GenerateConstants(writer, api);
        GenerateTypes(writer, api);
    }

    private static void GenerateConstants(CodeWriter writer, ApiData api)
    {
        using (writer.PushBlock($"public static partial class Apis"))
        {
            foreach (var constant in api.Constants)
            {
                if (ShouldSkipConstant(constant))
                    continue;

                string typeName = GetTypeName(constant.ValueType);
                writer.WriteLine($"public const {typeName} {constant.Name} = {constant.Value};");
            }
        }
        writer.WriteLine();
    }

    private static void GenerateTypes(CodeWriter writer, ApiData api)
    {
        writer.WriteLine($"#region Enums");
        foreach (ApiType enumType in api.Types.Where(item => item.Kind.ToLowerInvariant() == "enum"))
        {
            GenerateEnum(writer, enumType);
        }
        writer.WriteLine($"#endregion Enums");
        writer.WriteLine();

        writer.WriteLine($"#region Structs");
        foreach (ApiType structType in api.Types.Where(item => item.Kind.ToLowerInvariant() == "struct"))
        {
            GenerateStruct(writer, structType);
        }
        writer.WriteLine($"#endregion Structs");
        writer.WriteLine();
    }

    private static void GenerateEnum(CodeWriter writer, ApiType enumType)
    {
        if (enumType.Flags)
        {
            writer.WriteLine("[Flags]");
        }

        string csTypeName = GetDataTypeName(enumType.Name, out string enumPrefix);
        string baseTypeName = GetTypeName(enumType.IntegerBase);
        AddCsMapping(enumType.Name, csTypeName);

        writer.WriteLine($"/// <unmanaged>{enumType.Name}</unmanaged>");
        using (writer.PushBlock($"public enum {csTypeName} : {baseTypeName}"))
        {
            foreach (ApiEnumValue value in enumType.Values)
            {
                if (value.Name.EndsWith("_FORCE_DWORD") ||
                    value.Name.EndsWith("_FORCE_UINT"))
                    continue;

                string enumValueName = GetPrettyFieldName(value.Name, enumPrefix);
                writer.WriteLine($"/// <unmanaged>{value.Name}</unmanaged>");
                writer.WriteLine($"{enumValueName} = {value.Value},");
            }
        }

        writer.WriteLine();
    }

    private static void GenerateStruct(CodeWriter writer, ApiType structType)
    {
        string csTypeName = GetDataTypeName(structType.Name, out string structPrefix);
        AddCsMapping(structType.Name, csTypeName);

        writer.WriteLine($"/// <unmanaged>{structType.Name}</unmanaged>");
        using (writer.PushBlock($"public partial struct {csTypeName}"))
        {
            foreach (ApiStructField field in structType.Fields)
            {
                if (field.Name.EndsWith("_FORCE_DWORD"))
                    continue;

                string fieldValueName = GetPrettyFieldName(field.Name, structPrefix);
                string fieldTypeName = GetTypeName(field.Type);
                //writer.WriteLine($"/// <unmanaged>{field.Name}</unmanaged>");

                if (fieldTypeName == "Array")
                {
                    bool canUseFixed = false;
                    if (field.Type.Child.Kind == "Native")
                    {
                        canUseFixed = true;
                    }

                    fieldTypeName = GetTypeName(field.Type.Child);

                    if (canUseFixed)
                    {
                        writer.WriteLine($"public unsafe fixed {fieldTypeName} {fieldValueName}[{field.Type.Shape.Size}];");
                    }
                    else
                    {
                        writer.WriteLine($"public {fieldValueName}__FixedBuffer {fieldValueName};");
                        writer.WriteLine();

                        using (writer.PushBlock($"public unsafe struct {fieldValueName}__FixedBuffer"))
                        {
                            for (int i = 0; i < field.Type.Shape.Size; i++)
                            {
                                writer.WriteLine($"public {fieldTypeName} e{i};");
                            }
                            writer.WriteLine();

                            writer.WriteLine("[UnscopedRef]");
                            using (writer.PushBlock($"public ref {fieldTypeName} this[int index]"))
                            {
                                writer.WriteLine("[MethodImpl(MethodImplOptions.AggressiveInlining)]");
                                using (writer.PushBlock("get"))
                                {
                                    writer.WriteLine($"return ref AsSpan()[index];");
                                }
                            }
                            writer.WriteLine();

                            writer.WriteLine("[UnscopedRef]");
                            writer.WriteLine("[MethodImpl(MethodImplOptions.AggressiveInlining)]");
                            using (writer.PushBlock($"public Span<{fieldTypeName}> AsSpan()"))
                            {
                                writer.WriteUndindented("#if NET6_0_OR_GREATER");
                                writer.WriteLine($"return MemoryMarshal.CreateSpan(ref e0, {field.Type.Shape.Size});");
                                writer.WriteUndindented("#else");
                                writer.WriteLine($"return new(Unsafe.AsPointer(ref e0), {field.Type.Shape.Size});");
                                writer.WriteUndindented("#endif");
                            }
                        }
                    }
                }
                else
                {
                    writer.WriteLine($"public {fieldTypeName} {fieldValueName};");
                }
            }
        }

        writer.WriteLine();
    }

    private static bool ShouldSkipConstant(ApiDataConstant constant)
    {
        if (constant.Name == "_FACDXGI")
        {
            return true;
        }

        return false;
    }

    private static string GetDataTypeName(string typeName, out string prefix)
    {
        prefix = typeName;
        if (s_knownTypesPrefixes.TryGetValue(typeName, out string? knowPrefix))
        {
            prefix = knowPrefix!;
        }

        string[] parts = typeName.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries);

        var sb = new StringBuilder();
        foreach (string part in parts)
        {
            if (s_ignoredParts.Contains(part))
            {
                continue;
            }

            if (s_preserveCaps.Contains(part))
            {
                sb.Append(part);
            }
            else
            {
                if (part.Equals("DESC", StringComparison.OrdinalIgnoreCase))
                {
                    sb.Append("Description");
                }
                else
                {
                    sb.Append(char.ToUpper(part[0]));
                    for (int i = 1; i < part.Length; i++)
                    {
                        sb.Append(char.ToLower(part[i]));
                    }
                }
            }
        }

        string prettyName = sb.ToString();
        return (char.IsNumber(prettyName[0])) ? "_" + prettyName : prettyName;
    }

    private static string GetPrettyFieldName(string value, string enumPrefix)
    {
        if (s_knownEnumValueNames.TryGetValue(value, out string? knownName))
        {
            return knownName;
        }

        if (value.IndexOf(enumPrefix) != 0)
        {
            return value;
        }

        bool isDXGIFormat = enumPrefix == "DXGI_FORMAT";

        string[] parts = value[enumPrefix.Length..].Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries);

        var sb = new StringBuilder();
        foreach (string part in parts)
        {
            if (s_ignoredParts.Contains(part))
            {
                continue;
            }

            if (s_preserveCaps.Contains(part))
            {
                sb.Append(part);
            }
            else
            {
                if (isDXGIFormat)
                {
                    if (part.Equals("UNKNOWN", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("Unknown");
                    }
                    else if (part.Equals("TYPELESS", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("Typeless");
                    }
                    else if (part.Equals("UNORM", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("Unorm");
                    }
                    else if (part.Equals("SNORM", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("Snorm");
                    }
                    else if (part.Equals("UINT", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("Uint");
                    }
                    else if (part.Equals("SINT", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("Sint");
                    }
                    else if (part.Equals("FLOAT", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("Float");
                    }
                    else if (part.Equals("SRGB", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("Srgb");
                    }
                    else if (part.Equals("SHAREDEXP", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("SharedExp");
                    }
                    else if (part.Equals("SAMPLER", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("Sampler");
                    }
                    else if (part.Equals("FEEDBACK", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("Feedback");
                    }
                    else if (part.Equals("MIN", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("Min");
                    }
                    else if (part.Equals("MIP", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("Mip");
                    }
                    else if (part.Equals("OPAQUE", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("Opaque");
                    }
                    else if (part.Equals("REGION", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("Region");
                    }
                    else if (part.Equals("USED", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("Used");
                    }
                    else
                    {
                        sb.Append(part);
                    }
                }
                else
                {
                    sb.Append(char.ToUpper(part[0]));
                    for (int i = 1; i < part.Length; i++)
                    {
                        sb.Append(char.ToLower(part[i]));
                    }
                }
            }
        }

        string prettyName = sb.ToString();
        return (char.IsNumber(prettyName[0])) ? "_" + prettyName : prettyName;
    }

    private static string GetTypeName(ApiDataType dataType)
    {
        if (dataType.Kind == "ApiRef")
        {
            return GetTypeName(dataType.Name);
        }
        else if (dataType.Kind == "Array")
        {
            return "Array";
        }
        else if (dataType.Kind == "PointerTo")
        {
            throw new NotImplementedException();
        }

        return GetTypeName(dataType.Name);
    }

    private static void AddCsMapping(string typeName, string csTypeName)
    {
        s_csNameMappings[typeName] = csTypeName;
    }

    private static string GetTypeName(string name)
    {
        if (s_csNameMappings.TryGetValue(name, out string? mappedName))
        {
            return mappedName;
        }

        return name;
    }
}
