// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Imaging;

/// <include file='../Imaging.xml' path='doc/member[@name="IWICDdsEncoder"]/*' />
/// <unmanaged>IWICDdsEncoder</unmanaged>
[Guid("5cacdb4c-407e-41b3-b936-d0f010cd6732")]
[NativeTypeName("struct IWICDdsEncoder : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICDdsEncoder : INativeGuid
{
	public static ref readonly Guid IID_IWICDdsEncoder
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x4C, 0xDB, 0xAC, 0x5C,
				0x7E, 0x40,
				0xB3, 0x41,
				0xB9,
				0x36,
				0xD0,
				0xF0,
				0x10,
				0xCD,
				0x67,
				0x32
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICDdsEncoder));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICDdsEncoder));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, Guid*, void**, int>)(lpVtbl[0]))((IWICDdsEncoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, uint>)(lpVtbl[1]))((IWICDdsEncoder*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, uint>)(lpVtbl[2]))((IWICDdsEncoder*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICDdsEncoder::SetParameters"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetParameters(WICDdsParameters* pParameters)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, WICDdsParameters*, int>)(lpVtbl[3]))((IWICDdsEncoder*)Unsafe.AsPointer(ref this), pParameters);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICDdsEncoder::GetParameters"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetParameters(WICDdsParameters* pParameters)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, WICDdsParameters*, int>)(lpVtbl[4]))((IWICDdsEncoder*)Unsafe.AsPointer(ref this), pParameters);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICDdsEncoder::CreateNewFrame"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult CreateNewFrame(IWICBitmapFrameEncode** ppIFrameEncode, uint* pArrayIndex, uint* pMipLevel, uint* pSliceIndex)
	{
		return ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)(lpVtbl[5]))((IWICDdsEncoder*)Unsafe.AsPointer(ref this), ppIFrameEncode, pArrayIndex, pMipLevel, pSliceIndex);
	}
}

