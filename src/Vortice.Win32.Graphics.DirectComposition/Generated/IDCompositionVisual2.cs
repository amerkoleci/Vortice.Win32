// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectComposition;

/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisual2"]/*' />
/// <unmanaged>IDCompositionVisual2</unmanaged>
[Guid("e8de1639-4331-4b26-bc5f-6a321d347a85")]
[NativeTypeName("struct IDCompositionVisual2 : IDCompositionVisual")]
[NativeInheritance("IDCompositionVisual")]
public unsafe partial struct IDCompositionVisual2 : INativeGuid
{
	public static ref readonly Guid IID_IDCompositionVisual2
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x39, 0x16, 0xDE, 0xE8,
				0x31, 0x43,
				0x26, 0x4B,
				0xBC,
				0x5F,
				0x6A,
				0x32,
				0x1D,
				0x34,
				0x7A,
				0x85
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionVisual2));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionVisual2));
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

	/// <inheritdoc cref="IDCompositionVisual.SetOffsetX" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetOffsetX(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual2*, IDCompositionAnimation*, int>)(lpVtbl[3]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), animation);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetOffsetX" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetOffsetX(float offsetX)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual2*, float, int>)(lpVtbl[4]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), offsetX);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetOffsetY" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetOffsetY(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual2*, IDCompositionAnimation*, int>)(lpVtbl[5]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), animation);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetOffsetY" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetOffsetY(float offsetY)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual2*, float, int>)(lpVtbl[6]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), offsetY);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult SetTransform(IDCompositionTransform* transform)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual2*, IDCompositionTransform*, int>)(lpVtbl[7]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), transform);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult SetTransform(Matrix3x2* matrix)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual2*, Matrix3x2*, int>)(lpVtbl[8]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), matrix);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetTransformParent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult SetTransformParent(IDCompositionVisual* visual)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual2*, IDCompositionVisual*, int>)(lpVtbl[9]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), visual);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetEffect" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetEffect(IDCompositionEffect* effect)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual2*, IDCompositionEffect*, int>)(lpVtbl[10]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), effect);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetBitmapInterpolationMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult SetBitmapInterpolationMode(BitmapInterpolationMode interpolationMode)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual2*, BitmapInterpolationMode, int>)(lpVtbl[11]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), interpolationMode);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetBorderMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult SetBorderMode(BorderMode borderMode)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual2*, BorderMode, int>)(lpVtbl[12]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), borderMode);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetClip" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult SetClip(IDCompositionClip* clip)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual2*, IDCompositionClip*, int>)(lpVtbl[13]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), clip);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetClip" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult SetClip(Graphics.Direct2D.Common.RectF* rect)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual2*, Graphics.Direct2D.Common.RectF*, int>)(lpVtbl[14]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), rect);
	}

	/// <inheritdoc cref="IDCompositionVisual.SetContent" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult SetContent(IUnknown* content)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual2*, IUnknown*, int>)(lpVtbl[15]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), content);
	}

	/// <inheritdoc cref="IDCompositionVisual.AddVisual" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult AddVisual(IDCompositionVisual* visual, Bool32 insertAbove, IDCompositionVisual* referenceVisual)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual2*, IDCompositionVisual*, Bool32, IDCompositionVisual*, int>)(lpVtbl[16]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), visual, insertAbove, referenceVisual);
	}

	/// <inheritdoc cref="IDCompositionVisual.RemoveVisual" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult RemoveVisual(IDCompositionVisual* visual)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual2*, IDCompositionVisual*, int>)(lpVtbl[17]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), visual);
	}

	/// <inheritdoc cref="IDCompositionVisual.RemoveAllVisuals" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult RemoveAllVisuals()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual2*, int>)(lpVtbl[18]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDCompositionVisual.SetCompositeMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult SetCompositeMode(CompositeMode compositeMode)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual2*, CompositeMode, int>)(lpVtbl[19]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), compositeMode);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisual2::SetOpacityMode"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult SetOpacityMode(OpacityMode mode)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual2*, OpacityMode, int>)(lpVtbl[20]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), mode);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVisual2::SetBackFaceVisibility"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult SetBackFaceVisibility(BackfaceVisibility visibility)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionVisual2*, BackfaceVisibility, int>)(lpVtbl[21]))((IDCompositionVisual2*)Unsafe.AsPointer(ref this), visibility);
	}
}

