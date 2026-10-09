// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.D3D12;

namespace Vortice.Win32.Graphics;

public partial struct D3D12_RENDER_PASS_ENDING_ACCESS : IEquatable<D3D12_RENDER_PASS_ENDING_ACCESS>
{
    public static bool operator ==(in D3D12_RENDER_PASS_ENDING_ACCESS left, in D3D12_RENDER_PASS_ENDING_ACCESS right)
    {
        if (left.Type != right.Type)
        {
            return false;
        }

        switch (left.Type)
        {
            case D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_RESOLVE:
            {
                if (left.Anonymous.Resolve != right.Anonymous.Resolve)
                {
                    return false;
                }
                break;
            }

            case D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_PRESERVE_LOCAL_RENDER:
            case D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_PRESERVE_LOCAL_SRV:
            case D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_PRESERVE_LOCAL_UAV:
            {
                if (left.Anonymous.PreserveLocal != right.Anonymous.PreserveLocal)
                {
                    return false;
                }
                break;
            }
        }

        return true;
    }

    public static bool operator !=(in D3D12_RENDER_PASS_ENDING_ACCESS left, in D3D12_RENDER_PASS_ENDING_ACCESS right)
        => !(left == right);

    public override readonly bool Equals([NotNullWhen(true)] object? obj)
        => (obj is D3D12_RENDER_PASS_ENDING_ACCESS other) && Equals(other);

    public readonly bool Equals(D3D12_RENDER_PASS_ENDING_ACCESS other) => this == other;

    public override readonly int GetHashCode()
    {
        var hashCode = new HashCode();
        hashCode.Add(Type);

        switch (Type)
        {
            case D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_RESOLVE:
            {
                hashCode.Add(Anonymous.Resolve);
                break;
            }

            case D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_PRESERVE_LOCAL_RENDER:
            case D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_PRESERVE_LOCAL_SRV:
            case D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_PRESERVE_LOCAL_UAV:
            {
                hashCode.Add(Anonymous.PreserveLocal);
                break;
            }
        }

        return hashCode.ToHashCode();
    }
}

