// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.DXGICommon;
using static Vortice.Win32.Graphics.DXGI;
namespace Vortice.Win32.Graphics;

public partial struct DXGI_SWAP_CHAIN_DESC1
{
    /// <summary>
    /// Create new instance of <see cref="DXGI_SWAP_CHAIN_DESC1"/> struct.
    /// </summary>
    /// <param name="width"></param>
    /// <param name="height"></param>
    /// <param name="format">A <see cref="DXGI_FORMAT"/> that describes the display format.</param>
    /// <param name="stereo">
    /// Specifies whether the full-screen display mode or the swap-chain back buffer is stereo. TRUE if stereo; otherwise, FALSE.
    /// If you specify stereo, you must also specify a flip-model swap chain (that is, a swap chain that has the <see cref="DXGI_SWAP_EFFECT_FLIP_SEQUENTIAL"/> value set in the SwapEffect member).
    /// </param>
    /// <param name="bufferUsage">
    /// A <see cref="DXGI_USAGE"/> value that describes the surface usage and CPU access options for the back buffer. The back buffer can be used for shader input or render-target output.
    /// </param>
    /// <param name="bufferCount">
    /// A value that describes the number of buffers in the swap chain. When you create a full-screen swap chain, you typically include the front buffer in this value.
    /// </param>
    /// <param name="scaling">
    /// A <see cref="DXGI_SCALING"/> value that identifies resize behavior if the size of the back buffer is not equal to the target output.
    /// </param>
    /// <param name="swapEffect">
    /// A <see cref="DXGI_SWAP_EFFECT"/> value that describes the presentation model that is used by the swap chain and options for handling the contents of the presentation buffer after presenting a surface.
    /// You must specify the <see cref="DXGI_SWAP_EFFECT_FLIP_SEQUENTIAL"/> value when you call the <see cref="IDXGIFactory2.CreateSwapChainForComposition(IUnknown*, SwapChainDescription1*, IDXGIOutput*, IDXGISwapChain1**)"/> method because this method supports only flip presentation model.
    /// </param>
    /// <param name="alphaMode">
    /// A <see cref="DXGI_ALPHA_MODE"/> value that identifies the transparency behavior of the swap-chain back buffer.
    /// </param>
    /// <param name="flags">
    /// A combination of <see cref="DXGI_SWAP_CHAIN_FLAG"/> values that are combined by using a bitwise OR operation. The resulting value specifies options for swap-chain behavior.
    /// </param>
    public DXGI_SWAP_CHAIN_DESC1(
        uint width,
        uint height,
        DXGI_FORMAT format = DXGI_FORMAT_B8G8R8A8_UNORM,
        bool stereo = false,
        DXGI_USAGE bufferUsage = DXGI_USAGE_RENDER_TARGET_OUTPUT,
        uint bufferCount = 2,
        DXGI_SCALING scaling = DXGI_SCALING_STRETCH,
        DXGI_SWAP_EFFECT swapEffect = DXGI_SWAP_EFFECT_FLIP_DISCARD,
        DXGI_ALPHA_MODE alphaMode = DXGI_ALPHA_MODE_IGNORE,
        DXGI_SWAP_CHAIN_FLAG flags = 0)
    {
        Width = width;
        Height = height;
        Format = format;
        Stereo = stereo;
        SampleDesc = DXGI_SAMPLE_DESC.Default;
        BufferUsage = bufferUsage;
        BufferCount = bufferCount;
        Scaling = scaling;
        SwapEffect = swapEffect;
        AlphaMode = alphaMode;
        Flags = flags;
    }
}
