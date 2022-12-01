// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Dxgi;

unsafe partial class Apis
{
    public static HResult CreateDXGIFactory2(bool debug, Guid* riid, void** ppFactory)
    {
        return CreateDXGIFactory2(debug ? DXGI_CREATE_FACTORY_DEBUG : 0u, riid, ppFactory);
    }
}
