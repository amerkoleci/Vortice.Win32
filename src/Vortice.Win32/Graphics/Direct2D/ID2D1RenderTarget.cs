// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Drawing;
using Win32.Graphics.Direct2D.Common;
using Win32.Graphics.Imaging;
using Win32.Numerics;

namespace Win32.Graphics.Direct2D;

public unsafe partial struct ID2D1RenderTarget
{
    public HResult CreateBitmap(Size size, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
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

    public HResult CreateBitmapBrush(ID2D1Bitmap* bitmap, BitmapBrushProperties* bitmapBrushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        return CreateBitmapBrush(bitmap, bitmapBrushProperties, null, bitmapBrush);
    }

    public HResult CreateSolidColorBrush(Color4* color, ID2D1SolidColorBrush** solidColorBrush)
    {
        return CreateSolidColorBrush(color, null, solidColorBrush);
    }

    public HResult CreateGradientStopCollection(GradientStop* gradientStops, uint gradientStopsCount, ID2D1GradientStopCollection** gradientStopCollection)
    {
        return CreateGradientStopCollection(gradientStops, gradientStopsCount, Gamma.Gamma_2_2, ExtendMode.Clamp, gradientStopCollection);
    }

    public HResult CreateLinearGradientBrush(LinearGradientBrushProperties* linearGradientBrushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        return CreateLinearGradientBrush(linearGradientBrushProperties, null, gradientStopCollection, linearGradientBrush);
    }

    public HResult CreateRadialGradientBrush(RadialGradientBrushProperties* radialGradientBrushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        return CreateRadialGradientBrush(radialGradientBrushProperties, null, gradientStopCollection, radialGradientBrush);
    }

    public HResult CreateCompatibleRenderTarget(ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        return CreateCompatibleRenderTarget(null, null, null, CompatibleRenderTargetOptions.None, bitmapRenderTarget);
    }

    public HResult CreateCompatibleRenderTarget(SizeF desiredSize, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        return CreateCompatibleRenderTarget(&desiredSize, null, null, CompatibleRenderTargetOptions.None, bitmapRenderTarget);
    }

    public HResult CreateCompatibleRenderTarget(SizeF desiredSize, Size desiredPixelSize, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        return CreateCompatibleRenderTarget(&desiredSize, &desiredPixelSize, null, CompatibleRenderTargetOptions.None, bitmapRenderTarget);
    }

    public HResult CreateCompatibleRenderTarget(SizeF desiredSize, Size desiredPixelSize, PixelFormat desiredFormat, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        return CreateCompatibleRenderTarget(&desiredSize, &desiredPixelSize, &desiredFormat, CompatibleRenderTargetOptions.None, bitmapRenderTarget);
    }

    public HResult CreateCompatibleRenderTarget(SizeF desiredSize, Size desiredPixelSize, PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
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
