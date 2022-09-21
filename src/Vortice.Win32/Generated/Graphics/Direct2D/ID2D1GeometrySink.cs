// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1GeometrySink"]/*' />
/// <unmanaged>ID2D1GeometrySink</unmanaged>
[Guid("2cd9069f-12e2-11dc-9fed-001143a055f9")]
[NativeTypeName("struct ID2D1GeometrySink : ID2D1SimplifiedGeometrySink")]
[NativeInheritance("ID2D1SimplifiedGeometrySink")]
public unsafe partial struct ID2D1GeometrySink
{
	public static ref readonly Guid IID_ID2D1GeometrySink
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x9F, 0x06, 0xD9, 0x2C,
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

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1GeometrySink));

	public void** lpVtbl;

	/// <inheritdoc cref="ID2D1SimplifiedGeometrySink.SetFillMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public void SetFillMode(Common.FillMode fillMode)
	{
		((delegate* unmanaged[Stdcall]<ID2D1GeometrySink*, Common.FillMode, void>)(lpVtbl[0]))((ID2D1GeometrySink*)Unsafe.AsPointer(ref this), fillMode);
	}

	/// <inheritdoc cref="ID2D1SimplifiedGeometrySink.SetSegmentFlags" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	public void SetSegmentFlags(Common.PathSegment vertexFlags)
	{
		((delegate* unmanaged[Stdcall]<ID2D1GeometrySink*, Common.PathSegment, void>)(lpVtbl[1]))((ID2D1GeometrySink*)Unsafe.AsPointer(ref this), vertexFlags);
	}

	/// <inheritdoc cref="ID2D1SimplifiedGeometrySink.BeginFigure" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	public void BeginFigure(System.Drawing.PointF startPoint, Common.FigureBegin figureBegin)
	{
		((delegate* unmanaged[Stdcall]<ID2D1GeometrySink*, System.Drawing.PointF, Common.FigureBegin, void>)(lpVtbl[2]))((ID2D1GeometrySink*)Unsafe.AsPointer(ref this), startPoint, figureBegin);
	}

	/// <inheritdoc cref="ID2D1SimplifiedGeometrySink.AddLines" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void AddLines(System.Drawing.PointF* points, uint pointsCount)
	{
		((delegate* unmanaged[Stdcall]<ID2D1GeometrySink*, System.Drawing.PointF*, uint, void>)(lpVtbl[3]))((ID2D1GeometrySink*)Unsafe.AsPointer(ref this), points, pointsCount);
	}

	/// <inheritdoc cref="ID2D1SimplifiedGeometrySink.AddBeziers" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void AddBeziers(Common.BezierSegment* beziers, uint beziersCount)
	{
		((delegate* unmanaged[Stdcall]<ID2D1GeometrySink*, Common.BezierSegment*, uint, void>)(lpVtbl[4]))((ID2D1GeometrySink*)Unsafe.AsPointer(ref this), beziers, beziersCount);
	}

	/// <inheritdoc cref="ID2D1SimplifiedGeometrySink.EndFigure" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public void EndFigure(Common.FigureEnd figureEnd)
	{
		((delegate* unmanaged[Stdcall]<ID2D1GeometrySink*, Common.FigureEnd, void>)(lpVtbl[5]))((ID2D1GeometrySink*)Unsafe.AsPointer(ref this), figureEnd);
	}

	/// <inheritdoc cref="ID2D1SimplifiedGeometrySink.Close" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult Close()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1GeometrySink*, int>)(lpVtbl[6]))((ID2D1GeometrySink*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1GeometrySink::AddLine"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public void AddLine(System.Drawing.PointF point)
	{
		((delegate* unmanaged[Stdcall]<ID2D1GeometrySink*, System.Drawing.PointF, void>)(lpVtbl[7]))((ID2D1GeometrySink*)Unsafe.AsPointer(ref this), point);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1GeometrySink::AddBezier"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public void AddBezier(Common.BezierSegment* bezier)
	{
		((delegate* unmanaged[Stdcall]<ID2D1GeometrySink*, Common.BezierSegment*, void>)(lpVtbl[8]))((ID2D1GeometrySink*)Unsafe.AsPointer(ref this), bezier);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1GeometrySink::AddQuadraticBezier"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public void AddQuadraticBezier(QuadraticBezierSegment* bezier)
	{
		((delegate* unmanaged[Stdcall]<ID2D1GeometrySink*, QuadraticBezierSegment*, void>)(lpVtbl[9]))((ID2D1GeometrySink*)Unsafe.AsPointer(ref this), bezier);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1GeometrySink::AddQuadraticBeziers"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public void AddQuadraticBeziers(QuadraticBezierSegment* beziers, uint beziersCount)
	{
		((delegate* unmanaged[Stdcall]<ID2D1GeometrySink*, QuadraticBezierSegment*, uint, void>)(lpVtbl[10]))((ID2D1GeometrySink*)Unsafe.AsPointer(ref this), beziers, beziersCount);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1GeometrySink::AddArc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public void AddArc(ArcSegment* arc)
	{
		((delegate* unmanaged[Stdcall]<ID2D1GeometrySink*, ArcSegment*, void>)(lpVtbl[11]))((ID2D1GeometrySink*)Unsafe.AsPointer(ref this), arc);
	}
}

