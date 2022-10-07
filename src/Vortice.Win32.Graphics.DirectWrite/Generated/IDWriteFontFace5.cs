// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFace5"]/*' />
/// <unmanaged>IDWriteFontFace5</unmanaged>
[Guid("98eff3a5-b667-479a-b145-e2fa5b9fdc29")]
[NativeTypeName("struct IDWriteFontFace5 : IDWriteFontFace4")]
[NativeInheritance("IDWriteFontFace4")]
public unsafe partial struct IDWriteFontFace5 : INativeGuid
{
	public static ref readonly Guid IID_IDWriteFontFace5
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xA5, 0xF3, 0xEF, 0x98,
				0x67, 0xB6,
				0x9A, 0x47,
				0xB1,
				0x45,
				0xE2,
				0xFA,
				0x5B,
				0x9F,
				0xDC,
				0x29
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontFace5));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontFace5));
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

	/// <inheritdoc cref="IDWriteFontFace.GetType" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public new FontFaceType GetType()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, FontFaceType>)(lpVtbl[3]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFontFace.GetFiles" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetFiles(uint* numberOfFiles, IDWriteFontFile** fontFiles)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, uint*, IDWriteFontFile**, int>)(lpVtbl[4]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), numberOfFiles, fontFiles);
	}

	/// <inheritdoc cref="IDWriteFontFace.GetIndex" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public uint GetIndex()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, uint>)(lpVtbl[5]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFontFace.GetSimulations" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public FontSimulations GetSimulations()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, FontSimulations>)(lpVtbl[6]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFontFace.IsSymbolFont" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public Bool32 IsSymbolFont()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, Bool32>)(lpVtbl[7]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFontFace.GetMetrics" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public void GetMetrics(FontMetrics* fontFaceMetrics)
	{
		((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, FontMetrics*, void>)(lpVtbl[8]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), fontFaceMetrics);
	}

	/// <inheritdoc cref="IDWriteFontFace.GetGlyphCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public ushort GetGlyphCount()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, ushort>)(lpVtbl[9]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFontFace.GetDesignGlyphMetrics" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult GetDesignGlyphMetrics(ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Bool32 isSideways)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, ushort*, uint, GlyphMetrics*, Bool32, int>)(lpVtbl[10]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), glyphIndices, glyphCount, glyphMetrics, isSideways);
	}

	/// <inheritdoc cref="IDWriteFontFace.GetGlyphIndices" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetGlyphIndices(uint* codePoints, uint codePointCount, ushort* glyphIndices)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, uint*, uint, ushort*, int>)(lpVtbl[11]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), codePoints, codePointCount, glyphIndices);
	}

	/// <inheritdoc cref="IDWriteFontFace.TryGetFontTable" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult TryGetFontTable(uint openTypeTableTag, void** tableData, uint* tableSize, void** tableContext, Bool32* exists)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, uint, void**, uint*, void**, Bool32*, int>)(lpVtbl[12]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), openTypeTableTag, tableData, tableSize, tableContext, exists);
	}

	/// <inheritdoc cref="IDWriteFontFace.ReleaseFontTable" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public void ReleaseFontTable(void* tableContext)
	{
		((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, void*, void>)(lpVtbl[13]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), tableContext);
	}

	/// <inheritdoc cref="IDWriteFontFace.GetGlyphRunOutline" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult GetGlyphRunOutline(float emSize, ushort* glyphIndices, float* glyphAdvances, GlyphOffset* glyphOffsets, uint glyphCount, Bool32 isSideways, Bool32 isRightToLeft, Graphics.Direct2D.Common.ID2D1SimplifiedGeometrySink* geometrySink)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, float, ushort*, float*, GlyphOffset*, uint, Bool32, Bool32, Graphics.Direct2D.Common.ID2D1SimplifiedGeometrySink*, int>)(lpVtbl[14]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), emSize, glyphIndices, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
	}

	/// <inheritdoc cref="IDWriteFontFace.GetRecommendedRenderingMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult GetRecommendedRenderingMode(float emSize, float pixelsPerDip, MeasuringMode measuringMode, IDWriteRenderingParams* renderingParams, RenderingMode* renderingMode)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, float, float, MeasuringMode, IDWriteRenderingParams*, RenderingMode*, int>)(lpVtbl[15]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, measuringMode, renderingParams, renderingMode);
	}

	/// <inheritdoc cref="IDWriteFontFace.GetGdiCompatibleMetrics" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult GetGdiCompatibleMetrics(float emSize, float pixelsPerDip, Matrix3x2* transform, FontMetrics* fontFaceMetrics)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, float, float, Matrix3x2*, FontMetrics*, int>)(lpVtbl[16]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, fontFaceMetrics);
	}

	/// <inheritdoc cref="IDWriteFontFace.GetGdiCompatibleGlyphMetrics" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult GetGdiCompatibleGlyphMetrics(float emSize, float pixelsPerDip, Matrix3x2* transform, Bool32 useGdiNatural, ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Bool32 isSideways)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, float, float, Matrix3x2*, Bool32, ushort*, uint, GlyphMetrics*, Bool32, int>)(lpVtbl[17]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, useGdiNatural, glyphIndices, glyphCount, glyphMetrics, isSideways);
	}

	/// <inheritdoc cref="IDWriteFontFace1.GetMetrics" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public void GetMetrics(FontMetrics1* fontMetrics)
	{
		((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, FontMetrics1*, void>)(lpVtbl[18]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), fontMetrics);
	}

	/// <inheritdoc cref="IDWriteFontFace1.GetGdiCompatibleMetrics" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult GetGdiCompatibleMetrics(float emSize, float pixelsPerDip, Matrix3x2* transform, FontMetrics1* fontMetrics)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, float, float, Matrix3x2*, FontMetrics1*, int>)(lpVtbl[19]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, fontMetrics);
	}

	/// <inheritdoc cref="IDWriteFontFace1.GetCaretMetrics" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public void GetCaretMetrics(CaretMetrics* caretMetrics)
	{
		((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, CaretMetrics*, void>)(lpVtbl[20]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), caretMetrics);
	}

	/// <inheritdoc cref="IDWriteFontFace1.GetUnicodeRanges" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult GetUnicodeRanges(uint maxRangeCount, UnicodeRange* unicodeRanges, uint* actualRangeCount)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, uint, UnicodeRange*, uint*, int>)(lpVtbl[21]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), maxRangeCount, unicodeRanges, actualRangeCount);
	}

	/// <inheritdoc cref="IDWriteFontFace1.IsMonospacedFont" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public Bool32 IsMonospacedFont()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, Bool32>)(lpVtbl[22]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFontFace1.GetDesignGlyphAdvances" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public HResult GetDesignGlyphAdvances(uint glyphCount, ushort* glyphIndices, int* glyphAdvances, Bool32 isSideways)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, uint, ushort*, int*, Bool32, int>)(lpVtbl[23]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), glyphCount, glyphIndices, glyphAdvances, isSideways);
	}

	/// <inheritdoc cref="IDWriteFontFace1.GetGdiCompatibleGlyphAdvances" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult GetGdiCompatibleGlyphAdvances(float emSize, float pixelsPerDip, Matrix3x2* transform, Bool32 useGdiNatural, Bool32 isSideways, uint glyphCount, ushort* glyphIndices, int* glyphAdvances)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, float, float, Matrix3x2*, Bool32, Bool32, uint, ushort*, int*, int>)(lpVtbl[24]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, glyphIndices, glyphAdvances);
	}

	/// <inheritdoc cref="IDWriteFontFace1.GetKerningPairAdjustments" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public HResult GetKerningPairAdjustments(uint glyphCount, ushort* glyphIndices, int* glyphAdvanceAdjustments)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, uint, ushort*, int*, int>)(lpVtbl[25]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), glyphCount, glyphIndices, glyphAdvanceAdjustments);
	}

	/// <inheritdoc cref="IDWriteFontFace1.HasKerningPairs" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public Bool32 HasKerningPairs()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, Bool32>)(lpVtbl[26]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFontFace1.GetRecommendedRenderingMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public HResult GetRecommendedRenderingMode(float fontEmSize, float dpiX, float dpiY, Matrix3x2* transform, Bool32 isSideways, OutlineThreshold outlineThreshold, MeasuringMode measuringMode, RenderingMode* renderingMode)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, float, float, float, Matrix3x2*, Bool32, OutlineThreshold, MeasuringMode, RenderingMode*, int>)(lpVtbl[27]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), fontEmSize, dpiX, dpiY, transform, isSideways, outlineThreshold, measuringMode, renderingMode);
	}

	/// <inheritdoc cref="IDWriteFontFace1.GetVerticalGlyphVariants" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public HResult GetVerticalGlyphVariants(uint glyphCount, ushort* nominalGlyphIndices, ushort* verticalGlyphIndices)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, uint, ushort*, ushort*, int>)(lpVtbl[28]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), glyphCount, nominalGlyphIndices, verticalGlyphIndices);
	}

	/// <inheritdoc cref="IDWriteFontFace1.HasVerticalGlyphVariants" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(29)]
	public Bool32 HasVerticalGlyphVariants()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, Bool32>)(lpVtbl[29]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFontFace2.IsColorFont" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(30)]
	public Bool32 IsColorFont()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, Bool32>)(lpVtbl[30]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFontFace2.GetColorPaletteCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(31)]
	public uint GetColorPaletteCount()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, uint>)(lpVtbl[31]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFontFace2.GetPaletteEntryCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(32)]
	public uint GetPaletteEntryCount()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, uint>)(lpVtbl[32]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFontFace2.GetPaletteEntries" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(33)]
	public HResult GetPaletteEntries(uint colorPaletteIndex, uint firstEntryIndex, uint entryCount, Color4** paletteEntries)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, uint, uint, uint, Color4**, int>)(lpVtbl[33]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), colorPaletteIndex, firstEntryIndex, entryCount, paletteEntries);
	}

	/// <inheritdoc cref="IDWriteFontFace2.GetRecommendedRenderingMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(34)]
	public HResult GetRecommendedRenderingMode(float fontEmSize, float dpiX, float dpiY, Matrix3x2* transform, Bool32 isSideways, OutlineThreshold outlineThreshold, MeasuringMode measuringMode, IDWriteRenderingParams* renderingParams, RenderingMode* renderingMode, GridFitMode* gridFitMode)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, float, float, float, Matrix3x2*, Bool32, OutlineThreshold, MeasuringMode, IDWriteRenderingParams*, RenderingMode*, GridFitMode*, int>)(lpVtbl[34]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), fontEmSize, dpiX, dpiY, transform, isSideways, outlineThreshold, measuringMode, renderingParams, renderingMode, gridFitMode);
	}

	/// <inheritdoc cref="IDWriteFontFace3.GetFontFaceReference" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(35)]
	public HResult GetFontFaceReference(IDWriteFontFaceReference** fontFaceReference)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, IDWriteFontFaceReference**, int>)(lpVtbl[35]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), fontFaceReference);
	}

	/// <inheritdoc cref="IDWriteFontFace3.GetPanose" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(36)]
	public void GetPanose(Panose* panose)
	{
		((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, Panose*, void>)(lpVtbl[36]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), panose);
	}

	/// <inheritdoc cref="IDWriteFontFace3.GetWeight" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(37)]
	public FontWeight GetWeight()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, FontWeight>)(lpVtbl[37]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFontFace3.GetStretch" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(38)]
	public FontStretch GetStretch()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, FontStretch>)(lpVtbl[38]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFontFace3.GetStyle" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(39)]
	public FontStyle GetStyle()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, FontStyle>)(lpVtbl[39]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFontFace3.GetFamilyNames" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(40)]
	public HResult GetFamilyNames(IDWriteLocalizedStrings** names)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, IDWriteLocalizedStrings**, int>)(lpVtbl[40]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), names);
	}

	/// <inheritdoc cref="IDWriteFontFace3.GetFaceNames" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(41)]
	public HResult GetFaceNames(IDWriteLocalizedStrings** names)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, IDWriteLocalizedStrings**, int>)(lpVtbl[41]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), names);
	}

	/// <inheritdoc cref="IDWriteFontFace3.GetInformationalStrings" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(42)]
	public HResult GetInformationalStrings(InformationalStringId informationalStringID, IDWriteLocalizedStrings** informationalStrings, Bool32* exists)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, InformationalStringId, IDWriteLocalizedStrings**, Bool32*, int>)(lpVtbl[42]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), informationalStringID, informationalStrings, exists);
	}

	/// <inheritdoc cref="IDWriteFontFace3.HasCharacter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(43)]
	public Bool32 HasCharacter(uint unicodeValue)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, uint, Bool32>)(lpVtbl[43]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), unicodeValue);
	}

	/// <inheritdoc cref="IDWriteFontFace3.GetRecommendedRenderingMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(44)]
	public HResult GetRecommendedRenderingMode(float fontEmSize, float dpiX, float dpiY, Matrix3x2* transform, Bool32 isSideways, OutlineThreshold outlineThreshold, MeasuringMode measuringMode, IDWriteRenderingParams* renderingParams, RenderingMode1* renderingMode, GridFitMode* gridFitMode)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, float, float, float, Matrix3x2*, Bool32, OutlineThreshold, MeasuringMode, IDWriteRenderingParams*, RenderingMode1*, GridFitMode*, int>)(lpVtbl[44]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), fontEmSize, dpiX, dpiY, transform, isSideways, outlineThreshold, measuringMode, renderingParams, renderingMode, gridFitMode);
	}

	/// <inheritdoc cref="IDWriteFontFace3.IsCharacterLocal" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(45)]
	public Bool32 IsCharacterLocal(uint unicodeValue)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, uint, Bool32>)(lpVtbl[45]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), unicodeValue);
	}

	/// <inheritdoc cref="IDWriteFontFace3.IsGlyphLocal" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(46)]
	public Bool32 IsGlyphLocal(ushort glyphId)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, ushort, Bool32>)(lpVtbl[46]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), glyphId);
	}

	/// <inheritdoc cref="IDWriteFontFace3.AreCharactersLocal" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(47)]
	public HResult AreCharactersLocal(ushort* characters, uint characterCount, Bool32 enqueueIfNotLocal, Bool32* isLocal)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, ushort*, uint, Bool32, Bool32*, int>)(lpVtbl[47]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), characters, characterCount, enqueueIfNotLocal, isLocal);
	}

	/// <inheritdoc cref="IDWriteFontFace3.AreGlyphsLocal" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(48)]
	public HResult AreGlyphsLocal(ushort* glyphIndices, uint glyphCount, Bool32 enqueueIfNotLocal, Bool32* isLocal)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, ushort*, uint, Bool32, Bool32*, int>)(lpVtbl[48]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), glyphIndices, glyphCount, enqueueIfNotLocal, isLocal);
	}

	/// <inheritdoc cref="IDWriteFontFace4.GetGlyphImageFormats" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(49)]
	public HResult GetGlyphImageFormats(ushort glyphId, uint pixelsPerEmFirst, uint pixelsPerEmLast, GlyphImageFormats* glyphImageFormats)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, ushort, uint, uint, GlyphImageFormats*, int>)(lpVtbl[49]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), glyphId, pixelsPerEmFirst, pixelsPerEmLast, glyphImageFormats);
	}

	/// <inheritdoc cref="IDWriteFontFace4.GetGlyphImageFormats" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(50)]
	public GlyphImageFormats GetGlyphImageFormats()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, GlyphImageFormats>)(lpVtbl[50]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFontFace4.GetGlyphImageData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(51)]
	public HResult GetGlyphImageData(ushort glyphId, uint pixelsPerEm, GlyphImageFormats glyphImageFormat, GlyphImageData* glyphData, void** glyphDataContext)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, ushort, uint, GlyphImageFormats, GlyphImageData*, void**, int>)(lpVtbl[51]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), glyphId, pixelsPerEm, glyphImageFormat, glyphData, glyphDataContext);
	}

	/// <inheritdoc cref="IDWriteFontFace4.ReleaseGlyphImageData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(52)]
	public void ReleaseGlyphImageData(void* glyphDataContext)
	{
		((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, void*, void>)(lpVtbl[52]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), glyphDataContext);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFace5::GetFontAxisValueCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(53)]
	public uint GetFontAxisValueCount()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, uint>)(lpVtbl[53]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFace5::GetFontAxisValues"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(54)]
	public HResult GetFontAxisValues(FontAxisValue* fontAxisValues, uint fontAxisValueCount)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, FontAxisValue*, uint, int>)(lpVtbl[54]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), fontAxisValues, fontAxisValueCount);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFace5::HasVariations"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(55)]
	public Bool32 HasVariations()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, Bool32>)(lpVtbl[55]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFace5::GetFontResource"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(56)]
	public HResult GetFontResource(IDWriteFontResource** fontResource)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, IDWriteFontResource**, int>)(lpVtbl[56]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), fontResource);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFace5::Equals"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(57)]
	public Bool32 Equals(IDWriteFontFace* fontFace)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace5*, IDWriteFontFace*, Bool32>)(lpVtbl[57]))((IDWriteFontFace5*)Unsafe.AsPointer(ref this), fontFace);
	}
}
