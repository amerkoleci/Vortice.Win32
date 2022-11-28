// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12DebugDevice1"]/*' />
/// <unmanaged>ID3D12DebugDevice1</unmanaged>
[Guid("a9b71770-d099-4a65-a698-3dee10020f88")]
[NativeTypeName("struct ID3D12DebugDevice1 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12DebugDevice1 : INativeGuid
{
	public static ref readonly Guid IID_ID3D12DebugDevice1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x70, 0x17, 0xB7, 0xA9,
				0x99, 0xD0,
				0x65, 0x4A,
				0xA6,
				0x98,
				0x3D,
				0xEE,
				0x10,
				0x02,
				0x0F,
				0x88
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DebugDevice1));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DebugDevice1));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12DebugDevice1*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice1*, uint>)(lpVtbl[1]))((ID3D12DebugDevice1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice1*, uint>)(lpVtbl[2]))((ID3D12DebugDevice1*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12DebugDevice1::SetDebugParameter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetDebugParameter(DebugDeviceParameterType Type, void* pData, uint DataSize)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice1*, DebugDeviceParameterType, void*, uint, int>)(lpVtbl[3]))((ID3D12DebugDevice1*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12DebugDevice1::GetDebugParameter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetDebugParameter(DebugDeviceParameterType Type, void* pData, uint DataSize)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice1*, DebugDeviceParameterType, void*, uint, int>)(lpVtbl[4]))((ID3D12DebugDevice1*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12DebugDevice1::ReportLiveDeviceObjects"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult ReportLiveDeviceObjects(ReportLiveDeviceObjectFlags Flags)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice1*, ReportLiveDeviceObjectFlags, int>)(lpVtbl[5]))((ID3D12DebugDevice1*)Unsafe.AsPointer(ref this), Flags);
	}
}

