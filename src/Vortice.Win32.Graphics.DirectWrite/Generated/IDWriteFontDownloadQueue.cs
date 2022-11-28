// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontDownloadQueue"]/*' />
/// <unmanaged>IDWriteFontDownloadQueue</unmanaged>
[Guid("b71e6052-5aea-4fa3-832e-f60d431f7e91")]
[NativeTypeName("struct IDWriteFontDownloadQueue : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteFontDownloadQueue : INativeGuid
{
	public static ref readonly Guid IID_IDWriteFontDownloadQueue
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x52, 0x60, 0x1E, 0xB7,
				0xEA, 0x5A,
				0xA3, 0x4F,
				0x83,
				0x2E,
				0xF6,
				0x0D,
				0x43,
				0x1F,
				0x7E,
				0x91
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontDownloadQueue));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontDownloadQueue));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, uint>)(lpVtbl[1]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, uint>)(lpVtbl[2]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontDownloadQueue::AddListener"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult AddListener(IDWriteFontDownloadListener* listener, uint* token)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, IDWriteFontDownloadListener*, uint*, int>)(lpVtbl[3]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this), listener, token);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontDownloadQueue::RemoveListener"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult RemoveListener(uint token)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, uint, int>)(lpVtbl[4]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this), token);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontDownloadQueue::IsEmpty"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public Bool32 IsEmpty()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, Bool32>)(lpVtbl[5]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontDownloadQueue::BeginDownload"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult BeginDownload(IUnknown* context)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, IUnknown*, int>)(lpVtbl[6]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this), context);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontDownloadQueue::CancelDownload"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CancelDownload()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, int>)(lpVtbl[7]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteFontDownloadQueue::GetGenerationCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public ulong GetGenerationCount()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, ulong>)(lpVtbl[8]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this));
	}
}

