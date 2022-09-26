// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Win32.Graphics.Direct3D11.Apis;

namespace Win32.Graphics.Direct3D11;

public unsafe partial struct ID3D11Texture3D
{
    public uint CalculateSubResourceIndex(uint mipSlice, uint arraySlice, out uint mipSize)
    {
        Texture3DDescription desc;
        GetDesc(&desc);

        mipSize = D3D11CalculateMipSize(mipSlice, desc.Depth);
        return D3D11CalcSubresource(mipSlice, arraySlice, desc.MipLevels);
    }
}
