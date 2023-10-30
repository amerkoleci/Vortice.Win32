// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Dxgi;

/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIFactory7"]/*' />
/// <unmanaged>IDXGIFactory7</unmanaged>
[Guid("a4966eed-76db-44da-84c1-ee9a7afb20a8")]
[NativeTypeName("struct IDXGIFactory7 : IDXGIFactory6")]
[NativeInheritance("IDXGIFactory6")]
public unsafe partial struct IDXGIFactory7 : IDXGIFactory7.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDXGIFactory7
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xED, 0x6E, 0x96, 0xA4,
				0xDB, 0x76,
				0xDA, 0x44,
				0x84,
				0xC1,
				0xEE,
				0x9A,
				0x7A,
				0xFB,
				0x20,
				0xA8
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIFactory7));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory7*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory7*, uint>)(lpVtbl[1]))((IDXGIFactory7*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory7*, uint>)(lpVtbl[2]))((IDXGIFactory7*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetPrivateData(Guid* Name, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory7*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateDataInterface(Guid* Name, IUnknown* pUnknown)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory7*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), Name, pUnknown);
	}

	/// <inheritdoc cref="IDXGIObject.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory7*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.GetParent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetParent(Guid* riid, void** ppParent)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory7*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), riid, ppParent);
	}

	/// <inheritdoc cref="IDXGIFactory.EnumAdapters" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult EnumAdapters(uint Adapter, IDXGIAdapter** ppAdapter)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory7*, uint, IDXGIAdapter**, int>)(lpVtbl[7]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), Adapter, ppAdapter);
	}

	/// <inheritdoc cref="IDXGIFactory.MakeWindowAssociation" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult MakeWindowAssociation(nint WindowHandle, WindowAssociationFlags Flags)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory7*, nint, WindowAssociationFlags, int>)(lpVtbl[8]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), WindowHandle, Flags);
	}

	/// <inheritdoc cref="IDXGIFactory.GetWindowAssociation" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetWindowAssociation(nint* pWindowHandle)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory7*, nint*, int>)(lpVtbl[9]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), pWindowHandle);
	}

	/// <inheritdoc cref="IDXGIFactory.CreateSwapChain" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult CreateSwapChain(IUnknown* pDevice, SwapChainDescription* pDesc, IDXGISwapChain** ppSwapChain)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory7*, IUnknown*, SwapChainDescription*, IDXGISwapChain**, int>)(lpVtbl[10]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), pDevice, pDesc, ppSwapChain);
	}

	/// <inheritdoc cref="IDXGIFactory.CreateSoftwareAdapter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult CreateSoftwareAdapter(nint Module, IDXGIAdapter** ppAdapter)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory7*, nint, IDXGIAdapter**, int>)(lpVtbl[11]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), Module, ppAdapter);
	}

	/// <inheritdoc cref="IDXGIFactory1.EnumAdapters1" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult EnumAdapters1(uint Adapter, IDXGIAdapter1** ppAdapter)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory7*, uint, IDXGIAdapter1**, int>)(lpVtbl[12]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), Adapter, ppAdapter);
	}

	/// <inheritdoc cref="IDXGIFactory1.IsCurrent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public Bool32 IsCurrent()
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory7*, Bool32>)(lpVtbl[13]))((IDXGIFactory7*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDXGIFactory2.IsWindowedStereoEnabled" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public Bool32 IsWindowedStereoEnabled()
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory7*, Bool32>)(lpVtbl[14]))((IDXGIFactory7*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDXGIFactory2.CreateSwapChainForHwnd" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult CreateSwapChainForHwnd(IUnknown* pDevice, nint hWnd, SwapChainDescription1* pDesc, SwapChainFullscreenDescription* pFullscreenDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory7*, IUnknown*, nint, SwapChainDescription1*, SwapChainFullscreenDescription*, IDXGIOutput*, IDXGISwapChain1**, int>)(lpVtbl[15]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
	}

	/// <inheritdoc cref="IDXGIFactory2.CreateSwapChainForCoreWindow" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult CreateSwapChainForCoreWindow(IUnknown* pDevice, IUnknown* pWindow, SwapChainDescription1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory7*, IUnknown*, IUnknown*, SwapChainDescription1*, IDXGIOutput*, IDXGISwapChain1**, int>)(lpVtbl[16]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), pDevice, pWindow, pDesc, pRestrictToOutput, ppSwapChain);
	}

	/// <inheritdoc cref="IDXGIFactory2.GetSharedResourceAdapterLuid" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult GetSharedResourceAdapterLuid(Handle hResource, Luid* pLuid)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory7*, Handle, Luid*, int>)(lpVtbl[17]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), hResource, pLuid);
	}

	/// <inheritdoc cref="IDXGIFactory2.RegisterStereoStatusWindow" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult RegisterStereoStatusWindow(nint WindowHandle, uint wMsg, uint* pdwCookie)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory7*, nint, uint, uint*, int>)(lpVtbl[18]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), WindowHandle, wMsg, pdwCookie);
	}

	/// <inheritdoc cref="IDXGIFactory2.RegisterStereoStatusEvent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult RegisterStereoStatusEvent(Handle hEvent, uint* pdwCookie)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory7*, Handle, uint*, int>)(lpVtbl[19]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), hEvent, pdwCookie);
	}

	/// <inheritdoc cref="IDXGIFactory2.UnregisterStereoStatus" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public void UnregisterStereoStatus(uint dwCookie)
	{
		((delegate* unmanaged[MemberFunction]<IDXGIFactory7*, uint, void>)(lpVtbl[20]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), dwCookie);
	}

	/// <inheritdoc cref="IDXGIFactory2.RegisterOcclusionStatusWindow" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult RegisterOcclusionStatusWindow(nint WindowHandle, uint wMsg, uint* pdwCookie)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory7*, nint, uint, uint*, int>)(lpVtbl[21]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), WindowHandle, wMsg, pdwCookie);
	}

	/// <inheritdoc cref="IDXGIFactory2.RegisterOcclusionStatusEvent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult RegisterOcclusionStatusEvent(Handle hEvent, uint* pdwCookie)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory7*, Handle, uint*, int>)(lpVtbl[22]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), hEvent, pdwCookie);
	}

	/// <inheritdoc cref="IDXGIFactory2.UnregisterOcclusionStatus" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public void UnregisterOcclusionStatus(uint dwCookie)
	{
		((delegate* unmanaged[MemberFunction]<IDXGIFactory7*, uint, void>)(lpVtbl[23]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), dwCookie);
	}

	/// <inheritdoc cref="IDXGIFactory2.CreateSwapChainForComposition" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult CreateSwapChainForComposition(IUnknown* pDevice, SwapChainDescription1* pDesc, IDXGIOutput* pRestrictToOutput, IDXGISwapChain1** ppSwapChain)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory7*, IUnknown*, SwapChainDescription1*, IDXGIOutput*, IDXGISwapChain1**, int>)(lpVtbl[24]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), pDevice, pDesc, pRestrictToOutput, ppSwapChain);
	}

	/// <inheritdoc cref="IDXGIFactory3.GetCreationFlags" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public uint GetCreationFlags()
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory7*, uint>)(lpVtbl[25]))((IDXGIFactory7*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDXGIFactory4.EnumAdapterByLuid" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public HResult EnumAdapterByLuid(Luid AdapterLuid, Guid* riid, void** ppvAdapter)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory7*, Luid, Guid*, void**, int>)(lpVtbl[26]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), AdapterLuid, riid, ppvAdapter);
	}

	/// <inheritdoc cref="IDXGIFactory4.EnumWarpAdapter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public HResult EnumWarpAdapter(Guid* riid, void** ppvAdapter)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory7*, Guid*, void**, int>)(lpVtbl[27]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), riid, ppvAdapter);
	}

	/// <inheritdoc cref="IDXGIFactory5.CheckFeatureSupport" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public HResult CheckFeatureSupport(Feature Feature, void* pFeatureSupportData, int FeatureSupportDataSize)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory7*, Feature, void*, int, int>)(lpVtbl[28]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), Feature, pFeatureSupportData, FeatureSupportDataSize);
	}

	/// <inheritdoc cref="IDXGIFactory6.EnumAdapterByGpuPreference" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(29)]
	public HResult EnumAdapterByGpuPreference(uint Adapter, GpuPreference GpuPreference, Guid* riid, void** ppvAdapter)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory7*, uint, GpuPreference, Guid*, void**, int>)(lpVtbl[29]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), Adapter, GpuPreference, riid, ppvAdapter);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIFactory7::RegisterAdaptersChangedEvent"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(30)]
	public HResult RegisterAdaptersChangedEvent(Handle hEvent, uint* pdwCookie)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory7*, Handle, uint*, int>)(lpVtbl[30]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), hEvent, pdwCookie);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIFactory7::UnregisterAdaptersChangedEvent"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(31)]
	public HResult UnregisterAdaptersChangedEvent(uint dwCookie)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory7*, uint, int>)(lpVtbl[31]))((IDXGIFactory7*)Unsafe.AsPointer(ref this), dwCookie);
	}

	public interface Interface : IDXGIFactory6.Interface
	{
		[VtblIndex(30)]
		HResult RegisterAdaptersChangedEvent(Handle hEvent, uint* pdwCookie);

		[VtblIndex(31)]
		HResult UnregisterAdaptersChangedEvent(uint dwCookie);
	}
}

