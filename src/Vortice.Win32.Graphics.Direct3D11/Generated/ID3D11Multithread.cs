// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Multithread"]/*' />
/// <unmanaged>ID3D11Multithread</unmanaged>
[Guid("9b7e4e00-342c-4106-a19f-4f2704f689f0")]
[NativeTypeName("struct ID3D11Multithread : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D11Multithread : ID3D11Multithread.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D11Multithread
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x00, 0x4E, 0x7E, 0x9B,
				0x2C, 0x34,
				0x06, 0x41,
				0xA1,
				0x9F,
				0x4F,
				0x27,
				0x04,
				0xF6,
				0x89,
				0xF0
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Multithread));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11Multithread*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11Multithread*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11Multithread*, uint>)(lpVtbl[1]))((ID3D11Multithread*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11Multithread*, uint>)(lpVtbl[2]))((ID3D11Multithread*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Multithread::Enter"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void Enter()
	{
		((delegate* unmanaged[MemberFunction]<ID3D11Multithread*, void>)(lpVtbl[3]))((ID3D11Multithread*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Multithread::Leave"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void Leave()
	{
		((delegate* unmanaged[MemberFunction]<ID3D11Multithread*, void>)(lpVtbl[4]))((ID3D11Multithread*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Multithread::SetMultithreadProtected"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public Bool32 SetMultithreadProtected(Bool32 bMTProtect)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11Multithread*, Bool32, Bool32>)(lpVtbl[5]))((ID3D11Multithread*)Unsafe.AsPointer(ref this), bMTProtect);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Multithread::GetMultithreadProtected"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public Bool32 GetMultithreadProtected()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11Multithread*, Bool32>)(lpVtbl[6]))((ID3D11Multithread*)Unsafe.AsPointer(ref this));
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		void Enter();

		[VtblIndex(4)]
		void Leave();

		[VtblIndex(5)]
		Bool32 SetMultithreadProtected(Bool32 bMTProtect);

		[VtblIndex(6)]
		Bool32 GetMultithreadProtected();
	}
}

