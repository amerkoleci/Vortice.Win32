// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Direct2D.Common;

namespace Win32.Graphics.Direct2D;

public partial struct BrushProperties
{
    public BrushProperties(float opacity = 1.0f)
    {
        this.opacity = opacity;
        transform = Matrix3x2.Identity;
    }

    public BrushProperties(float opacity, in Matrix3x2 transform)
    {
        this.opacity = opacity;
        this.transform = transform;
    }
}
