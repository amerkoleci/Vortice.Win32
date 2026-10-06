// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.Direct3D12.Apis;

namespace Vortice.Win32.Graphics.Direct3D12;

public partial struct RenderPassBeginningAccess : IEquatable<RenderPassBeginningAccess>
{
    public static bool operator ==(in RenderPassBeginningAccess left, in RenderPassBeginningAccess right)
    {
        if (left.Type != right.Type)
        {
            return false;
        }

        if (left.Type == D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_CLEAR && !(left.Anonymous.Clear == right.Anonymous.Clear))
        {
            return false;
        }

        return true;
    }

    public static bool operator !=(in RenderPassBeginningAccess left, in RenderPassBeginningAccess right)
        => !(left == right);

    public override bool Equals(object? obj) => (obj is RenderPassBeginningAccess other) && Equals(other);

    public bool Equals(RenderPassBeginningAccess other) => this == other;

    public override int GetHashCode()
    {
        var hashCode = new HashCode();
        {
            hashCode.Add(Type);

            if (Type == D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE_CLEAR)
            {
                hashCode.Add(Anonymous.Clear);
            }
        }
        return hashCode.ToHashCode();
    }
}
