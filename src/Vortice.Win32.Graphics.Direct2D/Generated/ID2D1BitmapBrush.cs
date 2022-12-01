// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1BitmapBrush"]/*' />
/// <unmanaged>ID2D1BitmapBrush</unmanaged>
[Guid("2cd906aa-12e2-11dc-9fed-001143a055f9")]
[NativeTypeName("struct ID2D1BitmapBrush : ID2D1Brush")]
[NativeInheritance("ID2D1Brush")]
public unsafe partial struct ID2D1BitmapBrush : ID2D1BitmapBrush.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID2D1BitmapBrush
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xAA, 0x06, 0xD9, 0x2C,
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

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1BitmapBrush));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1BitmapBrush));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, uint>)(lpVtbl[1]))((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, uint>)(lpVtbl[2]))((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1Resource.GetFactory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetFactory(ID2D1Factory** factory)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this), factory);
	}

	/// <inheritdoc cref="ID2D1Brush.SetOpacity" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void SetOpacity(float opacity)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, float, void>)(lpVtbl[4]))((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this), opacity);
	}

	/// <inheritdoc cref="ID2D1Brush.SetTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public void SetTransform(Matrix3x2* transform)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, Matrix3x2*, void>)(lpVtbl[5]))((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this), transform);
	}

	/// <inheritdoc cref="ID2D1Brush.GetOpacity" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public float GetOpacity()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, float>)(lpVtbl[6]))((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1Brush.GetTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public void GetTransform(Matrix3x2* transform)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, Matrix3x2*, void>)(lpVtbl[7]))((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this), transform);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1BitmapBrush::SetExtendModeX"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public void SetExtendModeX(ExtendMode extendModeX)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, ExtendMode, void>)(lpVtbl[8]))((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this), extendModeX);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1BitmapBrush::SetExtendModeY"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public void SetExtendModeY(ExtendMode extendModeY)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, ExtendMode, void>)(lpVtbl[9]))((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this), extendModeY);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1BitmapBrush::SetInterpolationMode"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public void SetInterpolationMode(BitmapInterpolationMode interpolationMode)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, BitmapInterpolationMode, void>)(lpVtbl[10]))((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this), interpolationMode);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1BitmapBrush::SetBitmap"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public void SetBitmap(ID2D1Bitmap* bitmap)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, ID2D1Bitmap*, void>)(lpVtbl[11]))((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this), bitmap);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1BitmapBrush::GetExtendModeX"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public ExtendMode GetExtendModeX()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, ExtendMode>)(lpVtbl[12]))((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1BitmapBrush::GetExtendModeY"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public ExtendMode GetExtendModeY()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, ExtendMode>)(lpVtbl[13]))((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1BitmapBrush::GetInterpolationMode"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public BitmapInterpolationMode GetInterpolationMode()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, BitmapInterpolationMode>)(lpVtbl[14]))((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1BitmapBrush::GetBitmap"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public void GetBitmap(ID2D1Bitmap** bitmap)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, ID2D1Bitmap**, void>)(lpVtbl[15]))((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this), bitmap);
	}
	public interface Interface : ID2D1Brush.Interface
	{
		[VtblIndex(8)]
		void SetExtendModeX(ExtendMode extendModeX);

		[VtblIndex(9)]
		void SetExtendModeY(ExtendMode extendModeY);

		[VtblIndex(10)]
		void SetInterpolationMode(BitmapInterpolationMode interpolationMode);

		[VtblIndex(11)]
		void SetBitmap(ID2D1Bitmap* bitmap);

		[VtblIndex(12)]
		ExtendMode GetExtendModeX();

		[VtblIndex(13)]
		ExtendMode GetExtendModeY();

		[VtblIndex(14)]
		BitmapInterpolationMode GetInterpolationMode();

		[VtblIndex(15)]
		void GetBitmap(ID2D1Bitmap** bitmap);
	}
}

