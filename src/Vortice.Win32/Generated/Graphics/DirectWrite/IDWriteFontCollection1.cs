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

/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFontCollection1"]/*' />
/// <unmanaged>IDWriteFontCollection1</unmanaged>
[Guid("53585141-d9f8-4095-8321-d73cf6bd116c")]
[NativeTypeName("struct IDWriteFontCollection1 : IDWriteFontCollection")]
[NativeInheritance("IDWriteFontCollection")]
public unsafe partial struct IDWriteFontCollection1
{
	public static ref readonly Guid IID_IDWriteFontCollection1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x41, 0x51, 0x58, 0x53,
				0xF8, 0xD9,
				0x95, 0x40,
				0x83,
				0x21,
				0xD7,
				0x3C,
				0xF6,
				0xBD,
				0x11,
				0x6C
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontCollection1));

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

	/// <inheritdoc cref="IDWriteFontCollection.GetFontFamilyCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public uint GetFontFamilyCount()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontCollection1*, uint>)(lpVtbl[3]))((IDWriteFontCollection1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteFontCollection.GetFontFamily" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetFontFamily(uint index, IDWriteFontFamily** fontFamily)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontCollection1*, uint, IDWriteFontFamily**, int>)(lpVtbl[4]))((IDWriteFontCollection1*)Unsafe.AsPointer(ref this), index, fontFamily);
	}

	/// <inheritdoc cref="IDWriteFontCollection.FindFamilyName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult FindFamilyName(ushort* familyName, uint* index, Bool32* exists)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontCollection1*, ushort*, uint*, Bool32*, int>)(lpVtbl[5]))((IDWriteFontCollection1*)Unsafe.AsPointer(ref this), familyName, index, exists);
	}

	/// <inheritdoc cref="IDWriteFontCollection.GetFontFromFontFace" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetFontFromFontFace(IDWriteFontFace* fontFace, IDWriteFont** font)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontCollection1*, IDWriteFontFace*, IDWriteFont**, int>)(lpVtbl[6]))((IDWriteFontCollection1*)Unsafe.AsPointer(ref this), fontFace, font);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFontCollection1::GetFontSet"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetFontSet(IDWriteFontSet** fontSet)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontCollection1*, IDWriteFontSet**, int>)(lpVtbl[7]))((IDWriteFontCollection1*)Unsafe.AsPointer(ref this), fontSet);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFontCollection1::GetFontFamily"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetFontFamily(uint index, IDWriteFontFamily1** fontFamily)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontCollection1*, uint, IDWriteFontFamily1**, int>)(lpVtbl[8]))((IDWriteFontCollection1*)Unsafe.AsPointer(ref this), index, fontFamily);
	}
}

