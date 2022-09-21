// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1GradientStopCollection1"]/*' />
/// <unmanaged>ID2D1GradientStopCollection1</unmanaged>
[Guid("ae1572f4-5dd0-4777-998b-9279472ae63b")]
[NativeTypeName("struct ID2D1GradientStopCollection1 : ID2D1GradientStopCollection")]
[NativeInheritance("ID2D1GradientStopCollection")]
public unsafe partial struct ID2D1GradientStopCollection1
{
	public static ref readonly Guid IID_ID2D1GradientStopCollection1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xF4, 0x72, 0x15, 0xAE,
				0xD0, 0x5D,
				0x77, 0x47,
				0x99,
				0x8B,
				0x92,
				0x79,
				0x47,
				0x2A,
				0xE6,
				0x3B
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1GradientStopCollection1));

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

	/// <inheritdoc cref="ID2D1Resource.GetFactory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetFactory(ID2D1Factory** factory)
	{
		((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this), factory);
	}

	/// <inheritdoc cref="ID2D1GradientStopCollection.GetGradientStopCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public uint GetGradientStopCount()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, uint>)(lpVtbl[4]))((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1GradientStopCollection.GetGradientStops" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public void GetGradientStops(GradientStop* gradientStops, uint gradientStopsCount)
	{
		((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, GradientStop*, uint, void>)(lpVtbl[5]))((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this), gradientStops, gradientStopsCount);
	}

	/// <inheritdoc cref="ID2D1GradientStopCollection.GetColorInterpolationGamma" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public Gamma GetColorInterpolationGamma()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, Gamma>)(lpVtbl[6]))((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1GradientStopCollection.GetExtendMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public ExtendMode GetExtendMode()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, ExtendMode>)(lpVtbl[7]))((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1GradientStopCollection1::GetGradientStops1"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public void GetGradientStops1(GradientStop* gradientStops, uint gradientStopsCount)
	{
		((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, GradientStop*, uint, void>)(lpVtbl[8]))((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this), gradientStops, gradientStopsCount);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1GradientStopCollection1::GetPreInterpolationSpace"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public ColorSpace GetPreInterpolationSpace()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, ColorSpace>)(lpVtbl[9]))((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1GradientStopCollection1::GetPostInterpolationSpace"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public ColorSpace GetPostInterpolationSpace()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, ColorSpace>)(lpVtbl[10]))((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1GradientStopCollection1::GetBufferPrecision"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public BufferPrecision GetBufferPrecision()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, BufferPrecision>)(lpVtbl[11]))((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1GradientStopCollection1::GetColorInterpolationMode"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public ColorInterpolationMode GetColorInterpolationMode()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, ColorInterpolationMode>)(lpVtbl[12]))((ID2D1GradientStopCollection1*)Unsafe.AsPointer(ref this));
	}
}

