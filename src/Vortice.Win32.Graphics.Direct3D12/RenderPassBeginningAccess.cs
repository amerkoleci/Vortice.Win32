// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Dxgi.Common;

namespace Win32.Graphics.Direct3D12;

public partial struct RenderPassBeginningAccess : IEquatable<RenderPassBeginningAccess>
{
    public static bool operator ==(in RenderPassBeginningAccess left, in RenderPassBeginningAccess right)
    {
        if (left.Type != right.Type)
        {
            return false;
        }

        if (left.Type == RenderPassBeginningAccessType.Clear && !(left.Anonymous.Clear == right.Anonymous.Clear))
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

            if (Type == RenderPassBeginningAccessType.Clear)
            {
                hashCode.Add(Anonymous.Clear);
            }
        }
        return hashCode.ToHashCode();
    }
}
