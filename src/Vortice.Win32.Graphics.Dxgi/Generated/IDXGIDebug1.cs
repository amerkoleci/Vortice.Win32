// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Dxgi;

/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDebug1"]/*' />
/// <unmanaged>IDXGIDebug1</unmanaged>
[Guid("c5a05f0c-16f2-4adf-9f4d-a8c4d58ac550")]
[NativeTypeName("struct IDXGIDebug1 : IDXGIDebug")]
[NativeInheritance("IDXGIDebug")]
public unsafe partial struct IDXGIDebug1 : INativeGuid
{
	public static ref readonly Guid IID_IDXGIDebug1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x0C, 0x5F, 0xA0, 0xC5,
				0xF2, 0x16,
				0xDF, 0x4A,
				0x9F,
				0x4D,
				0xA8,
				0xC4,
				0xD5,
				0x8A,
				0xC5,
				0x50
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIDebug1));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIDebug1));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDebug1*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIDebug1*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDebug1*, uint>)(lpVtbl[1]))((IDXGIDebug1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDebug1*, uint>)(lpVtbl[2]))((IDXGIDebug1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDXGIDebug.ReportLiveObjects" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult ReportLiveObjects(Guid apiid, ReportLiveObjectFlags flags)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDebug1*, Guid, ReportLiveObjectFlags, int>)(lpVtbl[3]))((IDXGIDebug1*)Unsafe.AsPointer(ref this), apiid, flags);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDebug1::EnableLeakTrackingForThread"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void EnableLeakTrackingForThread()
	{
		((delegate* unmanaged[Stdcall]<IDXGIDebug1*, void>)(lpVtbl[4]))((IDXGIDebug1*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDebug1::DisableLeakTrackingForThread"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public void DisableLeakTrackingForThread()
	{
		((delegate* unmanaged[Stdcall]<IDXGIDebug1*, void>)(lpVtbl[5]))((IDXGIDebug1*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIDebug1::IsLeakTrackingEnabledForThread"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public Bool32 IsLeakTrackingEnabledForThread()
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDebug1*, Bool32>)(lpVtbl[6]))((IDXGIDebug1*)Unsafe.AsPointer(ref this));
	}
}

