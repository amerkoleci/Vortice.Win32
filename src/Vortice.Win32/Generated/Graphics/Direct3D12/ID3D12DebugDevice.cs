// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12DebugDevice"]/*' />
/// <unmanaged>ID3D12DebugDevice</unmanaged>
[Guid("3febd6dd-4973-4787-8194-e45f9e28923e")]
[NativeTypeName("struct ID3D12DebugDevice : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12DebugDevice
{
	public static ref readonly Guid IID_ID3D12DebugDevice
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xDD, 0xD6, 0xEB, 0x3F,
				0x73, 0x49,
				0x87, 0x47,
				0x81,
				0x94,
				0xE4,
				0x5F,
				0x9E,
				0x28,
				0x92,
				0x3E
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DebugDevice));

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

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12DebugDevice::SetFeatureMask"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetFeatureMask(DebugFeature Mask)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice*, DebugFeature, int>)(lpVtbl[3]))((ID3D12DebugDevice*)Unsafe.AsPointer(ref this), Mask);
	}

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12DebugDevice::GetFeatureMask"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public DebugFeature GetFeatureMask()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice*, DebugFeature>)(lpVtbl[4]))((ID3D12DebugDevice*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12DebugDevice::ReportLiveDeviceObjects"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult ReportLiveDeviceObjects(ReportLiveDeviceObjectFlags Flags)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12DebugDevice*, ReportLiveDeviceObjectFlags, int>)(lpVtbl[5]))((ID3D12DebugDevice*)Unsafe.AsPointer(ref this), Flags);
	}
}

