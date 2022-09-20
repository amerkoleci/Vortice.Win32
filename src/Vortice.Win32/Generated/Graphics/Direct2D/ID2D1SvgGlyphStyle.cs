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

/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1SvgGlyphStyle"]/*' />
/// <unmanaged>ID2D1SvgGlyphStyle</unmanaged>
[Guid("af671749-d241-4db8-8e41-dcc2e5c1a438")]
[NativeTypeName("struct ID2D1SvgGlyphStyle : ID2D1Resource")]
[NativeInheritance("ID2D1Resource")]
public unsafe partial struct ID2D1SvgGlyphStyle
{
	public static ref readonly Guid IID_ID2D1SvgGlyphStyle
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x49, 0x17, 0x67, 0xAF,
				0x41, 0xD2,
				0xB8, 0x4D,
				0x8E,
				0x41,
				0xDC,
				0xC2,
				0xE5,
				0xC1,
				0xA4,
				0x38
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1SvgGlyphStyle));

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
		((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this), factory);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1SvgGlyphStyle::SetFill"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetFill(ID2D1Brush* brush)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush*, int>)(lpVtbl[4]))((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this), brush);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1SvgGlyphStyle::GetFill"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public void GetFill(ID2D1Brush** brush)
	{
		((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, void>)(lpVtbl[5]))((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this), brush);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1SvgGlyphStyle::SetStroke"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetStroke(ID2D1Brush* brush, float strokeWidth, float* dashes, uint dashesCount, float dashOffset)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush*, float, float*, uint, float, int>)(lpVtbl[6]))((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this), brush, strokeWidth, dashes, dashesCount, dashOffset);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1SvgGlyphStyle::GetStrokeDashesCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public uint GetStrokeDashesCount()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, uint>)(lpVtbl[7]))((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1SvgGlyphStyle::GetStroke"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public void GetStroke(ID2D1Brush** brush, float* strokeWidth, float* dashes, uint dashesCount, float* dashOffset)
	{
		((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)(lpVtbl[8]))((ID2D1SvgGlyphStyle*)Unsafe.AsPointer(ref this), brush, strokeWidth, dashes, dashesCount, dashOffset);
	}
}

