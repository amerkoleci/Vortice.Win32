// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_STATE_OBJECT_FLAGS"]/*' />
/// <unmanaged>D3D12_STATE_OBJECT_FLAGS</unmanaged>
[Flags]
public enum StateObjectFlags : uint
{
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_STATE_OBJECT_FLAGS::D3D12_STATE_OBJECT_FLAG_NONE"]/*' />
	/// <unmanaged>D3D12_STATE_OBJECT_FLAG_NONE</unmanaged>
	None = 0,
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_STATE_OBJECT_FLAGS::D3D12_STATE_OBJECT_FLAG_ALLOW_LOCAL_DEPENDENCIES_ON_EXTERNAL_DEFINITIONS"]/*' />
	/// <unmanaged>D3D12_STATE_OBJECT_FLAG_ALLOW_LOCAL_DEPENDENCIES_ON_EXTERNAL_DEFINITIONS</unmanaged>
	AllowLocalDependenciesOnExternalDefinitions = 1,
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_STATE_OBJECT_FLAGS::D3D12_STATE_OBJECT_FLAG_ALLOW_EXTERNAL_DEPENDENCIES_ON_LOCAL_DEFINITIONS"]/*' />
	/// <unmanaged>D3D12_STATE_OBJECT_FLAG_ALLOW_EXTERNAL_DEPENDENCIES_ON_LOCAL_DEFINITIONS</unmanaged>
	AllowExternalDependenciesOnLocalDefinitions = 2,
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_STATE_OBJECT_FLAGS::D3D12_STATE_OBJECT_FLAG_ALLOW_STATE_OBJECT_ADDITIONS"]/*' />
	/// <unmanaged>D3D12_STATE_OBJECT_FLAG_ALLOW_STATE_OBJECT_ADDITIONS</unmanaged>
	AllowStateObjectAdditions = 4,
}