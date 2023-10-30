// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Factory6"]/*' />
/// <unmanaged>ID2D1Factory6</unmanaged>
[Guid("f9976f46-f642-44c1-97ca-da32ea2a2635")]
[NativeTypeName("struct ID2D1Factory6 : ID2D1Factory5")]
[NativeInheritance("ID2D1Factory5")]
public unsafe partial struct ID2D1Factory6 : ID2D1Factory6.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID2D1Factory6
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x46, 0x6F, 0x97, 0xF9,
				0x42, 0xF6,
				0xC1, 0x44,
				0x97,
				0xCA,
				0xDA,
				0x32,
				0xEA,
				0x2A,
				0x26,
				0x35
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1Factory6));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1Factory6*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1Factory6*, uint>)(lpVtbl[1]))((ID2D1Factory6*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1Factory6*, uint>)(lpVtbl[2]))((ID2D1Factory6*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1Factory.ReloadSystemMetrics" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult ReloadSystemMetrics()
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1Factory6*, int>)(lpVtbl[3]))((ID2D1Factory6*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1Factory.GetDesktopDpi" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void GetDesktopDpi(float* dpiX, float* dpiY)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1Factory6*, float*, float*, void>)(lpVtbl[4]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), dpiX, dpiY);
	}

	/// <inheritdoc cref="ID2D1Factory.CreateRectangleGeometry" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult CreateRectangleGeometry(Win32.Numerics.RectF* rectangle, ID2D1RectangleGeometry** rectangleGeometry)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1Factory6*, Win32.Numerics.RectF*, ID2D1RectangleGeometry**, int>)(lpVtbl[5]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), rectangle, rectangleGeometry);
	}

	/// <inheritdoc cref="ID2D1Factory.CreateRoundedRectangleGeometry" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult CreateRoundedRectangleGeometry(RoundedRect* roundedRectangle, ID2D1RoundedRectangleGeometry** roundedRectangleGeometry)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1Factory6*, RoundedRect*, ID2D1RoundedRectangleGeometry**, int>)(lpVtbl[6]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), roundedRectangle, roundedRectangleGeometry);
	}

	/// <inheritdoc cref="ID2D1Factory.CreateEllipseGeometry" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CreateEllipseGeometry(Ellipse* ellipse, ID2D1EllipseGeometry** ellipseGeometry)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1Factory6*, Ellipse*, ID2D1EllipseGeometry**, int>)(lpVtbl[7]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), ellipse, ellipseGeometry);
	}

	/// <inheritdoc cref="ID2D1Factory.CreateGeometryGroup" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateGeometryGroup(Common.FillMode fillMode, ID2D1Geometry** geometries, uint geometriesCount, ID2D1GeometryGroup** geometryGroup)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1Factory6*, Common.FillMode, ID2D1Geometry**, uint, ID2D1GeometryGroup**, int>)(lpVtbl[8]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), fillMode, geometries, geometriesCount, geometryGroup);
	}

	/// <inheritdoc cref="ID2D1Factory.CreateTransformedGeometry" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult CreateTransformedGeometry(ID2D1Geometry* sourceGeometry, Matrix3x2* transform, ID2D1TransformedGeometry** transformedGeometry)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1Factory6*, ID2D1Geometry*, Matrix3x2*, ID2D1TransformedGeometry**, int>)(lpVtbl[9]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), sourceGeometry, transform, transformedGeometry);
	}

	/// <inheritdoc cref="ID2D1Factory.CreatePathGeometry" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult CreatePathGeometry(ID2D1PathGeometry** pathGeometry)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1Factory6*, ID2D1PathGeometry**, int>)(lpVtbl[10]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), pathGeometry);
	}

	/// <inheritdoc cref="ID2D1Factory.CreateStrokeStyle" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult CreateStrokeStyle(StrokeStyleProperties* strokeStyleProperties, float* dashes, uint dashesCount, ID2D1StrokeStyle** strokeStyle)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1Factory6*, StrokeStyleProperties*, float*, uint, ID2D1StrokeStyle**, int>)(lpVtbl[11]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), strokeStyleProperties, dashes, dashesCount, strokeStyle);
	}

	/// <inheritdoc cref="ID2D1Factory.CreateDrawingStateBlock" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult CreateDrawingStateBlock(DrawingStateDescription* drawingStateDescription, Graphics.DirectWrite.IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock** drawingStateBlock)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1Factory6*, DrawingStateDescription*, Graphics.DirectWrite.IDWriteRenderingParams*, ID2D1DrawingStateBlock**, int>)(lpVtbl[12]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), drawingStateDescription, textRenderingParams, drawingStateBlock);
	}

	/// <inheritdoc cref="ID2D1Factory.CreateWicBitmapRenderTarget" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult CreateWicBitmapRenderTarget(Graphics.Imaging.IWICBitmap* target, RenderTargetProperties* renderTargetProperties, ID2D1RenderTarget** renderTarget)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1Factory6*, Graphics.Imaging.IWICBitmap*, RenderTargetProperties*, ID2D1RenderTarget**, int>)(lpVtbl[13]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), target, renderTargetProperties, renderTarget);
	}

	/// <inheritdoc cref="ID2D1Factory.CreateHwndRenderTarget" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult CreateHwndRenderTarget(RenderTargetProperties* renderTargetProperties, HwndRenderTargetProperties* hwndRenderTargetProperties, ID2D1HwndRenderTarget** hwndRenderTarget)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1Factory6*, RenderTargetProperties*, HwndRenderTargetProperties*, ID2D1HwndRenderTarget**, int>)(lpVtbl[14]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), renderTargetProperties, hwndRenderTargetProperties, hwndRenderTarget);
	}

	/// <inheritdoc cref="ID2D1Factory.CreateDxgiSurfaceRenderTarget" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult CreateDxgiSurfaceRenderTarget(Graphics.Dxgi.IDXGISurface* dxgiSurface, RenderTargetProperties* renderTargetProperties, ID2D1RenderTarget** renderTarget)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1Factory6*, Graphics.Dxgi.IDXGISurface*, RenderTargetProperties*, ID2D1RenderTarget**, int>)(lpVtbl[15]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), dxgiSurface, renderTargetProperties, renderTarget);
	}

	/// <inheritdoc cref="ID2D1Factory.CreateDCRenderTarget" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult CreateDCRenderTarget(RenderTargetProperties* renderTargetProperties, ID2D1DCRenderTarget** dcRenderTarget)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1Factory6*, RenderTargetProperties*, ID2D1DCRenderTarget**, int>)(lpVtbl[16]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), renderTargetProperties, dcRenderTarget);
	}

	/// <inheritdoc cref="ID2D1Factory1.CreateDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult CreateDevice(Graphics.Dxgi.IDXGIDevice* dxgiDevice, ID2D1Device** d2dDevice)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1Factory6*, Graphics.Dxgi.IDXGIDevice*, ID2D1Device**, int>)(lpVtbl[17]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), dxgiDevice, d2dDevice);
	}

	/// <inheritdoc cref="ID2D1Factory1.CreateStrokeStyle" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult CreateStrokeStyle(StrokeStyleProperties1* strokeStyleProperties, float* dashes, uint dashesCount, ID2D1StrokeStyle1** strokeStyle)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1Factory6*, StrokeStyleProperties1*, float*, uint, ID2D1StrokeStyle1**, int>)(lpVtbl[18]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), strokeStyleProperties, dashes, dashesCount, strokeStyle);
	}

	/// <inheritdoc cref="ID2D1Factory1.CreatePathGeometry" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult CreatePathGeometry(ID2D1PathGeometry1** pathGeometry)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1Factory6*, ID2D1PathGeometry1**, int>)(lpVtbl[19]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), pathGeometry);
	}

	/// <inheritdoc cref="ID2D1Factory1.CreateDrawingStateBlock" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult CreateDrawingStateBlock(DrawingStateDescription1* drawingStateDescription, Graphics.DirectWrite.IDWriteRenderingParams* textRenderingParams, ID2D1DrawingStateBlock1** drawingStateBlock)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1Factory6*, DrawingStateDescription1*, Graphics.DirectWrite.IDWriteRenderingParams*, ID2D1DrawingStateBlock1**, int>)(lpVtbl[20]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), drawingStateDescription, textRenderingParams, drawingStateBlock);
	}

	/// <inheritdoc cref="ID2D1Factory1.CreateGdiMetafile" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult CreateGdiMetafile(Com.IStream* metafileStream, ID2D1GdiMetafile** metafile)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1Factory6*, Com.IStream*, ID2D1GdiMetafile**, int>)(lpVtbl[21]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), metafileStream, metafile);
	}

	/// <inheritdoc cref="ID2D1Factory1.RegisterEffectFromStream" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult RegisterEffectFromStream(Guid* classId, Com.IStream* propertyXml, PropertyBinding* bindings, uint bindingsCount, delegate* unmanaged[Stdcall]<IUnknown**, HResult> effectFactory)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1Factory6*, Guid*, Com.IStream*, PropertyBinding*, uint, delegate* unmanaged[Stdcall]<IUnknown**, HResult>, int>)(lpVtbl[22]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), classId, propertyXml, bindings, bindingsCount, effectFactory);
	}

	/// <inheritdoc cref="ID2D1Factory1.RegisterEffectFromString" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public HResult RegisterEffectFromString(Guid* classId, ushort* propertyXml, PropertyBinding* bindings, uint bindingsCount, delegate* unmanaged[Stdcall]<IUnknown**, HResult> effectFactory)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1Factory6*, Guid*, ushort*, PropertyBinding*, uint, delegate* unmanaged[Stdcall]<IUnknown**, HResult>, int>)(lpVtbl[23]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), classId, propertyXml, bindings, bindingsCount, effectFactory);
	}

	/// <inheritdoc cref="ID2D1Factory1.UnregisterEffect" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult UnregisterEffect(Guid* classId)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1Factory6*, Guid*, int>)(lpVtbl[24]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), classId);
	}

	/// <inheritdoc cref="ID2D1Factory1.GetRegisteredEffects" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public HResult GetRegisteredEffects(Guid* effects, uint effectsCount, uint* effectsReturned, uint* effectsRegistered)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1Factory6*, Guid*, uint, uint*, uint*, int>)(lpVtbl[25]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), effects, effectsCount, effectsReturned, effectsRegistered);
	}

	/// <inheritdoc cref="ID2D1Factory1.GetEffectProperties" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public HResult GetEffectProperties(Guid* effectId, ID2D1Properties** properties)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1Factory6*, Guid*, ID2D1Properties**, int>)(lpVtbl[26]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), effectId, properties);
	}

	/// <inheritdoc cref="ID2D1Factory2.CreateDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public HResult CreateDevice(Graphics.Dxgi.IDXGIDevice* dxgiDevice, ID2D1Device1** d2dDevice1)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1Factory6*, Graphics.Dxgi.IDXGIDevice*, ID2D1Device1**, int>)(lpVtbl[27]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), dxgiDevice, d2dDevice1);
	}

	/// <inheritdoc cref="ID2D1Factory3.CreateDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public HResult CreateDevice(Graphics.Dxgi.IDXGIDevice* dxgiDevice, ID2D1Device2** d2dDevice2)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1Factory6*, Graphics.Dxgi.IDXGIDevice*, ID2D1Device2**, int>)(lpVtbl[28]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), dxgiDevice, d2dDevice2);
	}

	/// <inheritdoc cref="ID2D1Factory4.CreateDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(29)]
	public HResult CreateDevice(Graphics.Dxgi.IDXGIDevice* dxgiDevice, ID2D1Device3** d2dDevice3)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1Factory6*, Graphics.Dxgi.IDXGIDevice*, ID2D1Device3**, int>)(lpVtbl[29]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), dxgiDevice, d2dDevice3);
	}

	/// <inheritdoc cref="ID2D1Factory5.CreateDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(30)]
	public HResult CreateDevice(Graphics.Dxgi.IDXGIDevice* dxgiDevice, ID2D1Device4** d2dDevice4)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1Factory6*, Graphics.Dxgi.IDXGIDevice*, ID2D1Device4**, int>)(lpVtbl[30]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), dxgiDevice, d2dDevice4);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Factory6::CreateDevice"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(31)]
	public HResult CreateDevice(Graphics.Dxgi.IDXGIDevice* dxgiDevice, ID2D1Device5** d2dDevice5)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1Factory6*, Graphics.Dxgi.IDXGIDevice*, ID2D1Device5**, int>)(lpVtbl[31]))((ID2D1Factory6*)Unsafe.AsPointer(ref this), dxgiDevice, d2dDevice5);
	}

	public interface Interface : ID2D1Factory5.Interface
	{
		[VtblIndex(31)]
		HResult CreateDevice(Graphics.Dxgi.IDXGIDevice* dxgiDevice, ID2D1Device5** d2dDevice5);
	}
}

