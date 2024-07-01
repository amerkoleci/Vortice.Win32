// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D12;

public unsafe partial struct RootDescriptor
{
    public RootDescriptor(uint shaderRegister, uint registerSpace = 0)
    {
        Init(out this, shaderRegister, registerSpace);
    }

    public void Init(uint shaderRegister, uint registerSpace = 0)
    {
        Init(out this, shaderRegister, registerSpace);
    }

    public static void Init(out RootDescriptor table, uint shaderRegister, uint registerSpace = 0)
    {
        table.ShaderRegister = shaderRegister;
        table.RegisterSpace = registerSpace;
    }
}
