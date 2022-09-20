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

namespace Win32.Graphics.Direct3D.Dxc;

/// <include file='../../Direct3D.xml' path='doc/member[@name="IDxcLibrary"]/*' />
/// <unmanaged>IDxcLibrary</unmanaged>
[Guid("e5204dc7-d18c-4c3c-bdfb-851673980fe7")]
[NativeTypeName("struct IDxcLibrary : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxcLibrary
{
	public static ref readonly Guid IID_IDxcLibrary
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xC7, 0x4D, 0x20, 0xE5,
				0x8C, 0xD1,
				0x3C, 0x4C,
				0xBD,
				0xFB,
				0x85,
				0x16,
				0x73,
				0x98,
				0x0F,
				0xE7
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcLibrary));

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

	/// <include file='../../Direct3D.xml' path='doc/member[@name="IDxcLibrary::SetMalloc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetMalloc(Com.IMalloc* pMalloc)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcLibrary*, Com.IMalloc*, int>)(lpVtbl[3]))((IDxcLibrary*)Unsafe.AsPointer(ref this), pMalloc);
	}

	/// <include file='../../Direct3D.xml' path='doc/member[@name="IDxcLibrary::CreateBlobFromBlob"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult CreateBlobFromBlob(IDxcBlob* pBlob, uint offset, uint length, IDxcBlob** ppResult)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, uint, uint, IDxcBlob**, int>)(lpVtbl[4]))((IDxcLibrary*)Unsafe.AsPointer(ref this), pBlob, offset, length, ppResult);
	}

	/// <include file='../../Direct3D.xml' path='doc/member[@name="IDxcLibrary::CreateBlobFromFile"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult CreateBlobFromFile(ushort* pFileName, DxcCp* codePage, IDxcBlobEncoding** pBlobEncoding)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcLibrary*, ushort*, DxcCp*, IDxcBlobEncoding**, int>)(lpVtbl[5]))((IDxcLibrary*)Unsafe.AsPointer(ref this), pFileName, codePage, pBlobEncoding);
	}

	/// <include file='../../Direct3D.xml' path='doc/member[@name="IDxcLibrary::CreateBlobWithEncodingFromPinned"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult CreateBlobWithEncodingFromPinned(void* pText, uint size, DxcCp codePage, IDxcBlobEncoding** pBlobEncoding)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, uint, DxcCp, IDxcBlobEncoding**, int>)(lpVtbl[6]))((IDxcLibrary*)Unsafe.AsPointer(ref this), pText, size, codePage, pBlobEncoding);
	}

	/// <include file='../../Direct3D.xml' path='doc/member[@name="IDxcLibrary::CreateBlobWithEncodingOnHeapCopy"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CreateBlobWithEncodingOnHeapCopy(void* pText, uint size, DxcCp codePage, IDxcBlobEncoding** pBlobEncoding)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, uint, DxcCp, IDxcBlobEncoding**, int>)(lpVtbl[7]))((IDxcLibrary*)Unsafe.AsPointer(ref this), pText, size, codePage, pBlobEncoding);
	}

	/// <include file='../../Direct3D.xml' path='doc/member[@name="IDxcLibrary::CreateBlobWithEncodingOnMalloc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateBlobWithEncodingOnMalloc(void* pText, Com.IMalloc* pIMalloc, uint size, DxcCp codePage, IDxcBlobEncoding** pBlobEncoding)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcLibrary*, void*, Com.IMalloc*, uint, DxcCp, IDxcBlobEncoding**, int>)(lpVtbl[8]))((IDxcLibrary*)Unsafe.AsPointer(ref this), pText, pIMalloc, size, codePage, pBlobEncoding);
	}

	/// <include file='../../Direct3D.xml' path='doc/member[@name="IDxcLibrary::CreateIncludeHandler"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult CreateIncludeHandler(IDxcIncludeHandler** ppResult)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcIncludeHandler**, int>)(lpVtbl[9]))((IDxcLibrary*)Unsafe.AsPointer(ref this), ppResult);
	}

	/// <include file='../../Direct3D.xml' path='doc/member[@name="IDxcLibrary::CreateStreamFromBlobReadOnly"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult CreateStreamFromBlobReadOnly(IDxcBlob* pBlob, Com.IStream** ppStream)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, Com.IStream**, int>)(lpVtbl[10]))((IDxcLibrary*)Unsafe.AsPointer(ref this), pBlob, ppStream);
	}

	/// <include file='../../Direct3D.xml' path='doc/member[@name="IDxcLibrary::GetBlobAsUtf8"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetBlobAsUtf8(IDxcBlob* pBlob, IDxcBlobEncoding** pBlobEncoding)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)(lpVtbl[11]))((IDxcLibrary*)Unsafe.AsPointer(ref this), pBlob, pBlobEncoding);
	}

	/// <include file='../../Direct3D.xml' path='doc/member[@name="IDxcLibrary::GetBlobAsUtf16"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult GetBlobAsUtf16(IDxcBlob* pBlob, IDxcBlobEncoding** pBlobEncoding)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcLibrary*, IDxcBlob*, IDxcBlobEncoding**, int>)(lpVtbl[12]))((IDxcLibrary*)Unsafe.AsPointer(ref this), pBlob, pBlobEncoding);
	}
}

