// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct2D;

public unsafe partial struct ID2D1Properties
{
    public uint PropertyCount => GetPropertyCount();

    public bool Cached
    {
        get => GetBoolValue((uint)Property.Cached);
        set => SetValue((uint)Property.Cached, value);
    }

    public HResult SetValueByName<T>(ReadOnlySpan<char> name, ReadOnlySpan<T> data)
        where T : unmanaged
    {
        fixed (char* namePtr = name)
        {
            fixed (T* dataPtr = data)
            {
                return SetValueByName((ushort*)namePtr, PropertyType.Unknown, (byte*)dataPtr, (uint)(data.Length * sizeof(T)));
            }
        }
    }

    public HResult SetValueByName(ReadOnlySpan<char> name, byte* data, uint dataSize)
    {
        fixed (char* namePtr = name)
        {
            return SetValueByName((ushort*)namePtr, PropertyType.Unknown, data, dataSize);
        }
    }

    public HResult SetValueByName(ushort* name, byte* data, [NativeTypeName("UINT32")] uint dataSize)
    {
        return SetValueByName(name, PropertyType.Unknown, data, dataSize);
    }

    public HResult SetValue(uint index, byte* data, [NativeTypeName("UINT32")] uint dataSize)
    {
        return SetValue(index, PropertyType.Unknown, data, dataSize);
    }

    public HResult GetValueByName(ReadOnlySpan<char> name, byte* data, uint dataSize)
    {
        fixed (char* namePtr = name)
        {
            return GetValueByName((ushort*)namePtr, PropertyType.Unknown, data, dataSize);
        }
    }

    public HResult GetValueByName<T>(ReadOnlySpan<char> name, ReadOnlySpan<T> data)
        where T : unmanaged
    {
        fixed (char* namePtr = name)
        {
            fixed (T* dataPtr = data)
            {
                return GetValueByName((ushort*)namePtr, PropertyType.Unknown, (byte*)dataPtr, (uint)(data.Length * sizeof(T)));
            }
        }
    }

    public HResult GetValueByName(ushort* name, byte* data, uint dataSize)
    {
        return GetValueByName(name, PropertyType.Unknown, data, dataSize);
    }

    public HResult GetValue(uint index, byte* data, uint dataSize)
    {
        return GetValue(index, PropertyType.Unknown, data, dataSize);
    }

    public bool GetBoolValue(uint index)
    {
        int value = 0;
        GetValue(index, PropertyType.Bool, (byte*)&value, (uint)sizeof(Bool32));
        return value != 0;
    }

    public void SetValue(uint index, Bool32 value)
    {
        SetValue(index, PropertyType.Bool, (byte*)&value, (uint)sizeof(Bool32));
    }

    public float GetFloatValue(uint index)
    {
        float value = 0f;
        GetValue(index, PropertyType.Float, (byte*)&value, 4);
        return value;
    }

    public  void SetValue(uint index, float value)
    {
        SetValue(index, PropertyType.Float, (byte*)&value, 4u);
    }

    public T GetEnumValue<T>(uint index) where T : unmanaged, Enum
    {
        T value = default;
        GetValue(index, PropertyType.Enum, (byte*)&value, 4);
        return value;
    }

    public void SetValue<T>(uint index, T value) where T : unmanaged, Enum
    {
        SetValue(index, PropertyType.Enum, (byte*)&value, 4);
    }

    public Guid GetGuidValue(uint index)
    {
        Guid value = default;
        GetValue(index, PropertyType.Clsid, (byte*)&value, (uint)sizeof(Guid));
        return value;
    }

    public void SetValue(uint index, Guid value)
    {
      
        SetValue(index, PropertyType.Clsid, (byte*)&value, (uint)sizeof(Guid));
    }

    public void SetValue(uint index, IUnknown* value)
    {
        SetValue(index, PropertyType.IUnknown, (byte*)value, (uint)sizeof(void*));
    }

    public void SetValue(uint index, ID2D1ColorContext* value)
    {
        SetValue(index, PropertyType.ColorContext, (byte*)value, (uint)sizeof(void*));
    }
}
