// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Dxgi.Common;

namespace Win32.Graphics.Dxgi;

public partial struct SwapChainDescription1
{
    /// <summary>
    /// Create new instance of <see cref="SwapChainDescription1"/> struct.
    /// </summary>
    /// <param name="width"></param>
    /// <param name="height"></param>
    /// <param name="format">A <see cref="Common.Format"/> that describes the display format.</param>
    /// <param name="stereo">
    /// Specifies whether the full-screen display mode or the swap-chain back buffer is stereo. TRUE if stereo; otherwise, FALSE.
    /// If you specify stereo, you must also specify a flip-model swap chain (that is, a swap chain that has the <see cref="SwapEffect.FlipSequential"/> value set in the SwapEffect member).
    /// </param>
    /// <param name="bufferUsage">
    /// A <see cref="Usage"/> value that describes the surface usage and CPU access options for the back buffer. The back buffer can be used for shader input or render-target output.
    /// </param>
    /// <param name="bufferCount">
    /// A value that describes the number of buffers in the swap chain. When you create a full-screen swap chain, you typically include the front buffer in this value.
    /// </param>
    /// <param name="scaling">
    /// A <see cref="Scaling"/> value that identifies resize behavior if the size of the back buffer is not equal to the target output.
    /// </param>
    /// <param name="swapEffect">
    /// A <see cref="Dxgi.SwapEffect"/> value that describes the presentation model that is used by the swap chain and options for handling the contents of the presentation buffer after presenting a surface.
    /// You must specify the <see cref="SwapEffect.FlipSequential"/> value when you call the <see cref="IDXGIFactory2.CreateSwapChainForComposition(IUnknown*, SwapChainDescription1*, IDXGIOutput*, IDXGISwapChain1**)"/> method because this method supports only flip presentation model.
    /// </param>
    /// <param name="alphaMode">
    /// A <see cref="Dxgi.Common.AlphaMode"/> value that identifies the transparency behavior of the swap-chain back buffer.
    /// </param>
    /// <param name="flags">
    /// A combination of <see cref="SwapChainFlags"/> values that are combined by using a bitwise OR operation. The resulting value specifies options for swap-chain behavior.
    /// </param>
    public SwapChainDescription1(
        uint width,
        uint height,
        Format format = Format.B8G8R8A8Unorm,
        bool stereo = false,
        Usage bufferUsage = Usage.RenderTargetOutput,
        uint bufferCount = 2,
        Scaling scaling = Scaling.Stretch,
        SwapEffect swapEffect = SwapEffect.FlipDiscard,
        AlphaMode alphaMode = AlphaMode.Ignore,
        SwapChainFlags flags = SwapChainFlags.None)
    {
        Width = width;
        Height = height;
        Format = format;
        Stereo = stereo;
        SampleDesc = SampleDescription.Default;
        BufferUsage = bufferUsage;
        BufferCount = bufferCount;
        Scaling = scaling;
        SwapEffect = swapEffect;
        AlphaMode = alphaMode;
        Flags = flags;
    }
}
