// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Drawing;
using static Vortice.Win32.Graphics.D2D1;

namespace Vortice.Win32.Graphics;

public unsafe partial struct ID2D1RenderTarget
{
    public HResult CreateBitmap(Size size, D2D1_BITMAP_PROPERTIES* bitmapProperties, ID2D1Bitmap** bitmap)
    {
        return CreateBitmap(size, null, 0, bitmapProperties, bitmap);
    }

    public HResult CreateBitmapFromWicBitmap(IWICBitmapSource* wicBitmapSource, ID2D1Bitmap** bitmap)
    {
        return CreateBitmapFromWicBitmap(wicBitmapSource, null, bitmap);
    }

    public HResult CreateBitmapBrush(ID2D1Bitmap* bitmap, ID2D1BitmapBrush** bitmapBrush)
    {
        return CreateBitmapBrush(bitmap, null, null, bitmapBrush);
    }

    public HResult CreateBitmapBrush(ID2D1Bitmap* bitmap, D2D1_BITMAP_BRUSH_PROPERTIES* bitmapBrushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        return CreateBitmapBrush(bitmap, bitmapBrushProperties, null, bitmapBrush);
    }

    public HResult CreateSolidColorBrush(Color4* color, ID2D1SolidColorBrush** solidColorBrush)
    {
        return CreateSolidColorBrush(color, null, solidColorBrush);
    }

    public HResult CreateGradientStopCollection(D2D1_GRADIENT_STOP* gradientStops, uint gradientStopsCount, ID2D1GradientStopCollection** gradientStopCollection)
    {
        return CreateGradientStopCollection(gradientStops, gradientStopsCount, D2D1_GAMMA_2_2, D2D1_EXTEND_MODE_CLAMP, gradientStopCollection);
    }

    public HResult CreateLinearGradientBrush(D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        return CreateLinearGradientBrush(linearGradientBrushProperties, null, gradientStopCollection, linearGradientBrush);
    }

    public HResult CreateRadialGradientBrush(D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        return CreateRadialGradientBrush(radialGradientBrushProperties, null, gradientStopCollection, radialGradientBrush);
    }

    public HResult CreateCompatibleRenderTarget(ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        return CreateCompatibleRenderTarget(null, null, null, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE, bitmapRenderTarget);
    }

    public HResult CreateCompatibleRenderTarget(SizeF desiredSize, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        return CreateCompatibleRenderTarget(&desiredSize, null, null, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE, bitmapRenderTarget);
    }

    public HResult CreateCompatibleRenderTarget(SizeF desiredSize, Size desiredPixelSize, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        return CreateCompatibleRenderTarget(&desiredSize, &desiredPixelSize, null, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE, bitmapRenderTarget);
    }

    public HResult CreateCompatibleRenderTarget(SizeF desiredSize, Size desiredPixelSize, D2D1_PIXEL_FORMAT desiredFormat, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        return CreateCompatibleRenderTarget(&desiredSize, &desiredPixelSize, &desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE, bitmapRenderTarget);
    }

    public HResult CreateCompatibleRenderTarget(SizeF desiredSize, Size desiredPixelSize, D2D1_PIXEL_FORMAT desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        return CreateCompatibleRenderTarget(&desiredSize, &desiredPixelSize, &desiredFormat, options, bitmapRenderTarget);
    }

    public HResult CreateLayer(SizeF size, ID2D1Layer** layer)
    {
        return CreateLayer(&size, layer);
    }

    public HResult CreateLayer(ID2D1Layer** layer)
    {
        return CreateLayer(null, layer);
    }
}
