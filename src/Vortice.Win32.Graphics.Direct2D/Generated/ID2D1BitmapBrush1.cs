// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1BitmapBrush1"]/*' />
/// <unmanaged>ID2D1BitmapBrush1</unmanaged>
[Guid("41343a53-e41a-49a2-91cd-21793bbb62e5")]
[NativeTypeName("struct ID2D1BitmapBrush1 : ID2D1BitmapBrush")]
[NativeInheritance("ID2D1BitmapBrush")]
public unsafe partial struct ID2D1BitmapBrush1 : ID2D1BitmapBrush1.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID2D1BitmapBrush1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x53, 0x3A, 0x34, 0x41,
				0x1A, 0xE4,
				0xA2, 0x49,
				0x91,
				0xCD,
				0x21,
				0x79,
				0x3B,
				0xBB,
				0x62,
				0xE5
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1BitmapBrush1));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1BitmapBrush1*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1BitmapBrush1*, uint>)(lpVtbl[1]))((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1BitmapBrush1*, uint>)(lpVtbl[2]))((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1Resource.GetFactory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetFactory(ID2D1Factory** factory)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1BitmapBrush1*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this), factory);
	}

	/// <inheritdoc cref="ID2D1Brush.SetOpacity" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void SetOpacity(float opacity)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1BitmapBrush1*, float, void>)(lpVtbl[4]))((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this), opacity);
	}

	/// <inheritdoc cref="ID2D1Brush.SetTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public void SetTransform(Matrix3x2* transform)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1BitmapBrush1*, Matrix3x2*, void>)(lpVtbl[5]))((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this), transform);
	}

	/// <inheritdoc cref="ID2D1Brush.GetOpacity" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public float GetOpacity()
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1BitmapBrush1*, float>)(lpVtbl[6]))((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1Brush.GetTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public void GetTransform(Matrix3x2* transform)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1BitmapBrush1*, Matrix3x2*, void>)(lpVtbl[7]))((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this), transform);
	}

	/// <inheritdoc cref="ID2D1BitmapBrush.SetExtendModeX" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public void SetExtendModeX(ExtendMode extendModeX)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1BitmapBrush1*, ExtendMode, void>)(lpVtbl[8]))((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this), extendModeX);
	}

	/// <inheritdoc cref="ID2D1BitmapBrush.SetExtendModeY" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public void SetExtendModeY(ExtendMode extendModeY)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1BitmapBrush1*, ExtendMode, void>)(lpVtbl[9]))((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this), extendModeY);
	}

	/// <inheritdoc cref="ID2D1BitmapBrush.SetInterpolationMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public void SetInterpolationMode(BitmapInterpolationMode interpolationMode)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1BitmapBrush1*, BitmapInterpolationMode, void>)(lpVtbl[10]))((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this), interpolationMode);
	}

	/// <inheritdoc cref="ID2D1BitmapBrush.SetBitmap" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public void SetBitmap(ID2D1Bitmap* bitmap)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1BitmapBrush1*, ID2D1Bitmap*, void>)(lpVtbl[11]))((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this), bitmap);
	}

	/// <inheritdoc cref="ID2D1BitmapBrush.GetExtendModeX" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public ExtendMode GetExtendModeX()
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1BitmapBrush1*, ExtendMode>)(lpVtbl[12]))((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1BitmapBrush.GetExtendModeY" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public ExtendMode GetExtendModeY()
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1BitmapBrush1*, ExtendMode>)(lpVtbl[13]))((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1BitmapBrush.GetInterpolationMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public BitmapInterpolationMode GetInterpolationMode()
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1BitmapBrush1*, BitmapInterpolationMode>)(lpVtbl[14]))((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1BitmapBrush.GetBitmap" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public void GetBitmap(ID2D1Bitmap** bitmap)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1BitmapBrush1*, ID2D1Bitmap**, void>)(lpVtbl[15]))((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this), bitmap);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1BitmapBrush1::SetInterpolationMode1"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public void SetInterpolationMode1(InterpolationMode interpolationMode)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1BitmapBrush1*, InterpolationMode, void>)(lpVtbl[16]))((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this), interpolationMode);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1BitmapBrush1::GetInterpolationMode1"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public InterpolationMode GetInterpolationMode1()
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1BitmapBrush1*, InterpolationMode>)(lpVtbl[17]))((ID2D1BitmapBrush1*)Unsafe.AsPointer(ref this));
	}

	public interface Interface : ID2D1BitmapBrush.Interface
	{
		[VtblIndex(16)]
		void SetInterpolationMode1(InterpolationMode interpolationMode);

		[VtblIndex(17)]
		InterpolationMode GetInterpolationMode1();
	}
}

