// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_DEVICE_REMOVED_EXTENDED_DATA"]/*' />
/// <unmanaged>D3D12_DEVICE_REMOVED_EXTENDED_DATA</unmanaged>
public partial struct DeviceRemovedExtendedData
{
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_DEVICE_REMOVED_EXTENDED_DATA::Flags"]/*' />
	public DredFlags Flags;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_DEVICE_REMOVED_EXTENDED_DATA::pHeadAutoBreadcrumbNode"]/*' />
	public unsafe AutoBreadcrumbNode* pHeadAutoBreadcrumbNode;
}