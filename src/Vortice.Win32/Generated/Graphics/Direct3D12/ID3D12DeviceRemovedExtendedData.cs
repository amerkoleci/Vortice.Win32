// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12DeviceRemovedExtendedData"]/*' />
/// <unmanaged>ID3D12DeviceRemovedExtendedData</unmanaged>
[Guid("98931d33-5ae8-4791-aa3c-1a73a2934e71")]
[NativeTypeName("struct ID3D12DeviceRemovedExtendedData : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12DeviceRemovedExtendedData
{
	public static ref readonly Guid IID_ID3D12DeviceRemovedExtendedData
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x33, 0x1D, 0x93, 0x98,
				0xE8, 0x5A,
				0x91, 0x47,
				0xAA,
				0x3C,
				0x1A,
				0x73,
				0xA2,
				0x93,
				0x4E,
				0x71
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DeviceRemovedExtendedData));

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

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12DeviceRemovedExtendedData::GetAutoBreadcrumbsOutput"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetAutoBreadcrumbsOutput(DredAutoBreadcrumbsOutput* pOutput)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData*, DredAutoBreadcrumbsOutput*, int>)(lpVtbl[3]))((ID3D12DeviceRemovedExtendedData*)Unsafe.AsPointer(ref this), pOutput);
	}

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12DeviceRemovedExtendedData::GetPageFaultAllocationOutput"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPageFaultAllocationOutput(DredPageFaultOutput* pOutput)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData*, DredPageFaultOutput*, int>)(lpVtbl[4]))((ID3D12DeviceRemovedExtendedData*)Unsafe.AsPointer(ref this), pOutput);
	}
}

