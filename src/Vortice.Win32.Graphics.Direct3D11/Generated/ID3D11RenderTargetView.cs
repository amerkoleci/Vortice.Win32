// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11RenderTargetView"]/*' />
/// <unmanaged>ID3D11RenderTargetView</unmanaged>
[Guid("dfdba067-0b8d-4865-875b-d7b4516cc164")]
[NativeTypeName("struct ID3D11RenderTargetView : ID3D11View")]
[NativeInheritance("ID3D11View")]
public unsafe partial struct ID3D11RenderTargetView : INativeGuid
{
	public static ref readonly Guid IID_ID3D11RenderTargetView
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x67, 0xA0, 0xDB, 0xDF,
				0x8D, 0x0B,
				0x65, 0x48,
				0x87,
				0x5B,
				0xD7,
				0xB4,
				0x51,
				0x6C,
				0xC1,
				0x64
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11RenderTargetView));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11RenderTargetView));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11RenderTargetView*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11RenderTargetView*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11RenderTargetView*, uint>)(lpVtbl[1]))((ID3D11RenderTargetView*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11RenderTargetView*, uint>)(lpVtbl[2]))((ID3D11RenderTargetView*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetDevice(ID3D11Device** ppDevice)
	{
		((delegate* unmanaged[Stdcall]<ID3D11RenderTargetView*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11RenderTargetView*)Unsafe.AsPointer(ref this), ppDevice);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11RenderTargetView*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11RenderTargetView*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11RenderTargetView*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11RenderTargetView*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11RenderTargetView*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11RenderTargetView*)Unsafe.AsPointer(ref this), guid, pData);
	}

	/// <inheritdoc cref="ID3D11View.GetResource" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public void GetResource(ID3D11Resource** ppResource)
	{
		((delegate* unmanaged[Stdcall]<ID3D11RenderTargetView*, ID3D11Resource**, void>)(lpVtbl[7]))((ID3D11RenderTargetView*)Unsafe.AsPointer(ref this), ppResource);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11RenderTargetView::GetDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public void GetDesc(RenderTargetViewDescription* pDesc)
	{
		((delegate* unmanaged[Stdcall]<ID3D11RenderTargetView*, RenderTargetViewDescription*, void>)(lpVtbl[8]))((ID3D11RenderTargetView*)Unsafe.AsPointer(ref this), pDesc);
	}
}

