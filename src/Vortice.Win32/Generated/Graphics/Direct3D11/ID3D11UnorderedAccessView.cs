// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11UnorderedAccessView"]/*' />
/// <unmanaged>ID3D11UnorderedAccessView</unmanaged>
[Guid("28acf509-7f5c-48f6-8611-f316010a6380")]
[NativeTypeName("struct ID3D11UnorderedAccessView : ID3D11View")]
[NativeInheritance("ID3D11View")]
public unsafe partial struct ID3D11UnorderedAccessView
{
	public static ref readonly Guid IID_ID3D11UnorderedAccessView
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x09, 0xF5, 0xAC, 0x28,
				0x5C, 0x7F,
				0xF6, 0x48,
				0x86,
				0x11,
				0xF3,
				0x16,
				0x01,
				0x0A,
				0x63,
				0x80
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11UnorderedAccessView));

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
		((delegate* unmanaged[Stdcall]<ID3D11UnorderedAccessView*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11UnorderedAccessView*)Unsafe.AsPointer(ref this), ppDevice);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11UnorderedAccessView*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11UnorderedAccessView*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11UnorderedAccessView*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11UnorderedAccessView*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11UnorderedAccessView*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11UnorderedAccessView*)Unsafe.AsPointer(ref this), guid, pData);
	}

	/// <inheritdoc cref="ID3D11View.GetResource" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public void GetResource(ID3D11Resource** ppResource)
	{
		((delegate* unmanaged[Stdcall]<ID3D11UnorderedAccessView*, ID3D11Resource**, void>)(lpVtbl[7]))((ID3D11UnorderedAccessView*)Unsafe.AsPointer(ref this), ppResource);
	}

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11UnorderedAccessView::GetDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public void GetDesc(UnorderedAccessViewDescription* pDesc)
	{
		((delegate* unmanaged[Stdcall]<ID3D11UnorderedAccessView*, UnorderedAccessViewDescription*, void>)(lpVtbl[8]))((ID3D11UnorderedAccessView*)Unsafe.AsPointer(ref this), pDesc);
	}
}

