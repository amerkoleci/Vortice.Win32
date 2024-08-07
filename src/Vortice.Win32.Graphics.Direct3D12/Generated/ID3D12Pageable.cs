// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12Pageable"]/*' />
/// <unmanaged>ID3D12Pageable</unmanaged>
[Guid("63ee58fb-1268-4835-86da-f008ce62f0d6")]
[NativeTypeName("struct ID3D12Pageable : ID3D12DeviceChild")]
[NativeInheritance("ID3D12DeviceChild")]
public unsafe partial struct ID3D12Pageable : ID3D12Pageable.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D12Pageable
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xFB, 0x58, 0xEE, 0x63,
				0x68, 0x12,
				0x35, 0x48,
				0x86,
				0xDA,
				0xF0,
				0x08,
				0xCE,
				0x62,
				0xF0,
				0xD6
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12Pageable));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12Pageable*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12Pageable*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12Pageable*, uint>)(lpVtbl[1]))((ID3D12Pageable*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12Pageable*, uint>)(lpVtbl[2]))((ID3D12Pageable*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D12Object.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12Pageable*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12Pageable*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12Pageable*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12Pageable*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12Pageable*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12Pageable*)Unsafe.AsPointer(ref this), guid, pData);
	}

	/// <inheritdoc cref="ID3D12Object.SetName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetName(char* Name)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12Pageable*, char*, int>)(lpVtbl[6]))((ID3D12Pageable*)Unsafe.AsPointer(ref this), Name);
	}

	/// <inheritdoc cref="ID3D12DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetDevice(Guid* riid, void** ppvDevice)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12Pageable*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12Pageable*)Unsafe.AsPointer(ref this), riid, ppvDevice);
	}

	public interface Interface : ID3D12DeviceChild.Interface
	{
	}
}

