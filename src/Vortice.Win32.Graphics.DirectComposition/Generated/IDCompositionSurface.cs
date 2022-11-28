// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectComposition;

/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionSurface"]/*' />
/// <unmanaged>IDCompositionSurface</unmanaged>
[Guid("bb8a4953-2c99-4f5a-96f5-4819027fa3ac")]
[NativeTypeName("struct IDCompositionSurface : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDCompositionSurface : INativeGuid
{
	public static ref readonly Guid IID_IDCompositionSurface
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x53, 0x49, 0x8A, 0xBB,
				0x99, 0x2C,
				0x5A, 0x4F,
				0x96,
				0xF5,
				0x48,
				0x19,
				0x02,
				0x7F,
				0xA3,
				0xAC
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionSurface));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionSurface));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionSurface*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, uint>)(lpVtbl[1]))((IDCompositionSurface*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, uint>)(lpVtbl[2]))((IDCompositionSurface*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionSurface::BeginDraw"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult BeginDraw(RawRect* updateRect, Guid* iid, void** updateObject, System.Drawing.Point* updateOffset)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, RawRect*, Guid*, void**, System.Drawing.Point*, int>)(lpVtbl[3]))((IDCompositionSurface*)Unsafe.AsPointer(ref this), updateRect, iid, updateObject, updateOffset);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionSurface::EndDraw"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult EndDraw()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, int>)(lpVtbl[4]))((IDCompositionSurface*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionSurface::SuspendDraw"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SuspendDraw()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, int>)(lpVtbl[5]))((IDCompositionSurface*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionSurface::ResumeDraw"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult ResumeDraw()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, int>)(lpVtbl[6]))((IDCompositionSurface*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionSurface::Scroll"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult Scroll(RawRect* scrollRect, RawRect* clipRect, int offsetX, int offsetY)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, RawRect*, RawRect*, int, int, int>)(lpVtbl[7]))((IDCompositionSurface*)Unsafe.AsPointer(ref this), scrollRect, clipRect, offsetX, offsetY);
	}
}

