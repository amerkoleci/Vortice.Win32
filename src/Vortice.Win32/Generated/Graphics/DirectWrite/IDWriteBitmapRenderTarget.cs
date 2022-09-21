// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteBitmapRenderTarget"]/*' />
/// <unmanaged>IDWriteBitmapRenderTarget</unmanaged>
[Guid("5e5a32a3-8dff-4773-9ff6-0696eab77267")]
[NativeTypeName("struct IDWriteBitmapRenderTarget : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteBitmapRenderTarget
{
	public static ref readonly Guid IID_IDWriteBitmapRenderTarget
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xA3, 0x32, 0x5A, 0x5E,
				0xFF, 0x8D,
				0x73, 0x47,
				0x9F,
				0xF6,
				0x06,
				0x96,
				0xEA,
				0xB7,
				0x72,
				0x67
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteBitmapRenderTarget));

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

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteBitmapRenderTarget::DrawGlyphRun"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult DrawGlyphRun(float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, GlyphRun* glyphRun, IDWriteRenderingParams* renderingParams, uint textColor, RawRect* blackBoxRect)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, float, float, MeasuringMode, GlyphRun*, IDWriteRenderingParams*, uint, RawRect*, int>)(lpVtbl[3]))((IDWriteBitmapRenderTarget*)Unsafe.AsPointer(ref this), baselineOriginX, baselineOriginY, measuringMode, glyphRun, renderingParams, textColor, blackBoxRect);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteBitmapRenderTarget::GetMemoryDC"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public IntPtr GetMemoryDC()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, IntPtr>)(lpVtbl[4]))((IDWriteBitmapRenderTarget*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteBitmapRenderTarget::GetPixelsPerDip"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public float GetPixelsPerDip()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, float>)(lpVtbl[5]))((IDWriteBitmapRenderTarget*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteBitmapRenderTarget::SetPixelsPerDip"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetPixelsPerDip(float pixelsPerDip)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, float, int>)(lpVtbl[6]))((IDWriteBitmapRenderTarget*)Unsafe.AsPointer(ref this), pixelsPerDip);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteBitmapRenderTarget::GetCurrentTransform"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetCurrentTransform(Matrix3x2* transform)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, Matrix3x2*, int>)(lpVtbl[7]))((IDWriteBitmapRenderTarget*)Unsafe.AsPointer(ref this), transform);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteBitmapRenderTarget::SetCurrentTransform"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult SetCurrentTransform(Matrix3x2* transform)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, Matrix3x2*, int>)(lpVtbl[8]))((IDWriteBitmapRenderTarget*)Unsafe.AsPointer(ref this), transform);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteBitmapRenderTarget::GetSize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetSize(System.Drawing.Size* size)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, System.Drawing.Size*, int>)(lpVtbl[9]))((IDWriteBitmapRenderTarget*)Unsafe.AsPointer(ref this), size);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteBitmapRenderTarget::Resize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult Resize(uint width, uint height)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, uint, uint, int>)(lpVtbl[10]))((IDWriteBitmapRenderTarget*)Unsafe.AsPointer(ref this), width, height);
	}
}

