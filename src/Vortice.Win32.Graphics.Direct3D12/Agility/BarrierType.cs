// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D12;

/// <unmanaged>D3D12_BARRIER_TYPE</unmanaged>
public enum BarrierType
{
    Global = 0,
    Texture = (Global + 1),
    Buffer = (Texture + 1),
}
