// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Graphics;

public unsafe partial struct D3D12_ROOT_CONSTANTS
{
    public D3D12_ROOT_CONSTANTS(uint num32BitValues, uint shaderRegister, uint registerSpace = 0)
    {
        Init(num32BitValues, shaderRegister, registerSpace);
    }

    public void Init(uint num32BitValues, uint shaderRegister, uint registerSpace = 0)
    {
        Init(ref this, num32BitValues, shaderRegister, registerSpace);
    }

    public static void Init([NativeTypeName("D3D12_ROOT_CONSTANTS &")] ref D3D12_ROOT_CONSTANTS rootConstants, uint num32BitValues, uint shaderRegister, uint registerSpace = 0)
    {
        rootConstants.Num32BitValues = num32BitValues;
        rootConstants.ShaderRegister = shaderRegister;
        rootConstants.RegisterSpace = registerSpace;
    }
}
