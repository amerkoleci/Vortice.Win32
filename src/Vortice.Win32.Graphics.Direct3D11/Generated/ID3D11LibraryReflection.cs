// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11LibraryReflection"]/*' />
/// <unmanaged>ID3D11LibraryReflection</unmanaged>
[Guid("54384f1b-5b3e-4bb7-ae01-60ba3097cbb6")]
[NativeTypeName("struct ID3D11LibraryReflection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D11LibraryReflection : ID3D11LibraryReflection.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D11LibraryReflection
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x1B, 0x4F, 0x38, 0x54,
				0x3E, 0x5B,
				0xB7, 0x4B,
				0xAE,
				0x01,
				0x60,
				0xBA,
				0x30,
				0x97,
				0xCB,
				0xB6
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11LibraryReflection));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11LibraryReflection*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11LibraryReflection*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11LibraryReflection*, uint>)(lpVtbl[1]))((ID3D11LibraryReflection*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11LibraryReflection*, uint>)(lpVtbl[2]))((ID3D11LibraryReflection*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11LibraryReflection::GetDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetDesc(LibraryDescription* pDesc)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11LibraryReflection*, LibraryDescription*, int>)(lpVtbl[3]))((ID3D11LibraryReflection*)Unsafe.AsPointer(ref this), pDesc);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11LibraryReflection::GetFunctionByIndex"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public ID3D11FunctionReflection* GetFunctionByIndex(int FunctionIndex)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11LibraryReflection*, int, ID3D11FunctionReflection*>)(lpVtbl[4]))((ID3D11LibraryReflection*)Unsafe.AsPointer(ref this), FunctionIndex);
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult GetDesc(LibraryDescription* pDesc);

		[VtblIndex(4)]
		ID3D11FunctionReflection* GetFunctionByIndex(int FunctionIndex);
	}
}

