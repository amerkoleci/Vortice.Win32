// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderInfo"]/*' />
/// <unmanaged>ID2D1RenderInfo</unmanaged>
[Guid("519ae1bd-d19a-420d-b849-364f594776b7")]
[NativeTypeName("struct ID2D1RenderInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID2D1RenderInfo : ID2D1RenderInfo.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID2D1RenderInfo
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xBD, 0xE1, 0x9A, 0x51,
				0x9A, 0xD1,
				0x0D, 0x42,
				0xB8,
				0x49,
				0x36,
				0x4F,
				0x59,
				0x47,
				0x76,
				0xB7
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1RenderInfo));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1RenderInfo));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1RenderInfo*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1RenderInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1RenderInfo*, uint>)(lpVtbl[1]))((ID2D1RenderInfo*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1RenderInfo*, uint>)(lpVtbl[2]))((ID2D1RenderInfo*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderInfo::SetInputDescription"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetInputDescription(uint inputIndex, InputDescription inputDescription)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1RenderInfo*, uint, InputDescription, int>)(lpVtbl[3]))((ID2D1RenderInfo*)Unsafe.AsPointer(ref this), inputIndex, inputDescription);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderInfo::SetOutputBuffer"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetOutputBuffer(BufferPrecision bufferPrecision, ChannelDepth channelDepth)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1RenderInfo*, BufferPrecision, ChannelDepth, int>)(lpVtbl[4]))((ID2D1RenderInfo*)Unsafe.AsPointer(ref this), bufferPrecision, channelDepth);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderInfo::SetCached"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public void SetCached(Bool32 isCached)
	{
		((delegate* unmanaged[Stdcall]<ID2D1RenderInfo*, Bool32, void>)(lpVtbl[5]))((ID2D1RenderInfo*)Unsafe.AsPointer(ref this), isCached);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1RenderInfo::SetInstructionCountHint"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public void SetInstructionCountHint(uint instructionCount)
	{
		((delegate* unmanaged[Stdcall]<ID2D1RenderInfo*, uint, void>)(lpVtbl[6]))((ID2D1RenderInfo*)Unsafe.AsPointer(ref this), instructionCount);
	}
	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult SetInputDescription(uint inputIndex, InputDescription inputDescription);

		[VtblIndex(4)]
		HResult SetOutputBuffer(BufferPrecision bufferPrecision, ChannelDepth channelDepth);

		[VtblIndex(5)]
		void SetCached(Bool32 isCached);

		[VtblIndex(6)]
		void SetInstructionCountHint(uint instructionCount);
	}
}

