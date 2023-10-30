// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11RasterizerState"]/*' />
/// <unmanaged>ID3D11RasterizerState</unmanaged>
[Guid("9bb4ab81-ab1a-4d8f-b506-fc04200b6ee7")]
[NativeTypeName("struct ID3D11RasterizerState : ID3D11DeviceChild")]
[NativeInheritance("ID3D11DeviceChild")]
public unsafe partial struct ID3D11RasterizerState : ID3D11RasterizerState.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D11RasterizerState
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x81, 0xAB, 0xB4, 0x9B,
				0x1A, 0xAB,
				0x8F, 0x4D,
				0xB5,
				0x06,
				0xFC,
				0x04,
				0x20,
				0x0B,
				0x6E,
				0xE7
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11RasterizerState));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11RasterizerState*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11RasterizerState*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11RasterizerState*, uint>)(lpVtbl[1]))((ID3D11RasterizerState*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11RasterizerState*, uint>)(lpVtbl[2]))((ID3D11RasterizerState*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetDevice(ID3D11Device** ppDevice)
	{
		((delegate* unmanaged[MemberFunction]<ID3D11RasterizerState*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11RasterizerState*)Unsafe.AsPointer(ref this), ppDevice);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11RasterizerState*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11RasterizerState*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11RasterizerState*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11RasterizerState*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11RasterizerState*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11RasterizerState*)Unsafe.AsPointer(ref this), guid, pData);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11RasterizerState::GetDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public void GetDesc(RasterizerDescription* pDesc)
	{
		((delegate* unmanaged[MemberFunction]<ID3D11RasterizerState*, RasterizerDescription*, void>)(lpVtbl[7]))((ID3D11RasterizerState*)Unsafe.AsPointer(ref this), pDesc);
	}

	public interface Interface : ID3D11DeviceChild.Interface
	{
		[VtblIndex(7)]
		void GetDesc(RasterizerDescription* pDesc);
	}
}

