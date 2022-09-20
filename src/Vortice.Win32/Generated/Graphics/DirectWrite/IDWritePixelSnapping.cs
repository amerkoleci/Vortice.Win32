// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------


#if !NET6_0_OR_GREATER
using MemoryMarshal = Win32.MemoryMarshal;
#endif

namespace Win32.Graphics.DirectWrite;

/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWritePixelSnapping"]/*' />
/// <unmanaged>IDWritePixelSnapping</unmanaged>
[Guid("eaf3a2da-ecf4-4d24-b644-b34f6842024b")]
[NativeTypeName("struct IDWritePixelSnapping : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWritePixelSnapping
{
	public static ref readonly Guid IID_IDWritePixelSnapping
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xDA, 0xA2, 0xF3, 0xEA,
				0xF4, 0xEC,
				0x24, 0x4D,
				0xB6,
				0x44,
				0xB3,
				0x4F,
				0x68,
				0x42,
				0x02,
				0x4B
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWritePixelSnapping));

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

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWritePixelSnapping::IsPixelSnappingDisabled"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult IsPixelSnappingDisabled(void* clientDrawingContext, Bool32* isDisabled)
	{
		return ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, void*, Bool32*, int>)(lpVtbl[3]))((IDWritePixelSnapping*)Unsafe.AsPointer(ref this), clientDrawingContext, isDisabled);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWritePixelSnapping::GetCurrentTransform"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetCurrentTransform(void* clientDrawingContext, Matrix* transform)
	{
		return ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, void*, Matrix*, int>)(lpVtbl[4]))((IDWritePixelSnapping*)Unsafe.AsPointer(ref this), clientDrawingContext, transform);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWritePixelSnapping::GetPixelsPerDip"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetPixelsPerDip(void* clientDrawingContext, float* pixelsPerDip)
	{
		return ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, void*, float*, int>)(lpVtbl[5]))((IDWritePixelSnapping*)Unsafe.AsPointer(ref this), clientDrawingContext, pixelsPerDip);
	}
}

