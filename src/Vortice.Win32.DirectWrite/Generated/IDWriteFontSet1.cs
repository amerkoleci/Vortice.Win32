// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontSet1"]/*' />
/// <unmanaged>IDWriteFontSet1</unmanaged>
[Guid("7e9fda85-6c92-4053-bc47-7ae3530db4d3")]
[NativeTypeName("struct IDWriteFontSet1 : IDWriteFontSet")]
[NativeInheritance("IDWriteFontSet")]
public unsafe partial struct IDWriteFontSet1 : INativeGuid
{
	public static ref readonly Guid IID_IDWriteFontSet1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x85, 0xDA, 0x9F, 0x7E,
				0x92, 0x6C,
				0x53, 0x40,
				0xBC,
				0x47,
				0x7A,
				0xE3,
				0x53,
				0x0D,
				0xB4,
				0xD3
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontSet1));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontSet1));
#endif

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

	/// <inheritdoc cref="IDWriteFontSet.GetFontCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public uint GetFontCount()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, uint>)(lpVtbl[3]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFontSet.GetFontFaceReference" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetFontFaceReference(uint listIndex, IDWriteFontFaceReference** fontFaceReference)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, uint, IDWriteFontFaceReference**, int>)(lpVtbl[4]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), listIndex, fontFaceReference);
	}

	/// <inheritdoc cref="IDWriteFontSet.FindFontFaceReference" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult FindFontFaceReference(IDWriteFontFaceReference* fontFaceReference, uint* listIndex, Bool32* exists)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, IDWriteFontFaceReference*, uint*, Bool32*, int>)(lpVtbl[5]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), fontFaceReference, listIndex, exists);
	}

	/// <inheritdoc cref="IDWriteFontSet.FindFontFace" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult FindFontFace(IDWriteFontFace* fontFace, uint* listIndex, Bool32* exists)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, IDWriteFontFace*, uint*, Bool32*, int>)(lpVtbl[6]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), fontFace, listIndex, exists);
	}

	/// <inheritdoc cref="IDWriteFontSet.GetPropertyValues" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetPropertyValues(FontPropertyId propertyID, IDWriteStringList** values)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, FontPropertyId, IDWriteStringList**, int>)(lpVtbl[7]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), propertyID, values);
	}

	/// <inheritdoc cref="IDWriteFontSet.GetPropertyValues" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetPropertyValues(FontPropertyId propertyID, ushort* preferredLocaleNames, IDWriteStringList** values)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, FontPropertyId, ushort*, IDWriteStringList**, int>)(lpVtbl[8]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), propertyID, preferredLocaleNames, values);
	}

	/// <inheritdoc cref="IDWriteFontSet.GetPropertyValues" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetPropertyValues(uint listIndex, FontPropertyId propertyId, Bool32* exists, IDWriteLocalizedStrings** values)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, uint, FontPropertyId, Bool32*, IDWriteLocalizedStrings**, int>)(lpVtbl[9]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), listIndex, propertyId, exists, values);
	}

	/// <inheritdoc cref="IDWriteFontSet.GetPropertyOccurrenceCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult GetPropertyOccurrenceCount(FontProperty* property, uint* propertyOccurrenceCount)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, FontProperty*, uint*, int>)(lpVtbl[10]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), property, propertyOccurrenceCount);
	}

	/// <inheritdoc cref="IDWriteFontSet.GetMatchingFonts" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetMatchingFonts(ushort* familyName, FontWeight fontWeight, FontStretch fontStretch, FontStyle fontStyle, IDWriteFontSet** filteredSet)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, ushort*, FontWeight, FontStretch, FontStyle, IDWriteFontSet**, int>)(lpVtbl[11]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), familyName, fontWeight, fontStretch, fontStyle, filteredSet);
	}

	/// <inheritdoc cref="IDWriteFontSet.GetMatchingFonts" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult GetMatchingFonts(FontProperty* properties, uint propertyCount, IDWriteFontSet** filteredSet)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, FontProperty*, uint, IDWriteFontSet**, int>)(lpVtbl[12]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), properties, propertyCount, filteredSet);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontSet1::GetMatchingFonts"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult GetMatchingFonts(FontProperty* fontProperty, FontAxisValue* fontAxisValues, uint fontAxisValueCount, IDWriteFontSet1** matchingFonts)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, FontProperty*, FontAxisValue*, uint, IDWriteFontSet1**, int>)(lpVtbl[13]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), fontProperty, fontAxisValues, fontAxisValueCount, matchingFonts);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontSet1::GetFirstFontResources"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult GetFirstFontResources(IDWriteFontSet1** filteredFontSet)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, IDWriteFontSet1**, int>)(lpVtbl[14]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), filteredFontSet);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontSet1::GetFilteredFonts"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult GetFilteredFonts(uint* indices, uint indexCount, IDWriteFontSet1** filteredFontSet)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, uint*, uint, IDWriteFontSet1**, int>)(lpVtbl[15]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), indices, indexCount, filteredFontSet);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontSet1::GetFilteredFonts"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult GetFilteredFonts(FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, Bool32 selectAnyRange, IDWriteFontSet1** filteredFontSet)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, FontAxisRange*, uint, Bool32, IDWriteFontSet1**, int>)(lpVtbl[16]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), fontAxisRanges, fontAxisRangeCount, selectAnyRange, filteredFontSet);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontSet1::GetFilteredFonts"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult GetFilteredFonts(FontProperty* properties, uint propertyCount, Bool32 selectAnyProperty, IDWriteFontSet1** filteredFontSet)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, FontProperty*, uint, Bool32, IDWriteFontSet1**, int>)(lpVtbl[17]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), properties, propertyCount, selectAnyProperty, filteredFontSet);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontSet1::GetFilteredFontIndices"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult GetFilteredFontIndices(FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, Bool32 selectAnyRange, uint* indices, uint maxIndexCount, uint* actualIndexCount)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, FontAxisRange*, uint, Bool32, uint*, uint, uint*, int>)(lpVtbl[18]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), fontAxisRanges, fontAxisRangeCount, selectAnyRange, indices, maxIndexCount, actualIndexCount);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontSet1::GetFilteredFontIndices"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult GetFilteredFontIndices(FontProperty* properties, uint propertyCount, Bool32 selectAnyProperty, uint* indices, uint maxIndexCount, uint* actualIndexCount)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, FontProperty*, uint, Bool32, uint*, uint, uint*, int>)(lpVtbl[19]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), properties, propertyCount, selectAnyProperty, indices, maxIndexCount, actualIndexCount);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontSet1::GetFontAxisRanges"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult GetFontAxisRanges(uint listIndex, FontAxisRange* fontAxisRanges, uint maxFontAxisRangeCount, uint* actualFontAxisRangeCount)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, uint, FontAxisRange*, uint, uint*, int>)(lpVtbl[20]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), listIndex, fontAxisRanges, maxFontAxisRangeCount, actualFontAxisRangeCount);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontSet1::GetFontAxisRanges"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult GetFontAxisRanges(FontAxisRange* fontAxisRanges, uint maxFontAxisRangeCount, uint* actualFontAxisRangeCount)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, FontAxisRange*, uint, uint*, int>)(lpVtbl[21]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), fontAxisRanges, maxFontAxisRangeCount, actualFontAxisRangeCount);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontSet1::GetFontFaceReference"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult GetFontFaceReference(uint listIndex, IDWriteFontFaceReference1** fontFaceReference)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, uint, IDWriteFontFaceReference1**, int>)(lpVtbl[22]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), listIndex, fontFaceReference);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontSet1::CreateFontResource"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public HResult CreateFontResource(uint listIndex, IDWriteFontResource** fontResource)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, uint, IDWriteFontResource**, int>)(lpVtbl[23]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), listIndex, fontResource);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontSet1::CreateFontFace"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult CreateFontFace(uint listIndex, IDWriteFontFace5** fontFace)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, uint, IDWriteFontFace5**, int>)(lpVtbl[24]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), listIndex, fontFace);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontSet1::GetFontLocality"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public Locality GetFontLocality(uint listIndex)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSet1*, uint, Locality>)(lpVtbl[25]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), listIndex);
	}
}
