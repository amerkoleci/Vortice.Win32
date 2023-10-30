// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Imaging;

/// <include file='../Imaging.xml' path='doc/member[@name="IWICColorContext"]/*' />
/// <unmanaged>IWICColorContext</unmanaged>
[Guid("3c613a02-34b2-44ea-9a7c-45aea9c6fd6d")]
[NativeTypeName("struct IWICColorContext : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICColorContext : IWICColorContext.Interface, INativeGuid
{
	public static ref readonly Guid IID_IWICColorContext
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x02, 0x3A, 0x61, 0x3C,
				0xB2, 0x34,
				0xEA, 0x44,
				0x9A,
				0x7C,
				0x45,
				0xAE,
				0xA9,
				0xC6,
				0xFD,
				0x6D
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICColorContext));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICColorContext*, Guid*, void**, int>)(lpVtbl[0]))((IWICColorContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<IWICColorContext*, uint>)(lpVtbl[1]))((IWICColorContext*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<IWICColorContext*, uint>)(lpVtbl[2]))((IWICColorContext*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICColorContext::InitializeFromFilename"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult InitializeFromFilename(ushort* wzFilename)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICColorContext*, ushort*, int>)(lpVtbl[3]))((IWICColorContext*)Unsafe.AsPointer(ref this), wzFilename);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICColorContext::InitializeFromMemory"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult InitializeFromMemory(byte* pbBuffer, uint cbBufferSize)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICColorContext*, byte*, uint, int>)(lpVtbl[4]))((IWICColorContext*)Unsafe.AsPointer(ref this), pbBuffer, cbBufferSize);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICColorContext::InitializeFromExifColorSpace"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult InitializeFromExifColorSpace(uint value)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICColorContext*, uint, int>)(lpVtbl[5]))((IWICColorContext*)Unsafe.AsPointer(ref this), value);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICColorContext::GetType"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetType(WICColorContextType* pType)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICColorContext*, WICColorContextType*, int>)(lpVtbl[6]))((IWICColorContext*)Unsafe.AsPointer(ref this), pType);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICColorContext::GetProfileBytes"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetProfileBytes(uint cbBuffer, byte* pbBuffer, uint* pcbActual)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICColorContext*, uint, byte*, uint*, int>)(lpVtbl[7]))((IWICColorContext*)Unsafe.AsPointer(ref this), cbBuffer, pbBuffer, pcbActual);
	}

	/// <include file='../Imaging.xml' path='doc/member[@name="IWICColorContext::GetExifColorSpace"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetExifColorSpace(uint* pValue)
	{
		return ((delegate* unmanaged[MemberFunction]<IWICColorContext*, uint*, int>)(lpVtbl[8]))((IWICColorContext*)Unsafe.AsPointer(ref this), pValue);
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult InitializeFromFilename(ushort* wzFilename);

		[VtblIndex(4)]
		HResult InitializeFromMemory(byte* pbBuffer, uint cbBufferSize);

		[VtblIndex(5)]
		HResult InitializeFromExifColorSpace(uint value);

		[VtblIndex(6)]
		HResult GetType(WICColorContextType* pType);

		[VtblIndex(7)]
		HResult GetProfileBytes(uint cbBuffer, byte* pbBuffer, uint* pcbActual);

		[VtblIndex(8)]
		HResult GetExifColorSpace(uint* pValue);
	}
}

