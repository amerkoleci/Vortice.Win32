// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D12;

public unsafe partial struct RootConstants
{
    public RootConstants(uint num32BitValues, uint shaderRegister, uint registerSpace = 0)
    {
        Init(out this, num32BitValues, shaderRegister, registerSpace);
    }

    public void Init(uint num32BitValues, uint shaderRegister, uint registerSpace = 0)
    {
        Init(out this, num32BitValues, shaderRegister, registerSpace);
    }

    public static void Init(
        out RootConstants rootConstants,
        uint num32BitValues,
        uint shaderRegister,
        uint registerSpace = 0)
    {
        rootConstants.Num32BitValues = num32BitValues;
        rootConstants.ShaderRegister = shaderRegister;
        rootConstants.RegisterSpace = registerSpace;
    }
}
