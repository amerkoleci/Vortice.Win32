// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Graphics;

public unsafe partial struct D3D12_RT_FORMAT_ARRAY
{
    public D3D12_RT_FORMAT_ARRAY([NativeTypeName("const DXGI_FORMAT *")] DXGI_FORMAT* pFormats, uint NumFormats)
    {
        NumRenderTargets = NumFormats;

        fixed (DXGI_FORMAT* pRTFormats = &RTFormats[0])
        {
            NativeMemory.Copy(pFormats, pRTFormats, sizeof(DXGI_FORMAT));
        }
    }
}
