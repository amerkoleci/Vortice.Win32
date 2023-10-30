// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Dxgi;

/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIFactory"]/*' />
/// <unmanaged>IDXGIFactory</unmanaged>
[Guid("7b7166ec-21c7-44ae-b21a-c9ae321ae369")]
[NativeTypeName("struct IDXGIFactory : IDXGIObject")]
[NativeInheritance("IDXGIObject")]
public unsafe partial struct IDXGIFactory : IDXGIFactory.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDXGIFactory
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xEC, 0x66, 0x71, 0x7B,
				0xC7, 0x21,
				0xAE, 0x44,
				0xB2,
				0x1A,
				0xC9,
				0xAE,
				0x32,
				0x1A,
				0xE3,
				0x69
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIFactory));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory*, uint>)(lpVtbl[1]))((IDXGIFactory*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory*, uint>)(lpVtbl[2]))((IDXGIFactory*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetPrivateData(Guid* Name, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIFactory*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateDataInterface(Guid* Name, IUnknown* pUnknown)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIFactory*)Unsafe.AsPointer(ref this), Name, pUnknown);
	}

	/// <inheritdoc cref="IDXGIObject.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIFactory*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.GetParent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetParent(Guid* riid, void** ppParent)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIFactory*)Unsafe.AsPointer(ref this), riid, ppParent);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIFactory::EnumAdapters"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult EnumAdapters(uint Adapter, IDXGIAdapter** ppAdapter)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory*, uint, IDXGIAdapter**, int>)(lpVtbl[7]))((IDXGIFactory*)Unsafe.AsPointer(ref this), Adapter, ppAdapter);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIFactory::MakeWindowAssociation"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult MakeWindowAssociation(nint WindowHandle, WindowAssociationFlags Flags)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory*, nint, WindowAssociationFlags, int>)(lpVtbl[8]))((IDXGIFactory*)Unsafe.AsPointer(ref this), WindowHandle, Flags);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIFactory::GetWindowAssociation"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetWindowAssociation(nint* pWindowHandle)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory*, nint*, int>)(lpVtbl[9]))((IDXGIFactory*)Unsafe.AsPointer(ref this), pWindowHandle);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIFactory::CreateSwapChain"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult CreateSwapChain(IUnknown* pDevice, SwapChainDescription* pDesc, IDXGISwapChain** ppSwapChain)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory*, IUnknown*, SwapChainDescription*, IDXGISwapChain**, int>)(lpVtbl[10]))((IDXGIFactory*)Unsafe.AsPointer(ref this), pDevice, pDesc, ppSwapChain);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIFactory::CreateSoftwareAdapter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult CreateSoftwareAdapter(nint Module, IDXGIAdapter** ppAdapter)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIFactory*, nint, IDXGIAdapter**, int>)(lpVtbl[11]))((IDXGIFactory*)Unsafe.AsPointer(ref this), Module, ppAdapter);
	}

	public interface Interface : IDXGIObject.Interface
	{
		[VtblIndex(7)]
		HResult EnumAdapters(uint Adapter, IDXGIAdapter** ppAdapter);

		[VtblIndex(8)]
		HResult MakeWindowAssociation(nint WindowHandle, WindowAssociationFlags Flags);

		[VtblIndex(9)]
		HResult GetWindowAssociation(nint* pWindowHandle);

		[VtblIndex(10)]
		HResult CreateSwapChain(IUnknown* pDevice, SwapChainDescription* pDesc, IDXGISwapChain** ppSwapChain);

		[VtblIndex(11)]
		HResult CreateSoftwareAdapter(nint Module, IDXGIAdapter** ppAdapter);
	}
}

