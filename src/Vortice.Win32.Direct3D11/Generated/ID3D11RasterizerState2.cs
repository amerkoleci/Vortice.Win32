// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11RasterizerState2"]/*' />
/// <unmanaged>ID3D11RasterizerState2</unmanaged>
[Guid("6fbd02fb-209f-46c4-b059-2ed15586a6ac")]
[NativeTypeName("struct ID3D11RasterizerState2 : ID3D11RasterizerState1")]
[NativeInheritance("ID3D11RasterizerState1")]
public unsafe partial struct ID3D11RasterizerState2 : INativeGuid
{
	public static ref readonly Guid IID_ID3D11RasterizerState2
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xFB, 0x02, 0xBD, 0x6F,
				0x9F, 0x20,
				0xC4, 0x46,
				0xB0,
				0x59,
				0x2E,
				0xD1,
				0x55,
				0x86,
				0xA6,
				0xAC
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11RasterizerState2));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11RasterizerState2));
#endif

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
		((delegate* unmanaged[Stdcall]<ID3D11RasterizerState2*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11RasterizerState2*)Unsafe.AsPointer(ref this), ppDevice);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11RasterizerState2*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11RasterizerState2*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11RasterizerState2*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11RasterizerState2*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11RasterizerState2*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11RasterizerState2*)Unsafe.AsPointer(ref this), guid, pData);
	}

	/// <inheritdoc cref="ID3D11RasterizerState.GetDesc" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public void GetDesc(RasterizerDescription* pDesc)
	{
		((delegate* unmanaged[Stdcall]<ID3D11RasterizerState2*, RasterizerDescription*, void>)(lpVtbl[7]))((ID3D11RasterizerState2*)Unsafe.AsPointer(ref this), pDesc);
	}

	/// <inheritdoc cref="ID3D11RasterizerState1.GetDesc1" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public void GetDesc1(RasterizerDescription1* pDesc)
	{
		((delegate* unmanaged[Stdcall]<ID3D11RasterizerState2*, RasterizerDescription1*, void>)(lpVtbl[8]))((ID3D11RasterizerState2*)Unsafe.AsPointer(ref this), pDesc);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11RasterizerState2::GetDesc2"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public void GetDesc2(RasterizerDescription2* pDesc)
	{
		((delegate* unmanaged[Stdcall]<ID3D11RasterizerState2*, RasterizerDescription2*, void>)(lpVtbl[9]))((ID3D11RasterizerState2*)Unsafe.AsPointer(ref this), pDesc);
	}
}
