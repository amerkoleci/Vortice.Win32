// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Vortice.Win32.Graphics.Dxgi.Common;

namespace Vortice.Win32.Graphics;

/// <unmanaged>D3DX12_MESH_SHADER_PIPELINE_STATE_DESC</unmanaged>
public unsafe partial struct D3DX12_MESH_SHADER_PIPELINE_STATE_DESC
{
    public ID3D12RootSignature* pRootSignature;

    public D3D12_SHADER_BYTECODE AS;

    public D3D12_SHADER_BYTECODE MS;

    public D3D12_SHADER_BYTECODE PS;

    public D3D12_BLEND_DESC BlendState;

    public uint SampleMask;

    public D3D12_RASTERIZER_DESC RasterizerState;

    public D3D12_DEPTH_STENCIL_DESC1 DepthStencilState;

    public D3D12_PRIMITIVE_TOPOLOGY_TYPE PrimitiveTopologyType;

    public uint NumRenderTargets;

    public _RTVFormats_e__FixedBuffer RTVFormats;

    public Format DSVFormat;

    public SampleDescription SampleDesc;

    public uint NodeMask;

    public D3D12_CACHED_PIPELINE_STATE CachedPSO;

    public D3D12_PIPELINE_STATE_FLAGS Flags;

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
