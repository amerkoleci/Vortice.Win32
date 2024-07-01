// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Dxgi.Common;

namespace Win32.Graphics.Direct3D12;

/// <unmanaged>D3DX12_MESH_SHADER_PIPELINE_STATE_DESC</unmanaged>
public unsafe partial struct MeshShaderPipelineStateDescription
{
    public ID3D12RootSignature* pRootSignature;

    public ShaderBytecode AS;

    public ShaderBytecode MS;

    public ShaderBytecode PS;

    public BlendDescription BlendState;

    public uint SampleMask;

    public RasterizerDescription RasterizerState;

    public DepthStencilDescription1 DepthStencilState;

    public PrimitiveTopologyType PrimitiveTopologyType;

    public uint NumRenderTargets;

    public _RTVFormats_e__FixedBuffer RTVFormats;

    public Format DSVFormat;

    public SamplerDescription SampleDesc;

    public uint NodeMask;

    public CachedPipelineState CachedPSO;

    public PipelineStateFlags Flags;

    public partial struct _RTVFormats_e__FixedBuffer
    {
        public Format e0;
        public Format e1;
        public Format e2;
        public Format e3;
        public Format e4;
        public Format e5;
        public Format e6;
        public Format e7;

        [UnscopedRef]
        public ref Format this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<Format> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 8);
    }
}
