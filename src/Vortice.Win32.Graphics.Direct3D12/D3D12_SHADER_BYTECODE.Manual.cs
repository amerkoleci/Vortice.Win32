// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Graphics;

public unsafe partial struct D3D12_SHADER_BYTECODE
{
    public D3D12_SHADER_BYTECODE(ID3DBlob* shaderBlob)
    {
        pShaderBytecode = shaderBlob->GetBufferPointer();
        BytecodeLength = shaderBlob->GetBufferSize();
    }

    public D3D12_SHADER_BYTECODE(void* shaderBytecode, nuint bytecodeLength)
    {
        pShaderBytecode = shaderBytecode;
        BytecodeLength = bytecodeLength;
    }
}
