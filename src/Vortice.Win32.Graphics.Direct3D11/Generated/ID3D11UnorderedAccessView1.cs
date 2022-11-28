// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11UnorderedAccessView1"]/*' />
/// <unmanaged>ID3D11UnorderedAccessView1</unmanaged>
[Guid("7b3b6153-a886-4544-ab37-6537c8500403")]
[NativeTypeName("struct ID3D11UnorderedAccessView1 : ID3D11UnorderedAccessView")]
[NativeInheritance("ID3D11UnorderedAccessView")]
public unsafe partial struct ID3D11UnorderedAccessView1 : INativeGuid
{
	public static ref readonly Guid IID_ID3D11UnorderedAccessView1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x53, 0x61, 0x3B, 0x7B,
				0x86, 0xA8,
				0x44, 0x45,
				0xAB,
				0x37,
				0x65,
				0x37,
				0xC8,
				0x50,
				0x04,
				0x03
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11UnorderedAccessView1));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11UnorderedAccessView1));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11UnorderedAccessView1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11UnorderedAccessView1*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11UnorderedAccessView1*, uint>)(lpVtbl[1]))((ID3D11UnorderedAccessView1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11UnorderedAccessView1*, uint>)(lpVtbl[2]))((ID3D11UnorderedAccessView1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetDevice(ID3D11Device** ppDevice)
	{
		((delegate* unmanaged[Stdcall]<ID3D11UnorderedAccessView1*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11UnorderedAccessView1*)Unsafe.AsPointer(ref this), ppDevice);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11UnorderedAccessView1*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11UnorderedAccessView1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11UnorderedAccessView1*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11UnorderedAccessView1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11UnorderedAccessView1*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11UnorderedAccessView1*)Unsafe.AsPointer(ref this), guid, pData);
	}

	/// <inheritdoc cref="ID3D11View.GetResource" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public void GetResource(ID3D11Resource** ppResource)
	{
		((delegate* unmanaged[Stdcall]<ID3D11UnorderedAccessView1*, ID3D11Resource**, void>)(lpVtbl[7]))((ID3D11UnorderedAccessView1*)Unsafe.AsPointer(ref this), ppResource);
	}

	/// <inheritdoc cref="ID3D11UnorderedAccessView.GetDesc" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public void GetDesc(UnorderedAccessViewDescription* pDesc)
	{
		((delegate* unmanaged[Stdcall]<ID3D11UnorderedAccessView1*, UnorderedAccessViewDescription*, void>)(lpVtbl[8]))((ID3D11UnorderedAccessView1*)Unsafe.AsPointer(ref this), pDesc);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11UnorderedAccessView1::GetDesc1"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public void GetDesc1(UnorderedAccessViewDescription1* pDesc1)
	{
		((delegate* unmanaged[Stdcall]<ID3D11UnorderedAccessView1*, UnorderedAccessViewDescription1*, void>)(lpVtbl[9]))((ID3D11UnorderedAccessView1*)Unsafe.AsPointer(ref this), pDesc1);
	}
}

