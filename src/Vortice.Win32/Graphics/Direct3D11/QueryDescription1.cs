// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D11;

public unsafe partial struct QueryDescription1
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueryDescription1"/> struct.
    /// </summary>
    /// <param name="queryType">Type of query (see <see cref="QueryType"/>).</param>
    /// <param name="miscFlags">Miscellaneous flags (see <see cref="QueryMiscFlags"/>).</param>
    /// <param name="contextType">A <see cref="ContextType"/> value that specifies the context for the query.</param>
    public QueryDescription1(
        QueryType queryType,
        QueryMiscFlags miscFlags = QueryMiscFlags.None,
        ContextType contextType = ContextType.All)
    {
        Query = queryType;
        MiscFlags = miscFlags;
        ContextType = contextType;
    }
}
