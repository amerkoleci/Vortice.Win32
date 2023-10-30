// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12LibraryReflection"]/*' />
/// <unmanaged>ID3D12LibraryReflection</unmanaged>
[Guid("8e349d19-54db-4a56-9dc9-119d87bdb804")]
[NativeTypeName("struct ID3D12LibraryReflection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12LibraryReflection : ID3D12LibraryReflection.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D12LibraryReflection
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x19, 0x9D, 0x34, 0x8E,
				0xDB, 0x54,
				0x56, 0x4A,
				0x9D,
				0xC9,
				0x11,
				0x9D,
				0x87,
				0xBD,
				0xB8,
				0x04
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12LibraryReflection));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12LibraryReflection*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12LibraryReflection*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12LibraryReflection*, uint>)(lpVtbl[1]))((ID3D12LibraryReflection*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12LibraryReflection*, uint>)(lpVtbl[2]))((ID3D12LibraryReflection*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12LibraryReflection::GetDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetDesc(LibraryDescription* pDesc)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12LibraryReflection*, LibraryDescription*, int>)(lpVtbl[3]))((ID3D12LibraryReflection*)Unsafe.AsPointer(ref this), pDesc);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12LibraryReflection::GetFunctionByIndex"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public ID3D12FunctionReflection* GetFunctionByIndex(int FunctionIndex)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12LibraryReflection*, int, ID3D12FunctionReflection*>)(lpVtbl[4]))((ID3D12LibraryReflection*)Unsafe.AsPointer(ref this), FunctionIndex);
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult GetDesc(LibraryDescription* pDesc);

		[VtblIndex(4)]
		ID3D12FunctionReflection* GetFunctionByIndex(int FunctionIndex);
	}
}

