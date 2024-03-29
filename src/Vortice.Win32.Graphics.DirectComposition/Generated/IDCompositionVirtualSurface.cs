// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectComposition;

/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVirtualSurface"]/*' />
/// <unmanaged>IDCompositionVirtualSurface</unmanaged>
[Guid("ae471c51-5f53-4a24-8d3e-d0c39c30b3f0")]
[NativeTypeName("struct IDCompositionVirtualSurface : IDCompositionSurface")]
[NativeInheritance("IDCompositionSurface")]
public unsafe partial struct IDCompositionVirtualSurface : IDCompositionVirtualSurface.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDCompositionVirtualSurface
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x51, 0x1C, 0x47, 0xAE,
				0x53, 0x5F,
				0x24, 0x4A,
				0x8D,
				0x3E,
				0xD0,
				0xC3,
				0x9C,
				0x30,
				0xB3,
				0xF0
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionVirtualSurface));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<IDCompositionVirtualSurface*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<IDCompositionVirtualSurface*, uint>)(lpVtbl[1]))((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<IDCompositionVirtualSurface*, uint>)(lpVtbl[2]))((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDCompositionSurface.BeginDraw" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult BeginDraw(Rect* updateRect, Guid* iid, void** updateObject, System.Drawing.Point* updateOffset)
	{
		return ((delegate* unmanaged[MemberFunction]<IDCompositionVirtualSurface*, Rect*, Guid*, void**, System.Drawing.Point*, int>)(lpVtbl[3]))((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this), updateRect, iid, updateObject, updateOffset);
	}

	/// <inheritdoc cref="IDCompositionSurface.EndDraw" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult EndDraw()
	{
		return ((delegate* unmanaged[MemberFunction]<IDCompositionVirtualSurface*, int>)(lpVtbl[4]))((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDCompositionSurface.SuspendDraw" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SuspendDraw()
	{
		return ((delegate* unmanaged[MemberFunction]<IDCompositionVirtualSurface*, int>)(lpVtbl[5]))((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDCompositionSurface.ResumeDraw" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult ResumeDraw()
	{
		return ((delegate* unmanaged[MemberFunction]<IDCompositionVirtualSurface*, int>)(lpVtbl[6]))((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDCompositionSurface.Scroll" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult Scroll(Rect* scrollRect, Rect* clipRect, int offsetX, int offsetY)
	{
		return ((delegate* unmanaged[MemberFunction]<IDCompositionVirtualSurface*, Rect*, Rect*, int, int, int>)(lpVtbl[7]))((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this), scrollRect, clipRect, offsetX, offsetY);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVirtualSurface::Resize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult Resize(uint width, uint height)
	{
		return ((delegate* unmanaged[MemberFunction]<IDCompositionVirtualSurface*, uint, uint, int>)(lpVtbl[8]))((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this), width, height);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionVirtualSurface::Trim"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult Trim(Rect* rectangles, uint count)
	{
		return ((delegate* unmanaged[MemberFunction]<IDCompositionVirtualSurface*, Rect*, uint, int>)(lpVtbl[9]))((IDCompositionVirtualSurface*)Unsafe.AsPointer(ref this), rectangles, count);
	}

	public interface Interface : IDCompositionSurface.Interface
	{
		[VtblIndex(8)]
		HResult Resize(uint width, uint height);

		[VtblIndex(9)]
		HResult Trim(Rect* rectangles, uint count);
	}
}

