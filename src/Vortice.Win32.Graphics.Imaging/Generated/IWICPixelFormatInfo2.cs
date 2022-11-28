// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Imaging;

/// <include file='../Imaging.xml' path='doc/member[@name="IWICPixelFormatInfo2"]/*' />
/// <unmanaged>IWICPixelFormatInfo2</unmanaged>
[Guid("a9db33a2-af5f-43c7-b679-74f5984b5aa4")]
[NativeTypeName("struct IWICPixelFormatInfo2 : IWICPixelFormatInfo")]
[NativeInheritance("IWICPixelFormatInfo")]
public unsafe partial struct IWICPixelFormatInfo2 : INativeGuid
{
	public static ref readonly Guid IID_IWICPixelFormatInfo2
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xA2, 0x33, 0xDB, 0xA9,
				0x5F, 0xAF,
				0xC7, 0x43,
				0xB6,
				0x79,
				0x74,
				0xF5,
				0x98,
				0x4B,
				0x5A,
				0xA4
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICPixelFormatInfo2));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICPixelFormatInfo2));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, Guid*, void**, int>)(lpVtbl[0]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint>)(lpVtbl[1]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint>)(lpVtbl[2]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IWICComponentInfo.GetComponentType" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetComponentType(WICComponentType* pType)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, WICComponentType*, int>)(lpVtbl[3]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), pType);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetCLSID" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetCLSID(Guid* pclsid)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, Guid*, int>)(lpVtbl[4]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), pclsid);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetSigningStatus" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetSigningStatus(uint* pStatus)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint*, int>)(lpVtbl[5]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), pStatus);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetAuthor" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetAuthor(uint cchAuthor, ushort* wzAuthor, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, ushort*, uint*, int>)(lpVtbl[6]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetVendorGUID" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetVendorGUID(Guid* pguidVendor)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, Guid*, int>)(lpVtbl[7]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), pguidVendor);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetVersion" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetVersion(uint cchVersion, ushort* wzVersion, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, ushort*, uint*, int>)(lpVtbl[8]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetSpecVersion" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetSpecVersion(uint cchSpecVersion, ushort* wzSpecVersion, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, ushort*, uint*, int>)(lpVtbl[9]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
	}

	/// <inheritdoc cref="IWICComponentInfo.GetFriendlyName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult GetFriendlyName(uint cchFriendlyName, ushort* wzFriendlyName, uint* pcchActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, ushort*, uint*, int>)(lpVtbl[10]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
	}

	/// <inheritdoc cref="IWICPixelFormatInfo.GetFormatGUID" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetFormatGUID(Guid* pFormat)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, Guid*, int>)(lpVtbl[11]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), pFormat);
	}

	/// <inheritdoc cref="IWICPixelFormatInfo.GetColorContext" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult GetColorContext(IWICColorContext** ppIColorContext)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, IWICColorContext**, int>)(lpVtbl[12]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), ppIColorContext);
	}

	/// <inheritdoc cref="IWICPixelFormatInfo.GetBitsPerPixel" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult GetBitsPerPixel(uint* puiBitsPerPixel)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint*, int>)(lpVtbl[13]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), puiBitsPerPixel);
	}

	/// <inheritdoc cref="IWICPixelFormatInfo.GetChannelCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult GetChannelCount(uint* puiChannelCount)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint*, int>)(lpVtbl[14]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), puiChannelCount);
	}

	/// <inheritdoc cref="IWICPixelFormatInfo.GetChannelMask" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult GetChannelMask(uint uiChannelIndex, uint cbMaskBuffer, byte* pbMaskBuffer, uint* pcbActual)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, uint, byte*, uint*, int>)(lpVtbl[15]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), uiChannelIndex, cbMaskBuffer, pbMaskBuffer, pcbActual);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICPixelFormatInfo2::SupportsTransparency"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult SupportsTransparency(Bool32* pfSupportsTransparency)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, Bool32*, int>)(lpVtbl[16]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), pfSupportsTransparency);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICPixelFormatInfo2::GetNumericRepresentation"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult GetNumericRepresentation(WICPixelFormatNumericRepresentation* pNumericRepresentation)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, WICPixelFormatNumericRepresentation*, int>)(lpVtbl[17]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), pNumericRepresentation);
	}
}

