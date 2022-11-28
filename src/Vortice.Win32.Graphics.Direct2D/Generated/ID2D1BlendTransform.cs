// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1BlendTransform"]/*' />
/// <unmanaged>ID2D1BlendTransform</unmanaged>
[Guid("63ac0b32-ba44-450f-8806-7f4ca1ff2f1b")]
[NativeTypeName("struct ID2D1BlendTransform : ID2D1ConcreteTransform")]
[NativeInheritance("ID2D1ConcreteTransform")]
public unsafe partial struct ID2D1BlendTransform : INativeGuid
{
	public static ref readonly Guid IID_ID2D1BlendTransform
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x32, 0x0B, 0xAC, 0x63,
				0x44, 0xBA,
				0x0F, 0x45,
				0x88,
				0x06,
				0x7F,
				0x4C,
				0xA1,
				0xFF,
				0x2F,
				0x1B
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1BlendTransform));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1BlendTransform));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BlendTransform*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1BlendTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BlendTransform*, uint>)(lpVtbl[1]))((ID2D1BlendTransform*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BlendTransform*, uint>)(lpVtbl[2]))((ID2D1BlendTransform*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1TransformNode.GetInputCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public uint GetInputCount()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BlendTransform*, uint>)(lpVtbl[3]))((ID2D1BlendTransform*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1ConcreteTransform.SetOutputBuffer" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetOutputBuffer(BufferPrecision bufferPrecision, ChannelDepth channelDepth)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1BlendTransform*, BufferPrecision, ChannelDepth, int>)(lpVtbl[4]))((ID2D1BlendTransform*)Unsafe.AsPointer(ref this), bufferPrecision, channelDepth);
	}

	/// <inheritdoc cref="ID2D1ConcreteTransform.SetCached" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public void SetCached(Bool32 isCached)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BlendTransform*, Bool32, void>)(lpVtbl[5]))((ID2D1BlendTransform*)Unsafe.AsPointer(ref this), isCached);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1BlendTransform::SetDescription"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public void SetDescription(BlendDescription* description)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BlendTransform*, BlendDescription*, void>)(lpVtbl[6]))((ID2D1BlendTransform*)Unsafe.AsPointer(ref this), description);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1BlendTransform::GetDescription"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public void GetDescription(BlendDescription* description)
	{
		((delegate* unmanaged[Stdcall]<ID2D1BlendTransform*, BlendDescription*, void>)(lpVtbl[7]))((ID2D1BlendTransform*)Unsafe.AsPointer(ref this), description);
	}
}

