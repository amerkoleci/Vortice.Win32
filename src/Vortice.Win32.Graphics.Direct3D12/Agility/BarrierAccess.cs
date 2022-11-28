// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D12;

/// <unmanaged>D3D12_BARRIER_ACCESS</unmanaged>
[Flags]
public enum BarrierAccess : uint
{
    Common = 0,
    VertexBuffer = 0x1,
    ConstantBuffer = 0x2,
    IndexBuffer = 0x4,
    RenderTarget = 0x8,
    UnorderedAcccess = 0x10,
    DepthStencilWrite = 0x20,
    DepthStencilRead = 0x40,
    ShaderResource = 0x80,
    StreamOutput = 0x100,
    IndirectArgumetn = 0x200,
    Predication = 0x200,
    CopyDest = 0x400,
    CopySource = 0x800,
    ResolveDest = 0x1000,
    ResolveSource = 0x2000,
    RayTracingAccelerationStructureRead = 0x4000,
    RayTracingAccelerationStructureWrite = 0x8000,
    D3D12_BARRIER_ACCESS_SHADING_RATE_SOURCE = 0x10000,
    VideoDecodeRead = 0x20000,
    VideoDecodeWrite = 0x40000,
    VideoProcessRead = 0x80000,
    VideoProcessWrite = 0x100000,
    VideoEncodeRead = 0x200000,
    VideoEncodeWrite = 0x400000,
    NoAccess = 0x80000000
}
