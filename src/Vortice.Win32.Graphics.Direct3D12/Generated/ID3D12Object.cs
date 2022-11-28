// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12Object"]/*' />
/// <unmanaged>ID3D12Object</unmanaged>
[Guid("c4fec28f-7966-4e95-9f94-f431cb56c3b8")]
[NativeTypeName("struct ID3D12Object : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12Object : INativeGuid
{
	public static ref readonly Guid IID_ID3D12Object
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x8F, 0xC2, 0xFE, 0xC4,
				0x66, 0x79,
				0x95, 0x4E,
				0x9F,
				0x94,
				0xF4,
				0x31,
				0xCB,
				0x56,
				0xC3,
				0xB8
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12Object));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12Object));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Object*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12Object*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Object*, uint>)(lpVtbl[1]))((ID3D12Object*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Object*, uint>)(lpVtbl[2]))((ID3D12Object*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12Object::GetPrivateData"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Object*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12Object*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12Object::SetPrivateData"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Object*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12Object*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12Object::SetPrivateDataInterface"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Object*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12Object*)Unsafe.AsPointer(ref this), guid, pData);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12Object::SetName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetName(ushort* Name)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Object*, ushort*, int>)(lpVtbl[6]))((ID3D12Object*)Unsafe.AsPointer(ref this), Name);
	}
}

