// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Dxgi;

/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGISwapChain1"]/*' />
/// <unmanaged>IDXGISwapChain1</unmanaged>
[Guid("790a45f7-0d42-4876-983a-0a55cfe6f4aa")]
[NativeTypeName("struct IDXGISwapChain1 : IDXGISwapChain")]
[NativeInheritance("IDXGISwapChain")]
public unsafe partial struct IDXGISwapChain1 : IDXGISwapChain1.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDXGISwapChain1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xF7, 0x45, 0x0A, 0x79,
				0x42, 0x0D,
				0x76, 0x48,
				0x98,
				0x3A,
				0x0A,
				0x55,
				0xCF,
				0xE6,
				0xF4,
				0xAA
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGISwapChain1));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGISwapChain1*, Guid*, void**, int>)(lpVtbl[0]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGISwapChain1*, uint>)(lpVtbl[1]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGISwapChain1*, uint>)(lpVtbl[2]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetPrivateData(Guid* Name, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGISwapChain1*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPrivateDataInterface(Guid* Name, IUnknown* pUnknown)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGISwapChain1*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Name, pUnknown);
	}

	/// <inheritdoc cref="IDXGIObject.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGISwapChain1*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
	}

	/// <inheritdoc cref="IDXGIObject.GetParent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetParent(Guid* riid, void** ppParent)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGISwapChain1*, Guid*, void**, int>)(lpVtbl[6]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), riid, ppParent);
	}

	/// <inheritdoc cref="IDXGIDeviceSubObject.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetDevice(Guid* riid, void** ppDevice)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGISwapChain1*, Guid*, void**, int>)(lpVtbl[7]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), riid, ppDevice);
	}

	/// <inheritdoc cref="IDXGISwapChain.Present" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult Present(uint SyncInterval, PresentFlags Flags)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGISwapChain1*, uint, PresentFlags, int>)(lpVtbl[8]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), SyncInterval, Flags);
	}

	/// <inheritdoc cref="IDXGISwapChain.GetBuffer" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetBuffer(uint Buffer, Guid* riid, void** ppSurface)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGISwapChain1*, uint, Guid*, void**, int>)(lpVtbl[9]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Buffer, riid, ppSurface);
	}

	/// <inheritdoc cref="IDXGISwapChain.SetFullscreenState" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetFullscreenState(Bool32 Fullscreen, IDXGIOutput* pTarget)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGISwapChain1*, Bool32, IDXGIOutput*, int>)(lpVtbl[10]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Fullscreen, pTarget);
	}

	/// <inheritdoc cref="IDXGISwapChain.GetFullscreenState" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetFullscreenState(Bool32* pFullscreen, IDXGIOutput** ppTarget)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGISwapChain1*, Bool32*, IDXGIOutput**, int>)(lpVtbl[11]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pFullscreen, ppTarget);
	}

	/// <inheritdoc cref="IDXGISwapChain.GetDesc" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult GetDesc(SwapChainDescription* pDesc)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGISwapChain1*, SwapChainDescription*, int>)(lpVtbl[12]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pDesc);
	}

	/// <inheritdoc cref="IDXGISwapChain.ResizeBuffers" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult ResizeBuffers(uint BufferCount, uint Width, uint Height, Common.Format NewFormat, SwapChainFlags SwapChainFlags)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGISwapChain1*, uint, uint, uint, Common.Format, SwapChainFlags, int>)(lpVtbl[13]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), BufferCount, Width, Height, NewFormat, SwapChainFlags);
	}

	/// <inheritdoc cref="IDXGISwapChain.ResizeTarget" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult ResizeTarget(Common.ModeDescription* pNewTargetParameters)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGISwapChain1*, Common.ModeDescription*, int>)(lpVtbl[14]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pNewTargetParameters);
	}

	/// <inheritdoc cref="IDXGISwapChain.GetContainingOutput" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult GetContainingOutput(IDXGIOutput** ppOutput)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGISwapChain1*, IDXGIOutput**, int>)(lpVtbl[15]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), ppOutput);
	}

	/// <inheritdoc cref="IDXGISwapChain.GetFrameStatistics" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult GetFrameStatistics(FrameStatistics* pStats)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGISwapChain1*, FrameStatistics*, int>)(lpVtbl[16]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pStats);
	}

	/// <inheritdoc cref="IDXGISwapChain.GetLastPresentCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult GetLastPresentCount(uint* pLastPresentCount)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGISwapChain1*, uint*, int>)(lpVtbl[17]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pLastPresentCount);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGISwapChain1::GetDesc1"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult GetDesc1(SwapChainDescription1* pDesc)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGISwapChain1*, SwapChainDescription1*, int>)(lpVtbl[18]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pDesc);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGISwapChain1::GetFullscreenDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult GetFullscreenDesc(SwapChainFullscreenDescription* pDesc)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGISwapChain1*, SwapChainFullscreenDescription*, int>)(lpVtbl[19]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pDesc);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGISwapChain1::GetHwnd"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult GetHwnd(nint* pHwnd)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGISwapChain1*, nint*, int>)(lpVtbl[20]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pHwnd);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGISwapChain1::GetCoreWindow"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult GetCoreWindow(Guid* refiid, void** ppUnk)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGISwapChain1*, Guid*, void**, int>)(lpVtbl[21]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), refiid, ppUnk);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGISwapChain1::Present1"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult Present1(uint SyncInterval, PresentFlags PresentFlags, PresentParameters* pPresentParameters)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGISwapChain1*, uint, PresentFlags, PresentParameters*, int>)(lpVtbl[22]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), SyncInterval, PresentFlags, pPresentParameters);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGISwapChain1::IsTemporaryMonoSupported"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public Bool32 IsTemporaryMonoSupported()
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGISwapChain1*, Bool32>)(lpVtbl[23]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGISwapChain1::GetRestrictToOutput"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult GetRestrictToOutput(IDXGIOutput** ppRestrictToOutput)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGISwapChain1*, IDXGIOutput**, int>)(lpVtbl[24]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), ppRestrictToOutput);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGISwapChain1::SetBackgroundColor"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public HResult SetBackgroundColor(Color4* pColor)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGISwapChain1*, Color4*, int>)(lpVtbl[25]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pColor);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGISwapChain1::GetBackgroundColor"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public HResult GetBackgroundColor(Color4** pColor)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGISwapChain1*, Color4**, int>)(lpVtbl[26]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pColor);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGISwapChain1::SetRotation"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public HResult SetRotation(Common.ModeRotation Rotation)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGISwapChain1*, Common.ModeRotation, int>)(lpVtbl[27]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), Rotation);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGISwapChain1::GetRotation"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public HResult GetRotation(Common.ModeRotation* pRotation)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGISwapChain1*, Common.ModeRotation*, int>)(lpVtbl[28]))((IDXGISwapChain1*)Unsafe.AsPointer(ref this), pRotation);
	}

	public interface Interface : IDXGISwapChain.Interface
	{
		[VtblIndex(18)]
		HResult GetDesc1(SwapChainDescription1* pDesc);

		[VtblIndex(19)]
		HResult GetFullscreenDesc(SwapChainFullscreenDescription* pDesc);

		[VtblIndex(20)]
		HResult GetHwnd(nint* pHwnd);

		[VtblIndex(21)]
		HResult GetCoreWindow(Guid* refiid, void** ppUnk);

		[VtblIndex(22)]
		HResult Present1(uint SyncInterval, PresentFlags PresentFlags, PresentParameters* pPresentParameters);

		[VtblIndex(23)]
		Bool32 IsTemporaryMonoSupported();

		[VtblIndex(24)]
		HResult GetRestrictToOutput(IDXGIOutput** ppRestrictToOutput);

		[VtblIndex(25)]
		HResult SetBackgroundColor(Color4* pColor);

		[VtblIndex(26)]
		HResult GetBackgroundColor(Color4** pColor);

		[VtblIndex(27)]
		HResult SetRotation(Common.ModeRotation Rotation);

		[VtblIndex(28)]
		HResult GetRotation(Common.ModeRotation* pRotation);
	}
}

