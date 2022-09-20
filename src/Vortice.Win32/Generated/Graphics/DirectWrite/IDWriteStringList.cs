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

/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteStringList"]/*' />
/// <unmanaged>IDWriteStringList</unmanaged>
[Guid("cfee3140-1157-47ca-8b85-31bfcf3f2d0e")]
[NativeTypeName("struct IDWriteStringList : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteStringList
{
	public static ref readonly Guid IID_IDWriteStringList
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x40, 0x31, 0xEE, 0xCF,
				0x57, 0x11,
				0xCA, 0x47,
				0x8B,
				0x85,
				0x31,
				0xBF,
				0xCF,
				0x3F,
				0x2D,
				0x0E
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteStringList));

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

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteStringList::GetCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public uint GetCount()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteStringList*, uint>)(lpVtbl[3]))((IDWriteStringList*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteStringList::GetLocaleNameLength"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetLocaleNameLength(uint listIndex, uint* length)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteStringList*, uint, uint*, int>)(lpVtbl[4]))((IDWriteStringList*)Unsafe.AsPointer(ref this), listIndex, length);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteStringList::GetLocaleName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetLocaleName(uint listIndex, ushort* localeName, uint size)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteStringList*, uint, ushort*, uint, int>)(lpVtbl[5]))((IDWriteStringList*)Unsafe.AsPointer(ref this), listIndex, localeName, size);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteStringList::GetStringLength"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetStringLength(uint listIndex, uint* length)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteStringList*, uint, uint*, int>)(lpVtbl[6]))((IDWriteStringList*)Unsafe.AsPointer(ref this), listIndex, length);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteStringList::GetString"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetString(uint listIndex, ushort* stringBuffer, uint stringBufferSize)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteStringList*, uint, ushort*, uint, int>)(lpVtbl[7]))((IDWriteStringList*)Unsafe.AsPointer(ref this), listIndex, stringBuffer, stringBufferSize);
	}
}

