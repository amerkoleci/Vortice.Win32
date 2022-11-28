// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext"]/*' />
/// <unmanaged>ID3D11VideoContext</unmanaged>
[Guid("61f21c45-3c0e-4a74-9cea-67100d9ad5e4")]
[NativeTypeName("struct ID3D11VideoContext : ID3D11DeviceChild")]
[NativeInheritance("ID3D11DeviceChild")]
public unsafe partial struct ID3D11VideoContext : INativeGuid
{
	public static ref readonly Guid IID_ID3D11VideoContext
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x45, 0x1C, 0xF2, 0x61,
				0x0E, 0x3C,
				0x74, 0x4A,
				0x9C,
				0xEA,
				0x67,
				0x10,
				0x0D,
				0x9A,
				0xD5,
				0xE4
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11VideoContext));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11VideoContext));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, uint>)(lpVtbl[1]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, uint>)(lpVtbl[2]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetDevice(ID3D11Device** ppDevice)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), ppDevice);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), guid, pData);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::GetDecoderBuffer"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetDecoderBuffer(ID3D11VideoDecoder* pDecoder, VideoDecoderBufferType Type, uint* pBufferSize, void** ppBuffer)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)(lpVtbl[7]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pDecoder, Type, pBufferSize, ppBuffer);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::ReleaseDecoderBuffer"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult ReleaseDecoderBuffer(ID3D11VideoDecoder* pDecoder, VideoDecoderBufferType Type)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, int>)(lpVtbl[8]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pDecoder, Type);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::DecoderBeginFrame"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult DecoderBeginFrame(ID3D11VideoDecoder* pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, void* pContentKey)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)(lpVtbl[9]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pDecoder, pView, ContentKeySize, pContentKey);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::DecoderEndFrame"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult DecoderEndFrame(ID3D11VideoDecoder* pDecoder)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, int>)(lpVtbl[10]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pDecoder);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::SubmitDecoderBuffers"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult SubmitDecoderBuffers(ID3D11VideoDecoder* pDecoder, uint NumBuffers, VideoDecoderBufferDescription* pBufferDesc)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDescription*, int>)(lpVtbl[11]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pDecoder, NumBuffers, pBufferDesc);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::DecoderExtension"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public int DecoderExtension(ID3D11VideoDecoder* pDecoder, VideoDecoderExtension* pExtensionData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderExtension*, int>)(lpVtbl[12]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pDecoder, pExtensionData);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorSetOutputTargetRect"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public void VideoProcessorSetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, Bool32 Enable, RawRect* pRect)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, Bool32, RawRect*, void>)(lpVtbl[13]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, Enable, pRect);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorSetOutputBackgroundColor"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public void VideoProcessorSetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, Bool32 YCbCr, VideoColor* pColor)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, Bool32, VideoColor*, void>)(lpVtbl[14]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, YCbCr, pColor);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorSetOutputColorSpace"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public void VideoProcessorSetOutputColorSpace(ID3D11VideoProcessor* pVideoProcessor, VideoProcessorColorSpace* pColorSpace)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)(lpVtbl[15]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, pColorSpace);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorSetOutputAlphaFillMode"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public void VideoProcessorSetOutputAlphaFillMode(ID3D11VideoProcessor* pVideoProcessor, VideoProcessorAlphaFillMode AlphaFillMode, uint StreamIndex)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode, uint, void>)(lpVtbl[16]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, AlphaFillMode, StreamIndex);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorSetOutputConstriction"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public void VideoProcessorSetOutputConstriction(ID3D11VideoProcessor* pVideoProcessor, Bool32 Enable, System.Drawing.Size Size)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, Bool32, System.Drawing.Size, void>)(lpVtbl[17]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, Enable, Size);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorSetOutputStereoMode"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public void VideoProcessorSetOutputStereoMode(ID3D11VideoProcessor* pVideoProcessor, Bool32 Enable)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, Bool32, void>)(lpVtbl[18]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, Enable);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorSetOutputExtension"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public int VideoProcessorSetOutputExtension(ID3D11VideoProcessor* pVideoProcessor, Guid* pExtensionGuid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)(lpVtbl[19]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, pExtensionGuid, DataSize, pData);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorGetOutputTargetRect"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public void VideoProcessorGetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, Bool32* Enabled, RawRect* pRect)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, Bool32*, RawRect*, void>)(lpVtbl[20]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, Enabled, pRect);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorGetOutputBackgroundColor"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public void VideoProcessorGetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, Bool32* pYCbCr, VideoColor* pColor)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, Bool32*, VideoColor*, void>)(lpVtbl[21]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, pYCbCr, pColor);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorGetOutputColorSpace"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public void VideoProcessorGetOutputColorSpace(ID3D11VideoProcessor* pVideoProcessor, VideoProcessorColorSpace* pColorSpace)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)(lpVtbl[22]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, pColorSpace);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorGetOutputAlphaFillMode"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public void VideoProcessorGetOutputAlphaFillMode(ID3D11VideoProcessor* pVideoProcessor, VideoProcessorAlphaFillMode* pAlphaFillMode, uint* pStreamIndex)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)(lpVtbl[23]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, pAlphaFillMode, pStreamIndex);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorGetOutputConstriction"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public void VideoProcessorGetOutputConstriction(ID3D11VideoProcessor* pVideoProcessor, Bool32* pEnabled, System.Drawing.Size* pSize)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, Bool32*, System.Drawing.Size*, void>)(lpVtbl[24]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, pEnabled, pSize);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorGetOutputStereoMode"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public void VideoProcessorGetOutputStereoMode(ID3D11VideoProcessor* pVideoProcessor, Bool32* pEnabled)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, Bool32*, void>)(lpVtbl[25]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, pEnabled);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorGetOutputExtension"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public int VideoProcessorGetOutputExtension(ID3D11VideoProcessor* pVideoProcessor, Guid* pExtensionGuid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)(lpVtbl[26]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, pExtensionGuid, DataSize, pData);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorSetStreamFrameFormat"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public void VideoProcessorSetStreamFrameFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoFrameFormat FrameFormat)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoFrameFormat, void>)(lpVtbl[27]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, FrameFormat);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorSetStreamColorSpace"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public void VideoProcessorSetStreamColorSpace(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorColorSpace* pColorSpace)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)(lpVtbl[28]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pColorSpace);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorSetStreamOutputRate"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(29)]
	public void VideoProcessorSetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate OutputRate, Bool32 RepeatFrame, Graphics.Dxgi.Common.Rational* pCustomRate)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate, Bool32, Graphics.Dxgi.Common.Rational*, void>)(lpVtbl[29]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, OutputRate, RepeatFrame, pCustomRate);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorSetStreamSourceRect"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(30)]
	public void VideoProcessorSetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Bool32 Enable, RawRect* pRect)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Bool32, RawRect*, void>)(lpVtbl[30]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, pRect);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorSetStreamDestRect"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(31)]
	public void VideoProcessorSetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Bool32 Enable, RawRect* pRect)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Bool32, RawRect*, void>)(lpVtbl[31]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, pRect);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorSetStreamAlpha"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(32)]
	public void VideoProcessorSetStreamAlpha(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Bool32 Enable, float Alpha)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Bool32, float, void>)(lpVtbl[32]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, Alpha);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorSetStreamPalette"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(33)]
	public void VideoProcessorSetStreamPalette(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, uint Count, uint* pEntries)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)(lpVtbl[33]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Count, pEntries);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorSetStreamPixelAspectRatio"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(34)]
	public void VideoProcessorSetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Bool32 Enable, Graphics.Dxgi.Common.Rational* pSourceAspectRatio, Graphics.Dxgi.Common.Rational* pDestinationAspectRatio)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Bool32, Graphics.Dxgi.Common.Rational*, Graphics.Dxgi.Common.Rational*, void>)(lpVtbl[34]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatio);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorSetStreamLumaKey"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(35)]
	public void VideoProcessorSetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Bool32 Enable, float Lower, float Upper)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Bool32, float, float, void>)(lpVtbl[35]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, Lower, Upper);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorSetStreamStereoFormat"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(36)]
	public void VideoProcessorSetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Bool32 Enable, VideoProcessorStereoFormat Format, Bool32 LeftViewFrame0, Bool32 BaseViewFrame0, VideoProcessorStereoFlipMode FlipMode, int MonoOffset)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Bool32, VideoProcessorStereoFormat, Bool32, Bool32, VideoProcessorStereoFlipMode, int, void>)(lpVtbl[36]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, Format, LeftViewFrame0, BaseViewFrame0, FlipMode, MonoOffset);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorSetStreamAutoProcessingMode"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(37)]
	public void VideoProcessorSetStreamAutoProcessingMode(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Bool32 Enable)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Bool32, void>)(lpVtbl[37]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorSetStreamFilter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(38)]
	public void VideoProcessorSetStreamFilter(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, Bool32 Enable, int Level)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, Bool32, int, void>)(lpVtbl[38]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Filter, Enable, Level);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorSetStreamExtension"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(39)]
	public int VideoProcessorSetStreamExtension(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)(lpVtbl[39]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pData);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorGetStreamFrameFormat"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(40)]
	public void VideoProcessorGetStreamFrameFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoFrameFormat* pFrameFormat)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoFrameFormat*, void>)(lpVtbl[40]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pFrameFormat);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorGetStreamColorSpace"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(41)]
	public void VideoProcessorGetStreamColorSpace(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorColorSpace* pColorSpace)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)(lpVtbl[41]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pColorSpace);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorGetStreamOutputRate"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(42)]
	public void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, Bool32* pRepeatFrame, Graphics.Dxgi.Common.Rational* pCustomRate)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, Bool32*, Graphics.Dxgi.Common.Rational*, void>)(lpVtbl[42]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pOutputRate, pRepeatFrame, pCustomRate);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorGetStreamSourceRect"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(43)]
	public void VideoProcessorGetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Bool32* pEnabled, RawRect* pRect)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Bool32*, RawRect*, void>)(lpVtbl[43]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pRect);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorGetStreamDestRect"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(44)]
	public void VideoProcessorGetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Bool32* pEnabled, RawRect* pRect)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Bool32*, RawRect*, void>)(lpVtbl[44]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pRect);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorGetStreamAlpha"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(45)]
	public void VideoProcessorGetStreamAlpha(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Bool32* pEnabled, float* pAlpha)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Bool32*, float*, void>)(lpVtbl[45]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pAlpha);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorGetStreamPalette"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(46)]
	public void VideoProcessorGetStreamPalette(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, uint Count, uint* pEntries)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)(lpVtbl[46]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Count, pEntries);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorGetStreamPixelAspectRatio"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(47)]
	public void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Bool32* pEnabled, Graphics.Dxgi.Common.Rational* pSourceAspectRatio, Graphics.Dxgi.Common.Rational* pDestinationAspectRatio)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Bool32*, Graphics.Dxgi.Common.Rational*, Graphics.Dxgi.Common.Rational*, void>)(lpVtbl[47]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatio);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorGetStreamLumaKey"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(48)]
	public void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Bool32* pEnabled, float* pLower, float* pUpper)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Bool32*, float*, float*, void>)(lpVtbl[48]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled, pLower, pUpper);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorGetStreamStereoFormat"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(49)]
	public void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Bool32* pEnable, VideoProcessorStereoFormat* pFormat, Bool32* pLeftViewFrame0, Bool32* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Bool32*, VideoProcessorStereoFormat*, Bool32*, Bool32*, VideoProcessorStereoFlipMode*, int*, void>)(lpVtbl[49]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorGetStreamAutoProcessingMode"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(50)]
	public void VideoProcessorGetStreamAutoProcessingMode(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Bool32* pEnabled)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Bool32*, void>)(lpVtbl[50]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnabled);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorGetStreamFilter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(51)]
	public void VideoProcessorGetStreamFilter(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, Bool32* pEnabled, int* pLevel)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, Bool32*, int*, void>)(lpVtbl[51]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Filter, pEnabled, pLevel);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorGetStreamExtension"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(52)]
	public int VideoProcessorGetStreamExtension(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)(lpVtbl[52]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pData);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorBlt"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(53)]
	public HResult VideoProcessorBlt(ID3D11VideoProcessor* pVideoProcessor, ID3D11VideoProcessorOutputView* pView, uint OutputFrame, uint StreamCount, VideoProcessorStream* pStreams)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)(lpVtbl[53]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, pView, OutputFrame, StreamCount, pStreams);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::NegotiateCryptoSessionKeyExchange"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(54)]
	public HResult NegotiateCryptoSessionKeyExchange(ID3D11CryptoSession* pCryptoSession, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, int>)(lpVtbl[54]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pCryptoSession, DataSize, pData);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::EncryptionBlt"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(55)]
	public void EncryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, void* pIV)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)(lpVtbl[55]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pCryptoSession, pSrcSurface, pDstSurface, IVSize, pIV);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::DecryptionBlt"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(56)]
	public void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)(lpVtbl[56]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::StartSessionKeyRefresh"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(57)]
	public void StartSessionKeyRefresh(ID3D11CryptoSession* pCryptoSession, uint RandomNumberSize, void* pRandomNumber)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, void>)(lpVtbl[57]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pCryptoSession, RandomNumberSize, pRandomNumber);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::FinishSessionKeyRefresh"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(58)]
	public void FinishSessionKeyRefresh(ID3D11CryptoSession* pCryptoSession)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, void>)(lpVtbl[58]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pCryptoSession);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::GetEncryptionBltKey"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(59)]
	public HResult GetEncryptionBltKey(ID3D11CryptoSession* pCryptoSession, uint KeySize, void* pReadbackKey)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, int>)(lpVtbl[59]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pCryptoSession, KeySize, pReadbackKey);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::NegotiateAuthenticatedChannelKeyExchange"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(60)]
	public HResult NegotiateAuthenticatedChannelKeyExchange(ID3D11AuthenticatedChannel* pChannel, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, int>)(lpVtbl[60]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pChannel, DataSize, pData);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::QueryAuthenticatedChannel"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(61)]
	public HResult QueryAuthenticatedChannel(ID3D11AuthenticatedChannel* pChannel, uint InputSize, void* pInput, uint OutputSize, void* pOutput)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)(lpVtbl[61]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pChannel, InputSize, pInput, OutputSize, pOutput);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::ConfigureAuthenticatedChannel"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(62)]
	public HResult ConfigureAuthenticatedChannel(ID3D11AuthenticatedChannel* pChannel, uint InputSize, void* pInput, AuthenticatedConfigureOutput* pOutput)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)(lpVtbl[62]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pChannel, InputSize, pInput, pOutput);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorSetStreamRotation"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(63)]
	public void VideoProcessorSetStreamRotation(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Bool32 Enable, VideoProcessorRotation Rotation)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Bool32, VideoProcessorRotation, void>)(lpVtbl[63]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, Enable, Rotation);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoContext::VideoProcessorGetStreamRotation"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(64)]
	public void VideoProcessorGetStreamRotation(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Bool32* pEnable, VideoProcessorRotation* pRotation)
	{
		((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Bool32*, VideoProcessorRotation*, void>)(lpVtbl[64]))((ID3D11VideoContext*)Unsafe.AsPointer(ref this), pVideoProcessor, StreamIndex, pEnable, pRotation);
	}
}

