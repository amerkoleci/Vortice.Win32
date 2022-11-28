// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D.Dxc;

/// <unmanaged>IDxcUtils</unmanaged>
[Guid("4605c4cb-2019-492a-ada4-65f20bb7d67f")]
[NativeTypeName("struct IDxcUtils : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxcUtils : INativeGuid
{
	public static ref readonly Guid IID_IDxcUtils
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xCB, 0xC4, 0x05, 0x46,
				0x19, 0x20,
				0x2A, 0x49,
				0xAD,
				0xA4,
				0x65,
				0xF2,
				0x0B,
				0xB7,
				0xD6,
				0x7F
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcUtils));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcUtils));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcUtils*, Guid*, void**, int>)(lpVtbl[0]))((IDxcUtils*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDxcUtils*, uint>)(lpVtbl[1]))((IDxcUtils*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDxcUtils*, uint>)(lpVtbl[2]))((IDxcUtils*)Unsafe.AsPointer(ref this));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult CreateBlobFromBlob(IDxcBlob* pBlob, uint offset, uint length, IDxcBlob** ppResult)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, uint, uint, IDxcBlob**, int>)(lpVtbl[3]))((IDxcUtils*)Unsafe.AsPointer(ref this), pBlob, offset, length, ppResult);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult CreateBlobFromPinned(void* pData, uint size, DxcCp codePage, IDxcBlobEncoding** pBlobEncoding)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, uint, DxcCp, IDxcBlobEncoding**, int>)(lpVtbl[4]))((IDxcUtils*)Unsafe.AsPointer(ref this), pData, size, codePage, pBlobEncoding);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult MoveToBlob(void* pData, Com.IMalloc* pIMalloc, uint size, DxcCp codePage, IDxcBlobEncoding** pBlobEncoding)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, Com.IMalloc*, uint, DxcCp, IDxcBlobEncoding**, int>)(lpVtbl[5]))((IDxcUtils*)Unsafe.AsPointer(ref this), pData, pIMalloc, size, codePage, pBlobEncoding);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult CreateBlob(void* pData, uint size, DxcCp codePage, IDxcBlobEncoding** pBlobEncoding)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, uint, DxcCp, IDxcBlobEncoding**, int>)(lpVtbl[6]))((IDxcUtils*)Unsafe.AsPointer(ref this), pData, size, codePage, pBlobEncoding);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult LoadFile(ushort* pFileName, DxcCp* pCodePage, IDxcBlobEncoding** pBlobEncoding)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcUtils*, ushort*, DxcCp*, IDxcBlobEncoding**, int>)(lpVtbl[7]))((IDxcUtils*)Unsafe.AsPointer(ref this), pFileName, pCodePage, pBlobEncoding);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateReadOnlyStreamFromBlob(IDxcBlob* pBlob, Com.IStream** ppStream)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, Com.IStream**, int>)(lpVtbl[8]))((IDxcUtils*)Unsafe.AsPointer(ref this), pBlob, ppStream);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult CreateDefaultIncludeHandler(IDxcIncludeHandler** ppResult)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcIncludeHandler**, int>)(lpVtbl[9]))((IDxcUtils*)Unsafe.AsPointer(ref this), ppResult);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult GetBlobAsUtf8(IDxcBlob* pBlob, IDxcBlobUtf8** pBlobEncoding)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlobUtf8**, int>)(lpVtbl[10]))((IDxcUtils*)Unsafe.AsPointer(ref this), pBlob, pBlobEncoding);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetBlobAsUtf16(IDxcBlob* pBlob, IDxcBlobUtf16** pBlobEncoding)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlobUtf16**, int>)(lpVtbl[11]))((IDxcUtils*)Unsafe.AsPointer(ref this), pBlob, pBlobEncoding);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult GetDxilContainerPart(DxcBuffer* pShader, uint DxcPart, void** ppPartData, uint* pPartSizeInBytes)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcUtils*, DxcBuffer*, uint, void**, uint*, int>)(lpVtbl[12]))((IDxcUtils*)Unsafe.AsPointer(ref this), pShader, DxcPart, ppPartData, pPartSizeInBytes);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult CreateReflection(DxcBuffer* pData, Guid* iid, void** ppvReflection)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcUtils*, DxcBuffer*, Guid*, void**, int>)(lpVtbl[13]))((IDxcUtils*)Unsafe.AsPointer(ref this), pData, iid, ppvReflection);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult BuildArguments(ushort* pSourceName, ushort* pEntryPoint, ushort* pTargetProfile, ushort** pArguments, uint argCount, DxcDefine* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcUtils*, ushort*, ushort*, ushort*, ushort**, uint, DxcDefine*, uint, IDxcCompilerArgs**, int>)(lpVtbl[14]))((IDxcUtils*)Unsafe.AsPointer(ref this), pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult GetPDBContents(IDxcBlob* pPDBBlob, IDxcBlob** ppHash, IDxcBlob** ppContainer)
	{
		return ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlob**, IDxcBlob**, int>)(lpVtbl[15]))((IDxcUtils*)Unsafe.AsPointer(ref this), pPDBBlob, ppHash, ppContainer);
	}
}

