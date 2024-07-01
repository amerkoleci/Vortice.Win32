// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D11;

unsafe partial struct ID3DUserDefinedAnnotation
{
    public int BeginEvent(string name)
    {
        fixed (char* namePtr = name)
        {
            return BeginEvent(namePtr);
        }
    }

    public int BeginEvent(ReadOnlySpan<char> name)
    {
        fixed (char* namePtr = name)
        {
            return BeginEvent(namePtr);
        }
    }

    public void SetMarker(string name)
    {
        fixed (char* namePtr = name)
        {
            SetMarker(namePtr);
        }
    }

    public void SetMarker(ReadOnlySpan<char> name)
    {
        fixed (char* namePtr = name)
        {
            SetMarker(namePtr);
        }
    }
}
