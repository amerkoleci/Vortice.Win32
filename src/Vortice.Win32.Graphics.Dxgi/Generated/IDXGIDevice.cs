// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Dxgi;

/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDevice"]/*' />
/// <unmanaged>IDXGIDevice</unmanaged>
[Guid("54ec77fa-1377-44e6-8c32-88fd5f44c84c")]
[NativeTypeName("struct IDXGIDevice : IDXGIObject")]
[NativeInheritance("IDXGIObject")]
public unsafe partial struct IDXGIDevice : INativeGuid
{
	public static ref readonly Guid IID_IDXGIDevice
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xFA, 0x77, 0xEC, 0x54,
				0x77, 0x13,
				0xE6, 0x44,
				0x8C,
				0x32,
				0x88,
				0xFD,
				0x5F,
				0x44,
				0xC8,
				0x4C
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIDevice));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIDevice));
#endif

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

	/// <inheritdoc cref="IDXGIObject.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetPrivateData(Guid* Name, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIDevice*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateDataInterface(Guid* Name, IUnknown* pUnknown)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIDevice*)Unsafe.AsPointer(ref this), Name, pUnknown);
	}

	/// <inheritdoc cref="IDXGIObject.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIDevice*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.GetParent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetParent(Guid* riid, void** ppParent)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIDevice*)Unsafe.AsPointer(ref this), riid, ppParent);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDevice::GetAdapter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetAdapter(IDXGIAdapter** pAdapter)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice*, IDXGIAdapter**, int>)(lpVtbl[7]))((IDXGIDevice*)Unsafe.AsPointer(ref this), pAdapter);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDevice::CreateSurface"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateSurface(SurfaceDescription* pDesc, uint NumSurfaces, Usage Usage, SharedResource* pSharedResource, IDXGISurface** ppSurface)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice*, SurfaceDescription*, uint, Usage, SharedResource*, IDXGISurface**, int>)(lpVtbl[8]))((IDXGIDevice*)Unsafe.AsPointer(ref this), pDesc, NumSurfaces, Usage, pSharedResource, ppSurface);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDevice::QueryResourceResidency"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult QueryResourceResidency(IUnknown** ppResources, Residency* pResidencyStatus, uint NumResources)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice*, IUnknown**, Residency*, uint, int>)(lpVtbl[9]))((IDXGIDevice*)Unsafe.AsPointer(ref this), ppResources, pResidencyStatus, NumResources);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDevice::SetGPUThreadPriority"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetGPUThreadPriority(int Priority)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice*, int, int>)(lpVtbl[10]))((IDXGIDevice*)Unsafe.AsPointer(ref this), Priority);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDevice::GetGPUThreadPriority"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetGPUThreadPriority(int* pPriority)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDevice*, int*, int>)(lpVtbl[11]))((IDXGIDevice*)Unsafe.AsPointer(ref this), pPriority);
	}
}
