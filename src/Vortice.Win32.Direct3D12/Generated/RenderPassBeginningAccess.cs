// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_RENDER_PASS_BEGINNING_ACCESS"]/*' />
/// <unmanaged>D3D12_RENDER_PASS_BEGINNING_ACCESS</unmanaged>
public partial struct RenderPassBeginningAccess
{
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_RENDER_PASS_BEGINNING_ACCESS::Type"]/*' />
	public RenderPassBeginningAccessType Type;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_RENDER_PASS_BEGINNING_ACCESS::Anonymous"]/*' />
	public _Anonymous_e__Union Anonymous;

	[UnscopedRef]
	public ref RenderPassBeginningAccessClearParameters Clear
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.Clear;
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public partial struct _Anonymous_e__Union
	{
		/// <include file='../Direct3D12.xml' path='doc/member[@name="_Anonymous_e__Union::Clear"]/*' />
		[FieldOffset(0)]
		public RenderPassBeginningAccessClearParameters Clear;
	}
}