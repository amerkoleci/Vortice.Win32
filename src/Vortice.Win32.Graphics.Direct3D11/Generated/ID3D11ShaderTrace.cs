// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderTrace"]/*' />
/// <unmanaged>ID3D11ShaderTrace</unmanaged>
[Guid("36b013e6-2811-4845-baa7-d623fe0df104")]
[NativeTypeName("struct ID3D11ShaderTrace : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D11ShaderTrace : ID3D11ShaderTrace.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID3D11ShaderTrace
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xE6, 0x13, 0xB0, 0x36,
				0x11, 0x28,
				0x45, 0x48,
				0xBA,
				0xA7,
				0xD6,
				0x23,
				0xFE,
				0x0D,
				0xF1,
				0x04
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11ShaderTrace));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderTrace*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderTrace*, uint>)(lpVtbl[1]))((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderTrace*, uint>)(lpVtbl[2]))((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderTrace::TraceReady"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult TraceReady(ulong* pTestCount)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderTrace*, ulong*, int>)(lpVtbl[3]))((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), pTestCount);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderTrace::ResetTrace"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void ResetTrace()
	{
		((delegate* unmanaged[MemberFunction]<ID3D11ShaderTrace*, void>)(lpVtbl[4]))((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderTrace::GetTraceStats"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetTraceStats(TraceStats* pTraceStats)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderTrace*, TraceStats*, int>)(lpVtbl[5]))((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), pTraceStats);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderTrace::PSSelectStamp"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult PSSelectStamp(uint stampIndex)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderTrace*, uint, int>)(lpVtbl[6]))((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), stampIndex);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderTrace::GetInitialRegisterContents"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetInitialRegisterContents(TraceRegister* pRegister, TraceValue* pValue)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderTrace*, TraceRegister*, TraceValue*, int>)(lpVtbl[7]))((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), pRegister, pValue);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderTrace::GetStep"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult GetStep(uint stepIndex, TraceStep* pTraceStep)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderTrace*, uint, TraceStep*, int>)(lpVtbl[8]))((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), stepIndex, pTraceStep);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderTrace::GetWrittenRegister"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetWrittenRegister(uint stepIndex, uint writtenRegisterIndex, TraceRegister* pRegister, TraceValue* pValue)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)(lpVtbl[9]))((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), stepIndex, writtenRegisterIndex, pRegister, pValue);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11ShaderTrace::GetReadRegister"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult GetReadRegister(uint stepIndex, uint readRegisterIndex, TraceRegister* pRegister, TraceValue* pValue)
	{
		return ((delegate* unmanaged[MemberFunction]<ID3D11ShaderTrace*, uint, uint, TraceRegister*, TraceValue*, int>)(lpVtbl[10]))((ID3D11ShaderTrace*)Unsafe.AsPointer(ref this), stepIndex, readRegisterIndex, pRegister, pValue);
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult TraceReady(ulong* pTestCount);

		[VtblIndex(4)]
		void ResetTrace();

		[VtblIndex(5)]
		HResult GetTraceStats(TraceStats* pTraceStats);

		[VtblIndex(6)]
		HResult PSSelectStamp(uint stampIndex);

		[VtblIndex(7)]
		HResult GetInitialRegisterContents(TraceRegister* pRegister, TraceValue* pValue);

		[VtblIndex(8)]
		HResult GetStep(uint stepIndex, TraceStep* pTraceStep);

		[VtblIndex(9)]
		HResult GetWrittenRegister(uint stepIndex, uint writtenRegisterIndex, TraceRegister* pRegister, TraceValue* pValue);

		[VtblIndex(10)]
		HResult GetReadRegister(uint stepIndex, uint readRegisterIndex, TraceRegister* pRegister, TraceValue* pValue);
	}
}

