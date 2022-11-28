// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoDevice1"]/*' />
/// <unmanaged>ID3D11VideoDevice1</unmanaged>
[Guid("29da1d51-1321-4454-804b-f5fc9f861f0f")]
[NativeTypeName("struct ID3D11VideoDevice1 : ID3D11VideoDevice")]
[NativeInheritance("ID3D11VideoDevice")]
public unsafe partial struct ID3D11VideoDevice1 : INativeGuid
{
	public static ref readonly Guid IID_ID3D11VideoDevice1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x51, 0x1D, 0xDA, 0x29,
				0x21, 0x13,
				0x54, 0x44,
				0x80,
				0x4B,
				0xF5,
				0xFC,
				0x9F,
				0x86,
				0x1F,
				0x0F
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11VideoDevice1));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11VideoDevice1));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, uint>)(lpVtbl[1]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, uint>)(lpVtbl[2]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D11VideoDevice.CreateVideoDecoder" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult CreateVideoDecoder(VideoDecoderDescription* pVideoDesc, VideoDecoderConfig* pConfig, ID3D11VideoDecoder** ppDecoder)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDescription*, VideoDecoderConfig*, ID3D11VideoDecoder**, int>)(lpVtbl[3]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pVideoDesc, pConfig, ppDecoder);
	}

	/// <inheritdoc cref="ID3D11VideoDevice.CreateVideoProcessor" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult CreateVideoProcessor(ID3D11VideoProcessorEnumerator* pEnum, uint RateConversionIndex, ID3D11VideoProcessor** ppVideoProcessor)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11VideoProcessorEnumerator*, uint, ID3D11VideoProcessor**, int>)(lpVtbl[4]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pEnum, RateConversionIndex, ppVideoProcessor);
	}

	/// <inheritdoc cref="ID3D11VideoDevice.CreateAuthenticatedChannel" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult CreateAuthenticatedChannel(AuthenticatedChannelType ChannelType, ID3D11AuthenticatedChannel** ppAuthenticatedChannel)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, AuthenticatedChannelType, ID3D11AuthenticatedChannel**, int>)(lpVtbl[5]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), ChannelType, ppAuthenticatedChannel);
	}

	/// <inheritdoc cref="ID3D11VideoDevice.CreateCryptoSession" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult CreateCryptoSession(Guid* pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, ID3D11CryptoSession** ppCryptoSession)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, ID3D11CryptoSession**, int>)(lpVtbl[6]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pCryptoType, pDecoderProfile, pKeyExchangeType, ppCryptoSession);
	}

	/// <inheritdoc cref="ID3D11VideoDevice.CreateVideoDecoderOutputView" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CreateVideoDecoderOutputView(ID3D11Resource* pResource, VideoDecoderOutputViewDescription* pDesc, ID3D11VideoDecoderOutputView** ppVDOVView)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, VideoDecoderOutputViewDescription*, ID3D11VideoDecoderOutputView**, int>)(lpVtbl[7]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pResource, pDesc, ppVDOVView);
	}

	/// <inheritdoc cref="ID3D11VideoDevice.CreateVideoProcessorInputView" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateVideoProcessorInputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorInputViewDescription* pDesc, ID3D11VideoProcessorInputView** ppVPIView)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorInputViewDescription*, ID3D11VideoProcessorInputView**, int>)(lpVtbl[8]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pResource, pEnum, pDesc, ppVPIView);
	}

	/// <inheritdoc cref="ID3D11VideoDevice.CreateVideoProcessorOutputView" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult CreateVideoProcessorOutputView(ID3D11Resource* pResource, ID3D11VideoProcessorEnumerator* pEnum, VideoProcessorOutputViewDescription* pDesc, ID3D11VideoProcessorOutputView** ppVPOView)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, ID3D11Resource*, ID3D11VideoProcessorEnumerator*, VideoProcessorOutputViewDescription*, ID3D11VideoProcessorOutputView**, int>)(lpVtbl[9]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pResource, pEnum, pDesc, ppVPOView);
	}

	/// <inheritdoc cref="ID3D11VideoDevice.CreateVideoProcessorEnumerator" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult CreateVideoProcessorEnumerator(VideoProcessorContentDescription* pDesc, ID3D11VideoProcessorEnumerator** ppEnum)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoProcessorContentDescription*, ID3D11VideoProcessorEnumerator**, int>)(lpVtbl[10]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pDesc, ppEnum);
	}

	/// <inheritdoc cref="ID3D11VideoDevice.GetVideoDecoderProfileCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public uint GetVideoDecoderProfileCount()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, uint>)(lpVtbl[11]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D11VideoDevice.GetVideoDecoderProfile" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult GetVideoDecoderProfile(uint Index, Guid* pDecoderProfile)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, uint, Guid*, int>)(lpVtbl[12]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), Index, pDecoderProfile);
	}

	/// <inheritdoc cref="ID3D11VideoDevice.CheckVideoDecoderFormat" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult CheckVideoDecoderFormat(Guid* pDecoderProfile, Graphics.Dxgi.Common.Format Format, Bool32* pSupported)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Graphics.Dxgi.Common.Format, Bool32*, int>)(lpVtbl[13]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pDecoderProfile, Format, pSupported);
	}

	/// <inheritdoc cref="ID3D11VideoDevice.GetVideoDecoderConfigCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult GetVideoDecoderConfigCount(VideoDecoderDescription* pDesc, uint* pCount)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDescription*, uint*, int>)(lpVtbl[14]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pDesc, pCount);
	}

	/// <inheritdoc cref="ID3D11VideoDevice.GetVideoDecoderConfig" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult GetVideoDecoderConfig(VideoDecoderDescription* pDesc, uint Index, VideoDecoderConfig* pConfig)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDescription*, uint, VideoDecoderConfig*, int>)(lpVtbl[15]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pDesc, Index, pConfig);
	}

	/// <inheritdoc cref="ID3D11VideoDevice.GetContentProtectionCaps" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult GetContentProtectionCaps(Guid* pCryptoType, Guid* pDecoderProfile, VideoContentProtectionCaps* pCaps)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, VideoContentProtectionCaps*, int>)(lpVtbl[16]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pCryptoType, pDecoderProfile, pCaps);
	}

	/// <inheritdoc cref="ID3D11VideoDevice.CheckCryptoKeyExchange" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult CheckCryptoKeyExchange(Guid* pCryptoType, Guid* pDecoderProfile, uint Index, Guid* pKeyExchangeType)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, uint, Guid*, int>)(lpVtbl[17]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pCryptoType, pDecoderProfile, Index, pKeyExchangeType);
	}

	/// <inheritdoc cref="ID3D11VideoDevice.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, uint, void*, int>)(lpVtbl[18]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <inheritdoc cref="ID3D11VideoDevice.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, IUnknown*, int>)(lpVtbl[19]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), guid, pData);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoDevice1::GetCryptoSessionPrivateDataSize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult GetCryptoSessionPrivateDataSize(Guid* pCryptoType, Guid* pDecoderProfile, Guid* pKeyExchangeType, uint* pPrivateInputSize, uint* pPrivateOutputSize)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, Guid*, Guid*, uint*, uint*, int>)(lpVtbl[20]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pCryptoType, pDecoderProfile, pKeyExchangeType, pPrivateInputSize, pPrivateOutputSize);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoDevice1::GetVideoDecoderCaps"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult GetVideoDecoderCaps(Guid* pDecoderProfile, uint SampleWidth, uint SampleHeight, Graphics.Dxgi.Common.Rational* pFrameRate, uint BitRate, Guid* pCryptoType, uint* pDecoderCaps)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, Guid*, uint, uint, Graphics.Dxgi.Common.Rational*, uint, Guid*, uint*, int>)(lpVtbl[21]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pDecoderProfile, SampleWidth, SampleHeight, pFrameRate, BitRate, pCryptoType, pDecoderCaps);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoDevice1::CheckVideoDecoderDownsampling"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult CheckVideoDecoderDownsampling(VideoDecoderDescription* pInputDesc, Graphics.Dxgi.Common.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Graphics.Dxgi.Common.Rational* pFrameRate, VideoSampleDescription* pOutputDesc, Bool32* pSupported, Bool32* pRealTimeHint)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDescription*, Graphics.Dxgi.Common.ColorSpaceType, VideoDecoderConfig*, Graphics.Dxgi.Common.Rational*, VideoSampleDescription*, Bool32*, Bool32*, int>)(lpVtbl[22]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pOutputDesc, pSupported, pRealTimeHint);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11VideoDevice1::RecommendVideoDecoderDownsampleParameters"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public HResult RecommendVideoDecoderDownsampleParameters(VideoDecoderDescription* pInputDesc, Graphics.Dxgi.Common.ColorSpaceType InputColorSpace, VideoDecoderConfig* pInputConfig, Graphics.Dxgi.Common.Rational* pFrameRate, VideoSampleDescription* pRecommendedOutputDesc)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11VideoDevice1*, VideoDecoderDescription*, Graphics.Dxgi.Common.ColorSpaceType, VideoDecoderConfig*, Graphics.Dxgi.Common.Rational*, VideoSampleDescription*, int>)(lpVtbl[23]))((ID3D11VideoDevice1*)Unsafe.AsPointer(ref this), pInputDesc, InputColorSpace, pInputConfig, pFrameRate, pRecommendedOutputDesc);
	}
}

