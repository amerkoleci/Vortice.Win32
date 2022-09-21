// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderReflectionVariable"]/*' />
/// <unmanaged>ID3D11ShaderReflectionVariable</unmanaged>
[Guid("51f23923-f3e5-4bd1-91cb-606177d8db4c")]
public unsafe partial struct ID3D11ShaderReflectionVariable
{
	public static ref readonly Guid IID_ID3D11ShaderReflectionVariable
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x23, 0x39, 0xF2, 0x51,
				0xE5, 0xF3,
				0xD1, 0x4B,
				0x91,
				0xCB,
				0x60,
				0x61,
				0x77,
				0xD8,
				0xDB,
				0x4C
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11ShaderReflectionVariable));

	public void** lpVtbl;

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderReflectionVariable::GetDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult GetDesc(ShaderVariableDescription* pDesc)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionVariable*, ShaderVariableDescription*, int>)(lpVtbl[0]))((ID3D11ShaderReflectionVariable*)Unsafe.AsPointer(ref this), pDesc);
	}

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderReflectionVariable::GetType"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	public new ID3D11ShaderReflectionType GetType()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionVariable*, ID3D11ShaderReflectionType>)(lpVtbl[1]))((ID3D11ShaderReflectionVariable*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderReflectionVariable::GetBuffer"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	public ID3D11ShaderReflectionConstantBuffer GetBuffer()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionVariable*, ID3D11ShaderReflectionConstantBuffer>)(lpVtbl[2]))((ID3D11ShaderReflectionVariable*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderReflectionVariable::GetInterfaceSlot"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public uint GetInterfaceSlot(uint uArrayIndex)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionVariable*, uint, uint>)(lpVtbl[3]))((ID3D11ShaderReflectionVariable*)Unsafe.AsPointer(ref this), uArrayIndex);
	}
}

