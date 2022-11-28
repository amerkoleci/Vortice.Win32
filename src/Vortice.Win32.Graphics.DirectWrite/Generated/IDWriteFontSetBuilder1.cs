// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontSetBuilder1"]/*' />
/// <unmanaged>IDWriteFontSetBuilder1</unmanaged>
[Guid("3ff7715f-3cdc-4dc6-9b72-ec5621dccafd")]
[NativeTypeName("struct IDWriteFontSetBuilder1 : IDWriteFontSetBuilder")]
[NativeInheritance("IDWriteFontSetBuilder")]
public unsafe partial struct IDWriteFontSetBuilder1 : INativeGuid
{
	public static ref readonly Guid IID_IDWriteFontSetBuilder1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x5F, 0x71, 0xF7, 0x3F,
				0xDC, 0x3C,
				0xC6, 0x4D,
				0x9B,
				0x72,
				0xEC,
				0x56,
				0x21,
				0xDC,
				0xCA,
				0xFD
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontSetBuilder1));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontSetBuilder1));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder1*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontSetBuilder1*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder1*, uint>)(lpVtbl[1]))((IDWriteFontSetBuilder1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder1*, uint>)(lpVtbl[2]))((IDWriteFontSetBuilder1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFontSetBuilder.AddFontFaceReference" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult AddFontFaceReference(IDWriteFontFaceReference* fontFaceReference, FontProperty* properties, uint propertyCount)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder1*, IDWriteFontFaceReference*, FontProperty*, uint, int>)(lpVtbl[3]))((IDWriteFontSetBuilder1*)Unsafe.AsPointer(ref this), fontFaceReference, properties, propertyCount);
	}

	/// <inheritdoc cref="IDWriteFontSetBuilder.AddFontFaceReference" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult AddFontFaceReference(IDWriteFontFaceReference* fontFaceReference)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder1*, IDWriteFontFaceReference*, int>)(lpVtbl[4]))((IDWriteFontSetBuilder1*)Unsafe.AsPointer(ref this), fontFaceReference);
	}

	/// <inheritdoc cref="IDWriteFontSetBuilder.AddFontSet" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult AddFontSet(IDWriteFontSet* fontSet)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder1*, IDWriteFontSet*, int>)(lpVtbl[5]))((IDWriteFontSetBuilder1*)Unsafe.AsPointer(ref this), fontSet);
	}

	/// <inheritdoc cref="IDWriteFontSetBuilder.CreateFontSet" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult CreateFontSet(IDWriteFontSet** fontSet)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder1*, IDWriteFontSet**, int>)(lpVtbl[6]))((IDWriteFontSetBuilder1*)Unsafe.AsPointer(ref this), fontSet);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontSetBuilder1::AddFontFile"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult AddFontFile(IDWriteFontFile* fontFile)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder1*, IDWriteFontFile*, int>)(lpVtbl[7]))((IDWriteFontSetBuilder1*)Unsafe.AsPointer(ref this), fontFile);
	}
}

