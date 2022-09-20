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

/// <include file='../../Imaging.xml' path='doc/member[@name="IWICMetadataBlockWriter"]/*' />
/// <unmanaged>IWICMetadataBlockWriter</unmanaged>
[Guid("08fb9676-b444-41e8-8dbe-6a53a542bff1")]
[NativeTypeName("struct IWICMetadataBlockWriter : IWICMetadataBlockReader")]
[NativeInheritance("IWICMetadataBlockReader")]
public unsafe partial struct IWICMetadataBlockWriter
{
	public static ref readonly Guid IID_IWICMetadataBlockWriter
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x76, 0x96, 0xFB, 0x08,
				0x44, 0xB4,
				0xE8, 0x41,
				0x8D,
				0xBE,
				0x6A,
				0x53,
				0xA5,
				0x42,
				0xBF,
				0xF1
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICMetadataBlockWriter));

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

	/// <inheritdoc cref="IWICMetadataBlockReader.GetContainerFormat" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetContainerFormat(Guid* pguidContainerFormat)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, Guid*, int>)(lpVtbl[3]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pguidContainerFormat);
	}

	/// <inheritdoc cref="IWICMetadataBlockReader.GetCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetCount(uint* pcCount)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, uint*, int>)(lpVtbl[4]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pcCount);
	}

	/// <inheritdoc cref="IWICMetadataBlockReader.GetReaderByIndex" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetReaderByIndex(uint nIndex, IWICMetadataReader** ppIMetadataReader)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, uint, IWICMetadataReader**, int>)(lpVtbl[5]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex, ppIMetadataReader);
	}

	/// <inheritdoc cref="IWICMetadataBlockReader.GetEnumerator" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetEnumerator(Com.IEnumUnknown** ppIEnumMetadata)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, Com.IEnumUnknown**, int>)(lpVtbl[6]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), ppIEnumMetadata);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICMetadataBlockWriter::InitializeFromBlockReader"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult InitializeFromBlockReader(IWICMetadataBlockReader* pIMDBlockReader)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, IWICMetadataBlockReader*, int>)(lpVtbl[7]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pIMDBlockReader);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICMetadataBlockWriter::GetWriterByIndex"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetWriterByIndex(uint nIndex, IWICMetadataWriter** ppIMetadataWriter)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, uint, IWICMetadataWriter**, int>)(lpVtbl[8]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex, ppIMetadataWriter);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICMetadataBlockWriter::AddWriter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult AddWriter(IWICMetadataWriter* pIMetadataWriter)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, IWICMetadataWriter*, int>)(lpVtbl[9]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), pIMetadataWriter);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICMetadataBlockWriter::SetWriterByIndex"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetWriterByIndex(uint nIndex, IWICMetadataWriter* pIMetadataWriter)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, uint, IWICMetadataWriter*, int>)(lpVtbl[10]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex, pIMetadataWriter);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICMetadataBlockWriter::RemoveWriterByIndex"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult RemoveWriterByIndex(uint nIndex)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataBlockWriter*, uint, int>)(lpVtbl[11]))((IWICMetadataBlockWriter*)Unsafe.AsPointer(ref this), nIndex);
	}
}

