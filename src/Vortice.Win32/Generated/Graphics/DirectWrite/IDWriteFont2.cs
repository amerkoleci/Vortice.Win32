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

namespace Win32.Graphics.DirectWrite;

/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFont2"]/*' />
/// <unmanaged>IDWriteFont2</unmanaged>
[Guid("29748ed6-8c9c-4a6a-be0b-d912e8538944")]
[NativeTypeName("struct IDWriteFont2 : IDWriteFont1")]
[NativeInheritance("IDWriteFont1")]
public unsafe partial struct IDWriteFont2
{
	public static ref readonly Guid IID_IDWriteFont2
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xD6, 0x8E, 0x74, 0x29,
				0x9C, 0x8C,
				0x6A, 0x4A,
				0xBE,
				0x0B,
				0xD9,
				0x12,
				0xE8,
				0x53,
				0x89,
				0x44
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFont2));

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

	/// <inheritdoc cref="IDWriteFont.GetFontFamily" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetFontFamily(IDWriteFontFamily** fontFamily)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFont2*, IDWriteFontFamily**, int>)(lpVtbl[3]))((IDWriteFont2*)Unsafe.AsPointer(ref this), fontFamily);
	}

	/// <inheritdoc cref="IDWriteFont.GetWeight" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public FontWeight GetWeight()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFont2*, FontWeight>)(lpVtbl[4]))((IDWriteFont2*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFont.GetStretch" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public FontStretch GetStretch()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFont2*, FontStretch>)(lpVtbl[5]))((IDWriteFont2*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFont.GetStyle" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public FontStyle GetStyle()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFont2*, FontStyle>)(lpVtbl[6]))((IDWriteFont2*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFont.IsSymbolFont" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public Bool32 IsSymbolFont()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFont2*, Bool32>)(lpVtbl[7]))((IDWriteFont2*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFont.GetFaceNames" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetFaceNames(IDWriteLocalizedStrings** names)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFont2*, IDWriteLocalizedStrings**, int>)(lpVtbl[8]))((IDWriteFont2*)Unsafe.AsPointer(ref this), names);
	}

	/// <inheritdoc cref="IDWriteFont.GetInformationalStrings" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetInformationalStrings(InformationalStringId informationalStringID, IDWriteLocalizedStrings** informationalStrings, Bool32* exists)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFont2*, InformationalStringId, IDWriteLocalizedStrings**, Bool32*, int>)(lpVtbl[9]))((IDWriteFont2*)Unsafe.AsPointer(ref this), informationalStringID, informationalStrings, exists);
	}

	/// <inheritdoc cref="IDWriteFont.GetSimulations" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public FontSimulations GetSimulations()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFont2*, FontSimulations>)(lpVtbl[10]))((IDWriteFont2*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFont.GetMetrics" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public void GetMetrics(FontMetrics* fontMetrics)
	{
		((delegate* unmanaged[Stdcall]<IDWriteFont2*, FontMetrics*, void>)(lpVtbl[11]))((IDWriteFont2*)Unsafe.AsPointer(ref this), fontMetrics);
	}

	/// <inheritdoc cref="IDWriteFont.HasCharacter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult HasCharacter(uint unicodeValue, Bool32* exists)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFont2*, uint, Bool32*, int>)(lpVtbl[12]))((IDWriteFont2*)Unsafe.AsPointer(ref this), unicodeValue, exists);
	}

	/// <inheritdoc cref="IDWriteFont.CreateFontFace" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult CreateFontFace(IDWriteFontFace** fontFace)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFont2*, IDWriteFontFace**, int>)(lpVtbl[13]))((IDWriteFont2*)Unsafe.AsPointer(ref this), fontFace);
	}

	/// <inheritdoc cref="IDWriteFont1.GetMetrics" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public void GetMetrics(FontMetrics1* fontMetrics)
	{
		((delegate* unmanaged[Stdcall]<IDWriteFont2*, FontMetrics1*, void>)(lpVtbl[14]))((IDWriteFont2*)Unsafe.AsPointer(ref this), fontMetrics);
	}

	/// <inheritdoc cref="IDWriteFont1.GetPanose" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public void GetPanose(Panose* panose)
	{
		((delegate* unmanaged[Stdcall]<IDWriteFont2*, Panose*, void>)(lpVtbl[15]))((IDWriteFont2*)Unsafe.AsPointer(ref this), panose);
	}

	/// <inheritdoc cref="IDWriteFont1.GetUnicodeRanges" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult GetUnicodeRanges(uint maxRangeCount, UnicodeRange* unicodeRanges, uint* actualRangeCount)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFont2*, uint, UnicodeRange*, uint*, int>)(lpVtbl[16]))((IDWriteFont2*)Unsafe.AsPointer(ref this), maxRangeCount, unicodeRanges, actualRangeCount);
	}

	/// <inheritdoc cref="IDWriteFont1.IsMonospacedFont" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public Bool32 IsMonospacedFont()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFont2*, Bool32>)(lpVtbl[17]))((IDWriteFont2*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFont2::IsColorFont"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public Bool32 IsColorFont()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFont2*, Bool32>)(lpVtbl[18]))((IDWriteFont2*)Unsafe.AsPointer(ref this));
	}
}

