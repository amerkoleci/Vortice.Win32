// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES"]/*' />
/// <unmanaged>D3D12_GRAPHICS_STATES</unmanaged>
[Flags]
public enum GraphicsStates : uint
{
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES::D3D12_GRAPHICS_STATE_NONE"]/*' />
	/// <unmanaged>D3D12_GRAPHICS_STATE_NONE</unmanaged>
	None = 0,
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES::D3D12_GRAPHICS_STATE_IA_VERTEX_BUFFERS"]/*' />
	/// <unmanaged>D3D12_GRAPHICS_STATE_IA_VERTEX_BUFFERS</unmanaged>
	IAVertexBuffers = 1,
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES::D3D12_GRAPHICS_STATE_IA_INDEX_BUFFER"]/*' />
	/// <unmanaged>D3D12_GRAPHICS_STATE_IA_INDEX_BUFFER</unmanaged>
	IAIndexBuffer = 2,
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES::D3D12_GRAPHICS_STATE_IA_PRIMITIVE_TOPOLOGY"]/*' />
	/// <unmanaged>D3D12_GRAPHICS_STATE_IA_PRIMITIVE_TOPOLOGY</unmanaged>
	IAPrimitiveTopology = 4,
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES::D3D12_GRAPHICS_STATE_DESCRIPTOR_HEAP"]/*' />
	/// <unmanaged>D3D12_GRAPHICS_STATE_DESCRIPTOR_HEAP</unmanaged>
	DescriptorHeap = 8,
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES::D3D12_GRAPHICS_STATE_GRAPHICS_ROOT_SIGNATURE"]/*' />
	/// <unmanaged>D3D12_GRAPHICS_STATE_GRAPHICS_ROOT_SIGNATURE</unmanaged>
	GraphicsRootSignature = 16,
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES::D3D12_GRAPHICS_STATE_COMPUTE_ROOT_SIGNATURE"]/*' />
	/// <unmanaged>D3D12_GRAPHICS_STATE_COMPUTE_ROOT_SIGNATURE</unmanaged>
	ComputeRootSignature = 32,
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES::D3D12_GRAPHICS_STATE_RS_VIEWPORTS"]/*' />
	/// <unmanaged>D3D12_GRAPHICS_STATE_RS_VIEWPORTS</unmanaged>
	RSViewports = 64,
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES::D3D12_GRAPHICS_STATE_RS_SCISSOR_RECTS"]/*' />
	/// <unmanaged>D3D12_GRAPHICS_STATE_RS_SCISSOR_RECTS</unmanaged>
	RSScissorRects = 128,
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES::D3D12_GRAPHICS_STATE_PREDICATION"]/*' />
	/// <unmanaged>D3D12_GRAPHICS_STATE_PREDICATION</unmanaged>
	Predication = 256,
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES::D3D12_GRAPHICS_STATE_OM_RENDER_TARGETS"]/*' />
	/// <unmanaged>D3D12_GRAPHICS_STATE_OM_RENDER_TARGETS</unmanaged>
	OMRenderTargets = 512,
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES::D3D12_GRAPHICS_STATE_OM_STENCIL_REF"]/*' />
	/// <unmanaged>D3D12_GRAPHICS_STATE_OM_STENCIL_REF</unmanaged>
	OMStencilRef = 1024,
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES::D3D12_GRAPHICS_STATE_OM_BLEND_FACTOR"]/*' />
	/// <unmanaged>D3D12_GRAPHICS_STATE_OM_BLEND_FACTOR</unmanaged>
	OMBlendFactor = 2048,
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES::D3D12_GRAPHICS_STATE_PIPELINE_STATE"]/*' />
	/// <unmanaged>D3D12_GRAPHICS_STATE_PIPELINE_STATE</unmanaged>
	PipelineState = 4096,
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES::D3D12_GRAPHICS_STATE_SO_TARGETS"]/*' />
	/// <unmanaged>D3D12_GRAPHICS_STATE_SO_TARGETS</unmanaged>
	SOTargets = 8192,
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES::D3D12_GRAPHICS_STATE_OM_DEPTH_BOUNDS"]/*' />
	/// <unmanaged>D3D12_GRAPHICS_STATE_OM_DEPTH_BOUNDS</unmanaged>
	OMDepthBounds = 16384,
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES::D3D12_GRAPHICS_STATE_SAMPLE_POSITIONS"]/*' />
	/// <unmanaged>D3D12_GRAPHICS_STATE_SAMPLE_POSITIONS</unmanaged>
	SamplePositions = 32768,
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_GRAPHICS_STATES::D3D12_GRAPHICS_STATE_VIEW_INSTANCE_MASK"]/*' />
	/// <unmanaged>D3D12_GRAPHICS_STATE_VIEW_INSTANCE_MASK</unmanaged>
	ViewInstanceMask = 65536,
}