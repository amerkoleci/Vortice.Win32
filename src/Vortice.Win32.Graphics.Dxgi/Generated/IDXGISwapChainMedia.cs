// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Dxgi;

/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGISwapChainMedia"]/*' />
/// <unmanaged>IDXGISwapChainMedia</unmanaged>
[Guid("dd95b90b-f05f-4f6a-bd65-25bfb264bd84")]
[NativeTypeName("struct IDXGISwapChainMedia : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDXGISwapChainMedia : IDXGISwapChainMedia.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDXGISwapChainMedia
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x0B, 0xB9, 0x95, 0xDD,
				0x5F, 0xF0,
				0x6A, 0x4F,
				0xBD,
				0x65,
				0x25,
				0xBF,
				0xB2,
				0x64,
				0xBD,
				0x84
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGISwapChainMedia));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGISwapChainMedia));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChainMedia*, Guid*, void**, int>)(lpVtbl[0]))((IDXGISwapChainMedia*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChainMedia*, uint>)(lpVtbl[1]))((IDXGISwapChainMedia*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChainMedia*, uint>)(lpVtbl[2]))((IDXGISwapChainMedia*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGISwapChainMedia::GetFrameStatisticsMedia"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetFrameStatisticsMedia(FrameStatisticsMedia* pStats)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChainMedia*, FrameStatisticsMedia*, int>)(lpVtbl[3]))((IDXGISwapChainMedia*)Unsafe.AsPointer(ref this), pStats);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGISwapChainMedia::SetPresentDuration"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetPresentDuration(uint Duration)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChainMedia*, uint, int>)(lpVtbl[4]))((IDXGISwapChainMedia*)Unsafe.AsPointer(ref this), Duration);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGISwapChainMedia::CheckPresentDurationSupport"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult CheckPresentDurationSupport(uint DesiredPresentDuration, uint* pClosestSmallerPresentDuration, uint* pClosestLargerPresentDuration)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGISwapChainMedia*, uint, uint*, uint*, int>)(lpVtbl[5]))((IDXGISwapChainMedia*)Unsafe.AsPointer(ref this), DesiredPresentDuration, pClosestSmallerPresentDuration, pClosestLargerPresentDuration);
	}
	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult GetFrameStatisticsMedia(FrameStatisticsMedia* pStats);

		[VtblIndex(4)]
		HResult SetPresentDuration(uint Duration);

		[VtblIndex(5)]
		HResult CheckPresentDurationSupport(uint DesiredPresentDuration, uint* pClosestSmallerPresentDuration, uint* pClosestLargerPresentDuration);
	}
}

