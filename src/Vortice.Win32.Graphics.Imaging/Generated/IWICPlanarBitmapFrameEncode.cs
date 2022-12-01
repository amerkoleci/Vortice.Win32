// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Imaging;

/// <include file='../Imaging.xml' path='doc/member[@name="IWICPlanarBitmapFrameEncode"]/*' />
/// <unmanaged>IWICPlanarBitmapFrameEncode</unmanaged>
[Guid("f928b7b8-2221-40c1-b72e-7e82f1974d1a")]
[NativeTypeName("struct IWICPlanarBitmapFrameEncode : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICPlanarBitmapFrameEncode : IWICPlanarBitmapFrameEncode.Interface, INativeGuid
{
	public static ref readonly Guid IID_IWICPlanarBitmapFrameEncode
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xB8, 0xB7, 0x28, 0xF9,
				0x21, 0x22,
				0xC1, 0x40,
				0xB7,
				0x2E,
				0x7E,
				0x82,
				0xF1,
				0x97,
				0x4D,
				0x1A
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICPlanarBitmapFrameEncode));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICPlanarBitmapFrameEncode));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapFrameEncode*, Guid*, void**, int>)(lpVtbl[0]))((IWICPlanarBitmapFrameEncode*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapFrameEncode*, uint>)(lpVtbl[1]))((IWICPlanarBitmapFrameEncode*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapFrameEncode*, uint>)(lpVtbl[2]))((IWICPlanarBitmapFrameEncode*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICPlanarBitmapFrameEncode::WritePixels"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult WritePixels(uint lineCount, WICBitmapPlane* pPlanes, uint cPlanes)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapFrameEncode*, uint, WICBitmapPlane*, uint, int>)(lpVtbl[3]))((IWICPlanarBitmapFrameEncode*)Unsafe.AsPointer(ref this), lineCount, pPlanes, cPlanes);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICPlanarBitmapFrameEncode::WriteSource"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult WriteSource(IWICBitmapSource** ppPlanes, uint cPlanes, System.Drawing.Rectangle* prcSource)
	{
		return ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapFrameEncode*, IWICBitmapSource**, uint, System.Drawing.Rectangle*, int>)(lpVtbl[4]))((IWICPlanarBitmapFrameEncode*)Unsafe.AsPointer(ref this), ppPlanes, cPlanes, prcSource);
	}
	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult WritePixels(uint lineCount, WICBitmapPlane* pPlanes, uint cPlanes);

		[VtblIndex(4)]
		HResult WriteSource(IWICBitmapSource** ppPlanes, uint cPlanes, System.Drawing.Rectangle* prcSource);
	}
}

