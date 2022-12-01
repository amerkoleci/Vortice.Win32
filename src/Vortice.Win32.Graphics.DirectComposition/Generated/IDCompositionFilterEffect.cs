// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectComposition;

/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionFilterEffect"]/*' />
/// <unmanaged>IDCompositionFilterEffect</unmanaged>
[Guid("30c421d5-8cb2-4e9f-b133-37be270d4ac2")]
[NativeTypeName("struct IDCompositionFilterEffect : IDCompositionEffect")]
[NativeInheritance("IDCompositionEffect")]
public unsafe partial struct IDCompositionFilterEffect : IDCompositionFilterEffect.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDCompositionFilterEffect
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xD5, 0x21, 0xC4, 0x30,
				0xB2, 0x8C,
				0x9F, 0x4E,
				0xB1,
				0x33,
				0x37,
				0xBE,
				0x27,
				0x0D,
				0x4A,
				0xC2
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionFilterEffect));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionFilterEffect));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionFilterEffect*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionFilterEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionFilterEffect*, uint>)(lpVtbl[1]))((IDCompositionFilterEffect*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionFilterEffect*, uint>)(lpVtbl[2]))((IDCompositionFilterEffect*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionFilterEffect::SetInput"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetInput(uint index, IUnknown* input, uint flags)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionFilterEffect*, uint, IUnknown*, uint, int>)(lpVtbl[3]))((IDCompositionFilterEffect*)Unsafe.AsPointer(ref this), index, input, flags);
	}
	public interface Interface : IDCompositionEffect.Interface
	{
		[VtblIndex(3)]
		HResult SetInput(uint index, IUnknown* input, uint flags);
	}
}

