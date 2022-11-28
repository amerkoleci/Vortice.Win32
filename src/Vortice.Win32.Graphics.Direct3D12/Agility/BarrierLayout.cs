// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D12;

/// <unmanaged>D3D12_BARRIER_LAYOUT</unmanaged>
public enum BarrierLayout : uint
{
    Undefined = 0xffffffff,
    Common = 0,
    Present = 0,
    GenericRead = (Present + 1),
    RenderTarget = (GenericRead + 1),
    UnorderedAccess = (RenderTarget + 1),
    DepthStencilWrite = (UnorderedAccess + 1),
    DepthStencilRead = (DepthStencilWrite + 1),
    ShaderResource = (DepthStencilRead + 1),
    CopySource = (ShaderResource + 1),
    CopyDest = (CopySource + 1),
    ResolveSource = (CopyDest + 1),
    ResolveDest = (ResolveSource + 1),
    ShadingRateSource = (ResolveDest + 1),
    VideoDecodeRead = (ShadingRateSource + 1),
    VideoDecodeWrite = (VideoDecodeRead + 1),
    VideoProcessRead = (VideoDecodeWrite + 1),
    VideoProcessWrite = (VideoProcessRead + 1),
    D3D12_BARRIER_LAYOUT_VIDEO_ENCODE_READ = (VideoProcessWrite + 1),
    D3D12_BARRIER_LAYOUT_VIDEO_ENCODE_WRITE = (D3D12_BARRIER_LAYOUT_VIDEO_ENCODE_READ + 1),
    DirectQueueCommon = (D3D12_BARRIER_LAYOUT_VIDEO_ENCODE_WRITE + 1),
    DirectQueueGenericRead = (DirectQueueCommon + 1),
    DirectQueueUnorderedAccess = (DirectQueueGenericRead + 1),
    DirectQueueShaderResource = (DirectQueueUnorderedAccess + 1),
    DirectQueueCopySource = (DirectQueueShaderResource + 1),
    DirectQueueCopyDest = (DirectQueueCopySource + 1),
    ComputeQueueCommon = (DirectQueueCopyDest + 1),
    ComputeQueueGenericRead = (ComputeQueueCommon + 1),
    ComputeQueueUnorderedAccess = (ComputeQueueGenericRead + 1),
    ComputeQueueShaderResource = (ComputeQueueUnorderedAccess + 1),
    ComputeQueueCopySource = (ComputeQueueShaderResource + 1),
    ComputeQueueCopyDest = (ComputeQueueCopySource + 1),
    VideoQueueCommon = (ComputeQueueCopyDest + 1)
}
