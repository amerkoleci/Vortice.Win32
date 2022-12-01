// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Dxgi;

/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIOutput3"]/*' />
/// <unmanaged>IDXGIOutput3</unmanaged>
[Guid("8a6bb301-7e7e-41f4-a8e0-5b32f7f99b18")]
[NativeTypeName("struct IDXGIOutput3 : IDXGIOutput2")]
[NativeInheritance("IDXGIOutput2")]
public unsafe partial struct IDXGIOutput3 : IDXGIOutput3.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDXGIOutput3
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x01, 0xB3, 0x6B, 0x8A,
				0x7E, 0x7E,
				0xF4, 0x41,
				0xA8,
				0xE0,
				0x5B,
				0x32,
				0xF7,
				0xF9,
				0x9B,
				0x18
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIOutput3));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIOutput3));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, uint>)(lpVtbl[1]))((IDXGIOutput3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, uint>)(lpVtbl[2]))((IDXGIOutput3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetPrivateData(Guid* Name, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateDataInterface(Guid* Name, IUnknown* pUnknown)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), Name, pUnknown);
	}

	/// <inheritdoc cref="IDXGIObject.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.GetParent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetParent(Guid* riid, void** ppParent)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), riid, ppParent);
	}

	/// <inheritdoc cref="IDXGIOutput.GetDesc" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetDesc(OutputDescription* pDesc)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, OutputDescription*, int>)(lpVtbl[7]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), pDesc);
	}

	/// <inheritdoc cref="IDXGIOutput.GetDisplayModeList" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetDisplayModeList(Common.Format EnumFormat, EnumModesFlags Flags, uint* pNumModes, Common.ModeDescription* pDesc)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Common.Format, EnumModesFlags, uint*, Common.ModeDescription*, int>)(lpVtbl[8]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), EnumFormat, Flags, pNumModes, pDesc);
	}

	/// <inheritdoc cref="IDXGIOutput.FindClosestMatchingMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult FindClosestMatchingMode(Common.ModeDescription* pModeToMatch, Common.ModeDescription* pClosestMatch, IUnknown* pConcernedDevice)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Common.ModeDescription*, Common.ModeDescription*, IUnknown*, int>)(lpVtbl[9]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), pModeToMatch, pClosestMatch, pConcernedDevice);
	}

	/// <inheritdoc cref="IDXGIOutput.WaitForVBlank" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult WaitForVBlank()
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, int>)(lpVtbl[10]))((IDXGIOutput3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDXGIOutput.TakeOwnership" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult TakeOwnership(IUnknown* pDevice, Bool32 Exclusive)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, IUnknown*, Bool32, int>)(lpVtbl[11]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), pDevice, Exclusive);
	}

	/// <inheritdoc cref="IDXGIOutput.ReleaseOwnership" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public void ReleaseOwnership()
	{
		((delegate* unmanaged[Stdcall]<IDXGIOutput3*, void>)(lpVtbl[12]))((IDXGIOutput3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDXGIOutput.GetGammaControlCapabilities" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult GetGammaControlCapabilities(Common.GammaControlCapabilities* pGammaCaps)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Common.GammaControlCapabilities*, int>)(lpVtbl[13]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), pGammaCaps);
	}

	/// <inheritdoc cref="IDXGIOutput.SetGammaControl" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult SetGammaControl(Common.GammaControl* pArray)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Common.GammaControl*, int>)(lpVtbl[14]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), pArray);
	}

	/// <inheritdoc cref="IDXGIOutput.GetGammaControl" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult GetGammaControl(Common.GammaControl* pArray)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Common.GammaControl*, int>)(lpVtbl[15]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), pArray);
	}

	/// <inheritdoc cref="IDXGIOutput.SetDisplaySurface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult SetDisplaySurface(IDXGISurface* pScanoutSurface)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, IDXGISurface*, int>)(lpVtbl[16]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), pScanoutSurface);
	}

	/// <inheritdoc cref="IDXGIOutput.GetDisplaySurfaceData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult GetDisplaySurfaceData(IDXGISurface* pDestination)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, IDXGISurface*, int>)(lpVtbl[17]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), pDestination);
	}

	/// <inheritdoc cref="IDXGIOutput.GetFrameStatistics" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult GetFrameStatistics(FrameStatistics* pStats)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, FrameStatistics*, int>)(lpVtbl[18]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), pStats);
	}

	/// <inheritdoc cref="IDXGIOutput1.GetDisplayModeList1" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult GetDisplayModeList1(Common.Format EnumFormat, uint Flags, uint* pNumModes, ModeDescription1* pDesc)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Common.Format, uint, uint*, ModeDescription1*, int>)(lpVtbl[19]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), EnumFormat, Flags, pNumModes, pDesc);
	}

	/// <inheritdoc cref="IDXGIOutput1.FindClosestMatchingMode1" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult FindClosestMatchingMode1(ModeDescription1* pModeToMatch, ModeDescription1* pClosestMatch, IUnknown* pConcernedDevice)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, ModeDescription1*, ModeDescription1*, IUnknown*, int>)(lpVtbl[20]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), pModeToMatch, pClosestMatch, pConcernedDevice);
	}

	/// <inheritdoc cref="IDXGIOutput1.GetDisplaySurfaceData1" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult GetDisplaySurfaceData1(IDXGIResource* pDestination)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, IDXGIResource*, int>)(lpVtbl[21]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), pDestination);
	}

	/// <inheritdoc cref="IDXGIOutput1.DuplicateOutput" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult DuplicateOutput(IUnknown* pDevice, IDXGIOutputDuplication** ppOutputDuplication)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, IUnknown*, IDXGIOutputDuplication**, int>)(lpVtbl[22]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), pDevice, ppOutputDuplication);
	}

	/// <inheritdoc cref="IDXGIOutput2.SupportsOverlays" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public Bool32 SupportsOverlays()
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Bool32>)(lpVtbl[23]))((IDXGIOutput3*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIOutput3::CheckOverlaySupport"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult CheckOverlaySupport(Common.Format EnumFormat, IUnknown* pConcernedDevice, uint* pFlags)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIOutput3*, Common.Format, IUnknown*, uint*, int>)(lpVtbl[24]))((IDXGIOutput3*)Unsafe.AsPointer(ref this), EnumFormat, pConcernedDevice, pFlags);
	}
	public interface Interface : IDXGIOutput2.Interface
	{
		[VtblIndex(24)]
		HResult CheckOverlaySupport(Common.Format EnumFormat, IUnknown* pConcernedDevice, uint* pFlags);
	}
}

