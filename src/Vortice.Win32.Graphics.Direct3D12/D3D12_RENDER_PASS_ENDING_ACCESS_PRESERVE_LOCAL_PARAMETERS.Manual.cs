// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Graphics;

public partial struct D3D12_RENDER_PASS_ENDING_ACCESS_PRESERVE_LOCAL_PARAMETERS : IEquatable<D3D12_RENDER_PASS_ENDING_ACCESS_PRESERVE_LOCAL_PARAMETERS>
{
    public static bool operator ==(in D3D12_RENDER_PASS_ENDING_ACCESS_PRESERVE_LOCAL_PARAMETERS left, in D3D12_RENDER_PASS_ENDING_ACCESS_PRESERVE_LOCAL_PARAMETERS right)
        => (left.AdditionalWidth == right.AdditionalWidth)
        && (left.AdditionalHeight == right.AdditionalHeight);

    public static bool operator !=(in D3D12_RENDER_PASS_ENDING_ACCESS_PRESERVE_LOCAL_PARAMETERS left, in D3D12_RENDER_PASS_ENDING_ACCESS_PRESERVE_LOCAL_PARAMETERS right)
        => !(left == right);

    public override readonly bool Equals([NotNullWhen(true)] object? obj)
        => (obj is D3D12_RENDER_PASS_ENDING_ACCESS_PRESERVE_LOCAL_PARAMETERS other) && Equals(other);

    public readonly bool Equals(D3D12_RENDER_PASS_ENDING_ACCESS_PRESERVE_LOCAL_PARAMETERS other) => this == other;

    public override readonly int GetHashCode() => HashCode.Combine(AdditionalWidth, AdditionalHeight);
}
