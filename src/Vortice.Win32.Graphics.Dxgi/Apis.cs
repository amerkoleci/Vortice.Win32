// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Graphics;

unsafe partial class DXGI
{
    public static HResult CreateDXGIFactory2(bool debug, Guid* riid, void** ppFactory)
    {
        return CreateDXGIFactory2(debug ? DXGI_CREATE_FACTORY_DEBUG : 0u, riid, ppFactory);
    }
}
