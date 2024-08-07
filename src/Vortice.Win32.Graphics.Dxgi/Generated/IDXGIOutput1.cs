// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Dxgi;

/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIOutput1"]/*' />
/// <unmanaged>IDXGIOutput1</unmanaged>
[Guid("00cddea8-939b-4b83-a340-a685226666cc")]
[NativeTypeName("struct IDXGIOutput1 : IDXGIOutput")]
[NativeInheritance("IDXGIOutput")]
public unsafe partial struct IDXGIOutput1 : IDXGIOutput1.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDXGIOutput1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xA8, 0xDE, 0xCD, 0x00,
				0x9B, 0x93,
				0x83, 0x4B,
				0xA3,
				0x40,
				0xA6,
				0x85,
				0x22,
				0x66,
				0x66,
				0xCC
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIOutput1));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIOutput1*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIOutput1*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIOutput1*, uint>)(lpVtbl[1]))((IDXGIOutput1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIOutput1*, uint>)(lpVtbl[2]))((IDXGIOutput1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetPrivateData(Guid* Name, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIOutput1*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIOutput1*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateDataInterface(Guid* Name, IUnknown* pUnknown)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIOutput1*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIOutput1*)Unsafe.AsPointer(ref this), Name, pUnknown);
	}

	/// <inheritdoc cref="IDXGIObject.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIOutput1*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIOutput1*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.GetParent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetParent(Guid* riid, void** ppParent)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIOutput1*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIOutput1*)Unsafe.AsPointer(ref this), riid, ppParent);
	}

	/// <inheritdoc cref="IDXGIOutput.GetDesc" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetDesc(OutputDescription* pDesc)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIOutput1*, OutputDescription*, int>)(lpVtbl[7]))((IDXGIOutput1*)Unsafe.AsPointer(ref this), pDesc);
	}

	/// <inheritdoc cref="IDXGIOutput.GetDisplayModeList" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetDisplayModeList(Common.Format EnumFormat, EnumModesFlags Flags, uint* pNumModes, Common.ModeDescription* pDesc)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIOutput1*, Common.Format, EnumModesFlags, uint*, Common.ModeDescription*, int>)(lpVtbl[8]))((IDXGIOutput1*)Unsafe.AsPointer(ref this), EnumFormat, Flags, pNumModes, pDesc);
	}

	/// <inheritdoc cref="IDXGIOutput.FindClosestMatchingMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult FindClosestMatchingMode(Common.ModeDescription* pModeToMatch, Common.ModeDescription* pClosestMatch, IUnknown* pConcernedDevice)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIOutput1*, Common.ModeDescription*, Common.ModeDescription*, IUnknown*, int>)(lpVtbl[9]))((IDXGIOutput1*)Unsafe.AsPointer(ref this), pModeToMatch, pClosestMatch, pConcernedDevice);
	}

	/// <inheritdoc cref="IDXGIOutput.WaitForVBlank" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult WaitForVBlank()
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIOutput1*, int>)(lpVtbl[10]))((IDXGIOutput1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDXGIOutput.TakeOwnership" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult TakeOwnership(IUnknown* pDevice, Bool32 Exclusive)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIOutput1*, IUnknown*, Bool32, int>)(lpVtbl[11]))((IDXGIOutput1*)Unsafe.AsPointer(ref this), pDevice, Exclusive);
	}

	/// <inheritdoc cref="IDXGIOutput.ReleaseOwnership" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public void ReleaseOwnership()
	{
		((delegate* unmanaged[MemberFunction]<IDXGIOutput1*, void>)(lpVtbl[12]))((IDXGIOutput1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDXGIOutput.GetGammaControlCapabilities" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult GetGammaControlCapabilities(Common.GammaControlCapabilities* pGammaCaps)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIOutput1*, Common.GammaControlCapabilities*, int>)(lpVtbl[13]))((IDXGIOutput1*)Unsafe.AsPointer(ref this), pGammaCaps);
	}

	/// <inheritdoc cref="IDXGIOutput.SetGammaControl" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult SetGammaControl(Common.GammaControl* pArray)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIOutput1*, Common.GammaControl*, int>)(lpVtbl[14]))((IDXGIOutput1*)Unsafe.AsPointer(ref this), pArray);
	}

	/// <inheritdoc cref="IDXGIOutput.GetGammaControl" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult GetGammaControl(Common.GammaControl* pArray)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIOutput1*, Common.GammaControl*, int>)(lpVtbl[15]))((IDXGIOutput1*)Unsafe.AsPointer(ref this), pArray);
	}

	/// <inheritdoc cref="IDXGIOutput.SetDisplaySurface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult SetDisplaySurface(IDXGISurface* pScanoutSurface)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIOutput1*, IDXGISurface*, int>)(lpVtbl[16]))((IDXGIOutput1*)Unsafe.AsPointer(ref this), pScanoutSurface);
	}

	/// <inheritdoc cref="IDXGIOutput.GetDisplaySurfaceData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult GetDisplaySurfaceData(IDXGISurface* pDestination)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIOutput1*, IDXGISurface*, int>)(lpVtbl[17]))((IDXGIOutput1*)Unsafe.AsPointer(ref this), pDestination);
	}

	/// <inheritdoc cref="IDXGIOutput.GetFrameStatistics" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult GetFrameStatistics(FrameStatistics* pStats)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIOutput1*, FrameStatistics*, int>)(lpVtbl[18]))((IDXGIOutput1*)Unsafe.AsPointer(ref this), pStats);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIOutput1::GetDisplayModeList1"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult GetDisplayModeList1(Common.Format EnumFormat, EnumModesFlags Flags, uint* pNumModes, ModeDescription1* pDesc)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIOutput1*, Common.Format, EnumModesFlags, uint*, ModeDescription1*, int>)(lpVtbl[19]))((IDXGIOutput1*)Unsafe.AsPointer(ref this), EnumFormat, Flags, pNumModes, pDesc);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIOutput1::FindClosestMatchingMode1"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult FindClosestMatchingMode1(ModeDescription1* pModeToMatch, ModeDescription1* pClosestMatch, IUnknown* pConcernedDevice)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIOutput1*, ModeDescription1*, ModeDescription1*, IUnknown*, int>)(lpVtbl[20]))((IDXGIOutput1*)Unsafe.AsPointer(ref this), pModeToMatch, pClosestMatch, pConcernedDevice);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIOutput1::GetDisplaySurfaceData1"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult GetDisplaySurfaceData1(IDXGIResource* pDestination)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIOutput1*, IDXGIResource*, int>)(lpVtbl[21]))((IDXGIOutput1*)Unsafe.AsPointer(ref this), pDestination);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIOutput1::DuplicateOutput"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult DuplicateOutput(IUnknown* pDevice, IDXGIOutputDuplication** ppOutputDuplication)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIOutput1*, IUnknown*, IDXGIOutputDuplication**, int>)(lpVtbl[22]))((IDXGIOutput1*)Unsafe.AsPointer(ref this), pDevice, ppOutputDuplication);
	}

	public interface Interface : IDXGIOutput.Interface
	{
		[VtblIndex(19)]
		HResult GetDisplayModeList1(Common.Format EnumFormat, EnumModesFlags Flags, uint* pNumModes, ModeDescription1* pDesc);

		[VtblIndex(20)]
		HResult FindClosestMatchingMode1(ModeDescription1* pModeToMatch, ModeDescription1* pClosestMatch, IUnknown* pConcernedDevice);

		[VtblIndex(21)]
		HResult GetDisplaySurfaceData1(IDXGIResource* pDestination);

		[VtblIndex(22)]
		HResult DuplicateOutput(IUnknown* pDevice, IDXGIOutputDuplication** ppOutputDuplication);
	}
}

