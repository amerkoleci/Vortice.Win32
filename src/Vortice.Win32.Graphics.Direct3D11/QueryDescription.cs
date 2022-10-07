// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D11;

public unsafe partial struct QueryDescription
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueryDescription"/> struct.
    /// </summary>
    /// <param name="queryType">Type of query (see <see cref="QueryType"/>).</param>
    /// <param name="miscFlags">Miscellaneous flags (see <see cref="QueryMiscFlags"/>).</param>
    public QueryDescription(QueryType queryType, QueryMiscFlags miscFlags = QueryMiscFlags.None)
    {
        Query = queryType;
        MiscFlags = miscFlags;
    }
}
