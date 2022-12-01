// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectComposition;

/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionCompositeEffect"]/*' />
/// <unmanaged>IDCompositionCompositeEffect</unmanaged>
[Guid("576616c0-a231-494d-a38d-00fd5ec4db46")]
[NativeTypeName("struct IDCompositionCompositeEffect : IDCompositionFilterEffect")]
[NativeInheritance("IDCompositionFilterEffect")]
public unsafe partial struct IDCompositionCompositeEffect : IDCompositionCompositeEffect.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDCompositionCompositeEffect
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xC0, 0x16, 0x66, 0x57,
				0x31, 0xA2,
				0x4D, 0x49,
				0xA3,
				0x8D,
				0x00,
				0xFD,
				0x5E,
				0xC4,
				0xDB,
				0x46
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionCompositeEffect));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionCompositeEffect));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionCompositeEffect*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionCompositeEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionCompositeEffect*, uint>)(lpVtbl[1]))((IDCompositionCompositeEffect*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionCompositeEffect*, uint>)(lpVtbl[2]))((IDCompositionCompositeEffect*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDCompositionFilterEffect.SetInput" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetInput(uint index, IUnknown* input, uint flags)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionCompositeEffect*, uint, IUnknown*, uint, int>)(lpVtbl[3]))((IDCompositionCompositeEffect*)Unsafe.AsPointer(ref this), index, input, flags);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionCompositeEffect::SetMode"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetMode(Graphics.Direct2D.Common.CompositeMode mode)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionCompositeEffect*, Graphics.Direct2D.Common.CompositeMode, int>)(lpVtbl[4]))((IDCompositionCompositeEffect*)Unsafe.AsPointer(ref this), mode);
	}
	public interface Interface : IDCompositionFilterEffect.Interface
	{
		[VtblIndex(4)]
		HResult SetMode(Graphics.Direct2D.Common.CompositeMode mode);
	}
}

