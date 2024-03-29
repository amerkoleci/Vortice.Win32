// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteInlineObject"]/*' />
/// <unmanaged>IDWriteInlineObject</unmanaged>
[Guid("8339fde3-106f-47ab-8373-1c6295eb10b3")]
[NativeTypeName("struct IDWriteInlineObject : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteInlineObject : IDWriteInlineObject.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDWriteInlineObject
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xE3, 0xFD, 0x39, 0x83,
				0x6F, 0x10,
				0xAB, 0x47,
				0x83,
				0x73,
				0x1C,
				0x62,
				0x95,
				0xEB,
				0x10,
				0xB3
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteInlineObject));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteInlineObject*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteInlineObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteInlineObject*, uint>)(lpVtbl[1]))((IDWriteInlineObject*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteInlineObject*, uint>)(lpVtbl[2]))((IDWriteInlineObject*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteInlineObject::Draw"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult Draw(void* clientDrawingContext, IDWriteTextRenderer* renderer, float originX, float originY, Bool32 isSideways, Bool32 isRightToLeft, IUnknown* clientDrawingEffect)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteInlineObject*, void*, IDWriteTextRenderer*, float, float, Bool32, Bool32, IUnknown*, int>)(lpVtbl[3]))((IDWriteInlineObject*)Unsafe.AsPointer(ref this), clientDrawingContext, renderer, originX, originY, isSideways, isRightToLeft, clientDrawingEffect);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteInlineObject::GetMetrics"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetMetrics(InlineObjectMetrics* metrics)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteInlineObject*, InlineObjectMetrics*, int>)(lpVtbl[4]))((IDWriteInlineObject*)Unsafe.AsPointer(ref this), metrics);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteInlineObject::GetOverhangMetrics"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetOverhangMetrics(OverhangMetrics* overhangs)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteInlineObject*, OverhangMetrics*, int>)(lpVtbl[5]))((IDWriteInlineObject*)Unsafe.AsPointer(ref this), overhangs);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteInlineObject::GetBreakConditions"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetBreakConditions(BreakCondition* breakConditionBefore, BreakCondition* breakConditionAfter)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteInlineObject*, BreakCondition*, BreakCondition*, int>)(lpVtbl[6]))((IDWriteInlineObject*)Unsafe.AsPointer(ref this), breakConditionBefore, breakConditionAfter);
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult Draw(void* clientDrawingContext, IDWriteTextRenderer* renderer, float originX, float originY, Bool32 isSideways, Bool32 isRightToLeft, IUnknown* clientDrawingEffect);

		[VtblIndex(4)]
		HResult GetMetrics(InlineObjectMetrics* metrics);

		[VtblIndex(5)]
		HResult GetOverhangMetrics(OverhangMetrics* overhangs);

		[VtblIndex(6)]
		HResult GetBreakConditions(BreakCondition* breakConditionBefore, BreakCondition* breakConditionAfter);
	}
}

