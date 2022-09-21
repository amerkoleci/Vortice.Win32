// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteTextAnalysisSink"]/*' />
/// <unmanaged>IDWriteTextAnalysisSink</unmanaged>
[Guid("5810cd44-0ca0-4701-b3fa-bec5182ae4f6")]
[NativeTypeName("struct IDWriteTextAnalysisSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteTextAnalysisSink
{
	public static ref readonly Guid IID_IDWriteTextAnalysisSink
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x44, 0xCD, 0x10, 0x58,
				0xA0, 0x0C,
				0x01, 0x47,
				0xB3,
				0xFA,
				0xBE,
				0xC5,
				0x18,
				0x2A,
				0xE4,
				0xF6
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteTextAnalysisSink));

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

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteTextAnalysisSink::SetScriptAnalysis"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetScriptAnalysis(uint textPosition, uint textLength, ScriptAnalysis* scriptAnalysis)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, uint, uint, ScriptAnalysis*, int>)(lpVtbl[3]))((IDWriteTextAnalysisSink*)Unsafe.AsPointer(ref this), textPosition, textLength, scriptAnalysis);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteTextAnalysisSink::SetLineBreakpoints"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetLineBreakpoints(uint textPosition, uint textLength, LineBreakpoint* lineBreakpoints)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, uint, uint, LineBreakpoint*, int>)(lpVtbl[4]))((IDWriteTextAnalysisSink*)Unsafe.AsPointer(ref this), textPosition, textLength, lineBreakpoints);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteTextAnalysisSink::SetBidiLevel"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetBidiLevel(uint textPosition, uint textLength, byte explicitLevel, byte resolvedLevel)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, uint, uint, byte, byte, int>)(lpVtbl[5]))((IDWriteTextAnalysisSink*)Unsafe.AsPointer(ref this), textPosition, textLength, explicitLevel, resolvedLevel);
	}

	/// <include file='../../DirectWrite.xml' path='doc/member[@name="IDWriteTextAnalysisSink::SetNumberSubstitution"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetNumberSubstitution(uint textPosition, uint textLength, IDWriteNumberSubstitution* numberSubstitution)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, uint, uint, IDWriteNumberSubstitution*, int>)(lpVtbl[6]))((IDWriteTextAnalysisSink*)Unsafe.AsPointer(ref this), textPosition, textLength, numberSubstitution);
	}
}

