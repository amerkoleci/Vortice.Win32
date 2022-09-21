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

namespace Win32.Graphics.Direct3D12;

/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList3"]/*' />
/// <unmanaged>ID3D12GraphicsCommandList3</unmanaged>
[Guid("6fda83a7-b84c-4e38-9ac8-c7bd22016b3d")]
[NativeTypeName("struct ID3D12GraphicsCommandList3 : ID3D12GraphicsCommandList2")]
[NativeInheritance("ID3D12GraphicsCommandList2")]
public unsafe partial struct ID3D12GraphicsCommandList3
{
	public static ref readonly Guid IID_ID3D12GraphicsCommandList3
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xA7, 0x83, 0xDA, 0x6F,
				0x4C, 0xB8,
				0x38, 0x4E,
				0x9A,
				0xC8,
				0xC7,
				0xBD,
				0x22,
				0x01,
				0x6B,
				0x3D
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12GraphicsCommandList3));

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

	/// <inheritdoc cref="ID3D12Object.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), guid, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetName(ushort* Name)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ushort*, int>)(lpVtbl[6]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), Name);
	}

	/// <inheritdoc cref="ID3D12DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetDevice(Guid* riid, void** ppvDevice)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), riid, ppvDevice);
	}

	/// <inheritdoc cref="ID3D12CommandList.GetType" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public new CommandListType GetType()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, CommandListType>)(lpVtbl[8]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.Close" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult Close()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, int>)(lpVtbl[9]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.Reset" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult Reset(ID3D12CommandAllocator* pAllocator, ID3D12PipelineState* pInitialState)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12CommandAllocator*, ID3D12PipelineState*, int>)(lpVtbl[10]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), pAllocator, pInitialState);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.ClearState" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public void ClearState(ID3D12PipelineState* pPipelineState)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12PipelineState*, void>)(lpVtbl[11]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), pPipelineState);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.DrawInstanced" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public void DrawInstanced(uint VertexCountPerInstance, uint InstanceCount, uint StartVertexLocation, uint StartInstanceLocation)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, uint, uint, uint, void>)(lpVtbl[12]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.DrawIndexedInstanced" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public void DrawIndexedInstanced(uint IndexCountPerInstance, uint InstanceCount, uint StartIndexLocation, int BaseVertexLocation, uint StartInstanceLocation)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, uint, uint, int, uint, void>)(lpVtbl[13]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.Dispatch" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public void Dispatch(uint ThreadGroupCountX, uint ThreadGroupCountY, uint ThreadGroupCountZ)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, uint, uint, void>)(lpVtbl[14]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.CopyBufferRegion" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public void CopyBufferRegion(ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, ulong NumBytes)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void>)(lpVtbl[15]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, NumBytes);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.CopyTextureRegion" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public void CopyTextureRegion(TextureCopyLocation* pDst, uint DstX, uint DstY, uint DstZ, TextureCopyLocation* pSrc, Box* pSrcBox)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)(lpVtbl[16]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), pDst, DstX, DstY, DstZ, pSrc, pSrcBox);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.CopyResource" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public void CopyResource(ID3D12Resource* pDstResource, ID3D12Resource* pSrcResource)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ID3D12Resource*, void>)(lpVtbl[17]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), pDstResource, pSrcResource);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.CopyTiles" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public void CopyTiles(ID3D12Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)(lpVtbl[18]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.ResolveSubresource" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public void ResolveSubresource(ID3D12Resource* pDstResource, uint DstSubresource, ID3D12Resource* pSrcResource, uint SrcSubresource, Graphics.Dxgi.Common.Format Format)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, uint, ID3D12Resource*, uint, Graphics.Dxgi.Common.Format, void>)(lpVtbl[19]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.IASetPrimitiveTopology" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public void IASetPrimitiveTopology(Graphics.Direct3D.PrimitiveTopology PrimitiveTopology)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, Graphics.Direct3D.PrimitiveTopology, void>)(lpVtbl[20]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), PrimitiveTopology);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.RSSetViewports" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public void RSSetViewports(uint NumViewports, Viewport* pViewports)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, Viewport*, void>)(lpVtbl[21]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), NumViewports, pViewports);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.RSSetScissorRects" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public void RSSetScissorRects(uint NumRects, RawRect* pRects)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, RawRect*, void>)(lpVtbl[22]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), NumRects, pRects);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.OMSetBlendFactor" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public void OMSetBlendFactor(float* BlendFactor)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, float*, void>)(lpVtbl[23]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), BlendFactor);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.OMSetStencilRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public void OMSetStencilRef(uint StencilRef)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, void>)(lpVtbl[24]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), StencilRef);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.SetPipelineState" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public void SetPipelineState(ID3D12PipelineState* pPipelineState)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12PipelineState*, void>)(lpVtbl[25]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), pPipelineState);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.ResourceBarrier" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public void ResourceBarrier(uint NumBarriers, ResourceBarrier* pBarriers)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, ResourceBarrier*, void>)(lpVtbl[26]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), NumBarriers, pBarriers);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.ExecuteBundle" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public void ExecuteBundle(ID3D12GraphicsCommandList* pCommandList)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12GraphicsCommandList*, void>)(lpVtbl[27]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), pCommandList);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.SetDescriptorHeaps" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public void SetDescriptorHeaps(uint NumDescriptorHeaps, ID3D12DescriptorHeap** ppDescriptorHeaps)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, ID3D12DescriptorHeap**, void>)(lpVtbl[28]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), NumDescriptorHeaps, ppDescriptorHeaps);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.SetComputeRootSignature" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(29)]
	public void SetComputeRootSignature(ID3D12RootSignature* pRootSignature)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12RootSignature*, void>)(lpVtbl[29]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), pRootSignature);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.SetGraphicsRootSignature" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(30)]
	public void SetGraphicsRootSignature(ID3D12RootSignature* pRootSignature)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12RootSignature*, void>)(lpVtbl[30]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), pRootSignature);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.SetComputeRootDescriptorTable" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(31)]
	public void SetComputeRootDescriptorTable(uint RootParameterIndex, GpuDescriptorHandle* BaseDescriptor)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, GpuDescriptorHandle*, void>)(lpVtbl[31]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), RootParameterIndex, BaseDescriptor);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.SetGraphicsRootDescriptorTable" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(32)]
	public void SetGraphicsRootDescriptorTable(uint RootParameterIndex, GpuDescriptorHandle* BaseDescriptor)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, GpuDescriptorHandle*, void>)(lpVtbl[32]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), RootParameterIndex, BaseDescriptor);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.SetComputeRoot32BitConstant" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(33)]
	public void SetComputeRoot32BitConstant(uint RootParameterIndex, uint SrcData, uint DestOffsetIn32BitValues)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, uint, uint, void>)(lpVtbl[33]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), RootParameterIndex, SrcData, DestOffsetIn32BitValues);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.SetGraphicsRoot32BitConstant" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(34)]
	public void SetGraphicsRoot32BitConstant(uint RootParameterIndex, uint SrcData, uint DestOffsetIn32BitValues)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, uint, uint, void>)(lpVtbl[34]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), RootParameterIndex, SrcData, DestOffsetIn32BitValues);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.SetComputeRoot32BitConstants" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(35)]
	public void SetComputeRoot32BitConstants(uint RootParameterIndex, uint Num32BitValuesToSet, void* pSrcData, uint DestOffsetIn32BitValues)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, uint, void*, uint, void>)(lpVtbl[35]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.SetGraphicsRoot32BitConstants" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(36)]
	public void SetGraphicsRoot32BitConstants(uint RootParameterIndex, uint Num32BitValuesToSet, void* pSrcData, uint DestOffsetIn32BitValues)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, uint, void*, uint, void>)(lpVtbl[36]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.SetComputeRootConstantBufferView" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(37)]
	public void SetComputeRootConstantBufferView(uint RootParameterIndex, ulong BufferLocation)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, ulong, void>)(lpVtbl[37]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.SetGraphicsRootConstantBufferView" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(38)]
	public void SetGraphicsRootConstantBufferView(uint RootParameterIndex, ulong BufferLocation)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, ulong, void>)(lpVtbl[38]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.SetComputeRootShaderResourceView" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(39)]
	public void SetComputeRootShaderResourceView(uint RootParameterIndex, ulong BufferLocation)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, ulong, void>)(lpVtbl[39]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.SetGraphicsRootShaderResourceView" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(40)]
	public void SetGraphicsRootShaderResourceView(uint RootParameterIndex, ulong BufferLocation)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, ulong, void>)(lpVtbl[40]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.SetComputeRootUnorderedAccessView" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(41)]
	public void SetComputeRootUnorderedAccessView(uint RootParameterIndex, ulong BufferLocation)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, ulong, void>)(lpVtbl[41]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.SetGraphicsRootUnorderedAccessView" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(42)]
	public void SetGraphicsRootUnorderedAccessView(uint RootParameterIndex, ulong BufferLocation)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, ulong, void>)(lpVtbl[42]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.IASetIndexBuffer" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(43)]
	public void IASetIndexBuffer(IndexBufferView* pView)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, IndexBufferView*, void>)(lpVtbl[43]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), pView);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.IASetVertexBuffers" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(44)]
	public void IASetVertexBuffers(uint StartSlot, uint NumViews, VertexBufferView* pViews)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, uint, VertexBufferView*, void>)(lpVtbl[44]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), StartSlot, NumViews, pViews);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.SOSetTargets" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(45)]
	public void SOSetTargets(uint StartSlot, uint NumViews, StreamOutputBufferView* pViews)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, uint, StreamOutputBufferView*, void>)(lpVtbl[45]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), StartSlot, NumViews, pViews);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.OMSetRenderTargets" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(46)]
	public void OMSetRenderTargets(uint NumRenderTargetDescriptors, CpuDescriptorHandle* pRenderTargetDescriptors, Bool32 RTsSingleHandleToDescriptorRange, CpuDescriptorHandle* pDepthStencilDescriptor)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, CpuDescriptorHandle*, Bool32, CpuDescriptorHandle*, void>)(lpVtbl[46]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), NumRenderTargetDescriptors, pRenderTargetDescriptors, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptor);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.ClearDepthStencilView" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(47)]
	public void ClearDepthStencilView(CpuDescriptorHandle* DepthStencilView, ClearFlags ClearFlags, float Depth, byte Stencil, uint NumRects, RawRect* pRects)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, CpuDescriptorHandle*, ClearFlags, float, byte, uint, RawRect*, void>)(lpVtbl[47]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), DepthStencilView, ClearFlags, Depth, Stencil, NumRects, pRects);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.ClearRenderTargetView" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(48)]
	public void ClearRenderTargetView(CpuDescriptorHandle* RenderTargetView, float* ColorRGBA, uint NumRects, RawRect* pRects)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, CpuDescriptorHandle*, float*, uint, RawRect*, void>)(lpVtbl[48]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), RenderTargetView, ColorRGBA, NumRects, pRects);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.ClearUnorderedAccessViewUint" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(49)]
	public void ClearUnorderedAccessViewUint(GpuDescriptorHandle* ViewGPUHandleInCurrentHeap, CpuDescriptorHandle* ViewCPUHandle, ID3D12Resource* pResource, uint* Values, uint NumRects, RawRect* pRects)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, GpuDescriptorHandle*, CpuDescriptorHandle*, ID3D12Resource*, uint*, uint, RawRect*, void>)(lpVtbl[49]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.ClearUnorderedAccessViewFloat" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(50)]
	public void ClearUnorderedAccessViewFloat(GpuDescriptorHandle* ViewGPUHandleInCurrentHeap, CpuDescriptorHandle* ViewCPUHandle, ID3D12Resource* pResource, float* Values, uint NumRects, RawRect* pRects)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, GpuDescriptorHandle*, CpuDescriptorHandle*, ID3D12Resource*, float*, uint, RawRect*, void>)(lpVtbl[50]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.DiscardResource" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(51)]
	public void DiscardResource(ID3D12Resource* pResource, DiscardRegion* pRegion)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, DiscardRegion*, void>)(lpVtbl[51]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), pResource, pRegion);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.BeginQuery" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(52)]
	public void BeginQuery(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12QueryHeap*, QueryType, uint, void>)(lpVtbl[52]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), pQueryHeap, Type, Index);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.EndQuery" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(53)]
	public void EndQuery(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12QueryHeap*, QueryType, uint, void>)(lpVtbl[53]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), pQueryHeap, Type, Index);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.ResolveQueryData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(54)]
	public void ResolveQueryData(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)(lpVtbl[54]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.SetPredication" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(55)]
	public void SetPredication(ID3D12Resource* pBuffer, ulong AlignedBufferOffset, PredicationOperation Operation)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, PredicationOperation, void>)(lpVtbl[55]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), pBuffer, AlignedBufferOffset, Operation);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.SetMarker" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(56)]
	public void SetMarker(uint Metadata, void* pData, uint Size)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, void*, uint, void>)(lpVtbl[56]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), Metadata, pData, Size);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.BeginEvent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(57)]
	public void BeginEvent(uint Metadata, void* pData, uint Size)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, void*, uint, void>)(lpVtbl[57]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), Metadata, pData, Size);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.EndEvent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(58)]
	public void EndEvent()
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, void>)(lpVtbl[58]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList.ExecuteIndirect" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(59)]
	public void ExecuteIndirect(ID3D12CommandSignature* pCommandSignature, uint MaxCommandCount, ID3D12Resource* pArgumentBuffer, ulong ArgumentBufferOffset, ID3D12Resource* pCountBuffer, ulong CountBufferOffset)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)(lpVtbl[59]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), pCommandSignature, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList1.AtomicCopyBufferUINT" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(60)]
	public void AtomicCopyBufferUINT(ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUInt64* pDependentSubresourceRanges)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUInt64*, void>)(lpVtbl[60]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList1.AtomicCopyBufferUINT64" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(61)]
	public void AtomicCopyBufferUINT64(ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUInt64* pDependentSubresourceRanges)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUInt64*, void>)(lpVtbl[61]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList1.OMSetDepthBounds" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(62)]
	public void OMSetDepthBounds(float Min, float Max)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, float, float, void>)(lpVtbl[62]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), Min, Max);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList1.SetSamplePositions" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(63)]
	public void SetSamplePositions(uint NumSamplesPerPixel, uint NumPixels, SamplePosition* pSamplePositions)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, uint, SamplePosition*, void>)(lpVtbl[63]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), NumSamplesPerPixel, NumPixels, pSamplePositions);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList1.ResolveSubresourceRegion" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(64)]
	public void ResolveSubresourceRegion(ID3D12Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, ID3D12Resource* pSrcResource, uint SrcSubresource, RawRect* pSrcRect, Graphics.Dxgi.Common.Format Format, ResolveMode ResolveMode)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, RawRect*, Graphics.Dxgi.Common.Format, ResolveMode, void>)(lpVtbl[64]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, DstX, DstY, pSrcResource, SrcSubresource, pSrcRect, Format, ResolveMode);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList1.SetViewInstanceMask" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(65)]
	public void SetViewInstanceMask(uint Mask)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, void>)(lpVtbl[65]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), Mask);
	}

	/// <inheritdoc cref="ID3D12GraphicsCommandList2.WriteBufferImmediate" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(66)]
	public void WriteBufferImmediate(uint Count, WriteBufferImmediateParameter* pParams, WriteBufferImmediateMode* pModes)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, uint, WriteBufferImmediateParameter*, WriteBufferImmediateMode*, void>)(lpVtbl[66]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), Count, pParams, pModes);
	}

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12GraphicsCommandList3::SetProtectedResourceSession"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(67)]
	public void SetProtectedResourceSession(ID3D12ProtectedResourceSession* pProtectedResourceSession)
	{
		((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList3*, ID3D12ProtectedResourceSession*, void>)(lpVtbl[67]))((ID3D12GraphicsCommandList3*)Unsafe.AsPointer(ref this), pProtectedResourceSession);
	}
}
