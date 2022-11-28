// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D.Dxc;

/// <unmanaged>IDxcCompiler2</unmanaged>
[Guid("a005a9d9-b8bb-4594-b5c9-0e633bec4d37")]
[NativeTypeName("struct IDxcCompiler2 : IDxcCompiler")]
[NativeInheritance("IDxcCompiler")]
public unsafe partial struct IDxcCompiler2 : INativeGuid
{
	public static ref readonly Guid IID_IDxcCompiler2
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xD9, 0xA9, 0x05, 0xA0,
				0xBB, 0xB8,
				0x94, 0x45,
				0xB5,
				0xC9,
				0x0E,
				0x63,
				0x3B,
				0xEC,
				0x4D,
				0x37
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcCompiler2));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcCompiler2));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcCompiler2*, Guid*, void**, int>)(lpVtbl[0]))((IDxcCompiler2*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDxcCompiler2*, uint>)(lpVtbl[1]))((IDxcCompiler2*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDxcCompiler2*, uint>)(lpVtbl[2]))((IDxcCompiler2*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDxcCompiler.Compile" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult Compile(IDxcBlob* pSource, ushort* pSourceName, ushort* pEntryPoint, ushort* pTargetProfile, ushort** pArguments, uint argCount, DxcDefine* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcCompiler2*, IDxcBlob*, ushort*, ushort*, ushort*, ushort**, uint, DxcDefine*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)(lpVtbl[3]))((IDxcCompiler2*)Unsafe.AsPointer(ref this), pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
	}

	/// <inheritdoc cref="IDxcCompiler.Preprocess" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult Preprocess(IDxcBlob* pSource, ushort* pSourceName, ushort** pArguments, uint argCount, DxcDefine* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcCompiler2*, IDxcBlob*, ushort*, ushort**, uint, DxcDefine*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)(lpVtbl[4]))((IDxcCompiler2*)Unsafe.AsPointer(ref this), pSource, pSourceName, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
	}

	/// <inheritdoc cref="IDxcCompiler.Disassemble" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult Disassemble(IDxcBlob* pSource, IDxcBlobEncoding** ppDisassembly)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcCompiler2*, IDxcBlob*, IDxcBlobEncoding**, int>)(lpVtbl[5]))((IDxcCompiler2*)Unsafe.AsPointer(ref this), pSource, ppDisassembly);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult CompileWithDebug(IDxcBlob* pSource, ushort* pSourceName, ushort* pEntryPoint, ushort* pTargetProfile, ushort** pArguments, uint argCount, DxcDefine* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult, ushort** ppDebugBlobName, IDxcBlob** ppDebugBlob)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcCompiler2*, IDxcBlob*, ushort*, ushort*, ushort*, ushort**, uint, DxcDefine*, uint, IDxcIncludeHandler*, IDxcOperationResult**, ushort**, IDxcBlob**, int>)(lpVtbl[6]))((IDxcCompiler2*)Unsafe.AsPointer(ref this), pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult, ppDebugBlobName, ppDebugBlob);
	}
}

