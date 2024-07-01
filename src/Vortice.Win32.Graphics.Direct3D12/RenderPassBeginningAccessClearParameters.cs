// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Dxgi.Common;

namespace Win32.Graphics.Direct3D12;

public partial struct RenderPassBeginningAccessClearParameters : IEquatable<RenderPassBeginningAccessClearParameters>
{
    public static bool operator ==(in RenderPassBeginningAccessClearParameters left, in RenderPassBeginningAccessClearParameters right)
    {
        return left.ClearValue == right.ClearValue;
    }

    public static bool operator !=(in RenderPassBeginningAccessClearParameters left, in RenderPassBeginningAccessClearParameters right)
        => !(left == right);

    public override bool Equals(object? obj) => (obj is RenderPassBeginningAccessClearParameters other) && Equals(other);

    public bool Equals(RenderPassBeginningAccessClearParameters other) => this == other;

    public override int GetHashCode() => ClearValue.GetHashCode();
}
