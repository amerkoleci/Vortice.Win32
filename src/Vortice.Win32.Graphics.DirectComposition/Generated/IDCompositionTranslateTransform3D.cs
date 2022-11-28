// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectComposition;

/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionTranslateTransform3D"]/*' />
/// <unmanaged>IDCompositionTranslateTransform3D</unmanaged>
[Guid("91636d4b-9ba1-4532-aaf7-e3344994d788")]
[NativeTypeName("struct IDCompositionTranslateTransform3D : IDCompositionTransform3D")]
[NativeInheritance("IDCompositionTransform3D")]
public unsafe partial struct IDCompositionTranslateTransform3D : INativeGuid
{
	public static ref readonly Guid IID_IDCompositionTranslateTransform3D
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x4B, 0x6D, 0x63, 0x91,
				0xA1, 0x9B,
				0x32, 0x45,
				0xAA,
				0xF7,
				0xE3,
				0x34,
				0x49,
				0x94,
				0xD7,
				0x88
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionTranslateTransform3D));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionTranslateTransform3D));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionTranslateTransform3D*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionTranslateTransform3D*, uint>)(lpVtbl[1]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionTranslateTransform3D*, uint>)(lpVtbl[2]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionTranslateTransform3D::SetOffsetX"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetOffsetX(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionTranslateTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[3]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this), animation);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionTranslateTransform3D::SetOffsetX"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetOffsetX(float offsetX)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionTranslateTransform3D*, float, int>)(lpVtbl[4]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this), offsetX);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionTranslateTransform3D::SetOffsetY"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetOffsetY(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionTranslateTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[5]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this), animation);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionTranslateTransform3D::SetOffsetY"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetOffsetY(float offsetY)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionTranslateTransform3D*, float, int>)(lpVtbl[6]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this), offsetY);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionTranslateTransform3D::SetOffsetZ"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult SetOffsetZ(IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionTranslateTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[7]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this), animation);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionTranslateTransform3D::SetOffsetZ"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult SetOffsetZ(float offsetZ)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionTranslateTransform3D*, float, int>)(lpVtbl[8]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this), offsetZ);
	}
}
