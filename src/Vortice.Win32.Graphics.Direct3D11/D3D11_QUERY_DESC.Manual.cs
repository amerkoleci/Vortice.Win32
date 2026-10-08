// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Graphics;

public partial struct D3D11_QUERY_DESC
{
    /// <summary>
    /// Initializes a new instance of the <see cref="D3D11_QUERY_DESC"/> struct.
    /// </summary>
    /// <param name="queryType">Type of query (see <see cref="D3D11_QUERY"/>).</param>
    /// <param name="miscFlags">Miscellaneous flags (see <see cref="D3D11_QUERY_MISC_FLAG"/>).</param>
    public D3D11_QUERY_DESC(D3D11_QUERY queryType, D3D11_QUERY_MISC_FLAG miscFlags = 0)
    {
        Query = queryType;
        MiscFlags = miscFlags;
    }
}
