// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Win32.Graphics;

public partial struct D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS : IEquatable<D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS>
{
    public static bool operator ==(in D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS left, in D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS right)
        => left.ClearValue == right.ClearValue;

    public static bool operator !=(in D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS left, in D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS right)
        => !(left == right);

    public override readonly bool Equals([NotNullWhen(true)] object? obj)
        => (obj is D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS other) && Equals(other);

    public readonly bool Equals(D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS other) => this == other;

    public override readonly int GetHashCode() => ClearValue.GetHashCode();
}
