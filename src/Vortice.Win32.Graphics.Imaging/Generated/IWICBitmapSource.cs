// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Imaging;

/// <include file='../Imaging.xml' path='doc/member[@name="IWICBitmapSource"]/*' />
/// <unmanaged>IWICBitmapSource</unmanaged>
[Guid("00000120-a8f2-4877-ba0a-fd2b6645fb94")]
[NativeTypeName("struct IWICBitmapSource : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICBitmapSource : IWICBitmapSource.Interface, INativeGuid
{
	public static ref readonly Guid IID_IWICBitmapSource
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x20, 0x01, 0x00, 0x00,
				0xF2, 0xA8,
				0x77, 0x48,
				0xBA,
				0x0A,
				0xFD,
				0x2B,
				0x66,
				0x45,
				0xFB,
				0x94
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapSource));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapSource*, Guid*, void**, int>)(lpVtbl[0]))((IWICBitmapSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapSource*, uint>)(lpVtbl[1]))((IWICBitmapSource*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapSource*, uint>)(lpVtbl[2]))((IWICBitmapSource*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICBitmapSource::GetSize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetSize(uint* puiWidth, uint* puiHeight)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapSource*, uint*, uint*, int>)(lpVtbl[3]))((IWICBitmapSource*)Unsafe.AsPointer(ref this), puiWidth, puiHeight);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICBitmapSource::GetPixelFormat"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPixelFormat(Guid* pPixelFormat)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapSource*, Guid*, int>)(lpVtbl[4]))((IWICBitmapSource*)Unsafe.AsPointer(ref this), pPixelFormat);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICBitmapSource::GetResolution"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetResolution(double* pDpiX, double* pDpiY)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapSource*, double*, double*, int>)(lpVtbl[5]))((IWICBitmapSource*)Unsafe.AsPointer(ref this), pDpiX, pDpiY);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICBitmapSource::CopyPalette"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult CopyPalette(IWICPalette* pIPalette)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapSource*, IWICPalette*, int>)(lpVtbl[6]))((IWICBitmapSource*)Unsafe.AsPointer(ref this), pIPalette);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICBitmapSource::CopyPixels"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CopyPixels(System.Drawing.Rectangle* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICBitmapSource*, System.Drawing.Rectangle*, uint, uint, byte*, int>)(lpVtbl[7]))((IWICBitmapSource*)Unsafe.AsPointer(ref this), prc, cbStride, cbBufferSize, pbBuffer);
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult GetSize(uint* puiWidth, uint* puiHeight);

		[VtblIndex(4)]
		HResult GetPixelFormat(Guid* pPixelFormat);

		[VtblIndex(5)]
		HResult GetResolution(double* pDpiX, double* pDpiY);

		[VtblIndex(6)]
		HResult CopyPalette(IWICPalette* pIPalette);

		[VtblIndex(7)]
		HResult CopyPixels(System.Drawing.Rectangle* prc, uint cbStride, uint cbBufferSize, byte* pbBuffer);
	}
}

