// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1GradientStopCollection"]/*' />
/// <unmanaged>ID2D1GradientStopCollection</unmanaged>
[Guid("2cd906a7-12e2-11dc-9fed-001143a055f9")]
[NativeTypeName("struct ID2D1GradientStopCollection : ID2D1Resource")]
[NativeInheritance("ID2D1Resource")]
public unsafe partial struct ID2D1GradientStopCollection : INativeGuid
{
	public static ref readonly Guid IID_ID2D1GradientStopCollection
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xA7, 0x06, 0xD9, 0x2C,
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
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1GradientStopCollection));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1GradientStopCollection));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1GradientStopCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection*, uint>)(lpVtbl[1]))((ID2D1GradientStopCollection*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection*, uint>)(lpVtbl[2]))((ID2D1GradientStopCollection*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1Resource.GetFactory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetFactory(ID2D1Factory** factory)
	{
		((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1GradientStopCollection*)Unsafe.AsPointer(ref this), factory);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1GradientStopCollection::GetGradientStopCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public uint GetGradientStopCount()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection*, uint>)(lpVtbl[4]))((ID2D1GradientStopCollection*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1GradientStopCollection::GetGradientStops"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public void GetGradientStops(GradientStop* gradientStops, uint gradientStopsCount)
	{
		((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection*, GradientStop*, uint, void>)(lpVtbl[5]))((ID2D1GradientStopCollection*)Unsafe.AsPointer(ref this), gradientStops, gradientStopsCount);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1GradientStopCollection::GetColorInterpolationGamma"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public Gamma GetColorInterpolationGamma()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection*, Gamma>)(lpVtbl[6]))((ID2D1GradientStopCollection*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1GradientStopCollection::GetExtendMode"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public ExtendMode GetExtendMode()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection*, ExtendMode>)(lpVtbl[7]))((ID2D1GradientStopCollection*)Unsafe.AsPointer(ref this));
	}
}

