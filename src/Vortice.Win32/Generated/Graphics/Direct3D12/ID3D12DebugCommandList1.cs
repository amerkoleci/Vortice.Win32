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

/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12DebugCommandList1"]/*' />
/// <unmanaged>ID3D12DebugCommandList1</unmanaged>
[Guid("102ca951-311b-4b01-b11f-ecb83e061b37")]
[NativeTypeName("struct ID3D12DebugCommandList1 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12DebugCommandList1
{
	public static ref readonly Guid IID_ID3D12DebugCommandList1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x51, 0xA9, 0x2C, 0x10,
				0x1B, 0x31,
				0x01, 0x4B,
				0xB1,
				0x1F,
				0xEC,
				0xB8,
				0x3E,
				0x06,
				0x1B,
				0x37
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DebugCommandList1));

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

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12DebugCommandList1::AssertResourceState"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public Bool32 AssertResourceState(ID3D12Resource* pResource, uint Subresource, uint State)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList1*, ID3D12Resource*, uint, uint, Bool32>)(lpVtbl[3]))((ID3D12DebugCommandList1*)Unsafe.AsPointer(ref this), pResource, Subresource, State);
	}

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12DebugCommandList1::SetDebugParameter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetDebugParameter(DebugCommandListParameterType Type, void* pData, uint DataSize)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList1*, DebugCommandListParameterType, void*, uint, int>)(lpVtbl[4]))((ID3D12DebugCommandList1*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
	}

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12DebugCommandList1::GetDebugParameter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetDebugParameter(DebugCommandListParameterType Type, void* pData, uint DataSize)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugCommandList1*, DebugCommandListParameterType, void*, uint, int>)(lpVtbl[5]))((ID3D12DebugCommandList1*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
	}
}

