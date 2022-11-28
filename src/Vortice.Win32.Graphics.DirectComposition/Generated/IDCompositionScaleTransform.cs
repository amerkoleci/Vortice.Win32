// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectComposition;

/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionScaleTransform"]/*' />
/// <unmanaged>IDCompositionScaleTransform</unmanaged>
[Guid("71fde914-40ef-45ef-bd51-68b037c339f9")]
[NativeTypeName("struct IDCompositionScaleTransform : IDCompositionTransform")]
[NativeInheritance("IDCompositionTransform")]
public unsafe partial struct IDCompositionScaleTransform : INativeGuid
{
	public static ref readonly Guid IID_IDCompositionScaleTransform
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x14, 0xE9, 0xFD, 0x71,
				0xEF, 0x40,
				0xEF, 0x45,
				0xBD,
				0x51,
				0x68,
				0xB0,
				0x37,
				0xC3,
				0x39,
				0xF9
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionScaleTransform));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionScaleTransform));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform*, uint>)(lpVtbl[1]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform*, uint>)(lpVtbl[2]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionScaleTransform::SetScaleX"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetScaleX(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform*, IDCompositionAnimation*, int>)(lpVtbl[3]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), animation);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionScaleTransform::SetScaleX"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetScaleX(float scaleX)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform*, float, int>)(lpVtbl[4]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), scaleX);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionScaleTransform::SetScaleY"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetScaleY(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform*, IDCompositionAnimation*, int>)(lpVtbl[5]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), animation);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionScaleTransform::SetScaleY"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetScaleY(float scaleY)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform*, float, int>)(lpVtbl[6]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), scaleY);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionScaleTransform::SetCenterX"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult SetCenterX(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform*, IDCompositionAnimation*, int>)(lpVtbl[7]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), animation);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionScaleTransform::SetCenterX"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult SetCenterX(float centerX)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform*, float, int>)(lpVtbl[8]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), centerX);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionScaleTransform::SetCenterY"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult SetCenterY(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform*, IDCompositionAnimation*, int>)(lpVtbl[9]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), animation);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionScaleTransform::SetCenterY"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetCenterY(float centerY)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionScaleTransform*, float, int>)(lpVtbl[10]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), centerY);
	}
}
