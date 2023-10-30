// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12SwapChainAssistant"]/*' />
/// <unmanaged>ID3D12SwapChainAssistant</unmanaged>
[Guid("f1df64b6-57fd-49cd-8807-c0eb88b45c8f")]
[NativeTypeName("struct ID3D12SwapChainAssistant : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12SwapChainAssistant : ID3D12SwapChainAssistant.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D12SwapChainAssistant
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xB6, 0x64, 0xDF, 0xF1,
				0xFD, 0x57,
				0xCD, 0x49,
				0x88,
				0x07,
				0xC0,
				0xEB,
				0x88,
				0xB4,
				0x5C,
				0x8F
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12SwapChainAssistant));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12SwapChainAssistant*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12SwapChainAssistant*, uint>)(lpVtbl[1]))((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12SwapChainAssistant*, uint>)(lpVtbl[2]))((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12SwapChainAssistant::GetLUID"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public Luid GetLUID()
	{
		Luid result;
		return *((delegate* unmanaged[MemberFunction]<ID3D12SwapChainAssistant*, Luid*, Luid*>)(lpVtbl[3]))((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this), &result);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12SwapChainAssistant::GetSwapChainObject"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetSwapChainObject(Guid* riid, void** ppv)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12SwapChainAssistant*, Guid*, void**, int>)(lpVtbl[4]))((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this), riid, ppv);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12SwapChainAssistant::GetCurrentResourceAndCommandQueue"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetCurrentResourceAndCommandQueue(Guid* riidResource, void** ppvResource, Guid* riidQueue, void** ppvQueue)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)(lpVtbl[5]))((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this), riidResource, ppvResource, riidQueue, ppvQueue);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12SwapChainAssistant::InsertImplicitSync"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult InsertImplicitSync()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12SwapChainAssistant*, int>)(lpVtbl[6]))((ID3D12SwapChainAssistant*)Unsafe.AsPointer(ref this));
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		Luid GetLUID();

		[VtblIndex(4)]
		HResult GetSwapChainObject(Guid* riid, void** ppv);

		[VtblIndex(5)]
		HResult GetCurrentResourceAndCommandQueue(Guid* riidResource, void** ppvResource, Guid* riidQueue, void** ppvQueue);

		[VtblIndex(6)]
		HResult InsertImplicitSync();
	}
}

