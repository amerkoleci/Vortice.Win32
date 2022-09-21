// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Imaging;

/// <include file='../../Imaging.xml' path='doc/member[@name="IWICMetadataReaderInfo"]/*' />
/// <unmanaged>IWICMetadataReaderInfo</unmanaged>
[Guid("eebf1f5b-07c1-4447-a3ab-22acaf78a804")]
[NativeTypeName("struct IWICMetadataReaderInfo : IWICMetadataHandlerInfo")]
[NativeInheritance("IWICMetadataHandlerInfo")]
public unsafe partial struct IWICMetadataReaderInfo
{
	public static ref readonly Guid IID_IWICMetadataReaderInfo
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x5B, 0x1F, 0xBF, 0xEE,
				0xC1, 0x07,
				0x47, 0x44,
				0xA3,
				0xAB,
				0x22,
				0xAC,
				0xAF,
				0x78,
				0xA8,
				0x04
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICMetadataReaderInfo));

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

	/// <inheritdoc cref="IWICComponentInfo.GetComponentType" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetComponentType(WICComponentType* pType)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, WICComponentType*, int>)(lpVtbl[3]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), pType);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetCLSID" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetCLSID(Guid* pclsid)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, int>)(lpVtbl[4]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), pclsid);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetSigningStatus" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetSigningStatus(uint* pStatus)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint*, int>)(lpVtbl[5]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), pStatus);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetAuthor" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetAuthor(uint cchAuthor, ushort* wzAuthor, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, ushort*, uint*, int>)(lpVtbl[6]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetVendorGUID" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetVendorGUID(Guid* pguidVendor)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, int>)(lpVtbl[7]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), pguidVendor);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetVersion" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetVersion(uint cchVersion, ushort* wzVersion, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, ushort*, uint*, int>)(lpVtbl[8]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetSpecVersion" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetSpecVersion(uint cchSpecVersion, ushort* wzSpecVersion, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, ushort*, uint*, int>)(lpVtbl[9]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetFriendlyName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult GetFriendlyName(uint cchFriendlyName, ushort* wzFriendlyName, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, ushort*, uint*, int>)(lpVtbl[10]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
	}

	/// <inheritdoc cref="IWICMetadataHandlerInfo.GetMetadataFormat" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetMetadataFormat(Guid* pguidMetadataFormat)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, int>)(lpVtbl[11]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), pguidMetadataFormat);
	}

	/// <inheritdoc cref="IWICMetadataHandlerInfo.GetContainerFormats" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult GetContainerFormats(uint cContainerFormats, Guid* pguidContainerFormats, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, Guid*, uint*, int>)(lpVtbl[12]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), cContainerFormats, pguidContainerFormats, pcchActual);
	}

	/// <inheritdoc cref="IWICMetadataHandlerInfo.GetDeviceManufacturer" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult GetDeviceManufacturer(uint cchDeviceManufacturer, ushort* wzDeviceManufacturer, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, ushort*, uint*, int>)(lpVtbl[13]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
	}

	/// <inheritdoc cref="IWICMetadataHandlerInfo.GetDeviceModels" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult GetDeviceModels(uint cchDeviceModels, ushort* wzDeviceModels, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, ushort*, uint*, int>)(lpVtbl[14]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), cchDeviceModels, wzDeviceModels, pcchActual);
	}

	/// <inheritdoc cref="IWICMetadataHandlerInfo.DoesRequireFullStream" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult DoesRequireFullStream(Bool32* pfRequiresFullStream)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Bool32*, int>)(lpVtbl[15]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), pfRequiresFullStream);
	}

	/// <inheritdoc cref="IWICMetadataHandlerInfo.DoesSupportPadding" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult DoesSupportPadding(Bool32* pfSupportsPadding)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Bool32*, int>)(lpVtbl[16]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), pfSupportsPadding);
	}

	/// <inheritdoc cref="IWICMetadataHandlerInfo.DoesRequireFixedSize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult DoesRequireFixedSize(Bool32* pfFixedSize)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Bool32*, int>)(lpVtbl[17]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), pfFixedSize);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICMetadataReaderInfo::GetPatterns"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult GetPatterns(Guid* guidContainerFormat, uint cbSize, WICMetadataPattern* pPattern, uint* pcCount, uint* pcbActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, uint, WICMetadataPattern*, uint*, uint*, int>)(lpVtbl[18]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), guidContainerFormat, cbSize, pPattern, pcCount, pcbActual);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICMetadataReaderInfo::MatchesPattern"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult MatchesPattern(Guid* guidContainerFormat, Com.IStream* pIStream, Bool32* pfMatches)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, Com.IStream*, Bool32*, int>)(lpVtbl[19]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), guidContainerFormat, pIStream, pfMatches);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICMetadataReaderInfo::CreateInstance"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult CreateInstance(IWICMetadataReader** ppIReader)
	{
		return ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, IWICMetadataReader**, int>)(lpVtbl[20]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), ppIReader);
	}
}

