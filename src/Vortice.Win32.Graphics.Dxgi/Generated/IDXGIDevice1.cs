// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Dxgi;

/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDevice1"]/*' />
/// <unmanaged>IDXGIDevice1</unmanaged>
[Guid("77db970f-6276-48ba-ba28-070143b4392c")]
[NativeTypeName("struct IDXGIDevice1 : IDXGIDevice")]
[NativeInheritance("IDXGIDevice")]
public unsafe partial struct IDXGIDevice1 : IDXGIDevice1.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDXGIDevice1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x0F, 0x97, 0xDB, 0x77,
				0x76, 0x62,
				0xBA, 0x48,
				0xBA,
				0x28,
				0x07,
				0x01,
				0x43,
				0xB4,
				0x39,
				0x2C
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIDevice1));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIDevice1*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIDevice1*, uint>)(lpVtbl[1]))((IDXGIDevice1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIDevice1*, uint>)(lpVtbl[2]))((IDXGIDevice1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetPrivateData(Guid* Name, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIDevice1*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateDataInterface(Guid* Name, IUnknown* pUnknown)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIDevice1*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), Name, pUnknown);
	}

	/// <inheritdoc cref="IDXGIObject.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIDevice1*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.GetParent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetParent(Guid* riid, void** ppParent)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIDevice1*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), riid, ppParent);
	}

	/// <inheritdoc cref="IDXGIDevice.GetAdapter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetAdapter(IDXGIAdapter** pAdapter)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIDevice1*, IDXGIAdapter**, int>)(lpVtbl[7]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), pAdapter);
	}

	/// <inheritdoc cref="IDXGIDevice.CreateSurface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateSurface(SurfaceDescription* pDesc, uint NumSurfaces, Usage Usage, SharedResource* pSharedResource, IDXGISurface** ppSurface)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIDevice1*, SurfaceDescription*, uint, Usage, SharedResource*, IDXGISurface**, int>)(lpVtbl[8]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), pDesc, NumSurfaces, Usage, pSharedResource, ppSurface);
	}

	/// <inheritdoc cref="IDXGIDevice.QueryResourceResidency" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult QueryResourceResidency(IUnknown** ppResources, Residency* pResidencyStatus, uint NumResources)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIDevice1*, IUnknown**, Residency*, uint, int>)(lpVtbl[9]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), ppResources, pResidencyStatus, NumResources);
	}

	/// <inheritdoc cref="IDXGIDevice.SetGPUThreadPriority" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetGPUThreadPriority(int Priority)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIDevice1*, int, int>)(lpVtbl[10]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), Priority);
	}

	/// <inheritdoc cref="IDXGIDevice.GetGPUThreadPriority" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetGPUThreadPriority(int* pPriority)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIDevice1*, int*, int>)(lpVtbl[11]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), pPriority);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDevice1::SetMaximumFrameLatency"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult SetMaximumFrameLatency(uint MaxLatency)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIDevice1*, uint, int>)(lpVtbl[12]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), MaxLatency);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDevice1::GetMaximumFrameLatency"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult GetMaximumFrameLatency(uint* pMaxLatency)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIDevice1*, uint*, int>)(lpVtbl[13]))((IDXGIDevice1*)Unsafe.AsPointer(ref this), pMaxLatency);
	}

	public interface Interface : IDXGIDevice.Interface
	{
		[VtblIndex(12)]
		HResult SetMaximumFrameLatency(uint MaxLatency);

		[VtblIndex(13)]
		HResult GetMaximumFrameLatency(uint* pMaxLatency);
	}
}

