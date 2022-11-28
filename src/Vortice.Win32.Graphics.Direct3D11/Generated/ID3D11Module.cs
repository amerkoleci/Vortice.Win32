// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Module"]/*' />
/// <unmanaged>ID3D11Module</unmanaged>
[Guid("cac701ee-80fc-4122-8242-10b39c8cec34")]
[NativeTypeName("struct ID3D11Module : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D11Module : INativeGuid
{
	public static ref readonly Guid IID_ID3D11Module
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xEE, 0x01, 0xC7, 0xCA,
				0xFC, 0x80,
				0x22, 0x41,
				0x82,
				0x42,
				0x10,
				0xB3,
				0x9C,
				0x8C,
				0xEC,
				0x34
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Module));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Module));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Module*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11Module*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Module*, uint>)(lpVtbl[1]))((ID3D11Module*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Module*, uint>)(lpVtbl[2]))((ID3D11Module*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Module::CreateInstance"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult CreateInstance(sbyte* pNamespace, ID3D11ModuleInstance** ppModuleInstance)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Module*, sbyte*, ID3D11ModuleInstance**, int>)(lpVtbl[3]))((ID3D11Module*)Unsafe.AsPointer(ref this), pNamespace, ppModuleInstance);
	}
}

