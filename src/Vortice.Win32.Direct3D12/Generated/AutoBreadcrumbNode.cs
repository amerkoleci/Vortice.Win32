// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D12;

/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE"]/*' />
/// <unmanaged>D3D12_AUTO_BREADCRUMB_NODE</unmanaged>
public partial struct AutoBreadcrumbNode
{
	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE::pCommandListDebugNameA"]/*' />
	public unsafe byte* pCommandListDebugNameA;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE::pCommandListDebugNameW"]/*' />
	public unsafe ushort* pCommandListDebugNameW;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE::pCommandQueueDebugNameA"]/*' />
	public unsafe byte* pCommandQueueDebugNameA;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE::pCommandQueueDebugNameW"]/*' />
	public unsafe ushort* pCommandQueueDebugNameW;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE::pCommandList"]/*' />
	public unsafe ID3D12GraphicsCommandList* pCommandList;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE::pCommandQueue"]/*' />
	public unsafe ID3D12CommandQueue* pCommandQueue;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE::BreadcrumbCount"]/*' />
	public uint BreadcrumbCount;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE::pLastBreadcrumbValue"]/*' />
	public unsafe uint* pLastBreadcrumbValue;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE::pCommandHistory"]/*' />
	public unsafe AutoBreadcrumbOperation* pCommandHistory;

	/// <include file='../Direct3D12.xml' path='doc/member[@name="D3D12_AUTO_BREADCRUMB_NODE::pNext"]/*' />
	public unsafe AutoBreadcrumbNode* pNext;
}