// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11AuthenticatedChannel"]/*' />
/// <unmanaged>ID3D11AuthenticatedChannel</unmanaged>
[Guid("3015a308-dcbd-47aa-a747-192486d14d4a")]
[NativeTypeName("struct ID3D11AuthenticatedChannel : ID3D11DeviceChild")]
[NativeInheritance("ID3D11DeviceChild")]
public unsafe partial struct ID3D11AuthenticatedChannel : ID3D11AuthenticatedChannel.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D11AuthenticatedChannel
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x08, 0xA3, 0x15, 0x30,
				0xBD, 0xDC,
				0xAA, 0x47,
				0xA7,
				0x47,
				0x19,
				0x24,
				0x86,
				0xD1,
				0x4D,
				0x4A
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11AuthenticatedChannel));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11AuthenticatedChannel*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11AuthenticatedChannel*, uint>)(lpVtbl[1]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11AuthenticatedChannel*, uint>)(lpVtbl[2]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetDevice(ID3D11Device** ppDevice)
	{
		((delegate* unmanaged[MemberFunction]<ID3D11AuthenticatedChannel*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this), ppDevice);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11AuthenticatedChannel*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11AuthenticatedChannel*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11AuthenticatedChannel*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this), guid, pData);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11AuthenticatedChannel::GetCertificateSize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetCertificateSize(uint* pCertificateSize)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11AuthenticatedChannel*, uint*, int>)(lpVtbl[7]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this), pCertificateSize);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11AuthenticatedChannel::GetCertificate"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetCertificate(uint CertificateSize, byte* pCertificate)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11AuthenticatedChannel*, uint, byte*, int>)(lpVtbl[8]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this), CertificateSize, pCertificate);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11AuthenticatedChannel::GetChannelHandle"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public void GetChannelHandle(Handle* pChannelHandle)
	{
		((delegate* unmanaged[MemberFunction]<ID3D11AuthenticatedChannel*, Handle*, void>)(lpVtbl[9]))((ID3D11AuthenticatedChannel*)Unsafe.AsPointer(ref this), pChannelHandle);
	}

	public interface Interface : ID3D11DeviceChild.Interface
	{
		[VtblIndex(7)]
		HResult GetCertificateSize(uint* pCertificateSize);

		[VtblIndex(8)]
		HResult GetCertificate(uint CertificateSize, byte* pCertificate);

		[VtblIndex(9)]
		void GetChannelHandle(Handle* pChannelHandle);
	}
}

