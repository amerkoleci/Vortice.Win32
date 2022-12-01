// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderReflection"]/*' />
/// <unmanaged>ID3D11ShaderReflection</unmanaged>
[Guid("8d536ca1-0cca-4956-a837-786963755584")]
[NativeTypeName("struct ID3D11ShaderReflection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D11ShaderReflection : ID3D11ShaderReflection.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D11ShaderReflection
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xA1, 0x6C, 0x53, 0x8D,
				0xCA, 0x0C,
				0x56, 0x49,
				0xA8,
				0x37,
				0x78,
				0x69,
				0x63,
				0x75,
				0x55,
				0x84
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11ShaderReflection));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11ShaderReflection));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint>)(lpVtbl[1]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint>)(lpVtbl[2]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderReflection::GetDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetDesc(ShaderDescription* pDesc)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, ShaderDescription*, int>)(lpVtbl[3]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), pDesc);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderReflection::GetConstantBufferByIndex"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public ID3D11ShaderReflectionConstantBuffer GetConstantBufferByIndex(uint Index)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint, ID3D11ShaderReflectionConstantBuffer>)(lpVtbl[4]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), Index);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderReflection::GetConstantBufferByName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public ID3D11ShaderReflectionConstantBuffer GetConstantBufferByName(sbyte* Name)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, sbyte*, ID3D11ShaderReflectionConstantBuffer>)(lpVtbl[5]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), Name);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderReflection::GetResourceBindingDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetResourceBindingDesc(uint ResourceIndex, ShaderInputBindDescription* pDesc)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint, ShaderInputBindDescription*, int>)(lpVtbl[6]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), ResourceIndex, pDesc);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderReflection::GetInputParameterDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetInputParameterDesc(uint ParameterIndex, SignatureParameterDescription* pDesc)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint, SignatureParameterDescription*, int>)(lpVtbl[7]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderReflection::GetOutputParameterDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetOutputParameterDesc(uint ParameterIndex, SignatureParameterDescription* pDesc)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint, SignatureParameterDescription*, int>)(lpVtbl[8]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderReflection::GetPatchConstantParameterDesc"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetPatchConstantParameterDesc(uint ParameterIndex, SignatureParameterDescription* pDesc)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint, SignatureParameterDescription*, int>)(lpVtbl[9]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderReflection::GetVariableByName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public ID3D11ShaderReflectionVariable GetVariableByName(sbyte* Name)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, sbyte*, ID3D11ShaderReflectionVariable>)(lpVtbl[10]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), Name);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderReflection::GetResourceBindingDescByName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetResourceBindingDescByName(sbyte* Name, ShaderInputBindDescription* pDesc)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, sbyte*, ShaderInputBindDescription*, int>)(lpVtbl[11]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), Name, pDesc);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderReflection::GetMovInstructionCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public uint GetMovInstructionCount()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint>)(lpVtbl[12]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderReflection::GetMovcInstructionCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public uint GetMovcInstructionCount()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint>)(lpVtbl[13]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderReflection::GetConversionInstructionCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public uint GetConversionInstructionCount()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint>)(lpVtbl[14]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderReflection::GetBitwiseInstructionCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public uint GetBitwiseInstructionCount()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint>)(lpVtbl[15]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderReflection::GetGSInputPrimitive"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public Graphics.Direct3D.Primitive GetGSInputPrimitive()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, Graphics.Direct3D.Primitive>)(lpVtbl[16]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderReflection::IsSampleFrequencyShader"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public Bool32 IsSampleFrequencyShader()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, Bool32>)(lpVtbl[17]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderReflection::GetNumInterfaceSlots"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public uint GetNumInterfaceSlots()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint>)(lpVtbl[18]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderReflection::GetMinFeatureLevel"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult GetMinFeatureLevel(Graphics.Direct3D.FeatureLevel* pLevel)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, Graphics.Direct3D.FeatureLevel*, int>)(lpVtbl[19]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), pLevel);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderReflection::GetThreadGroupSize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public uint GetThreadGroupSize(uint* pSizeX, uint* pSizeY, uint* pSizeZ)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)(lpVtbl[20]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), pSizeX, pSizeY, pSizeZ);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderReflection::GetRequiresFlags"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public ulong GetRequiresFlags()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, ulong>)(lpVtbl[21]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
	}
	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult GetDesc(ShaderDescription* pDesc);

		[VtblIndex(4)]
		ID3D11ShaderReflectionConstantBuffer GetConstantBufferByIndex(uint Index);

		[VtblIndex(5)]
		ID3D11ShaderReflectionConstantBuffer GetConstantBufferByName(sbyte* Name);

		[VtblIndex(6)]
		HResult GetResourceBindingDesc(uint ResourceIndex, ShaderInputBindDescription* pDesc);

		[VtblIndex(7)]
		HResult GetInputParameterDesc(uint ParameterIndex, SignatureParameterDescription* pDesc);

		[VtblIndex(8)]
		HResult GetOutputParameterDesc(uint ParameterIndex, SignatureParameterDescription* pDesc);

		[VtblIndex(9)]
		HResult GetPatchConstantParameterDesc(uint ParameterIndex, SignatureParameterDescription* pDesc);

		[VtblIndex(10)]
		ID3D11ShaderReflectionVariable GetVariableByName(sbyte* Name);

		[VtblIndex(11)]
		HResult GetResourceBindingDescByName(sbyte* Name, ShaderInputBindDescription* pDesc);

		[VtblIndex(12)]
		uint GetMovInstructionCount();

		[VtblIndex(13)]
		uint GetMovcInstructionCount();

		[VtblIndex(14)]
		uint GetConversionInstructionCount();

		[VtblIndex(15)]
		uint GetBitwiseInstructionCount();

		[VtblIndex(16)]
		Graphics.Direct3D.Primitive GetGSInputPrimitive();

		[VtblIndex(17)]
		Bool32 IsSampleFrequencyShader();

		[VtblIndex(18)]
		uint GetNumInterfaceSlots();

		[VtblIndex(19)]
		HResult GetMinFeatureLevel(Graphics.Direct3D.FeatureLevel* pLevel);

		[VtblIndex(20)]
		uint GetThreadGroupSize(uint* pSizeX, uint* pSizeY, uint* pSizeZ);

		[VtblIndex(21)]
		ulong GetRequiresFlags();
	}
}

