// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Device3"]/*' />
/// <unmanaged>ID2D1Device3</unmanaged>
[Guid("852f2087-802c-4037-ab60-ff2e7ee6fc01")]
[NativeTypeName("struct ID2D1Device3 : ID2D1Device2")]
[NativeInheritance("ID2D1Device2")]
public unsafe partial struct ID2D1Device3 : INativeGuid
{
	public static ref readonly Guid IID_ID2D1Device3
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x87, 0x20, 0x2F, 0x85,
				0x2C, 0x80,
				0x37, 0x40,
				0xAB,
				0x60,
				0xFF,
				0x2E,
				0x7E,
				0xE6,
				0xFC,
				0x01
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1Device3));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1Device3));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Device3*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1Device3*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Device3*, uint>)(lpVtbl[1]))((ID2D1Device3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Device3*, uint>)(lpVtbl[2]))((ID2D1Device3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1Resource.GetFactory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetFactory(ID2D1Factory** factory)
	{
		((delegate* unmanaged[Stdcall]<ID2D1Device3*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1Device3*)Unsafe.AsPointer(ref this), factory);
	}

	/// <inheritdoc cref="ID2D1Device.CreateDeviceContext" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult CreateDeviceContext(DeviceContextOptions options, ID2D1DeviceContext** deviceContext)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Device3*, DeviceContextOptions, ID2D1DeviceContext**, int>)(lpVtbl[4]))((ID2D1Device3*)Unsafe.AsPointer(ref this), options, deviceContext);
	}

	/// <inheritdoc cref="ID2D1Device.SetMaximumTextureMemory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public void SetMaximumTextureMemory(ulong maximumInBytes)
	{
		((delegate* unmanaged[Stdcall]<ID2D1Device3*, ulong, void>)(lpVtbl[5]))((ID2D1Device3*)Unsafe.AsPointer(ref this), maximumInBytes);
	}

	/// <inheritdoc cref="ID2D1Device.GetMaximumTextureMemory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public ulong GetMaximumTextureMemory()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Device3*, ulong>)(lpVtbl[6]))((ID2D1Device3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1Device.ClearResources" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public void ClearResources(uint millisecondsSinceUse)
	{
		((delegate* unmanaged[Stdcall]<ID2D1Device3*, uint, void>)(lpVtbl[7]))((ID2D1Device3*)Unsafe.AsPointer(ref this), millisecondsSinceUse);
	}

	/// <inheritdoc cref="ID2D1Device1.GetRenderingPriority" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public RenderingPriority GetRenderingPriority()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Device3*, RenderingPriority>)(lpVtbl[8]))((ID2D1Device3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1Device1.SetRenderingPriority" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public void SetRenderingPriority(RenderingPriority renderingPriority)
	{
		((delegate* unmanaged[Stdcall]<ID2D1Device3*, RenderingPriority, void>)(lpVtbl[9]))((ID2D1Device3*)Unsafe.AsPointer(ref this), renderingPriority);
	}

	/// <inheritdoc cref="ID2D1Device1.CreateDeviceContext" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult CreateDeviceContext(DeviceContextOptions options, ID2D1DeviceContext1** deviceContext1)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Device3*, DeviceContextOptions, ID2D1DeviceContext1**, int>)(lpVtbl[10]))((ID2D1Device3*)Unsafe.AsPointer(ref this), options, deviceContext1);
	}

	/// <inheritdoc cref="ID2D1Device2.CreateDeviceContext" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult CreateDeviceContext(DeviceContextOptions options, ID2D1DeviceContext2** deviceContext2)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Device3*, DeviceContextOptions, ID2D1DeviceContext2**, int>)(lpVtbl[11]))((ID2D1Device3*)Unsafe.AsPointer(ref this), options, deviceContext2);
	}

	/// <inheritdoc cref="ID2D1Device2.FlushDeviceContexts" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public void FlushDeviceContexts(ID2D1Bitmap* bitmap)
	{
		((delegate* unmanaged[Stdcall]<ID2D1Device3*, ID2D1Bitmap*, void>)(lpVtbl[12]))((ID2D1Device3*)Unsafe.AsPointer(ref this), bitmap);
	}

	/// <inheritdoc cref="ID2D1Device2.GetDxgiDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult GetDxgiDevice(Graphics.Dxgi.IDXGIDevice** dxgiDevice)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Device3*, Graphics.Dxgi.IDXGIDevice**, int>)(lpVtbl[13]))((ID2D1Device3*)Unsafe.AsPointer(ref this), dxgiDevice);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1Device3::CreateDeviceContext"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult CreateDeviceContext(DeviceContextOptions options, ID2D1DeviceContext3** deviceContext3)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Device3*, DeviceContextOptions, ID2D1DeviceContext3**, int>)(lpVtbl[14]))((ID2D1Device3*)Unsafe.AsPointer(ref this), options, deviceContext3);
	}
}

