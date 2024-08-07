// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D.Dxc;

/// <unmanaged>IDxcPdbUtils</unmanaged>
[Guid("e6c9647e-9d6a-4c3b-b94c-524b5a6c343d")]
[NativeTypeName("struct IDxcPdbUtils : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxcPdbUtils : IDxcPdbUtils.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDxcPdbUtils
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x7E, 0x64, 0xC9, 0xE6,
				0x6A, 0x9D,
				0x3B, 0x4C,
				0xB9,
				0x4C,
				0x52,
				0x4B,
				0x5A,
				0x6C,
				0x34,
				0x3D
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcPdbUtils));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils*, Guid*, void**, int>)(lpVtbl[0]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils*, uint>)(lpVtbl[1]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils*, uint>)(lpVtbl[2]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult Load(IDxcBlob* pPdbOrDxil)
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils*, IDxcBlob*, int>)(lpVtbl[3]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pPdbOrDxil);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetSourceCount(uint* pCount)
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils*, uint*, int>)(lpVtbl[4]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pCount);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetSource(uint uIndex, IDxcBlobEncoding** ppResult)
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils*, uint, IDxcBlobEncoding**, int>)(lpVtbl[5]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), uIndex, ppResult);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetSourceName(uint uIndex, char** pResult)
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils*, uint, char**, int>)(lpVtbl[6]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), uIndex, pResult);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetFlagCount(uint* pCount)
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils*, uint*, int>)(lpVtbl[7]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pCount);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetFlag(uint uIndex, char** pResult)
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils*, uint, char**, int>)(lpVtbl[8]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), uIndex, pResult);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetArgCount(uint* pCount)
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils*, uint*, int>)(lpVtbl[9]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pCount);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult GetArg(uint uIndex, char** pResult)
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils*, uint, char**, int>)(lpVtbl[10]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), uIndex, pResult);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetArgPairCount(uint* pCount)
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils*, uint*, int>)(lpVtbl[11]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pCount);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult GetArgPair(uint uIndex, char** pName, char** pValue)
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils*, uint, char**, char**, int>)(lpVtbl[12]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), uIndex, pName, pValue);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult GetDefineCount(uint* pCount)
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils*, uint*, int>)(lpVtbl[13]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pCount);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult GetDefine(uint uIndex, char** pResult)
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils*, uint, char**, int>)(lpVtbl[14]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), uIndex, pResult);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult GetTargetProfile(char** pResult)
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils*, char**, int>)(lpVtbl[15]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pResult);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult GetEntryPoint(char** pResult)
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils*, char**, int>)(lpVtbl[16]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pResult);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult GetMainFileName(char** pResult)
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils*, char**, int>)(lpVtbl[17]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pResult);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult GetHash(IDxcBlob** ppResult)
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils*, IDxcBlob**, int>)(lpVtbl[18]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), ppResult);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult GetName(char** pResult)
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils*, char**, int>)(lpVtbl[19]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pResult);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public Bool32 IsFullPDB()
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils*, Bool32>)(lpVtbl[20]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult GetFullPDB(IDxcBlob** ppFullPDB)
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils*, IDxcBlob**, int>)(lpVtbl[21]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), ppFullPDB);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult GetVersionInfo(IDxcVersionInfo** ppVersionInfo)
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils*, IDxcVersionInfo**, int>)(lpVtbl[22]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), ppVersionInfo);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public HResult SetCompiler(IDxcCompiler3* pCompiler)
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils*, IDxcCompiler3*, int>)(lpVtbl[23]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pCompiler);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult CompileForFullPDB(IDxcResult** ppResult)
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils*, IDxcResult**, int>)(lpVtbl[24]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), ppResult);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public HResult OverrideArgs(DxcArgPair* pArgPairs, uint uNumArgPairs)
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils*, DxcArgPair*, uint, int>)(lpVtbl[25]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pArgPairs, uNumArgPairs);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public HResult OverrideRootSignature(char* pRootSignature)
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcPdbUtils*, char*, int>)(lpVtbl[26]))((IDxcPdbUtils*)Unsafe.AsPointer(ref this), pRootSignature);
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult Load(IDxcBlob* pPdbOrDxil);

		[VtblIndex(4)]
		HResult GetSourceCount(uint* pCount);

		[VtblIndex(5)]
		HResult GetSource(uint uIndex, IDxcBlobEncoding** ppResult);

		[VtblIndex(6)]
		HResult GetSourceName(uint uIndex, char** pResult);

		[VtblIndex(7)]
		HResult GetFlagCount(uint* pCount);

		[VtblIndex(8)]
		HResult GetFlag(uint uIndex, char** pResult);

		[VtblIndex(9)]
		HResult GetArgCount(uint* pCount);

		[VtblIndex(10)]
		HResult GetArg(uint uIndex, char** pResult);

		[VtblIndex(11)]
		HResult GetArgPairCount(uint* pCount);

		[VtblIndex(12)]
		HResult GetArgPair(uint uIndex, char** pName, char** pValue);

		[VtblIndex(13)]
		HResult GetDefineCount(uint* pCount);

		[VtblIndex(14)]
		HResult GetDefine(uint uIndex, char** pResult);

		[VtblIndex(15)]
		HResult GetTargetProfile(char** pResult);

		[VtblIndex(16)]
		HResult GetEntryPoint(char** pResult);

		[VtblIndex(17)]
		HResult GetMainFileName(char** pResult);

		[VtblIndex(18)]
		HResult GetHash(IDxcBlob** ppResult);

		[VtblIndex(19)]
		HResult GetName(char** pResult);

		[VtblIndex(20)]
		Bool32 IsFullPDB();

		[VtblIndex(21)]
		HResult GetFullPDB(IDxcBlob** ppFullPDB);

		[VtblIndex(22)]
		HResult GetVersionInfo(IDxcVersionInfo** ppVersionInfo);

		[VtblIndex(23)]
		HResult SetCompiler(IDxcCompiler3* pCompiler);

		[VtblIndex(24)]
		HResult CompileForFullPDB(IDxcResult** ppResult);

		[VtblIndex(25)]
		HResult OverrideArgs(DxcArgPair* pArgPairs, uint uNumArgPairs);

		[VtblIndex(26)]
		HResult OverrideRootSignature(char* pRootSignature);
	}
}

