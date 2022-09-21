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

/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11Texture3D1"]/*' />
/// <unmanaged>ID3D11Texture3D1</unmanaged>
[Guid("0c711683-2853-4846-9bb0-f3e60639e46a")]
[NativeTypeName("struct ID3D11Texture3D1 : ID3D11Texture3D")]
[NativeInheritance("ID3D11Texture3D")]
public unsafe partial struct ID3D11Texture3D1
{
	public static ref readonly Guid IID_ID3D11Texture3D1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x83, 0x16, 0x71, 0x0C,
				0x53, 0x28,
				0x46, 0x48,
				0x9B,
				0xB0,
				0xF3,
				0xE6,
				0x06,
				0x39,
				0xE4,
				0x6A
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Texture3D1));

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
		((delegate* unmanaged[Stdcall]<ID3D11Texture3D1*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11Texture3D1*)Unsafe.AsPointer(ref this), ppDevice);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Texture3D1*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11Texture3D1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Texture3D1*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11Texture3D1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Texture3D1*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11Texture3D1*)Unsafe.AsPointer(ref this), guid, pData);
	}

	/// <inheritdoc cref="ID3D11Resource.GetType" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public void GetType(ResourceDimension* pResourceDimension)
	{
		((delegate* unmanaged[Stdcall]<ID3D11Texture3D1*, ResourceDimension*, void>)(lpVtbl[7]))((ID3D11Texture3D1*)Unsafe.AsPointer(ref this), pResourceDimension);
	}

	/// <inheritdoc cref="ID3D11Resource.SetEvictionPriority" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public void SetEvictionPriority(uint EvictionPriority)
	{
		((delegate* unmanaged[Stdcall]<ID3D11Texture3D1*, uint, void>)(lpVtbl[8]))((ID3D11Texture3D1*)Unsafe.AsPointer(ref this), EvictionPriority);
	}

	/// <inheritdoc cref="ID3D11Resource.GetEvictionPriority" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public uint GetEvictionPriority()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Texture3D1*, uint>)(lpVtbl[9]))((ID3D11Texture3D1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D11Texture3D.GetDesc" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public void GetDesc(Texture3DDescription* pDesc)
	{
		((delegate* unmanaged[Stdcall]<ID3D11Texture3D1*, Texture3DDescription*, void>)(lpVtbl[10]))((ID3D11Texture3D1*)Unsafe.AsPointer(ref this), pDesc);
	}

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11Texture3D1::GetDesc1"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public void GetDesc1(Texture3DDescription1* pDesc)
	{
		((delegate* unmanaged[Stdcall]<ID3D11Texture3D1*, Texture3DDescription1*, void>)(lpVtbl[11]))((ID3D11Texture3D1*)Unsafe.AsPointer(ref this), pDesc);
	}
}
