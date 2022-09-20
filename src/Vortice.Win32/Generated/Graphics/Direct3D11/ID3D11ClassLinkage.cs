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

namespace Win32.Graphics.Direct3D11;

/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11ClassLinkage"]/*' />
/// <unmanaged>ID3D11ClassLinkage</unmanaged>
[Guid("ddf57cba-9543-46e4-a12b-f207a0fe7fed")]
[NativeTypeName("struct ID3D11ClassLinkage : ID3D11DeviceChild")]
[NativeInheritance("ID3D11DeviceChild")]
public unsafe partial struct ID3D11ClassLinkage
{
	public static ref readonly Guid IID_ID3D11ClassLinkage
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xBA, 0x7C, 0xF5, 0xDD,
				0x43, 0x95,
				0xE4, 0x46,
				0xA1,
				0x2B,
				0xF2,
				0x07,
				0xA0,
				0xFE,
				0x7F,
				0xED
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11ClassLinkage));

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

	/// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetDevice(ID3D11Device** ppDevice)
	{
		((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11ClassLinkage*)Unsafe.AsPointer(ref this), ppDevice);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11ClassLinkage*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11ClassLinkage*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11ClassLinkage*)Unsafe.AsPointer(ref this), guid, pData);
	}

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11ClassLinkage::GetClassInstance"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetClassInstance(sbyte* pClassInstanceName, uint InstanceIndex, ID3D11ClassInstance** ppInstance)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, sbyte*, uint, ID3D11ClassInstance**, int>)(lpVtbl[7]))((ID3D11ClassLinkage*)Unsafe.AsPointer(ref this), pClassInstanceName, InstanceIndex, ppInstance);
	}

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11ClassLinkage::CreateClassInstance"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateClassInstance(sbyte* pClassTypeName, uint ConstantBufferOffset, uint ConstantVectorOffset, uint TextureOffset, uint SamplerOffset, ID3D11ClassInstance** ppInstance)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ClassLinkage*, sbyte*, uint, uint, uint, uint, ID3D11ClassInstance**, int>)(lpVtbl[8]))((ID3D11ClassLinkage*)Unsafe.AsPointer(ref this), pClassTypeName, ConstantBufferOffset, ConstantVectorOffset, TextureOffset, SamplerOffset, ppInstance);
	}
}

