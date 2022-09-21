// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Dxgi;

/// <include file='../../Dxgi.xml' path='doc/member[@name="IDXGIDebug"]/*' />
/// <unmanaged>IDXGIDebug</unmanaged>
[Guid("119e7452-de9e-40fe-8806-88f90c12b441")]
[NativeTypeName("struct IDXGIDebug : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDXGIDebug
{
	public static ref readonly Guid IID_IDXGIDebug
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x52, 0x74, 0x9E, 0x11,
				0x9E, 0xDE,
				0xFE, 0x40,
				0x88,
				0x06,
				0x88,
				0xF9,
				0x0C,
				0x12,
				0xB4,
				0x41
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIDebug));

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

	/// <include file='../../Dxgi.xml' path='doc/member[@name="IDXGIDebug::ReportLiveObjects"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult ReportLiveObjects(Guid apiid, ReportLiveObjectFlags flags)
	{
		return ((delegate* unmanaged[Stdcall]<IDXGIDebug*, Guid, ReportLiveObjectFlags, int>)(lpVtbl[3]))((IDXGIDebug*)Unsafe.AsPointer(ref this), apiid, flags);
	}
}

