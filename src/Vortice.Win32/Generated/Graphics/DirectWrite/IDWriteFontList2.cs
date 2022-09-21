// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFontList2"]/*' />
/// <unmanaged>IDWriteFontList2</unmanaged>
[Guid("c0763a34-77af-445a-b735-08c37b0a5bf5")]
[NativeTypeName("struct IDWriteFontList2 : IDWriteFontList1")]
[NativeInheritance("IDWriteFontList1")]
public unsafe partial struct IDWriteFontList2
{
	public static ref readonly Guid IID_IDWriteFontList2
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x34, 0x3A, 0x76, 0xC0,
				0xAF, 0x77,
				0x5A, 0x44,
				0xB7,
				0x35,
				0x08,
				0xC3,
				0x7B,
				0x0A,
				0x5B,
				0xF5
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontList2));

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

	/// <inheritdoc cref="IDWriteFontList.GetFontCollection" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetFontCollection(IDWriteFontCollection** fontCollection)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontList2*, IDWriteFontCollection**, int>)(lpVtbl[3]))((IDWriteFontList2*)Unsafe.AsPointer(ref this), fontCollection);
	}

	/// <inheritdoc cref="IDWriteFontList.GetFontCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public uint GetFontCount()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontList2*, uint>)(lpVtbl[4]))((IDWriteFontList2*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFontList.GetFont" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetFont(uint index, IDWriteFont** font)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontList2*, uint, IDWriteFont**, int>)(lpVtbl[5]))((IDWriteFontList2*)Unsafe.AsPointer(ref this), index, font);
	}

	/// <inheritdoc cref="IDWriteFontList1.GetFontLocality" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public Locality GetFontLocality(uint listIndex)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontList2*, uint, Locality>)(lpVtbl[6]))((IDWriteFontList2*)Unsafe.AsPointer(ref this), listIndex);
	}

	/// <inheritdoc cref="IDWriteFontList1.GetFont" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetFont(uint listIndex, IDWriteFont3** font)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontList2*, uint, IDWriteFont3**, int>)(lpVtbl[7]))((IDWriteFontList2*)Unsafe.AsPointer(ref this), listIndex, font);
	}

	/// <inheritdoc cref="IDWriteFontList1.GetFontFaceReference" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetFontFaceReference(uint listIndex, IDWriteFontFaceReference** fontFaceReference)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontList2*, uint, IDWriteFontFaceReference**, int>)(lpVtbl[8]))((IDWriteFontList2*)Unsafe.AsPointer(ref this), listIndex, fontFaceReference);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFontList2::GetFontSet"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetFontSet(IDWriteFontSet1** fontSet)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontList2*, IDWriteFontSet1**, int>)(lpVtbl[9]))((IDWriteFontList2*)Unsafe.AsPointer(ref this), fontSet);
	}
}

