// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Counter"]/*' />
/// <unmanaged>ID3D11Counter</unmanaged>
[Guid("6e8c49fb-a371-4770-b440-29086022b741")]
[NativeTypeName("struct ID3D11Counter : ID3D11Asynchronous")]
[NativeInheritance("ID3D11Asynchronous")]
public unsafe partial struct ID3D11Counter : ID3D11Counter.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D11Counter
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xFB, 0x49, 0x8C, 0x6E,
				0x71, 0xA3,
				0x70, 0x47,
				0xB4,
				0x40,
				0x29,
				0x08,
				0x60,
				0x22,
				0xB7,
				0x41
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Counter));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Counter));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Counter*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11Counter*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Counter*, uint>)(lpVtbl[1]))((ID3D11Counter*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Counter*, uint>)(lpVtbl[2]))((ID3D11Counter*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetDevice(ID3D11Device** ppDevice)
	{
		((delegate* unmanaged[Stdcall]<ID3D11Counter*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11Counter*)Unsafe.AsPointer(ref this), ppDevice);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Counter*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11Counter*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Counter*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11Counter*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Counter*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11Counter*)Unsafe.AsPointer(ref this), guid, pData);
	}

	/// <inheritdoc cref="ID3D11Asynchronous.GetDataSize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public uint GetDataSize()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Counter*, uint>)(lpVtbl[7]))((ID3D11Counter*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Counter::GetDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public void GetDesc(CounterDescription* pDesc)
	{
		((delegate* unmanaged[Stdcall]<ID3D11Counter*, CounterDescription*, void>)(lpVtbl[8]))((ID3D11Counter*)Unsafe.AsPointer(ref this), pDesc);
	}
	public interface Interface : ID3D11Asynchronous.Interface
	{
		[VtblIndex(8)]
		void GetDesc(CounterDescription* pDesc);
	}
}

