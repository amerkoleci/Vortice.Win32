// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Drawing;
using Win32.Graphics.Direct2D.Common;
using Win32.Graphics.Imaging;
using static Win32.Apis;
using static Win32.Graphics.Direct2D.Apis;

namespace Win32.Graphics.Direct2D;

public static unsafe class ID2D1DeviceContextExtensions
{
    public static HResult CreateBitmapt<TD2D1DeviceContext>(
        ref this TD2D1DeviceContext self, Size size, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
        where TD2D1DeviceContext : unmanaged, ID2D1DeviceContext.Interface
    {
        return self.CreateBitmap(size, null, 0, bitmapProperties, bitmap);
    }

    public static HResult CreateBitmapFromWicBitmapt<TD2D1DeviceContext>(
        ref this TD2D1DeviceContext self, IWICBitmapSource* wicBitmapSource, ID2D1Bitmap** bitmap)
        where TD2D1DeviceContext : unmanaged, ID2D1DeviceContext.Interface
    {
        return self.CreateBitmapFromWicBitmap(wicBitmapSource, null, bitmap);
    }

    public static HResult CreateBitmapBrusht<TD2D1DeviceContext>(
        ref this TD2D1DeviceContext self, ID2D1Bitmap* bitmap, ID2D1BitmapBrush** bitmapBrush)
        where TD2D1DeviceContext : unmanaged, ID2D1DeviceContext.Interface
    {
        return self.CreateBitmapBrush(bitmap, null, null, bitmapBrush);
    }

    public static HResult CreateBitmapBrush<TD2D1DeviceContext>(
        ref this TD2D1DeviceContext self, ID2D1Bitmap* bitmap, BitmapBrushProperties* bitmapBrushProperties, ID2D1BitmapBrush** bitmapBrush)
        where TD2D1DeviceContext : unmanaged, ID2D1DeviceContext.Interface
    {
        return self.CreateBitmapBrush(bitmap, bitmapBrushProperties, null, bitmapBrush);
    }

    public static HResult CreateSolidColorBrush<TD2D1DeviceContext>(
        ref this TD2D1DeviceContext self, Color4* color, ID2D1SolidColorBrush** solidColorBrush)
        where TD2D1DeviceContext : unmanaged, ID2D1DeviceContext.Interface
    {
        return self.CreateSolidColorBrush(color, null, solidColorBrush);
    }

    public static HResult CreateSolidColorBrush<TD2D1DeviceContext>(
        ref this TD2D1DeviceContext self, Color4 color, ID2D1SolidColorBrush** solidColorBrush)
        where TD2D1DeviceContext : unmanaged, ID2D1DeviceContext.Interface
    {
        return self.CreateSolidColorBrush(&color, null, solidColorBrush);
    }

    public static HResult CreateGradientStopCollection<TD2D1DeviceContext>(
        ref this TD2D1DeviceContext self, GradientStop* gradientStops, int gradientStopsCount, ID2D1GradientStopCollection** gradientStopCollection)
        where TD2D1DeviceContext : unmanaged, ID2D1DeviceContext.Interface
    {
        return self.CreateGradientStopCollection(gradientStops, (uint)gradientStopsCount, Gamma.Gamma_2_2, ExtendMode.Clamp, gradientStopCollection);
    }

    public static HResult CreateLinearGradientBrush<TD2D1DeviceContext>(
        ref this TD2D1DeviceContext self, LinearGradientBrushProperties* linearGradientBrushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
        where TD2D1DeviceContext : unmanaged, ID2D1DeviceContext.Interface
    {
        return self.CreateLinearGradientBrush(linearGradientBrushProperties, null, gradientStopCollection, linearGradientBrush);
    }

    public static HResult CreateRadialGradientBrush<TD2D1DeviceContext>(
        ref this TD2D1DeviceContext self, RadialGradientBrushProperties* radialGradientBrushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
        where TD2D1DeviceContext : unmanaged, ID2D1DeviceContext.Interface
    {
        return self.CreateRadialGradientBrush(radialGradientBrushProperties, null, gradientStopCollection, radialGradientBrush);
    }

    public static HResult CreateCompatibleRenderTarget<TD2D1DeviceContext>(
        ref this TD2D1DeviceContext self, ID2D1BitmapRenderTarget** bitmapRenderTarget)
        where TD2D1DeviceContext : unmanaged, ID2D1DeviceContext.Interface
    {
        return self.CreateCompatibleRenderTarget(null, null, null, CompatibleRenderTargetOptions.None, bitmapRenderTarget);
    }

    public static HResult CreateCompatibleRenderTarget<TD2D1DeviceContext>(
        ref this TD2D1DeviceContext self, SizeF desiredSize, ID2D1BitmapRenderTarget** bitmapRenderTarget)
        where TD2D1DeviceContext : unmanaged, ID2D1DeviceContext.Interface
    {
        return self.CreateCompatibleRenderTarget(&desiredSize, null, null, CompatibleRenderTargetOptions.None, bitmapRenderTarget);
    }

    public static HResult CreateCompatibleRenderTarget<TD2D1DeviceContext>(
        ref this TD2D1DeviceContext self, SizeF desiredSize, Size desiredPixelSize, ID2D1BitmapRenderTarget** bitmapRenderTarget)
        where TD2D1DeviceContext : unmanaged, ID2D1DeviceContext.Interface
    {
        return self.CreateCompatibleRenderTarget(&desiredSize, &desiredPixelSize, null, CompatibleRenderTargetOptions.None, bitmapRenderTarget);
    }

    public static HResult CreateCompatibleRenderTarget<TD2D1DeviceContext>(
        ref this TD2D1DeviceContext self, SizeF desiredSize, Size desiredPixelSize, PixelFormat desiredFormat, ID2D1BitmapRenderTarget** bitmapRenderTarget)
        where TD2D1DeviceContext : unmanaged, ID2D1DeviceContext.Interface
    {
        return self.CreateCompatibleRenderTarget(&desiredSize, &desiredPixelSize, &desiredFormat, CompatibleRenderTargetOptions.None, bitmapRenderTarget);
    }

    public static HResult CreateCompatibleRenderTarget<TD2D1DeviceContext>(
        ref this TD2D1DeviceContext self, SizeF desiredSize, Size desiredPixelSize, PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
        where TD2D1DeviceContext : unmanaged, ID2D1DeviceContext.Interface
    {
        return self.CreateCompatibleRenderTarget(&desiredSize, &desiredPixelSize, &desiredFormat, options, bitmapRenderTarget);
    }

    public static HResult CreateLayer<TD2D1DeviceContext>(
        ref this TD2D1DeviceContext self, SizeF size, ID2D1Layer** layer)
        where TD2D1DeviceContext : unmanaged, ID2D1DeviceContext.Interface
    {
        return self.CreateLayer(&size, layer);
    }

    public static HResult CreateLayer<TD2D1DeviceContext>(
        ref this TD2D1DeviceContext self, ID2D1Layer** layer)
        where TD2D1DeviceContext : unmanaged, ID2D1DeviceContext.Interface
    {
        return self.CreateLayer(null, layer);
    }
    public static HResult CreateBitmapFromWicBitmap<TD2D1DeviceContext>(
        ref this TD2D1DeviceContext self, IWICBitmapSource* wicBitmapSource, ID2D1Bitmap1** bitmap)
        where TD2D1DeviceContext : unmanaged, ID2D1DeviceContext.Interface
    {
        return self.CreateBitmapFromWicBitmap(wicBitmapSource, null, bitmap);
    }

    public static HResult CreateImageBrush<TD2D1DeviceContext>(
        ref this TD2D1DeviceContext self, ID2D1Image* image, ImageBrushProperties* imageBrushProperties, ID2D1ImageBrush** imageBrush)
        where TD2D1DeviceContext : unmanaged, ID2D1DeviceContext.Interface
    {
        return self.CreateImageBrush(image, imageBrushProperties, null, imageBrush);
    }

    public static HResult CreateBitmapBrush<TD2D1DeviceContext>(
        ref this TD2D1DeviceContext self, ID2D1Bitmap* bitmap, ID2D1BitmapBrush1** bitmapBrush)
        where TD2D1DeviceContext : unmanaged, ID2D1DeviceContext.Interface
    {
        return self.CreateBitmapBrush(bitmap, null, null, bitmapBrush);
    }

    public static HResult CreateEffect<TD2D1DeviceContext>(
        ref this TD2D1DeviceContext self, in Guid effectId, ID2D1Effect** effect)
        where TD2D1DeviceContext : unmanaged, ID2D1DeviceContext.Interface
    {
        return self.CreateEffect((Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in effectId)), effect);
    }

    public static ComPtr<ID2D1Effect> CreateEffect<TD2D1DeviceContext>(
        ref this TD2D1DeviceContext self, in Guid effectId)
        where TD2D1DeviceContext : unmanaged, ID2D1DeviceContext.Interface
    {
        using ComPtr<ID2D1Effect> effect = default;
        ThrowIfFailed(self.CreateEffect((Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in effectId)), effect.GetAddressOf()));
        return effect.Move();
    }

    public static void DrawImage<TD2D1DeviceContext>(
        ref this TD2D1DeviceContext self,
        ID2D1Effect* effect,
        Vector2* targetOffset = null,
        RectF* imageRectangle = null,
        InterpolationMode interpolationMode = InterpolationMode.Linear,
        CompositeMode compositeMode = CompositeMode.SourceOver)
        where TD2D1DeviceContext : unmanaged, ID2D1DeviceContext.Interface
    {
        ID2D1Image* output = null;

        effect->GetOutput(&output);
        self.DrawImage(output, targetOffset, imageRectangle, interpolationMode, compositeMode);
        _ = output->Release();
    }

    public static void DrawImage<TD2D1DeviceContext>(
        ref this TD2D1DeviceContext self,
        ID2D1Image* image,
        InterpolationMode interpolationMode,
        CompositeMode compositeMode = CompositeMode.SourceOver)
        where TD2D1DeviceContext : unmanaged, ID2D1DeviceContext.Interface
    {
        self.DrawImage(image, null, null, interpolationMode, compositeMode);
    }

    public static void DrawImage<TD2D1DeviceContext>(
        ref this TD2D1DeviceContext self,
        ID2D1Effect* effect,
        InterpolationMode interpolationMode,
        CompositeMode compositeMode = CompositeMode.SourceOver)
        where TD2D1DeviceContext : unmanaged, ID2D1DeviceContext.Interface
    {
        self.DrawImage(effect, null, null, interpolationMode, compositeMode);
    }

    public static void DrawImage<TD2D1DeviceContext>(
        ref this TD2D1DeviceContext self, ID2D1Image* image,
        Vector2 targetOffset,
        InterpolationMode interpolationMode = InterpolationMode.Linear,
        CompositeMode compositeMode = CompositeMode.SourceOver)
        where TD2D1DeviceContext : unmanaged, ID2D1DeviceContext.Interface
    {
        self.DrawImage(image, &targetOffset, null, interpolationMode, compositeMode);
    }

    public static void DrawImage<TD2D1DeviceContext>(
        ref this TD2D1DeviceContext self, ID2D1Effect* effect,
        Vector2 targetOffset,
        InterpolationMode interpolationMode = InterpolationMode.Linear,
        CompositeMode compositeMode = CompositeMode.SourceOver)
        where TD2D1DeviceContext : unmanaged, ID2D1DeviceContext.Interface
    {
        self.DrawImage(effect, &targetOffset, null, interpolationMode, compositeMode);
    }

    public static void DrawImage<TD2D1DeviceContext>(
        ref this TD2D1DeviceContext self, ID2D1Image* image,
        Vector2 targetOffset,
        RectF* imageRectangle,
        InterpolationMode interpolationMode = InterpolationMode.Linear,
        CompositeMode compositeMode = CompositeMode.SourceOver)
        where TD2D1DeviceContext : unmanaged, ID2D1DeviceContext.Interface
    {
        self.DrawImage(image, &targetOffset, imageRectangle, interpolationMode, compositeMode);
    }

    public static void DrawImage<TD2D1DeviceContext>(
        ref this TD2D1DeviceContext self, ID2D1Effect* effect,
        Vector2 targetOffset,
        RectF* imageRectangle,
        InterpolationMode interpolationMode = InterpolationMode.Linear,
        CompositeMode compositeMode = CompositeMode.SourceOver)
        where TD2D1DeviceContext : unmanaged, ID2D1DeviceContext.Interface
    {
        self.DrawImage(effect, &targetOffset, imageRectangle, interpolationMode, compositeMode);
    }

    public static void DrawGdiMetafile<TD2D1DeviceContext>(
        ref this TD2D1DeviceContext self, ID2D1GdiMetafile* gdiMetafile, Vector2 targetOffset)
        where TD2D1DeviceContext : unmanaged, ID2D1DeviceContext.Interface
    {
        self.DrawGdiMetafile(gdiMetafile, &targetOffset);
    }

    public static HResult SetDpiCompensatedEffectInput<TD2D1DeviceContext>(
        ref this TD2D1DeviceContext self,
        ID2D1Effect* effect,
        uint inputIndex,
        ID2D1Bitmap* inputBitmap,
        InterpolationMode interpolationMode = InterpolationMode.Linear,
        BorderMode borderMode = BorderMode.Hard)
        where TD2D1DeviceContext : unmanaged, ID2D1DeviceContext.Interface
    {
        HResult hr = HResult.Ok;
        ID2D1Effect* dpiCompensationEffect = null;

        if (inputBitmap == null)
        {
            effect->SetInput(inputIndex, null);
            return hr;
        }

        hr = self.CreateEffect((Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in CLSID_D2D1DpiCompensation)), &dpiCompensationEffect);

        if (hr.Success)
        {
            if (hr.Success)
            {
                dpiCompensationEffect->SetInput(0, (ID2D1Image*)inputBitmap);

                Vector2 bitmapDpi;
                inputBitmap->GetDpi(&bitmapDpi.X, &bitmapDpi.Y);
                hr = dpiCompensationEffect->SetValue(DpiCompensationProp.InputDpi, &bitmapDpi);
            }

            if (hr.Success)
            {
                hr = dpiCompensationEffect->SetValue(DpiCompensationProp.InterpolationMode, &interpolationMode);
            }

            if (hr.Success)
            {
                hr = dpiCompensationEffect->SetValue(DpiCompensationProp.BorderMode, &borderMode);
            }

            if (hr.Success)
            {
                effect->SetInputEffect(inputIndex, dpiCompensationEffect);
            }

            if (dpiCompensationEffect != null)
            {
                _ = dpiCompensationEffect->Release();
            }
        }

        return hr;
    }
}
