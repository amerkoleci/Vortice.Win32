// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontCollection2"]/*' />
/// <unmanaged>IDWriteFontCollection2</unmanaged>
[Guid("514039c6-4617-4064-bf8b-92ea83e506e0")]
[NativeTypeName("struct IDWriteFontCollection2 : IDWriteFontCollection1")]
[NativeInheritance("IDWriteFontCollection1")]
public unsafe partial struct IDWriteFontCollection2 : IDWriteFontCollection2.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDWriteFontCollection2
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xC6, 0x39, 0x40, 0x51,
				0x17, 0x46,
				0x64, 0x40,
				0xBF,
				0x8B,
				0x92,
				0xEA,
				0x83,
				0xE5,
				0x06,
				0xE0
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontCollection2));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontCollection2));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontCollection2*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontCollection2*, uint>)(lpVtbl[1]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontCollection2*, uint>)(lpVtbl[2]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFontCollection.GetFontFamilyCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public uint GetFontFamilyCount()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontCollection2*, uint>)(lpVtbl[3]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFontCollection.GetFontFamily" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetFontFamily(uint index, IDWriteFontFamily** fontFamily)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontCollection2*, uint, IDWriteFontFamily**, int>)(lpVtbl[4]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), index, fontFamily);
	}

	/// <inheritdoc cref="IDWriteFontCollection.FindFamilyName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult FindFamilyName(ushort* familyName, uint* index, Bool32* exists)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontCollection2*, ushort*, uint*, Bool32*, int>)(lpVtbl[5]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), familyName, index, exists);
	}

	/// <inheritdoc cref="IDWriteFontCollection.GetFontFromFontFace" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetFontFromFontFace(IDWriteFontFace* fontFace, IDWriteFont** font)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontCollection2*, IDWriteFontFace*, IDWriteFont**, int>)(lpVtbl[6]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), fontFace, font);
	}

	/// <inheritdoc cref="IDWriteFontCollection1.GetFontSet" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetFontSet(IDWriteFontSet** fontSet)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontCollection2*, IDWriteFontSet**, int>)(lpVtbl[7]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), fontSet);
	}

	/// <inheritdoc cref="IDWriteFontCollection1.GetFontFamily" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetFontFamily(uint index, IDWriteFontFamily1** fontFamily)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontCollection2*, uint, IDWriteFontFamily1**, int>)(lpVtbl[8]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), index, fontFamily);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontCollection2::GetFontFamily"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetFontFamily(uint index, IDWriteFontFamily2** fontFamily)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontCollection2*, uint, IDWriteFontFamily2**, int>)(lpVtbl[9]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), index, fontFamily);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontCollection2::GetMatchingFonts"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult GetMatchingFonts(ushort* familyName, FontAxisValue* fontAxisValues, uint fontAxisValueCount, IDWriteFontList2** fontList)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontCollection2*, ushort*, FontAxisValue*, uint, IDWriteFontList2**, int>)(lpVtbl[10]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), familyName, fontAxisValues, fontAxisValueCount, fontList);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontCollection2::GetFontFamilyModel"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public FontFamilyModel GetFontFamilyModel()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontCollection2*, FontFamilyModel>)(lpVtbl[11]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontCollection2::GetFontSet"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult GetFontSet(IDWriteFontSet1** fontSet)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontCollection2*, IDWriteFontSet1**, int>)(lpVtbl[12]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), fontSet);
	}
	public interface Interface : IDWriteFontCollection1.Interface
	{
		[VtblIndex(9)]
		HResult GetFontFamily(uint index, IDWriteFontFamily2** fontFamily);

		[VtblIndex(10)]
		HResult GetMatchingFonts(ushort* familyName, FontAxisValue* fontAxisValues, uint fontAxisValueCount, IDWriteFontList2** fontList);

		[VtblIndex(11)]
		FontFamilyModel GetFontFamilyModel();

		[VtblIndex(12)]
		HResult GetFontSet(IDWriteFontSet1** fontSet);
	}
}

