// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_RESOURCE_DESC1"]/*' />
/// <unmanaged>D3D12_RESOURCE_DESC1</unmanaged>
public partial struct ResourceDescription1
{
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_RESOURCE_DESC1::Dimension"]/*' />
	public ResourceDimension Dimension;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_RESOURCE_DESC1::Alignment"]/*' />
	public ulong Alignment;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_RESOURCE_DESC1::Width"]/*' />
	public ulong Width;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_RESOURCE_DESC1::Height"]/*' />
	public uint Height;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_RESOURCE_DESC1::DepthOrArraySize"]/*' />
	public ushort DepthOrArraySize;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_RESOURCE_DESC1::MipLevels"]/*' />
	public ushort MipLevels;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_RESOURCE_DESC1::Format"]/*' />
	public Graphics.Dxgi.Common.Format Format;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_RESOURCE_DESC1::SampleDesc"]/*' />
	public Graphics.Dxgi.Common.SampleDescription SampleDesc;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_RESOURCE_DESC1::Layout"]/*' />
	public TextureLayout Layout;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_RESOURCE_DESC1::Flags"]/*' />
	public ResourceFlags Flags;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_RESOURCE_DESC1::SamplerFeedbackMipRegion"]/*' />
	public MipRegion SamplerFeedbackMipRegion;
}