// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Imaging;

/// <include file='../../Imaging.xml' path='doc/member[@name="IWICPalette"]/*' />
/// <unmanaged>IWICPalette</unmanaged>
[Guid("00000040-a8f2-4877-ba0a-fd2b6645fb94")]
[NativeTypeName("struct IWICPalette : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICPalette
{
	public static ref readonly Guid IID_IWICPalette
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x40, 0x00, 0x00, 0x00,
				0xF2, 0xA8,
				0x77, 0x48,
				0xBA,
				0x0A,
				0xFD,
				0x2B,
				0x66,
				0x45,
				0xFB,
				0x94
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICPalette));

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

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICPalette::InitializePredefined"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult InitializePredefined(WICBitmapPaletteType ePaletteType, Bool32 fAddTransparentColor)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPalette*, WICBitmapPaletteType, Bool32, int>)(lpVtbl[3]))((IWICPalette*)Unsafe.AsPointer(ref this), ePaletteType, fAddTransparentColor);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICPalette::InitializeCustom"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult InitializeCustom(uint* pColors, uint cCount)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPalette*, uint*, uint, int>)(lpVtbl[4]))((IWICPalette*)Unsafe.AsPointer(ref this), pColors, cCount);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICPalette::InitializeFromBitmap"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult InitializeFromBitmap(IWICBitmapSource* pISurface, uint cCount, Bool32 fAddTransparentColor)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPalette*, IWICBitmapSource*, uint, Bool32, int>)(lpVtbl[5]))((IWICPalette*)Unsafe.AsPointer(ref this), pISurface, cCount, fAddTransparentColor);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICPalette::InitializeFromPalette"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult InitializeFromPalette(IWICPalette* pIPalette)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPalette*, IWICPalette*, int>)(lpVtbl[6]))((IWICPalette*)Unsafe.AsPointer(ref this), pIPalette);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICPalette::GetType"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetType(WICBitmapPaletteType* pePaletteType)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPalette*, WICBitmapPaletteType*, int>)(lpVtbl[7]))((IWICPalette*)Unsafe.AsPointer(ref this), pePaletteType);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICPalette::GetColorCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetColorCount(uint* pcCount)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPalette*, uint*, int>)(lpVtbl[8]))((IWICPalette*)Unsafe.AsPointer(ref this), pcCount);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICPalette::GetColors"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetColors(uint cCount, uint* pColors, uint* pcActualColors)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPalette*, uint, uint*, uint*, int>)(lpVtbl[9]))((IWICPalette*)Unsafe.AsPointer(ref this), cCount, pColors, pcActualColors);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICPalette::IsBlackWhite"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult IsBlackWhite(Bool32* pfIsBlackWhite)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPalette*, Bool32*, int>)(lpVtbl[10]))((IWICPalette*)Unsafe.AsPointer(ref this), pfIsBlackWhite);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICPalette::IsGrayscale"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult IsGrayscale(Bool32* pfIsGrayscale)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPalette*, Bool32*, int>)(lpVtbl[11]))((IWICPalette*)Unsafe.AsPointer(ref this), pfIsGrayscale);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICPalette::HasAlpha"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult HasAlpha(Bool32* pfHasAlpha)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPalette*, Bool32*, int>)(lpVtbl[12]))((IWICPalette*)Unsafe.AsPointer(ref this), pfHasAlpha);
	}
}

