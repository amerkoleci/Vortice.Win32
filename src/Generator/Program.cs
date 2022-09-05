// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Text;
using Newtonsoft.Json;

namespace Generator;

public static class Program
{
    private static readonly string[] jsons = new[]
    {
        "Graphics.Dxgi.Common.json",
        "Graphics.Dxgi.json",
        "Graphics.Direct3D.json"
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
        { "Foundation.BOOLEAN", "byte" },
        { "Foundation.BSTR", "char*" },
        { "Foundation.HANDLE", "IntPtr" },
        { "Foundation.HINSTANCE", "IntPtr" },
        { "Foundation.HRESULT", "HResult" },
        { "Foundation.HWND", "IntPtr" },
        { "Foundation.LPARAM", "IntPtr" },
        { "Foundation.LRESULT", "IntPtr" },
        { "Foundation.WPARAM", "UIntPtr" },
        { "Foundation.PSTR", "byte*" },
        { "Foundation.PWSTR", "char*" },
        { "Foundation.CHAR", "byte" },

        { "Foundation.LUID", "Luid" },
        { "Foundation.LARGE_INTEGER", "LargeInterger" },

        { "System.Com.IUnknown", "IUnknown" },

        { "Graphics.Gdi.HMONITOR", "IntPtr" },
        { "Graphics.Gdi.HDC", "IntPtr" },

        { "Graphics.Direct3D.D3DVECTOR", "Vector3" },
        { "Graphics.Direct3D.D3DMATRIX", "Matrix4x4" },

        // TODO: Understand those ->
        { "Foundation.RECT", "RawRect" },
        { "Foundation.RECTL", "RawRect" },
        { "Foundation.POINT", "System.Drawing.Point" },
        { "Foundation.POINTL", "System.Drawing.Point" },
        { "Foundation.SIZE", "System.Drawing.Size" },
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

        // D3D
        { "D3D_INTERPOLATION_MODE", "D3D_INTERPOLATION" },
        { "D3D_PARAMETER_FLAGS", "D3D" },
        { "D3D_TESSELLATOR_OUTPUT_PRIMITIVE", "D3D_TESSELLATOR_OUTPUT" },
        { "D3D_REGISTER_COMPONENT_TYPE", "D3D_REGISTER_COMPONENT" },
        { "D3D_RESOURCE_RETURN_TYPE", "D3D_RETURN_TYPE" },
    };

    private static readonly Dictionary<string, string> s_partRenames = new()
    {
        { "NONPREROTATED", "NonPrerotated" },
        { "POINTLIST", "PointList" },
        { "LINELIST", "LineList" },
        { "LINESTRIP", "LineStrip" },
        { "TRIANGLELIST", "TriangleList" },
        { "TRIANGLESTRIP", "TriangleStrip" },
        { "PATCHLIST", "PatchList" },

        { "NOPERSPECTIVE", "NoPerspective" },
        { "TEXTURE1D", "Texture1D" },
        { "TEXTURE1DARRAY", "Texture1DArray" },
        { "TEXTURE2D", "Texture2D" },
        { "TEXTURE2DARRAY", "Texture2DArray" },
        { "TEXTURE2DMS", "Texture2DMs" },
        { "TEXTURE2DMSARRAY", "Texture2DMsArray" },
        { "TEXTURE3D", "Texture3D" },
        { "TEXTURECUBE", "TextureCube" },
        { "TEXTURECUBEARRAY", "TextureCubeArray" },
        { "BUFFEREX", "BufferExtended" },
    };

    private static readonly Dictionary<string, string> s_knownEnumValueNames = new()
    {
        { "DXGI_FORMAT_420_OPAQUE", "Opaque420" },
        { "DXGI_OUTDUPL_COMPOSITED_UI_CAPTURE_ONLY", "CompositedUICaptureOnly" },
        { "D3D_FEATURE_LEVEL_9_1", "Level_9_1" },
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
        "DXGI",
        "D3D",
        "D3D10",
        "D3D11",
        "PF" // D3D_PF_
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

    private static readonly HashSet<string> s_visitedEnums = new();
    private static readonly HashSet<string> s_visitedStructs = new();

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
        DocGenerator.Generate(new[] { "DXGI" }, Path.Combine(outputPath, "Dxgi.xml"));
        //DocGenerator.Generate(new[] { "D3D" }, Path.Combine(outputPath, "Direct3D.xml"));
        DocGenerator.Generate(new[] { "D3D11" }, Path.Combine(outputPath, "D3D11.xml"));
        return 0;
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

        string docFile = splits[1];
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
            docFile,
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

            s_visitedEnums.Add($"{writer.Api}.{enumType.Name}");
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
            if (s_csNameMappings.ContainsKey($"{writer.Api}.{structType.Name}"))
            {
                continue;
            }

            GenerateStruct(writer, structType);

            s_visitedStructs.Add($"{writer.Api}.{structType.Name}");
        }
        writer.WriteLine($"#endregion Structs");
        writer.WriteLine();

        // Com types
        writer.WriteLine($"#region COM Types");
        foreach (ApiType comType in api.Types.Where(item => item.Kind.ToLowerInvariant() == "com"))
        {
            //if (comType.Name != "IDXGIObject" &&
            //    comType.Name != "IDXGIDeviceSubObject")
            //{
            //    break;
            //}

            // Generate methods
            List<KeyValuePair<ApiFunction, string>> methodsToGenerate = new();
            ApiType iterateType = comType;
            while (iterateType.Interface != null && iterateType.Interface.Name != "IUnknown")
            {
                iterateType = api.Types.First(item => item.Name == iterateType.Interface.Name);

                foreach (var method in iterateType.Methods)
                {
                    methodsToGenerate.Add(new(method, iterateType.Name));
                }

            }

            foreach (var method in comType.Methods)
            {
                methodsToGenerate.Add(new(method, comType.Name));
            }

            GenerateComType(api, writer, comType, methodsToGenerate);
        }

        writer.WriteLine($"#endregion Com Types");
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
                {
                    continue;
                }

                // Ignore D3D10 and D3D11 in D3D
                if (enumType.Name.StartsWith("D3D_"))
                {
                    if (value.Name.StartsWith("D3D10_") ||
                        value.Name.StartsWith("D3D11_"))
                    {
                        continue;
                    }
                }

                string enumValueName = GetPrettyFieldName(value.Name, enumPrefix);

                if (enumType.Name == "D3D_PRIMITIVE_TOPOLOGY")
                {
                }

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

                writer.WriteLine();
            }
        }

        writer.WriteLine();
    }

    private static void GenerateComType(
        ApiData api,
        CodeWriter writer,
        ApiType comType,
        List<KeyValuePair<ApiFunction, string>> methodsToGenerate)
    {
        string csTypeName = comType.Name;
        //AddCsMapping(writer.Api, comType.Name, csTypeName);

        writer.WriteLine($"/// <include file='../{writer.DocFileName}.xml' path='doc/member[@name=\"{comType.Name}\"]/*' />");

        if (s_generateUnmanagedDocs)
        {
            writer.WriteLine($"/// <unmanaged>{comType.Name}</unmanaged>");
        }

        if (comType.Guid != null)
        {
            writer.WriteLine($"[Guid(\"{comType.Guid}\")]");
        }

        if (comType.Interface != null)
        {
            writer.WriteLine($"[NativeTypeName(\"struct {comType.Name} : {comType.Interface.Name}\")]");
            writer.WriteLine($"[NativeInheritance(\"{comType.Interface.Name}\")]");
        }

        using (writer.PushBlock($"public unsafe partial struct {csTypeName} : {csTypeName}.Interface"))
        {
            if (comType.Guid != null)
            {
                // Generate IID
                using (writer.PushBlock($"public static ref readonly Guid IID_{csTypeName}"))
                {
                    writer.WriteLine("[MethodImpl(MethodImplOptions.AggressiveInlining)]");
                    using (writer.PushBlock("get"))
                    {
                        var guid = Guid.Parse(comType.Guid).ToString("N");
                        var _1 = "0x" + guid.Substring(6, 2).ToUpperInvariant();
                        var _2 = "0x" + guid.Substring(4, 2).ToUpperInvariant();
                        var _3 = "0x" + guid.Substring(2, 2).ToUpperInvariant();
                        var _4 = "0x" + guid.Substring(0, 2).ToUpperInvariant();

                        var _5 = "0x" + guid.Substring(10, 2).ToUpperInvariant();
                        var _6 = "0x" + guid.Substring(8, 2).ToUpperInvariant();

                        var _7 = "0x" + guid.Substring(14, 2).ToUpperInvariant();
                        var _8 = "0x" + guid.Substring(12, 2).ToUpperInvariant();

                        var d = "0x" + guid.Substring(16, 2).ToUpperInvariant();
                        var e = "0x" + guid.Substring(18, 2).ToUpperInvariant();
                        var f = "0x" + guid.Substring(20, 2).ToUpperInvariant();
                        var g = "0x" + guid.Substring(22, 2).ToUpperInvariant();
                        var h = "0x" + guid.Substring(24, 2).ToUpperInvariant();
                        var i = "0x" + guid.Substring(26, 2).ToUpperInvariant();
                        var j = "0x" + guid.Substring(28, 2).ToUpperInvariant();
                        var k = "0x" + guid.Substring(30, 2).ToUpperInvariant();

                        writer.WriteLine("ReadOnlySpan<byte> data = new byte[] {");
                        writer.WriteLine($"{'\t'}{_1}, {_2}, {_3}, {_4},");
                        writer.WriteLine($"{'\t'}{_5}, {_6},");
                        writer.WriteLine($"{'\t'}{_7}, {_8},");
                        writer.WriteLine($"{'\t'}{d},");
                        writer.WriteLine($"{'\t'}{e},");
                        writer.WriteLine($"{'\t'}{f},");
                        writer.WriteLine($"{'\t'}{g},");
                        writer.WriteLine($"{'\t'}{h},");
                        writer.WriteLine($"{'\t'}{i},");
                        writer.WriteLine($"{'\t'}{j},");
                        writer.WriteLine($"{'\t'}{k}");
                        writer.WriteLine("};");
                        writer.WriteLine();

                        writer.WriteLine("Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());");
                        writer.WriteLine("return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));");
                    }
                }
                writer.WriteLine();

                writer.WriteLine($"public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_{csTypeName}));");
                writer.WriteLine();
            }

            writer.WriteLine($"public void** lpVtbl;");
            writer.WriteLine();

            int vtblIndex = 0;

            bool generateIUnknown = false;
            var iterateType = comType;

            while (iterateType != null)
            {
                if (iterateType.Interface == null)
                    break;

                generateIUnknown = iterateType.Interface.Name == "IUnknown";
                iterateType = api.Types.FirstOrDefault(item => item.Name == iterateType.Interface.Name);
            }

            if (generateIUnknown)
            {
                writer.WriteLine("/// <inheritdoc cref=\"IUnknown.QueryInterface\" />");
                writer.WriteLine("[MethodImpl(MethodImplOptions.AggressiveInlining)]");
                writer.WriteLine("[VtblIndex(0)]");
                using (writer.PushBlock($"public HResult QueryInterface([NativeTypeName(\"const IID &\")] Guid* riid, void** ppvObject)"))
                {
                    writer.WriteLine("return ((delegate* unmanaged[Stdcall]<IUnknown*, Guid*, void**, int>)(lpVtbl[0]))((IUnknown*)Unsafe.AsPointer(ref this), riid, ppvObject);");
                }
                writer.WriteLine();

                // AddRef
                writer.WriteLine("/// <inheritdoc cref=\"IUnknown.AddRef\" />");
                writer.WriteLine("[MethodImpl(MethodImplOptions.AggressiveInlining)]");
                writer.WriteLine("[VtblIndex(1)]");
                writer.WriteLine("[return: NativeTypeName(\"ULONG\")]");
                using (writer.PushBlock($"public uint AddRef()"))
                {
                    writer.WriteLine("return ((delegate* unmanaged[Stdcall]<IUnknown*, uint>)(lpVtbl[1]))((IUnknown*)Unsafe.AsPointer(ref this));");
                }
                writer.WriteLine();

                // Release
                writer.WriteLine("/// <inheritdoc cref=\"IUnknown.Release\" />");
                writer.WriteLine("[MethodImpl(MethodImplOptions.AggressiveInlining)]");
                writer.WriteLine("[VtblIndex(2)]");
                writer.WriteLine("[return: NativeTypeName(\"ULONG\")]");
                using (writer.PushBlock($"public uint Release()"))
                {
                    writer.WriteLine("return ((delegate* unmanaged[Stdcall]<IUnknown*, uint>)(lpVtbl[2]))((IUnknown*)Unsafe.AsPointer(ref this));");
                }
                writer.WriteLine();
                vtblIndex = 3;
            }

            foreach (var methodPair in methodsToGenerate)
            {
                var method = methodPair.Key;
                string docName = methodPair.Value;

                // TODO: Handle inherit
                string returnType = GetTypeName(method.ReturnType);

                StringBuilder argumentBuilder = new();
                StringBuilder argumentsTypesBuilder = new();
                StringBuilder argumentsNameBuilder = new();
                int parameterIndex = 0;

                if (method.Name == "RegisterDestructionCallback")
                {
                    Console.WriteLine();
                }

                foreach (var parameter in method.Params)
                {
                    bool asPointer = false;
                    if (parameter.Type.Kind == "ApiRef")
                    {
                        if (parameter.Type.TargetKind == "FunctionPointer")
                        {
                        }
                        else
                        {
                            string fullTypeName = $"{parameter.Type.Api}.{parameter.Type.Name}";
                            if (!IsEnum(fullTypeName))
                            {
                                asPointer = true;
                            }
                        }
                    }

                    string parameterType = GetTypeName(parameter.Type, asPointer);
                    parameterType = NormalizeTypeName(writer.Api, parameterType);
                    string parameterName = parameter.Name;

                    bool isOptional = parameter.Attrs.Any(item => item is string str && str == "Optional");
                    if (parameter.Attrs.Any(item => item is string str && str == "ComOutPtr"))
                    {
                        if (!IsPrimitive(parameter.Type))
                        {
                            parameterType += "*";
                        }
                    }

                    argumentBuilder.Append(parameterType).Append(' ').Append(parameterName);
                    if (isOptional == true)
                    {
                        //argumentBuilder.Append(" = default");
                    }

                    argumentsTypesBuilder.Append(parameterType);
                    argumentsNameBuilder.Append(parameterName);

                    if (parameterIndex < method.Params.Count - 1)
                    {
                        argumentBuilder.Append(", ");
                        argumentsTypesBuilder.Append(", ");
                        argumentsNameBuilder.Append(", ");
                    }

                    parameterIndex++;
                }

                // Return type
                string returnMarshalType = returnType;
                if (returnMarshalType.ToLower() == "hresult")
                {
                    returnMarshalType = "int";
                }

                if (method.Params.Count > 0)
                {
                    argumentsTypesBuilder.Append(", ");
                }

                argumentsTypesBuilder.Append(returnMarshalType);

                string argumentsString = argumentBuilder.ToString();
                string argumentTypesString = argumentsTypesBuilder.ToString();
                string argumentNamesString = argumentsNameBuilder.ToString();
                if (method.Params.Count > 0)
                {
                    argumentNamesString = ", " + argumentNamesString;
                }

                if (comType.Name == docName)
                {
                    writer.WriteLine($"/// <include file='../{writer.DocFileName}.xml' path='doc/member[@name=\"{comType.Name}::{method.Name}\"]/*' />");
                }
                else
                {
                    writer.WriteLine($"/// <inheritdoc cref=\"{docName}.{method.Name}\" />");
                }

                writer.WriteLine("[MethodImpl(MethodImplOptions.AggressiveInlining)]");
                writer.WriteLine($"[VtblIndex({vtblIndex})]");
                using (writer.PushBlock($"public {returnType} {method.Name}({argumentsString})"))
                {
                    writer.WriteLineUndindented("#if NET6_0_OR_GREATER");
                    if (returnType != "void")
                        writer.Write("return ");
                    writer.WriteLine($"((delegate* unmanaged<{comType.Name}*, {argumentTypesString}>)(lpVtbl[{vtblIndex}]))(({comType.Name}*)Unsafe.AsPointer(ref this){argumentNamesString});");
                    writer.WriteLineUndindented("#else");
                    if (returnType != "void")
                        writer.Write("return ");
                    writer.WriteLine($"((delegate* unmanaged[Stdcall]<{comType.Name}*, {argumentTypesString}>)(lpVtbl[{vtblIndex}]))(({comType.Name}*)Unsafe.AsPointer(ref this){argumentNamesString});");
                    writer.WriteLineUndindented("#endif");
                }
                writer.WriteLine();

                vtblIndex++;
            }

            string baseInterfaceType = string.Empty;
            if (comType.Interface != null)
            {
                baseInterfaceType = $" : {comType.Interface.Name}.Interface";
            }

            using (writer.PushBlock($"public interface Interface{baseInterfaceType}"))
            {
            }
            //writer.WriteLine();
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
        {
            return typeName;
        }

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

        bool isFeatureLevel = enumPrefix == "D3D_FEATURE_LEVEL";
        bool isDXGIFormat = enumPrefix == "DXGI_FORMAT";

        string[] parts = value[enumPrefix.Length..].Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries);

        StringBuilder sb = new();

        bool appendUnderscore = false;
        if (isFeatureLevel)
        {
            sb.Append("Level").Append('_');
            appendUnderscore = true;
        }
        else if (enumPrefix == "D3D_PRIMITIVE_TOPOLOGY"
            && value.EndsWith("_CONTROL_POINT_PATCHLIST"))
        {
            sb.Append('P');
        }
        else if (enumPrefix == "D3D_PRIMITIVE"
            && value.EndsWith("_CONTROL_POINT_PATCH"))
        {
            sb.Append('P');
        }

        int partIndex = 0;
        foreach (string part in parts)
        {
            if (s_ignoredParts.Contains(part))
            {
                partIndex++;
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
                    if (s_partRenames.TryGetValue(part, out string? partRemap))
                    {
                        sb.Append(partRemap!);
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

            if (appendUnderscore)
            {
                if (partIndex < parts.Length - 1)
                {
                    sb.Append('_');
                }

                partIndex++;
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

    private static string GetTypeName(ApiDataType dataType, bool asPointer = false)
    {
        if (dataType.Kind == "ApiRef")
        {
            string typeName = GetTypeName($"{dataType.Api}.{dataType.Name}");
            return asPointer ? typeName + "*" : typeName;
        }
        else if (dataType.Kind == "Array")
        {
            return "Array";
        }
        else if (dataType.Kind == "LPArray")
        {
            return GetTypeName(dataType.Child) + "*";
        }
        else if (dataType.Kind == "PointerTo")
        {
            return GetTypeName(dataType.Child) + "*";
        }

        return GetTypeName(dataType.Name);
    }

    private static bool IsPrimitive(ApiDataType dataType)
    {
        if (dataType.Kind == "ApiRef")
        {
            string apiRefType = GetTypeName($"{dataType.Api}.{dataType.Name}");
        }
        else if (dataType.Kind == "PointerTo")
        {
            return IsPrimitive(dataType.Child);
        }

        if (dataType.Kind != "Native")
        {
            return false;
        }

        string typeName = GetTypeName(dataType.Name);
        switch (typeName)
        {
            case "void":
            case "int":
            case "uint":
                return true;

            case "nint":
            case "nuint":
                return true;
        }

        return false;
    }

    private static bool IsEnum(string typeName)
    {
        return s_visitedEnums.Contains(typeName);
    }

    private static bool IsStruct(string typeName)
    {
        return s_visitedStructs.Contains(typeName);
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
