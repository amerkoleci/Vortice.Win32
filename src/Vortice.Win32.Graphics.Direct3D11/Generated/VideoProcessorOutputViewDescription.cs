// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC"]/*' />
/// <unmanaged>D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC</unmanaged>
public partial struct VideoProcessorOutputViewDescription
{
	/// <include file='../Direct3D11.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC::ViewDimension"]/*' />
	public VpovDimension ViewDimension;

	/// <include file='../Direct3D11.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC::Anonymous"]/*' />
	public _Anonymous_e__Union Anonymous;

	[UnscopedRef]
	public ref Texture2DVpov Texture2D
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.Texture2D;
		}
	}

	[UnscopedRef]
	public ref Texture2DArrayVpov Texture2DArray
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return ref Anonymous.Texture2DArray;
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public partial struct _Anonymous_e__Union
	{
		/// <include file='../Direct3D11.xml' path='doc/member[@name="_Anonymous_e__Union::Texture2D"]/*' />
		[FieldOffset(0)]
		public Texture2DVpov Texture2D;

		/// <include file='../Direct3D11.xml' path='doc/member[@name="_Anonymous_e__Union::Texture2DArray"]/*' />
		[FieldOffset(0)]
		public Texture2DArrayVpov Texture2DArray;
	}
}