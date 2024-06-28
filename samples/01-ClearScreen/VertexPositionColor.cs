// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Numerics;
using System.Runtime.InteropServices;

namespace ClearScreen;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public readonly struct VertexPositionColor
{
    public static readonly unsafe int SizeInBytes = sizeof(VertexPositionColor);

    public VertexPositionColor(in Vector3 position, in Vector4 color)
    {
        Position = position;
        Color = color;
    }

    public readonly Vector3 Position;
    public readonly Vector4 Color;
}
