// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteColorGlyphRunEnumerator1"]/*' />
/// <unmanaged>IDWriteColorGlyphRunEnumerator1</unmanaged>
[Guid("7c5f86da-c7a1-4f05-b8e1-55a179fe5a35")]
[NativeTypeName("struct IDWriteColorGlyphRunEnumerator1 : IDWriteColorGlyphRunEnumerator")]
[NativeInheritance("IDWriteColorGlyphRunEnumerator")]
public unsafe partial struct IDWriteColorGlyphRunEnumerator1 : IDWriteColorGlyphRunEnumerator1.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDWriteColorGlyphRunEnumerator1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xDA, 0x86, 0x5F, 0x7C,
				0xA1, 0xC7,
				0x05, 0x4F,
				0xB8,
				0xE1,
				0x55,
				0xA1,
				0x79,
				0xFE,
				0x5A,
				0x35
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteColorGlyphRunEnumerator1));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteColorGlyphRunEnumerator1*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteColorGlyphRunEnumerator1*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteColorGlyphRunEnumerator1*, uint>)(lpVtbl[1]))((IDWriteColorGlyphRunEnumerator1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteColorGlyphRunEnumerator1*, uint>)(lpVtbl[2]))((IDWriteColorGlyphRunEnumerator1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteColorGlyphRunEnumerator.MoveNext" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult MoveNext(Bool32* hasRun)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteColorGlyphRunEnumerator1*, Bool32*, int>)(lpVtbl[3]))((IDWriteColorGlyphRunEnumerator1*)Unsafe.AsPointer(ref this), hasRun);
	}

	/// <inheritdoc cref="IDWriteColorGlyphRunEnumerator.GetCurrentRun" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetCurrentRun(ColorGlyphRun** colorGlyphRun)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteColorGlyphRunEnumerator1*, ColorGlyphRun**, int>)(lpVtbl[4]))((IDWriteColorGlyphRunEnumerator1*)Unsafe.AsPointer(ref this), colorGlyphRun);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteColorGlyphRunEnumerator1::GetCurrentRun"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetCurrentRun(ColorGlyphRun1** colorGlyphRun)
	{
		return ((delegate* unmanaged[MemberFunction]<IDWriteColorGlyphRunEnumerator1*, ColorGlyphRun1**, int>)(lpVtbl[5]))((IDWriteColorGlyphRunEnumerator1*)Unsafe.AsPointer(ref this), colorGlyphRun);
	}

	public interface Interface : IDWriteColorGlyphRunEnumerator.Interface
	{
		[VtblIndex(5)]
		HResult GetCurrentRun(ColorGlyphRun1** colorGlyphRun);
	}
}

