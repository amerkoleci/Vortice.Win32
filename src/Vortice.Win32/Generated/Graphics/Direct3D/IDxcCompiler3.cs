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

namespace Win32.Graphics.Direct3D.Dxc;

/// <include file='../../Direct3D.xml' path='doc/member[@name="IDxcCompiler3"]/*' />
/// <unmanaged>IDxcCompiler3</unmanaged>
[Guid("228b4687-5a6a-4730-900c-9702b2203f54")]
[NativeTypeName("struct IDxcCompiler3 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxcCompiler3
{
	public static ref readonly Guid IID_IDxcCompiler3
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x87, 0x46, 0x8B, 0x22,
				0x6A, 0x5A,
				0x30, 0x47,
				0x90,
				0x0C,
				0x97,
				0x02,
				0xB2,
				0x20,
				0x3F,
				0x54
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcCompiler3));

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

	/// <include file='../../Direct3D.xml' path='doc/member[@name="IDxcCompiler3::Compile"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult Compile(DxcBuffer* pSource, ushort** pArguments, uint argCount, IDxcIncludeHandler* pIncludeHandler, Guid* riid, void** ppResult)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, DxcBuffer*, ushort**, uint, IDxcIncludeHandler*, Guid*, void**, int>)(lpVtbl[3]))((IDxcCompiler3*)Unsafe.AsPointer(ref this), pSource, pArguments, argCount, pIncludeHandler, riid, ppResult);
	}

	/// <include file='../../Direct3D.xml' path='doc/member[@name="IDxcCompiler3::Disassemble"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult Disassemble(DxcBuffer* pObject, Guid* riid, void** ppResult)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcCompiler3*, DxcBuffer*, Guid*, void**, int>)(lpVtbl[4]))((IDxcCompiler3*)Unsafe.AsPointer(ref this), pObject, riid, ppResult);
	}
}

