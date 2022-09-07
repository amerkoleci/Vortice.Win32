// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Globalization;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Generator;

public static class Program
{
    private static readonly string[] jsons = new[]
    {
        "Graphics.Dxgi.Common.json",
        "Graphics.Dxgi.json",
        "Graphics.Direct3D.json",
        "Graphics.Direct3D11.json",
        "Graphics.Direct3D12.json",
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
        { "D3D_CBUFFER_TYPE", "D3D_CT" },
        { "D3D_INCLUDE_TYPE", "D3D_INCLUDE" },
        { "D3D_SHADER_VARIABLE_CLASS", "D3D_SVC" },
        { "D3D_SHADER_VARIABLE_FLAGS", "D3D_SVF" },
        { "D3D_SHADER_VARIABLE_TYPE", "D3D_SVT" },
        { "D3D_SHADER_INPUT_FLAGS", "D3D_SIF" },
        { "D3D_SHADER_INPUT_TYPE", "D3D_SIT" },
        { "D3D_SHADER_CBUFFER_FLAGS", "D3D_CBF" },

        // D3D11 -> handled in code
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

        { "CBUFFER", "CBuffer" },
        { "TBUFFER", "TBuffer" },
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
        { "RWTEXTURE1D", "RwTexture1D" },
        { "RWTEXTURE1DARRAY", "RwTexture1DArray" },
        { "RWTEXTURE2D", "RwTexture2D" },
        { "RWTEXTURE2DARRAY", "RwTexture2DArray" },
        { "RWTEXTURE3D", "RwTexture3D" },
        { "RWBUFFER", "RwBuffer" },
        { "BUFFEREX", "BufferExtended" },
        { "USERPACKED", "UserPacked" },
        { "SAMPLER1D", "Sampler1D" },
        { "SAMPLER2D", "Sampler2D" },
        { "SAMPLER3D", "Sampler3D" },
        { "SAMPLERCUBE", "SamplerCube" },
        { "RWTYPED", "RwTyped" },
        { "RWSTRUCTURED", "RwStructured" },
        { "BYTEADDRESS", "ByteAddress" },
        { "RWBYTEADDRESS", "RwByteAddress" },
        { "RTACCELERATIONSTRUCTURE", "RtAccelerationStructure" },
        { "FEEDBACKTEXTURE", "FeedbackTexture" },
        { "TESSFACTOR", "TessFactor" },
        { "SHADINGRATE", "ShadingRate" },
        { "CULLPRIMITIVE", "CullPrimitive" },
        { "VERTEXSHADER", "VertexShader" },
        { "PIXELSHADER", "PixelShader" },
        { "VERTEXFRAGMENT", "VertexFragment" },
        { "PIXELFRAGMENT", "PixelFragment" },
        { "GEOMETRYSHADER", "GeometryShader" },
        { "DOMAINSHADER", "DomainShader" },
        { "COMPUTESHADER", "ComputeShader" },
        { "DEPTHSTENCIL", "DepthStencil" },
        { "RENDERTARGETVIEW", "RenderTargetView" },
        { "DEPTHSTENCILVIEW", "DepthStencilView" },
        { "MIN8FLOAT", "Min8Float" },
        { "MIN10FLOAT", "Min10Float" },
        { "MIN16FLOAT", "Min16Float" },
        { "MIN12INT", "Min12Int" },
        { "MIN16INT", "Min16Int" },
        { "MIN16UINT", "Min16Uint" },
        { "KEYEDMUTEX", "KeyedMutex" },
    };

    private static readonly Dictionary<string, string> s_knownEnumValueNames = new()
    {
        { "DXGI_FORMAT_420_OPAQUE", "Opaque420" },
        { "DXGI_OUTDUPL_COMPOSITED_UI_CAPTURE_ONLY", "CompositedUICaptureOnly" },
        { "D3D_FEATURE_LEVEL_9_1", "Level_9_1" },

        // D3D11
        { "D3D11_STANDARD_MULTISAMPLE_PATTERN", "Standard" },
        { "D3D11_CENTER_MULTISAMPLE_PATTERN", "Center" },
        { "D3D11_SHADER_MIN_PRECISION_10_BIT", "Bit10" },
        { "D3D11_SHADER_MIN_PRECISION_16_BIT", "Bit16" },
        { "D3D11_SHARED_RESOURCE_TIER_0", "Tier0" },
        { "D3D11_SHARED_RESOURCE_TIER_1", "Tier1" },
        { "D3D11_SHARED_RESOURCE_TIER_2", "Tier2" },
        { "D3D11_SHARED_RESOURCE_TIER_3", "Tier3" },
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

    private static readonly HashSet<string> s_ignoredStartParts = new(StringComparer.OrdinalIgnoreCase)
    {
        "DXGI",
        "D3D",
        "D3D10",
        "D3D11",
        "D3D12",
    };

    private static readonly HashSet<string> s_ignoredParts = new(StringComparer.OrdinalIgnoreCase)
    {
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

        // D3D11
        { "D3D11_BIND_FLAG", "BindFlags" },
        { "D3D11_CPU_ACCESS_FLAG", "CpuAccessFlags" },
        { "D3D11_RESOURCE_MISC_FLAG", "ResourceMiscFlags" },
        { "D3D11_MAP_FLAG", "MapFlags" },
        { "D3D11_FORMAT_SUPPORT", "FormatSupport" },
        { "D3D11_FORMAT_SUPPORT2", "FormatSupport2" },
        { "D3D11_DSV_FLAG", "DsvFlags" },
    };

    private static readonly Dictionary<string, string> s_structFieldTypeRemap = new()
    {
        { "DXGI_ADAPTER_DESC1::Flags", "DXGI_ADAPTER_FLAG" },
        { "DXGI_ADAPTER_DESC3::Flags", "DXGI_ADAPTER_FLAG3" },
        { "DXGI_SWAP_CHAIN_DESC::BufferUsage", "Usage" },
        { "DXGI_SWAP_CHAIN_DESC::Flags", "DXGI_SWAP_CHAIN_FLAG" },
        { "DXGI_SWAP_CHAIN_DESC1::BufferUsage", "Usage" },
        { "DXGI_SWAP_CHAIN_DESC1::Flags", "DXGI_SWAP_CHAIN_FLAG" },

        // D3D11
        { "D3D11_BUFFER_DESC::BindFlags", "D3D11_BIND_FLAG" },
        { "D3D11_BUFFER_DESC::CPUAccessFlags", "D3D11_CPU_ACCESS_FLAG" },
        { "D3D11_BUFFER_DESC::MiscFlags", "D3D11_RESOURCE_MISC_FLAG" },

        { "D3D11_TEXTURE1D_DESC::BindFlags", "D3D11_BIND_FLAG" },
        { "D3D11_TEXTURE1D_DESC::CPUAccessFlags", "D3D11_CPU_ACCESS_FLAG" },
        { "D3D11_TEXTURE1D_DESC::MiscFlags", "D3D11_RESOURCE_MISC_FLAG" },

        { "D3D11_TEXTURE2D_DESC::BindFlags", "D3D11_BIND_FLAG" },
        { "D3D11_TEXTURE2D_DESC::CPUAccessFlags", "D3D11_CPU_ACCESS_FLAG" },
        { "D3D11_TEXTURE2D_DESC::MiscFlags", "D3D11_RESOURCE_MISC_FLAG" },

        { "D3D11_TEXTURE3D_DESC::BindFlags", "D3D11_BIND_FLAG" },
        { "D3D11_TEXTURE3D_DESC::CPUAccessFlags", "D3D11_CPU_ACCESS_FLAG" },
        { "D3D11_TEXTURE3D_DESC::MiscFlags", "D3D11_RESOURCE_MISC_FLAG" },

        { "D3D11_FEATURE_DATA_FORMAT_SUPPORT::OutFormatSupport", "D3D11_FORMAT_SUPPORT" },
        { "D3D11_FEATURE_DATA_FORMAT_SUPPORT2::OutFormatSupport2", "D3D11_FORMAT_SUPPORT2" },

        { "D3D11_DEPTH_STENCIL_VIEW_DESC::Flags", "D3D11_DSV_FLAG" },
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
        //DocGenerator.Generate(new[] { "D3D" }, Path.Combine(outputPath, "Direct3D.xml"));
        //DocGenerator.Generate(new[] { "DXGI" }, Path.Combine(outputPath, "Dxgi.xml"));
        //DocGenerator.Generate(new[] { "D3D11" }, Path.Combine(outputPath, "Direct3D11.xml"));
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
        GenerateFunctions(writer, api);
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
                else if (typeName == "float")
                {
                    float floatValue = Convert.ToSingle(constant.Value);
                    writer.WriteLine($"public const float {constant.Name} = {floatValue.ToString(CultureInfo.InvariantCulture)}f;");
                }
                else if (typeName == "double")
                {
                    double dblValue = Convert.ToDouble(constant.Value);
                    writer.WriteLine($"public const double {constant.Name} = {dblValue.ToString(CultureInfo.InvariantCulture)};");
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

        // Unions
        writer.WriteLine($"#region Unions");
        foreach (ApiType structType in api.Types.Where(item => item.Kind.ToLowerInvariant() == "union"))
        {
            if (s_csNameMappings.ContainsKey($"{writer.Api}.{structType.Name}"))
            {
                continue;
            }

            GenerateStruct(writer, structType);

            s_visitedStructs.Add($"{writer.Api}.{structType.Name}");
        }
        writer.WriteLine($"#endregion Unions");
        writer.WriteLine();

        // Structs
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

    private static void GenerateFunctions(CodeWriter writer, ApiData api)
    {
        if (api.Functions.Length == 0)
            return;

        writer.WriteLine($"#region Functions");
        using (writer.PushBlock($"public static unsafe partial class Apis"))
        {
            foreach (ApiFunction function in api.Functions)
            {
                if (function.Name.StartsWith("D3DX11") ||
                    function.Name == "D3DDisassemble11Trace")
                    continue;

                WriteFunction(writer, api, function);
                writer.WriteLine();
            }
        }

        writer.WriteLine($"#endregion Functions");
    }

    private static void WriteFunction(CodeWriter writer, ApiData api, ApiFunction function)
    {
        string returnType = GetTypeName(function.ReturnType);
        string functionSuffix = string.Empty;

        if (string.IsNullOrEmpty(function.DllImport) == false)
        {
            functionSuffix = "static extern ";
            writer.WriteLine($"[DllImport(\"{function.DllImport}\", ExactSpelling = true)]");
        }

        StringBuilder argumentBuilder = new();
        StringBuilder argumentsTypesBuilder = new();
        StringBuilder argumentsNameBuilder = new();
        int parameterIndex = 0;
        foreach (ApiParameter parameter in function.Params)
        {
            bool asPointer = false;
            string parameterType = default;
            if (parameter.Type.Kind == "ApiRef")
            {
                if (parameter.Type.TargetKind == "FunctionPointer")
                {
                    var functionType = api.Types.First(item => item.Name == parameter.Type.Name && item.Kind == "FunctionPointer");
                    parameterType = "delegate* unmanaged[Stdcall]<void*, void>";
                }
                else
                {
                    string fullTypeName = $"{parameter.Type.Api}.{parameter.Type.Name}";
                    if (!IsPrimitive(parameter.Type) && !IsEnum(fullTypeName))
                    {
                        asPointer = true;
                    }
                }
            }

            if (string.IsNullOrEmpty(parameterType))
            {
                parameterType = GetTypeName(parameter.Type, asPointer);
            }

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

            if (parameterIndex < function.Params.Count - 1)
            {
                argumentBuilder.Append(", ");
                argumentsTypesBuilder.Append(", ");
                argumentsNameBuilder.Append(", ");
            }

            parameterIndex++;
        }

        string argumentsString = argumentBuilder.ToString();
        writer.Write($"public {functionSuffix}{returnType} {function.Name}({argumentsString})");
        writer.WriteLine(";");
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

        bool isFlags = false;
        if (enumType.Flags ||
            csTypeName.EndsWith("Flag") ||
            csTypeName.EndsWith("Flags"))
        {
            isFlags = true;
            writer.WriteLine("[Flags]");
        }

        if (csTypeName == "ShaderCacheSupportFlags")
        {

        }

        using (writer.PushBlock($"public enum {csTypeName} : {baseTypeName}"))
        {
            if (isFlags &&
                !enumType.Values.Any(item => GetEnumItemName(enumType, item, enumPrefix) == "None"))
            {
                writer.WriteLine("None = 0,");
            }

            foreach (ApiEnumValue enumItem in enumType.Values)
            {
                if (enumItem.Name.EndsWith("_FORCE_DWORD") ||
                    enumItem.Name.EndsWith("_FORCE_UINT"))
                {
                    continue;
                }

                // Ignore D3D10, D3D11 and D3D12 in D3D
                if (enumType.Name.StartsWith("D3D_"))
                {
                    if (enumItem.Name.StartsWith("D3D10_") ||
                        enumItem.Name.StartsWith("D3D11_") ||
                        enumItem.Name.StartsWith("D3D12_"))
                    {
                        continue;
                    }
                }

                if (enumItem.Name.EndsWith("_MESSAGES_START") ||
                    enumItem.Name.EndsWith("_MESSAGES_END"))
                {
                    continue;
                }

                string enumValueName = GetEnumItemName(enumType, enumItem, enumPrefix);

                if (!autoGenerated)
                {
                    writer.WriteLine($"/// <include file='../{writer.DocFileName}.xml' path='doc/member[@name=\"{enumType.Name}::{enumItem.Name}\"]/*' />");
                }

                if (s_generateUnmanagedDocs)
                {
                    writer.WriteLine($"/// <unmanaged>{enumItem.Name}</unmanaged>");
                }

                if (enumValueName.StartsWith("DXGI_MSG_"))
                {
                    enumValueName = enumValueName.Substring("DXGI_MSG_".Length);
                }

                writer.WriteLine($"{enumValueName} = {enumItem.Value},");
            }
        }

        writer.WriteLine();
    }

    private static string GetEnumItemName(ApiType enumType, ApiEnumValue enumItem, string enumPrefix)
    {
        string enumValueName = GetPrettyFieldName(enumItem.Name, enumPrefix);

        // D3D11 has some enum name "issues"
        // D3D11_FILL_MODE -> D3D11_FILL_*
        if (enumValueName.StartsWith("D3D11_"))
        {
            string[] parts = enumType.Name.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
            enumPrefix = string.Join("_", parts.Take(parts.Length - 1));
            enumValueName = GetPrettyFieldName(enumItem.Name, enumPrefix);
        }

        return enumValueName;
    }

    private static void GenerateStruct(CodeWriter writer, ApiType structType, bool nestedType = false)
    {
        string csTypeName;
        string structPrefix = string.Empty;

        if (nestedType)
        {
            csTypeName = structType.Name;
        }
        else
        {
            csTypeName = GetDataTypeName(structType.Name, out structPrefix);
            AddCsMapping(writer.Api, structType.Name, csTypeName);

            writer.WriteLine($"/// <include file='../{writer.DocFileName}.xml' path='doc/member[@name=\"{structType.Name}\"]/*' />");

            if (s_generateUnmanagedDocs)
            {
                writer.WriteLine($"/// <unmanaged>{structType.Name}</unmanaged>");
            }
        }

        bool isUnion = structType.Kind == "Union";
        if (isUnion)
        {
            writer.WriteLine("[StructLayout(LayoutKind.Explicit)]");
        }

        using (writer.PushBlock($"public partial struct {csTypeName}"))
        {
            int fieldIndex = 0;
            foreach (ApiStructField field in structType.Fields)
            {
                if (field.Name.EndsWith("_FORCE_DWORD"))
                    continue;

                string fieldValueName;
                if (nestedType)
                {
                    fieldValueName = field.Name;
                }
                else
                {
                    fieldValueName = GetPrettyFieldName(field.Name, structPrefix);
                }

                if (structType.Name == "D3D11_OMAC")
                {
                    fieldValueName = "Buffer";
                }
                else if (structType.Name == "D3D12_NODE_MASK")
                {
                    fieldValueName = "Mask";
                }

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
                        if (isUnion)
                        {
                            writer.WriteLine("[FieldOffset(0)]");
                        }

                        writer.WriteLine($"public unsafe fixed {fieldTypeName} {fieldValueName}[{field.Type.Shape.Size}];");
                    }
                    else
                    {
                        writer.WriteLine($"public {fieldValueName}__FixedBuffer {fieldValueName};");
                        writer.WriteLine();

                        using (writer.PushBlock($"public unsafe struct {fieldValueName}__FixedBuffer"))
                        {
                            int arraySize = field.Type.Shape != null ? field.Type.Shape.Size : 1;

                            for (int i = 0; i < arraySize; i++)
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
                                writer.WriteLine($"return MemoryMarshal.CreateSpan(ref e0, {arraySize});");
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

                    if (isUnion)
                    {
                        writer.WriteLine("[FieldOffset(0)]");
                    }
                    writer.WriteLine($"public {unsafePrefix}{fieldTypeName} {fieldValueName};");
                }

                if (fieldIndex < structType.Fields.Length - 1)
                {
                    writer.WriteLine();
                }

                fieldIndex++;
            }

            // Generate nested types
            if (structType.NestedTypes.Length > 0)
            {
                writer.WriteLine();

                if (isUnion == false)
                {
                    foreach (ApiType nestedTypeToGenerate in structType.NestedTypes)
                    {
                        foreach (ApiStructField field in nestedTypeToGenerate.Fields)
                        {
                            ApiStructField parentMemberAccess = structType.Fields.First(item => item.Type.Name == nestedTypeToGenerate.Name);
                            string fieldTypeName = GetTypeName(field.Type);
                            fieldTypeName = NormalizeTypeName(writer.Api, fieldTypeName);

                            string fieldName = GetPrettyFieldName(field.Name, structPrefix);

                            writer.WriteLine("[UnscopedRef]");
                            if (fieldTypeName == "Array")
                            {
                                fieldTypeName = GetTypeName(field.Type.Child);

                                using (writer.PushBlock($"public unsafe Span<{fieldTypeName}> {fieldName}"))
                                {
                                    writer.WriteLine("[MethodImpl(MethodImplOptions.AggressiveInlining)]");
                                    using (writer.PushBlock("get"))
                                    {
                                        writer.WriteLine($"return MemoryMarshal.CreateSpan(ref {parentMemberAccess.Name}.{fieldName}[0], {field.Type.Shape.Size});");
                                    }
                                }
                            }
                            else
                            {
                                if (fieldName == "pGeometryDescs")
                                {

                                }

                                string unsafePrefix = string.Empty;
                                if (fieldTypeName.EndsWith("*"))
                                {
                                    unsafePrefix += "unsafe ";
                                }

                                using (writer.PushBlock($"public {unsafePrefix}ref {fieldTypeName} {fieldName}"))
                                {
                                    writer.WriteLine("[MethodImpl(MethodImplOptions.AggressiveInlining)]");
                                    using (writer.PushBlock("get"))
                                    {
                                        writer.WriteLineUndindented("#if NET7_0_OR_GREATER");
                                        writer.WriteLine($"return ref {parentMemberAccess.Name}.{fieldName};");
                                        writer.WriteLineUndindented("#else");
                                        if (fieldTypeName.EndsWith("*"))
                                        {
                                            writer.WriteLine($"return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).{parentMemberAccess.Name}.{fieldName};");
                                        }
                                        else
                                        {
                                            writer.WriteLine($"return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref {parentMemberAccess.Name}.{fieldName}, 1));");
                                        }

                                        writer.WriteLineUndindented("#endif");
                                    }
                                }
                            }

                            writer.WriteLine();
                        }
                    }
                }

                foreach (ApiType nestedTypeToGenerate in structType.NestedTypes)
                {
                    GenerateStruct(writer, nestedTypeToGenerate, true);
                }
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
                    if (method.Name == "SetBreakOnSeverity")
                    {

                    }

                    bool asPointer = false;
                    string parameterType = default;
                    if (parameter.Type.Kind == "ApiRef")
                    {
                        if (parameter.Type.TargetKind == "FunctionPointer")
                        {
                            var functionType = api.Types.First(item => item.Name == parameter.Type.Name && item.Kind == "FunctionPointer");
                            parameterType = "delegate* unmanaged[Stdcall]<void*, void>";
                        }
                        else
                        {
                            string fullTypeName = $"{parameter.Type.Api}.{parameter.Type.Name}";
                            if (!IsPrimitive(parameter.Type) && !IsEnum(fullTypeName))
                            {
                                asPointer = true;
                            }
                        }
                    }

                    if (string.IsNullOrEmpty(parameterType))
                    {
                        parameterType = GetTypeName(parameter.Type, asPointer);
                    }

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

                string methodSuffix = string.Empty;
                if (method.Name == "GetType")
                {
                    if (string.IsNullOrEmpty(argumentsString))
                    {
                        methodSuffix = "new ";
                    }
                }

                using (writer.PushBlock($"public {methodSuffix}{returnType} {method.Name}({argumentsString})"))
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
            constant.Name == "DXGI_FORMAT_DEFINED" ||
            constant.Name == "D3D11_FLOAT32_MAX" ||
            constant.Name.StartsWith("D3DX11_"))
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
        for (int i = 0; i < parts.Length; i++)
        {
            string part = parts[i];

            if (i == 0 && s_ignoredStartParts.Contains(part))
            {
                continue;
            }

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
                if (s_partRenames.TryGetValue(part, out string? partRemap))
                {
                    sb.Append(partRemap!);
                }
                else if (part == "DESC")
                {
                    sb.Append("Description");
                }
                else if (part == "DESC1")
                {
                    sb.Append("Description1");
                }
                else if (part == "DESC2")
                {
                    sb.Append("Description2");
                }
                else if (part == "DESC3")
                {
                    sb.Append("Description3");
                }
                else
                {
                    sb.Append(char.ToUpper(part[0]));
                    for (int j = 1; j < part.Length; j++)
                    {
                        sb.Append(char.ToLower(part[j]));
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

        for (int i = 0; i < parts.Length; i++)
        {
            string part = parts[i];

            if (i == 0 && s_ignoredStartParts.Contains(part))
            {
                continue;
            }

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
                    if (s_partRenames.TryGetValue(part, out string? partRemap))
                    {
                        sb.Append(partRemap!);
                    }
                    else
                    {
                        sb.Append(char.ToUpper(part[0]));
                        for (int j = 1; j < part.Length; j++)
                        {
                            sb.Append(char.ToLower(part[j]));
                        }
                    }
                }
            }

            if (appendUnderscore)
            {
                if (i < parts.Length - 1)
                {
                    sb.Append('_');
                }
            }
        }

        string prettyName = sb.ToString();
        if (string.IsNullOrEmpty(prettyName))
        {
            return parts[0];
        }

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
            string apiName = dataType.Api;
            if (dataType.Parents?.Length > 0)
            {
                apiName += ".";
                apiName += string.Join(".", dataType.Parents);
            }

            string typeName = GetTypeName($"{apiName}.{dataType.Name}");
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

    private static bool IsPrimitive(string typeName)
    {
        switch (typeName)
        {
            case "void":
            case "bool":
            case "int":
            case "uint":
            case "Bool32":
                return true;

            case "nint":
            case "nuint":
            case "IntPtr":
            case "UIntPtr":
                return true;
        }

        return false;
    }

    private static bool IsPrimitive(ApiDataType dataType)
    {
        if (dataType.Kind == "ApiRef")
        {
            string apiRefType = GetTypeName($"{dataType.Api}.{dataType.Name}");
            return IsPrimitive(apiRefType);
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
        return IsPrimitive(typeName);
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
