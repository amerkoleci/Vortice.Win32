// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12WorkGraphProperties"]/*' />
/// <unmanaged>ID3D12WorkGraphProperties</unmanaged>
[Guid("065acf71-f863-4b89-82f4-02e4d5886757")]
[NativeTypeName("struct ID3D12WorkGraphProperties : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12WorkGraphProperties : ID3D12WorkGraphProperties.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D12WorkGraphProperties
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x71, 0xCF, 0x5A, 0x06,
				0x63, 0xF8,
				0x89, 0x4B,
				0x82,
				0xF4,
				0x02,
				0xE4,
				0xD5,
				0x88,
				0x67,
				0x57
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12WorkGraphProperties));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12WorkGraphProperties*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12WorkGraphProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12WorkGraphProperties*, uint>)(lpVtbl[1]))((ID3D12WorkGraphProperties*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12WorkGraphProperties*, uint>)(lpVtbl[2]))((ID3D12WorkGraphProperties*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12WorkGraphProperties::GetNumWorkGraphs"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public uint GetNumWorkGraphs()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12WorkGraphProperties*, uint>)(lpVtbl[3]))((ID3D12WorkGraphProperties*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12WorkGraphProperties::GetProgramName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public ushort* GetProgramName(uint WorkGraphIndex)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12WorkGraphProperties*, uint, ushort*>)(lpVtbl[4]))((ID3D12WorkGraphProperties*)Unsafe.AsPointer(ref this), WorkGraphIndex);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12WorkGraphProperties::GetWorkGraphIndex"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public uint GetWorkGraphIndex(ushort* pProgramName)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12WorkGraphProperties*, ushort*, uint>)(lpVtbl[5]))((ID3D12WorkGraphProperties*)Unsafe.AsPointer(ref this), pProgramName);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12WorkGraphProperties::GetNumNodes"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public uint GetNumNodes(uint WorkGraphIndex)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12WorkGraphProperties*, uint, uint>)(lpVtbl[6]))((ID3D12WorkGraphProperties*)Unsafe.AsPointer(ref this), WorkGraphIndex);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12WorkGraphProperties::GetNodeID"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public NodeId GetNodeID(uint WorkGraphIndex, uint NodeIndex)
	{
		NodeId result;
		return *((delegate* unmanaged[MemberFunction]<ID3D12WorkGraphProperties*, NodeId*, uint, uint, NodeId*>)(lpVtbl[7]))((ID3D12WorkGraphProperties*)Unsafe.AsPointer(ref this), &result, WorkGraphIndex, NodeIndex);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12WorkGraphProperties::GetNodeIndex"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public uint GetNodeIndex(uint WorkGraphIndex, NodeId NodeID)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12WorkGraphProperties*, uint, NodeId, uint>)(lpVtbl[8]))((ID3D12WorkGraphProperties*)Unsafe.AsPointer(ref this), WorkGraphIndex, NodeID);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12WorkGraphProperties::GetNodeLocalRootArgumentsTableIndex"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public uint GetNodeLocalRootArgumentsTableIndex(uint WorkGraphIndex, uint NodeIndex)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12WorkGraphProperties*, uint, uint, uint>)(lpVtbl[9]))((ID3D12WorkGraphProperties*)Unsafe.AsPointer(ref this), WorkGraphIndex, NodeIndex);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12WorkGraphProperties::GetNumEntrypoints"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public uint GetNumEntrypoints(uint WorkGraphIndex)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12WorkGraphProperties*, uint, uint>)(lpVtbl[10]))((ID3D12WorkGraphProperties*)Unsafe.AsPointer(ref this), WorkGraphIndex);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12WorkGraphProperties::GetEntrypointID"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public NodeId GetEntrypointID(uint WorkGraphIndex, uint EntrypointIndex)
	{
		NodeId result;
		return *((delegate* unmanaged[MemberFunction]<ID3D12WorkGraphProperties*, NodeId*, uint, uint, NodeId*>)(lpVtbl[11]))((ID3D12WorkGraphProperties*)Unsafe.AsPointer(ref this), &result, WorkGraphIndex, EntrypointIndex);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12WorkGraphProperties::GetEntrypointIndex"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public uint GetEntrypointIndex(uint WorkGraphIndex, NodeId NodeID)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12WorkGraphProperties*, uint, NodeId, uint>)(lpVtbl[12]))((ID3D12WorkGraphProperties*)Unsafe.AsPointer(ref this), WorkGraphIndex, NodeID);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12WorkGraphProperties::GetEntrypointRecordSizeInBytes"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public uint GetEntrypointRecordSizeInBytes(uint WorkGraphIndex, uint EntrypointIndex)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12WorkGraphProperties*, uint, uint, uint>)(lpVtbl[13]))((ID3D12WorkGraphProperties*)Unsafe.AsPointer(ref this), WorkGraphIndex, EntrypointIndex);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12WorkGraphProperties::GetWorkGraphMemoryRequirements"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public void GetWorkGraphMemoryRequirements(uint WorkGraphIndex, WorkGraphMemoryRequirements* pWorkGraphMemoryRequirements)
	{
		((delegate* unmanaged[MemberFunction]<ID3D12WorkGraphProperties*, uint, WorkGraphMemoryRequirements*, void>)(lpVtbl[14]))((ID3D12WorkGraphProperties*)Unsafe.AsPointer(ref this), WorkGraphIndex, pWorkGraphMemoryRequirements);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12WorkGraphProperties::GetEntrypointRecordAlignmentInBytes"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public uint GetEntrypointRecordAlignmentInBytes(uint WorkGraphIndex, uint EntrypointIndex)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12WorkGraphProperties*, uint, uint, uint>)(lpVtbl[15]))((ID3D12WorkGraphProperties*)Unsafe.AsPointer(ref this), WorkGraphIndex, EntrypointIndex);
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		uint GetNumWorkGraphs();

		[VtblIndex(4)]
		ushort* GetProgramName(uint WorkGraphIndex);

		[VtblIndex(5)]
		uint GetWorkGraphIndex(ushort* pProgramName);

		[VtblIndex(6)]
		uint GetNumNodes(uint WorkGraphIndex);

		[VtblIndex(7)]
		NodeId GetNodeID(uint WorkGraphIndex, uint NodeIndex);

		[VtblIndex(8)]
		uint GetNodeIndex(uint WorkGraphIndex, NodeId NodeID);

		[VtblIndex(9)]
		uint GetNodeLocalRootArgumentsTableIndex(uint WorkGraphIndex, uint NodeIndex);

		[VtblIndex(10)]
		uint GetNumEntrypoints(uint WorkGraphIndex);

		[VtblIndex(11)]
		NodeId GetEntrypointID(uint WorkGraphIndex, uint EntrypointIndex);

		[VtblIndex(12)]
		uint GetEntrypointIndex(uint WorkGraphIndex, NodeId NodeID);

		[VtblIndex(13)]
		uint GetEntrypointRecordSizeInBytes(uint WorkGraphIndex, uint EntrypointIndex);

		[VtblIndex(14)]
		void GetWorkGraphMemoryRequirements(uint WorkGraphIndex, WorkGraphMemoryRequirements* pWorkGraphMemoryRequirements);

		[VtblIndex(15)]
		uint GetEntrypointRecordAlignmentInBytes(uint WorkGraphIndex, uint EntrypointIndex);
	}
}

