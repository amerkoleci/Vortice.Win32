// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Imaging;

/// <include file='../Imaging.xml' path='doc/member[@name="IWICComponentFactory"]/*' />
/// <unmanaged>IWICComponentFactory</unmanaged>
[Guid("412d0c3a-9650-44fa-af5b-dd2a06c8e8fb")]
[NativeTypeName("struct IWICComponentFactory : IWICImagingFactory")]
[NativeInheritance("IWICImagingFactory")]
public unsafe partial struct IWICComponentFactory : IWICComponentFactory.Interface, INativeGuid
{
	public static ref readonly Guid IID_IWICComponentFactory
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x3A, 0x0C, 0x2D, 0x41,
				0x50, 0x96,
				0xFA, 0x44,
				0xAF,
				0x5B,
				0xDD,
				0x2A,
				0x06,
				0xC8,
				0xE8,
				0xFB
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICComponentFactory));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, Guid*, void**, int>)(lpVtbl[0]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, uint>)(lpVtbl[1]))((IWICComponentFactory*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, uint>)(lpVtbl[2]))((IWICComponentFactory*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateDecoderFromFilename" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult CreateDecoderFromFilename(char* wzFilename, Guid* pguidVendor, NativeFileAccess dwDesiredAccess, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, char*, Guid*, NativeFileAccess, WICDecodeOptions, IWICBitmapDecoder**, int>)(lpVtbl[3]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoder);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateDecoderFromStream" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult CreateDecoderFromStream(Com.IStream* pIStream, Guid* pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, Com.IStream*, Guid*, WICDecodeOptions, IWICBitmapDecoder**, int>)(lpVtbl[4]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIStream, pguidVendor, metadataOptions, ppIDecoder);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateDecoderFromFileHandle" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult CreateDecoderFromFileHandle(nuint hFile, Guid* pguidVendor, WICDecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, nuint, Guid*, WICDecodeOptions, IWICBitmapDecoder**, int>)(lpVtbl[5]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), hFile, pguidVendor, metadataOptions, ppIDecoder);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateComponentInfo" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult CreateComponentInfo(Guid* clsidComponent, IWICComponentInfo** ppIInfo)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, Guid*, IWICComponentInfo**, int>)(lpVtbl[6]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), clsidComponent, ppIInfo);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateDecoder" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CreateDecoder(Guid* guidContainerFormat, Guid* pguidVendor, IWICBitmapDecoder** ppIDecoder)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, Guid*, Guid*, IWICBitmapDecoder**, int>)(lpVtbl[7]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, ppIDecoder);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateEncoder" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateEncoder(Guid* guidContainerFormat, Guid* pguidVendor, IWICBitmapEncoder** ppIEncoder)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, Guid*, Guid*, IWICBitmapEncoder**, int>)(lpVtbl[8]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, ppIEncoder);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreatePalette" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult CreatePalette(IWICPalette** ppIPalette)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, IWICPalette**, int>)(lpVtbl[9]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIPalette);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateFormatConverter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult CreateFormatConverter(IWICFormatConverter** ppIFormatConverter)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, IWICFormatConverter**, int>)(lpVtbl[10]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIFormatConverter);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateBitmapScaler" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult CreateBitmapScaler(IWICBitmapScaler** ppIBitmapScaler)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, IWICBitmapScaler**, int>)(lpVtbl[11]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIBitmapScaler);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateBitmapClipper" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult CreateBitmapClipper(IWICBitmapClipper** ppIBitmapClipper)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, IWICBitmapClipper**, int>)(lpVtbl[12]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIBitmapClipper);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateBitmapFlipRotator" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult CreateBitmapFlipRotator(IWICBitmapFlipRotator** ppIBitmapFlipRotator)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, IWICBitmapFlipRotator**, int>)(lpVtbl[13]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIBitmapFlipRotator);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateStream" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult CreateStream(IWICStream** ppIWICStream)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, IWICStream**, int>)(lpVtbl[14]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIWICStream);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateColorContext" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult CreateColorContext(IWICColorContext** ppIWICColorContext)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, IWICColorContext**, int>)(lpVtbl[15]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIWICColorContext);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateColorTransformer" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult CreateColorTransformer(IWICColorTransform** ppIWICColorTransform)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, IWICColorTransform**, int>)(lpVtbl[16]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppIWICColorTransform);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateBitmap" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult CreateBitmap(uint uiWidth, uint uiHeight, Guid* pixelFormat, WICBitmapCreateCacheOption option, IWICBitmap** ppIBitmap)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, uint, uint, Guid*, WICBitmapCreateCacheOption, IWICBitmap**, int>)(lpVtbl[17]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), uiWidth, uiHeight, pixelFormat, option, ppIBitmap);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateBitmapFromSource" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult CreateBitmapFromSource(IWICBitmapSource* pIBitmapSource, WICBitmapCreateCacheOption option, IWICBitmap** ppIBitmap)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, IWICBitmapSource*, WICBitmapCreateCacheOption, IWICBitmap**, int>)(lpVtbl[18]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIBitmapSource, option, ppIBitmap);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateBitmapFromSourceRect" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult CreateBitmapFromSourceRect(IWICBitmapSource* pIBitmapSource, uint x, uint y, uint width, uint height, IWICBitmap** ppIBitmap)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, IWICBitmapSource*, uint, uint, uint, uint, IWICBitmap**, int>)(lpVtbl[19]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIBitmapSource, x, y, width, height, ppIBitmap);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateBitmapFromMemory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult CreateBitmapFromMemory(uint uiWidth, uint uiHeight, Guid* pixelFormat, uint cbStride, uint cbBufferSize, byte* pbBuffer, IWICBitmap** ppIBitmap)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)(lpVtbl[20]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBuffer, ppIBitmap);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateBitmapFromHBITMAP" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult CreateBitmapFromHBITMAP(IntPtr hBitmap, IntPtr hPalette, WICBitmapAlphaChannelOption options, IWICBitmap** ppIBitmap)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, IntPtr, IntPtr, WICBitmapAlphaChannelOption, IWICBitmap**, int>)(lpVtbl[21]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), hBitmap, hPalette, options, ppIBitmap);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateBitmapFromHICON" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult CreateBitmapFromHICON(IntPtr hIcon, IWICBitmap** ppIBitmap)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, IntPtr, IWICBitmap**, int>)(lpVtbl[22]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), hIcon, ppIBitmap);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateComponentEnumerator" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public HResult CreateComponentEnumerator(uint componentTypes, uint options, Com.IEnumUnknown** ppIEnumUnknown)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, uint, uint, Com.IEnumUnknown**, int>)(lpVtbl[23]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), componentTypes, options, ppIEnumUnknown);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateFastMetadataEncoderFromDecoder" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult CreateFastMetadataEncoderFromDecoder(IWICBitmapDecoder* pIDecoder, IWICFastMetadataEncoder** ppIFastEncoder)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, IWICBitmapDecoder*, IWICFastMetadataEncoder**, int>)(lpVtbl[24]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIDecoder, ppIFastEncoder);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateFastMetadataEncoderFromFrameDecode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public HResult CreateFastMetadataEncoderFromFrameDecode(IWICBitmapFrameDecode* pIFrameDecoder, IWICFastMetadataEncoder** ppIFastEncoder)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, IWICBitmapFrameDecode*, IWICFastMetadataEncoder**, int>)(lpVtbl[25]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIFrameDecoder, ppIFastEncoder);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateQueryWriter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public HResult CreateQueryWriter(Guid* guidMetadataFormat, Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, Guid*, Guid*, IWICMetadataQueryWriter**, int>)(lpVtbl[26]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), guidMetadataFormat, pguidVendor, ppIQueryWriter);
	}

	/// <inheritdoc cref="IWICImagingFactory.CreateQueryWriterFromReader" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public HResult CreateQueryWriterFromReader(IWICMetadataQueryReader* pIQueryReader, Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int>)(lpVtbl[27]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIQueryReader, pguidVendor, ppIQueryWriter);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICComponentFactory::CreateMetadataReader"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public HResult CreateMetadataReader(Guid* guidMetadataFormat, Guid* pguidVendor, uint dwOptions, Com.IStream* pIStream, IWICMetadataReader** ppIReader)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, Guid*, Guid*, uint, Com.IStream*, IWICMetadataReader**, int>)(lpVtbl[28]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), guidMetadataFormat, pguidVendor, dwOptions, pIStream, ppIReader);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICComponentFactory::CreateMetadataReaderFromContainer"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(29)]
	public HResult CreateMetadataReaderFromContainer(Guid* guidContainerFormat, Guid* pguidVendor, uint dwOptions, Com.IStream* pIStream, IWICMetadataReader** ppIReader)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, Guid*, Guid*, uint, Com.IStream*, IWICMetadataReader**, int>)(lpVtbl[29]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), guidContainerFormat, pguidVendor, dwOptions, pIStream, ppIReader);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICComponentFactory::CreateMetadataWriter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(30)]
	public HResult CreateMetadataWriter(Guid* guidMetadataFormat, Guid* pguidVendor, uint dwMetadataOptions, IWICMetadataWriter** ppIWriter)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, Guid*, Guid*, uint, IWICMetadataWriter**, int>)(lpVtbl[30]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), guidMetadataFormat, pguidVendor, dwMetadataOptions, ppIWriter);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICComponentFactory::CreateMetadataWriterFromReader"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(31)]
	public HResult CreateMetadataWriterFromReader(IWICMetadataReader* pIReader, Guid* pguidVendor, IWICMetadataWriter** ppIWriter)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, IWICMetadataReader*, Guid*, IWICMetadataWriter**, int>)(lpVtbl[31]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIReader, pguidVendor, ppIWriter);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICComponentFactory::CreateQueryReaderFromBlockReader"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(32)]
	public HResult CreateQueryReaderFromBlockReader(IWICMetadataBlockReader* pIBlockReader, IWICMetadataQueryReader** ppIQueryReader)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, IWICMetadataBlockReader*, IWICMetadataQueryReader**, int>)(lpVtbl[32]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIBlockReader, ppIQueryReader);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICComponentFactory::CreateQueryWriterFromBlockWriter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(33)]
	public HResult CreateQueryWriterFromBlockWriter(IWICMetadataBlockWriter* pIBlockWriter, IWICMetadataQueryWriter** ppIQueryWriter)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, IWICMetadataBlockWriter*, IWICMetadataQueryWriter**, int>)(lpVtbl[33]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), pIBlockWriter, ppIQueryWriter);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICComponentFactory::CreateEncoderPropertyBag"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(34)]
	public HResult CreateEncoderPropertyBag(Com.PropertyBagMetadata** ppropOptions, uint cCount, Com.IPropertyBag2** ppIPropertyBag)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICComponentFactory*, Com.PropertyBagMetadata**, uint, Com.IPropertyBag2**, int>)(lpVtbl[34]))((IWICComponentFactory*)Unsafe.AsPointer(ref this), ppropOptions, cCount, ppIPropertyBag);
	}

	public interface Interface : IWICImagingFactory.Interface
	{
		[VtblIndex(28)]
		HResult CreateMetadataReader(Guid* guidMetadataFormat, Guid* pguidVendor, uint dwOptions, Com.IStream* pIStream, IWICMetadataReader** ppIReader);

		[VtblIndex(29)]
		HResult CreateMetadataReaderFromContainer(Guid* guidContainerFormat, Guid* pguidVendor, uint dwOptions, Com.IStream* pIStream, IWICMetadataReader** ppIReader);

		[VtblIndex(30)]
		HResult CreateMetadataWriter(Guid* guidMetadataFormat, Guid* pguidVendor, uint dwMetadataOptions, IWICMetadataWriter** ppIWriter);

		[VtblIndex(31)]
		HResult CreateMetadataWriterFromReader(IWICMetadataReader* pIReader, Guid* pguidVendor, IWICMetadataWriter** ppIWriter);

		[VtblIndex(32)]
		HResult CreateQueryReaderFromBlockReader(IWICMetadataBlockReader* pIBlockReader, IWICMetadataQueryReader** ppIQueryReader);

		[VtblIndex(33)]
		HResult CreateQueryWriterFromBlockWriter(IWICMetadataBlockWriter* pIBlockWriter, IWICMetadataQueryWriter** ppIQueryWriter);

		[VtblIndex(34)]
		HResult CreateEncoderPropertyBag(Com.PropertyBagMetadata** ppropOptions, uint cCount, Com.IPropertyBag2** ppIPropertyBag);
	}
}

