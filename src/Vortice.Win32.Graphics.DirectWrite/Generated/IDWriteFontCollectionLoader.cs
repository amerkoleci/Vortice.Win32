// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontCollectionLoader"]/*' />
/// <unmanaged>IDWriteFontCollectionLoader</unmanaged>
[Guid("cca920e4-52f0-492b-bfa8-29c72ee0a468")]
[NativeTypeName("struct IDWriteFontCollectionLoader : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteFontCollectionLoader : IDWriteFontCollectionLoader.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDWriteFontCollectionLoader
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xE4, 0x20, 0xA9, 0xCC,
				0xF0, 0x52,
				0x2B, 0x49,
				0xBF,
				0xA8,
				0x29,
				0xC7,
				0x2E,
				0xE0,
				0xA4,
				0x68
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontCollectionLoader));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFontCollectionLoader*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontCollectionLoader*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFontCollectionLoader*, uint>)(lpVtbl[1]))((IDWriteFontCollectionLoader*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFontCollectionLoader*, uint>)(lpVtbl[2]))((IDWriteFontCollectionLoader*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontCollectionLoader::CreateEnumeratorFromKey"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult CreateEnumeratorFromKey(IDWriteFactory* factory, void* collectionKey, uint collectionKeySize, IDWriteFontFileEnumerator** fontFileEnumerator)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFontCollectionLoader*, IDWriteFactory*, void*, uint, IDWriteFontFileEnumerator**, int>)(lpVtbl[3]))((IDWriteFontCollectionLoader*)Unsafe.AsPointer(ref this), factory, collectionKey, collectionKeySize, fontFileEnumerator);
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult CreateEnumeratorFromKey(IDWriteFactory* factory, void* collectionKey, uint collectionKeySize, IDWriteFontFileEnumerator** fontFileEnumerator);
	}
}

