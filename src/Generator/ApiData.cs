// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

#nullable disable

using System.Text;

namespace Generator;

public class ApiDataArrayShape
{
    public int Size { get; set; }
}

public class ApiDataType
{
    public string Kind { get; set; }
    public string Name { get; set; }
    public string TargetKind { get; set; }
    public string Api { get; set; }
    public string[] Parents { get; set; }

    // Kind == Array
    public ApiDataArrayShape Shape { get; set; }
    public ApiDataType Child { get; set; }

    // Kind == LPArray
    public bool NullNullTerm { get; set; }
    public int CountParamIndex { get; set; }
    public int CountConst { get; set; }
}

public class ApiDataConstant
{
    public string Name { get; set; }
    public ApiDataType Type { get; set; }
    public string ValueType { get; set; }
    public object Value { get; set; }
}

public class ApiEnumValue
{
    public string Name { get; set; }
    public object Value { get; set; }
}

public class ApiStructField
{
    public string Name { get; set; }
    public ApiDataType Type { get; set; }
}

public class ApiParameter
{
    public string Name { get; set; }
    public ApiDataType Type { get; set; }
    public List<object> Attrs { get; set; } = new();
}

public class ApiType
{
    public string Name { get; set; }
    public string Kind { get; set; }
    public List<object> Attrs { get; set; }

    // Enum
    public bool Flags { get; set; }
    public bool Scoped { get; set; }
    public string IntegerBase { get; set; }
    public IList<ApiEnumValue> Values { get; set; } = new List<ApiEnumValue>();

    // Struct
    public int Size { get; set; }
    public int PackingSize { get; set; }
    public ApiStructField[] Fields { get; set; }
    public ApiType[] NestedTypes { get; set; }

    // Com
    public string Guid { get; set; }
    public ApiDataType Interface { get; set; }
    public IList<ApiType> Methods { get; set; } = new List<ApiType>();

    // Function
    public bool SetLastError { get; set; }
    public ApiDataType ReturnType { get; set; }
    public List<object> ReturnAttrs { get; set; }
    public IList<ApiParameter> Params { get; set; } = new List<ApiParameter>();
    public string DllImport { get; set; }

    public override string ToString()
    {
        return $"{Kind}: {Name}";
    }
}

public sealed class ApiData
{
    public ApiDataConstant[] Constants { get; set; }
    public ApiType[] Types { get; set; }
    public ApiType[] Functions { get; set; }
}
