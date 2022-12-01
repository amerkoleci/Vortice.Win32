// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFileEnumerator"]/*' />
/// <unmanaged>IDWriteFontFileEnumerator</unmanaged>
[Guid("72755049-5ff7-435d-8348-4be97cfa6c7c")]
[NativeTypeName("struct IDWriteFontFileEnumerator : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteFontFileEnumerator : IDWriteFontFileEnumerator.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDWriteFontFileEnumerator
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x49, 0x50, 0x75, 0x72,
				0xF7, 0x5F,
				0x5D, 0x43,
				0x83,
				0x48,
				0x4B,
				0xE9,
				0x7C,
				0xFA,
				0x6C,
				0x7C
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontFileEnumerator));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontFileEnumerator));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFileEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontFileEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFileEnumerator*, uint>)(lpVtbl[1]))((IDWriteFontFileEnumerator*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFileEnumerator*, uint>)(lpVtbl[2]))((IDWriteFontFileEnumerator*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFileEnumerator::MoveNext"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult MoveNext(Bool32* hasCurrentFile)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFileEnumerator*, Bool32*, int>)(lpVtbl[3]))((IDWriteFontFileEnumerator*)Unsafe.AsPointer(ref this), hasCurrentFile);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFileEnumerator::GetCurrentFontFile"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetCurrentFontFile(IDWriteFontFile** fontFile)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontFileEnumerator*, IDWriteFontFile**, int>)(lpVtbl[4]))((IDWriteFontFileEnumerator*)Unsafe.AsPointer(ref this), fontFile);
	}
	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult MoveNext(Bool32* hasCurrentFile);

		[VtblIndex(4)]
		HResult GetCurrentFontFile(IDWriteFontFile** fontFile);
	}
}

