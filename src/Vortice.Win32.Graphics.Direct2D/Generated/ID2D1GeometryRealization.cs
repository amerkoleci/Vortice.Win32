// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1GeometryRealization"]/*' />
/// <unmanaged>ID2D1GeometryRealization</unmanaged>
[Guid("a16907d7-bc02-4801-99e8-8cf7f485f774")]
[NativeTypeName("struct ID2D1GeometryRealization : ID2D1Resource")]
[NativeInheritance("ID2D1Resource")]
public unsafe partial struct ID2D1GeometryRealization : ID2D1GeometryRealization.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID2D1GeometryRealization
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xD7, 0x07, 0x69, 0xA1,
				0x02, 0xBC,
				0x01, 0x48,
				0x99,
				0xE8,
				0x8C,
				0xF7,
				0xF4,
				0x85,
				0xF7,
				0x74
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1GeometryRealization));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1GeometryRealization));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1GeometryRealization*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1GeometryRealization*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1GeometryRealization*, uint>)(lpVtbl[1]))((ID2D1GeometryRealization*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1GeometryRealization*, uint>)(lpVtbl[2]))((ID2D1GeometryRealization*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1Resource.GetFactory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetFactory(ID2D1Factory** factory)
	{
		((delegate* unmanaged[Stdcall]<ID2D1GeometryRealization*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1GeometryRealization*)Unsafe.AsPointer(ref this), factory);
	}
	public interface Interface : ID2D1Resource.Interface
	{
	}
}

