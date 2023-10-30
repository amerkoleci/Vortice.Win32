// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflectionType"]/*' />
/// <unmanaged>ID3D12ShaderReflectionType</unmanaged>
[Guid("e913c351-783d-48ca-a1d1-4f306284ad56")]
public unsafe partial struct ID3D12ShaderReflectionType : ID3D12ShaderReflectionType.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D12ShaderReflectionType
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x51, 0xC3, 0x13, 0xE9,
				0x3D, 0x78,
				0xCA, 0x48,
				0xA1,
				0xD1,
				0x4F,
				0x30,
				0x62,
				0x84,
				0xAD,
				0x56
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12ShaderReflectionType));

	public void** lpVtbl;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflectionType::GetDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult GetDesc(ShaderTypeDescription* pDesc)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12ShaderReflectionType*, ShaderTypeDescription*, int>)(lpVtbl[0]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), pDesc);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflectionType::GetMemberTypeByIndex"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	public ID3D12ShaderReflectionType* GetMemberTypeByIndex(uint Index)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12ShaderReflectionType*, uint, ID3D12ShaderReflectionType*>)(lpVtbl[1]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), Index);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflectionType::GetMemberTypeByName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	public ID3D12ShaderReflectionType* GetMemberTypeByName(sbyte* Name)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12ShaderReflectionType*, sbyte*, ID3D12ShaderReflectionType*>)(lpVtbl[2]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), Name);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflectionType::GetMemberTypeName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public sbyte* GetMemberTypeName(uint Index)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12ShaderReflectionType*, uint, sbyte*>)(lpVtbl[3]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), Index);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflectionType::IsEqual"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult IsEqual(ID3D12ShaderReflectionType* pType)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)(lpVtbl[4]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), pType);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflectionType::GetSubType"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public ID3D12ShaderReflectionType* GetSubType()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*>)(lpVtbl[5]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflectionType::GetBaseClass"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public ID3D12ShaderReflectionType* GetBaseClass()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*>)(lpVtbl[6]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflectionType::GetNumInterfaces"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public uint GetNumInterfaces()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12ShaderReflectionType*, uint>)(lpVtbl[7]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflectionType::GetInterfaceByIndex"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public ID3D12ShaderReflectionType* GetInterfaceByIndex(uint uIndex)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12ShaderReflectionType*, uint, ID3D12ShaderReflectionType*>)(lpVtbl[8]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), uIndex);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflectionType::IsOfType"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult IsOfType(ID3D12ShaderReflectionType* pType)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)(lpVtbl[9]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), pType);
	}

	/// <include file='../Direct3D12.xml' path='doc/member[@name="ID3D12ShaderReflectionType::ImplementsInterface"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult ImplementsInterface(ID3D12ShaderReflectionType* pBase)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)(lpVtbl[10]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), pBase);
	}

	public interface Interface 
	{
		[VtblIndex(0)]
		HResult GetDesc(ShaderTypeDescription* pDesc);

		[VtblIndex(1)]
		ID3D12ShaderReflectionType* GetMemberTypeByIndex(uint Index);

		[VtblIndex(2)]
		ID3D12ShaderReflectionType* GetMemberTypeByName(sbyte* Name);

		[VtblIndex(3)]
		sbyte* GetMemberTypeName(uint Index);

		[VtblIndex(4)]
		HResult IsEqual(ID3D12ShaderReflectionType* pType);

		[VtblIndex(5)]
		ID3D12ShaderReflectionType* GetSubType();

		[VtblIndex(6)]
		ID3D12ShaderReflectionType* GetBaseClass();

		[VtblIndex(7)]
		uint GetNumInterfaces();

		[VtblIndex(8)]
		ID3D12ShaderReflectionType* GetInterfaceByIndex(uint uIndex);

		[VtblIndex(9)]
		HResult IsOfType(ID3D12ShaderReflectionType* pType);

		[VtblIndex(10)]
		HResult ImplementsInterface(ID3D12ShaderReflectionType* pBase);
	}
}

