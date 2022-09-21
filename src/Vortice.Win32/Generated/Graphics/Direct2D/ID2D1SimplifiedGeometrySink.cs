// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------


#if !NET6_0_OR_GREATER
using MemoryMarshal = Win32.MemoryMarshal;
#endif

namespace Win32.Graphics.Direct2D.Common;

/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1SimplifiedGeometrySink"]/*' />
/// <unmanaged>ID2D1SimplifiedGeometrySink</unmanaged>
[Guid("2cd9069e-12e2-11dc-9fed-001143a055f9")]
[NativeTypeName("struct ID2D1SimplifiedGeometrySink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID2D1SimplifiedGeometrySink
{
	public static ref readonly Guid IID_ID2D1SimplifiedGeometrySink
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x9E, 0x06, 0xD9, 0x2C,
				0xE2, 0x12,
				0xDC, 0x11,
				0x9F,
				0xED,
				0x00,
				0x11,
				0x43,
				0xA0,
				0x55,
				0xF9
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1SimplifiedGeometrySink));

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

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1SimplifiedGeometrySink::SetFillMode"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void SetFillMode(FillMode fillMode)
	{
		((delegate* unmanaged[Stdcall]<ID2D1SimplifiedGeometrySink*, FillMode, void>)(lpVtbl[3]))((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this), fillMode);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1SimplifiedGeometrySink::SetSegmentFlags"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void SetSegmentFlags(PathSegment vertexFlags)
	{
		((delegate* unmanaged[Stdcall]<ID2D1SimplifiedGeometrySink*, PathSegment, void>)(lpVtbl[4]))((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this), vertexFlags);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1SimplifiedGeometrySink::BeginFigure"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public void BeginFigure(System.Drawing.PointF startPoint, FigureBegin figureBegin)
	{
		((delegate* unmanaged[Stdcall]<ID2D1SimplifiedGeometrySink*, System.Drawing.PointF, FigureBegin, void>)(lpVtbl[5]))((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this), startPoint, figureBegin);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1SimplifiedGeometrySink::AddLines"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public void AddLines(System.Drawing.PointF* points, uint pointsCount)
	{
		((delegate* unmanaged[Stdcall]<ID2D1SimplifiedGeometrySink*, System.Drawing.PointF*, uint, void>)(lpVtbl[6]))((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this), points, pointsCount);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1SimplifiedGeometrySink::AddBeziers"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public void AddBeziers(BezierSegment* beziers, uint beziersCount)
	{
		((delegate* unmanaged[Stdcall]<ID2D1SimplifiedGeometrySink*, BezierSegment*, uint, void>)(lpVtbl[7]))((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this), beziers, beziersCount);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1SimplifiedGeometrySink::EndFigure"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public void EndFigure(FigureEnd figureEnd)
	{
		((delegate* unmanaged[Stdcall]<ID2D1SimplifiedGeometrySink*, FigureEnd, void>)(lpVtbl[8]))((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this), figureEnd);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1SimplifiedGeometrySink::Close"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult Close()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SimplifiedGeometrySink*, int>)(lpVtbl[9]))((ID2D1SimplifiedGeometrySink*)Unsafe.AsPointer(ref this));
	}
}
