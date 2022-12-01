// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ModuleInstance"]/*' />
/// <unmanaged>ID3D11ModuleInstance</unmanaged>
[Guid("469e07f7-045a-48d5-aa12-68a478cdf75d")]
[NativeTypeName("struct ID3D11ModuleInstance : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D11ModuleInstance : ID3D11ModuleInstance.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D11ModuleInstance
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xF7, 0x07, 0x9E, 0x46,
				0x5A, 0x04,
				0xD5, 0x48,
				0xAA,
				0x12,
				0x68,
				0xA4,
				0x78,
				0xCD,
				0xF7,
				0x5D
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11ModuleInstance));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11ModuleInstance));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint>)(lpVtbl[1]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint>)(lpVtbl[2]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ModuleInstance::BindConstantBuffer"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult BindConstantBuffer(uint uSrcSlot, uint uDstSlot, uint cbDstOffset)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint, uint, uint, int>)(lpVtbl[3]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), uSrcSlot, uDstSlot, cbDstOffset);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ModuleInstance::BindConstantBufferByName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult BindConstantBufferByName(sbyte* pName, uint uDstSlot, uint cbDstOffset)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, sbyte*, uint, uint, int>)(lpVtbl[4]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), pName, uDstSlot, cbDstOffset);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ModuleInstance::BindResource"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult BindResource(uint uSrcSlot, uint uDstSlot, uint uCount)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint, uint, uint, int>)(lpVtbl[5]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), uSrcSlot, uDstSlot, uCount);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ModuleInstance::BindResourceByName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult BindResourceByName(sbyte* pName, uint uDstSlot, uint uCount)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, sbyte*, uint, uint, int>)(lpVtbl[6]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), pName, uDstSlot, uCount);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ModuleInstance::BindSampler"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult BindSampler(uint uSrcSlot, uint uDstSlot, uint uCount)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint, uint, uint, int>)(lpVtbl[7]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), uSrcSlot, uDstSlot, uCount);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ModuleInstance::BindSamplerByName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult BindSamplerByName(sbyte* pName, uint uDstSlot, uint uCount)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, sbyte*, uint, uint, int>)(lpVtbl[8]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), pName, uDstSlot, uCount);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ModuleInstance::BindUnorderedAccessView"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult BindUnorderedAccessView(uint uSrcSlot, uint uDstSlot, uint uCount)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint, uint, uint, int>)(lpVtbl[9]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), uSrcSlot, uDstSlot, uCount);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ModuleInstance::BindUnorderedAccessViewByName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult BindUnorderedAccessViewByName(sbyte* pName, uint uDstSlot, uint uCount)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, sbyte*, uint, uint, int>)(lpVtbl[10]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), pName, uDstSlot, uCount);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ModuleInstance::BindResourceAsUnorderedAccessView"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult BindResourceAsUnorderedAccessView(uint uSrcSrvSlot, uint uDstUavSlot, uint uCount)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint, uint, uint, int>)(lpVtbl[11]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), uSrcSrvSlot, uDstUavSlot, uCount);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ModuleInstance::BindResourceAsUnorderedAccessViewByName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult BindResourceAsUnorderedAccessViewByName(sbyte* pSrvName, uint uDstUavSlot, uint uCount)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, sbyte*, uint, uint, int>)(lpVtbl[12]))((ID3D11ModuleInstance*)Unsafe.AsPointer(ref this), pSrvName, uDstUavSlot, uCount);
	}
	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult BindConstantBuffer(uint uSrcSlot, uint uDstSlot, uint cbDstOffset);

		[VtblIndex(4)]
		HResult BindConstantBufferByName(sbyte* pName, uint uDstSlot, uint cbDstOffset);

		[VtblIndex(5)]
		HResult BindResource(uint uSrcSlot, uint uDstSlot, uint uCount);

		[VtblIndex(6)]
		HResult BindResourceByName(sbyte* pName, uint uDstSlot, uint uCount);

		[VtblIndex(7)]
		HResult BindSampler(uint uSrcSlot, uint uDstSlot, uint uCount);

		[VtblIndex(8)]
		HResult BindSamplerByName(sbyte* pName, uint uDstSlot, uint uCount);

		[VtblIndex(9)]
		HResult BindUnorderedAccessView(uint uSrcSlot, uint uDstSlot, uint uCount);

		[VtblIndex(10)]
		HResult BindUnorderedAccessViewByName(sbyte* pName, uint uDstSlot, uint uCount);

		[VtblIndex(11)]
		HResult BindResourceAsUnorderedAccessView(uint uSrcSrvSlot, uint uDstUavSlot, uint uCount);

		[VtblIndex(12)]
		HResult BindResourceAsUnorderedAccessViewByName(sbyte* pSrvName, uint uDstUavSlot, uint uCount);
	}
}

