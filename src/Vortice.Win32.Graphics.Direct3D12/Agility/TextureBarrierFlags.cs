// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D12;

/// <unmanaged>D3D12_TEXTURE_BARRIER_FLAGS</unmanaged>
[Flags]
public enum TextureBarrierFlags
{
    None = 0,
    Discard = 0x1,
}
