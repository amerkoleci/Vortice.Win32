// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget"]/*' />
/// <unmanaged>ID2D1RenderTarget</unmanaged>
[Guid("2cd90694-12e2-11dc-9fed-001143a055f9")]
[NativeTypeName("struct ID2D1RenderTarget : ID2D1Resource")]
[NativeInheritance("ID2D1Resource")]
public unsafe partial struct ID2D1RenderTarget : ID2D1RenderTarget.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID2D1RenderTarget
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x94, 0x06, 0xD9, 0x2C,
				0xE2, 0x12,
				0xDC, 0x11,
				0x9F,
				0xED,
				0x00,
				0x11,
				0x43,
				0xA0,
				0x55,
				0xF9
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1RenderTarget));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, uint>)(lpVtbl[1]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, uint>)(lpVtbl[2]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1Resource.GetFactory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetFactory(ID2D1Factory** factory)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), factory);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::CreateBitmap"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult CreateBitmap(System.Drawing.Size size, void* srcData, uint pitch, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, System.Drawing.Size, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)(lpVtbl[4]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), size, srcData, pitch, bitmapProperties, bitmap);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::CreateBitmapFromWicBitmap"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult CreateBitmapFromWicBitmap(Graphics.Imaging.IWICBitmapSource* wicBitmapSource, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, Graphics.Imaging.IWICBitmapSource*, BitmapProperties*, ID2D1Bitmap**, int>)(lpVtbl[5]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), wicBitmapSource, bitmapProperties, bitmap);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::CreateSharedBitmap"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult CreateSharedBitmap(Guid* riid, void* data, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)(lpVtbl[6]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), riid, data, bitmapProperties, bitmap);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::CreateBitmapBrush"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CreateBitmapBrush(ID2D1Bitmap* bitmap, BitmapBrushProperties* bitmapBrushProperties, BrushProperties* brushProperties, ID2D1BitmapBrush** bitmapBrush)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)(lpVtbl[7]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), bitmap, bitmapBrushProperties, brushProperties, bitmapBrush);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::CreateSolidColorBrush"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateSolidColorBrush(Color4* color, BrushProperties* brushProperties, ID2D1SolidColorBrush** solidColorBrush)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, Color4*, BrushProperties*, ID2D1SolidColorBrush**, int>)(lpVtbl[8]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), color, brushProperties, solidColorBrush);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::CreateGradientStopCollection"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult CreateGradientStopCollection(Common.GradientStop* gradientStops, uint gradientStopsCount, Gamma colorInterpolationGamma, ExtendMode extendMode, ID2D1GradientStopCollection** gradientStopCollection)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, Common.GradientStop*, uint, Gamma, ExtendMode, ID2D1GradientStopCollection**, int>)(lpVtbl[9]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), gradientStops, gradientStopsCount, colorInterpolationGamma, extendMode, gradientStopCollection);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::CreateLinearGradientBrush"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult CreateLinearGradientBrush(LinearGradientBrushProperties* linearGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)(lpVtbl[10]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), linearGradientBrushProperties, brushProperties, gradientStopCollection, linearGradientBrush);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::CreateRadialGradientBrush"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult CreateRadialGradientBrush(RadialGradientBrushProperties* radialGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)(lpVtbl[11]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), radialGradientBrushProperties, brushProperties, gradientStopCollection, radialGradientBrush);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::CreateCompatibleRenderTarget"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult CreateCompatibleRenderTarget(System.Drawing.SizeF* desiredSize, System.Drawing.Size* desiredPixelSize, Common.PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, System.Drawing.SizeF*, System.Drawing.Size*, Common.PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)(lpVtbl[12]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), desiredSize, desiredPixelSize, desiredFormat, options, bitmapRenderTarget);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::CreateLayer"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult CreateLayer(System.Drawing.SizeF* size, ID2D1Layer** layer)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, System.Drawing.SizeF*, ID2D1Layer**, int>)(lpVtbl[13]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), size, layer);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::CreateMesh"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult CreateMesh(ID2D1Mesh** mesh)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, ID2D1Mesh**, int>)(lpVtbl[14]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), mesh);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::DrawLine"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public void DrawLine(Vector2 point0, Vector2 point1, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, Vector2, Vector2, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)(lpVtbl[15]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), point0, point1, brush, strokeWidth, strokeStyle);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::DrawRectangle"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public void DrawRectangle(Win32.Numerics.RectF* rect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, Win32.Numerics.RectF*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)(lpVtbl[16]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), rect, brush, strokeWidth, strokeStyle);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::FillRectangle"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public void FillRectangle(Win32.Numerics.RectF* rect, ID2D1Brush* brush)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, Win32.Numerics.RectF*, ID2D1Brush*, void>)(lpVtbl[17]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), rect, brush);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::DrawRoundedRectangle"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public void DrawRoundedRectangle(RoundedRect* roundedRect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)(lpVtbl[18]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), roundedRect, brush, strokeWidth, strokeStyle);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::FillRoundedRectangle"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public void FillRoundedRectangle(RoundedRect* roundedRect, ID2D1Brush* brush)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, RoundedRect*, ID2D1Brush*, void>)(lpVtbl[19]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), roundedRect, brush);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::DrawEllipse"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public void DrawEllipse(Ellipse* ellipse, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)(lpVtbl[20]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), ellipse, brush, strokeWidth, strokeStyle);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::FillEllipse"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public void FillEllipse(Ellipse* ellipse, ID2D1Brush* brush)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, Ellipse*, ID2D1Brush*, void>)(lpVtbl[21]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), ellipse, brush);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::DrawGeometry"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public void DrawGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)(lpVtbl[22]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), geometry, brush, strokeWidth, strokeStyle);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::FillGeometry"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public void FillGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)(lpVtbl[23]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), geometry, brush, opacityBrush);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::FillMesh"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public void FillMesh(ID2D1Mesh* mesh, ID2D1Brush* brush)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, ID2D1Mesh*, ID2D1Brush*, void>)(lpVtbl[24]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), mesh, brush);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::FillOpacityMask"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public void FillOpacityMask(ID2D1Bitmap* opacityMask, ID2D1Brush* brush, OpacityMaskContent content, Win32.Numerics.RectF* destinationRectangle, Win32.Numerics.RectF* sourceRectangle)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Win32.Numerics.RectF*, Win32.Numerics.RectF*, void>)(lpVtbl[25]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), opacityMask, brush, content, destinationRectangle, sourceRectangle);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::DrawBitmap"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public void DrawBitmap(ID2D1Bitmap* bitmap, Win32.Numerics.RectF* destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, Win32.Numerics.RectF* sourceRectangle)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, ID2D1Bitmap*, Win32.Numerics.RectF*, float, BitmapInterpolationMode, Win32.Numerics.RectF*, void>)(lpVtbl[26]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::DrawText"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public void DrawText(char* @string, uint stringLength, Graphics.DirectWrite.IDWriteTextFormat* textFormat, Win32.Numerics.RectF* layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, Graphics.DirectWrite.MeasuringMode measuringMode)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, char*, uint, Graphics.DirectWrite.IDWriteTextFormat*, Win32.Numerics.RectF*, ID2D1Brush*, DrawTextOptions, Graphics.DirectWrite.MeasuringMode, void>)(lpVtbl[27]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, layoutRect, defaultFillBrush, options, measuringMode);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::DrawTextLayout"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public void DrawTextLayout(Vector2 origin, Graphics.DirectWrite.IDWriteTextLayout* textLayout, ID2D1Brush* defaultFillBrush, DrawTextOptions options)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, Vector2, Graphics.DirectWrite.IDWriteTextLayout*, ID2D1Brush*, DrawTextOptions, void>)(lpVtbl[28]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), origin, textLayout, defaultFillBrush, options);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::DrawGlyphRun"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(29)]
	public void DrawGlyphRun(Vector2 baselineOrigin, Graphics.DirectWrite.GlyphRun* glyphRun, ID2D1Brush* foregroundBrush, Graphics.DirectWrite.MeasuringMode measuringMode)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, Vector2, Graphics.DirectWrite.GlyphRun*, ID2D1Brush*, Graphics.DirectWrite.MeasuringMode, void>)(lpVtbl[29]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), baselineOrigin, glyphRun, foregroundBrush, measuringMode);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::SetTransform"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(30)]
	public void SetTransform(Matrix3x2* transform)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, Matrix3x2*, void>)(lpVtbl[30]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), transform);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::GetTransform"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(31)]
	public void GetTransform(Matrix3x2* transform)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, Matrix3x2*, void>)(lpVtbl[31]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), transform);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::SetAntialiasMode"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(32)]
	public void SetAntialiasMode(AntialiasMode antialiasMode)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, AntialiasMode, void>)(lpVtbl[32]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), antialiasMode);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::GetAntialiasMode"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(33)]
	public AntialiasMode GetAntialiasMode()
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, AntialiasMode>)(lpVtbl[33]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::SetTextAntialiasMode"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(34)]
	public void SetTextAntialiasMode(TextAntialiasMode textAntialiasMode)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, TextAntialiasMode, void>)(lpVtbl[34]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), textAntialiasMode);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::GetTextAntialiasMode"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(35)]
	public TextAntialiasMode GetTextAntialiasMode()
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, TextAntialiasMode>)(lpVtbl[35]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::SetTextRenderingParams"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(36)]
	public void SetTextRenderingParams(Graphics.DirectWrite.IDWriteRenderingParams* textRenderingParams)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, Graphics.DirectWrite.IDWriteRenderingParams*, void>)(lpVtbl[36]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), textRenderingParams);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::GetTextRenderingParams"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(37)]
	public void GetTextRenderingParams(Graphics.DirectWrite.IDWriteRenderingParams** textRenderingParams)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, Graphics.DirectWrite.IDWriteRenderingParams**, void>)(lpVtbl[37]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), textRenderingParams);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::SetTags"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(38)]
	public void SetTags(ulong tag1, ulong tag2)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, ulong, ulong, void>)(lpVtbl[38]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), tag1, tag2);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::GetTags"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(39)]
	public void GetTags(ulong* tag1, ulong* tag2)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, ulong*, ulong*, void>)(lpVtbl[39]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), tag1, tag2);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::PushLayer"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(40)]
	public void PushLayer(LayerParameters* layerParameters, ID2D1Layer* layer)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, LayerParameters*, ID2D1Layer*, void>)(lpVtbl[40]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), layerParameters, layer);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::PopLayer"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(41)]
	public void PopLayer()
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, void>)(lpVtbl[41]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::Flush"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(42)]
	public HResult Flush(ulong* tag1, ulong* tag2)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, ulong*, ulong*, int>)(lpVtbl[42]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), tag1, tag2);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::SaveDrawingState"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(43)]
	public void SaveDrawingState(ID2D1DrawingStateBlock* drawingStateBlock)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, ID2D1DrawingStateBlock*, void>)(lpVtbl[43]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), drawingStateBlock);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::RestoreDrawingState"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(44)]
	public void RestoreDrawingState(ID2D1DrawingStateBlock* drawingStateBlock)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, ID2D1DrawingStateBlock*, void>)(lpVtbl[44]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), drawingStateBlock);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::PushAxisAlignedClip"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(45)]
	public void PushAxisAlignedClip(Win32.Numerics.RectF* clipRect, AntialiasMode antialiasMode)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, Win32.Numerics.RectF*, AntialiasMode, void>)(lpVtbl[45]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), clipRect, antialiasMode);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::PopAxisAlignedClip"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(46)]
	public void PopAxisAlignedClip()
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, void>)(lpVtbl[46]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::Clear"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(47)]
	public void Clear(Color4* clearColor)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, Color4*, void>)(lpVtbl[47]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), clearColor);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::BeginDraw"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(48)]
	public void BeginDraw()
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, void>)(lpVtbl[48]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::EndDraw"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(49)]
	public HResult EndDraw(ulong* tag1 = null, ulong* tag2 = null)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, ulong*, ulong*, int>)(lpVtbl[49]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), tag1, tag2);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::GetPixelFormat"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(50)]
	public Common.PixelFormat GetPixelFormat()
	{
		Common.PixelFormat result;
		return *((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, Common.PixelFormat*, Common.PixelFormat*>)(lpVtbl[50]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), &result);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::SetDpi"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(51)]
	public void SetDpi(float dpiX, float dpiY)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, float, float, void>)(lpVtbl[51]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), dpiX, dpiY);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::GetDpi"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(52)]
	public void GetDpi(float* dpiX, float* dpiY)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, float*, float*, void>)(lpVtbl[52]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), dpiX, dpiY);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::GetSize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(53)]
	public System.Drawing.SizeF GetSize()
	{
		System.Drawing.SizeF result;
		return *((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, System.Drawing.SizeF*, System.Drawing.SizeF*>)(lpVtbl[53]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), &result);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::GetPixelSize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(54)]
	public System.Drawing.Size GetPixelSize()
	{
		System.Drawing.Size result;
		return *((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, System.Drawing.Size*, System.Drawing.Size*>)(lpVtbl[54]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), &result);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::GetMaximumBitmapSize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(55)]
	public uint GetMaximumBitmapSize()
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, uint>)(lpVtbl[55]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderTarget::IsSupported"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(56)]
	public Bool32 IsSupported(RenderTargetProperties* renderTargetProperties)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1RenderTarget*, RenderTargetProperties*, Bool32>)(lpVtbl[56]))((ID2D1RenderTarget*)Unsafe.AsPointer(ref this), renderTargetProperties);
	}

	public interface Interface : ID2D1Resource.Interface
	{
		[VtblIndex(4)]
		HResult CreateBitmap(System.Drawing.Size size, void* srcData, uint pitch, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap);

		[VtblIndex(5)]
		HResult CreateBitmapFromWicBitmap(Graphics.Imaging.IWICBitmapSource* wicBitmapSource, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap);

		[VtblIndex(6)]
		HResult CreateSharedBitmap(Guid* riid, void* data, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap);

		[VtblIndex(7)]
		HResult CreateBitmapBrush(ID2D1Bitmap* bitmap, BitmapBrushProperties* bitmapBrushProperties, BrushProperties* brushProperties, ID2D1BitmapBrush** bitmapBrush);

		[VtblIndex(8)]
		HResult CreateSolidColorBrush(Color4* color, BrushProperties* brushProperties, ID2D1SolidColorBrush** solidColorBrush);

		[VtblIndex(9)]
		HResult CreateGradientStopCollection(Common.GradientStop* gradientStops, uint gradientStopsCount, Gamma colorInterpolationGamma, ExtendMode extendMode, ID2D1GradientStopCollection** gradientStopCollection);

		[VtblIndex(10)]
		HResult CreateLinearGradientBrush(LinearGradientBrushProperties* linearGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush);

		[VtblIndex(11)]
		HResult CreateRadialGradientBrush(RadialGradientBrushProperties* radialGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush);

		[VtblIndex(12)]
		HResult CreateCompatibleRenderTarget(System.Drawing.SizeF* desiredSize, System.Drawing.Size* desiredPixelSize, Common.PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget);

		[VtblIndex(13)]
		HResult CreateLayer(System.Drawing.SizeF* size, ID2D1Layer** layer);

		[VtblIndex(14)]
		HResult CreateMesh(ID2D1Mesh** mesh);

		[VtblIndex(15)]
		void DrawLine(Vector2 point0, Vector2 point1, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle);

		[VtblIndex(16)]
		void DrawRectangle(Win32.Numerics.RectF* rect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle);

		[VtblIndex(17)]
		void FillRectangle(Win32.Numerics.RectF* rect, ID2D1Brush* brush);

		[VtblIndex(18)]
		void DrawRoundedRectangle(RoundedRect* roundedRect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle);

		[VtblIndex(19)]
		void FillRoundedRectangle(RoundedRect* roundedRect, ID2D1Brush* brush);

		[VtblIndex(20)]
		void DrawEllipse(Ellipse* ellipse, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle);

		[VtblIndex(21)]
		void FillEllipse(Ellipse* ellipse, ID2D1Brush* brush);

		[VtblIndex(22)]
		void DrawGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle);

		[VtblIndex(23)]
		void FillGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush);

		[VtblIndex(24)]
		void FillMesh(ID2D1Mesh* mesh, ID2D1Brush* brush);

		[VtblIndex(25)]
		void FillOpacityMask(ID2D1Bitmap* opacityMask, ID2D1Brush* brush, OpacityMaskContent content, Win32.Numerics.RectF* destinationRectangle, Win32.Numerics.RectF* sourceRectangle);

		[VtblIndex(26)]
		void DrawBitmap(ID2D1Bitmap* bitmap, Win32.Numerics.RectF* destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, Win32.Numerics.RectF* sourceRectangle);

		[VtblIndex(27)]
		void DrawText(char* @string, uint stringLength, Graphics.DirectWrite.IDWriteTextFormat* textFormat, Win32.Numerics.RectF* layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, Graphics.DirectWrite.MeasuringMode measuringMode);

		[VtblIndex(28)]
		void DrawTextLayout(Vector2 origin, Graphics.DirectWrite.IDWriteTextLayout* textLayout, ID2D1Brush* defaultFillBrush, DrawTextOptions options);

		[VtblIndex(29)]
		void DrawGlyphRun(Vector2 baselineOrigin, Graphics.DirectWrite.GlyphRun* glyphRun, ID2D1Brush* foregroundBrush, Graphics.DirectWrite.MeasuringMode measuringMode);

		[VtblIndex(30)]
		void SetTransform(Matrix3x2* transform);

		[VtblIndex(31)]
		void GetTransform(Matrix3x2* transform);

		[VtblIndex(32)]
		void SetAntialiasMode(AntialiasMode antialiasMode);

		[VtblIndex(33)]
		AntialiasMode GetAntialiasMode();

		[VtblIndex(34)]
		void SetTextAntialiasMode(TextAntialiasMode textAntialiasMode);

		[VtblIndex(35)]
		TextAntialiasMode GetTextAntialiasMode();

		[VtblIndex(36)]
		void SetTextRenderingParams(Graphics.DirectWrite.IDWriteRenderingParams* textRenderingParams);

		[VtblIndex(37)]
		void GetTextRenderingParams(Graphics.DirectWrite.IDWriteRenderingParams** textRenderingParams);

		[VtblIndex(38)]
		void SetTags(ulong tag1, ulong tag2);

		[VtblIndex(39)]
		void GetTags(ulong* tag1, ulong* tag2);

		[VtblIndex(40)]
		void PushLayer(LayerParameters* layerParameters, ID2D1Layer* layer);

		[VtblIndex(41)]
		void PopLayer();

		[VtblIndex(42)]
		HResult Flush(ulong* tag1, ulong* tag2);

		[VtblIndex(43)]
		void SaveDrawingState(ID2D1DrawingStateBlock* drawingStateBlock);

		[VtblIndex(44)]
		void RestoreDrawingState(ID2D1DrawingStateBlock* drawingStateBlock);

		[VtblIndex(45)]
		void PushAxisAlignedClip(Win32.Numerics.RectF* clipRect, AntialiasMode antialiasMode);

		[VtblIndex(46)]
		void PopAxisAlignedClip();

		[VtblIndex(47)]
		void Clear(Color4* clearColor);

		[VtblIndex(48)]
		void BeginDraw();

		[VtblIndex(49)]
		HResult EndDraw(ulong* tag1 = null, ulong* tag2 = null);

		[VtblIndex(50)]
		Common.PixelFormat GetPixelFormat();

		[VtblIndex(51)]
		void SetDpi(float dpiX, float dpiY);

		[VtblIndex(52)]
		void GetDpi(float* dpiX, float* dpiY);

		[VtblIndex(53)]
		System.Drawing.SizeF GetSize();

		[VtblIndex(54)]
		System.Drawing.Size GetPixelSize();

		[VtblIndex(55)]
		uint GetMaximumBitmapSize();

		[VtblIndex(56)]
		Bool32 IsSupported(RenderTargetProperties* renderTargetProperties);
	}
}

