// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgPathData"]/*' />
/// <unmanaged>ID2D1SvgPathData</unmanaged>
[Guid("c095e4f4-bb98-43d6-9745-4d1b84ec9888")]
[NativeTypeName("struct ID2D1SvgPathData : ID2D1SvgAttribute")]
[NativeInheritance("ID2D1SvgAttribute")]
public unsafe partial struct ID2D1SvgPathData : INativeGuid
{
	public static ref readonly Guid IID_ID2D1SvgPathData
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xF4, 0xE4, 0x95, 0xC0,
				0x98, 0xBB,
				0xD6, 0x43,
				0x97,
				0x45,
				0x4D,
				0x1B,
				0x84,
				0xEC,
				0x98,
				0x88
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1SvgPathData));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1SvgPathData));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, uint>)(lpVtbl[1]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, uint>)(lpVtbl[2]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1Resource.GetFactory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetFactory(ID2D1Factory** factory)
	{
		((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), factory);
	}

	/// <inheritdoc cref="ID2D1SvgAttribute.GetElement" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void GetElement(ID2D1SvgElement** element)
	{
		((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, ID2D1SvgElement**, void>)(lpVtbl[4]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), element);
	}

	/// <inheritdoc cref="ID2D1SvgAttribute.Clone" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult Clone(ID2D1SvgAttribute** attribute)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, ID2D1SvgAttribute**, int>)(lpVtbl[5]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), attribute);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgPathData::RemoveSegmentDataAtEnd"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult RemoveSegmentDataAtEnd(uint dataCount)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, uint, int>)(lpVtbl[6]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), dataCount);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgPathData::UpdateSegmentData"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult UpdateSegmentData(float* data, uint dataCount, uint startIndex)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, float*, uint, uint, int>)(lpVtbl[7]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), data, dataCount, startIndex);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgPathData::GetSegmentData"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetSegmentData(float* data, uint dataCount, uint startIndex)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, float*, uint, uint, int>)(lpVtbl[8]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), data, dataCount, startIndex);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgPathData::GetSegmentDataCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public uint GetSegmentDataCount()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, uint>)(lpVtbl[9]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgPathData::RemoveCommandsAtEnd"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult RemoveCommandsAtEnd(uint commandsCount)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, uint, int>)(lpVtbl[10]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), commandsCount);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgPathData::UpdateCommands"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult UpdateCommands(SvgPathCommand* commands, uint commandsCount, uint startIndex)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, SvgPathCommand*, uint, uint, int>)(lpVtbl[11]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), commands, commandsCount, startIndex);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgPathData::GetCommands"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult GetCommands(SvgPathCommand* commands, uint commandsCount, uint startIndex)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, SvgPathCommand*, uint, uint, int>)(lpVtbl[12]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), commands, commandsCount, startIndex);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgPathData::GetCommandsCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public uint GetCommandsCount()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, uint>)(lpVtbl[13]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgPathData::CreatePathGeometry"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult CreatePathGeometry(Common.FillMode fillMode, ID2D1PathGeometry1** pathGeometry)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, Common.FillMode, ID2D1PathGeometry1**, int>)(lpVtbl[14]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), fillMode, pathGeometry);
	}
}

