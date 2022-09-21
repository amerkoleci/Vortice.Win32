// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------


#if !NET6_0_OR_GREATER
using MemoryMarshal = Win32.MemoryMarshal;
#endif

namespace Win32.Graphics.Direct3D12;

/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12Tools"]/*' />
/// <unmanaged>ID3D12Tools</unmanaged>
[Guid("7071e1f0-e84b-4b33-974f-12fa49de65c5")]
[NativeTypeName("struct ID3D12Tools : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12Tools
{
	public static ref readonly Guid IID_ID3D12Tools
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xF0, 0xE1, 0x71, 0x70,
				0x4B, 0xE8,
				0x33, 0x4B,
				0x97,
				0x4F,
				0x12,
				0xFA,
				0x49,
				0xDE,
				0x65,
				0xC5
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12Tools));

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

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12Tools::EnableShaderInstrumentation"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void EnableShaderInstrumentation(Bool32 bEnable)
	{
		((delegate* unmanaged[Stdcall]<ID3D12Tools*, Bool32, void>)(lpVtbl[3]))((ID3D12Tools*)Unsafe.AsPointer(ref this), bEnable);
	}

	/// <include file='../../Direct3D12.xml' path='doc/member[@name="ID3D12Tools::ShaderInstrumentationEnabled"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public Bool32 ShaderInstrumentationEnabled()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D12Tools*, Bool32>)(lpVtbl[4]))((ID3D12Tools*)Unsafe.AsPointer(ref this));
	}
}
