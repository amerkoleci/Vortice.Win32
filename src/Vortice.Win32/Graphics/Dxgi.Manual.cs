// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Win32.Graphics.Dxgi.Apis;

namespace Win32.Graphics.Dxgi;

[Flags]
public enum Usage : uint
{
    ShaderInput = DXGI_USAGE_SHADER_INPUT,
    RenderTargetOutput = DXGI_USAGE_RENDER_TARGET_OUTPUT,
    Backbuffer = DXGI_USAGE_BACK_BUFFER,
    Shared = DXGI_USAGE_SHARED,
    ReadOnly = DXGI_USAGE_READ_ONLY,
    DiscardOnPresent = DXGI_USAGE_DISCARD_ON_PRESENT,
    UnorderedAccess = DXGI_USAGE_UNORDERED_ACCESS
}

[Flags]
public enum MapFlags : uint
{
    Read = DXGI_MAP_READ,
    Write = DXGI_MAP_WRITE,
    Discard = DXGI_MAP_DISCARD
}
