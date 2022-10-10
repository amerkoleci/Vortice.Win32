// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectComposition;

/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionLinearTransferEffect"]/*' />
/// <unmanaged>IDCompositionLinearTransferEffect</unmanaged>
[Guid("4305ee5b-c4a0-4c88-9385-67124e017683")]
[NativeTypeName("struct IDCompositionLinearTransferEffect : IDCompositionFilterEffect")]
[NativeInheritance("IDCompositionFilterEffect")]
public unsafe partial struct IDCompositionLinearTransferEffect : INativeGuid
{
	public static ref readonly Guid IID_IDCompositionLinearTransferEffect
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x5B, 0xEE, 0x05, 0x43,
				0xA0, 0xC4,
				0x88, 0x4C,
				0x93,
				0x85,
				0x67,
				0x12,
				0x4E,
				0x01,
				0x76,
				0x83
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionLinearTransferEffect));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionLinearTransferEffect));
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

	/// <inheritdoc cref="IDCompositionFilterEffect.SetInput" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetInput(uint index, IUnknown* input, uint flags)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, uint, IUnknown*, uint, int>)(lpVtbl[3]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), index, input, flags);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionLinearTransferEffect::SetRedYIntercept"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetRedYIntercept(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, IDCompositionAnimation*, int>)(lpVtbl[4]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), animation);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionLinearTransferEffect::SetRedYIntercept"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetRedYIntercept(float redYIntercept)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, float, int>)(lpVtbl[5]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), redYIntercept);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionLinearTransferEffect::SetRedSlope"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetRedSlope(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, IDCompositionAnimation*, int>)(lpVtbl[6]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), animation);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionLinearTransferEffect::SetRedSlope"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult SetRedSlope(float redSlope)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, float, int>)(lpVtbl[7]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), redSlope);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionLinearTransferEffect::SetRedDisable"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult SetRedDisable(Bool32 redDisable)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, Bool32, int>)(lpVtbl[8]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), redDisable);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionLinearTransferEffect::SetGreenYIntercept"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult SetGreenYIntercept(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, IDCompositionAnimation*, int>)(lpVtbl[9]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), animation);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionLinearTransferEffect::SetGreenYIntercept"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetGreenYIntercept(float greenYIntercept)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, float, int>)(lpVtbl[10]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), greenYIntercept);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionLinearTransferEffect::SetGreenSlope"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult SetGreenSlope(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, IDCompositionAnimation*, int>)(lpVtbl[11]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), animation);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionLinearTransferEffect::SetGreenSlope"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult SetGreenSlope(float greenSlope)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, float, int>)(lpVtbl[12]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), greenSlope);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionLinearTransferEffect::SetGreenDisable"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult SetGreenDisable(Bool32 greenDisable)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, Bool32, int>)(lpVtbl[13]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), greenDisable);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionLinearTransferEffect::SetBlueYIntercept"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult SetBlueYIntercept(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, IDCompositionAnimation*, int>)(lpVtbl[14]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), animation);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionLinearTransferEffect::SetBlueYIntercept"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult SetBlueYIntercept(float blueYIntercept)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, float, int>)(lpVtbl[15]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), blueYIntercept);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionLinearTransferEffect::SetBlueSlope"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult SetBlueSlope(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, IDCompositionAnimation*, int>)(lpVtbl[16]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), animation);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionLinearTransferEffect::SetBlueSlope"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult SetBlueSlope(float blueSlope)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, float, int>)(lpVtbl[17]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), blueSlope);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionLinearTransferEffect::SetBlueDisable"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult SetBlueDisable(Bool32 blueDisable)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, Bool32, int>)(lpVtbl[18]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), blueDisable);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionLinearTransferEffect::SetAlphaYIntercept"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult SetAlphaYIntercept(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, IDCompositionAnimation*, int>)(lpVtbl[19]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), animation);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionLinearTransferEffect::SetAlphaYIntercept"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult SetAlphaYIntercept(float alphaYIntercept)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, float, int>)(lpVtbl[20]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), alphaYIntercept);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionLinearTransferEffect::SetAlphaSlope"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult SetAlphaSlope(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, IDCompositionAnimation*, int>)(lpVtbl[21]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), animation);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionLinearTransferEffect::SetAlphaSlope"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult SetAlphaSlope(float alphaSlope)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, float, int>)(lpVtbl[22]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), alphaSlope);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionLinearTransferEffect::SetAlphaDisable"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public HResult SetAlphaDisable(Bool32 alphaDisable)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, Bool32, int>)(lpVtbl[23]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), alphaDisable);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionLinearTransferEffect::SetClampOutput"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult SetClampOutput(Bool32 clampOutput)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionLinearTransferEffect*, Bool32, int>)(lpVtbl[24]))((IDCompositionLinearTransferEffect*)Unsafe.AsPointer(ref this), clampOutput);
	}
}

