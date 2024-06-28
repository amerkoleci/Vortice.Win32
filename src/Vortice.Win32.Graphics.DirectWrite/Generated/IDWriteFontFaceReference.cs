// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFaceReference"]/*' />
/// <unmanaged>IDWriteFontFaceReference</unmanaged>
[Guid("5e7fa7ca-dde3-424c-89f0-9fcd6fed58cd")]
[NativeTypeName("struct IDWriteFontFaceReference : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteFontFaceReference : IDWriteFontFaceReference.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDWriteFontFaceReference
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xCA, 0xA7, 0x7F, 0x5E,
				0xE3, 0xDD,
				0x4C, 0x42,
				0x89,
				0xF0,
				0x9F,
				0xCD,
				0x6F,
				0xED,
				0x58,
				0xCD
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontFaceReference));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFontFaceReference*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFontFaceReference*, uint>)(lpVtbl[1]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFontFaceReference*, uint>)(lpVtbl[2]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFaceReference::CreateFontFace"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult CreateFontFace(IDWriteFontFace3** fontFace)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFontFaceReference*, IDWriteFontFace3**, int>)(lpVtbl[3]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this), fontFace);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFaceReference::CreateFontFaceWithSimulations"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult CreateFontFaceWithSimulations(FontSimulations fontFaceSimulationFlags, IDWriteFontFace3** fontFace)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFontFaceReference*, FontSimulations, IDWriteFontFace3**, int>)(lpVtbl[4]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this), fontFaceSimulationFlags, fontFace);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFaceReference::Equals"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public Bool32 Equals(IDWriteFontFaceReference* fontFaceReference)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFontFaceReference*, IDWriteFontFaceReference*, Bool32>)(lpVtbl[5]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this), fontFaceReference);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFaceReference::GetFontFaceIndex"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public uint GetFontFaceIndex()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFontFaceReference*, uint>)(lpVtbl[6]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFaceReference::GetSimulations"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public FontSimulations GetSimulations()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFontFaceReference*, FontSimulations>)(lpVtbl[7]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFaceReference::GetFontFile"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetFontFile(IDWriteFontFile** fontFile)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFontFaceReference*, IDWriteFontFile**, int>)(lpVtbl[8]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this), fontFile);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFaceReference::GetLocalFileSize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public ulong GetLocalFileSize()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFontFaceReference*, ulong>)(lpVtbl[9]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFaceReference::GetFileSize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public ulong GetFileSize()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFontFaceReference*, ulong>)(lpVtbl[10]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFaceReference::GetFileTime"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetFileTime(ulong* lastWriteTime)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFontFaceReference*, ulong*, int>)(lpVtbl[11]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this), lastWriteTime);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFaceReference::GetLocality"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public Locality GetLocality()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFontFaceReference*, Locality>)(lpVtbl[12]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFaceReference::EnqueueFontDownloadRequest"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult EnqueueFontDownloadRequest()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFontFaceReference*, int>)(lpVtbl[13]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFaceReference::EnqueueCharacterDownloadRequest"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult EnqueueCharacterDownloadRequest(char* characters, uint characterCount)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFontFaceReference*, char*, uint, int>)(lpVtbl[14]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this), characters, characterCount);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFaceReference::EnqueueGlyphDownloadRequest"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult EnqueueGlyphDownloadRequest(ushort* glyphIndices, uint glyphCount)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFontFaceReference*, ushort*, uint, int>)(lpVtbl[15]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this), glyphIndices, glyphCount);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontFaceReference::EnqueueFileFragmentDownloadRequest"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult EnqueueFileFragmentDownloadRequest(ulong fileOffset, ulong fragmentSize)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteFontFaceReference*, ulong, ulong, int>)(lpVtbl[16]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this), fileOffset, fragmentSize);
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult CreateFontFace(IDWriteFontFace3** fontFace);

		[VtblIndex(4)]
		HResult CreateFontFaceWithSimulations(FontSimulations fontFaceSimulationFlags, IDWriteFontFace3** fontFace);

		[VtblIndex(5)]
		Bool32 Equals(IDWriteFontFaceReference* fontFaceReference);

		[VtblIndex(6)]
		uint GetFontFaceIndex();

		[VtblIndex(7)]
		FontSimulations GetSimulations();

		[VtblIndex(8)]
		HResult GetFontFile(IDWriteFontFile** fontFile);

		[VtblIndex(9)]
		ulong GetLocalFileSize();

		[VtblIndex(10)]
		ulong GetFileSize();

		[VtblIndex(11)]
		HResult GetFileTime(ulong* lastWriteTime);

		[VtblIndex(12)]
		Locality GetLocality();

		[VtblIndex(13)]
		HResult EnqueueFontDownloadRequest();

		[VtblIndex(14)]
		HResult EnqueueCharacterDownloadRequest(char* characters, uint characterCount);

		[VtblIndex(15)]
		HResult EnqueueGlyphDownloadRequest(ushort* glyphIndices, uint glyphCount);

		[VtblIndex(16)]
		HResult EnqueueFileFragmentDownloadRequest(ulong fileOffset, ulong fragmentSize);
	}
}

