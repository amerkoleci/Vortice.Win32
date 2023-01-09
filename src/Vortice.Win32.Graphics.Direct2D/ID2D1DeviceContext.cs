// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Drawing;
using Win32.Graphics.Direct2D.Common;
using Win32.Graphics.Imaging;
using static Win32.Apis;
using static Win32.Graphics.Direct2D.Apis;

namespace Win32.Graphics.Direct2D;

public unsafe partial struct ID2D1DeviceContext
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
    public HResult CreateBitmapFromWicBitmap(IWICBitmapSource* wicBitmapSource, ID2D1Bitmap1** bitmap)
    {
        return CreateBitmapFromWicBitmap(wicBitmapSource, null, bitmap);
    }

    public HResult CreateImageBrush(ID2D1Image* image, ImageBrushProperties* imageBrushProperties, ID2D1ImageBrush** imageBrush)
    {
        return CreateImageBrush(image, imageBrushProperties, null, imageBrush);
    }

    public HResult CreateBitmapBrush(ID2D1Bitmap* bitmap, ID2D1BitmapBrush1** bitmapBrush)
    {
        return CreateBitmapBrush(bitmap, null, null, bitmapBrush);
    }

    public HResult CreateEffect(in Guid effectId, ID2D1Effect** effect)
    {
        return CreateEffect((Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in effectId)), effect);
    }

    public ComPtr<ID2D1Effect> CreateEffect(in Guid effectId)
    {
        using ComPtr<ID2D1Effect> effect = default;
        ThrowIfFailed(CreateEffect((Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in effectId)), effect.GetAddressOf()));
        return effect.Move();
    }

    public void DrawImage(
        ID2D1Effect* effect,
        Vector2* targetOffset = null,
        RectF* imageRectangle = null,
        InterpolationMode interpolationMode = InterpolationMode.Linear,
        CompositeMode compositeMode = CompositeMode.SourceOver)
    {
        ID2D1Image* output = null;

        effect->GetOutput(&output);
        DrawImage(output, targetOffset, imageRectangle, interpolationMode, compositeMode);
        _ = output->Release();
    }

    public void DrawImage(
        ID2D1Image* image,
        InterpolationMode interpolationMode,
        CompositeMode compositeMode = CompositeMode.SourceOver)
    {
        DrawImage(image, null, null, interpolationMode, compositeMode);
    }

    public void DrawImage(ID2D1Effect* effect,
        InterpolationMode interpolationMode,
        CompositeMode compositeMode = CompositeMode.SourceOver)
    {
        DrawImage(effect, null, null, interpolationMode, compositeMode);
    }

    public void DrawImage(ID2D1Image* image,
        Vector2 targetOffset,
        InterpolationMode interpolationMode = InterpolationMode.Linear,
        CompositeMode compositeMode = CompositeMode.SourceOver)
    {
        DrawImage(image, &targetOffset, null, interpolationMode, compositeMode);
    }

    public void DrawImage(ID2D1Effect* effect,
        Vector2 targetOffset,
        InterpolationMode interpolationMode = InterpolationMode.Linear,
        CompositeMode compositeMode = CompositeMode.SourceOver)
    {
        DrawImage(effect, &targetOffset, null, interpolationMode, compositeMode);
    }

    public void DrawImage(ID2D1Image* image,
        Vector2 targetOffset,
        RectF* imageRectangle,
        InterpolationMode interpolationMode = InterpolationMode.Linear,
        CompositeMode compositeMode = CompositeMode.SourceOver)
    {
        DrawImage(image, &targetOffset, imageRectangle, interpolationMode, compositeMode);
    }

    public void DrawImage(ID2D1Effect* effect,
        Vector2 targetOffset,
        RectF* imageRectangle,
        InterpolationMode interpolationMode = InterpolationMode.Linear,
        CompositeMode compositeMode = CompositeMode.SourceOver)
    {
        DrawImage(effect, &targetOffset, imageRectangle, interpolationMode, compositeMode);
    }

    public void DrawGdiMetafile(ID2D1GdiMetafile* gdiMetafile, Vector2 targetOffset)
    {
        DrawGdiMetafile(gdiMetafile, &targetOffset);
    }
}

public static unsafe partial class ID2D1DeviceContextExtensions
{
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
