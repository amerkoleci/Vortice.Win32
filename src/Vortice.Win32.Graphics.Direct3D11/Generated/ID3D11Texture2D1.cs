// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Texture2D1"]/*' />
/// <unmanaged>ID3D11Texture2D1</unmanaged>
[Guid("51218251-1e33-4617-9ccb-4d3a4367e7bb")]
[NativeTypeName("struct ID3D11Texture2D1 : ID3D11Texture2D")]
[NativeInheritance("ID3D11Texture2D")]
public unsafe partial struct ID3D11Texture2D1 : ID3D11Texture2D1.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D11Texture2D1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x51, 0x82, 0x21, 0x51,
				0x33, 0x1E,
				0x17, 0x46,
				0x9C,
				0xCB,
				0x4D,
				0x3A,
				0x43,
				0x67,
				0xE7,
				0xBB
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Texture2D1));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11Texture2D1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11Texture2D1*, uint>)(lpVtbl[1]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11Texture2D1*, uint>)(lpVtbl[2]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetDevice(ID3D11Device** ppDevice)
	{
		((delegate* unmanaged[MemberFunction]<ID3D11Texture2D1*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), ppDevice);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11Texture2D1*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11Texture2D1*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11Texture2D1*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), guid, pData);
	}

	/// <inheritdoc cref="ID3D11Resource.GetType" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public void GetType(ResourceDimension* pResourceDimension)
	{
		((delegate* unmanaged[MemberFunction]<ID3D11Texture2D1*, ResourceDimension*, void>)(lpVtbl[7]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), pResourceDimension);
	}

	/// <inheritdoc cref="ID3D11Resource.SetEvictionPriority" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public void SetEvictionPriority(uint EvictionPriority)
	{
		((delegate* unmanaged[MemberFunction]<ID3D11Texture2D1*, uint, void>)(lpVtbl[8]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), EvictionPriority);
	}

	/// <inheritdoc cref="ID3D11Resource.GetEvictionPriority" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public uint GetEvictionPriority()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11Texture2D1*, uint>)(lpVtbl[9]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D11Texture2D.GetDesc" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public void GetDesc(Texture2DDescription* pDesc)
	{
		((delegate* unmanaged[MemberFunction]<ID3D11Texture2D1*, Texture2DDescription*, void>)(lpVtbl[10]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), pDesc);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Texture2D1::GetDesc1"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public void GetDesc1(Texture2DDescription1* pDesc)
	{
		((delegate* unmanaged[MemberFunction]<ID3D11Texture2D1*, Texture2DDescription1*, void>)(lpVtbl[11]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), pDesc);
	}

	public interface Interface : ID3D11Texture2D.Interface
	{
		[VtblIndex(11)]
		void GetDesc1(Texture2DDescription1* pDesc);
	}
}

