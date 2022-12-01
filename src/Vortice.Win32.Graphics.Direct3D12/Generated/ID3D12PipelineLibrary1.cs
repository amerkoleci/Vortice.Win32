// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12PipelineLibrary1"]/*' />
/// <unmanaged>ID3D12PipelineLibrary1</unmanaged>
[Guid("80eabf42-2568-4e5e-bd82-c37f86961dc3")]
[NativeTypeName("struct ID3D12PipelineLibrary1 : ID3D12PipelineLibrary")]
[NativeInheritance("ID3D12PipelineLibrary")]
public unsafe partial struct ID3D12PipelineLibrary1 : ID3D12PipelineLibrary1.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D12PipelineLibrary1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x42, 0xBF, 0xEA, 0x80,
				0x68, 0x25,
				0x5E, 0x4E,
				0xBD,
				0x82,
				0xC3,
				0x7F,
				0x86,
				0x96,
				0x1D,
				0xC3
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12PipelineLibrary1));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12PipelineLibrary1));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, uint>)(lpVtbl[1]))((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, uint>)(lpVtbl[2]))((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D12Object.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this), guid, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetName(ushort* Name)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, ushort*, int>)(lpVtbl[6]))((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this), Name);
	}

	/// <inheritdoc cref="ID3D12DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetDevice(Guid* riid, void** ppvDevice)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this), riid, ppvDevice);
	}

	/// <inheritdoc cref="ID3D12PipelineLibrary.StorePipeline" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult StorePipeline(ushort* pName, ID3D12PipelineState* pPipeline)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, ushort*, ID3D12PipelineState*, int>)(lpVtbl[8]))((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this), pName, pPipeline);
	}

	/// <inheritdoc cref="ID3D12PipelineLibrary.LoadGraphicsPipeline" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult LoadGraphicsPipeline(ushort* pName, GraphicsPipelineStateDescription* pDesc, Guid* riid, void** ppPipelineState)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, ushort*, GraphicsPipelineStateDescription*, Guid*, void**, int>)(lpVtbl[9]))((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this), pName, pDesc, riid, ppPipelineState);
	}

	/// <inheritdoc cref="ID3D12PipelineLibrary.LoadComputePipeline" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult LoadComputePipeline(ushort* pName, ComputePipelineStateDescription* pDesc, Guid* riid, void** ppPipelineState)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, ushort*, ComputePipelineStateDescription*, Guid*, void**, int>)(lpVtbl[10]))((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this), pName, pDesc, riid, ppPipelineState);
	}

	/// <inheritdoc cref="ID3D12PipelineLibrary.GetSerializedSize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public nuint GetSerializedSize()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, nuint>)(lpVtbl[11]))((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D12PipelineLibrary.Serialize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult Serialize(void* pData, nuint DataSizeInBytes)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, void*, nuint, int>)(lpVtbl[12]))((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this), pData, DataSizeInBytes);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12PipelineLibrary1::LoadPipeline"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult LoadPipeline(ushort* pName, PipelineStateStreamDescription* pDesc, Guid* riid, void** ppPipelineState)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, ushort*, PipelineStateStreamDescription*, Guid*, void**, int>)(lpVtbl[13]))((ID3D12PipelineLibrary1*)Unsafe.AsPointer(ref this), pName, pDesc, riid, ppPipelineState);
	}
	public interface Interface : ID3D12PipelineLibrary.Interface
	{
		[VtblIndex(13)]
		HResult LoadPipeline(ushort* pName, PipelineStateStreamDescription* pDesc, Guid* riid, void** ppPipelineState);
	}
}

