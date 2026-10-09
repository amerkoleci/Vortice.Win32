// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D2D1;

namespace Vortice.Win32.Graphics;

public unsafe partial struct ID2D1Properties
{
    public uint PropertyCount => GetPropertyCount();

    public bool Cached
    {
        set => this.SetValue(unchecked((uint)D2D1_PROPERTY_CACHED), value);
        get => this.GetBoolValue(unchecked((uint)D2D1_PROPERTY_CACHED));
    }
}

public static unsafe partial class ID2D1PropertiesExtensions
{
    public static HRESULT SetValueByName<TD2D1Properties, T>(ref this TD2D1Properties self, ReadOnlySpan<char> name, ReadOnlySpan<T> data)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
        where T : unmanaged
    {
        fixed (char* namePtr = name)
        {
            fixed (T* dataPtr = data)
            {
                return self.SetValueByName(namePtr, D2D1_PROPERTY_TYPE_UNKNOWN, (byte*)dataPtr, (uint)(data.Length * sizeof(T)));
            }
        }
    }

    public static HRESULT SetValueByName<TD2D1Properties>(ref this TD2D1Properties self, ReadOnlySpan<char> name, byte* data, uint dataSize)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        fixed (char* namePtr = name)
        {
            return self.SetValueByName(namePtr, D2D1_PROPERTY_TYPE_UNKNOWN, data, dataSize);
        }
    }

    public static HRESULT SetValueByName<TD2D1Properties>(ref this TD2D1Properties self, char* name, byte* data, uint dataSize)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        return self.SetValueByName(name, D2D1_PROPERTY_TYPE_UNKNOWN, data, dataSize);
    }

    public static HRESULT GetValueByName<TD2D1Properties>(ref this TD2D1Properties self, ReadOnlySpan<char> name, byte* data, uint dataSize)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        fixed (char* namePtr = name)
        {
            return self.GetValueByName(namePtr, D2D1_PROPERTY_TYPE_UNKNOWN, data, dataSize);
        }
    }

    public static HRESULT GetValueByName<TD2D1Properties, T>(ref this TD2D1Properties self, ReadOnlySpan<char> name, ReadOnlySpan<T> data)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
        where T : unmanaged
    {
        fixed (char* namePtr = name)
        {
            fixed (T* dataPtr = data)
            {
                return self.GetValueByName(namePtr, D2D1_PROPERTY_TYPE_UNKNOWN, (byte*)dataPtr, (uint)(data.Length * sizeof(T)));
            }
        }
    }

    public static HRESULT GetValueByName<TD2D1Properties>(ref this TD2D1Properties self, char* name, byte* data, uint dataSize)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        return self.GetValueByName(name, D2D1_PROPERTY_TYPE_UNKNOWN, data, dataSize);
    }

    public static HRESULT GetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, byte* data, uint dataSize)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        return self.GetValue(index, D2D1_PROPERTY_TYPE_UNKNOWN, data, dataSize);
    }

    public static bool GetBoolValue<TD2D1Properties>(ref this TD2D1Properties self, uint index)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        int value = 0;
        self.GetValue(index, D2D1_PROPERTY_TYPE_BOOL, (byte*)&value, (uint)sizeof(Bool32)).ThrowIfFailed();
        return value != 0;
    }

    public static float GetFloatValue<TD2D1Properties>(ref this TD2D1Properties self, uint index)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        float value = 0f;
        self.GetValue(index, D2D1_PROPERTY_TYPE_FLOAT, (byte*)&value, 4).ThrowIfFailed();
        return value;
    }

    public static T GetEnumValue<TD2D1Properties, T>(ref this TD2D1Properties self, uint index)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
        where T : unmanaged, Enum
    {
        T value = default;
        self.GetValue(index, D2D1_PROPERTY_TYPE_ENUM, (byte*)&value, (uint)sizeof(T)).ThrowIfFailed();
        return value;
    }

    public static Guid GetGuidValue<TD2D1Properties>(ref this TD2D1Properties self, uint index)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        Guid value = default;
        self.GetValue(index, D2D1_PROPERTY_TYPE_CLSID, (byte*)&value, (uint)sizeof(Guid)).ThrowIfFailed();
        return value;
    }

    #region SetValue
    public static HRESULT SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, string value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        fixed (char* chars = value)
        {
            return self.SetValue(index, D2D1_PROPERTY_TYPE_STRING, (byte*)chars, (uint)(value.Length + 1));
        }
    }

    public static HRESULT SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, bool value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        Bool32 bValue = value;
        return self.SetValue(index, D2D1_PROPERTY_TYPE_BOOL, (byte*)&bValue, (uint)sizeof(Bool32));
    }

    public static HRESULT SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, Bool32 value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        return self.SetValue(index, D2D1_PROPERTY_TYPE_BOOL, (byte*)&value, (uint)sizeof(Bool32));
    }

    public static HRESULT SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, uint value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        return self.SetValue(index, D2D1_PROPERTY_TYPE_UINT32, (byte*)&value, 4u);
    }

    public static HRESULT SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, int value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        return self.SetValue(index, D2D1_PROPERTY_TYPE_INT32, (byte*)&value, 4u);
    }

    public static HRESULT SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, float value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        return self.SetValue(index, D2D1_PROPERTY_TYPE_FLOAT, (byte*)&value, 4u);
    }

    public static HRESULT SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, Vector2 value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        return self.SetValue(index, D2D1_PROPERTY_TYPE_VECTOR2, (byte*)&value, (uint)sizeof(Vector2));
    }

    public static HRESULT SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, Vector3 value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        return self.SetValue(index, D2D1_PROPERTY_TYPE_VECTOR3, (byte*)&value, (uint)sizeof(Vector3));
    }

    public static HRESULT SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, Vector4 value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        return self.SetValue(index, D2D1_PROPERTY_TYPE_VECTOR4, (byte*)&value, (uint)sizeof(Vector4));
    }

    public static HRESULT SetValue<TD2D1Properties, T>(ref this TD2D1Properties self, uint index, ReadOnlySpan<T> data)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
        where T : unmanaged
    {
        fixed (T* dataPtr = data)
        {
            return self.SetValue(index, D2D1_PROPERTY_TYPE_BLOB, (byte*)dataPtr, (uint)(data.Length * sizeof(T)));
        }
    }

    public static HRESULT SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, IUnknown* value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        return self.SetValue(index, D2D1_PROPERTY_TYPE_IUNKNOWN, (byte*)value, (uint)sizeof(void*));
    }

    public static HRESULT SetValue<TD2D1Properties, T>(ref this TD2D1Properties self, uint index, T* value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
        where T : unmanaged, IUnknown.Interface
    {
        return self.SetValue(index, D2D1_PROPERTY_TYPE_IUNKNOWN, (byte*)value, (uint)sizeof(void*));
    }

    public static HRESULT SetValue<TD2D1Properties, T>(ref this TD2D1Properties self, uint index, T value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
        where T : unmanaged, Enum
    {
        return self.SetValue(index, D2D1_PROPERTY_TYPE_ENUM, (byte*)&value, (uint)sizeof(T));
    }

    public static HRESULT SetEnumValue<TD2D1Properties, T>(ref this TD2D1Properties self, uint index, T value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
        where T : unmanaged, Enum
    {
        return self.SetValue(index, D2D1_PROPERTY_TYPE_ENUM, (byte*)&value, (uint)sizeof(T));
    }

    public static HRESULT SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, Guid value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        return self.SetValue(index, D2D1_PROPERTY_TYPE_CLSID, (byte*)&value, (uint)sizeof(Guid));
    }

    public static HRESULT SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, Matrix3x2 value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        return self.SetValue(index, D2D1_PROPERTY_TYPE_MATRIX_3X2, (byte*)&value, (uint)sizeof(Matrix3x2));
    }

    public static HRESULT SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, Matrix4x3 value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        return self.SetValue(index, D2D1_PROPERTY_TYPE_MATRIX_4X3, (byte*)&value, (uint)sizeof(Matrix4x3));
    }

    public static HRESULT SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, Matrix4x4 value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        return self.SetValue(index, D2D1_PROPERTY_TYPE_MATRIX_4X4, (byte*)&value, (uint)sizeof(Matrix4x4));
    }

    public static HRESULT SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, Matrix5x4 value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        return self.SetValue(index, D2D1_PROPERTY_TYPE_MATRIX_5X4, (byte*)&value, (uint)sizeof(Matrix5x4));
    }

    public static HRESULT SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, ID2D1ColorContext* value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        return self.SetValue(index, D2D1_PROPERTY_TYPE_COLOR_CONTEXT, (byte*)value, (uint)sizeof(void*));
    }

    public static HRESULT SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, byte* data, int dataSize)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        return self.SetValue(index, D2D1_PROPERTY_TYPE_BLOB, data, unchecked((uint)dataSize));
    }

    public static HRESULT SetValue<TD2D1Properties, T, U>(ref this TD2D1Properties self, U index, T* value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
        where T : unmanaged
        where U : unmanaged, Enum
    {
        return self.SetValue(Unsafe.As<U, uint>(ref index), D2D1_PROPERTY_TYPE_UNKNOWN, (byte*)value, unchecked((uint)sizeof(T)));
    }

    #endregion
}
