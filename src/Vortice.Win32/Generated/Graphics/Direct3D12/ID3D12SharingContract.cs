// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12SharingContract"]/*' />
/// <unmanaged>ID3D12SharingContract</unmanaged>
[Guid("0adf7d52-929c-4e61-addb-ffed30de66ef")]
[NativeTypeName("struct ID3D12SharingContract : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12SharingContract
{
	public static ref readonly Guid IID_ID3D12SharingContract
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x52, 0x7D, 0xDF, 0x0A,
				0x9C, 0x92,
				0x61, 0x4E,
				0xAD,
				0xDB,
				0xFF,
				0xED,
				0x30,
				0xDE,
				0x66,
				0xEF
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12SharingContract));

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

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12SharingContract::Present"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void Present(ID3D12Resource* pResource, uint Subresource, IntPtr window)
	{
		((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, ID3D12Resource*, uint, IntPtr, void>)(lpVtbl[3]))((ID3D12SharingContract*)Unsafe.AsPointer(ref this), pResource, Subresource, window);
	}

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12SharingContract::SharedFenceSignal"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void SharedFenceSignal(ID3D12Fence* pFence, ulong FenceValue)
	{
		((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, ID3D12Fence*, ulong, void>)(lpVtbl[4]))((ID3D12SharingContract*)Unsafe.AsPointer(ref this), pFence, FenceValue);
	}

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12SharingContract::BeginCapturableWork"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public void BeginCapturableWork(Guid* guid)
	{
		((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, Guid*, void>)(lpVtbl[5]))((ID3D12SharingContract*)Unsafe.AsPointer(ref this), guid);
	}

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12SharingContract::EndCapturableWork"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public void EndCapturableWork(Guid* guid)
	{
		((delegate* unmanaged[Stdcall]<ID3D12SharingContract*, Guid*, void>)(lpVtbl[6]))((ID3D12SharingContract*)Unsafe.AsPointer(ref this), guid);
	}
}

