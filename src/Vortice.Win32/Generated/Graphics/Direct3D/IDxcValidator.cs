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

/// <include file='../../Direct3D.xml' path='doc/member[@name="IDxcValidator"]/*' />
/// <unmanaged>IDxcValidator</unmanaged>
[Guid("a6e82bd2-1fd7-4826-9811-2857e797f49a")]
[NativeTypeName("struct IDxcValidator : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxcValidator
{
	public static ref readonly Guid IID_IDxcValidator
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xD2, 0x2B, 0xE8, 0xA6,
				0xD7, 0x1F,
				0x26, 0x48,
				0x98,
				0x11,
				0x28,
				0x57,
				0xE7,
				0x97,
				0xF4,
				0x9A
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcValidator));

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

	/// <include file='../../Direct3D.xml' path='doc/member[@name="IDxcValidator::Validate"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult Validate(IDxcBlob* pShader, DxcValidatorFlags Flags, IDxcOperationResult** ppResult)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcValidator*, IDxcBlob*, DxcValidatorFlags, IDxcOperationResult**, int>)(lpVtbl[3]))((IDxcValidator*)Unsafe.AsPointer(ref this), pShader, Flags, ppResult);
	}
}
