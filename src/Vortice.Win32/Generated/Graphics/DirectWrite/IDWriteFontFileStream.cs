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

/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFontFileStream"]/*' />
/// <unmanaged>IDWriteFontFileStream</unmanaged>
[Guid("6d4865fe-0ab8-4d91-8f62-5dd6be34a3e0")]
[NativeTypeName("struct IDWriteFontFileStream : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteFontFileStream
{
	public static ref readonly Guid IID_IDWriteFontFileStream
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xFE, 0x65, 0x48, 0x6D,
				0xB8, 0x0A,
				0x91, 0x4D,
				0x8F,
				0x62,
				0x5D,
				0xD6,
				0xBE,
				0x34,
				0xA3,
				0xE0
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontFileStream));

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

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFontFileStream::ReadFileFragment"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult ReadFileFragment(void** fragmentStart, ulong fileOffset, ulong fragmentSize, void** fragmentContext)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, void**, ulong, ulong, void**, int>)(lpVtbl[3]))((IDWriteFontFileStream*)Unsafe.AsPointer(ref this), fragmentStart, fileOffset, fragmentSize, fragmentContext);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFontFileStream::ReleaseFileFragment"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void ReleaseFileFragment(void* fragmentContext)
	{
		((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, void*, void>)(lpVtbl[4]))((IDWriteFontFileStream*)Unsafe.AsPointer(ref this), fragmentContext);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFontFileStream::GetFileSize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetFileSize(ulong* fileSize)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, ulong*, int>)(lpVtbl[5]))((IDWriteFontFileStream*)Unsafe.AsPointer(ref this), fileSize);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteFontFileStream::GetLastWriteTime"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetLastWriteTime(ulong* lastWriteTime)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, ulong*, int>)(lpVtbl[6]))((IDWriteFontFileStream*)Unsafe.AsPointer(ref this), lastWriteTime);
	}
}

