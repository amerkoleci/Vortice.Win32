// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1ConcreteTransform"]/*' />
/// <unmanaged>ID2D1ConcreteTransform</unmanaged>
[Guid("1a799d8a-69f7-4e4c-9fed-437ccc6684cc")]
[NativeTypeName("struct ID2D1ConcreteTransform : ID2D1TransformNode")]
[NativeInheritance("ID2D1TransformNode")]
public unsafe partial struct ID2D1ConcreteTransform : ID2D1ConcreteTransform.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID2D1ConcreteTransform
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x8A, 0x9D, 0x79, 0x1A,
				0xF7, 0x69,
				0x4C, 0x4E,
				0x9F,
				0xED,
				0x43,
				0x7C,
				0xCC,
				0x66,
				0x84,
				0xCC
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1ConcreteTransform));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1ConcreteTransform));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ConcreteTransform*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1ConcreteTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ConcreteTransform*, uint>)(lpVtbl[1]))((ID2D1ConcreteTransform*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ConcreteTransform*, uint>)(lpVtbl[2]))((ID2D1ConcreteTransform*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1TransformNode.GetInputCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public uint GetInputCount()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ConcreteTransform*, uint>)(lpVtbl[3]))((ID2D1ConcreteTransform*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1ConcreteTransform::SetOutputBuffer"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetOutputBuffer(BufferPrecision bufferPrecision, ChannelDepth channelDepth)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ConcreteTransform*, BufferPrecision, ChannelDepth, int>)(lpVtbl[4]))((ID2D1ConcreteTransform*)Unsafe.AsPointer(ref this), bufferPrecision, channelDepth);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1ConcreteTransform::SetCached"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public void SetCached(Bool32 isCached)
	{
		((delegate* unmanaged[Stdcall]<ID2D1ConcreteTransform*, Bool32, void>)(lpVtbl[5]))((ID2D1ConcreteTransform*)Unsafe.AsPointer(ref this), isCached);
	}
	public interface Interface : ID2D1TransformNode.Interface
	{
		[VtblIndex(4)]
		HResult SetOutputBuffer(BufferPrecision bufferPrecision, ChannelDepth channelDepth);

		[VtblIndex(5)]
		void SetCached(Bool32 isCached);
	}
}

