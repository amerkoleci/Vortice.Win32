// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D12;

public unsafe partial struct RootDescriptor1
{
    public RootDescriptor1(uint shaderRegister, uint registerSpace = 0, RootDescriptorFlags flags = RootDescriptorFlags.None)
    {
        Init(out this, shaderRegister, registerSpace, flags);
    }

    public void Init(uint shaderRegister, uint registerSpace = 0, RootDescriptorFlags flags = RootDescriptorFlags.None)
    {
        Init(out this, shaderRegister, registerSpace, flags);
    }

    public static void Init(out RootDescriptor1 table,
        uint shaderRegister,
        uint registerSpace = 0,
        RootDescriptorFlags flags = RootDescriptorFlags.None)
    {
        table.ShaderRegister = shaderRegister;
        table.RegisterSpace = registerSpace;
        table.Flags = flags;
    }
}
