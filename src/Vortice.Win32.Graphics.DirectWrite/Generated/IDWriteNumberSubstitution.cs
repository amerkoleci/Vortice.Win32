// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteNumberSubstitution"]/*' />
/// <unmanaged>IDWriteNumberSubstitution</unmanaged>
[Guid("14885cc9-bab0-4f90-b6ed-5c366a2cd03d")]
[NativeTypeName("struct IDWriteNumberSubstitution : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteNumberSubstitution : INativeGuid
{
	public static ref readonly Guid IID_IDWriteNumberSubstitution
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xC9, 0x5C, 0x88, 0x14,
				0xB0, 0xBA,
				0x90, 0x4F,
				0xB6,
				0xED,
				0x5C,
				0x36,
				0x6A,
				0x2C,
				0xD0,
				0x3D
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteNumberSubstitution));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteNumberSubstitution));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteNumberSubstitution*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteNumberSubstitution*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteNumberSubstitution*, uint>)(lpVtbl[1]))((IDWriteNumberSubstitution*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteNumberSubstitution*, uint>)(lpVtbl[2]))((IDWriteNumberSubstitution*)Unsafe.AsPointer(ref this));
	}

}

