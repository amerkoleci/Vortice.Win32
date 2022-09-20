// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------


#if !NET6_0_OR_GREATER
using MemoryMarshal = Win32.MemoryMarshal;
#endif

namespace Win32.Graphics.Direct3D11;

/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11VideoProcessor"]/*' />
/// <unmanaged>ID3D11VideoProcessor</unmanaged>
[Guid("1d7b0652-185f-41c6-85ce-0c5be3d4ae6c")]
[NativeTypeName("struct ID3D11VideoProcessor : ID3D11DeviceChild")]
[NativeInheritance("ID3D11DeviceChild")]
public unsafe partial struct ID3D11VideoProcessor
{
	public static ref readonly Guid IID_ID3D11VideoProcessor
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x52, 0x06, 0x7B, 0x1D,
				0x5F, 0x18,
				0xC6, 0x41,
				0x85,
				0xCE,
				0x0C,
				0x5B,
				0xE3,
				0xD4,
				0xAE,
				0x6C
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11VideoProcessor));

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
		((delegate* unmanaged[Stdcall]<ID3D11VideoProcessor*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11VideoProcessor*)Unsafe.AsPointer(ref this), ppDevice);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessor*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11VideoProcessor*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessor*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11VideoProcessor*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessor*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11VideoProcessor*)Unsafe.AsPointer(ref this), guid, pData);
	}

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11VideoProcessor::GetContentDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public void GetContentDesc(VideoProcessorContentDescription* pDesc)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoProcessor*, VideoProcessorContentDescription*, void>)(lpVtbl[7]))((ID3D11VideoProcessor*)Unsafe.AsPointer(ref this), pDesc);
	}

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11VideoProcessor::GetRateConversionCaps"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public void GetRateConversionCaps(VideoProcessorRateConversionCaps* pCaps)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoProcessor*, VideoProcessorRateConversionCaps*, void>)(lpVtbl[8]))((ID3D11VideoProcessor*)Unsafe.AsPointer(ref this), pCaps);
	}
}

