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

/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1ComputeTransform"]/*' />
/// <unmanaged>ID2D1ComputeTransform</unmanaged>
[Guid("0d85573c-01e3-4f7d-bfd9-0d60608bf3c3")]
[NativeTypeName("struct ID2D1ComputeTransform : ID2D1Transform")]
[NativeInheritance("ID2D1Transform")]
public unsafe partial struct ID2D1ComputeTransform
{
	public static ref readonly Guid IID_ID2D1ComputeTransform
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x3C, 0x57, 0x85, 0x0D,
				0xE3, 0x01,
				0x7D, 0x4F,
				0xBF,
				0xD9,
				0x0D,
				0x60,
				0x60,
				0x8B,
				0xF3,
				0xC3
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1ComputeTransform));

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
		return ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, uint>)(lpVtbl[3]))((ID2D1ComputeTransform*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1Transform.MapOutputRectToInputRects" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult MapOutputRectToInputRects(RawRect* outputRect, RawRect* inputRects, uint inputRectsCount)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, RawRect*, RawRect*, uint, int>)(lpVtbl[4]))((ID2D1ComputeTransform*)Unsafe.AsPointer(ref this), outputRect, inputRects, inputRectsCount);
	}

	/// <inheritdoc cref="ID2D1Transform.MapInputRectsToOutputRect" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult MapInputRectsToOutputRect(RawRect* inputRects, RawRect* inputOpaqueSubRects, uint inputRectCount, RawRect* outputRect, RawRect* outputOpaqueSubRect)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, RawRect*, RawRect*, uint, RawRect*, RawRect*, int>)(lpVtbl[5]))((ID2D1ComputeTransform*)Unsafe.AsPointer(ref this), inputRects, inputOpaqueSubRects, inputRectCount, outputRect, outputOpaqueSubRect);
	}

	/// <inheritdoc cref="ID2D1Transform.MapInvalidRect" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult MapInvalidRect(uint inputIndex, RawRect* invalidInputRect, RawRect* invalidOutputRect)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, uint, RawRect*, RawRect*, int>)(lpVtbl[6]))((ID2D1ComputeTransform*)Unsafe.AsPointer(ref this), inputIndex, invalidInputRect, invalidOutputRect);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1ComputeTransform::SetComputeInfo"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult SetComputeInfo(ID2D1ComputeInfo* computeInfo)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, ID2D1ComputeInfo*, int>)(lpVtbl[7]))((ID2D1ComputeTransform*)Unsafe.AsPointer(ref this), computeInfo);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1ComputeTransform::CalculateThreadgroups"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CalculateThreadgroups(RawRect* outputRect, uint* dimensionX, uint* dimensionY, uint* dimensionZ)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ComputeTransform*, RawRect*, uint*, uint*, uint*, int>)(lpVtbl[8]))((ID2D1ComputeTransform*)Unsafe.AsPointer(ref this), outputRect, dimensionX, dimensionY, dimensionZ);
	}
}

