// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------


#if !NET6_0_OR_GREATER
using MemoryMarshal = Win32.MemoryMarshal;
#endif

namespace Win32.Graphics;

public static partial class Apis
{
}

#region Enums
/// <include file='../.xml' path='doc/member[@name="D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE"]/*' />
/// <unmanaged>D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE</unmanaged>
public enum AffineTransform2DInterpolationMode : uint
{
	/// <include file='../.xml' path='doc/member[@name="D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE::D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE_NEAREST_NEIGHBOR"]/*' />
	/// <unmanaged>D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE_NEAREST_NEIGHBOR</unmanaged>
	NearestNeighbor = 0,
	/// <include file='../.xml' path='doc/member[@name="D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE::D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE_LINEAR"]/*' />
	/// <unmanaged>D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE_LINEAR</unmanaged>
	Linear = 1,
	/// <include file='../.xml' path='doc/member[@name="D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE::D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE_CUBIC"]/*' />
	/// <unmanaged>D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE_CUBIC</unmanaged>
	Cubic = 2,
	/// <include file='../.xml' path='doc/member[@name="D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE::D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE_MULTI_SAMPLE_LINEAR"]/*' />
	/// <unmanaged>D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE_MULTI_SAMPLE_LINEAR</unmanaged>
	MultiSampleLinear = 3,
	/// <include file='../.xml' path='doc/member[@name="D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE::D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE_ANISOTROPIC"]/*' />
	/// <unmanaged>D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE_ANISOTROPIC</unmanaged>
	Anisotropic = 4,
	/// <include file='../.xml' path='doc/member[@name="D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE::D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE_HIGH_QUALITY_CUBIC"]/*' />
	/// <unmanaged>D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE_HIGH_QUALITY_CUBIC</unmanaged>
	HighQualityCubic = 5,
}

#endregion Enums

