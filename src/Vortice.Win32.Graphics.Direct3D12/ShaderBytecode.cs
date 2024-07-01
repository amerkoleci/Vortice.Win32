// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Direct3D;
using Win32.Graphics.Dxgi.Common;

namespace Win32.Graphics.Direct3D12;

public unsafe partial struct ShaderBytecode
{
    public ShaderBytecode(ID3DBlob* shaderBlob)
    {
        pShaderBytecode = shaderBlob->GetBufferPointer();
        BytecodeLength = shaderBlob->GetBufferSize();
    }

    public ShaderBytecode(void* shaderBytecode, nuint bytecodeLength)
    {
        pShaderBytecode = shaderBytecode;
        BytecodeLength = bytecodeLength;
    }
}
