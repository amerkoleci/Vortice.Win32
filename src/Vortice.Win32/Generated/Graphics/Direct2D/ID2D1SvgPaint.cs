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

namespace Win32.Graphics.Direct2D;

/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1SvgPaint"]/*' />
/// <unmanaged>ID2D1SvgPaint</unmanaged>
[Guid("d59bab0a-68a2-455b-a5dc-9eb2854e2490")]
[NativeTypeName("struct ID2D1SvgPaint : ID2D1SvgAttribute")]
[NativeInheritance("ID2D1SvgAttribute")]
public unsafe partial struct ID2D1SvgPaint
{
	public static ref readonly Guid IID_ID2D1SvgPaint
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x0A, 0xAB, 0x9B, 0xD5,
				0xA2, 0x68,
				0x5B, 0x45,
				0xA5,
				0xDC,
				0x9E,
				0xB2,
				0x85,
				0x4E,
				0x24,
				0x90
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1SvgPaint));

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

	/// <inheritdoc cref="ID2D1Resource.GetFactory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetFactory(ID2D1Factory** factory)
	{
		((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), factory);
	}

	/// <inheritdoc cref="ID2D1SvgAttribute.GetElement" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void GetElement(ID2D1SvgElement** element)
	{
		((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, ID2D1SvgElement**, void>)(lpVtbl[4]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), element);
	}

	/// <inheritdoc cref="ID2D1SvgAttribute.Clone" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult Clone(ID2D1SvgAttribute** attribute)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, ID2D1SvgAttribute**, int>)(lpVtbl[5]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), attribute);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1SvgPaint::SetPaintType"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetPaintType(SvgPaintType paintType)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, SvgPaintType, int>)(lpVtbl[6]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), paintType);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1SvgPaint::GetPaintType"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public SvgPaintType GetPaintType()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, SvgPaintType>)(lpVtbl[7]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1SvgPaint::SetColor"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult SetColor(Color4* color)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, Color4*, int>)(lpVtbl[8]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), color);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1SvgPaint::GetColor"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public void GetColor(Color4** color)
	{
		((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, Color4**, void>)(lpVtbl[9]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), color);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1SvgPaint::SetId"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetId(ushort* id)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, ushort*, int>)(lpVtbl[10]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), id);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1SvgPaint::GetId"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetId(ushort* id, uint idCount)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, ushort*, uint, int>)(lpVtbl[11]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this), id, idCount);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1SvgPaint::GetIdLength"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public uint GetIdLength()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, uint>)(lpVtbl[12]))((ID2D1SvgPaint*)Unsafe.AsPointer(ref this));
	}
}

