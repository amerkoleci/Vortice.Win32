// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct2D;

public partial struct LinearGradientBrushProperties
{
    public LinearGradientBrushProperties(in Vector2 startPoint, in Vector2 endPoint)
    {
        this.startPoint = startPoint;
        this.endPoint = endPoint;
    }
}
