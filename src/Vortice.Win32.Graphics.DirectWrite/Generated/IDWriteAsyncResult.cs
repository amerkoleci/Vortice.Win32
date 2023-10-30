// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteAsyncResult"]/*' />
/// <unmanaged>IDWriteAsyncResult</unmanaged>
[Guid("ce25f8fd-863b-4d13-9651-c1f88dc73fe2")]
[NativeTypeName("struct IDWriteAsyncResult : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteAsyncResult : IDWriteAsyncResult.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDWriteAsyncResult
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xFD, 0xF8, 0x25, 0xCE,
				0x3B, 0x86,
				0x13, 0x4D,
				0x96,
				0x51,
				0xC1,
				0xF8,
				0x8D,
				0xC7,
				0x3F,
				0xE2
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteAsyncResult));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteAsyncResult*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteAsyncResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteAsyncResult*, uint>)(lpVtbl[1]))((IDWriteAsyncResult*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteAsyncResult*, uint>)(lpVtbl[2]))((IDWriteAsyncResult*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteAsyncResult::GetWaitHandle"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public Handle GetWaitHandle()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteAsyncResult*, Handle>)(lpVtbl[3]))((IDWriteAsyncResult*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteAsyncResult::GetResult"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetResult()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteAsyncResult*, int>)(lpVtbl[4]))((IDWriteAsyncResult*)Unsafe.AsPointer(ref this));
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		Handle GetWaitHandle();

		[VtblIndex(4)]
		HResult GetResult();
	}
}

