// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D3D11;

namespace Vortice.Win32.Graphics;

public unsafe partial struct ID3D11Texture3D
{
    public uint CalculateSubResourceIndex(uint mipSlice, uint arraySlice, out uint mipSize)
    {
        D3D11_TEXTURE3D_DESC desc;
        GetDesc(&desc);

        mipSize = D3D11CalculateMipSize(mipSlice, desc.Depth);
        return D3D11CalcSubresource(mipSlice, arraySlice, desc.MipLevels);
    }
}
