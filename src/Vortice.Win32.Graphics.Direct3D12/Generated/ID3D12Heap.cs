// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12Heap"]/*' />
/// <unmanaged>ID3D12Heap</unmanaged>
[Guid("6b3b2502-6e51-45b3-90ee-9884265e8df3")]
[NativeTypeName("struct ID3D12Heap : ID3D12Pageable")]
[NativeInheritance("ID3D12Pageable")]
public unsafe partial struct ID3D12Heap : ID3D12Heap.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D12Heap
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x02, 0x25, 0x3B, 0x6B,
				0x51, 0x6E,
				0xB3, 0x45,
				0x90,
				0xEE,
				0x98,
				0x84,
				0x26,
				0x5E,
				0x8D,
				0xF3
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12Heap));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12Heap));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Heap*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12Heap*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Heap*, uint>)(lpVtbl[1]))((ID3D12Heap*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Heap*, uint>)(lpVtbl[2]))((ID3D12Heap*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D12Object.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Heap*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12Heap*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Heap*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12Heap*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Heap*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12Heap*)Unsafe.AsPointer(ref this), guid, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetName(ushort* Name)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Heap*, ushort*, int>)(lpVtbl[6]))((ID3D12Heap*)Unsafe.AsPointer(ref this), Name);
	}

	/// <inheritdoc cref="ID3D12DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetDevice(Guid* riid, void** ppvDevice)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Heap*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12Heap*)Unsafe.AsPointer(ref this), riid, ppvDevice);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12Heap::GetDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HeapDescription GetDesc()
	{
		HeapDescription result;
		return *((delegate* unmanaged[Stdcall]<ID3D12Heap*, HeapDescription*, HeapDescription*>)(lpVtbl[8]))((ID3D12Heap*)Unsafe.AsPointer(ref this), &result);
	}
	public interface Interface : ID3D12Pageable.Interface
	{
		[VtblIndex(8)]
		HeapDescription GetDesc();
	}
}

