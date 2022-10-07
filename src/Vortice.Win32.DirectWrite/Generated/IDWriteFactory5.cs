// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory5"]/*' />
/// <unmanaged>IDWriteFactory5</unmanaged>
[Guid("958db99a-be2a-4f09-af7d-65189803d1d3")]
[NativeTypeName("struct IDWriteFactory5 : IDWriteFactory4")]
[NativeInheritance("IDWriteFactory4")]
public unsafe partial struct IDWriteFactory5 : INativeGuid
{
	public static ref readonly Guid IID_IDWriteFactory5
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x9A, 0xB9, 0x8D, 0x95,
				0x2A, 0xBE,
				0x09, 0x4F,
				0xAF,
				0x7D,
				0x65,
				0x18,
				0x98,
				0x03,
				0xD1,
				0xD3
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFactory5));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFactory5));
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

	/// <inheritdoc cref="IDWriteFactory.GetSystemFontCollection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetSystemFontCollection(IDWriteFontCollection** fontCollection, Bool32 checkForUpdates)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, IDWriteFontCollection**, Bool32, int>)(lpVtbl[3]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontCollection, checkForUpdates);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateCustomFontCollection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult CreateCustomFontCollection(IDWriteFontCollectionLoader* collectionLoader, void* collectionKey, uint collectionKeySize, IDWriteFontCollection** fontCollection)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)(lpVtbl[4]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), collectionLoader, collectionKey, collectionKeySize, fontCollection);
	}

	/// <inheritdoc cref="IDWriteFactory.RegisterFontCollectionLoader" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult RegisterFontCollectionLoader(IDWriteFontCollectionLoader* fontCollectionLoader)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, IDWriteFontCollectionLoader*, int>)(lpVtbl[5]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontCollectionLoader);
	}

	/// <inheritdoc cref="IDWriteFactory.UnregisterFontCollectionLoader" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult UnregisterFontCollectionLoader(IDWriteFontCollectionLoader* fontCollectionLoader)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, IDWriteFontCollectionLoader*, int>)(lpVtbl[6]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontCollectionLoader);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateFontFileReference" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CreateFontFileReference(ushort* filePath, ulong* lastWriteTime, IDWriteFontFile** fontFile)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, ushort*, ulong*, IDWriteFontFile**, int>)(lpVtbl[7]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), filePath, lastWriteTime, fontFile);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateCustomFontFileReference" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateCustomFontFileReference(void* fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileLoader* fontFileLoader, IDWriteFontFile** fontFile)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)(lpVtbl[8]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, fontFileLoader, fontFile);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateFontFace" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult CreateFontFace(FontFaceType fontFaceType, uint numberOfFiles, IDWriteFontFile** fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, IDWriteFontFace** fontFace)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, FontFaceType, uint, IDWriteFontFile**, uint, FontSimulations, IDWriteFontFace**, int>)(lpVtbl[9]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontFaceType, numberOfFiles, fontFiles, faceIndex, fontFaceSimulationFlags, fontFace);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateRenderingParams" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult CreateRenderingParams(IDWriteRenderingParams** renderingParams)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, IDWriteRenderingParams**, int>)(lpVtbl[10]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), renderingParams);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateMonitorRenderingParams" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult CreateMonitorRenderingParams(IntPtr monitor, IDWriteRenderingParams** renderingParams)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, IntPtr, IDWriteRenderingParams**, int>)(lpVtbl[11]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), monitor, renderingParams);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateCustomRenderingParams" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult CreateCustomRenderingParams(float gamma, float enhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, IDWriteRenderingParams** renderingParams)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, float, float, float, PixelGeometry, RenderingMode, IDWriteRenderingParams**, int>)(lpVtbl[12]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, renderingParams);
	}

	/// <inheritdoc cref="IDWriteFactory.RegisterFontFileLoader" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult RegisterFontFileLoader(IDWriteFontFileLoader* fontFileLoader)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, IDWriteFontFileLoader*, int>)(lpVtbl[13]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontFileLoader);
	}

	/// <inheritdoc cref="IDWriteFactory.UnregisterFontFileLoader" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult UnregisterFontFileLoader(IDWriteFontFileLoader* fontFileLoader)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, IDWriteFontFileLoader*, int>)(lpVtbl[14]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontFileLoader);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateTextFormat" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult CreateTextFormat(ushort* fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, ushort* localeName, IDWriteTextFormat** textFormat)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, ushort*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, ushort*, IDWriteTextFormat**, int>)(lpVtbl[15]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateTypography" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult CreateTypography(IDWriteTypography** typography)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, IDWriteTypography**, int>)(lpVtbl[16]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), typography);
	}

	/// <inheritdoc cref="IDWriteFactory.GetGdiInterop" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult GetGdiInterop(IDWriteGdiInterop** gdiInterop)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, IDWriteGdiInterop**, int>)(lpVtbl[17]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), gdiInterop);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateTextLayout" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult CreateTextLayout(ushort* @string, uint stringLength, IDWriteTextFormat* textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, ushort*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)(lpVtbl[18]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, maxWidth, maxHeight, textLayout);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateGdiCompatibleTextLayout" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult CreateGdiCompatibleTextLayout(ushort* @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, Matrix3x2* transform, Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, ushort*, uint, IDWriteTextFormat*, float, float, float, Matrix3x2*, Bool32, IDWriteTextLayout**, int>)(lpVtbl[19]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateEllipsisTrimmingSign" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult CreateEllipsisTrimmingSign(IDWriteTextFormat* textFormat, IDWriteInlineObject** trimmingSign)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, IDWriteTextFormat*, IDWriteInlineObject**, int>)(lpVtbl[20]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), textFormat, trimmingSign);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateTextAnalyzer" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult CreateTextAnalyzer(IDWriteTextAnalyzer** textAnalyzer)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, IDWriteTextAnalyzer**, int>)(lpVtbl[21]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), textAnalyzer);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateNumberSubstitution" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult CreateNumberSubstitution(NumberSubstitutionMethod substitutionMethod, ushort* localeName, Bool32 ignoreUserOverride, IDWriteNumberSubstitution** numberSubstitution)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, NumberSubstitutionMethod, ushort*, Bool32, IDWriteNumberSubstitution**, int>)(lpVtbl[22]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), substitutionMethod, localeName, ignoreUserOverride, numberSubstitution);
	}

	/// <inheritdoc cref="IDWriteFactory.CreateGlyphRunAnalysis" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public HResult CreateGlyphRunAnalysis(GlyphRun* glyphRun, float pixelsPerDip, Matrix3x2* transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, GlyphRun*, float, Matrix3x2*, RenderingMode, MeasuringMode, float, float, IDWriteGlyphRunAnalysis**, int>)(lpVtbl[23]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), glyphRun, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
	}

	/// <inheritdoc cref="IDWriteFactory1.GetEudcFontCollection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult GetEudcFontCollection(IDWriteFontCollection** fontCollection, Bool32 checkForUpdates)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, IDWriteFontCollection**, Bool32, int>)(lpVtbl[24]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontCollection, checkForUpdates);
	}

	/// <inheritdoc cref="IDWriteFactory1.CreateCustomRenderingParams" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public HResult CreateCustomRenderingParams(float gamma, float enhancedContrast, float enhancedContrastGrayscale, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, IDWriteRenderingParams1** renderingParams)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, float, float, float, float, PixelGeometry, RenderingMode, IDWriteRenderingParams1**, int>)(lpVtbl[25]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, enhancedContrastGrayscale, clearTypeLevel, pixelGeometry, renderingMode, renderingParams);
	}

	/// <inheritdoc cref="IDWriteFactory2.GetSystemFontFallback" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public HResult GetSystemFontFallback(IDWriteFontFallback** fontFallback)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, IDWriteFontFallback**, int>)(lpVtbl[26]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontFallback);
	}

	/// <inheritdoc cref="IDWriteFactory2.CreateFontFallbackBuilder" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public HResult CreateFontFallbackBuilder(IDWriteFontFallbackBuilder** fontFallbackBuilder)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, IDWriteFontFallbackBuilder**, int>)(lpVtbl[27]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontFallbackBuilder);
	}

	/// <inheritdoc cref="IDWriteFactory2.TranslateColorGlyphRun" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public HResult TranslateColorGlyphRun(float baselineOriginX, float baselineOriginY, GlyphRun* glyphRun, GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, Matrix3x2* worldToDeviceTransform, uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator** colorLayers)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix3x2*, uint, IDWriteColorGlyphRunEnumerator**, int>)(lpVtbl[28]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), baselineOriginX, baselineOriginY, glyphRun, glyphRunDescription, measuringMode, worldToDeviceTransform, colorPaletteIndex, colorLayers);
	}

	/// <inheritdoc cref="IDWriteFactory2.CreateCustomRenderingParams" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(29)]
	public HResult CreateCustomRenderingParams(float gamma, float enhancedContrast, float grayscaleEnhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, GridFitMode gridFitMode, IDWriteRenderingParams2** renderingParams)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, float, float, float, float, PixelGeometry, RenderingMode, GridFitMode, IDWriteRenderingParams2**, int>)(lpVtbl[29]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, grayscaleEnhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, gridFitMode, renderingParams);
	}

	/// <inheritdoc cref="IDWriteFactory2.CreateGlyphRunAnalysis" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(30)]
	public HResult CreateGlyphRunAnalysis(GlyphRun* glyphRun, Matrix3x2* transform, RenderingMode renderingMode, MeasuringMode measuringMode, GridFitMode gridFitMode, TextAntialiasMode antialiasMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, GlyphRun*, Matrix3x2*, RenderingMode, MeasuringMode, GridFitMode, TextAntialiasMode, float, float, IDWriteGlyphRunAnalysis**, int>)(lpVtbl[30]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), glyphRun, transform, renderingMode, measuringMode, gridFitMode, antialiasMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
	}

	/// <inheritdoc cref="IDWriteFactory3.CreateGlyphRunAnalysis" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(31)]
	public HResult CreateGlyphRunAnalysis(GlyphRun* glyphRun, Matrix3x2* transform, RenderingMode1 renderingMode, MeasuringMode measuringMode, GridFitMode gridFitMode, TextAntialiasMode antialiasMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, GlyphRun*, Matrix3x2*, RenderingMode1, MeasuringMode, GridFitMode, TextAntialiasMode, float, float, IDWriteGlyphRunAnalysis**, int>)(lpVtbl[31]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), glyphRun, transform, renderingMode, measuringMode, gridFitMode, antialiasMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
	}

	/// <inheritdoc cref="IDWriteFactory3.CreateCustomRenderingParams" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(32)]
	public HResult CreateCustomRenderingParams(float gamma, float enhancedContrast, float grayscaleEnhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode1 renderingMode, GridFitMode gridFitMode, IDWriteRenderingParams3** renderingParams)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, float, float, float, float, PixelGeometry, RenderingMode1, GridFitMode, IDWriteRenderingParams3**, int>)(lpVtbl[32]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, grayscaleEnhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, gridFitMode, renderingParams);
	}

	/// <inheritdoc cref="IDWriteFactory3.CreateFontFaceReference" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(33)]
	public HResult CreateFontFaceReference(IDWriteFontFile* fontFile, uint faceIndex, FontSimulations fontSimulations, IDWriteFontFaceReference** fontFaceReference)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, IDWriteFontFile*, uint, FontSimulations, IDWriteFontFaceReference**, int>)(lpVtbl[33]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontFile, faceIndex, fontSimulations, fontFaceReference);
	}

	/// <inheritdoc cref="IDWriteFactory3.CreateFontFaceReference" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(34)]
	public HResult CreateFontFaceReference(ushort* filePath, ulong* lastWriteTime, uint faceIndex, FontSimulations fontSimulations, IDWriteFontFaceReference** fontFaceReference)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, ushort*, ulong*, uint, FontSimulations, IDWriteFontFaceReference**, int>)(lpVtbl[34]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), filePath, lastWriteTime, faceIndex, fontSimulations, fontFaceReference);
	}

	/// <inheritdoc cref="IDWriteFactory3.GetSystemFontSet" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(35)]
	public HResult GetSystemFontSet(IDWriteFontSet** fontSet)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, IDWriteFontSet**, int>)(lpVtbl[35]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontSet);
	}

	/// <inheritdoc cref="IDWriteFactory3.CreateFontSetBuilder" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(36)]
	public HResult CreateFontSetBuilder(IDWriteFontSetBuilder** fontSetBuilder)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, IDWriteFontSetBuilder**, int>)(lpVtbl[36]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontSetBuilder);
	}

	/// <inheritdoc cref="IDWriteFactory3.CreateFontCollectionFromFontSet" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(37)]
	public HResult CreateFontCollectionFromFontSet(IDWriteFontSet* fontSet, IDWriteFontCollection1** fontCollection)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, IDWriteFontSet*, IDWriteFontCollection1**, int>)(lpVtbl[37]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontSet, fontCollection);
	}

	/// <inheritdoc cref="IDWriteFactory3.GetSystemFontCollection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(38)]
	public HResult GetSystemFontCollection(Bool32 includeDownloadableFonts, IDWriteFontCollection1** fontCollection, Bool32 checkForUpdates)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, Bool32, IDWriteFontCollection1**, Bool32, int>)(lpVtbl[38]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), includeDownloadableFonts, fontCollection, checkForUpdates);
	}

	/// <inheritdoc cref="IDWriteFactory3.GetFontDownloadQueue" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(39)]
	public HResult GetFontDownloadQueue(IDWriteFontDownloadQueue** fontDownloadQueue)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, IDWriteFontDownloadQueue**, int>)(lpVtbl[39]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontDownloadQueue);
	}

	/// <inheritdoc cref="IDWriteFactory4.TranslateColorGlyphRun" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(40)]
	public HResult TranslateColorGlyphRun(System.Drawing.PointF baselineOrigin, GlyphRun* glyphRun, GlyphRunDescription* glyphRunDescription, GlyphImageFormats desiredGlyphImageFormats, MeasuringMode measuringMode, Matrix3x2* worldAndDpiTransform, uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator1** colorLayers)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, System.Drawing.PointF, GlyphRun*, GlyphRunDescription*, GlyphImageFormats, MeasuringMode, Matrix3x2*, uint, IDWriteColorGlyphRunEnumerator1**, int>)(lpVtbl[40]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), baselineOrigin, glyphRun, glyphRunDescription, desiredGlyphImageFormats, measuringMode, worldAndDpiTransform, colorPaletteIndex, colorLayers);
	}

	/// <inheritdoc cref="IDWriteFactory4.ComputeGlyphOrigins" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(41)]
	public HResult ComputeGlyphOrigins(GlyphRun* glyphRun, System.Drawing.PointF baselineOrigin, System.Drawing.PointF* glyphOrigins)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, GlyphRun*, System.Drawing.PointF, System.Drawing.PointF*, int>)(lpVtbl[41]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), glyphRun, baselineOrigin, glyphOrigins);
	}

	/// <inheritdoc cref="IDWriteFactory4.ComputeGlyphOrigins" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(42)]
	public HResult ComputeGlyphOrigins(GlyphRun* glyphRun, MeasuringMode measuringMode, System.Drawing.PointF baselineOrigin, Matrix3x2* worldAndDpiTransform, System.Drawing.PointF* glyphOrigins)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, GlyphRun*, MeasuringMode, System.Drawing.PointF, Matrix3x2*, System.Drawing.PointF*, int>)(lpVtbl[42]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), glyphRun, measuringMode, baselineOrigin, worldAndDpiTransform, glyphOrigins);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory5::CreateFontSetBuilder"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(43)]
	public HResult CreateFontSetBuilder(IDWriteFontSetBuilder1** fontSetBuilder)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, IDWriteFontSetBuilder1**, int>)(lpVtbl[43]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fontSetBuilder);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory5::CreateInMemoryFontFileLoader"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(44)]
	public HResult CreateInMemoryFontFileLoader(IDWriteInMemoryFontFileLoader** newLoader)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, IDWriteInMemoryFontFileLoader**, int>)(lpVtbl[44]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), newLoader);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory5::CreateHttpFontFileLoader"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(45)]
	public HResult CreateHttpFontFileLoader(ushort* referrerUrl, ushort* extraHeaders, IDWriteRemoteFontFileLoader** newLoader)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, ushort*, ushort*, IDWriteRemoteFontFileLoader**, int>)(lpVtbl[45]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), referrerUrl, extraHeaders, newLoader);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory5::AnalyzeContainerType"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(46)]
	public ContainerType AnalyzeContainerType(void* fileData, uint fileDataSize)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, void*, uint, ContainerType>)(lpVtbl[46]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), fileData, fileDataSize);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFactory5::UnpackFontFile"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(47)]
	public HResult UnpackFontFile(ContainerType containerType, void* fileData, uint fileDataSize, IDWriteFontFileStream** unpackedFontStream)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFactory5*, ContainerType, void*, uint, IDWriteFontFileStream**, int>)(lpVtbl[47]))((IDWriteFactory5*)Unsafe.AsPointer(ref this), containerType, fileData, fileDataSize, unpackedFontStream);
	}
}
