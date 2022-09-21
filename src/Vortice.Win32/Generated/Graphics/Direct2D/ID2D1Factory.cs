// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1Factory"]/*' />
/// <unmanaged>ID2D1Factory</unmanaged>
[Guid("06152247-6f50-465a-9245-118bfd3b6007")]
[NativeTypeName("struct ID2D1Factory : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID2D1Factory
{
	public static ref readonly Guid IID_ID2D1Factory
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x47, 0x22, 0x15, 0x06,
				0x50, 0x6F,
				0x5A, 0x46,
				0x92,
				0x45,
				0x11,
				0x8B,
				0xFD,
				0x3B,
				0x60,
				0x07
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1Factory));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IUnknown*, Guid*, void**, int>)(lpVtbl[0]))((IUnknown*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IUnknown*, uint>)(lpVtbl[1]))((IUnknown*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IUnknown*, uint>)(lpVtbl[2]))((IUnknown*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1Factory::ReloadSystemMetrics"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult ReloadSystemMetrics()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory*, int>)(lpVtbl[3]))((ID2D1Factory*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1Factory::GetDesktopDpi"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void GetDesktopDpi(float* dpiX, float* dpiY)
	{
		((delegate* unmanaged[Stdcall]<ID2D1Factory*, float*, float*, void>)(lpVtbl[4]))((ID2D1Factory*)Unsafe.AsPointer(ref this), dpiX, dpiY);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1Factory::CreateRectangleGeometry"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult CreateRectangleGeometry(Common.RectF* rectangle, ID2D1RectangleGeometry** rectangleGeometry)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory*, Common.RectF*, ID2D1RectangleGeometry**, int>)(lpVtbl[5]))((ID2D1Factory*)Unsafe.AsPointer(ref this), rectangle, rectangleGeometry);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1Factory::CreateRoundedRectangleGeometry"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult CreateRoundedRectangleGeometry(RoundedRect* roundedRectangle, ID2D1RoundedRectangleGeometry** roundedRectangleGeometry)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory*, RoundedRect*, ID2D1RoundedRectangleGeometry**, int>)(lpVtbl[6]))((ID2D1Factory*)Unsafe.AsPointer(ref this), roundedRectangle, roundedRectangleGeometry);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1Factory::CreateEllipseGeometry"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CreateEllipseGeometry(Ellipse* ellipse, ID2D1EllipseGeometry** ellipseGeometry)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory*, Ellipse*, ID2D1EllipseGeometry**, int>)(lpVtbl[7]))((ID2D1Factory*)Unsafe.AsPointer(ref this), ellipse, ellipseGeometry);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1Factory::CreateGeometryGroup"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateGeometryGroup(Common.FillMode fillMode, ID2D1Geometry** geometries, uint geometriesCount, ID2D1GeometryGroup** geometryGroup)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory*, Common.FillMode, ID2D1Geometry**, uint, ID2D1GeometryGroup**, int>)(lpVtbl[8]))((ID2D1Factory*)Unsafe.AsPointer(ref this), fillMode, geometries, geometriesCount, geometryGroup);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1Factory::CreateTransformedGeometry"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult CreateTransformedGeometry(ID2D1Geometry* sourceGeometry, Matrix3x2* transform, ID2D1TransformedGeometry** transformedGeometry)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory*, ID2D1Geometry*, Matrix3x2*, ID2D1TransformedGeometry**, int>)(lpVtbl[9]))((ID2D1Factory*)Unsafe.AsPointer(ref this), sourceGeometry, transform, transformedGeometry);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1Factory::CreatePathGeometry"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult CreatePathGeometry(ID2D1PathGeometry** pathGeometry)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory*, ID2D1PathGeometry**, int>)(lpVtbl[10]))((ID2D1Factory*)Unsafe.AsPointer(ref this), pathGeometry);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1Factory::CreateStrokeStyle"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult CreateStrokeStyle(StrokeStyleProperties* strokeStyleProperties, float* dashes, uint dashesCount, ID2D1StrokeStyle** strokeStyle)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)(lpVtbl[11]))((ID2D1Factory*)Unsafe.AsPointer(ref this), strokeStyleProperties, dashes, dashesCount, strokeStyle);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1Factory::CreateDrawingStateBlock"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult CreateDrawingStateBlock(DrawingStateDescription* drawingStateDescription, Graphics.DirectWrite.IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock** drawingStateBlock)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory*, DrawingStateDescription*, Graphics.DirectWrite.IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)(lpVtbl[12]))((ID2D1Factory*)Unsafe.AsPointer(ref this), drawingStateDescription, textRenderingParams, drawingStateBlock);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1Factory::CreateWicBitmapRenderTarget"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult CreateWicBitmapRenderTarget(Graphics.Imaging.IWICBitmap* target, RenderTargetProperties* renderTargetProperties, ID2D1RenderTarget** renderTarget)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory*, Graphics.Imaging.IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)(lpVtbl[13]))((ID2D1Factory*)Unsafe.AsPointer(ref this), target, renderTargetProperties, renderTarget);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1Factory::CreateHwndRenderTarget"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult CreateHwndRenderTarget(RenderTargetProperties* renderTargetProperties, HwndRenderTargetProperties* hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)(lpVtbl[14]))((ID2D1Factory*)Unsafe.AsPointer(ref this), renderTargetProperties, hwndRenderTargetProperties, hwndRenderTarget);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1Factory::CreateDxgiSurfaceRenderTarget"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult CreateDxgiSurfaceRenderTarget(Graphics.Dxgi.IDXGISurface* dxgiSurface, RenderTargetProperties* renderTargetProperties, ID2D1RenderTarget** renderTarget)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory*, Graphics.Dxgi.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)(lpVtbl[15]))((ID2D1Factory*)Unsafe.AsPointer(ref this), dxgiSurface, renderTargetProperties, renderTarget);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1Factory::CreateDCRenderTarget"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult CreateDCRenderTarget(RenderTargetProperties* renderTargetProperties, ID2D1DCRenderTarget** dcRenderTarget)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory*, RenderTargetProperties*, ID2D1DCRenderTarget**, int>)(lpVtbl[16]))((ID2D1Factory*)Unsafe.AsPointer(ref this), renderTargetProperties, dcRenderTarget);
	}
}

