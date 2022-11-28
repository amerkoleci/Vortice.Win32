// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectComposition;

/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionTurbulenceEffect"]/*' />
/// <unmanaged>IDCompositionTurbulenceEffect</unmanaged>
[Guid("a6a55bda-c09c-49f3-9193-a41922c89715")]
[NativeTypeName("struct IDCompositionTurbulenceEffect : IDCompositionFilterEffect")]
[NativeInheritance("IDCompositionFilterEffect")]
public unsafe partial struct IDCompositionTurbulenceEffect : INativeGuid
{
	public static ref readonly Guid IID_IDCompositionTurbulenceEffect
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xDA, 0x5B, 0xA5, 0xA6,
				0x9C, 0xC0,
				0xF3, 0x49,
				0x91,
				0x93,
				0xA4,
				0x19,
				0x22,
				0xC8,
				0x97,
				0x15
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionTurbulenceEffect));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionTurbulenceEffect));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionTurbulenceEffect*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionTurbulenceEffect*, uint>)(lpVtbl[1]))((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionTurbulenceEffect*, uint>)(lpVtbl[2]))((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDCompositionFilterEffect.SetInput" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetInput(uint index, IUnknown* input, uint flags)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionTurbulenceEffect*, uint, IUnknown*, uint, int>)(lpVtbl[3]))((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), index, input, flags);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionTurbulenceEffect::SetOffset"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetOffset(Vector2* offset)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionTurbulenceEffect*, Vector2*, int>)(lpVtbl[4]))((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), offset);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionTurbulenceEffect::SetBaseFrequency"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetBaseFrequency(Vector2* frequency)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionTurbulenceEffect*, Vector2*, int>)(lpVtbl[5]))((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), frequency);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionTurbulenceEffect::SetSize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetSize(Vector2* size)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionTurbulenceEffect*, Vector2*, int>)(lpVtbl[6]))((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), size);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionTurbulenceEffect::SetNumOctaves"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult SetNumOctaves(uint numOctaves)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionTurbulenceEffect*, uint, int>)(lpVtbl[7]))((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), numOctaves);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionTurbulenceEffect::SetSeed"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult SetSeed(uint seed)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionTurbulenceEffect*, uint, int>)(lpVtbl[8]))((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), seed);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionTurbulenceEffect::SetNoise"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult SetNoise(Graphics.Direct2D.Common.TurbulenceNoise noise)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionTurbulenceEffect*, Graphics.Direct2D.Common.TurbulenceNoise, int>)(lpVtbl[9]))((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), noise);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionTurbulenceEffect::SetStitchable"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetStitchable(Bool32 stitchable)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionTurbulenceEffect*, Bool32, int>)(lpVtbl[10]))((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), stitchable);
	}
}
