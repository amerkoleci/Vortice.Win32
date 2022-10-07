// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout"]/*' />
/// <unmanaged>IDWriteTextLayout</unmanaged>
[Guid("53737037-6d14-410b-9bfe-0b182bb70961")]
[NativeTypeName("struct IDWriteTextLayout : IDWriteTextFormat")]
[NativeInheritance("IDWriteTextFormat")]
public unsafe partial struct IDWriteTextLayout : INativeGuid
{
	public static ref readonly Guid IID_IDWriteTextLayout
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x37, 0x70, 0x73, 0x53,
				0x14, 0x6D,
				0x0B, 0x41,
				0x9B,
				0xFE,
				0x0B,
				0x18,
				0x2B,
				0xB7,
				0x09,
				0x61
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteTextLayout));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteTextLayout));
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

	/// <inheritdoc cref="IDWriteTextFormat.SetTextAlignment" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetTextAlignment(TextAlignment textAlignment)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, TextAlignment, int>)(lpVtbl[3]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), textAlignment);
	}

	/// <inheritdoc cref="IDWriteTextFormat.SetParagraphAlignment" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetParagraphAlignment(ParagraphAlignment paragraphAlignment)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, ParagraphAlignment, int>)(lpVtbl[4]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), paragraphAlignment);
	}

	/// <inheritdoc cref="IDWriteTextFormat.SetWordWrapping" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetWordWrapping(WordWrapping wordWrapping)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, WordWrapping, int>)(lpVtbl[5]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), wordWrapping);
	}

	/// <inheritdoc cref="IDWriteTextFormat.SetReadingDirection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetReadingDirection(ReadingDirection readingDirection)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, ReadingDirection, int>)(lpVtbl[6]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), readingDirection);
	}

	/// <inheritdoc cref="IDWriteTextFormat.SetFlowDirection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult SetFlowDirection(FlowDirection flowDirection)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, FlowDirection, int>)(lpVtbl[7]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), flowDirection);
	}

	/// <inheritdoc cref="IDWriteTextFormat.SetIncrementalTabStop" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult SetIncrementalTabStop(float incrementalTabStop)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float, int>)(lpVtbl[8]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), incrementalTabStop);
	}

	/// <inheritdoc cref="IDWriteTextFormat.SetTrimming" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult SetTrimming(Trimming* trimmingOptions, IDWriteInlineObject* trimmingSign)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, Trimming*, IDWriteInlineObject*, int>)(lpVtbl[9]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
	}

	/// <inheritdoc cref="IDWriteTextFormat.SetLineSpacing" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetLineSpacing(LineSpacingMethod lineSpacingMethod, float lineSpacing, float baseline)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, LineSpacingMethod, float, float, int>)(lpVtbl[10]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetTextAlignment" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public TextAlignment GetTextAlignment()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, TextAlignment>)(lpVtbl[11]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetParagraphAlignment" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public ParagraphAlignment GetParagraphAlignment()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, ParagraphAlignment>)(lpVtbl[12]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetWordWrapping" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public WordWrapping GetWordWrapping()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, WordWrapping>)(lpVtbl[13]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetReadingDirection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public ReadingDirection GetReadingDirection()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, ReadingDirection>)(lpVtbl[14]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetFlowDirection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public FlowDirection GetFlowDirection()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, FlowDirection>)(lpVtbl[15]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetIncrementalTabStop" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public float GetIncrementalTabStop()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float>)(lpVtbl[16]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetTrimming" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult GetTrimming(Trimming* trimmingOptions, IDWriteInlineObject** trimmingSign)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, Trimming*, IDWriteInlineObject**, int>)(lpVtbl[17]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetLineSpacing" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult GetLineSpacing(LineSpacingMethod* lineSpacingMethod, float* lineSpacing, float* baseline)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, LineSpacingMethod*, float*, float*, int>)(lpVtbl[18]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetFontCollection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult GetFontCollection(IDWriteFontCollection** fontCollection)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, IDWriteFontCollection**, int>)(lpVtbl[19]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), fontCollection);
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetFontFamilyNameLength" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public uint GetFontFamilyNameLength()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint>)(lpVtbl[20]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetFontFamilyName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult GetFontFamilyName(ushort* fontFamilyName, uint nameSize)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, ushort*, uint, int>)(lpVtbl[21]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), fontFamilyName, nameSize);
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetFontWeight" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public FontWeight GetFontWeight()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, FontWeight>)(lpVtbl[22]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetFontStyle" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public FontStyle GetFontStyle()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, FontStyle>)(lpVtbl[23]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetFontStretch" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public FontStretch GetFontStretch()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, FontStretch>)(lpVtbl[24]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetFontSize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public float GetFontSize()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float>)(lpVtbl[25]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetLocaleNameLength" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public uint GetLocaleNameLength()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint>)(lpVtbl[26]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetLocaleName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public HResult GetLocaleName(ushort* localeName, uint nameSize)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, ushort*, uint, int>)(lpVtbl[27]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), localeName, nameSize);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::SetMaxWidth"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public HResult SetMaxWidth(float maxWidth)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float, int>)(lpVtbl[28]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), maxWidth);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::SetMaxHeight"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(29)]
	public HResult SetMaxHeight(float maxHeight)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float, int>)(lpVtbl[29]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), maxHeight);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::SetFontCollection"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(30)]
	public HResult SetFontCollection(IDWriteFontCollection* fontCollection, TextRange* textRange)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, IDWriteFontCollection*, TextRange*, int>)(lpVtbl[30]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), fontCollection, textRange);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::SetFontFamilyName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(31)]
	public HResult SetFontFamilyName(ushort* fontFamilyName, TextRange* textRange)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, ushort*, TextRange*, int>)(lpVtbl[31]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), fontFamilyName, textRange);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::SetFontWeight"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(32)]
	public HResult SetFontWeight(FontWeight fontWeight, TextRange* textRange)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, FontWeight, TextRange*, int>)(lpVtbl[32]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), fontWeight, textRange);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::SetFontStyle"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(33)]
	public HResult SetFontStyle(FontStyle fontStyle, TextRange* textRange)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, FontStyle, TextRange*, int>)(lpVtbl[33]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), fontStyle, textRange);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::SetFontStretch"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(34)]
	public HResult SetFontStretch(FontStretch fontStretch, TextRange* textRange)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, FontStretch, TextRange*, int>)(lpVtbl[34]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), fontStretch, textRange);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::SetFontSize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(35)]
	public HResult SetFontSize(float fontSize, TextRange* textRange)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float, TextRange*, int>)(lpVtbl[35]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), fontSize, textRange);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::SetUnderline"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(36)]
	public HResult SetUnderline(Bool32 hasUnderline, TextRange* textRange)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, Bool32, TextRange*, int>)(lpVtbl[36]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), hasUnderline, textRange);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::SetStrikethrough"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(37)]
	public HResult SetStrikethrough(Bool32 hasStrikethrough, TextRange* textRange)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, Bool32, TextRange*, int>)(lpVtbl[37]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), hasStrikethrough, textRange);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::SetDrawingEffect"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(38)]
	public HResult SetDrawingEffect(IUnknown* drawingEffect, TextRange* textRange)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, IUnknown*, TextRange*, int>)(lpVtbl[38]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), drawingEffect, textRange);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::SetInlineObject"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(39)]
	public HResult SetInlineObject(IDWriteInlineObject* inlineObject, TextRange* textRange)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, IDWriteInlineObject*, TextRange*, int>)(lpVtbl[39]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), inlineObject, textRange);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::SetTypography"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(40)]
	public HResult SetTypography(IDWriteTypography* typography, TextRange* textRange)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, IDWriteTypography*, TextRange*, int>)(lpVtbl[40]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), typography, textRange);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::SetLocaleName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(41)]
	public HResult SetLocaleName(ushort* localeName, TextRange* textRange)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, ushort*, TextRange*, int>)(lpVtbl[41]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), localeName, textRange);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::GetMaxWidth"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(42)]
	public float GetMaxWidth()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float>)(lpVtbl[42]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::GetMaxHeight"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(43)]
	public float GetMaxHeight()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float>)(lpVtbl[43]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::GetFontCollection"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(44)]
	public HResult GetFontCollection(uint currentPosition, IDWriteFontCollection** fontCollection, TextRange* textRange)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, IDWriteFontCollection**, TextRange*, int>)(lpVtbl[44]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, fontCollection, textRange);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::GetFontFamilyNameLength"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(45)]
	public HResult GetFontFamilyNameLength(uint currentPosition, uint* nameLength, TextRange* textRange)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, uint*, TextRange*, int>)(lpVtbl[45]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, nameLength, textRange);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::GetFontFamilyName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(46)]
	public HResult GetFontFamilyName(uint currentPosition, ushort* fontFamilyName, uint nameSize, TextRange* textRange)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, ushort*, uint, TextRange*, int>)(lpVtbl[46]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, fontFamilyName, nameSize, textRange);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::GetFontWeight"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(47)]
	public HResult GetFontWeight(uint currentPosition, FontWeight* fontWeight, TextRange* textRange)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, FontWeight*, TextRange*, int>)(lpVtbl[47]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, fontWeight, textRange);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::GetFontStyle"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(48)]
	public HResult GetFontStyle(uint currentPosition, FontStyle* fontStyle, TextRange* textRange)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, FontStyle*, TextRange*, int>)(lpVtbl[48]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, fontStyle, textRange);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::GetFontStretch"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(49)]
	public HResult GetFontStretch(uint currentPosition, FontStretch* fontStretch, TextRange* textRange)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, FontStretch*, TextRange*, int>)(lpVtbl[49]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, fontStretch, textRange);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::GetFontSize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(50)]
	public HResult GetFontSize(uint currentPosition, float* fontSize, TextRange* textRange)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, float*, TextRange*, int>)(lpVtbl[50]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, fontSize, textRange);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::GetUnderline"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(51)]
	public HResult GetUnderline(uint currentPosition, Bool32* hasUnderline, TextRange* textRange)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, Bool32*, TextRange*, int>)(lpVtbl[51]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, hasUnderline, textRange);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::GetStrikethrough"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(52)]
	public HResult GetStrikethrough(uint currentPosition, Bool32* hasStrikethrough, TextRange* textRange)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, Bool32*, TextRange*, int>)(lpVtbl[52]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, hasStrikethrough, textRange);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::GetDrawingEffect"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(53)]
	public HResult GetDrawingEffect(uint currentPosition, IUnknown** drawingEffect, TextRange* textRange)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, IUnknown**, TextRange*, int>)(lpVtbl[53]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, drawingEffect, textRange);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::GetInlineObject"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(54)]
	public HResult GetInlineObject(uint currentPosition, IDWriteInlineObject** inlineObject, TextRange* textRange)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, IDWriteInlineObject**, TextRange*, int>)(lpVtbl[54]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, inlineObject, textRange);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::GetTypography"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(55)]
	public HResult GetTypography(uint currentPosition, IDWriteTypography** typography, TextRange* textRange)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, IDWriteTypography**, TextRange*, int>)(lpVtbl[55]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, typography, textRange);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::GetLocaleNameLength"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(56)]
	public HResult GetLocaleNameLength(uint currentPosition, uint* nameLength, TextRange* textRange)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, uint*, TextRange*, int>)(lpVtbl[56]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, nameLength, textRange);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::GetLocaleName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(57)]
	public HResult GetLocaleName(uint currentPosition, ushort* localeName, uint nameSize, TextRange* textRange)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, ushort*, uint, TextRange*, int>)(lpVtbl[57]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, localeName, nameSize, textRange);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::Draw"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(58)]
	public HResult Draw(void* clientDrawingContext, IDWriteTextRenderer* renderer, float originX, float originY)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, void*, IDWriteTextRenderer*, float, float, int>)(lpVtbl[58]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), clientDrawingContext, renderer, originX, originY);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::GetLineMetrics"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(59)]
	public HResult GetLineMetrics(LineMetrics* lineMetrics, uint maxLineCount, uint* actualLineCount)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, LineMetrics*, uint, uint*, int>)(lpVtbl[59]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), lineMetrics, maxLineCount, actualLineCount);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::GetMetrics"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(60)]
	public HResult GetMetrics(TextMetrics* textMetrics)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, TextMetrics*, int>)(lpVtbl[60]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), textMetrics);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::GetOverhangMetrics"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(61)]
	public HResult GetOverhangMetrics(OverhangMetrics* overhangs)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, OverhangMetrics*, int>)(lpVtbl[61]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), overhangs);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::GetClusterMetrics"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(62)]
	public HResult GetClusterMetrics(ClusterMetrics* clusterMetrics, uint maxClusterCount, uint* actualClusterCount)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, ClusterMetrics*, uint, uint*, int>)(lpVtbl[62]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), clusterMetrics, maxClusterCount, actualClusterCount);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::DetermineMinWidth"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(63)]
	public HResult DetermineMinWidth(float* minWidth)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float*, int>)(lpVtbl[63]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), minWidth);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::HitTestPoint"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(64)]
	public HResult HitTestPoint(float pointX, float pointY, Bool32* isTrailingHit, Bool32* isInside, HitTestMetrics* hitTestMetrics)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float, float, Bool32*, Bool32*, HitTestMetrics*, int>)(lpVtbl[64]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), pointX, pointY, isTrailingHit, isInside, hitTestMetrics);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::HitTestTextPosition"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(65)]
	public HResult HitTestTextPosition(uint textPosition, Bool32 isTrailingHit, float* pointX, float* pointY, HitTestMetrics* hitTestMetrics)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, Bool32, float*, float*, HitTestMetrics*, int>)(lpVtbl[65]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), textPosition, isTrailingHit, pointX, pointY, hitTestMetrics);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout::HitTestTextRange"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(66)]
	public HResult HitTestTextRange(uint textPosition, uint textLength, float originX, float originY, HitTestMetrics* hitTestMetrics, uint maxHitTestMetricsCount, uint* actualHitTestMetricsCount)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, uint, float, float, HitTestMetrics*, uint, uint*, int>)(lpVtbl[66]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), textPosition, textLength, originX, originY, hitTestMetrics, maxHitTestMetricsCount, actualHitTestMetricsCount);
	}
}
