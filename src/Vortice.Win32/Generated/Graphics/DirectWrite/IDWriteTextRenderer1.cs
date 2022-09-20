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

/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteTextRenderer1"]/*' />
/// <unmanaged>IDWriteTextRenderer1</unmanaged>
[Guid("d3e0e934-22a0-427e-aae4-7d9574b59db1")]
[NativeTypeName("struct IDWriteTextRenderer1 : IDWriteTextRenderer")]
[NativeInheritance("IDWriteTextRenderer")]
public unsafe partial struct IDWriteTextRenderer1
{
	public static ref readonly Guid IID_IDWriteTextRenderer1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x34, 0xE9, 0xE0, 0xD3,
				0xA0, 0x22,
				0x7E, 0x42,
				0xAA,
				0xE4,
				0x7D,
				0x95,
				0x74,
				0xB5,
				0x9D,
				0xB1
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteTextRenderer1));

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

	/// <inheritdoc cref="IDWritePixelSnapping.IsPixelSnappingDisabled" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult IsPixelSnappingDisabled(void* clientDrawingContext, Bool32* isDisabled)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, Bool32*, int>)(lpVtbl[3]))((IDWriteTextRenderer1*)Unsafe.AsPointer(ref this), clientDrawingContext, isDisabled);
	}

	/// <inheritdoc cref="IDWritePixelSnapping.GetCurrentTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetCurrentTransform(void* clientDrawingContext, Matrix* transform)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, Matrix*, int>)(lpVtbl[4]))((IDWriteTextRenderer1*)Unsafe.AsPointer(ref this), clientDrawingContext, transform);
	}

	/// <inheritdoc cref="IDWritePixelSnapping.GetPixelsPerDip" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetPixelsPerDip(void* clientDrawingContext, float* pixelsPerDip)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float*, int>)(lpVtbl[5]))((IDWriteTextRenderer1*)Unsafe.AsPointer(ref this), clientDrawingContext, pixelsPerDip);
	}

	/// <inheritdoc cref="IDWriteTextRenderer.DrawGlyphRun" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult DrawGlyphRun(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, GlyphRun* glyphRun, GlyphRunDescription* glyphRunDescription, IUnknown* clientDrawingEffect)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, MeasuringMode, GlyphRun*, GlyphRunDescription*, IUnknown*, int>)(lpVtbl[6]))((IDWriteTextRenderer1*)Unsafe.AsPointer(ref this), clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, glyphRun, glyphRunDescription, clientDrawingEffect);
	}

	/// <inheritdoc cref="IDWriteTextRenderer.DrawUnderline" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult DrawUnderline(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, Underline* underline, IUnknown* clientDrawingEffect)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, Underline*, IUnknown*, int>)(lpVtbl[7]))((IDWriteTextRenderer1*)Unsafe.AsPointer(ref this), clientDrawingContext, baselineOriginX, baselineOriginY, underline, clientDrawingEffect);
	}

	/// <inheritdoc cref="IDWriteTextRenderer.DrawStrikethrough" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult DrawStrikethrough(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, Strikethrough* strikethrough, IUnknown* clientDrawingEffect)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, Strikethrough*, IUnknown*, int>)(lpVtbl[8]))((IDWriteTextRenderer1*)Unsafe.AsPointer(ref this), clientDrawingContext, baselineOriginX, baselineOriginY, strikethrough, clientDrawingEffect);
	}

	/// <inheritdoc cref="IDWriteTextRenderer.DrawInlineObject" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult DrawInlineObject(void* clientDrawingContext, float originX, float originY, IDWriteInlineObject* inlineObject, Bool32 isSideways, Bool32 isRightToLeft, IUnknown* clientDrawingEffect)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, IDWriteInlineObject*, Bool32, Bool32, IUnknown*, int>)(lpVtbl[9]))((IDWriteTextRenderer1*)Unsafe.AsPointer(ref this), clientDrawingContext, originX, originY, inlineObject, isSideways, isRightToLeft, clientDrawingEffect);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteTextRenderer1::DrawGlyphRun"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult DrawGlyphRun(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, GlyphOrientationAngle orientationAngle, MeasuringMode measuringMode, GlyphRun* glyphRun, GlyphRunDescription* glyphRunDescription, IUnknown* clientDrawingEffect)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, GlyphOrientationAngle, MeasuringMode, GlyphRun*, GlyphRunDescription*, IUnknown*, int>)(lpVtbl[10]))((IDWriteTextRenderer1*)Unsafe.AsPointer(ref this), clientDrawingContext, baselineOriginX, baselineOriginY, orientationAngle, measuringMode, glyphRun, glyphRunDescription, clientDrawingEffect);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteTextRenderer1::DrawUnderline"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult DrawUnderline(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, GlyphOrientationAngle orientationAngle, Underline* underline, IUnknown* clientDrawingEffect)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, GlyphOrientationAngle, Underline*, IUnknown*, int>)(lpVtbl[11]))((IDWriteTextRenderer1*)Unsafe.AsPointer(ref this), clientDrawingContext, baselineOriginX, baselineOriginY, orientationAngle, underline, clientDrawingEffect);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteTextRenderer1::DrawStrikethrough"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult DrawStrikethrough(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, GlyphOrientationAngle orientationAngle, Strikethrough* strikethrough, IUnknown* clientDrawingEffect)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, GlyphOrientationAngle, Strikethrough*, IUnknown*, int>)(lpVtbl[12]))((IDWriteTextRenderer1*)Unsafe.AsPointer(ref this), clientDrawingContext, baselineOriginX, baselineOriginY, orientationAngle, strikethrough, clientDrawingEffect);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteTextRenderer1::DrawInlineObject"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult DrawInlineObject(void* clientDrawingContext, float originX, float originY, GlyphOrientationAngle orientationAngle, IDWriteInlineObject* inlineObject, Bool32 isSideways, Bool32 isRightToLeft, IUnknown* clientDrawingEffect)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer1*, void*, float, float, GlyphOrientationAngle, IDWriteInlineObject*, Bool32, Bool32, IUnknown*, int>)(lpVtbl[13]))((IDWriteTextRenderer1*)Unsafe.AsPointer(ref this), clientDrawingContext, originX, originY, orientationAngle, inlineObject, isSideways, isRightToLeft, clientDrawingEffect);
	}
}

