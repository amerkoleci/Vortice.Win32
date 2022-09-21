// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Imaging;

/// <include file='../../Imaging.xml' path='doc/member[@name="IWICPixelFormatInfo"]/*' />
/// <unmanaged>IWICPixelFormatInfo</unmanaged>
[Guid("e8eda601-3d48-431a-ab44-69059be88bbe")]
[NativeTypeName("struct IWICPixelFormatInfo : IWICComponentInfo")]
[NativeInheritance("IWICComponentInfo")]
public unsafe partial struct IWICPixelFormatInfo
{
	public static ref readonly Guid IID_IWICPixelFormatInfo
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x01, 0xA6, 0xED, 0xE8,
				0x48, 0x3D,
				0x1A, 0x43,
				0xAB,
				0x44,
				0x69,
				0x05,
				0x9B,
				0xE8,
				0x8B,
				0xBE
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICPixelFormatInfo));

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
		return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo*, WICComponentType*, int>)(lpVtbl[3]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), pType);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetCLSID" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetCLSID(Guid* pclsid)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo*, Guid*, int>)(lpVtbl[4]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), pclsid);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetSigningStatus" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetSigningStatus(uint* pStatus)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo*, uint*, int>)(lpVtbl[5]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), pStatus);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetAuthor" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetAuthor(uint cchAuthor, ushort* wzAuthor, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo*, uint, ushort*, uint*, int>)(lpVtbl[6]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetVendorGUID" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetVendorGUID(Guid* pguidVendor)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo*, Guid*, int>)(lpVtbl[7]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), pguidVendor);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetVersion" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetVersion(uint cchVersion, ushort* wzVersion, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo*, uint, ushort*, uint*, int>)(lpVtbl[8]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetSpecVersion" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetSpecVersion(uint cchSpecVersion, ushort* wzSpecVersion, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo*, uint, ushort*, uint*, int>)(lpVtbl[9]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetFriendlyName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult GetFriendlyName(uint cchFriendlyName, ushort* wzFriendlyName, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo*, uint, ushort*, uint*, int>)(lpVtbl[10]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICPixelFormatInfo::GetFormatGUID"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetFormatGUID(Guid* pFormat)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo*, Guid*, int>)(lpVtbl[11]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), pFormat);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICPixelFormatInfo::GetColorContext"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult GetColorContext(IWICColorContext** ppIColorContext)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo*, IWICColorContext**, int>)(lpVtbl[12]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), ppIColorContext);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICPixelFormatInfo::GetBitsPerPixel"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult GetBitsPerPixel(uint* puiBitsPerPixel)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo*, uint*, int>)(lpVtbl[13]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), puiBitsPerPixel);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICPixelFormatInfo::GetChannelCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult GetChannelCount(uint* puiChannelCount)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo*, uint*, int>)(lpVtbl[14]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), puiChannelCount);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICPixelFormatInfo::GetChannelMask"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult GetChannelMask(uint uiChannelIndex, uint cbMaskBuffer, byte* pbMaskBuffer, uint* pcbActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo*, uint, uint, byte*, uint*, int>)(lpVtbl[15]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), uiChannelIndex, cbMaskBuffer, pbMaskBuffer, pcbActual);
	}
}

