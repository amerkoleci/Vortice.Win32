// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------


#if !NET6_0_OR_GREATER
using MemoryMarshal = Win32.MemoryMarshal;
#endif

namespace Win32.Graphics.Direct2D;

/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1Factory4"]/*' />
/// <unmanaged>ID2D1Factory4</unmanaged>
[Guid("bd4ec2d2-0662-4bee-ba8e-6f29f032e096")]
[NativeTypeName("struct ID2D1Factory4 : ID2D1Factory3")]
[NativeInheritance("ID2D1Factory3")]
public unsafe partial struct ID2D1Factory4
{
	public static ref readonly Guid IID_ID2D1Factory4
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xD2, 0xC2, 0x4E, 0xBD,
				0x62, 0x06,
				0xEE, 0x4B,
				0xBA,
				0x8E,
				0x6F,
				0x29,
				0xF0,
				0x32,
				0xE0,
				0x96
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1Factory4));

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

	/// <inheritdoc cref="ID2D1Factory.ReloadSystemMetrics" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult ReloadSystemMetrics()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, int>)(lpVtbl[3]))((ID2D1Factory4*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1Factory.GetDesktopDpi" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void GetDesktopDpi(float* dpiX, float* dpiY)
	{
		((delegate* unmanaged[Stdcall]<ID2D1Factory4*, float*, float*, void>)(lpVtbl[4]))((ID2D1Factory4*)Unsafe.AsPointer(ref this), dpiX, dpiY);
	}

	/// <inheritdoc cref="ID2D1Factory.CreateRectangleGeometry" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult CreateRectangleGeometry(Common.RectF* rectangle, ID2D1RectangleGeometry** rectangleGeometry)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Common.RectF*, ID2D1RectangleGeometry**, int>)(lpVtbl[5]))((ID2D1Factory4*)Unsafe.AsPointer(ref this), rectangle, rectangleGeometry);
	}

	/// <inheritdoc cref="ID2D1Factory.CreateRoundedRectangleGeometry" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult CreateRoundedRectangleGeometry(RoundedRect* roundedRectangle, ID2D1RoundedRectangleGeometry** roundedRectangleGeometry)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RoundedRect*, ID2D1RoundedRectangleGeometry**, int>)(lpVtbl[6]))((ID2D1Factory4*)Unsafe.AsPointer(ref this), roundedRectangle, roundedRectangleGeometry);
	}

	/// <inheritdoc cref="ID2D1Factory.CreateEllipseGeometry" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CreateEllipseGeometry(Ellipse* ellipse, ID2D1EllipseGeometry** ellipseGeometry)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Ellipse*, ID2D1EllipseGeometry**, int>)(lpVtbl[7]))((ID2D1Factory4*)Unsafe.AsPointer(ref this), ellipse, ellipseGeometry);
	}

	/// <inheritdoc cref="ID2D1Factory.CreateGeometryGroup" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateGeometryGroup(Common.FillMode fillMode, ID2D1Geometry** geometries, uint geometriesCount, ID2D1GeometryGroup** geometryGroup)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Common.FillMode, ID2D1Geometry**, uint, ID2D1GeometryGroup**, int>)(lpVtbl[8]))((ID2D1Factory4*)Unsafe.AsPointer(ref this), fillMode, geometries, geometriesCount, geometryGroup);
	}

	/// <inheritdoc cref="ID2D1Factory.CreateTransformedGeometry" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult CreateTransformedGeometry(ID2D1Geometry* sourceGeometry, Matrix3x2* transform, ID2D1TransformedGeometry** transformedGeometry)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, ID2D1Geometry*, Matrix3x2*, ID2D1TransformedGeometry**, int>)(lpVtbl[9]))((ID2D1Factory4*)Unsafe.AsPointer(ref this), sourceGeometry, transform, transformedGeometry);
	}

	/// <inheritdoc cref="ID2D1Factory.CreatePathGeometry" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult CreatePathGeometry(ID2D1PathGeometry** pathGeometry)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, ID2D1PathGeometry**, int>)(lpVtbl[10]))((ID2D1Factory4*)Unsafe.AsPointer(ref this), pathGeometry);
	}

	/// <inheritdoc cref="ID2D1Factory.CreateStrokeStyle" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult CreateStrokeStyle(StrokeStyleProperties* strokeStyleProperties, float* dashes, uint dashesCount, ID2D1StrokeStyle** strokeStyle)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)(lpVtbl[11]))((ID2D1Factory4*)Unsafe.AsPointer(ref this), strokeStyleProperties, dashes, dashesCount, strokeStyle);
	}

	/// <inheritdoc cref="ID2D1Factory.CreateDrawingStateBlock" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult CreateDrawingStateBlock(DrawingStateDescription* drawingStateDescription, Graphics.DirectWrite.IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock** drawingStateBlock)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, DrawingStateDescription*, Graphics.DirectWrite.IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)(lpVtbl[12]))((ID2D1Factory4*)Unsafe.AsPointer(ref this), drawingStateDescription, textRenderingParams, drawingStateBlock);
	}

	/// <inheritdoc cref="ID2D1Factory.CreateWicBitmapRenderTarget" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult CreateWicBitmapRenderTarget(Graphics.Imaging.IWICBitmap* target, RenderTargetProperties* renderTargetProperties, ID2D1RenderTarget** renderTarget)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Graphics.Imaging.IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)(lpVtbl[13]))((ID2D1Factory4*)Unsafe.AsPointer(ref this), target, renderTargetProperties, renderTarget);
	}

	/// <inheritdoc cref="ID2D1Factory.CreateHwndRenderTarget" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult CreateHwndRenderTarget(RenderTargetProperties* renderTargetProperties, HwndRenderTargetProperties* hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)(lpVtbl[14]))((ID2D1Factory4*)Unsafe.AsPointer(ref this), renderTargetProperties, hwndRenderTargetProperties, hwndRenderTarget);
	}

	/// <inheritdoc cref="ID2D1Factory.CreateDxgiSurfaceRenderTarget" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult CreateDxgiSurfaceRenderTarget(Graphics.Dxgi.IDXGISurface* dxgiSurface, RenderTargetProperties* renderTargetProperties, ID2D1RenderTarget** renderTarget)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Graphics.Dxgi.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)(lpVtbl[15]))((ID2D1Factory4*)Unsafe.AsPointer(ref this), dxgiSurface, renderTargetProperties, renderTarget);
	}

	/// <inheritdoc cref="ID2D1Factory.CreateDCRenderTarget" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult CreateDCRenderTarget(RenderTargetProperties* renderTargetProperties, ID2D1DCRenderTarget** dcRenderTarget)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, RenderTargetProperties*, ID2D1DCRenderTarget**, int>)(lpVtbl[16]))((ID2D1Factory4*)Unsafe.AsPointer(ref this), renderTargetProperties, dcRenderTarget);
	}

	/// <inheritdoc cref="ID2D1Factory1.CreateDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult CreateDevice(Graphics.Dxgi.IDXGIDevice* dxgiDevice, ID2D1Device** d2dDevice)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Graphics.Dxgi.IDXGIDevice*, ID2D1Device**, int>)(lpVtbl[17]))((ID2D1Factory4*)Unsafe.AsPointer(ref this), dxgiDevice, d2dDevice);
	}

	/// <inheritdoc cref="ID2D1Factory1.CreateStrokeStyle" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult CreateStrokeStyle(StrokeStyleProperties1* strokeStyleProperties, float* dashes, uint dashesCount, ID2D1StrokeStyle1** strokeStyle)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, StrokeStyleProperties1*, float*, uint, ID2D1StrokeStyle1**, int>)(lpVtbl[18]))((ID2D1Factory4*)Unsafe.AsPointer(ref this), strokeStyleProperties, dashes, dashesCount, strokeStyle);
	}

	/// <inheritdoc cref="ID2D1Factory1.CreatePathGeometry" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult CreatePathGeometry(ID2D1PathGeometry1** pathGeometry)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, ID2D1PathGeometry1**, int>)(lpVtbl[19]))((ID2D1Factory4*)Unsafe.AsPointer(ref this), pathGeometry);
	}

	/// <inheritdoc cref="ID2D1Factory1.CreateDrawingStateBlock" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult CreateDrawingStateBlock(DrawingStateDescription1* drawingStateDescription, Graphics.DirectWrite.IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock1** drawingStateBlock)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, DrawingStateDescription1*, Graphics.DirectWrite.IDWriteRenderingParams*, ID2D1DrawingStateBlock1**, int>)(lpVtbl[20]))((ID2D1Factory4*)Unsafe.AsPointer(ref this), drawingStateDescription, textRenderingParams, drawingStateBlock);
	}

	/// <inheritdoc cref="ID2D1Factory1.CreateGdiMetafile" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult CreateGdiMetafile(Com.IStream* metafileStream, ID2D1GdiMetafile** metafile)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Com.IStream*, ID2D1GdiMetafile**, int>)(lpVtbl[21]))((ID2D1Factory4*)Unsafe.AsPointer(ref this), metafileStream, metafile);
	}

	/// <inheritdoc cref="ID2D1Factory1.RegisterEffectFromStream" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult RegisterEffectFromStream(Guid* classId, Com.IStream* propertyXml, PropertyBinding* bindings, uint bindingsCount, delegate* unmanaged[Stdcall]<void*, void> effectFactory)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, Com.IStream*, PropertyBinding*, uint, delegate* unmanaged[Stdcall]<void*, void>, int>)(lpVtbl[22]))((ID2D1Factory4*)Unsafe.AsPointer(ref this), classId, propertyXml, bindings, bindingsCount, effectFactory);
	}

	/// <inheritdoc cref="ID2D1Factory1.RegisterEffectFromString" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public HResult RegisterEffectFromString(Guid* classId, ushort* propertyXml, PropertyBinding* bindings, uint bindingsCount, delegate* unmanaged[Stdcall]<void*, void> effectFactory)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, ushort*, PropertyBinding*, uint, delegate* unmanaged[Stdcall]<void*, void>, int>)(lpVtbl[23]))((ID2D1Factory4*)Unsafe.AsPointer(ref this), classId, propertyXml, bindings, bindingsCount, effectFactory);
	}

	/// <inheritdoc cref="ID2D1Factory1.UnregisterEffect" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult UnregisterEffect(Guid* classId)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, int>)(lpVtbl[24]))((ID2D1Factory4*)Unsafe.AsPointer(ref this), classId);
	}

	/// <inheritdoc cref="ID2D1Factory1.GetRegisteredEffects" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public HResult GetRegisteredEffects(Guid* effects, uint effectsCount, uint* effectsReturned, uint* effectsRegistered)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, uint, uint*, uint*, int>)(lpVtbl[25]))((ID2D1Factory4*)Unsafe.AsPointer(ref this), effects, effectsCount, effectsReturned, effectsRegistered);
	}

	/// <inheritdoc cref="ID2D1Factory1.GetEffectProperties" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public HResult GetEffectProperties(Guid* effectId, ID2D1Properties** properties)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Guid*, ID2D1Properties**, int>)(lpVtbl[26]))((ID2D1Factory4*)Unsafe.AsPointer(ref this), effectId, properties);
	}

	/// <inheritdoc cref="ID2D1Factory2.CreateDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public HResult CreateDevice(Graphics.Dxgi.IDXGIDevice* dxgiDevice, ID2D1Device1** d2dDevice1)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Graphics.Dxgi.IDXGIDevice*, ID2D1Device1**, int>)(lpVtbl[27]))((ID2D1Factory4*)Unsafe.AsPointer(ref this), dxgiDevice, d2dDevice1);
	}

	/// <inheritdoc cref="ID2D1Factory3.CreateDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public HResult CreateDevice(Graphics.Dxgi.IDXGIDevice* dxgiDevice, ID2D1Device2** d2dDevice2)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Graphics.Dxgi.IDXGIDevice*, ID2D1Device2**, int>)(lpVtbl[28]))((ID2D1Factory4*)Unsafe.AsPointer(ref this), dxgiDevice, d2dDevice2);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1Factory4::CreateDevice"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(29)]
	public HResult CreateDevice(Graphics.Dxgi.IDXGIDevice* dxgiDevice, ID2D1Device3** d2dDevice3)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Factory4*, Graphics.Dxgi.IDXGIDevice*, ID2D1Device3**, int>)(lpVtbl[29]))((ID2D1Factory4*)Unsafe.AsPointer(ref this), dxgiDevice, d2dDevice3);
	}
}

