// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Graphics;

public unsafe partial struct D3D12_ROOT_DESCRIPTOR
{
    public D3D12_ROOT_DESCRIPTOR(uint shaderRegister, uint registerSpace = 0)
    {
        Init(shaderRegister, registerSpace);
    }

    public void Init(uint shaderRegister, uint registerSpace = 0)
    {
        Init(ref this, shaderRegister, registerSpace);
    }

    public static void Init([NativeTypeName("D3D12_ROOT_DESCRIPTOR &")] ref D3D12_ROOT_DESCRIPTOR table, uint shaderRegister, uint registerSpace = 0)
    {
        table.ShaderRegister = shaderRegister;
        table.RegisterSpace = registerSpace;
    }
}
