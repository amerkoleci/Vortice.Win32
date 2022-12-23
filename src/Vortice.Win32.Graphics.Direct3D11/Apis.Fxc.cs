// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D11;

public static unsafe partial class Apis
{
    [DllImport("D3DCOMPILER_47.dll", ExactSpelling = true)]
    public static extern HResult D3DCreateLinker(ID3D11Linker** ppLinker);

    [DllImport("D3DCOMPILER_47.dll", ExactSpelling = true)]
    public static extern HResult D3DLoadModule(void* pSrcData, nuint cbSrcDataSize, ID3D11Module** ppModule);

    [DllImport("D3DCOMPILER_47.dll", ExactSpelling = true)]
    public static extern HResult D3DCreateFunctionLinkingGraph(uint uFlags, ID3D11FunctionLinkingGraph** ppFunctionLinkingGraph);
}
