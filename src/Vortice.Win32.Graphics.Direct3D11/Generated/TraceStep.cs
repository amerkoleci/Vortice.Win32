// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="D3D11_TRACE_STEP"]/*' />
/// <unmanaged>D3D11_TRACE_STEP</unmanaged>
public partial struct TraceStep
{
	/// <include file='../Direct3D11.xml' path='doc/member[@name="D3D11_TRACE_STEP::ID"]/*' />
	public uint ID;

	/// <include file='../Direct3D11.xml' path='doc/member[@name="D3D11_TRACE_STEP::InstructionActive"]/*' />
	public Bool32 InstructionActive;

	/// <include file='../Direct3D11.xml' path='doc/member[@name="D3D11_TRACE_STEP::NumRegistersWritten"]/*' />
	public byte NumRegistersWritten;

	/// <include file='../Direct3D11.xml' path='doc/member[@name="D3D11_TRACE_STEP::NumRegistersRead"]/*' />
	public byte NumRegistersRead;

	/// <include file='../Direct3D11.xml' path='doc/member[@name="D3D11_TRACE_STEP::MiscOperations"]/*' />
	public ushort MiscOperations;

	/// <include file='../Direct3D11.xml' path='doc/member[@name="D3D11_TRACE_STEP::OpcodeType"]/*' />
	public uint OpcodeType;

	/// <include file='../Direct3D11.xml' path='doc/member[@name="D3D11_TRACE_STEP::CurrentGlobalCycle"]/*' />
	public ulong CurrentGlobalCycle;
}