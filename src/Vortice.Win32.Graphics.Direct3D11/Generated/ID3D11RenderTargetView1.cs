// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11RenderTargetView1"]/*' />
/// <unmanaged>ID3D11RenderTargetView1</unmanaged>
[Guid("ffbe2e23-f011-418a-ac56-5ceed7c5b94b")]
[NativeTypeName("struct ID3D11RenderTargetView1 : ID3D11RenderTargetView")]
[NativeInheritance("ID3D11RenderTargetView")]
public unsafe partial struct ID3D11RenderTargetView1 : ID3D11RenderTargetView1.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D11RenderTargetView1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x23, 0x2E, 0xBE, 0xFF,
				0x11, 0xF0,
				0x8A, 0x41,
				0xAC,
				0x56,
				0x5C,
				0xEE,
				0xD7,
				0xC5,
				0xB9,
				0x4B
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11RenderTargetView1));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11RenderTargetView1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11RenderTargetView1*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11RenderTargetView1*, uint>)(lpVtbl[1]))((ID3D11RenderTargetView1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11RenderTargetView1*, uint>)(lpVtbl[2]))((ID3D11RenderTargetView1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetDevice(ID3D11Device** ppDevice)
	{
		((delegate* unmanaged[MemberFunction]<ID3D11RenderTargetView1*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11RenderTargetView1*)Unsafe.AsPointer(ref this), ppDevice);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11RenderTargetView1*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11RenderTargetView1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11RenderTargetView1*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11RenderTargetView1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11RenderTargetView1*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11RenderTargetView1*)Unsafe.AsPointer(ref this), guid, pData);
	}

	/// <inheritdoc cref="ID3D11View.GetResource" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public void GetResource(ID3D11Resource** ppResource)
	{
		((delegate* unmanaged[MemberFunction]<ID3D11RenderTargetView1*, ID3D11Resource**, void>)(lpVtbl[7]))((ID3D11RenderTargetView1*)Unsafe.AsPointer(ref this), ppResource);
	}

	/// <inheritdoc cref="ID3D11RenderTargetView.GetDesc" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public void GetDesc(RenderTargetViewDescription* pDesc)
	{
		((delegate* unmanaged[MemberFunction]<ID3D11RenderTargetView1*, RenderTargetViewDescription*, void>)(lpVtbl[8]))((ID3D11RenderTargetView1*)Unsafe.AsPointer(ref this), pDesc);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11RenderTargetView1::GetDesc1"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public void GetDesc1(RenderTargetViewDescription1* pDesc1)
	{
		((delegate* unmanaged[MemberFunction]<ID3D11RenderTargetView1*, RenderTargetViewDescription1*, void>)(lpVtbl[9]))((ID3D11RenderTargetView1*)Unsafe.AsPointer(ref this), pDesc1);
	}

	public interface Interface : ID3D11RenderTargetView.Interface
	{
		[VtblIndex(9)]
		void GetDesc1(RenderTargetViewDescription1* pDesc1);
	}
}

