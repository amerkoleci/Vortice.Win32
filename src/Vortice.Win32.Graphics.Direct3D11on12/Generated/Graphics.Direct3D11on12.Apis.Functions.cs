// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11on12;

public static unsafe partial class Apis
{
	/// <include file='../../Vortice.Win32.Graphics.Direct3D11/Direct3D11.xml' path='doc/member[@name="D3D11On12CreateDevice"]/*' />
	[LibraryImport("d3d11.dll")]
	public static partial HResult D3D11On12CreateDevice(IUnknown* pDevice, Graphics.Direct3D11.CreateDeviceFlags Flags, Graphics.Direct3D.FeatureLevel* pFeatureLevels, uint FeatureLevels, IUnknown** ppCommandQueues, uint NumQueues, uint NodeMask, Graphics.Direct3D11.ID3D11Device** ppDevice, Graphics.Direct3D11.ID3D11DeviceContext** ppImmediateContext, Graphics.Direct3D.FeatureLevel* pChosenFeatureLevel);
}
