// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct2D;

public unsafe partial struct ID2D1Properties
{
    public uint PropertyCount => GetPropertyCount();

    public bool Cached
    {
        set => this.SetValue(unchecked((uint)Property.Cached), value);
        get => this.GetBoolValue(unchecked((uint)Property.Cached));
    }
}

public static unsafe partial class ID2D1PropertiesExtensions
{
    public static HResult SetValueByName<TD2D1Properties, T>(ref this TD2D1Properties self, ReadOnlySpan<char> name, ReadOnlySpan<T> data)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
        where T : unmanaged
    {
        fixed (char* namePtr = name)
        {
            fixed (T* dataPtr = data)
            {
                return self.SetValueByName((ushort*)namePtr, PropertyType.Unknown, (byte*)dataPtr, (uint)(data.Length * sizeof(T)));
            }
        }
    }

    public static HResult SetValueByName<TD2D1Properties>(ref this TD2D1Properties self, ReadOnlySpan<char> name, byte* data, uint dataSize)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        fixed (char* namePtr = name)
        {
            return self.SetValueByName((ushort*)namePtr, PropertyType.Unknown, data, dataSize);
        }
    }

    public static HResult SetValueByName<TD2D1Properties>(ref this TD2D1Properties self, ushort* name, byte* data, uint dataSize)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        return self.SetValueByName(name, PropertyType.Unknown, data, dataSize);
    }

    public static HResult GetValueByName<TD2D1Properties>(ref this TD2D1Properties self, ReadOnlySpan<char> name, byte* data, uint dataSize)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        fixed (char* namePtr = name)
        {
            return self.GetValueByName((ushort*)namePtr, PropertyType.Unknown, data, dataSize);
        }
    }

    public static HResult GetValueByName<TD2D1Properties, T>(ref this TD2D1Properties self, ReadOnlySpan<char> name, ReadOnlySpan<T> data)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
        where T : unmanaged
    {
        fixed (char* namePtr = name)
        {
            fixed (T* dataPtr = data)
            {
                return self.GetValueByName((ushort*)namePtr, PropertyType.Unknown, (byte*)dataPtr, (uint)(data.Length * sizeof(T)));
            }
        }
    }

    public static HResult GetValueByName<TD2D1Properties>(ref this TD2D1Properties self, ushort* name, byte* data, uint dataSize)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        return self.GetValueByName(name, PropertyType.Unknown, data, dataSize);
    }

    public static HResult GetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, byte* data, uint dataSize)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        return self.GetValue(index, PropertyType.Unknown, data, dataSize);
    }

    public static bool GetBoolValue<TD2D1Properties>(ref this TD2D1Properties self, uint index)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        int value = 0;
        self.GetValue(index, PropertyType.Bool, (byte*)&value, (uint)sizeof(Bool32));
        return value != 0;
    }

    public static float GetFloatValue<TD2D1Properties>(ref this TD2D1Properties self, uint index)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        float value = 0f;
        self.GetValue(index, PropertyType.Float, (byte*)&value, 4);
        return value;
    }

    public static T GetEnumValue<TD2D1Properties, T>(ref this TD2D1Properties self, uint index)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
        where T : unmanaged, Enum
    {
        T value = default;
        self.GetValue(index, PropertyType.Enum, (byte*)&value, 4);
        return value;
    }

    public static Guid GetGuidValue<TD2D1Properties>(ref this TD2D1Properties self, uint index)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        Guid value = default;
        self.GetValue(index, PropertyType.Clsid, (byte*)&value, (uint)sizeof(Guid));
        return value;
    }

    #region SetValue
    public static void SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, string value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        fixed (char* chars = value)
        {
            self.SetValue(index, PropertyType.String, (byte*)chars, (uint)(value.Length + 1));
        }
    }

    public static void SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, bool value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        Bool32 bValue = value;
        self.SetValue(index, PropertyType.Bool, (byte*)&bValue, (uint)sizeof(Bool32));
    }

    public static void SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, Bool32 value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        self.SetValue(index, PropertyType.Bool, (byte*)&value, (uint)sizeof(Bool32));
    }


    public static void SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, uint value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        self.SetValue(index, PropertyType.UInt32, (byte*)&value, 4u);
    }

    public static void SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, int value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        self.SetValue(index, PropertyType.Int32, (byte*)&value, 4u);
    }

    public static void SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, float value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        self.SetValue(index, PropertyType.Float, (byte*)&value, 4u);
    }

    public static void SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, Vector2 value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        self.SetValue(index, PropertyType.Vector2, (byte*)&value, (uint)sizeof(Vector2));
    }

    public static void SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, Vector3 value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        self.SetValue(index, PropertyType.Vector3, (byte*)&value, (uint)sizeof(Vector3));
    }

    public static void SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, Vector4 value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        self.SetValue(index, PropertyType.Vector4, (byte*)&value, (uint)sizeof(Vector4));
    }

    public static void SetValue<TD2D1Properties, T>(ref this TD2D1Properties self, uint index, ReadOnlySpan<T> data)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
        where T : unmanaged
    {
        fixed (T* dataPtr = data)
        {
            self.SetValue(index, PropertyType.Blob, (byte*)dataPtr, (uint)(data.Length * sizeof(T)));
        }
    }

    public static void SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, IUnknown* value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        self.SetValue(index, PropertyType.IUnknown, (byte*)value, (uint)sizeof(void*));
    }

    public static void SetValue<TD2D1Properties, T>(ref this TD2D1Properties self, uint index, T* value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
        where T : unmanaged, IUnknown.Interface
    {
        self.SetValue(index, PropertyType.IUnknown, (byte*)value, (uint)sizeof(void*));
    }

    public static void SetValue<TD2D1Properties, T>(ref this TD2D1Properties self, uint index, T value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
        where T : unmanaged, Enum
    {
        self.SetValue(index, PropertyType.Enum, (byte*)&value, 4);
    }
    public static void SetEnumValue<TD2D1Properties, T>(ref this TD2D1Properties self, uint index, T value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
        where T : unmanaged, Enum
    {
        self.SetValue(index, PropertyType.Enum, (byte*)&value, 4);
    }

    public static void SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, Guid value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        self.SetValue(index, PropertyType.Clsid, (byte*)&value, (uint)sizeof(Guid));
    }

    public static void SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, Matrix3x2 value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        self.SetValue(index, PropertyType.Matrix3x2, (byte*)&value, (uint)sizeof(Matrix3x2));
    }

    public static void SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, Matrix4x3 value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        self.SetValue(index, PropertyType.Matrix4x3, (byte*)&value, (uint)sizeof(Matrix4x3));
    }

    public static void SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, Matrix4x4 value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        self.SetValue(index, PropertyType.Matrix4x4, (byte*)&value, (uint)sizeof(Matrix4x4));
    }

    public static void SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, Matrix5x4 value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        self.SetValue(index, PropertyType.Matrix5x4, (byte*)&value, (uint)sizeof(Matrix5x4));
    }

    public static void SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, ID2D1ColorContext* value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        self.SetValue(index, PropertyType.ColorContext, (byte*)value, (uint)sizeof(void*));
    }

    public static HResult SetValue<TD2D1Properties>(ref this TD2D1Properties self, uint index, byte* data, int dataSize)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
    {
        return self.SetValue(index, PropertyType.Blob, data, unchecked((uint)dataSize));
    }

    public static HResult SetValue<TD2D1Properties, T, U>(ref this TD2D1Properties self, U index, T* value)
        where TD2D1Properties : unmanaged, ID2D1Properties.Interface
        where T : unmanaged
        where U : unmanaged
    {
        return self.SetValue((uint)(object)index, PropertyType.Unknown, (byte*)value, unchecked((uint)sizeof(T)));
    }

    #endregion
}
