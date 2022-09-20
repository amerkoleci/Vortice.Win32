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

namespace Win32.Graphics.Imaging;

/// <include file='../../Imaging.xml' path='doc/member[@name="IWICMetadataReader"]/*' />
/// <unmanaged>IWICMetadataReader</unmanaged>
[Guid("9204fe99-d8fc-4fd5-a001-9536b067a899")]
[NativeTypeName("struct IWICMetadataReader : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICMetadataReader
{
	public static ref readonly Guid IID_IWICMetadataReader
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x99, 0xFE, 0x04, 0x92,
				0xFC, 0xD8,
				0xD5, 0x4F,
				0xA0,
				0x01,
				0x95,
				0x36,
				0xB0,
				0x67,
				0xA8,
				0x99
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICMetadataReader));

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

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICMetadataReader::GetMetadataFormat"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetMetadataFormat(Guid* pguidMetadataFormat)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, Guid*, int>)(lpVtbl[3]))((IWICMetadataReader*)Unsafe.AsPointer(ref this), pguidMetadataFormat);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICMetadataReader::GetMetadataHandlerInfo"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetMetadataHandlerInfo(IWICMetadataHandlerInfo** ppIHandler)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, IWICMetadataHandlerInfo**, int>)(lpVtbl[4]))((IWICMetadataReader*)Unsafe.AsPointer(ref this), ppIHandler);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICMetadataReader::GetCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetCount(uint* pcCount)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, uint*, int>)(lpVtbl[5]))((IWICMetadataReader*)Unsafe.AsPointer(ref this), pcCount);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICMetadataReader::GetValueByIndex"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetValueByIndex(uint nIndex, Com.Variant** pvarSchema, Com.Variant** pvarId, Com.Variant** pvarValue)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, uint, Com.Variant**, Com.Variant**, Com.Variant**, int>)(lpVtbl[6]))((IWICMetadataReader*)Unsafe.AsPointer(ref this), nIndex, pvarSchema, pvarId, pvarValue);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICMetadataReader::GetValue"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetValue(Com.Variant* pvarSchema, Com.Variant* pvarId, Com.Variant** pvarValue)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, Com.Variant*, Com.Variant*, Com.Variant**, int>)(lpVtbl[7]))((IWICMetadataReader*)Unsafe.AsPointer(ref this), pvarSchema, pvarId, pvarValue);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICMetadataReader::GetEnumerator"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetEnumerator(IWICEnumMetadataItem** ppIEnumMetadata)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, IWICEnumMetadataItem**, int>)(lpVtbl[8]))((IWICMetadataReader*)Unsafe.AsPointer(ref this), ppIEnumMetadata);
	}
}

