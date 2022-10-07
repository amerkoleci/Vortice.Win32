// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="DWRITE_PANOSE"]/*' />
/// <unmanaged>DWRITE_PANOSE</unmanaged>
[StructLayout(LayoutKind.Explicit)]
public partial struct Panose
{
	/// <include file='../DirectWrite.xml' path='doc/member[@name="DWRITE_PANOSE::values"]/*' />
	[FieldOffset(0)]
	public unsafe fixed byte values[10];

	/// <include file='../DirectWrite.xml' path='doc/member[@name="DWRITE_PANOSE::familyKind"]/*' />
	[FieldOffset(0)]
	public byte familyKind;

	/// <include file='../DirectWrite.xml' path='doc/member[@name="DWRITE_PANOSE::text"]/*' />
	[FieldOffset(0)]
	public _text_e__Struct text;

	/// <include file='../DirectWrite.xml' path='doc/member[@name="DWRITE_PANOSE::script"]/*' />
	[FieldOffset(0)]
	public _script_e__Struct script;

	/// <include file='../DirectWrite.xml' path='doc/member[@name="DWRITE_PANOSE::decorative"]/*' />
	[FieldOffset(0)]
	public _decorative_e__Struct decorative;

	/// <include file='../DirectWrite.xml' path='doc/member[@name="DWRITE_PANOSE::symbol"]/*' />
	[FieldOffset(0)]
	public _symbol_e__Struct symbol;

	public partial struct _decorative_e__Struct
	{
		/// <include file='../DirectWrite.xml' path='doc/member[@name="_decorative_e__Struct::familyKind"]/*' />
		public byte familyKind;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_decorative_e__Struct::decorativeClass"]/*' />
		public byte decorativeClass;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_decorative_e__Struct::weight"]/*' />
		public byte weight;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_decorative_e__Struct::aspect"]/*' />
		public byte aspect;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_decorative_e__Struct::contrast"]/*' />
		public byte contrast;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_decorative_e__Struct::serifVariant"]/*' />
		public byte serifVariant;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_decorative_e__Struct::fill"]/*' />
		public byte fill;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_decorative_e__Struct::lining"]/*' />
		public byte lining;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_decorative_e__Struct::decorativeTopology"]/*' />
		public byte decorativeTopology;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_decorative_e__Struct::characterRange"]/*' />
		public byte characterRange;
	}
	public partial struct _text_e__Struct
	{
		/// <include file='../DirectWrite.xml' path='doc/member[@name="_text_e__Struct::familyKind"]/*' />
		public byte familyKind;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_text_e__Struct::serifStyle"]/*' />
		public byte serifStyle;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_text_e__Struct::weight"]/*' />
		public byte weight;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_text_e__Struct::proportion"]/*' />
		public byte proportion;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_text_e__Struct::contrast"]/*' />
		public byte contrast;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_text_e__Struct::strokeVariation"]/*' />
		public byte strokeVariation;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_text_e__Struct::armStyle"]/*' />
		public byte armStyle;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_text_e__Struct::letterform"]/*' />
		public byte letterform;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_text_e__Struct::midline"]/*' />
		public byte midline;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_text_e__Struct::xHeight"]/*' />
		public byte xHeight;
	}
	public partial struct _symbol_e__Struct
	{
		/// <include file='../DirectWrite.xml' path='doc/member[@name="_symbol_e__Struct::familyKind"]/*' />
		public byte familyKind;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_symbol_e__Struct::symbolKind"]/*' />
		public byte symbolKind;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_symbol_e__Struct::weight"]/*' />
		public byte weight;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_symbol_e__Struct::spacing"]/*' />
		public byte spacing;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_symbol_e__Struct::aspectRatioAndContrast"]/*' />
		public byte aspectRatioAndContrast;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_symbol_e__Struct::aspectRatio94"]/*' />
		public byte aspectRatio94;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_symbol_e__Struct::aspectRatio119"]/*' />
		public byte aspectRatio119;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_symbol_e__Struct::aspectRatio157"]/*' />
		public byte aspectRatio157;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_symbol_e__Struct::aspectRatio163"]/*' />
		public byte aspectRatio163;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_symbol_e__Struct::aspectRatio211"]/*' />
		public byte aspectRatio211;
	}
	public partial struct _script_e__Struct
	{
		/// <include file='../DirectWrite.xml' path='doc/member[@name="_script_e__Struct::familyKind"]/*' />
		public byte familyKind;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_script_e__Struct::toolKind"]/*' />
		public byte toolKind;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_script_e__Struct::weight"]/*' />
		public byte weight;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_script_e__Struct::spacing"]/*' />
		public byte spacing;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_script_e__Struct::aspectRatio"]/*' />
		public byte aspectRatio;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_script_e__Struct::contrast"]/*' />
		public byte contrast;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_script_e__Struct::scriptTopology"]/*' />
		public byte scriptTopology;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_script_e__Struct::scriptForm"]/*' />
		public byte scriptForm;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_script_e__Struct::finials"]/*' />
		public byte finials;

		/// <include file='../DirectWrite.xml' path='doc/member[@name="_script_e__Struct::xAscent"]/*' />
		public byte xAscent;
	}
}