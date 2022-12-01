// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1ComputeInfo"]/*' />
/// <unmanaged>ID2D1ComputeInfo</unmanaged>
[Guid("5598b14b-9fd7-48b7-9bdb-8f0964eb38bc")]
[NativeTypeName("struct ID2D1ComputeInfo : ID2D1RenderInfo")]
[NativeInheritance("ID2D1RenderInfo")]
public unsafe partial struct ID2D1ComputeInfo : ID2D1ComputeInfo.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID2D1ComputeInfo
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x4B, 0xB1, 0x98, 0x55,
				0xD7, 0x9F,
				0xB7, 0x48,
				0x9B,
				0xDB,
				0x8F,
				0x09,
				0x64,
				0xEB,
				0x38,
				0xBC
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1ComputeInfo));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1ComputeInfo));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1ComputeInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, uint>)(lpVtbl[1]))((ID2D1ComputeInfo*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, uint>)(lpVtbl[2]))((ID2D1ComputeInfo*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1RenderInfo.SetInputDescription" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetInputDescription(uint inputIndex, InputDescription inputDescription)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, uint, InputDescription, int>)(lpVtbl[3]))((ID2D1ComputeInfo*)Unsafe.AsPointer(ref this), inputIndex, inputDescription);
	}

	/// <inheritdoc cref="ID2D1RenderInfo.SetOutputBuffer" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetOutputBuffer(BufferPrecision bufferPrecision, ChannelDepth channelDepth)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, BufferPrecision, ChannelDepth, int>)(lpVtbl[4]))((ID2D1ComputeInfo*)Unsafe.AsPointer(ref this), bufferPrecision, channelDepth);
	}

	/// <inheritdoc cref="ID2D1RenderInfo.SetCached" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public void SetCached(Bool32 isCached)
	{
		((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, Bool32, void>)(lpVtbl[5]))((ID2D1ComputeInfo*)Unsafe.AsPointer(ref this), isCached);
	}

	/// <inheritdoc cref="ID2D1RenderInfo.SetInstructionCountHint" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public void SetInstructionCountHint(uint instructionCount)
	{
		((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, uint, void>)(lpVtbl[6]))((ID2D1ComputeInfo*)Unsafe.AsPointer(ref this), instructionCount);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1ComputeInfo::SetComputeShaderConstantBuffer"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult SetComputeShaderConstantBuffer(byte* buffer, uint bufferCount)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, byte*, uint, int>)(lpVtbl[7]))((ID2D1ComputeInfo*)Unsafe.AsPointer(ref this), buffer, bufferCount);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1ComputeInfo::SetComputeShader"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult SetComputeShader(Guid* shaderId)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, Guid*, int>)(lpVtbl[8]))((ID2D1ComputeInfo*)Unsafe.AsPointer(ref this), shaderId);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1ComputeInfo::SetResourceTexture"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult SetResourceTexture(uint textureIndex, ID2D1ResourceTexture* resourceTexture)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, uint, ID2D1ResourceTexture*, int>)(lpVtbl[9]))((ID2D1ComputeInfo*)Unsafe.AsPointer(ref this), textureIndex, resourceTexture);
	}
	public interface Interface : ID2D1RenderInfo.Interface
	{
		[VtblIndex(7)]
		HResult SetComputeShaderConstantBuffer(byte* buffer, uint bufferCount);

		[VtblIndex(8)]
		HResult SetComputeShader(Guid* shaderId);

		[VtblIndex(9)]
		HResult SetResourceTexture(uint textureIndex, ID2D1ResourceTexture* resourceTexture);
	}
}

