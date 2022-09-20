// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------


#if !NET6_0_OR_GREATER
using MemoryMarshal = Win32.MemoryMarshal;
#endif

namespace Win32.Graphics.Direct2D;

/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1Transform"]/*' />
/// <unmanaged>ID2D1Transform</unmanaged>
[Guid("ef1a287d-342a-4f76-8fdb-da0d6ea9f92b")]
[NativeTypeName("struct ID2D1Transform : ID2D1TransformNode")]
[NativeInheritance("ID2D1TransformNode")]
public unsafe partial struct ID2D1Transform
{
	public static ref readonly Guid IID_ID2D1Transform
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x7D, 0x28, 0x1A, 0xEF,
				0x2A, 0x34,
				0x76, 0x4F,
				0x8F,
				0xDB,
				0xDA,
				0x0D,
				0x6E,
				0xA9,
				0xF9,
				0x2B
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1Transform));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IUnknown*, Guid*, void**, int>)(lpVtbl[0]))((IUnknown*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IUnknown*, uint>)(lpVtbl[1]))((IUnknown*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IUnknown*, uint>)(lpVtbl[2]))((IUnknown*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1TransformNode.GetInputCount" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public uint GetInputCount()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Transform*, uint>)(lpVtbl[3]))((ID2D1Transform*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1Transform::MapOutputRectToInputRects"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult MapOutputRectToInputRects(RawRect* outputRect, RawRect* inputRects, uint inputRectsCount)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Transform*, RawRect*, RawRect*, uint, int>)(lpVtbl[4]))((ID2D1Transform*)Unsafe.AsPointer(ref this), outputRect, inputRects, inputRectsCount);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1Transform::MapInputRectsToOutputRect"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult MapInputRectsToOutputRect(RawRect* inputRects, RawRect* inputOpaqueSubRects, uint inputRectCount, RawRect* outputRect, RawRect* outputOpaqueSubRect)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Transform*, RawRect*, RawRect*, uint, RawRect*, RawRect*, int>)(lpVtbl[5]))((ID2D1Transform*)Unsafe.AsPointer(ref this), inputRects, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRect);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1Transform::MapInvalidRect"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult MapInvalidRect(uint inputIndex, RawRect* invalidInputRect, RawRect* invalidOutputRect)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Transform*, uint, RawRect*, RawRect*, int>)(lpVtbl[6]))((ID2D1Transform*)Unsafe.AsPointer(ref this), inputIndex, invalidInputRect, invalidOutputRect);
	}
}

