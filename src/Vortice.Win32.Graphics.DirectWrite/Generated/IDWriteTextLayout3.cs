// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout3"]/*' />
/// <unmanaged>IDWriteTextLayout3</unmanaged>
[Guid("07ddcd52-020e-4de8-ac33-6c953d83f92d")]
[NativeTypeName("struct IDWriteTextLayout3 : IDWriteTextLayout2")]
[NativeInheritance("IDWriteTextLayout2")]
public unsafe partial struct IDWriteTextLayout3 : IDWriteTextLayout3.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDWriteTextLayout3
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x52, 0xCD, 0xDD, 0x07,
				0x0E, 0x02,
				0xE8, 0x4D,
				0xAC,
				0x33,
				0x6C,
				0x95,
				0x3D,
				0x83,
				0xF9,
				0x2D
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteTextLayout3));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, uint>)(lpVtbl[1]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, uint>)(lpVtbl[2]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.SetTextAlignment" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetTextAlignment(TextAlignment textAlignment)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, TextAlignment, int>)(lpVtbl[3]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), textAlignment);
	}

	/// <inheritdoc cref="IDWriteTextFormat.SetParagraphAlignment" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetParagraphAlignment(ParagraphAlignment paragraphAlignment)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, ParagraphAlignment, int>)(lpVtbl[4]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), paragraphAlignment);
	}

	/// <inheritdoc cref="IDWriteTextFormat.SetWordWrapping" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetWordWrapping(WordWrapping wordWrapping)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, WordWrapping, int>)(lpVtbl[5]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), wordWrapping);
	}

	/// <inheritdoc cref="IDWriteTextFormat.SetReadingDirection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetReadingDirection(ReadingDirection readingDirection)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, ReadingDirection, int>)(lpVtbl[6]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), readingDirection);
	}

	/// <inheritdoc cref="IDWriteTextFormat.SetFlowDirection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult SetFlowDirection(FlowDirection flowDirection)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, FlowDirection, int>)(lpVtbl[7]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), flowDirection);
	}

	/// <inheritdoc cref="IDWriteTextFormat.SetIncrementalTabStop" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult SetIncrementalTabStop(float incrementalTabStop)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, float, int>)(lpVtbl[8]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), incrementalTabStop);
	}

	/// <inheritdoc cref="IDWriteTextFormat.SetTrimming" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult SetTrimming(Trimming* trimmingOptions, IDWriteInlineObject* trimmingSign)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, Trimming*, IDWriteInlineObject*, int>)(lpVtbl[9]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
	}

	/// <inheritdoc cref="IDWriteTextFormat.SetLineSpacing" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetLineSpacing(LineSpacingMethod lineSpacingMethod, float lineSpacing, float baseline)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, LineSpacingMethod, float, float, int>)(lpVtbl[10]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetTextAlignment" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public TextAlignment GetTextAlignment()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, TextAlignment>)(lpVtbl[11]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetParagraphAlignment" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public ParagraphAlignment GetParagraphAlignment()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, ParagraphAlignment>)(lpVtbl[12]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetWordWrapping" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public WordWrapping GetWordWrapping()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, WordWrapping>)(lpVtbl[13]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetReadingDirection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public ReadingDirection GetReadingDirection()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, ReadingDirection>)(lpVtbl[14]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetFlowDirection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public FlowDirection GetFlowDirection()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, FlowDirection>)(lpVtbl[15]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetIncrementalTabStop" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public float GetIncrementalTabStop()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, float>)(lpVtbl[16]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetTrimming" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult GetTrimming(Trimming* trimmingOptions, IDWriteInlineObject** trimmingSign)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, Trimming*, IDWriteInlineObject**, int>)(lpVtbl[17]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetLineSpacing" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult GetLineSpacing(LineSpacingMethod* lineSpacingMethod, float* lineSpacing, float* baseline)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, LineSpacingMethod*, float*, float*, int>)(lpVtbl[18]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetFontCollection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult GetFontCollection(IDWriteFontCollection** fontCollection)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, IDWriteFontCollection**, int>)(lpVtbl[19]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), fontCollection);
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetFontFamilyNameLength" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public uint GetFontFamilyNameLength()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, uint>)(lpVtbl[20]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetFontFamilyName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult GetFontFamilyName(char** fontFamilyName, uint nameSize)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, char**, uint, int>)(lpVtbl[21]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), fontFamilyName, nameSize);
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetFontWeight" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public FontWeight GetFontWeight()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, FontWeight>)(lpVtbl[22]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetFontStyle" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public FontStyle GetFontStyle()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, FontStyle>)(lpVtbl[23]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetFontStretch" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public FontStretch GetFontStretch()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, FontStretch>)(lpVtbl[24]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetFontSize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public float GetFontSize()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, float>)(lpVtbl[25]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetLocaleNameLength" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public uint GetLocaleNameLength()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, uint>)(lpVtbl[26]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextFormat.GetLocaleName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public HResult GetLocaleName(char** localeName, uint nameSize)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, char**, uint, int>)(lpVtbl[27]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), localeName, nameSize);
	}

	/// <inheritdoc cref="IDWriteTextLayout.SetMaxWidth" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public HResult SetMaxWidth(float maxWidth)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, float, int>)(lpVtbl[28]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), maxWidth);
	}

	/// <inheritdoc cref="IDWriteTextLayout.SetMaxHeight" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(29)]
	public HResult SetMaxHeight(float maxHeight)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, float, int>)(lpVtbl[29]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), maxHeight);
	}

	/// <inheritdoc cref="IDWriteTextLayout.SetFontCollection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(30)]
	public HResult SetFontCollection(IDWriteFontCollection* fontCollection, TextRange textRange)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, IDWriteFontCollection*, TextRange, int>)(lpVtbl[30]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), fontCollection, textRange);
	}

	/// <inheritdoc cref="IDWriteTextLayout.SetFontFamilyName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(31)]
	public HResult SetFontFamilyName(ushort* fontFamilyName, TextRange textRange)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, ushort*, TextRange, int>)(lpVtbl[31]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), fontFamilyName, textRange);
	}

	/// <inheritdoc cref="IDWriteTextLayout.SetFontWeight" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(32)]
	public HResult SetFontWeight(FontWeight fontWeight, TextRange textRange)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, FontWeight, TextRange, int>)(lpVtbl[32]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), fontWeight, textRange);
	}

	/// <inheritdoc cref="IDWriteTextLayout.SetFontStyle" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(33)]
	public HResult SetFontStyle(FontStyle fontStyle, TextRange textRange)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, FontStyle, TextRange, int>)(lpVtbl[33]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), fontStyle, textRange);
	}

	/// <inheritdoc cref="IDWriteTextLayout.SetFontStretch" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(34)]
	public HResult SetFontStretch(FontStretch fontStretch, TextRange textRange)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, FontStretch, TextRange, int>)(lpVtbl[34]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), fontStretch, textRange);
	}

	/// <inheritdoc cref="IDWriteTextLayout.SetFontSize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(35)]
	public HResult SetFontSize(float fontSize, TextRange textRange)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, float, TextRange, int>)(lpVtbl[35]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), fontSize, textRange);
	}

	/// <inheritdoc cref="IDWriteTextLayout.SetUnderline" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(36)]
	public HResult SetUnderline(Bool32 hasUnderline, TextRange textRange)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, Bool32, TextRange, int>)(lpVtbl[36]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), hasUnderline, textRange);
	}

	/// <inheritdoc cref="IDWriteTextLayout.SetStrikethrough" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(37)]
	public HResult SetStrikethrough(Bool32 hasStrikethrough, TextRange textRange)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, Bool32, TextRange, int>)(lpVtbl[37]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), hasStrikethrough, textRange);
	}

	/// <inheritdoc cref="IDWriteTextLayout.SetDrawingEffect" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(38)]
	public HResult SetDrawingEffect(IUnknown* drawingEffect, TextRange textRange)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, IUnknown*, TextRange, int>)(lpVtbl[38]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), drawingEffect, textRange);
	}

	/// <inheritdoc cref="IDWriteTextLayout.SetInlineObject" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(39)]
	public HResult SetInlineObject(IDWriteInlineObject* inlineObject, TextRange textRange)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, IDWriteInlineObject*, TextRange, int>)(lpVtbl[39]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), inlineObject, textRange);
	}

	/// <inheritdoc cref="IDWriteTextLayout.SetTypography" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(40)]
	public HResult SetTypography(IDWriteTypography* typography, TextRange textRange)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, IDWriteTypography*, TextRange, int>)(lpVtbl[40]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), typography, textRange);
	}

	/// <inheritdoc cref="IDWriteTextLayout.SetLocaleName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(41)]
	public HResult SetLocaleName(ushort* localeName, TextRange textRange)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, ushort*, TextRange, int>)(lpVtbl[41]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), localeName, textRange);
	}

	/// <inheritdoc cref="IDWriteTextLayout.GetMaxWidth" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(42)]
	public float GetMaxWidth()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, float>)(lpVtbl[42]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextLayout.GetMaxHeight" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(43)]
	public float GetMaxHeight()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, float>)(lpVtbl[43]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextLayout.GetFontCollection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(44)]
	public HResult GetFontCollection(uint currentPosition, IDWriteFontCollection** fontCollection, TextRange* textRange)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, uint, IDWriteFontCollection**, TextRange*, int>)(lpVtbl[44]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, fontCollection, textRange);
	}

	/// <inheritdoc cref="IDWriteTextLayout.GetFontFamilyNameLength" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(45)]
	public HResult GetFontFamilyNameLength(uint currentPosition, uint* nameLength, TextRange* textRange)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, uint, uint*, TextRange*, int>)(lpVtbl[45]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, nameLength, textRange);
	}

	/// <inheritdoc cref="IDWriteTextLayout.GetFontFamilyName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(46)]
	public HResult GetFontFamilyName(uint currentPosition, char** fontFamilyName, uint nameSize, TextRange* textRange)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, uint, char**, uint, TextRange*, int>)(lpVtbl[46]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, fontFamilyName, nameSize, textRange);
	}

	/// <inheritdoc cref="IDWriteTextLayout.GetFontWeight" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(47)]
	public HResult GetFontWeight(uint currentPosition, FontWeight* fontWeight, TextRange* textRange)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, uint, FontWeight*, TextRange*, int>)(lpVtbl[47]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, fontWeight, textRange);
	}

	/// <inheritdoc cref="IDWriteTextLayout.GetFontStyle" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(48)]
	public HResult GetFontStyle(uint currentPosition, FontStyle* fontStyle, TextRange* textRange)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, uint, FontStyle*, TextRange*, int>)(lpVtbl[48]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, fontStyle, textRange);
	}

	/// <inheritdoc cref="IDWriteTextLayout.GetFontStretch" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(49)]
	public HResult GetFontStretch(uint currentPosition, FontStretch* fontStretch, TextRange* textRange)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, uint, FontStretch*, TextRange*, int>)(lpVtbl[49]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, fontStretch, textRange);
	}

	/// <inheritdoc cref="IDWriteTextLayout.GetFontSize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(50)]
	public HResult GetFontSize(uint currentPosition, float* fontSize, TextRange* textRange)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, uint, float*, TextRange*, int>)(lpVtbl[50]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, fontSize, textRange);
	}

	/// <inheritdoc cref="IDWriteTextLayout.GetUnderline" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(51)]
	public HResult GetUnderline(uint currentPosition, Bool32* hasUnderline, TextRange* textRange)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, uint, Bool32*, TextRange*, int>)(lpVtbl[51]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, hasUnderline, textRange);
	}

	/// <inheritdoc cref="IDWriteTextLayout.GetStrikethrough" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(52)]
	public HResult GetStrikethrough(uint currentPosition, Bool32* hasStrikethrough, TextRange* textRange)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, uint, Bool32*, TextRange*, int>)(lpVtbl[52]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, hasStrikethrough, textRange);
	}

	/// <inheritdoc cref="IDWriteTextLayout.GetDrawingEffect" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(53)]
	public HResult GetDrawingEffect(uint currentPosition, IUnknown** drawingEffect, TextRange* textRange)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, uint, IUnknown**, TextRange*, int>)(lpVtbl[53]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, drawingEffect, textRange);
	}

	/// <inheritdoc cref="IDWriteTextLayout.GetInlineObject" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(54)]
	public HResult GetInlineObject(uint currentPosition, IDWriteInlineObject** inlineObject, TextRange* textRange)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, uint, IDWriteInlineObject**, TextRange*, int>)(lpVtbl[54]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, inlineObject, textRange);
	}

	/// <inheritdoc cref="IDWriteTextLayout.GetTypography" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(55)]
	public HResult GetTypography(uint currentPosition, IDWriteTypography** typography, TextRange* textRange)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, uint, IDWriteTypography**, TextRange*, int>)(lpVtbl[55]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, typography, textRange);
	}

	/// <inheritdoc cref="IDWriteTextLayout.GetLocaleNameLength" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(56)]
	public HResult GetLocaleNameLength(uint currentPosition, uint* nameLength, TextRange* textRange)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, uint, uint*, TextRange*, int>)(lpVtbl[56]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, nameLength, textRange);
	}

	/// <inheritdoc cref="IDWriteTextLayout.GetLocaleName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(57)]
	public HResult GetLocaleName(uint currentPosition, char** localeName, uint nameSize, TextRange* textRange)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, uint, char**, uint, TextRange*, int>)(lpVtbl[57]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, localeName, nameSize, textRange);
	}

	/// <inheritdoc cref="IDWriteTextLayout.Draw" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(58)]
	public HResult Draw(void* clientDrawingContext, IDWriteTextRenderer* renderer, float originX, float originY)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, void*, IDWriteTextRenderer*, float, float, int>)(lpVtbl[58]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), clientDrawingContext, renderer, originX, originY);
	}

	/// <inheritdoc cref="IDWriteTextLayout.GetLineMetrics" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(59)]
	public HResult GetLineMetrics(LineMetrics* lineMetrics, uint maxLineCount, uint* actualLineCount)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, LineMetrics*, uint, uint*, int>)(lpVtbl[59]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), lineMetrics, maxLineCount, actualLineCount);
	}

	/// <inheritdoc cref="IDWriteTextLayout.GetMetrics" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(60)]
	public HResult GetMetrics(TextMetrics* textMetrics)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, TextMetrics*, int>)(lpVtbl[60]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), textMetrics);
	}

	/// <inheritdoc cref="IDWriteTextLayout.GetOverhangMetrics" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(61)]
	public HResult GetOverhangMetrics(OverhangMetrics* overhangs)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, OverhangMetrics*, int>)(lpVtbl[61]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), overhangs);
	}

	/// <inheritdoc cref="IDWriteTextLayout.GetClusterMetrics" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(62)]
	public HResult GetClusterMetrics(ClusterMetrics* clusterMetrics, uint maxClusterCount, uint* actualClusterCount)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, ClusterMetrics*, uint, uint*, int>)(lpVtbl[62]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), clusterMetrics, maxClusterCount, actualClusterCount);
	}

	/// <inheritdoc cref="IDWriteTextLayout.DetermineMinWidth" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(63)]
	public HResult DetermineMinWidth(float* minWidth)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, float*, int>)(lpVtbl[63]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), minWidth);
	}

	/// <inheritdoc cref="IDWriteTextLayout.HitTestPoint" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(64)]
	public HResult HitTestPoint(float pointX, float pointY, Bool32* isTrailingHit, Bool32* isInside, HitTestMetrics* hitTestMetrics)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, float, float, Bool32*, Bool32*, HitTestMetrics*, int>)(lpVtbl[64]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), pointX, pointY, isTrailingHit, isInside, hitTestMetrics);
	}

	/// <inheritdoc cref="IDWriteTextLayout.HitTestTextPosition" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(65)]
	public HResult HitTestTextPosition(uint textPosition, Bool32 isTrailingHit, float* pointX, float* pointY, HitTestMetrics* hitTestMetrics)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, uint, Bool32, float*, float*, HitTestMetrics*, int>)(lpVtbl[65]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), textPosition, isTrailingHit, pointX, pointY, hitTestMetrics);
	}

	/// <inheritdoc cref="IDWriteTextLayout.HitTestTextRange" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(66)]
	public HResult HitTestTextRange(uint textPosition, uint textLength, float originX, float originY, HitTestMetrics* hitTestMetrics, uint maxHitTestMetricsCount, uint* actualHitTestMetricsCount)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, uint, uint, float, float, HitTestMetrics*, uint, uint*, int>)(lpVtbl[66]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), textPosition, textLength, originX, originY, hitTestMetrics, maxHitTestMetricsCount, actualHitTestMetricsCount);
	}

	/// <inheritdoc cref="IDWriteTextLayout1.SetPairKerning" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(67)]
	public HResult SetPairKerning(Bool32 isPairKerningEnabled, TextRange textRange)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, Bool32, TextRange, int>)(lpVtbl[67]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), isPairKerningEnabled, textRange);
	}

	/// <inheritdoc cref="IDWriteTextLayout1.GetPairKerning" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(68)]
	public HResult GetPairKerning(uint currentPosition, Bool32* isPairKerningEnabled, TextRange* textRange)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, uint, Bool32*, TextRange*, int>)(lpVtbl[68]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, isPairKerningEnabled, textRange);
	}

	/// <inheritdoc cref="IDWriteTextLayout1.SetCharacterSpacing" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(69)]
	public HResult SetCharacterSpacing(float leadingSpacing, float trailingSpacing, float minimumAdvanceWidth, TextRange textRange)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, float, float, float, TextRange, int>)(lpVtbl[69]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), leadingSpacing, trailingSpacing, minimumAdvanceWidth, textRange);
	}

	/// <inheritdoc cref="IDWriteTextLayout1.GetCharacterSpacing" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(70)]
	public HResult GetCharacterSpacing(uint currentPosition, float* leadingSpacing, float* trailingSpacing, float* minimumAdvanceWidth, TextRange* textRange)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, uint, float*, float*, float*, TextRange*, int>)(lpVtbl[70]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, leadingSpacing, trailingSpacing, minimumAdvanceWidth, textRange);
	}

	/// <inheritdoc cref="IDWriteTextLayout2.GetMetrics" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(71)]
	public HResult GetMetrics(TextMetrics1* textMetrics)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, TextMetrics1*, int>)(lpVtbl[71]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), textMetrics);
	}

	/// <inheritdoc cref="IDWriteTextLayout2.SetVerticalGlyphOrientation" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(72)]
	public HResult SetVerticalGlyphOrientation(VerticalGlyphOrientation glyphOrientation)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, VerticalGlyphOrientation, int>)(lpVtbl[72]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), glyphOrientation);
	}

	/// <inheritdoc cref="IDWriteTextLayout2.GetVerticalGlyphOrientation" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(73)]
	public VerticalGlyphOrientation GetVerticalGlyphOrientation()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, VerticalGlyphOrientation>)(lpVtbl[73]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextLayout2.SetLastLineWrapping" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(74)]
	public HResult SetLastLineWrapping(Bool32 isLastLineWrappingEnabled)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, Bool32, int>)(lpVtbl[74]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), isLastLineWrappingEnabled);
	}

	/// <inheritdoc cref="IDWriteTextLayout2.GetLastLineWrapping" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(75)]
	public Bool32 GetLastLineWrapping()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, Bool32>)(lpVtbl[75]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextLayout2.SetOpticalAlignment" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(76)]
	public HResult SetOpticalAlignment(OpticalAlignment opticalAlignment)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, OpticalAlignment, int>)(lpVtbl[76]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), opticalAlignment);
	}

	/// <inheritdoc cref="IDWriteTextLayout2.GetOpticalAlignment" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(77)]
	public OpticalAlignment GetOpticalAlignment()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, OpticalAlignment>)(lpVtbl[77]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextLayout2.SetFontFallback" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(78)]
	public HResult SetFontFallback(IDWriteFontFallback* fontFallback)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, IDWriteFontFallback*, int>)(lpVtbl[78]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), fontFallback);
	}

	/// <inheritdoc cref="IDWriteTextLayout2.GetFontFallback" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(79)]
	public HResult GetFontFallback(IDWriteFontFallback** fontFallback)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, IDWriteFontFallback**, int>)(lpVtbl[79]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), fontFallback);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout3::InvalidateLayout"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(80)]
	public HResult InvalidateLayout()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, int>)(lpVtbl[80]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout3::SetLineSpacing"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(81)]
	public HResult SetLineSpacing(LineSpacing* lineSpacingOptions)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, LineSpacing*, int>)(lpVtbl[81]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), lineSpacingOptions);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout3::GetLineSpacing"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(82)]
	public HResult GetLineSpacing(LineSpacing* lineSpacingOptions)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, LineSpacing*, int>)(lpVtbl[82]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), lineSpacingOptions);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextLayout3::GetLineMetrics"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(83)]
	public HResult GetLineMetrics(LineMetrics1* lineMetrics, uint maxLineCount, uint* actualLineCount)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteTextLayout3*, LineMetrics1*, uint, uint*, int>)(lpVtbl[83]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), lineMetrics, maxLineCount, actualLineCount);
	}

	public interface Interface : IDWriteTextLayout2.Interface
	{
		[VtblIndex(80)]
		HResult InvalidateLayout();

		[VtblIndex(81)]
		HResult SetLineSpacing(LineSpacing* lineSpacingOptions);

		[VtblIndex(82)]
		HResult GetLineSpacing(LineSpacing* lineSpacingOptions);

		[VtblIndex(83)]
		HResult GetLineMetrics(LineMetrics1* lineMetrics, uint maxLineCount, uint* actualLineCount);
	}
}

