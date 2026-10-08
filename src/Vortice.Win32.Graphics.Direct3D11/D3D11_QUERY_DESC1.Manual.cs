// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D3D11;

namespace Vortice.Win32.Graphics;

public partial struct D3D11_QUERY_DESC1
{
    /// <summary>
    /// Initializes a new instance of the <see cref="D3D11_QUERY_DESC1"/> struct.
    /// </summary>
    /// <param name="queryType">Type of query (see <see cref="D3D11_QUERY"/>).</param>
    /// <param name="miscFlags">Miscellaneous flags (see <see cref="D3D11_QUERY_MISC_FLAG"/>).</param>
    /// <param name="contextType">A <see cref="D3D11_CONTEXT_TYPE"/> value that specifies the context for the query.</param>
    public D3D11_QUERY_DESC1(
        D3D11_QUERY queryType,
        D3D11_QUERY_MISC_FLAG miscFlags = 0,
        D3D11_CONTEXT_TYPE contextType = D3D11_CONTEXT_TYPE_ALL)
    {
        Query = queryType;
        MiscFlags = miscFlags;
        ContextType = contextType;
    }
}
