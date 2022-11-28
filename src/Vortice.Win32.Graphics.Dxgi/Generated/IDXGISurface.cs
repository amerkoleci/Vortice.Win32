// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Dxgi;

/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGISurface"]/*' />
/// <unmanaged>IDXGISurface</unmanaged>
[Guid("cafcb56c-6ac3-4889-bf47-9e23bbd260ec")]
[NativeTypeName("struct IDXGISurface : IDXGIDeviceSubObject")]
[NativeInheritance("IDXGIDeviceSubObject")]
public unsafe partial struct IDXGISurface : INativeGuid
{
	public static ref readonly Guid IID_IDXGISurface
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x6C, 0xB5, 0xFC, 0xCA,
				0xC3, 0x6A,
				0x89, 0x48,
				0xBF,
				0x47,
				0x9E,
				0x23,
				0xBB,
				0xD2,
				0x60,
				0xEC
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGISurface));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGISurface));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISurface*, Guid*, void**, int>)(lpVtbl[0]))((IDXGISurface*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISurface*, uint>)(lpVtbl[1]))((IDXGISurface*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISurface*, uint>)(lpVtbl[2]))((IDXGISurface*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetPrivateData(Guid* Name, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISurface*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGISurface*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateDataInterface(Guid* Name, IUnknown* pUnknown)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISurface*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGISurface*)Unsafe.AsPointer(ref this), Name, pUnknown);
	}

	/// <inheritdoc cref="IDXGIObject.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISurface*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGISurface*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.GetParent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetParent(Guid* riid, void** ppParent)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISurface*, Guid*, void**, int>)(lpVtbl[6]))((IDXGISurface*)Unsafe.AsPointer(ref this), riid, ppParent);
	}

	/// <inheritdoc cref="IDXGIDeviceSubObject.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetDevice(Guid* riid, void** ppDevice)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISurface*, Guid*, void**, int>)(lpVtbl[7]))((IDXGISurface*)Unsafe.AsPointer(ref this), riid, ppDevice);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGISurface::GetDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetDesc(SurfaceDescription* pDesc)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISurface*, SurfaceDescription*, int>)(lpVtbl[8]))((IDXGISurface*)Unsafe.AsPointer(ref this), pDesc);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGISurface::Map"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult Map(MappedRect* pLockedRect, uint MapFlags)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISurface*, MappedRect*, uint, int>)(lpVtbl[9]))((IDXGISurface*)Unsafe.AsPointer(ref this), pLockedRect, MapFlags);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGISurface::Unmap"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult Unmap()
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISurface*, int>)(lpVtbl[10]))((IDXGISurface*)Unsafe.AsPointer(ref this));
	}
}

