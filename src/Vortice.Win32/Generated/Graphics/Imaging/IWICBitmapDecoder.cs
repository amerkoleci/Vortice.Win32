// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Imaging;

/// <include file='../../Imaging.xml' path='doc/member[@name="IWICBitmapDecoder"]/*' />
/// <unmanaged>IWICBitmapDecoder</unmanaged>
[Guid("9edde9e7-8dee-47ea-99df-e6faf2ed44bf")]
[NativeTypeName("struct IWICBitmapDecoder : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICBitmapDecoder
{
	public static ref readonly Guid IID_IWICBitmapDecoder
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xE7, 0xE9, 0xDD, 0x9E,
				0xEE, 0x8D,
				0xEA, 0x47,
				0x99,
				0xDF,
				0xE6,
				0xFA,
				0xF2,
				0xED,
				0x44,
				0xBF
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapDecoder));

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

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICBitmapDecoder::QueryCapability"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult QueryCapability(Com.IStream* pIStream, uint* pdwCapability)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, Com.IStream*, uint*, int>)(lpVtbl[3]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), pIStream, pdwCapability);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICBitmapDecoder::Initialize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult Initialize(Com.IStream* pIStream, WICDecodeOptions cacheOptions)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, Com.IStream*, WICDecodeOptions, int>)(lpVtbl[4]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), pIStream, cacheOptions);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICBitmapDecoder::GetContainerFormat"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetContainerFormat(Guid* pguidContainerFormat)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, Guid*, int>)(lpVtbl[5]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), pguidContainerFormat);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICBitmapDecoder::GetDecoderInfo"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetDecoderInfo(IWICBitmapDecoderInfo** ppIDecoderInfo)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, IWICBitmapDecoderInfo**, int>)(lpVtbl[6]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), ppIDecoderInfo);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICBitmapDecoder::CopyPalette"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CopyPalette(IWICPalette* pIPalette)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, IWICPalette*, int>)(lpVtbl[7]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), pIPalette);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICBitmapDecoder::GetMetadataQueryReader"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetMetadataQueryReader(IWICMetadataQueryReader** ppIMetadataQueryReader)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, IWICMetadataQueryReader**, int>)(lpVtbl[8]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), ppIMetadataQueryReader);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICBitmapDecoder::GetPreview"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetPreview(IWICBitmapSource** ppIBitmapSource)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, IWICBitmapSource**, int>)(lpVtbl[9]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), ppIBitmapSource);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICBitmapDecoder::GetColorContexts"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult GetColorContexts(uint cCount, IWICColorContext** ppIColorContexts, uint* pcActualCount)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, uint, IWICColorContext**, uint*, int>)(lpVtbl[10]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), cCount, ppIColorContexts, pcActualCount);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICBitmapDecoder::GetThumbnail"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetThumbnail(IWICBitmapSource** ppIThumbnail)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, IWICBitmapSource**, int>)(lpVtbl[11]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), ppIThumbnail);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICBitmapDecoder::GetFrameCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult GetFrameCount(uint* pCount)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, uint*, int>)(lpVtbl[12]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), pCount);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICBitmapDecoder::GetFrame"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult GetFrame(uint index, IWICBitmapFrameDecode** ppIBitmapFrame)
	{
		return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, uint, IWICBitmapFrameDecode**, int>)(lpVtbl[13]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), index, ppIBitmapFrame);
	}
}

