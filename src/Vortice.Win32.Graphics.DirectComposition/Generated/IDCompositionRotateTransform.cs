// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectComposition;

/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionRotateTransform"]/*' />
/// <unmanaged>IDCompositionRotateTransform</unmanaged>
[Guid("641ed83c-ae96-46c5-90dc-32774cc5c6d5")]
[NativeTypeName("struct IDCompositionRotateTransform : IDCompositionTransform")]
[NativeInheritance("IDCompositionTransform")]
public unsafe partial struct IDCompositionRotateTransform : INativeGuid
{
	public static ref readonly Guid IID_IDCompositionRotateTransform
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x3C, 0xD8, 0x1E, 0x64,
				0x96, 0xAE,
				0xC5, 0x46,
				0x90,
				0xDC,
				0x32,
				0x77,
				0x4C,
				0xC5,
				0xC6,
				0xD5
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionRotateTransform));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionRotateTransform));
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

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionRotateTransform::SetAngle"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetAngle(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform*, IDCompositionAnimation*, int>)(lpVtbl[3]))((IDCompositionRotateTransform*)Unsafe.AsPointer(ref this), animation);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionRotateTransform::SetAngle"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetAngle(float angle)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform*, float, int>)(lpVtbl[4]))((IDCompositionRotateTransform*)Unsafe.AsPointer(ref this), angle);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionRotateTransform::SetCenterX"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetCenterX(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform*, IDCompositionAnimation*, int>)(lpVtbl[5]))((IDCompositionRotateTransform*)Unsafe.AsPointer(ref this), animation);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionRotateTransform::SetCenterX"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetCenterX(float centerX)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform*, float, int>)(lpVtbl[6]))((IDCompositionRotateTransform*)Unsafe.AsPointer(ref this), centerX);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionRotateTransform::SetCenterY"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult SetCenterY(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform*, IDCompositionAnimation*, int>)(lpVtbl[7]))((IDCompositionRotateTransform*)Unsafe.AsPointer(ref this), animation);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionRotateTransform::SetCenterY"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult SetCenterY(float centerY)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionRotateTransform*, float, int>)(lpVtbl[8]))((IDCompositionRotateTransform*)Unsafe.AsPointer(ref this), centerY);
	}
}

