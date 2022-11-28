// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D12;

/// <unmanaged>D3D12_BARRIER_SYNC</unmanaged>
[Flags]
public enum BarrierSync : uint
{
    None = 0,
    All = 0x1,
    Draw = 0x2,
    InputAssembler = 0x4,
    VertexShading = 0x8,
    PixelShading = 0x10,
    DepthStencil = 0x20,
    RenderTarget = 0x40,
    ComputeShading = 0x80,
    RayTracing = 0x100,
    Copy = 0x200,
    Resolve = 0x400,
    ExecuteIndirect = 0x800,
    Predication = 0x800,
    AllShading = 0x1000,
    NonPixelShading = 0x2000,
    EmitRayTracingAccelerationStructurePostBuildInfo = 0x4000,
    ClearUnorderedAccessView = 0x8000,
    VideoDecode = 0x100000,
    VideoProcess = 0x200000,
    VideoEncode = 0x400000,
    BuildRayTracingAccelerationStructure = 0x800000,
    CopyRayTracingAccelerationStructure = 0x1000000,
    Split = 0x80000000
}
