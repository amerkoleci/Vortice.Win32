// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Linker"]/*' />
/// <unmanaged>ID3D11Linker</unmanaged>
[Guid("59a6cd0e-e10d-4c1f-88c0-63aba1daf30e")]
[NativeTypeName("struct ID3D11Linker : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D11Linker : INativeGuid
{
	public static ref readonly Guid IID_ID3D11Linker
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x0E, 0xCD, 0xA6, 0x59,
				0x0D, 0xE1,
				0x1F, 0x4C,
				0x88,
				0xC0,
				0x63,
				0xAB,
				0xA1,
				0xDA,
				0xF3,
				0x0E
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Linker));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Linker));
#endif

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

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Linker::Link"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult Link(ID3D11ModuleInstance* pEntry, sbyte* pEntryName, sbyte* pTargetName, uint uFlags, Graphics.Direct3D.ID3DBlob** ppShaderBlob, Graphics.Direct3D.ID3DBlob** ppErrorBuffer)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, sbyte*, sbyte*, uint, Graphics.Direct3D.ID3DBlob**, Graphics.Direct3D.ID3DBlob**, int>)(lpVtbl[3]))((ID3D11Linker*)Unsafe.AsPointer(ref this), pEntry, pEntryName, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Linker::UseLibrary"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult UseLibrary(ID3D11ModuleInstance* pLibraryMI)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, int>)(lpVtbl[4]))((ID3D11Linker*)Unsafe.AsPointer(ref this), pLibraryMI);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Linker::AddClipPlaneFromCBuffer"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult AddClipPlaneFromCBuffer(uint uCBufferSlot, uint uCBufferEntry)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Linker*, uint, uint, int>)(lpVtbl[5]))((ID3D11Linker*)Unsafe.AsPointer(ref this), uCBufferSlot, uCBufferEntry);
	}
}
