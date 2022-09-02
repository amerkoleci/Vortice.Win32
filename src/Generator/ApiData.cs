// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

#nullable disable

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

    // Kind == Array
    public ApiDataArrayShape Shape { get; set; }
    public ApiDataType Child { get; set; }
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
}

public class ApiFunction
{
    public string Name { get; set; }
    public bool SetLastError { get; set; }
    public ApiDataType ReturnType { get; set; }
    public IList<ApiParameter> Params { get; set; } = new List<ApiParameter>();
    public List<object> Attrs { get; set; }
}

public class ApiType
{
    public string Name { get; set; }
    public string Kind { get; set; }

    // Enum
    public bool Flags { get; set; }
    public bool Scoped { get; set; }
    public string IntegerBase { get; set; }
    public IList<ApiEnumValue> Values { get; set; } = new List<ApiEnumValue>();

    // Struct
    public int Size { get; set; }
    public int PackingSize { get; set; }
    public ApiStructField[] Fields { get; set; }

    // Com
    public string Guid { get; set; }
    public ApiDataType Interface { get; set; }
    public IList<ApiFunction> Methods { get; set; } = new List<ApiFunction>();
}

public sealed class ApiData
{
    public ApiDataConstant[] Constants { get; set; }
    public ApiType[] Types { get; set; }
}
