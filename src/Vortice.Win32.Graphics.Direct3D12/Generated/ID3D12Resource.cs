// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12Resource"]/*' />
/// <unmanaged>ID3D12Resource</unmanaged>
[Guid("696442be-a72e-4059-bc79-5b5c98040fad")]
[NativeTypeName("struct ID3D12Resource : ID3D12Pageable")]
[NativeInheritance("ID3D12Pageable")]
public unsafe partial struct ID3D12Resource : ID3D12Resource.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D12Resource
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xBE, 0x42, 0x64, 0x69,
				0x2E, 0xA7,
				0x59, 0x40,
				0xBC,
				0x79,
				0x5B,
				0x5C,
				0x98,
				0x04,
				0x0F,
				0xAD
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12Resource));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12Resource*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12Resource*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12Resource*, uint>)(lpVtbl[1]))((ID3D12Resource*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12Resource*, uint>)(lpVtbl[2]))((ID3D12Resource*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D12Object.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12Resource*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12Resource*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12Resource*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12Resource*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12Resource*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12Resource*)Unsafe.AsPointer(ref this), guid, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetName(char* Name)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12Resource*, char*, int>)(lpVtbl[6]))((ID3D12Resource*)Unsafe.AsPointer(ref this), Name);
	}

	/// <inheritdoc cref="ID3D12DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetDevice(Guid* riid, void** ppvDevice)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12Resource*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12Resource*)Unsafe.AsPointer(ref this), riid, ppvDevice);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12Resource::Map"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult Map(uint Subresource, Range* pReadRange, void** ppData)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12Resource*, uint, Range*, void**, int>)(lpVtbl[8]))((ID3D12Resource*)Unsafe.AsPointer(ref this), Subresource, pReadRange, ppData);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12Resource::Unmap"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public void Unmap(uint Subresource, Range* pWrittenRange)
	{
		((delegate* unmanaged[MemberFunction]<ID3D12Resource*, uint, Range*, void>)(lpVtbl[9]))((ID3D12Resource*)Unsafe.AsPointer(ref this), Subresource, pWrittenRange);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12Resource::GetDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public ResourceDescription GetDesc()
	{
		ResourceDescription result;
		return *((delegate* unmanaged[MemberFunction]<ID3D12Resource*, ResourceDescription*, ResourceDescription*>)(lpVtbl[10]))((ID3D12Resource*)Unsafe.AsPointer(ref this), &result);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12Resource::GetGPUVirtualAddress"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public ulong GetGPUVirtualAddress()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12Resource*, ulong>)(lpVtbl[11]))((ID3D12Resource*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12Resource::WriteToSubresource"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult WriteToSubresource(uint DstSubresource, Box* pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12Resource*, uint, Box*, void*, uint, uint, int>)(lpVtbl[12]))((ID3D12Resource*)Unsafe.AsPointer(ref this), DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12Resource::ReadFromSubresource"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult ReadFromSubresource(void* pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, Box* pSrcBox)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12Resource*, void*, uint, uint, uint, Box*, int>)(lpVtbl[13]))((ID3D12Resource*)Unsafe.AsPointer(ref this), pDstData, DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBox);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12Resource::GetHeapProperties"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult GetHeapProperties(HeapProperties* pHeapProperties, HeapFlags* pHeapFlags)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12Resource*, HeapProperties*, HeapFlags*, int>)(lpVtbl[14]))((ID3D12Resource*)Unsafe.AsPointer(ref this), pHeapProperties, pHeapFlags);
	}

	public interface Interface : ID3D12Pageable.Interface
	{
		[VtblIndex(8)]
		HResult Map(uint Subresource, Range* pReadRange, void** ppData);

		[VtblIndex(9)]
		void Unmap(uint Subresource, Range* pWrittenRange);

		[VtblIndex(10)]
		ResourceDescription GetDesc();

		[VtblIndex(11)]
		ulong GetGPUVirtualAddress();

		[VtblIndex(12)]
		HResult WriteToSubresource(uint DstSubresource, Box* pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch);

		[VtblIndex(13)]
		HResult ReadFromSubresource(void* pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, Box* pSrcBox);

		[VtblIndex(14)]
		HResult GetHeapProperties(HeapProperties* pHeapProperties, HeapFlags* pHeapFlags);
	}
}

