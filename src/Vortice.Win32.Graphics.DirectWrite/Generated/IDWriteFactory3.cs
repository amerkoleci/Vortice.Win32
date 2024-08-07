// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory3"]/*' />
/// <unmanaged>IDWriteFactory3</unmanaged>
[Guid("9a1b41c3-d3bb-466a-87fc-fe67556a3b65")]
[NativeTypeName("struct IDWriteFactory3 : IDWriteFactory2")]
[NativeInheritance("IDWriteFactory2")]
public unsafe partial struct IDWriteFactory3 : IDWriteFactory3.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDWriteFactory3
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xC3, 0x41, 0x1B, 0x9A,
				0xBB, 0xD3,
				0x6A, 0x46,
				0x87,
				0xFC,
				0xFE,
				0x67,
				0x55,
				0x6A,
				0x3B,
				0x65
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFactory3));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, uint>)(lpVtbl[1]))((IDWriteFactory3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, uint>)(lpVtbl[2]))((IDWriteFactory3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFactory.GetSystemFontCollection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetSystemFontCollection(IDWriteFontCollection** fontCollection, Bool32 checkForUpdates)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, IDWriteFontCollection**, Bool32, int>)(lpVtbl[3]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), fontCollection, checkForUpdates);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateCustomFontCollection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult CreateCustomFontCollection(IDWriteFontCollectionLoader* collectionLoader, void* collectionKey, uint collectionKeySize, IDWriteFontCollection** fontCollection)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)(lpVtbl[4]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), collectionLoader, collectionKey, collectionKeySize, fontCollection);
	}

	/// <inheritdoc cref="IDWriteFactory.RegisterFontCollectionLoader" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult RegisterFontCollectionLoader(IDWriteFontCollectionLoader* fontCollectionLoader)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, IDWriteFontCollectionLoader*, int>)(lpVtbl[5]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), fontCollectionLoader);
	}

	/// <inheritdoc cref="IDWriteFactory.UnregisterFontCollectionLoader" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult UnregisterFontCollectionLoader(IDWriteFontCollectionLoader* fontCollectionLoader)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, IDWriteFontCollectionLoader*, int>)(lpVtbl[6]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), fontCollectionLoader);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateFontFileReference" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CreateFontFileReference(char* filePath, ulong* lastWriteTime, IDWriteFontFile** fontFile)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, char*, ulong*, IDWriteFontFile**, int>)(lpVtbl[7]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), filePath, lastWriteTime, fontFile);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateCustomFontFileReference" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateCustomFontFileReference(void* fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileLoader* fontFileLoader, IDWriteFontFile** fontFile)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)(lpVtbl[8]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, fontFileLoader, fontFile);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateFontFace" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult CreateFontFace(FontFaceType fontFaceType, uint numberOfFiles, IDWriteFontFile** fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, IDWriteFontFace** fontFace)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, FontFaceType, uint, IDWriteFontFile**, uint, FontSimulations, IDWriteFontFace**, int>)(lpVtbl[9]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), fontFaceType, numberOfFiles, fontFiles, faceIndex, fontFaceSimulationFlags, fontFace);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateRenderingParams" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult CreateRenderingParams(IDWriteRenderingParams** renderingParams)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, IDWriteRenderingParams**, int>)(lpVtbl[10]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), renderingParams);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateMonitorRenderingParams" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult CreateMonitorRenderingParams(IntPtr monitor, IDWriteRenderingParams** renderingParams)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, IntPtr, IDWriteRenderingParams**, int>)(lpVtbl[11]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), monitor, renderingParams);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateCustomRenderingParams" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult CreateCustomRenderingParams(float gamma, float enhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, IDWriteRenderingParams** renderingParams)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, float, float, float, PixelGeometry, RenderingMode, IDWriteRenderingParams**, int>)(lpVtbl[12]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, renderingParams);
	}

	/// <inheritdoc cref="IDWriteFactory.RegisterFontFileLoader" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult RegisterFontFileLoader(IDWriteFontFileLoader* fontFileLoader)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, IDWriteFontFileLoader*, int>)(lpVtbl[13]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), fontFileLoader);
	}

	/// <inheritdoc cref="IDWriteFactory.UnregisterFontFileLoader" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult UnregisterFontFileLoader(IDWriteFontFileLoader* fontFileLoader)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, IDWriteFontFileLoader*, int>)(lpVtbl[14]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), fontFileLoader);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateTextFormat" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult CreateTextFormat(char* fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, char* localeName, IDWriteTextFormat** textFormat)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)(lpVtbl[15]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateTypography" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult CreateTypography(IDWriteTypography** typography)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, IDWriteTypography**, int>)(lpVtbl[16]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), typography);
	}

	/// <inheritdoc cref="IDWriteFactory.GetGdiInterop" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult GetGdiInterop(IDWriteGdiInterop** gdiInterop)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, IDWriteGdiInterop**, int>)(lpVtbl[17]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), gdiInterop);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateTextLayout" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult CreateTextLayout(char* @string, uint stringLength, IDWriteTextFormat* textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, char*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)(lpVtbl[18]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, maxWidth, maxHeight, textLayout);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateGdiCompatibleTextLayout" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult CreateGdiCompatibleTextLayout(char* @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, Matrix3x2* transform, Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix3x2*, Bool32, IDWriteTextLayout**, int>)(lpVtbl[19]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateEllipsisTrimmingSign" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult CreateEllipsisTrimmingSign(IDWriteTextFormat* textFormat, IDWriteInlineObject** trimmingSign)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, IDWriteTextFormat*, IDWriteInlineObject**, int>)(lpVtbl[20]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), textFormat, trimmingSign);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateTextAnalyzer" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult CreateTextAnalyzer(IDWriteTextAnalyzer** textAnalyzer)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, IDWriteTextAnalyzer**, int>)(lpVtbl[21]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), textAnalyzer);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateNumberSubstitution" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult CreateNumberSubstitution(NumberSubstitutionMethod substitutionMethod, char* localeName, Bool32 ignoreUserOverride, IDWriteNumberSubstitution** numberSubstitution)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, NumberSubstitutionMethod, char*, Bool32, IDWriteNumberSubstitution**, int>)(lpVtbl[22]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), substitutionMethod, localeName, ignoreUserOverride, numberSubstitution);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateGlyphRunAnalysis" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public HResult CreateGlyphRunAnalysis(GlyphRun* glyphRun, float pixelsPerDip, Matrix3x2* transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, GlyphRun*, float, Matrix3x2*, RenderingMode, MeasuringMode, float, float, IDWriteGlyphRunAnalysis**, int>)(lpVtbl[23]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), glyphRun, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
	}

	/// <inheritdoc cref="IDWriteFactory1.GetEudcFontCollection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult GetEudcFontCollection(IDWriteFontCollection** fontCollection, Bool32 checkForUpdates)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, IDWriteFontCollection**, Bool32, int>)(lpVtbl[24]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), fontCollection, checkForUpdates);
	}

	/// <inheritdoc cref="IDWriteFactory1.CreateCustomRenderingParams" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public HResult CreateCustomRenderingParams(float gamma, float enhancedContrast, float enhancedContrastGrayscale, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, IDWriteRenderingParams1** renderingParams)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, float, float, float, float, PixelGeometry, RenderingMode, IDWriteRenderingParams1**, int>)(lpVtbl[25]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, enhancedContrastGrayscale, clearTypeLevel, pixelGeometry, renderingMode, renderingParams);
	}

	/// <inheritdoc cref="IDWriteFactory2.GetSystemFontFallback" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public HResult GetSystemFontFallback(IDWriteFontFallback** fontFallback)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, IDWriteFontFallback**, int>)(lpVtbl[26]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), fontFallback);
	}

	/// <inheritdoc cref="IDWriteFactory2.CreateFontFallbackBuilder" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public HResult CreateFontFallbackBuilder(IDWriteFontFallbackBuilder** fontFallbackBuilder)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, IDWriteFontFallbackBuilder**, int>)(lpVtbl[27]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), fontFallbackBuilder);
	}

	/// <inheritdoc cref="IDWriteFactory2.TranslateColorGlyphRun" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public HResult TranslateColorGlyphRun(float baselineOriginX, float baselineOriginY, GlyphRun* glyphRun, GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, Matrix3x2* worldToDeviceTransform, uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator** colorLayers)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix3x2*, uint, IDWriteColorGlyphRunEnumerator**, int>)(lpVtbl[28]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), baselineOriginX, baselineOriginY, glyphRun, glyphRunDescription, measuringMode, worldToDeviceTransform, colorPaletteIndex, colorLayers);
	}

	/// <inheritdoc cref="IDWriteFactory2.CreateCustomRenderingParams" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(29)]
	public HResult CreateCustomRenderingParams(float gamma, float enhancedContrast, float grayscaleEnhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, GridFitMode gridFitMode, IDWriteRenderingParams2** renderingParams)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, float, float, float, float, PixelGeometry, RenderingMode, GridFitMode, IDWriteRenderingParams2**, int>)(lpVtbl[29]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, grayscaleEnhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, gridFitMode, renderingParams);
	}

	/// <inheritdoc cref="IDWriteFactory2.CreateGlyphRunAnalysis" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(30)]
	public HResult CreateGlyphRunAnalysis(GlyphRun* glyphRun, Matrix3x2* transform, RenderingMode renderingMode, MeasuringMode measuringMode, GridFitMode gridFitMode, TextAntialiasMode antialiasMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, GlyphRun*, Matrix3x2*, RenderingMode, MeasuringMode, GridFitMode, TextAntialiasMode, float, float, IDWriteGlyphRunAnalysis**, int>)(lpVtbl[30]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), glyphRun, transform, renderingMode, measuringMode, gridFitMode, antialiasMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory3::CreateGlyphRunAnalysis"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(31)]
	public HResult CreateGlyphRunAnalysis(GlyphRun* glyphRun, Matrix3x2* transform, RenderingMode1 renderingMode, MeasuringMode measuringMode, GridFitMode gridFitMode, TextAntialiasMode antialiasMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, GlyphRun*, Matrix3x2*, RenderingMode1, MeasuringMode, GridFitMode, TextAntialiasMode, float, float, IDWriteGlyphRunAnalysis**, int>)(lpVtbl[31]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), glyphRun, transform, renderingMode, measuringMode, gridFitMode, antialiasMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory3::CreateCustomRenderingParams"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(32)]
	public HResult CreateCustomRenderingParams(float gamma, float enhancedContrast, float grayscaleEnhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode1 renderingMode, GridFitMode gridFitMode, IDWriteRenderingParams3** renderingParams)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, float, float, float, float, PixelGeometry, RenderingMode1, GridFitMode, IDWriteRenderingParams3**, int>)(lpVtbl[32]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, grayscaleEnhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, gridFitMode, renderingParams);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory3::CreateFontFaceReference"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(33)]
	public HResult CreateFontFaceReference(IDWriteFontFile* fontFile, uint faceIndex, FontSimulations fontSimulations, IDWriteFontFaceReference** fontFaceReference)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, IDWriteFontFile*, uint, FontSimulations, IDWriteFontFaceReference**, int>)(lpVtbl[33]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), fontFile, faceIndex, fontSimulations, fontFaceReference);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory3::CreateFontFaceReference"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(34)]
	public HResult CreateFontFaceReference(char* filePath, ulong* lastWriteTime, uint faceIndex, FontSimulations fontSimulations, IDWriteFontFaceReference** fontFaceReference)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, char*, ulong*, uint, FontSimulations, IDWriteFontFaceReference**, int>)(lpVtbl[34]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), filePath, lastWriteTime, faceIndex, fontSimulations, fontFaceReference);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory3::GetSystemFontSet"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(35)]
	public HResult GetSystemFontSet(IDWriteFontSet** fontSet)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, IDWriteFontSet**, int>)(lpVtbl[35]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), fontSet);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory3::CreateFontSetBuilder"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(36)]
	public HResult CreateFontSetBuilder(IDWriteFontSetBuilder** fontSetBuilder)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, IDWriteFontSetBuilder**, int>)(lpVtbl[36]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), fontSetBuilder);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory3::CreateFontCollectionFromFontSet"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(37)]
	public HResult CreateFontCollectionFromFontSet(IDWriteFontSet* fontSet, IDWriteFontCollection1** fontCollection)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, IDWriteFontSet*, IDWriteFontCollection1**, int>)(lpVtbl[37]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), fontSet, fontCollection);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory3::GetSystemFontCollection"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(38)]
	public HResult GetSystemFontCollection(Bool32 includeDownloadableFonts, IDWriteFontCollection1** fontCollection, Bool32 checkForUpdates)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, Bool32, IDWriteFontCollection1**, Bool32, int>)(lpVtbl[38]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), includeDownloadableFonts, fontCollection, checkForUpdates);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory3::GetFontDownloadQueue"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(39)]
	public HResult GetFontDownloadQueue(IDWriteFontDownloadQueue** fontDownloadQueue)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFactory3*, IDWriteFontDownloadQueue**, int>)(lpVtbl[39]))((IDWriteFactory3*)Unsafe.AsPointer(ref this), fontDownloadQueue);
	}

	public interface Interface : IDWriteFactory2.Interface
	{
		[VtblIndex(31)]
		HResult CreateGlyphRunAnalysis(GlyphRun* glyphRun, Matrix3x2* transform, RenderingMode1 renderingMode, MeasuringMode measuringMode, GridFitMode gridFitMode, TextAntialiasMode antialiasMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis);

		[VtblIndex(32)]
		HResult CreateCustomRenderingParams(float gamma, float enhancedContrast, float grayscaleEnhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode1 renderingMode, GridFitMode gridFitMode, IDWriteRenderingParams3** renderingParams);

		[VtblIndex(33)]
		HResult CreateFontFaceReference(IDWriteFontFile* fontFile, uint faceIndex, FontSimulations fontSimulations, IDWriteFontFaceReference** fontFaceReference);

		[VtblIndex(34)]
		HResult CreateFontFaceReference(char* filePath, ulong* lastWriteTime, uint faceIndex, FontSimulations fontSimulations, IDWriteFontFaceReference** fontFaceReference);

		[VtblIndex(35)]
		HResult GetSystemFontSet(IDWriteFontSet** fontSet);

		[VtblIndex(36)]
		HResult CreateFontSetBuilder(IDWriteFontSetBuilder** fontSetBuilder);

		[VtblIndex(37)]
		HResult CreateFontCollectionFromFontSet(IDWriteFontSet* fontSet, IDWriteFontCollection1** fontCollection);

		[VtblIndex(38)]
		HResult GetSystemFontCollection(Bool32 includeDownloadableFonts, IDWriteFontCollection1** fontCollection, Bool32 checkForUpdates);

		[VtblIndex(39)]
		HResult GetFontDownloadQueue(IDWriteFontDownloadQueue** fontDownloadQueue);
	}
}

