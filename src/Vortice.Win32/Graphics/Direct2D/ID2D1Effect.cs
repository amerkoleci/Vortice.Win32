// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct2D;

public unsafe partial struct ID2D1Effect
{
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

    public HResult SetValueByName(ushort* name, byte* data, uint dataSize)
    {
        return SetValueByName(name, PropertyType.Unknown, data, dataSize);
    }

    public HResult SetValue(uint index, byte* data, uint dataSize)
    {
        return SetValue(index, PropertyType.Unknown, data, dataSize);
    }

    public HResult GetValueByName(ushort* name, byte* data, uint dataSize)
    {
        return GetValueByName(name, PropertyType.Unknown, data, dataSize);
    }

    public HResult GetValueByName(ReadOnlySpan<char> name, byte* data, uint dataSize)
    {
        fixed (char* namePtr = name)
        {
            return GetValueByName((ushort*)namePtr, PropertyType.Unknown, data, dataSize);
        }
    }

    public HResult GetValue(uint index, byte* data, uint dataSize)
    {
        return GetValue(index, PropertyType.Unknown, data, dataSize);
    }

    public void SetInput(uint index, ID2D1Image* input)
    {
        SetInput(index, input, 1);
    }

    public void SetInputEffect(uint index, ID2D1Effect* inputEffect, bool invalidate = true)
    {
        ID2D1Image* output = null;

        if (inputEffect != null)
        {
            inputEffect->GetOutput(&output);
        }

        SetInput(index, output, invalidate);
        if (output != null)
        {
            _ = output->Release();
        }
    }
}
