// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D.Dxc;

public static unsafe partial class Apis
{
	[DllImport("dxcompiler.dll", ExactSpelling = true)]
	public static extern HResult DxcCreateInstance(Guid* rclsid, Guid* riid, void** ppv);

	[DllImport("dxcompiler.dll", ExactSpelling = true)]
	public static extern HResult DxcCreateInstance2(Com.IMalloc* pMalloc, Guid* rclsid, Guid* riid, void** ppv);
}
