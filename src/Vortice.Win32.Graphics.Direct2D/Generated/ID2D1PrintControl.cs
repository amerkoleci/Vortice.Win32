// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1PrintControl"]/*' />
/// <unmanaged>ID2D1PrintControl</unmanaged>
[Guid("2c1d867d-c290-41c8-ae7e-34a98702e9a5")]
[NativeTypeName("struct ID2D1PrintControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID2D1PrintControl : ID2D1PrintControl.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID2D1PrintControl
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x7D, 0x86, 0x1D, 0x2C,
				0x90, 0xC2,
				0xC8, 0x41,
				0xAE,
				0x7E,
				0x34,
				0xA9,
				0x87,
				0x02,
				0xE9,
				0xA5
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1PrintControl));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1PrintControl*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1PrintControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1PrintControl*, uint>)(lpVtbl[1]))((ID2D1PrintControl*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1PrintControl*, uint>)(lpVtbl[2]))((ID2D1PrintControl*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1PrintControl::AddPage"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult AddPage(ID2D1CommandList* commandList, System.Drawing.SizeF pageSize, Com.IStream* pagePrintTicketStream, ulong* tag1, ulong* tag2)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1PrintControl*, ID2D1CommandList*, System.Drawing.SizeF, Com.IStream*, ulong*, ulong*, int>)(lpVtbl[3]))((ID2D1PrintControl*)Unsafe.AsPointer(ref this), commandList, pageSize, pagePrintTicketStream, tag1, tag2);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1PrintControl::Close"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult Close()
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1PrintControl*, int>)(lpVtbl[4]))((ID2D1PrintControl*)Unsafe.AsPointer(ref this));
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult AddPage(ID2D1CommandList* commandList, System.Drawing.SizeF pageSize, Com.IStream* pagePrintTicketStream, ulong* tag1, ulong* tag2);

		[VtblIndex(4)]
		HResult Close();
	}
}

