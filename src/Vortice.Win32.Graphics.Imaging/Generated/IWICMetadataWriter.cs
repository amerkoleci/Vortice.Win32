// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Imaging;

/// <include file='../Imaging.xml' path='doc/member[@name="IWICMetadataWriter"]/*' />
/// <unmanaged>IWICMetadataWriter</unmanaged>
[Guid("f7836e16-3be0-470b-86bb-160d0aecd7de")]
[NativeTypeName("struct IWICMetadataWriter : IWICMetadataReader")]
[NativeInheritance("IWICMetadataReader")]
public unsafe partial struct IWICMetadataWriter : IWICMetadataWriter.Interface, INativeGuid
{
	public static ref readonly Guid IID_IWICMetadataWriter
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x16, 0x6E, 0x83, 0xF7,
				0xE0, 0x3B,
				0x0B, 0x47,
				0x86,
				0xBB,
				0x16,
				0x0D,
				0x0A,
				0xEC,
				0xD7,
				0xDE
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICMetadataWriter));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICMetadataWriter*, Guid*, void**, int>)(lpVtbl[0]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<IWICMetadataWriter*, uint>)(lpVtbl[1]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<IWICMetadataWriter*, uint>)(lpVtbl[2]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IWICMetadataReader.GetMetadataFormat" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetMetadataFormat(Guid* pguidMetadataFormat)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICMetadataWriter*, Guid*, int>)(lpVtbl[3]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this), pguidMetadataFormat);
	}

	/// <inheritdoc cref="IWICMetadataReader.GetMetadataHandlerInfo" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetMetadataHandlerInfo(IWICMetadataHandlerInfo** ppIHandler)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICMetadataWriter*, IWICMetadataHandlerInfo**, int>)(lpVtbl[4]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this), ppIHandler);
	}

	/// <inheritdoc cref="IWICMetadataReader.GetCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetCount(uint* pcCount)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICMetadataWriter*, uint*, int>)(lpVtbl[5]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this), pcCount);
	}

	/// <inheritdoc cref="IWICMetadataReader.GetValueByIndex" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetValueByIndex(uint nIndex, Com.Variant** pvarSchema, Com.Variant** pvarId, Com.Variant** pvarValue)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICMetadataWriter*, uint, Com.Variant**, Com.Variant**, Com.Variant**, int>)(lpVtbl[6]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this), nIndex, pvarSchema, pvarId, pvarValue);
	}

	/// <inheritdoc cref="IWICMetadataReader.GetValue" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetValue(Com.Variant* pvarSchema, Com.Variant* pvarId, Com.Variant** pvarValue)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICMetadataWriter*, Com.Variant*, Com.Variant*, Com.Variant**, int>)(lpVtbl[7]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this), pvarSchema, pvarId, pvarValue);
	}

	/// <inheritdoc cref="IWICMetadataReader.GetEnumerator" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetEnumerator(IWICEnumMetadataItem** ppIEnumMetadata)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICMetadataWriter*, IWICEnumMetadataItem**, int>)(lpVtbl[8]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this), ppIEnumMetadata);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICMetadataWriter::SetValue"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult SetValue(Com.Variant* pvarSchema, Com.Variant* pvarId, Com.Variant* pvarValue)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICMetadataWriter*, Com.Variant*, Com.Variant*, Com.Variant*, int>)(lpVtbl[9]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this), pvarSchema, pvarId, pvarValue);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICMetadataWriter::SetValueByIndex"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetValueByIndex(uint nIndex, Com.Variant* pvarSchema, Com.Variant* pvarId, Com.Variant* pvarValue)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICMetadataWriter*, uint, Com.Variant*, Com.Variant*, Com.Variant*, int>)(lpVtbl[10]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this), nIndex, pvarSchema, pvarId, pvarValue);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICMetadataWriter::RemoveValue"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult RemoveValue(Com.Variant* pvarSchema, Com.Variant* pvarId)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICMetadataWriter*, Com.Variant*, Com.Variant*, int>)(lpVtbl[11]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this), pvarSchema, pvarId);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICMetadataWriter::RemoveValueByIndex"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult RemoveValueByIndex(uint nIndex)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICMetadataWriter*, uint, int>)(lpVtbl[12]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this), nIndex);
	}

	public interface Interface : IWICMetadataReader.Interface
	{
		[VtblIndex(9)]
		HResult SetValue(Com.Variant* pvarSchema, Com.Variant* pvarId, Com.Variant* pvarValue);

		[VtblIndex(10)]
		HResult SetValueByIndex(uint nIndex, Com.Variant* pvarSchema, Com.Variant* pvarId, Com.Variant* pvarValue);

		[VtblIndex(11)]
		HResult RemoveValue(Com.Variant* pvarSchema, Com.Variant* pvarId);

		[VtblIndex(12)]
		HResult RemoveValueByIndex(uint nIndex);
	}
}

