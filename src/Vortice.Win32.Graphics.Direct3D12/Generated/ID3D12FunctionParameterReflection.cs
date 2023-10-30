// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12FunctionParameterReflection"]/*' />
/// <unmanaged>ID3D12FunctionParameterReflection</unmanaged>
[Guid("ec25f42d-7006-4f2b-b33e-02cc3375733f")]
public unsafe partial struct ID3D12FunctionParameterReflection : ID3D12FunctionParameterReflection.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D12FunctionParameterReflection
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x2D, 0xF4, 0x25, 0xEC,
				0x06, 0x70,
				0x2B, 0x4F,
				0xB3,
				0x3E,
				0x02,
				0xCC,
				0x33,
				0x75,
				0x73,
				0x3F
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12FunctionParameterReflection));

	public void** lpVtbl;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12FunctionParameterReflection::GetDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult GetDesc(ParameterDescription* pDesc)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12FunctionParameterReflection*, ParameterDescription*, int>)(lpVtbl[0]))((ID3D12FunctionParameterReflection*)Unsafe.AsPointer(ref this), pDesc);
	}

	public interface Interface 
	{
		[VtblIndex(0)]
		HResult GetDesc(ParameterDescription* pDesc);
	}
}

