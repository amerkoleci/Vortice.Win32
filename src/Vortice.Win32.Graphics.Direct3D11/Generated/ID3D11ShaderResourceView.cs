// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderResourceView"]/*' />
/// <unmanaged>ID3D11ShaderResourceView</unmanaged>
[Guid("b0e06fe0-8192-4e1a-b1ca-36d7414710b2")]
[NativeTypeName("struct ID3D11ShaderResourceView : ID3D11View")]
[NativeInheritance("ID3D11View")]
public unsafe partial struct ID3D11ShaderResourceView : ID3D11ShaderResourceView.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D11ShaderResourceView
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xE0, 0x6F, 0xE0, 0xB0,
				0x92, 0x81,
				0x1A, 0x4E,
				0xB1,
				0xCA,
				0x36,
				0xD7,
				0x41,
				0x47,
				0x10,
				0xB2
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11ShaderResourceView));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderResourceView*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11ShaderResourceView*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderResourceView*, uint>)(lpVtbl[1]))((ID3D11ShaderResourceView*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderResourceView*, uint>)(lpVtbl[2]))((ID3D11ShaderResourceView*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetDevice(ID3D11Device** ppDevice)
	{
		((delegate* unmanaged[MemberFunction]<ID3D11ShaderResourceView*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11ShaderResourceView*)Unsafe.AsPointer(ref this), ppDevice);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderResourceView*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11ShaderResourceView*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderResourceView*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11ShaderResourceView*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderResourceView*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11ShaderResourceView*)Unsafe.AsPointer(ref this), guid, pData);
	}

	/// <inheritdoc cref="ID3D11View.GetResource" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public void GetResource(ID3D11Resource** ppResource)
	{
		((delegate* unmanaged[MemberFunction]<ID3D11ShaderResourceView*, ID3D11Resource**, void>)(lpVtbl[7]))((ID3D11ShaderResourceView*)Unsafe.AsPointer(ref this), ppResource);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderResourceView::GetDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public void GetDesc(ShaderResourceViewDescription* pDesc)
	{
		((delegate* unmanaged[MemberFunction]<ID3D11ShaderResourceView*, ShaderResourceViewDescription*, void>)(lpVtbl[8]))((ID3D11ShaderResourceView*)Unsafe.AsPointer(ref this), pDesc);
	}

	public interface Interface : ID3D11View.Interface
	{
		[VtblIndex(8)]
		void GetDesc(ShaderResourceViewDescription* pDesc);
	}
}

