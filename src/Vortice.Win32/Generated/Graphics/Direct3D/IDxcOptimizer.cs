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

/// <include file='../../Direct3D.xml' path='doc/member[@name="IDxcOptimizer"]/*' />
/// <unmanaged>IDxcOptimizer</unmanaged>
[Guid("25740e2e-9cba-401b-9119-4fb42f39f270")]
[NativeTypeName("struct IDxcOptimizer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxcOptimizer
{
	public static ref readonly Guid IID_IDxcOptimizer
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x2E, 0x0E, 0x74, 0x25,
				0xBA, 0x9C,
				0x1B, 0x40,
				0x91,
				0x19,
				0x4F,
				0xB4,
				0x2F,
				0x39,
				0xF2,
				0x70
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcOptimizer));

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

	/// <include file='../../Direct3D.xml' path='doc/member[@name="IDxcOptimizer::GetAvailablePassCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetAvailablePassCount(uint* pCount)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint*, int>)(lpVtbl[3]))((IDxcOptimizer*)Unsafe.AsPointer(ref this), pCount);
	}

	/// <include file='../../Direct3D.xml' path='doc/member[@name="IDxcOptimizer::GetAvailablePass"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetAvailablePass(uint index, IDxcOptimizerPass** ppResult)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint, IDxcOptimizerPass**, int>)(lpVtbl[4]))((IDxcOptimizer*)Unsafe.AsPointer(ref this), index, ppResult);
	}

	/// <include file='../../Direct3D.xml' path='doc/member[@name="IDxcOptimizer::RunOptimizer"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult RunOptimizer(IDxcBlob* pBlob, ushort** ppOptions, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, ushort**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)(lpVtbl[5]))((IDxcOptimizer*)Unsafe.AsPointer(ref this), pBlob, ppOptions, optionCount, pOutputModule, ppOutputText);
	}
}
