// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D.Dxc;

/// <unmanaged>IDxcVersionInfo</unmanaged>
[Guid("b04f5b50-2059-4f12-a8ff-a1e0cde1cc7e")]
[NativeTypeName("struct IDxcVersionInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxcVersionInfo : INativeGuid
{
	public static ref readonly Guid IID_IDxcVersionInfo
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x50, 0x5B, 0x4F, 0xB0,
				0x59, 0x20,
				0x12, 0x4F,
				0xA8,
				0xFF,
				0xA1,
				0xE0,
				0xCD,
				0xE1,
				0xCC,
				0x7E
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcVersionInfo));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcVersionInfo));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcVersionInfo*, Guid*, void**, int>)(lpVtbl[0]))((IDxcVersionInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDxcVersionInfo*, uint>)(lpVtbl[1]))((IDxcVersionInfo*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDxcVersionInfo*, uint>)(lpVtbl[2]))((IDxcVersionInfo*)Unsafe.AsPointer(ref this));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetVersion(uint* pMajor, uint* pMinor)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcVersionInfo*, uint*, uint*, int>)(lpVtbl[3]))((IDxcVersionInfo*)Unsafe.AsPointer(ref this), pMajor, pMinor);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetFlags(DxcVersionInfoFlags* pFlags)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcVersionInfo*, DxcVersionInfoFlags*, int>)(lpVtbl[4]))((IDxcVersionInfo*)Unsafe.AsPointer(ref this), pFlags);
	}
}

