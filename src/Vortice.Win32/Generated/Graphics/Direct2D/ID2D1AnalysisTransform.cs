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

/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1AnalysisTransform"]/*' />
/// <unmanaged>ID2D1AnalysisTransform</unmanaged>
[Guid("0359dc30-95e6-4568-9055-27720d130e93")]
[NativeTypeName("struct ID2D1AnalysisTransform : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID2D1AnalysisTransform
{
	public static ref readonly Guid IID_ID2D1AnalysisTransform
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x30, 0xDC, 0x59, 0x03,
				0xE6, 0x95,
				0x68, 0x45,
				0x90,
				0x55,
				0x27,
				0x72,
				0x0D,
				0x13,
				0x0E,
				0x93
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1AnalysisTransform));

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

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1AnalysisTransform::ProcessAnalysisResults"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult ProcessAnalysisResults(byte* analysisData, uint analysisDataCount)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1AnalysisTransform*, byte*, uint, int>)(lpVtbl[3]))((ID2D1AnalysisTransform*)Unsafe.AsPointer(ref this), analysisData, analysisDataCount);
	}
}
