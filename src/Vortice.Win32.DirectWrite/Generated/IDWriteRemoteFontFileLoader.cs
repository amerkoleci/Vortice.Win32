// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteRemoteFontFileLoader"]/*' />
/// <unmanaged>IDWriteRemoteFontFileLoader</unmanaged>
[Guid("68648c83-6ede-46c0-ab46-20083a887fde")]
[NativeTypeName("struct IDWriteRemoteFontFileLoader : IDWriteFontFileLoader")]
[NativeInheritance("IDWriteFontFileLoader")]
public unsafe partial struct IDWriteRemoteFontFileLoader : INativeGuid
{
	public static ref readonly Guid IID_IDWriteRemoteFontFileLoader
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x83, 0x8C, 0x64, 0x68,
				0xDE, 0x6E,
				0xC0, 0x46,
				0xAB,
				0x46,
				0x20,
				0x08,
				0x3A,
				0x88,
				0x7F,
				0xDE
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteRemoteFontFileLoader));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteRemoteFontFileLoader));
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

	/// <inheritdoc cref="IDWriteFontFileLoader.CreateStreamFromKey" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult CreateStreamFromKey(void* fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileStream** fontFileStream)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, void*, uint, IDWriteFontFileStream**, int>)(lpVtbl[3]))((IDWriteRemoteFontFileLoader*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteRemoteFontFileLoader::CreateRemoteStreamFromKey"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult CreateRemoteStreamFromKey(void* fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteRemoteFontFileStream** fontFileStream)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, void*, uint, IDWriteRemoteFontFileStream**, int>)(lpVtbl[4]))((IDWriteRemoteFontFileLoader*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteRemoteFontFileLoader::GetLocalityFromKey"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetLocalityFromKey(void* fontFileReferenceKey, uint fontFileReferenceKeySize, Locality* locality)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, void*, uint, Locality*, int>)(lpVtbl[5]))((IDWriteRemoteFontFileLoader*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, locality);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteRemoteFontFileLoader::CreateFontFileReferenceFromUrl"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult CreateFontFileReferenceFromUrl(IDWriteFactory* factory, ushort* baseUrl, ushort* fontFileUrl, IDWriteFontFile** fontFile)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, ushort*, ushort*, IDWriteFontFile**, int>)(lpVtbl[6]))((IDWriteRemoteFontFileLoader*)Unsafe.AsPointer(ref this), factory, baseUrl, fontFileUrl, fontFile);
	}
}
