// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

public static unsafe partial class Apis
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1CreateFactory"]/*' />
	[LibraryImport("d2d1.dll")]
	public static partial HResult D2D1CreateFactory(FactoryType factoryType, Guid* riid, FactoryOptions* pFactoryOptions, void** ppIFactory);

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1MakeRotateMatrix"]/*' />
	[LibraryImport("d2d1.dll")]
	public static partial void D2D1MakeRotateMatrix(float angle, Vector2 center, Matrix3x2* matrix);

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1MakeSkewMatrix"]/*' />
	[LibraryImport("d2d1.dll")]
	public static partial void D2D1MakeSkewMatrix(float angleX, float angleY, Vector2 center, Matrix3x2* matrix);

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1IsMatrixInvertible"]/*' />
	[LibraryImport("d2d1.dll")]
	public static partial Bool32 D2D1IsMatrixInvertible(Matrix3x2* matrix);

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1InvertMatrix"]/*' />
	[LibraryImport("d2d1.dll")]
	public static partial Bool32 D2D1InvertMatrix(Matrix3x2* matrix);

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1CreateDevice"]/*' />
	[LibraryImport("d2d1.dll")]
	public static partial HResult D2D1CreateDevice(Graphics.Dxgi.IDXGIDevice* dxgiDevice, CreationProperties* creationProperties, ID2D1Device** d2dDevice);

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1CreateDeviceContext"]/*' />
	[LibraryImport("d2d1.dll")]
	public static partial HResult D2D1CreateDeviceContext(Graphics.Dxgi.IDXGISurface* dxgiSurface, CreationProperties* creationProperties, ID2D1DeviceContext** d2dDeviceContext);

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1ConvertColorSpace"]/*' />
	[LibraryImport("d2d1.dll")]
	public static partial Color4 D2D1ConvertColorSpace(ColorSpace sourceColorSpace, ColorSpace destinationColorSpace, Color4* color);

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1SinCos"]/*' />
	[LibraryImport("d2d1.dll")]
	public static partial void D2D1SinCos(float angle, float* s, float* c);

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1Tan"]/*' />
	[LibraryImport("d2d1.dll")]
	public static partial float D2D1Tan(float angle);

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1Vec3Length"]/*' />
	[LibraryImport("d2d1.dll")]
	public static partial float D2D1Vec3Length(float x, float y, float z);

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1ComputeMaximumScaleFactor"]/*' />
	[LibraryImport("d2d1.dll")]
	public static partial float D2D1ComputeMaximumScaleFactor(Matrix3x2* matrix);

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1GetGradientMeshInteriorPointsFromCoonsPatch"]/*' />
	[LibraryImport("d2d1.dll")]
	public static partial void D2D1GetGradientMeshInteriorPointsFromCoonsPatch(Vector2* pPoint0, Vector2* pPoint1, Vector2* pPoint2, Vector2* pPoint3, Vector2* pPoint4, Vector2* pPoint5, Vector2* pPoint6, Vector2* pPoint7, Vector2* pPoint8, Vector2* pPoint9, Vector2* pPoint10, Vector2* pPoint11, Vector2* pTensorPoint11, Vector2* pTensorPoint12, Vector2* pTensorPoint21, Vector2* pTensorPoint22);
}
