// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextAnalysisSource1"]/*' />
/// <unmanaged>IDWriteTextAnalysisSource1</unmanaged>
[Guid("639cfad8-0fb4-4b21-a58a-067920120009")]
[NativeTypeName("struct IDWriteTextAnalysisSource1 : IDWriteTextAnalysisSource")]
[NativeInheritance("IDWriteTextAnalysisSource")]
public unsafe partial struct IDWriteTextAnalysisSource1 : IDWriteTextAnalysisSource1.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDWriteTextAnalysisSource1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xD8, 0xFA, 0x9C, 0x63,
				0xB4, 0x0F,
				0x21, 0x4B,
				0xA5,
				0x8A,
				0x06,
				0x79,
				0x20,
				0x12,
				0x00,
				0x09
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteTextAnalysisSource1));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteTextAnalysisSource1));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint>)(lpVtbl[1]))((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint>)(lpVtbl[2]))((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextAnalysisSource.GetTextAtPosition" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetTextAtPosition(uint textPosition, ushort** textString, uint* textLength)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, ushort**, uint*, int>)(lpVtbl[3]))((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this), textPosition, textString, textLength);
	}

	/// <inheritdoc cref="IDWriteTextAnalysisSource.GetTextBeforePosition" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetTextBeforePosition(uint textPosition, ushort** textString, uint* textLength)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, ushort**, uint*, int>)(lpVtbl[4]))((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this), textPosition, textString, textLength);
	}

	/// <inheritdoc cref="IDWriteTextAnalysisSource.GetParagraphReadingDirection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public ReadingDirection GetParagraphReadingDirection()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, ReadingDirection>)(lpVtbl[5]))((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteTextAnalysisSource.GetLocaleName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetLocaleName(uint textPosition, uint* textLength, ushort** localeName)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, uint*, ushort**, int>)(lpVtbl[6]))((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this), textPosition, textLength, localeName);
	}

	/// <inheritdoc cref="IDWriteTextAnalysisSource.GetNumberSubstitution" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetNumberSubstitution(uint textPosition, uint* textLength, IDWriteNumberSubstitution** numberSubstitution)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, uint*, IDWriteNumberSubstitution**, int>)(lpVtbl[7]))((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this), textPosition, textLength, numberSubstitution);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteTextAnalysisSource1::GetVerticalGlyphOrientation"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetVerticalGlyphOrientation(uint textPosition, uint* textLength, VerticalGlyphOrientation* glyphOrientation, byte* bidiLevel)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, uint*, VerticalGlyphOrientation*, byte*, int>)(lpVtbl[8]))((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this), textPosition, textLength, glyphOrientation, bidiLevel);
	}
	public interface Interface : IDWriteTextAnalysisSource.Interface
	{
		[VtblIndex(8)]
		HResult GetVerticalGlyphOrientation(uint textPosition, uint* textLength, VerticalGlyphOrientation* glyphOrientation, byte* bidiLevel);
	}
}

