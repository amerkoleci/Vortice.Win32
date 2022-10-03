// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Win32.Graphics.Direct3D11.Apis;

namespace Win32.Graphics.Direct3D11;

public unsafe partial struct ID3D11Texture1D
{
    public uint CalculateSubResourceIndex(uint mipSlice, uint arraySlice, out uint mipSize)
    {
        Texture1DDescription desc;
        GetDesc(&desc);

        mipSize = D3D11CalculateMipSize(mipSlice, desc.Width);
        return D3D11CalcSubresource(mipSlice, arraySlice, desc.MipLevels);
    }
}
