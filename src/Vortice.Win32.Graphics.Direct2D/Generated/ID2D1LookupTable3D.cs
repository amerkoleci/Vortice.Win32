// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1LookupTable3D"]/*' />
/// <unmanaged>ID2D1LookupTable3D</unmanaged>
[Guid("53dd9855-a3b0-4d5b-82e1-26e25c5e5797")]
[NativeTypeName("struct ID2D1LookupTable3D : ID2D1Resource")]
[NativeInheritance("ID2D1Resource")]
public unsafe partial struct ID2D1LookupTable3D : ID2D1LookupTable3D.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID2D1LookupTable3D
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x55, 0x98, 0xDD, 0x53,
				0xB0, 0xA3,
				0x5B, 0x4D,
				0x82,
				0xE1,
				0x26,
				0xE2,
				0x5C,
				0x5E,
				0x57,
				0x97
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1LookupTable3D));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1LookupTable3D*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1LookupTable3D*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1LookupTable3D*, uint>)(lpVtbl[1]))((ID2D1LookupTable3D*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<ID2D1LookupTable3D*, uint>)(lpVtbl[2]))((ID2D1LookupTable3D*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1Resource.GetFactory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetFactory(ID2D1Factory** factory)
	{
		((delegate* unmanaged[MemberFunction]<ID2D1LookupTable3D*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1LookupTable3D*)Unsafe.AsPointer(ref this), factory);
	}

	public interface Interface : ID2D1Resource.Interface
	{
	}
}

