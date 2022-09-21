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

namespace Win32.Graphics.Imaging;

/// <include file='../../Imaging.xml' path='doc/member[@name="IWICStream"]/*' />
/// <unmanaged>IWICStream</unmanaged>
[Guid("135ff860-22b7-4ddf-b0f6-218f4f299a43")]
[NativeTypeName("struct IWICStream : IStream")]
[NativeInheritance("IStream")]
public unsafe partial struct IWICStream
{
	public static ref readonly Guid IID_IWICStream
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x60, 0xF8, 0x5F, 0x13,
				0xB7, 0x22,
				0xDF, 0x4D,
				0xB0,
				0xF6,
				0x21,
				0x8F,
				0x4F,
				0x29,
				0x9A,
				0x43
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICStream));

	public void** lpVtbl;

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICStream::InitializeFromIStream"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult InitializeFromIStream(Com.IStream* pIStream)
	{
		return ((delegate* unmanaged[Stdcall]<IWICStream*, Com.IStream*, int>)(lpVtbl[0]))((IWICStream*)Unsafe.AsPointer(ref this), pIStream);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICStream::InitializeFromFilename"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	public HResult InitializeFromFilename(ushort* wzFileName, uint dwDesiredAccess)
	{
		return ((delegate* unmanaged[Stdcall]<IWICStream*, ushort*, uint, int>)(lpVtbl[1]))((IWICStream*)Unsafe.AsPointer(ref this), wzFileName, dwDesiredAccess);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICStream::InitializeFromMemory"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	public HResult InitializeFromMemory(byte* pbBuffer, uint cbBufferSize)
	{
		return ((delegate* unmanaged[Stdcall]<IWICStream*, byte*, uint, int>)(lpVtbl[2]))((IWICStream*)Unsafe.AsPointer(ref this), pbBuffer, cbBufferSize);
	}

	/// <include file='../../Imaging.xml' path='doc/member[@name="IWICStream::InitializeFromIStreamRegion"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult InitializeFromIStreamRegion(Com.IStream* pIStream, ULargeInteger ulOffset, ULargeInteger ulMaxSize)
	{
		return ((delegate* unmanaged[Stdcall]<IWICStream*, Com.IStream*, ULargeInteger, ULargeInteger, int>)(lpVtbl[3]))((IWICStream*)Unsafe.AsPointer(ref this), pIStream, ulOffset, ulMaxSize);
	}
}
