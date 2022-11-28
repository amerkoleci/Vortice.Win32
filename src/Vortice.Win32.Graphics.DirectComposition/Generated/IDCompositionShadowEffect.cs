// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectComposition;

/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionShadowEffect"]/*' />
/// <unmanaged>IDCompositionShadowEffect</unmanaged>
[Guid("4ad18ac0-cfd2-4c2f-bb62-96e54fdb6879")]
[NativeTypeName("struct IDCompositionShadowEffect : IDCompositionFilterEffect")]
[NativeInheritance("IDCompositionFilterEffect")]
public unsafe partial struct IDCompositionShadowEffect : INativeGuid
{
	public static ref readonly Guid IID_IDCompositionShadowEffect
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xC0, 0x8A, 0xD1, 0x4A,
				0xD2, 0xCF,
				0x2F, 0x4C,
				0xBB,
				0x62,
				0x96,
				0xE5,
				0x4F,
				0xDB,
				0x68,
				0x79
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionShadowEffect));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionShadowEffect));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, uint>)(lpVtbl[1]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, uint>)(lpVtbl[2]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDCompositionFilterEffect.SetInput" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetInput(uint index, IUnknown* input, uint flags)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, uint, IUnknown*, uint, int>)(lpVtbl[3]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), index, input, flags);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionShadowEffect::SetStandardDeviation"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetStandardDeviation(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, IDCompositionAnimation*, int>)(lpVtbl[4]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), animation);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionShadowEffect::SetStandardDeviation"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetStandardDeviation(float amount)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, float, int>)(lpVtbl[5]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), amount);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionShadowEffect::SetColor"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetColor(Vector4* color)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, Vector4*, int>)(lpVtbl[6]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), color);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionShadowEffect::SetRed"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult SetRed(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, IDCompositionAnimation*, int>)(lpVtbl[7]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), animation);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionShadowEffect::SetRed"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult SetRed(float amount)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, float, int>)(lpVtbl[8]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), amount);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionShadowEffect::SetGreen"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult SetGreen(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, IDCompositionAnimation*, int>)(lpVtbl[9]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), animation);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionShadowEffect::SetGreen"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetGreen(float amount)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, float, int>)(lpVtbl[10]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), amount);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionShadowEffect::SetBlue"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult SetBlue(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, IDCompositionAnimation*, int>)(lpVtbl[11]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), animation);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionShadowEffect::SetBlue"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult SetBlue(float amount)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, float, int>)(lpVtbl[12]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), amount);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionShadowEffect::SetAlpha"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult SetAlpha(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, IDCompositionAnimation*, int>)(lpVtbl[13]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), animation);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionShadowEffect::SetAlpha"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult SetAlpha(float amount)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionShadowEffect*, float, int>)(lpVtbl[14]))((IDCompositionShadowEffect*)Unsafe.AsPointer(ref this), amount);
	}
}
