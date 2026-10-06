// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.Direct3D12.Apis;

namespace Vortice.Win32.Graphics.Direct3D12;

public unsafe partial struct RootDescriptor1
{
    public RootDescriptor1(uint shaderRegister, uint registerSpace = 0, D3D12_ROOT_DESCRIPTOR_FLAGS flags = D3D12_ROOT_DESCRIPTOR_FLAG_NONE)
    {
        Init(out this, shaderRegister, registerSpace, flags);
    }

    public void Init(uint shaderRegister, uint registerSpace = 0, D3D12_ROOT_DESCRIPTOR_FLAGS flags = D3D12_ROOT_DESCRIPTOR_FLAG_NONE)
    {
        Init(out this, shaderRegister, registerSpace, flags);
    }

    public static void Init(out RootDescriptor1 table,
        uint shaderRegister,
        uint registerSpace = 0,
        D3D12_ROOT_DESCRIPTOR_FLAGS flags = D3D12_ROOT_DESCRIPTOR_FLAG_NONE)
    {
        table.ShaderRegister = shaderRegister;
        table.RegisterSpace = registerSpace;
        table.Flags = flags;
    }
}
