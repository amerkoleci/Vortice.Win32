// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using MessagePack;
using Microsoft.Windows.SDK.Win32Docs;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Generator;

public static class Program
{
    private static readonly string[] jsons = new[]
    {
        "Graphics.Dxgi.Common.json",
        "Graphics.Dxgi.json"
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

        {"IntPtr", "nint" },
        {"UIntPtr", "nuint" },

        {"Char", "ushort" },

        { "Foundation.BOOL", "Bool32" },
        { "Foundation.HRESULT", "HResult" },
        { "Foundation.LUID", "Luid" },
        { "Foundation.LARGE_INTEGER", "LargeInterger" },

        // TODO: Understand those ->
        { "Foundation.HWND", "IntPtr" },
        { "Foundation.HANDLE", "IntPtr" },
        { "Foundation.POINT", "System.Drawing.Point" },
        { "Foundation.RECT", "RawRect" },
        { "Graphics.Gdi.HMONITOR", "IntPtr" },
    };

    private static readonly Dictionary<string, string> s_knownTypesPrefixes = new()
    {
        { "DXGI_COLOR_SPACE_TYPE", "DXGI_COLOR_SPACE" },
        { "DXGI_GRAPHICS_PREEMPTION_GRANULARITY", "DXGI_GRAPHICS_PREEMPTION" },
        { "DXGI_COMPUTE_PREEMPTION_GRANULARITY", "DXGI_COMPUTE_PREEMPTION" },
        { "DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS", "DXGI_MULTIPLANE_OVERLAY" },
        { "DXGI_RECLAIM_RESOURCE_RESULTS", "DXGI_RECLAIM_RESOURCE_RESULT" },
        { "DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAGS", "DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAG" },
        { "DXGI_DEBUG_RLO_FLAGS", "DXGI_DEBUG_RLO" },
        { "DXGI_OFFER_RESOURCE_FLAGS", "DXGI_OFFER_RESOURCE_FLAG" },
    };

    private static readonly Dictionary<string, string> s_knownEnumValueNames = new()
    {
        { "DXGI_FORMAT_420_OPAQUE", "Opaque420" },
        { "DXGI_OUTDUPL_COMPOSITED_UI_CAPTURE_ONLY", "CompositedUICaptureOnly" },
    };

    private static readonly Dictionary<string, bool> s_generatedEnums = new()
    {
        {"DXGI_CPU_ACCESS", false },
        {"DXGI_USAGE", true },
        {"DXGI_MAP", true },
        {"DXGI_PRESENT", true },
        {"DXGI_MWA", true },
        {"DXGI_ENUM_MODES", true },
    };

    private static readonly HashSet<string> s_ignoredParts = new(StringComparer.OrdinalIgnoreCase)
    {
        "DXGI"
    };

    private static readonly HashSet<string> s_preserveCaps = new(StringComparer.OrdinalIgnoreCase)
    {
        "HW",
        "YUV",
        "GDI",
    };

    private static readonly Dictionary<string, string> s_typesNameRemap = new()
    {
        { "DXGI_ADAPTER_FLAG", "AdapterFlags" },
        { "DXGI_ADAPTER_FLAG3", "AdapterFlags3" },
        { "DXGI_SWAP_CHAIN_FLAG", "SwapChainFlags" },

        // Generated
        { "DXGI_MAP", "MapFlags" },
        { "DXGI_ENUM_MODES", "EnumModesFlags" },
        { "DXGI_MWA", "WindowAssociationFlags" },
    };

    private static readonly Dictionary<string, string> s_structFieldTypeRemap = new()
    {
        { "DXGI_ADAPTER_DESC1::Flags", "DXGI_ADAPTER_FLAG" },
        { "DXGI_ADAPTER_DESC3::Flags", "DXGI_ADAPTER_FLAG3" },
        { "DXGI_SWAP_CHAIN_DESC::BufferUsage", "Usage" },
        { "DXGI_SWAP_CHAIN_DESC::Flags", "DXGI_SWAP_CHAIN_FLAG" },
        { "DXGI_SWAP_CHAIN_DESC1::BufferUsage", "Usage" },
        { "DXGI_SWAP_CHAIN_DESC1::Flags", "DXGI_SWAP_CHAIN_FLAG" },
    };

    private static bool s_generateUnmanagedDocs = true;

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
            string finalPath = Path.Combine(AppContext.BaseDirectory, "win32json", "api", jsonFile);
            string jsonData = File.ReadAllText(finalPath);
            ApiData? api = JsonConvert.DeserializeObject<ApiData>(jsonData);
            Generate(api!, outputPath, jsonFile);
        }

        // Generate docs
        using FileStream docsStream = File.OpenRead(@"C:\Users\amerk\.nuget\packages\microsoft.windows.sdk.win32docs\0.1.8-alpha\apidocs.msgpack");
        var data = MessagePackSerializer.Deserialize<Dictionary<string, ApiDetails>>(docsStream);
        var documentationData = new Dictionary<string, ApiDetails>();

        string[] prefixes = new[] { "DXGI" };
        foreach (string key in data.Keys)
        {
            //Debug.WriteLine(key);

            foreach (string prefix in prefixes)
            {
                if (key.StartsWith(prefix) || key.StartsWith("I" + prefix))
                {
                    documentationData.Add(key, data[key]);
                }
            }
        }

        XmlWriterSettings settings = new()
        {
            Indent = true,
        };
        //settings.ConformanceLevel = ConformanceLevel.Fragment;

        using (var writer = XmlWriter.Create(Path.Combine(outputPath, "DXGI.xml"), settings))
        {
            writer.WriteStartDocument();
            writer.WriteStartElement(null, "doc", null);

            foreach (var item in documentationData.Keys)
            {
                var doc = documentationData[item];

                if (!string.IsNullOrEmpty(doc.Description) || doc.Parameters.Count > 0)
                {
                    writer.WriteStartElement(null, "member", null);
                    writer.WriteAttributeString("name", item.Replace(".", "::"));
                    {
                        writer.WriteStartElement(null, "summary", null);
                        {
                            if (!string.IsNullOrEmpty(doc.Description))
                            {
                                writer.WriteStartElement(null, "para", null);
                                writer.WriteRaw(FormatMd(doc.Description));
                                writer.WriteEndElement(); // para
                            }

                            if (doc.HelpLink != null)
                            {
                                writer.WriteStartElement(null, "para", null);
                                writer.WriteString("Microsoft Docs: ");
                                writer.WriteStartElement(null, "see", null);
                                writer.WriteAttributeString("href", doc.HelpLink.ToString());
                                writer.WriteEndElement(); // see
                                writer.WriteEndElement(); // para
                            }

                            // Write params
                            foreach (var param in doc.Parameters)
                            {
                                if (!string.IsNullOrEmpty(param.Value))
                                {
                                    writer.WriteStartElement(null, "param", null);
                                    string paramName = param.Key;
                                    if (paramName.StartsWith("pp") && char.IsUpper(paramName[2]))
                                    {
                                        paramName = paramName.Substring(2);
                                        paramName = paramName[0].ToString().ToLower() + paramName.Substring(1);
                                    }
                                    else if (paramName.StartsWith("p") && char.IsUpper(paramName[1]))
                                    {
                                        paramName = paramName.Substring(1);
                                        paramName = paramName[0].ToString().ToLower() + paramName.Substring(1);
                                    }
                                    else if (paramName.StartsWith("u") && char.IsUpper(paramName[1]))
                                    {
                                        paramName = paramName.Substring(1);
                                        paramName = paramName[0].ToString().ToLower() + paramName.Substring(1);
                                    }
                                    else if (paramName.StartsWith("b") && char.IsUpper(paramName[1])) // bEnable
                                    {
                                        paramName = paramName.Substring(1);
                                        paramName = paramName[0].ToString().ToLower() + paramName.Substring(1);
                                    }
                                    else if (char.IsUpper(paramName[0]) && paramName.Length > 1 && char.IsLower(paramName[1]))
                                    {
                                        paramName = paramName[0].ToString().ToLower() + paramName.Substring(1);
                                    }
                                    else if (paramName == "ID")
                                    {
                                        paramName = "id";
                                    }
                                    else if (paramName == "dwCookie")
                                    {
                                        paramName = "cookie";
                                    }

                                    writer.WriteAttributeString("name", paramName);

                                    if (!param.Value.StartsWith("Type:"))
                                    {
                                        writer.WriteRaw(FormatMd(param.Value));
                                    }
                                    else
                                    {
                                        var lines = param.Value.Split('\n');
                                        writer.WriteRaw(FormatMd(string.Join("\r\n", lines.Skip(2))));
                                    }

                                    writer.WriteEndElement(); // param
                                }

                            }
                        }
                        writer.WriteEndElement(); // summary
                    }
                    writer.WriteEndElement(); // comment
                }

                // Write fields
                foreach (var fieldName in doc.Fields.Keys)
                {
                    var field = doc.Fields[fieldName];

                    if (string.IsNullOrEmpty(field))
                    {
                        continue;
                    }

                    if (!field.StartsWith("Type:"))
                    {
                        // Enum value
                        writer.WriteStartElement(null, "member", null);
                        writer.WriteAttributeString("name", $"{item.Replace(".", "::")}::{fieldName}");
                        {
                            writer.WriteStartElement(null, "summary", null);
                            {
                                var a = FormatMd(field);
                                writer.WriteRaw(FormatMd(field));
                            }
                            writer.WriteEndElement(); // summary
                        }
                        writer.WriteEndElement(); // comment
                    }
                    else
                    {
                        // Struct field
                        writer.WriteStartElement(null, "member", null);
                        writer.WriteAttributeString("name", $"{item.Replace(".", "::")}::{fieldName}");
                        {
                            writer.WriteStartElement(null, "summary", null);
                            {
                                var lines = field.Split('\n');
                                writer.WriteRaw(FormatMd(string.Join("\r\n", lines.Skip(2))));
                            }
                            writer.WriteEndElement(); // summary
                        }
                        writer.WriteEndElement(); // comment
                    }
                }
            }

            writer.WriteEndElement(); // comments
            writer.WriteEndDocument();
        }

        return 0;
    }

    public static Regex MDLink = new(@"\[([A-z0-9<>\\]+)\]\(([^\)]+)\)");
    public static Regex ImgLink = new(@"!\[([A-z0-9<>\\]+)\]\(([^\)]+)\)");
    public static Regex Bold = new(@"\*\*([^ ^\*][^\*^\n]*)\*\*");
    public static Regex Italics = new(@"\*([^ ^\*][^\*^\n]*)\*");
    public static Regex MultilineCode = new(@"```[A-z]*([^`]+)```");
    public static Regex InlineCode = new(@"`([^`]+)`");

    public static Regex Struct = new Regex(@"struct DML_[A-z0-9_]+_OPERATOR_DESC\r\n{[^}]+};", RegexOptions.Multiline);

    public static string FormatMd(string value)
    {
        value = ImgLink.Replace(value, "");
        value = MDLink.Replace(value, "<a href=\"https://docs.microsoft.com$2\">$1</a>");
        value = Bold.Replace(value, "<b>$1</b>");
        value = Italics.Replace(value, "<i>$1</i>");
        value = MultilineCode.Replace(value, "<code>$1</code>");
        value = InlineCode.Replace(value, "<c>$1</c>");

        value = value.Replace("<code>s<code>", "<c>s</c>");
        value = value.Replace("ns-d3d12video-d3d12_video_process_luma_key\"\"", "\"ns-d3d12video-d3d12_video_process_luma_key\"");
        value = value.Replace("&L", "&amp;l");

        value = value.Replace("& ", "&amp; ");
        value = value.Replace(" > ", " &gt; ");
        value = value.Replace(" < ", " &lt; ");
        value = value.Replace(" >= ", " &gt;= ");
        value = value.Replace(" <= ", " &lt;= ");
        value = value.Replace("<-", "&lt;-");
        value = value.Replace("->", "-&gt;");
        value = value.Replace("\n>", "\n&gt;");
        value = value.Replace("&mdash;", "—");

        return value;
    }

    private static void Generate(ApiData api, string outputPath, string jsonFile)
    {
        string[] splits = jsonFile.Split(".", StringSplitOptions.RemoveEmptyEntries);
        string folderRoot = splits[0];
        string outputFolder = Path.Combine(outputPath, folderRoot);

        if (!Directory.Exists(outputFolder))
        {
            Directory.CreateDirectory(outputFolder);
        }

        string fileName = string.Empty;
        for (int i = 1; i < splits.Length - 1; i++)
        {
            if (string.IsNullOrEmpty(fileName) == false)
            {
                fileName += ".";
            }

            fileName += splits[i];
        }
        string ns = fileName;
        fileName += ".cs";

        using var writer = new CodeWriter(
            Path.Combine(outputFolder, fileName),
            $"{folderRoot}.{ns}",
            $"DXGI",
            $"Win32.{folderRoot}.{ns}");

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

                bool skipValue = false;
                foreach (var enumToGenerate in s_generatedEnums)
                {
                    if (constant.Name.StartsWith(enumToGenerate.Key))
                    {
                        skipValue = true;
                        break;
                    }
                }

                if (skipValue)
                    continue;

                string typeName = GetTypeName(constant.Type);
                if (typeName == "Guid")
                {
                    writer.WriteLine($"public static readonly Guid {constant.Name} = {FormatGuid(constant.Value.ToString())};");
                }
                else if (typeName == "HResult")
                {
                    writer.WriteLine($"public static readonly HResult {constant.Name} = {constant.Value};");
                }
                else
                {
                    writer.WriteLine($"public const {typeName} {constant.Name} = {constant.Value};");
                }
            }
        }
        writer.WriteLine();
    }

    private static void GenerateTypes(CodeWriter writer, ApiData api)
    {
        writer.WriteLine($"#region Enums");
        foreach (ApiType enumType in api.Types.Where(item => item.Kind.ToLowerInvariant() == "enum"))
        {
            GenerateEnum(writer, enumType, false);
        }
        writer.WriteLine($"#endregion Enums");
        writer.WriteLine();

        // Generated enums -> from constants
        writer.WriteLine($"#region Generated Enums");
        var createdEnums = new Dictionary<string, ApiType>();

        foreach (var constant in api.Constants)
        {
            if (ShouldSkipConstant(constant))
                continue;

            foreach (var enumToGenerate in s_generatedEnums)
            {
                if (constant.Name.StartsWith(enumToGenerate.Key))
                {
                    ApiType createdEnumType;
                    if (!createdEnums.ContainsKey(enumToGenerate.Key))
                    {
                        ApiType apiType = new()
                        {
                            Name = enumToGenerate.Key,
                            Kind = "Enum",
                            Flags = enumToGenerate.Value,
                            Scoped = false,
                            IntegerBase = constant.Type.Name
                        };
                        createdEnums.Add(enumToGenerate.Key, apiType);
                        createdEnumType = apiType;
                    }
                    else
                    {
                        createdEnumType = createdEnums[enumToGenerate.Key];
                    }

                    ApiEnumValue enumValue = new ApiEnumValue
                    {
                        Name = constant.Name,
                        Value = constant.Value
                    };
                    createdEnumType.Values.Add(enumValue);

                    //string enumValueName = GetPrettyFieldName(constant.Name, createdEnumName);
                    //writer.WriteLine($"{enumValueName} = {constant.Value},");
                }
            }
        }

        foreach (ApiType enumType in createdEnums.Values)
        {
            GenerateEnum(writer, enumType, true);
        }

        writer.WriteLine($"#endregion Generated Enums");
        writer.WriteLine();

        writer.WriteLine($"#region Structs");
        foreach (ApiType structType in api.Types.Where(item => item.Kind.ToLowerInvariant() == "struct"))
        {
            GenerateStruct(writer, structType);
        }
        writer.WriteLine($"#endregion Structs");
        writer.WriteLine();
    }

    private static void GenerateEnum(CodeWriter writer, ApiType enumType, bool autoGenerated)
    {
        string csTypeName = GetDataTypeName(enumType.Name, out string enumPrefix);
        string baseTypeName = GetTypeName(enumType.IntegerBase);
        AddCsMapping(writer.Api, enumType.Name, csTypeName);

        if (!autoGenerated)
        {
            writer.WriteLine($"/// <include file='../{writer.DocFileName}.xml' path='doc/member[@name=\"{enumType.Name}\"]/*' />");
        }

        if (s_generateUnmanagedDocs)
            writer.WriteLine($"/// <unmanaged>{enumType.Name}</unmanaged>");

        if (enumType.Flags)
        {
            writer.WriteLine("[Flags]");
        }

        bool noneAdded = false;
        using (writer.PushBlock($"public enum {csTypeName} : {baseTypeName}"))
        {
            if (enumType.Flags &&
                !enumType.Values.Any(item => GetPrettyFieldName(item.Name, enumPrefix) == "None"))
            {
                writer.WriteLine("None = 0,");
                noneAdded = true;
            }

            foreach (ApiEnumValue value in enumType.Values)
            {
                if (value.Name.EndsWith("_FORCE_DWORD") ||
                    value.Name.EndsWith("_FORCE_UINT"))
                    continue;

                string enumValueName = GetPrettyFieldName(value.Name, enumPrefix);

                if (!autoGenerated)
                {
                    writer.WriteLine($"/// <include file='../{writer.DocFileName}.xml' path='doc/member[@name=\"{enumType.Name}::{value.Name}\"]/*' />");
                }

                if (s_generateUnmanagedDocs)
                {
                    writer.WriteLine($"/// <unmanaged>{value.Name}</unmanaged>");
                }

                if (enumValueName.StartsWith("DXGI_MSG_"))
                {
                    enumValueName = enumValueName.Substring("DXGI_MSG_".Length);
                }

                writer.WriteLine($"{enumValueName} = {value.Value},");
            }
        }

        writer.WriteLine();
    }

    private static void GenerateStruct(CodeWriter writer, ApiType structType)
    {
        string csTypeName = GetDataTypeName(structType.Name, out string structPrefix);
        AddCsMapping(writer.Api, structType.Name, csTypeName);

        writer.WriteLine($"/// <include file='../{writer.DocFileName}.xml' path='doc/member[@name=\"{structType.Name}\"]/*' />");

        if (s_generateUnmanagedDocs)
        {
            writer.WriteLine($"/// <unmanaged>{structType.Name}</unmanaged>");
        }

        using (writer.PushBlock($"public partial struct {csTypeName}"))
        {
            foreach (ApiStructField field in structType.Fields)
            {
                if (field.Name.EndsWith("_FORCE_DWORD"))
                    continue;

                string fieldValueName = GetPrettyFieldName(field.Name, structPrefix);
                string fieldTypeName = GetTypeName(field.Type);

                writer.WriteLine($"/// <include file='../{writer.DocFileName}.xml' path='doc/member[@name=\"{structType.Name}::{field.Name}\"]/*' />");

                if (s_generateUnmanagedDocs)
                {
                    //writer.WriteLine($"/// <unmanaged>{field.Name}</unmanaged>");
                }

                string remapFieldLookUp = $"{structType.Name}::{field.Name}";
                if (s_structFieldTypeRemap.TryGetValue(remapFieldLookUp, out string? remapType))
                {
                    fieldTypeName = GetTypeName(remapType);
                }

                if (fieldTypeName == "Array")
                {
                    bool canUseFixed = false;
                    if (field.Type.Child.Kind == "Native")
                    {
                        canUseFixed = true;
                    }

                    fieldTypeName = GetTypeName(field.Type.Child);
                    fieldTypeName = NormalizeTypeName(writer.Api, fieldTypeName);

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
                                writer.WriteLine($"return MemoryMarshal.CreateSpan(ref e0, {field.Type.Shape.Size});");
                            }
                        }
                    }
                }
                else
                {
                    string unsafePrefix = string.Empty;
                    fieldTypeName = NormalizeTypeName(writer.Api, fieldTypeName);
                    if (fieldTypeName.EndsWith("*"))
                    {
                        unsafePrefix += "unsafe ";
                    }

                    writer.WriteLine($"public {unsafePrefix}{fieldTypeName} {fieldValueName};");
                }
            }
        }

        writer.WriteLine();
    }

    private static bool ShouldSkipConstant(ApiDataConstant constant)
    {
        if (constant.Name == "_FACDXGI" ||
            constant.Name == "DXGI_FORMAT_DEFINED")
        {
            return true;
        }

        return false;
    }

    private static string NormalizeTypeName(string api, string typeName)
    {
        if (!typeName.StartsWith(api))
            return typeName;

        return typeName.Replace(api + ".", "");
    }

    private static string GetDataTypeName(string typeName, out string prefix)
    {
        prefix = typeName;
        if (s_knownTypesPrefixes.TryGetValue(typeName, out string? knowPrefix))
        {
            prefix = knowPrefix!;
        }

        if (s_typesNameRemap.TryGetValue(typeName, out string? remapName))
        {
            return remapName!;
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
                else if (part.Equals("DESC1", StringComparison.OrdinalIgnoreCase))
                {
                    sb.Append("Description1");
                }
                else if (part.Equals("DESC2", StringComparison.OrdinalIgnoreCase))
                {
                    sb.Append("Description2");
                }
                else if (part.Equals("DESC3", StringComparison.OrdinalIgnoreCase))
                {
                    sb.Append("Description3");
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
                    if (part.Equals("NONPREROTATED", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("NonPrerotated");
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
        }

        string prettyName = sb.ToString();
        return (char.IsNumber(prettyName[0])) ? "_" + prettyName : prettyName;
    }

    private static string FormatGuid(string value)
    {
        var guid = Guid.Parse(value).ToString("N");

        var a = "0x" + guid.Substring(0, 8);
        var b = "0x" + guid.Substring(8, 4);
        var c = "0x" + guid.Substring(12, 4);
        var d = "0x" + guid.Substring(16, 2);
        var e = "0x" + guid.Substring(18, 2);
        var f = "0x" + guid.Substring(20, 2);
        var g = "0x" + guid.Substring(22, 2);
        var h = "0x" + guid.Substring(24, 2);
        var i = "0x" + guid.Substring(26, 2);
        var j = "0x" + guid.Substring(28, 2);
        var k = "0x" + guid.Substring(30, 2);

        return $"new Guid({a}, {b}, {c}, {d}, {e}, {f}, {g}, {h}, {i}, {j}, {k})";
    }


    private static string GetTypeName(ApiDataType dataType)
    {
        if (dataType.Kind == "ApiRef")
        {
            return GetTypeName($"{dataType.Api}.{dataType.Name}");
        }
        else if (dataType.Kind == "Array")
        {
            return "Array";
        }
        else if (dataType.Kind == "PointerTo")
        {
            return GetTypeName(dataType.Child) + "*";
        }

        return GetTypeName(dataType.Name);
    }

    private static void AddCsMapping(string api, string typeName, string csTypeName)
    {
        s_csNameMappings[$"{api}.{typeName}"] = $"{api}.{csTypeName}";
    }

    private static string GetTypeName(string name)
    {
        string? mappedName;
        if (s_csNameMappings.TryGetValue(name, out mappedName))
        {
            return mappedName!;
        }
        else if (s_typesNameRemap.TryGetValue(name, out mappedName))
        {
            return mappedName!;
        }

        return name;
    }
}
