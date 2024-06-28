// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Imaging;

/// <include file='../Imaging.xml' path='doc/member[@name="IWICBitmapDecoderInfo"]/*' />
/// <unmanaged>IWICBitmapDecoderInfo</unmanaged>
[Guid("d8cd007f-d08f-4191-9bfc-236ea7f0e4b5")]
[NativeTypeName("struct IWICBitmapDecoderInfo : IWICBitmapCodecInfo")]
[NativeInheritance("IWICBitmapCodecInfo")]
public unsafe partial struct IWICBitmapDecoderInfo : IWICBitmapDecoderInfo.Interface, INativeGuid
{
	public static ref readonly Guid IID_IWICBitmapDecoderInfo
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x7F, 0x00, 0xCD, 0xD8,
				0x8F, 0xD0,
				0x91, 0x41,
				0x9B,
				0xFC,
				0x23,
				0x6E,
				0xA7,
				0xF0,
				0xE4,
				0xB5
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapDecoderInfo));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, Guid*, void**, int>)(lpVtbl[0]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, uint>)(lpVtbl[1]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, uint>)(lpVtbl[2]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IWICComponentInfo.GetComponentType" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetComponentType(WICComponentType* pType)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, WICComponentType*, int>)(lpVtbl[3]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pType);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetCLSID" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetCLSID(Guid* pclsid)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, Guid*, int>)(lpVtbl[4]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pclsid);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetSigningStatus" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetSigningStatus(uint* pStatus)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, uint*, int>)(lpVtbl[5]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pStatus);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetAuthor" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetAuthor(uint cchAuthor, char** wzAuthor, uint* pcchActual)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, uint, char**, uint*, int>)(lpVtbl[6]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetVendorGUID" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetVendorGUID(Guid* pguidVendor)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, Guid*, int>)(lpVtbl[7]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pguidVendor);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetVersion" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetVersion(uint cchVersion, char** wzVersion, uint* pcchActual)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, uint, char**, uint*, int>)(lpVtbl[8]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetSpecVersion" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetSpecVersion(uint cchSpecVersion, char** wzSpecVersion, uint* pcchActual)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, uint, char**, uint*, int>)(lpVtbl[9]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetFriendlyName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult GetFriendlyName(uint cchFriendlyName, char** wzFriendlyName, uint* pcchActual)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, uint, char**, uint*, int>)(lpVtbl[10]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
	}

	/// <inheritdoc cref="IWICBitmapCodecInfo.GetContainerFormat" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetContainerFormat(Guid* pguidContainerFormat)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, Guid*, int>)(lpVtbl[11]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pguidContainerFormat);
	}

	/// <inheritdoc cref="IWICBitmapCodecInfo.GetPixelFormats" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult GetPixelFormats(uint cFormats, Guid* pguidPixelFormats, uint* pcActual)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, uint, Guid*, uint*, int>)(lpVtbl[12]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cFormats, pguidPixelFormats, pcActual);
	}

	/// <inheritdoc cref="IWICBitmapCodecInfo.GetColorManagementVersion" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult GetColorManagementVersion(uint cchColorManagementVersion, char** wzColorManagementVersion, uint* pcchActual)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, uint, char**, uint*, int>)(lpVtbl[13]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchColorManagementVersion, wzColorManagementVersion, pcchActual);
	}

	/// <inheritdoc cref="IWICBitmapCodecInfo.GetDeviceManufacturer" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult GetDeviceManufacturer(uint cchDeviceManufacturer, char** wzDeviceManufacturer, uint* pcchActual)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, uint, char**, uint*, int>)(lpVtbl[14]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
	}

	/// <inheritdoc cref="IWICBitmapCodecInfo.GetDeviceModels" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult GetDeviceModels(uint cchDeviceModels, char** wzDeviceModels, uint* pcchActual)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, uint, char**, uint*, int>)(lpVtbl[15]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchDeviceModels, wzDeviceModels, pcchActual);
	}

	/// <inheritdoc cref="IWICBitmapCodecInfo.GetMimeTypes" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult GetMimeTypes(uint cchMimeTypes, char** wzMimeTypes, uint* pcchActual)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, uint, char**, uint*, int>)(lpVtbl[16]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchMimeTypes, wzMimeTypes, pcchActual);
	}

	/// <inheritdoc cref="IWICBitmapCodecInfo.GetFileExtensions" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult GetFileExtensions(uint cchFileExtensions, char** wzFileExtensions, uint* pcchActual)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, uint, char**, uint*, int>)(lpVtbl[17]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchFileExtensions, wzFileExtensions, pcchActual);
	}

	/// <inheritdoc cref="IWICBitmapCodecInfo.DoesSupportAnimation" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult DoesSupportAnimation(Bool32* pfSupportAnimation)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, Bool32*, int>)(lpVtbl[18]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pfSupportAnimation);
	}

	/// <inheritdoc cref="IWICBitmapCodecInfo.DoesSupportChromakey" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult DoesSupportChromakey(Bool32* pfSupportChromakey)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, Bool32*, int>)(lpVtbl[19]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pfSupportChromakey);
	}

	/// <inheritdoc cref="IWICBitmapCodecInfo.DoesSupportLossless" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult DoesSupportLossless(Bool32* pfSupportLossless)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, Bool32*, int>)(lpVtbl[20]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pfSupportLossless);
	}

	/// <inheritdoc cref="IWICBitmapCodecInfo.DoesSupportMultiframe" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult DoesSupportMultiframe(Bool32* pfSupportMultiframe)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, Bool32*, int>)(lpVtbl[21]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pfSupportMultiframe);
	}

	/// <inheritdoc cref="IWICBitmapCodecInfo.MatchesMimeType" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult MatchesMimeType(ushort* wzMimeType, Bool32* pfMatches)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, ushort*, Bool32*, int>)(lpVtbl[22]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), wzMimeType, pfMatches);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICBitmapDecoderInfo::GetPatterns"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public HResult GetPatterns(uint cbSizePatterns, WICBitmapPattern* pPatterns, uint* pcPatterns, uint* pcbPatternsActual)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, uint, WICBitmapPattern*, uint*, uint*, int>)(lpVtbl[23]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cbSizePatterns, pPatterns, pcPatterns, pcbPatternsActual);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICBitmapDecoderInfo::MatchesPattern"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult MatchesPattern(Com.IStream* pIStream, Bool32* pfMatches)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, Com.IStream*, Bool32*, int>)(lpVtbl[24]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pIStream, pfMatches);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICBitmapDecoderInfo::CreateInstance"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public HResult CreateInstance(IWICBitmapDecoder** ppIBitmapDecoder)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, IWICBitmapDecoder**, int>)(lpVtbl[25]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), ppIBitmapDecoder);
	}

	public interface Interface : IWICBitmapCodecInfo.Interface
	{
		[VtblIndex(23)]
		HResult GetPatterns(uint cbSizePatterns, WICBitmapPattern* pPatterns, uint* pcPatterns, uint* pcbPatternsActual);

		[VtblIndex(24)]
		HResult MatchesPattern(Com.IStream* pIStream, Bool32* pfMatches);

		[VtblIndex(25)]
		HResult CreateInstance(IWICBitmapDecoder** ppIBitmapDecoder);
	}
}

