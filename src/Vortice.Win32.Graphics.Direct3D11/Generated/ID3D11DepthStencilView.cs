// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11DepthStencilView"]/*' />
/// <unmanaged>ID3D11DepthStencilView</unmanaged>
[Guid("9fdac92a-1876-48c3-afad-25b94f84a9b6")]
[NativeTypeName("struct ID3D11DepthStencilView : ID3D11View")]
[NativeInheritance("ID3D11View")]
public unsafe partial struct ID3D11DepthStencilView : ID3D11DepthStencilView.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D11DepthStencilView
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x2A, 0xC9, 0xDA, 0x9F,
				0x76, 0x18,
				0xC3, 0x48,
				0xAF,
				0xAD,
				0x25,
				0xB9,
				0x4F,
				0x84,
				0xA9,
				0xB6
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11DepthStencilView));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11DepthStencilView*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11DepthStencilView*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11DepthStencilView*, uint>)(lpVtbl[1]))((ID3D11DepthStencilView*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11DepthStencilView*, uint>)(lpVtbl[2]))((ID3D11DepthStencilView*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetDevice(ID3D11Device** ppDevice)
	{
		((delegate* unmanaged[MemberFunction]<ID3D11DepthStencilView*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11DepthStencilView*)Unsafe.AsPointer(ref this), ppDevice);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11DepthStencilView*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11DepthStencilView*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11DepthStencilView*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11DepthStencilView*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11DepthStencilView*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11DepthStencilView*)Unsafe.AsPointer(ref this), guid, pData);
	}

	/// <inheritdoc cref="ID3D11View.GetResource" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public void GetResource(ID3D11Resource** ppResource)
	{
		((delegate* unmanaged[MemberFunction]<ID3D11DepthStencilView*, ID3D11Resource**, void>)(lpVtbl[7]))((ID3D11DepthStencilView*)Unsafe.AsPointer(ref this), ppResource);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11DepthStencilView::GetDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public void GetDesc(DepthStencilViewDescription* pDesc)
	{
		((delegate* unmanaged[MemberFunction]<ID3D11DepthStencilView*, DepthStencilViewDescription*, void>)(lpVtbl[8]))((ID3D11DepthStencilView*)Unsafe.AsPointer(ref this), pDesc);
	}

	public interface Interface : ID3D11View.Interface
	{
		[VtblIndex(8)]
		void GetDesc(DepthStencilViewDescription* pDesc);
	}
}

