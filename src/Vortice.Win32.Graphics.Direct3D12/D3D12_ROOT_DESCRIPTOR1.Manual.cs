// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D3D12;

namespace Vortice.Win32.Graphics;

public unsafe partial struct D3D12_ROOT_DESCRIPTOR1
{
    public D3D12_ROOT_DESCRIPTOR1(uint shaderRegister, uint registerSpace = 0, D3D12_ROOT_DESCRIPTOR_FLAGS flags = D3D12_ROOT_DESCRIPTOR_FLAG_NONE)
    {
        Init(shaderRegister, registerSpace, flags);
    }

    public void Init(uint shaderRegister, uint registerSpace = 0, D3D12_ROOT_DESCRIPTOR_FLAGS flags = D3D12_ROOT_DESCRIPTOR_FLAG_NONE)
    {
        Init(ref this, shaderRegister, registerSpace, flags);
    }

    public static void Init([NativeTypeName("D3D12_ROOT_DESCRIPTOR1 &")] ref D3D12_ROOT_DESCRIPTOR1 table, uint shaderRegister, uint registerSpace = 0, D3D12_ROOT_DESCRIPTOR_FLAGS flags = D3D12_ROOT_DESCRIPTOR_FLAG_NONE)
    {
        table.ShaderRegister = shaderRegister;
        table.RegisterSpace = registerSpace;
        table.Flags = flags;
    }
}
