// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="DWRITE_GLYPH_RUN"]/*' />
/// <unmanaged>DWRITE_GLYPH_RUN</unmanaged>
public partial struct GlyphRun
{
	/// <include file='../DirectWrite.xml' path='doc/member[@name="DWRITE_GLYPH_RUN::fontFace"]/*' />
	public unsafe IDWriteFontFace* fontFace;

	/// <include file='../DirectWrite.xml' path='doc/member[@name="DWRITE_GLYPH_RUN::fontEmSize"]/*' />
	public float fontEmSize;

	/// <include file='../DirectWrite.xml' path='doc/member[@name="DWRITE_GLYPH_RUN::glyphCount"]/*' />
	public uint glyphCount;

	/// <include file='../DirectWrite.xml' path='doc/member[@name="DWRITE_GLYPH_RUN::glyphIndices"]/*' />
	public unsafe ushort* glyphIndices;

	/// <include file='../DirectWrite.xml' path='doc/member[@name="DWRITE_GLYPH_RUN::glyphAdvances"]/*' />
	public unsafe float* glyphAdvances;

	/// <include file='../DirectWrite.xml' path='doc/member[@name="DWRITE_GLYPH_RUN::glyphOffsets"]/*' />
	public unsafe GlyphOffset* glyphOffsets;

	/// <include file='../DirectWrite.xml' path='doc/member[@name="DWRITE_GLYPH_RUN::isSideways"]/*' />
	public Bool32 isSideways;

	/// <include file='../DirectWrite.xml' path='doc/member[@name="DWRITE_GLYPH_RUN::bidiLevel"]/*' />
	public uint bidiLevel;
}