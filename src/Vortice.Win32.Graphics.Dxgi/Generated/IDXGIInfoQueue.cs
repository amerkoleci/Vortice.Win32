// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Dxgi;

/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue"]/*' />
/// <unmanaged>IDXGIInfoQueue</unmanaged>
[Guid("d67441c7-672a-476f-9e82-cd55b44949ce")]
[NativeTypeName("struct IDXGIInfoQueue : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDXGIInfoQueue : IDXGIInfoQueue.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDXGIInfoQueue
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xC7, 0x41, 0x74, 0xD6,
				0x2A, 0x67,
				0x6F, 0x47,
				0x9E,
				0x82,
				0xCD,
				0x55,
				0xB4,
				0x49,
				0x49,
				0xCE
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIInfoQueue));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, uint>)(lpVtbl[1]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, uint>)(lpVtbl[2]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::SetMessageCountLimit"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetMessageCountLimit(Guid Producer, ulong MessageCountLimit)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, ulong, int>)(lpVtbl[3]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, MessageCountLimit);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::ClearStoredMessages"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void ClearStoredMessages(Guid Producer)
	{
		((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, void>)(lpVtbl[4]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::GetMessage"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetMessage(Guid Producer, ulong MessageIndex, InfoQueueMessage* pMessage, nuint* pMessageByteLength)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, ulong, InfoQueueMessage*, nuint*, int>)(lpVtbl[5]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, MessageIndex, pMessage, pMessageByteLength);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::GetNumStoredMessagesAllowedByRetrievalFilters"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public ulong GetNumStoredMessagesAllowedByRetrievalFilters(Guid Producer)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, ulong>)(lpVtbl[6]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::GetNumStoredMessages"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public ulong GetNumStoredMessages(Guid Producer)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, ulong>)(lpVtbl[7]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::GetNumMessagesDiscardedByMessageCountLimit"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public ulong GetNumMessagesDiscardedByMessageCountLimit(Guid Producer)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, ulong>)(lpVtbl[8]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::GetMessageCountLimit"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public ulong GetMessageCountLimit(Guid Producer)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, ulong>)(lpVtbl[9]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::GetNumMessagesAllowedByStorageFilter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public ulong GetNumMessagesAllowedByStorageFilter(Guid Producer)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, ulong>)(lpVtbl[10]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::GetNumMessagesDeniedByStorageFilter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public ulong GetNumMessagesDeniedByStorageFilter(Guid Producer)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, ulong>)(lpVtbl[11]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::AddStorageFilterEntries"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult AddStorageFilterEntries(Guid Producer, InfoQueueFilter* pFilter)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)(lpVtbl[12]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::GetStorageFilter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult GetStorageFilter(Guid Producer, InfoQueueFilter* pFilter, nuint* pFilterByteLength)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)(lpVtbl[13]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter, pFilterByteLength);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::ClearStorageFilter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public void ClearStorageFilter(Guid Producer)
	{
		((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, void>)(lpVtbl[14]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::PushEmptyStorageFilter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult PushEmptyStorageFilter(Guid Producer)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, int>)(lpVtbl[15]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::PushDenyAllStorageFilter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult PushDenyAllStorageFilter(Guid Producer)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, int>)(lpVtbl[16]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::PushCopyOfStorageFilter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult PushCopyOfStorageFilter(Guid Producer)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, int>)(lpVtbl[17]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::PushStorageFilter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult PushStorageFilter(Guid Producer, InfoQueueFilter* pFilter)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)(lpVtbl[18]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::PopStorageFilter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public void PopStorageFilter(Guid Producer)
	{
		((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, void>)(lpVtbl[19]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::GetStorageFilterStackSize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public uint GetStorageFilterStackSize(Guid Producer)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, uint>)(lpVtbl[20]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::AddRetrievalFilterEntries"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult AddRetrievalFilterEntries(Guid Producer, InfoQueueFilter* pFilter)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)(lpVtbl[21]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::GetRetrievalFilter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult GetRetrievalFilter(Guid Producer, InfoQueueFilter* pFilter, nuint* pFilterByteLength)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, nuint*, int>)(lpVtbl[22]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter, pFilterByteLength);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::ClearRetrievalFilter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public void ClearRetrievalFilter(Guid Producer)
	{
		((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, void>)(lpVtbl[23]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::PushEmptyRetrievalFilter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult PushEmptyRetrievalFilter(Guid Producer)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, int>)(lpVtbl[24]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::PushDenyAllRetrievalFilter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public HResult PushDenyAllRetrievalFilter(Guid Producer)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, int>)(lpVtbl[25]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::PushCopyOfRetrievalFilter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public HResult PushCopyOfRetrievalFilter(Guid Producer)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, int>)(lpVtbl[26]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::PushRetrievalFilter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public HResult PushRetrievalFilter(Guid Producer, InfoQueueFilter* pFilter)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, InfoQueueFilter*, int>)(lpVtbl[27]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::PopRetrievalFilter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public void PopRetrievalFilter(Guid Producer)
	{
		((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, void>)(lpVtbl[28]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::GetRetrievalFilterStackSize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(29)]
	public uint GetRetrievalFilterStackSize(Guid Producer)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, uint>)(lpVtbl[29]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::AddMessage"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(30)]
	public HResult AddMessage(Guid Producer, InfoQueueMessageCategory Category, InfoQueueMessageSeverity Severity, int ID, sbyte* pDescription)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, InfoQueueMessageSeverity, int, sbyte*, int>)(lpVtbl[30]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, Category, Severity, ID, pDescription);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::AddApplicationMessage"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(31)]
	public HResult AddApplicationMessage(InfoQueueMessageSeverity Severity, sbyte* pDescription)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, InfoQueueMessageSeverity, sbyte*, int>)(lpVtbl[31]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Severity, pDescription);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::SetBreakOnCategory"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(32)]
	public HResult SetBreakOnCategory(Guid Producer, InfoQueueMessageCategory Category, Bool32 bEnable)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, Bool32, int>)(lpVtbl[32]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, Category, bEnable);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::SetBreakOnSeverity"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(33)]
	public HResult SetBreakOnSeverity(Guid Producer, InfoQueueMessageSeverity Severity, Bool32 bEnable)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, InfoQueueMessageSeverity, Bool32, int>)(lpVtbl[33]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, Severity, bEnable);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::SetBreakOnID"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(34)]
	public HResult SetBreakOnID(Guid Producer, int ID, Bool32 bEnable)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, int, Bool32, int>)(lpVtbl[34]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, ID, bEnable);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::GetBreakOnCategory"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(35)]
	public Bool32 GetBreakOnCategory(Guid Producer, InfoQueueMessageCategory Category)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, InfoQueueMessageCategory, Bool32>)(lpVtbl[35]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, Category);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::GetBreakOnSeverity"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(36)]
	public Bool32 GetBreakOnSeverity(Guid Producer, InfoQueueMessageSeverity Severity)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, InfoQueueMessageSeverity, Bool32>)(lpVtbl[36]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, Severity);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::GetBreakOnID"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(37)]
	public Bool32 GetBreakOnID(Guid Producer, int ID)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, int, Bool32>)(lpVtbl[37]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, ID);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::SetMuteDebugOutput"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(38)]
	public void SetMuteDebugOutput(Guid Producer, Bool32 bMute)
	{
		((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, Bool32, void>)(lpVtbl[38]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, bMute);
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGIInfoQueue::GetMuteDebugOutput"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(39)]
	public Bool32 GetMuteDebugOutput(Guid Producer)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGIInfoQueue*, Guid, Bool32>)(lpVtbl[39]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult SetMessageCountLimit(Guid Producer, ulong MessageCountLimit);

		[VtblIndex(4)]
		void ClearStoredMessages(Guid Producer);

		[VtblIndex(5)]
		HResult GetMessage(Guid Producer, ulong MessageIndex, InfoQueueMessage* pMessage, nuint* pMessageByteLength);

		[VtblIndex(6)]
		ulong GetNumStoredMessagesAllowedByRetrievalFilters(Guid Producer);

		[VtblIndex(7)]
		ulong GetNumStoredMessages(Guid Producer);

		[VtblIndex(8)]
		ulong GetNumMessagesDiscardedByMessageCountLimit(Guid Producer);

		[VtblIndex(9)]
		ulong GetMessageCountLimit(Guid Producer);

		[VtblIndex(10)]
		ulong GetNumMessagesAllowedByStorageFilter(Guid Producer);

		[VtblIndex(11)]
		ulong GetNumMessagesDeniedByStorageFilter(Guid Producer);

		[VtblIndex(12)]
		HResult AddStorageFilterEntries(Guid Producer, InfoQueueFilter* pFilter);

		[VtblIndex(13)]
		HResult GetStorageFilter(Guid Producer, InfoQueueFilter* pFilter, nuint* pFilterByteLength);

		[VtblIndex(14)]
		void ClearStorageFilter(Guid Producer);

		[VtblIndex(15)]
		HResult PushEmptyStorageFilter(Guid Producer);

		[VtblIndex(16)]
		HResult PushDenyAllStorageFilter(Guid Producer);

		[VtblIndex(17)]
		HResult PushCopyOfStorageFilter(Guid Producer);

		[VtblIndex(18)]
		HResult PushStorageFilter(Guid Producer, InfoQueueFilter* pFilter);

		[VtblIndex(19)]
		void PopStorageFilter(Guid Producer);

		[VtblIndex(20)]
		uint GetStorageFilterStackSize(Guid Producer);

		[VtblIndex(21)]
		HResult AddRetrievalFilterEntries(Guid Producer, InfoQueueFilter* pFilter);

		[VtblIndex(22)]
		HResult GetRetrievalFilter(Guid Producer, InfoQueueFilter* pFilter, nuint* pFilterByteLength);

		[VtblIndex(23)]
		void ClearRetrievalFilter(Guid Producer);

		[VtblIndex(24)]
		HResult PushEmptyRetrievalFilter(Guid Producer);

		[VtblIndex(25)]
		HResult PushDenyAllRetrievalFilter(Guid Producer);

		[VtblIndex(26)]
		HResult PushCopyOfRetrievalFilter(Guid Producer);

		[VtblIndex(27)]
		HResult PushRetrievalFilter(Guid Producer, InfoQueueFilter* pFilter);

		[VtblIndex(28)]
		void PopRetrievalFilter(Guid Producer);

		[VtblIndex(29)]
		uint GetRetrievalFilterStackSize(Guid Producer);

		[VtblIndex(30)]
		HResult AddMessage(Guid Producer, InfoQueueMessageCategory Category, InfoQueueMessageSeverity Severity, int ID, sbyte* pDescription);

		[VtblIndex(31)]
		HResult AddApplicationMessage(InfoQueueMessageSeverity Severity, sbyte* pDescription);

		[VtblIndex(32)]
		HResult SetBreakOnCategory(Guid Producer, InfoQueueMessageCategory Category, Bool32 bEnable);

		[VtblIndex(33)]
		HResult SetBreakOnSeverity(Guid Producer, InfoQueueMessageSeverity Severity, Bool32 bEnable);

		[VtblIndex(34)]
		HResult SetBreakOnID(Guid Producer, int ID, Bool32 bEnable);

		[VtblIndex(35)]
		Bool32 GetBreakOnCategory(Guid Producer, InfoQueueMessageCategory Category);

		[VtblIndex(36)]
		Bool32 GetBreakOnSeverity(Guid Producer, InfoQueueMessageSeverity Severity);

		[VtblIndex(37)]
		Bool32 GetBreakOnID(Guid Producer, int ID);

		[VtblIndex(38)]
		void SetMuteDebugOutput(Guid Producer, Bool32 bMute);

		[VtblIndex(39)]
		Bool32 GetMuteDebugOutput(Guid Producer);
	}
}

