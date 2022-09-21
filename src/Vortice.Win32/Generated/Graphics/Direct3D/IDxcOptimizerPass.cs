// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D.Dxc;

/// <include file='../../Direct3D.xml' path='doc/member[@name="IDxcOptimizerPass"]/*' />
/// <unmanaged>IDxcOptimizerPass</unmanaged>
[Guid("ae2cd79f-cc22-453f-9b6b-b124e7a5204c")]
[NativeTypeName("struct IDxcOptimizerPass : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxcOptimizerPass
{
	public static ref readonly Guid IID_IDxcOptimizerPass
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x9F, 0xD7, 0x2C, 0xAE,
				0x22, 0xCC,
				0x3F, 0x45,
				0x9B,
				0x6B,
				0xB1,
				0x24,
				0xE7,
				0xA5,
				0x20,
				0x4C
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcOptimizerPass));

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

	/// <include file='../../Direct3D.xml' path='doc/member[@name="IDxcOptimizerPass::GetOptionName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetOptionName(ushort** ppResult)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, ushort**, int>)(lpVtbl[3]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), ppResult);
	}

	/// <include file='../../Direct3D.xml' path='doc/member[@name="IDxcOptimizerPass::GetDescription"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetDescription(ushort** ppResult)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, ushort**, int>)(lpVtbl[4]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), ppResult);
	}

	/// <include file='../../Direct3D.xml' path='doc/member[@name="IDxcOptimizerPass::GetOptionArgCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetOptionArgCount(uint* pCount)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint*, int>)(lpVtbl[5]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), pCount);
	}

	/// <include file='../../Direct3D.xml' path='doc/member[@name="IDxcOptimizerPass::GetOptionArgName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetOptionArgName(uint argIndex, ushort** ppResult)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint, ushort**, int>)(lpVtbl[6]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), argIndex, ppResult);
	}

	/// <include file='../../Direct3D.xml' path='doc/member[@name="IDxcOptimizerPass::GetOptionArgDescription"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetOptionArgDescription(uint argIndex, ushort** ppResult)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint, ushort**, int>)(lpVtbl[7]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), argIndex, ppResult);
	}
}

