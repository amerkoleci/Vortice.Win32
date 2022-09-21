// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFontFace"]/*' />
/// <unmanaged>IDWriteFontFace</unmanaged>
[Guid("5f49804d-7024-4d43-bfa9-d25984f53849")]
[NativeTypeName("struct IDWriteFontFace : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteFontFace
{
	public static ref readonly Guid IID_IDWriteFontFace
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x4D, 0x80, 0x49, 0x5F,
				0x24, 0x70,
				0x43, 0x4D,
				0xBF,
				0xA9,
				0xD2,
				0x59,
				0x84,
				0xF5,
				0x38,
				0x49
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontFace));

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

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFontFace::GetType"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public new FontFaceType GetType()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, FontFaceType>)(lpVtbl[3]))((IDWriteFontFace*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFontFace::GetFiles"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetFiles(uint* numberOfFiles, IDWriteFontFile** fontFiles)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, uint*, IDWriteFontFile**, int>)(lpVtbl[4]))((IDWriteFontFace*)Unsafe.AsPointer(ref this), numberOfFiles, fontFiles);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFontFace::GetIndex"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public uint GetIndex()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, uint>)(lpVtbl[5]))((IDWriteFontFace*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFontFace::GetSimulations"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public FontSimulations GetSimulations()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, FontSimulations>)(lpVtbl[6]))((IDWriteFontFace*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFontFace::IsSymbolFont"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public Bool32 IsSymbolFont()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, Bool32>)(lpVtbl[7]))((IDWriteFontFace*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFontFace::GetMetrics"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public void GetMetrics(FontMetrics* fontFaceMetrics)
	{
		((delegate* unmanaged[Stdcall]<IDWriteFontFace*, FontMetrics*, void>)(lpVtbl[8]))((IDWriteFontFace*)Unsafe.AsPointer(ref this), fontFaceMetrics);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFontFace::GetGlyphCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public ushort GetGlyphCount()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, ushort>)(lpVtbl[9]))((IDWriteFontFace*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFontFace::GetDesignGlyphMetrics"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult GetDesignGlyphMetrics(ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Bool32 isSideways)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, ushort*, uint, GlyphMetrics*, Bool32, int>)(lpVtbl[10]))((IDWriteFontFace*)Unsafe.AsPointer(ref this), glyphIndices, glyphCount, glyphMetrics, isSideways);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFontFace::GetGlyphIndices"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetGlyphIndices(uint* codePoints, uint codePointCount, ushort* glyphIndices)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, uint*, uint, ushort*, int>)(lpVtbl[11]))((IDWriteFontFace*)Unsafe.AsPointer(ref this), codePoints, codePointCount, glyphIndices);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFontFace::TryGetFontTable"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult TryGetFontTable(uint openTypeTableTag, void** tableData, uint* tableSize, void** tableContext, Bool32* exists)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, uint, void**, uint*, void**, Bool32*, int>)(lpVtbl[12]))((IDWriteFontFace*)Unsafe.AsPointer(ref this), openTypeTableTag, tableData, tableSize, tableContext, exists);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFontFace::ReleaseFontTable"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public void ReleaseFontTable(void* tableContext)
	{
		((delegate* unmanaged[Stdcall]<IDWriteFontFace*, void*, void>)(lpVtbl[13]))((IDWriteFontFace*)Unsafe.AsPointer(ref this), tableContext);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFontFace::GetGlyphRunOutline"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult GetGlyphRunOutline(float emSize, ushort* glyphIndices, float* glyphAdvances, GlyphOffset* glyphOffsets, uint glyphCount, Bool32 isSideways, Bool32 isRightToLeft, Graphics.Direct2D.Common.ID2D1SimplifiedGeometrySink* geometrySink)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, ushort*, float*, GlyphOffset*, uint, Bool32, Bool32, Graphics.Direct2D.Common.ID2D1SimplifiedGeometrySink*, int>)(lpVtbl[14]))((IDWriteFontFace*)Unsafe.AsPointer(ref this), emSize, glyphIndices, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFontFace::GetRecommendedRenderingMode"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult GetRecommendedRenderingMode(float emSize, float pixelsPerDip, MeasuringMode measuringMode, IDWriteRenderingParams* renderingParams, RenderingMode* renderingMode)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, float, MeasuringMode, IDWriteRenderingParams*, RenderingMode*, int>)(lpVtbl[15]))((IDWriteFontFace*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, measuringMode, renderingParams, renderingMode);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFontFace::GetGdiCompatibleMetrics"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult GetGdiCompatibleMetrics(float emSize, float pixelsPerDip, Matrix3x2* transform, FontMetrics* fontFaceMetrics)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, float, Matrix3x2*, FontMetrics*, int>)(lpVtbl[16]))((IDWriteFontFace*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, fontFaceMetrics);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFontFace::GetGdiCompatibleGlyphMetrics"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult GetGdiCompatibleGlyphMetrics(float emSize, float pixelsPerDip, Matrix3x2* transform, Bool32 useGdiNatural, ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Bool32 isSideways)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, float, Matrix3x2*, Bool32, ushort*, uint, GlyphMetrics*, Bool32, int>)(lpVtbl[17]))((IDWriteFontFace*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, useGdiNatural, glyphIndices, glyphCount, glyphMetrics, isSideways);
	}
}

