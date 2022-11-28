// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12DescriptorHeap"]/*' />
/// <unmanaged>ID3D12DescriptorHeap</unmanaged>
[Guid("8efb471d-616c-4f49-90f7-127bb763fa51")]
[NativeTypeName("struct ID3D12DescriptorHeap : ID3D12Pageable")]
[NativeInheritance("ID3D12Pageable")]
public unsafe partial struct ID3D12DescriptorHeap : INativeGuid
{
	public static ref readonly Guid IID_ID3D12DescriptorHeap
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x1D, 0x47, 0xFB, 0x8E,
				0x6C, 0x61,
				0x49, 0x4F,
				0x90,
				0xF7,
				0x12,
				0x7B,
				0xB7,
				0x63,
				0xFA,
				0x51
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DescriptorHeap));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DescriptorHeap));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DescriptorHeap*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12DescriptorHeap*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DescriptorHeap*, uint>)(lpVtbl[1]))((ID3D12DescriptorHeap*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DescriptorHeap*, uint>)(lpVtbl[2]))((ID3D12DescriptorHeap*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D12Object.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DescriptorHeap*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12DescriptorHeap*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DescriptorHeap*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12DescriptorHeap*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DescriptorHeap*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12DescriptorHeap*)Unsafe.AsPointer(ref this), guid, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetName(ushort* Name)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DescriptorHeap*, ushort*, int>)(lpVtbl[6]))((ID3D12DescriptorHeap*)Unsafe.AsPointer(ref this), Name);
	}

	/// <inheritdoc cref="ID3D12DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetDevice(Guid* riid, void** ppvDevice)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DescriptorHeap*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12DescriptorHeap*)Unsafe.AsPointer(ref this), riid, ppvDevice);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12DescriptorHeap::GetDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public DescriptorHeapDescription GetDesc()
	{
		DescriptorHeapDescription result;
		return *((delegate* unmanaged[Stdcall]<ID3D12DescriptorHeap*, DescriptorHeapDescription*, DescriptorHeapDescription*>)(lpVtbl[8]))((ID3D12DescriptorHeap*)Unsafe.AsPointer(ref this), &result);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12DescriptorHeap::GetCPUDescriptorHandleForHeapStart"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public CpuDescriptorHandle GetCPUDescriptorHandleForHeapStart()
	{
		CpuDescriptorHandle result;
		return *((delegate* unmanaged[Stdcall]<ID3D12DescriptorHeap*, CpuDescriptorHandle*, CpuDescriptorHandle*>)(lpVtbl[9]))((ID3D12DescriptorHeap*)Unsafe.AsPointer(ref this), &result);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12DescriptorHeap::GetGPUDescriptorHandleForHeapStart"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public GpuDescriptorHandle GetGPUDescriptorHandleForHeapStart()
	{
		GpuDescriptorHandle result;
		return *((delegate* unmanaged[Stdcall]<ID3D12DescriptorHeap*, GpuDescriptorHandle*, GpuDescriptorHandle*>)(lpVtbl[10]))((ID3D12DescriptorHeap*)Unsafe.AsPointer(ref this), &result);
	}
}

