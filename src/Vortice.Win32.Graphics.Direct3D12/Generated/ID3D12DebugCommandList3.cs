// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12DebugCommandList3"]/*' />
/// <unmanaged>ID3D12DebugCommandList3</unmanaged>
[Guid("197d5e15-4d37-4d34-af78-724cd70fdb1f")]
[NativeTypeName("struct ID3D12DebugCommandList3 : ID3D12DebugCommandList2")]
[NativeInheritance("ID3D12DebugCommandList2")]
public unsafe partial struct ID3D12DebugCommandList3 : ID3D12DebugCommandList3.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D12DebugCommandList3
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x15, 0x5E, 0x7D, 0x19,
				0x37, 0x4D,
				0x34, 0x4D,
				0xAF,
				0x78,
				0x72,
				0x4C,
				0xD7,
				0x0F,
				0xDB,
				0x1F
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DebugCommandList3));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DebugCommandList3));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12DebugCommandList3*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12DebugCommandList3*)Unsafe.AsPointer(ref this), riid, ppvObject);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList3*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12DebugCommandList3*)Unsafe.AsPointer(ref this), riid, ppvObject);
#endif
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12DebugCommandList3*, uint>)(lpVtbl[1]))((ID3D12DebugCommandList3*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList3*, uint>)(lpVtbl[1]))((ID3D12DebugCommandList3*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12DebugCommandList3*, uint>)(lpVtbl[2]))((ID3D12DebugCommandList3*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList3*, uint>)(lpVtbl[2]))((ID3D12DebugCommandList3*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="ID3D12DebugCommandList.AssertResourceState" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public Bool32 AssertResourceState(ID3D12Resource* pResource, uint Subresource, uint State)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12DebugCommandList3*, ID3D12Resource*, uint, uint, Bool32>)(lpVtbl[3]))((ID3D12DebugCommandList3*)Unsafe.AsPointer(ref this), pResource, Subresource, State);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList3*, ID3D12Resource*, uint, uint, Bool32>)(lpVtbl[3]))((ID3D12DebugCommandList3*)Unsafe.AsPointer(ref this), pResource, Subresource, State);
#endif
	}

	/// <inheritdoc cref="ID3D12DebugCommandList.SetFeatureMask" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetFeatureMask(DebugFeature Mask)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12DebugCommandList3*, DebugFeature, int>)(lpVtbl[4]))((ID3D12DebugCommandList3*)Unsafe.AsPointer(ref this), Mask);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList3*, DebugFeature, int>)(lpVtbl[4]))((ID3D12DebugCommandList3*)Unsafe.AsPointer(ref this), Mask);
#endif
	}

	/// <inheritdoc cref="ID3D12DebugCommandList.GetFeatureMask" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public DebugFeature GetFeatureMask()
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12DebugCommandList3*, DebugFeature>)(lpVtbl[5]))((ID3D12DebugCommandList3*)Unsafe.AsPointer(ref this));
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList3*, DebugFeature>)(lpVtbl[5]))((ID3D12DebugCommandList3*)Unsafe.AsPointer(ref this));
#endif
	}

	/// <inheritdoc cref="ID3D12DebugCommandList2.SetDebugParameter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetDebugParameter(DebugCommandListParameterType Type, void* pData, uint DataSize)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12DebugCommandList3*, DebugCommandListParameterType, void*, uint, int>)(lpVtbl[6]))((ID3D12DebugCommandList3*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList3*, DebugCommandListParameterType, void*, uint, int>)(lpVtbl[6]))((ID3D12DebugCommandList3*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
#endif
	}

	/// <inheritdoc cref="ID3D12DebugCommandList2.GetDebugParameter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetDebugParameter(DebugCommandListParameterType Type, void* pData, uint DataSize)
	{
#if NET6_0_OR_GREATER
		return ((delegate* unmanaged<ID3D12DebugCommandList3*, DebugCommandListParameterType, void*, uint, int>)(lpVtbl[7]))((ID3D12DebugCommandList3*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
#else
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList3*, DebugCommandListParameterType, void*, uint, int>)(lpVtbl[7]))((ID3D12DebugCommandList3*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
#endif
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12DebugCommandList3::AssertResourceAccess"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public void AssertResourceAccess(ID3D12Resource* pResource, uint Subresource, BarrierAccess Access)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D12DebugCommandList3*, ID3D12Resource*, uint, BarrierAccess, void>)(lpVtbl[8]))((ID3D12DebugCommandList3*)Unsafe.AsPointer(ref this), pResource, Subresource, Access);
#else
		((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList3*, ID3D12Resource*, uint, BarrierAccess, void>)(lpVtbl[8]))((ID3D12DebugCommandList3*)Unsafe.AsPointer(ref this), pResource, Subresource, Access);
#endif
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12DebugCommandList3::AssertTextureLayout"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public void AssertTextureLayout(ID3D12Resource* pResource, uint Subresource, BarrierLayout Layout)
	{
#if NET6_0_OR_GREATER
		((delegate* unmanaged<ID3D12DebugCommandList3*, ID3D12Resource*, uint, BarrierLayout, void>)(lpVtbl[9]))((ID3D12DebugCommandList3*)Unsafe.AsPointer(ref this), pResource, Subresource, Layout);
#else
		((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList3*, ID3D12Resource*, uint, BarrierLayout, void>)(lpVtbl[9]))((ID3D12DebugCommandList3*)Unsafe.AsPointer(ref this), pResource, Subresource, Layout);
#endif
	}

	public interface Interface : ID3D12DebugCommandList2.Interface
	{
		[VtblIndex(8)]
		void AssertResourceAccess(ID3D12Resource* pResource, uint Subresource, BarrierAccess Access);

		[VtblIndex(9)]
		void AssertTextureLayout(ID3D12Resource* pResource, uint Subresource, BarrierLayout Layout);
	}
}
