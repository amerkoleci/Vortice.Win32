// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Dxgi.Common;

namespace Win32.Graphics.Direct3D12;

public partial struct RenderPassEndingAccess : IEquatable<RenderPassEndingAccess>
{
    public static bool operator ==(in RenderPassEndingAccess left, in RenderPassEndingAccess right)
    {
        if (left.Type != right.Type)
        {
            return false;
        }

        if (left.Type == RenderPassEndingAccessType.Resolve && !(left.Anonymous.Resolve == right.Anonymous.Resolve))
        {
            return false;
        }

        return true;
    }

    public static bool operator !=(in RenderPassEndingAccess left, in RenderPassEndingAccess right)
        => !(left == right);

    public override bool Equals(object? obj) => (obj is RenderPassEndingAccess other) && Equals(other);

    public bool Equals(RenderPassEndingAccess other) => this == other;

    public override int GetHashCode()
    {
        var hashCode = new HashCode();
        {
            hashCode.Add(Type);

            if (Type == RenderPassEndingAccessType.Resolve)
            {
                hashCode.Add(Anonymous.Resolve);
            }
        }
        return hashCode.ToHashCode();
    }
}
