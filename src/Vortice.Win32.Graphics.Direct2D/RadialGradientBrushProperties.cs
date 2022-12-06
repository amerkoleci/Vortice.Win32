// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Drawing;
using System.Net;

namespace Win32.Graphics.Direct2D;

public partial struct RadialGradientBrushProperties
{
    public RadialGradientBrushProperties(in Vector2 center, in Vector2 gradientOriginOffset, float radiusX, float radiusY)
    {
        this.center = center;
        this.gradientOriginOffset = gradientOriginOffset;
        this.radiusX = radiusX;
        this.radiusY = radiusY;
    }
}
