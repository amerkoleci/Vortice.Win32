// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory"]/*' />
/// <unmanaged>IDWriteFactory</unmanaged>
[Guid("b859ee5a-d838-4b5b-a2e8-1adc7d93db48")]
[NativeTypeName("struct IDWriteFactory : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteFactory : IDWriteFactory.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDWriteFactory
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x5A, 0xEE, 0x59, 0xB8,
				0x38, 0xD8,
				0x5B, 0x4B,
				0xA2,
				0xE8,
				0x1A,
				0xDC,
				0x7D,
				0x93,
				0xDB,
				0x48
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFactory));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory*, uint>)(lpVtbl[1]))((IDWriteFactory*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory*, uint>)(lpVtbl[2]))((IDWriteFactory*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory::GetSystemFontCollection"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetSystemFontCollection(IDWriteFontCollection** fontCollection, Bool32 checkForUpdates)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory*, IDWriteFontCollection**, Bool32, int>)(lpVtbl[3]))((IDWriteFactory*)Unsafe.AsPointer(ref this), fontCollection, checkForUpdates);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory::CreateCustomFontCollection"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult CreateCustomFontCollection(IDWriteFontCollectionLoader* collectionLoader, void* collectionKey, uint collectionKeySize, IDWriteFontCollection** fontCollection)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)(lpVtbl[4]))((IDWriteFactory*)Unsafe.AsPointer(ref this), collectionLoader, collectionKey, collectionKeySize, fontCollection);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory::RegisterFontCollectionLoader"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult RegisterFontCollectionLoader(IDWriteFontCollectionLoader* fontCollectionLoader)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory*, IDWriteFontCollectionLoader*, int>)(lpVtbl[5]))((IDWriteFactory*)Unsafe.AsPointer(ref this), fontCollectionLoader);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory::UnregisterFontCollectionLoader"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult UnregisterFontCollectionLoader(IDWriteFontCollectionLoader* fontCollectionLoader)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory*, IDWriteFontCollectionLoader*, int>)(lpVtbl[6]))((IDWriteFactory*)Unsafe.AsPointer(ref this), fontCollectionLoader);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory::CreateFontFileReference"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CreateFontFileReference(ushort* filePath, ulong* lastWriteTime, IDWriteFontFile** fontFile)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory*, ushort*, ulong*, IDWriteFontFile**, int>)(lpVtbl[7]))((IDWriteFactory*)Unsafe.AsPointer(ref this), filePath, lastWriteTime, fontFile);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory::CreateCustomFontFileReference"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateCustomFontFileReference(void* fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileLoader* fontFileLoader, IDWriteFontFile** fontFile)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)(lpVtbl[8]))((IDWriteFactory*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, fontFileLoader, fontFile);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory::CreateFontFace"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult CreateFontFace(FontFaceType fontFaceType, uint numberOfFiles, IDWriteFontFile** fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, IDWriteFontFace** fontFace)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory*, FontFaceType, uint, IDWriteFontFile**, uint, FontSimulations, IDWriteFontFace**, int>)(lpVtbl[9]))((IDWriteFactory*)Unsafe.AsPointer(ref this), fontFaceType, numberOfFiles, fontFiles, faceIndex, fontFaceSimulationFlags, fontFace);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory::CreateRenderingParams"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult CreateRenderingParams(IDWriteRenderingParams** renderingParams)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory*, IDWriteRenderingParams**, int>)(lpVtbl[10]))((IDWriteFactory*)Unsafe.AsPointer(ref this), renderingParams);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory::CreateMonitorRenderingParams"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult CreateMonitorRenderingParams(IntPtr monitor, IDWriteRenderingParams** renderingParams)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory*, IntPtr, IDWriteRenderingParams**, int>)(lpVtbl[11]))((IDWriteFactory*)Unsafe.AsPointer(ref this), monitor, renderingParams);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory::CreateCustomRenderingParams"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult CreateCustomRenderingParams(float gamma, float enhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, IDWriteRenderingParams** renderingParams)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory*, float, float, float, PixelGeometry, RenderingMode, IDWriteRenderingParams**, int>)(lpVtbl[12]))((IDWriteFactory*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, renderingParams);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory::RegisterFontFileLoader"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult RegisterFontFileLoader(IDWriteFontFileLoader* fontFileLoader)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory*, IDWriteFontFileLoader*, int>)(lpVtbl[13]))((IDWriteFactory*)Unsafe.AsPointer(ref this), fontFileLoader);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory::UnregisterFontFileLoader"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult UnregisterFontFileLoader(IDWriteFontFileLoader* fontFileLoader)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory*, IDWriteFontFileLoader*, int>)(lpVtbl[14]))((IDWriteFactory*)Unsafe.AsPointer(ref this), fontFileLoader);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory::CreateTextFormat"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult CreateTextFormat(ushort* fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, ushort* localeName, IDWriteTextFormat** textFormat)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory*, ushort*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, ushort*, IDWriteTextFormat**, int>)(lpVtbl[15]))((IDWriteFactory*)Unsafe.AsPointer(ref this), fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory::CreateTypography"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult CreateTypography(IDWriteTypography** typography)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory*, IDWriteTypography**, int>)(lpVtbl[16]))((IDWriteFactory*)Unsafe.AsPointer(ref this), typography);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory::GetGdiInterop"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult GetGdiInterop(IDWriteGdiInterop** gdiInterop)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory*, IDWriteGdiInterop**, int>)(lpVtbl[17]))((IDWriteFactory*)Unsafe.AsPointer(ref this), gdiInterop);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory::CreateTextLayout"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult CreateTextLayout(char* @string, uint stringLength, IDWriteTextFormat* textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory*, char*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)(lpVtbl[18]))((IDWriteFactory*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, maxWidth, maxHeight, textLayout);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory::CreateGdiCompatibleTextLayout"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult CreateGdiCompatibleTextLayout(char* @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, Matrix3x2* transform, Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix3x2*, Bool32, IDWriteTextLayout**, int>)(lpVtbl[19]))((IDWriteFactory*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory::CreateEllipsisTrimmingSign"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult CreateEllipsisTrimmingSign(IDWriteTextFormat* textFormat, IDWriteInlineObject** trimmingSign)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory*, IDWriteTextFormat*, IDWriteInlineObject**, int>)(lpVtbl[20]))((IDWriteFactory*)Unsafe.AsPointer(ref this), textFormat, trimmingSign);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory::CreateTextAnalyzer"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult CreateTextAnalyzer(IDWriteTextAnalyzer** textAnalyzer)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory*, IDWriteTextAnalyzer**, int>)(lpVtbl[21]))((IDWriteFactory*)Unsafe.AsPointer(ref this), textAnalyzer);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory::CreateNumberSubstitution"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult CreateNumberSubstitution(NumberSubstitutionMethod substitutionMethod, ushort* localeName, Bool32 ignoreUserOverride, IDWriteNumberSubstitution** numberSubstitution)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory*, NumberSubstitutionMethod, ushort*, Bool32, IDWriteNumberSubstitution**, int>)(lpVtbl[22]))((IDWriteFactory*)Unsafe.AsPointer(ref this), substitutionMethod, localeName, ignoreUserOverride, numberSubstitution);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory::CreateGlyphRunAnalysis"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public HResult CreateGlyphRunAnalysis(GlyphRun* glyphRun, float pixelsPerDip, Matrix3x2* transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory*, GlyphRun*, float, Matrix3x2*, RenderingMode, MeasuringMode, float, float, IDWriteGlyphRunAnalysis**, int>)(lpVtbl[23]))((IDWriteFactory*)Unsafe.AsPointer(ref this), glyphRun, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult GetSystemFontCollection(IDWriteFontCollection** fontCollection, Bool32 checkForUpdates);

		[VtblIndex(4)]
		HResult CreateCustomFontCollection(IDWriteFontCollectionLoader* collectionLoader, void* collectionKey, uint collectionKeySize, IDWriteFontCollection** fontCollection);

		[VtblIndex(5)]
		HResult RegisterFontCollectionLoader(IDWriteFontCollectionLoader* fontCollectionLoader);

		[VtblIndex(6)]
		HResult UnregisterFontCollectionLoader(IDWriteFontCollectionLoader* fontCollectionLoader);

		[VtblIndex(7)]
		HResult CreateFontFileReference(ushort* filePath, ulong* lastWriteTime, IDWriteFontFile** fontFile);

		[VtblIndex(8)]
		HResult CreateCustomFontFileReference(void* fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileLoader* fontFileLoader, IDWriteFontFile** fontFile);

		[VtblIndex(9)]
		HResult CreateFontFace(FontFaceType fontFaceType, uint numberOfFiles, IDWriteFontFile** fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, IDWriteFontFace** fontFace);

		[VtblIndex(10)]
		HResult CreateRenderingParams(IDWriteRenderingParams** renderingParams);

		[VtblIndex(11)]
		HResult CreateMonitorRenderingParams(IntPtr monitor, IDWriteRenderingParams** renderingParams);

		[VtblIndex(12)]
		HResult CreateCustomRenderingParams(float gamma, float enhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, IDWriteRenderingParams** renderingParams);

		[VtblIndex(13)]
		HResult RegisterFontFileLoader(IDWriteFontFileLoader* fontFileLoader);

		[VtblIndex(14)]
		HResult UnregisterFontFileLoader(IDWriteFontFileLoader* fontFileLoader);

		[VtblIndex(15)]
		HResult CreateTextFormat(ushort* fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, ushort* localeName, IDWriteTextFormat** textFormat);

		[VtblIndex(16)]
		HResult CreateTypography(IDWriteTypography** typography);

		[VtblIndex(17)]
		HResult GetGdiInterop(IDWriteGdiInterop** gdiInterop);

		[VtblIndex(18)]
		HResult CreateTextLayout(char* @string, uint stringLength, IDWriteTextFormat* textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout);

		[VtblIndex(19)]
		HResult CreateGdiCompatibleTextLayout(char* @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, Matrix3x2* transform, Bool32 useGdiNatural, IDWriteTextLayout** textLayout);

		[VtblIndex(20)]
		HResult CreateEllipsisTrimmingSign(IDWriteTextFormat* textFormat, IDWriteInlineObject** trimmingSign);

		[VtblIndex(21)]
		HResult CreateTextAnalyzer(IDWriteTextAnalyzer** textAnalyzer);

		[VtblIndex(22)]
		HResult CreateNumberSubstitution(NumberSubstitutionMethod substitutionMethod, ushort* localeName, Bool32 ignoreUserOverride, IDWriteNumberSubstitution** numberSubstitution);

		[VtblIndex(23)]
		HResult CreateGlyphRunAnalysis(GlyphRun* glyphRun, float pixelsPerDip, Matrix3x2* transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis);
	}
}

