// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Imaging;

/// <include file='../Imaging.xml' path='doc/member[@name="WICRawToneCurve"]/*' />
/// <unmanaged>WICRawToneCurve</unmanaged>
public partial struct WICRawToneCurve
{
	/// <include file='../Imaging.xml' path='doc/member[@name="WICRawToneCurve::cPoints"]/*' />
	public uint cPoints;

	/// <include file='../Imaging.xml' path='doc/member[@name="WICRawToneCurve::aPoints"]/*' />
	public aPoints__FixedBuffer aPoints;

	public unsafe struct aPoints__FixedBuffer
	{
		public WICRawToneCurvePoint e0;

		[UnscopedRef]
		public ref WICRawToneCurvePoint this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return ref AsSpan()[index];
			}
		}

		[UnscopedRef]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Span<WICRawToneCurvePoint> AsSpan()
		{
			return MemoryMarshal.CreateSpan(ref e0, 1);
		}
	}
}