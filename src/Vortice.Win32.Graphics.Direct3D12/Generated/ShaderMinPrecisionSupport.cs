// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_SHADER_MIN_PRECISION_SUPPORT"]/*' />
/// <unmanaged>D3D12_SHADER_MIN_PRECISION_SUPPORT</unmanaged>
[Flags]
public enum ShaderMinPrecisionSupport : uint
{
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_SHADER_MIN_PRECISION_SUPPORT::D3D12_SHADER_MIN_PRECISION_SUPPORT_NONE"]/*' />
	/// <unmanaged>D3D12_SHADER_MIN_PRECISION_SUPPORT_NONE</unmanaged>
	None = 0,
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_SHADER_MIN_PRECISION_SUPPORT::D3D12_SHADER_MIN_PRECISION_SUPPORT_10_BIT"]/*' />
	/// <unmanaged>D3D12_SHADER_MIN_PRECISION_SUPPORT_10_BIT</unmanaged>
	P10Bit = 1,
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_SHADER_MIN_PRECISION_SUPPORT::D3D12_SHADER_MIN_PRECISION_SUPPORT_16_BIT"]/*' />
	/// <unmanaged>D3D12_SHADER_MIN_PRECISION_SUPPORT_16_BIT</unmanaged>
	P16Bit = 2,
}