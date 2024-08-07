// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D.Fxc;

public static unsafe partial class Apis
{
	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DReadFileToBlob"]/*' />
	[LibraryImport("D3DCOMPILER_47.dll")]
	public static partial HResult D3DReadFileToBlob(char* pFileName, Graphics.Direct3D.ID3DBlob** ppContents);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DWriteBlobToFile"]/*' />
	[LibraryImport("D3DCOMPILER_47.dll")]
	public static partial HResult D3DWriteBlobToFile(Graphics.Direct3D.ID3DBlob* pBlob, char* pFileName, Bool32 bOverwrite);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DCompile"]/*' />
	[LibraryImport("D3DCOMPILER_47.dll")]
	public static partial HResult D3DCompile(void* pSrcData, nuint SrcDataSize, byte* pSourceName, Graphics.Direct3D.ShaderMacro* pDefines, Graphics.Direct3D.ID3DInclude* pInclude, byte* pEntrypoint, byte* pTarget, CompileFlags Flags1, uint Flags2, Graphics.Direct3D.ID3DBlob** ppCode, Graphics.Direct3D.ID3DBlob** ppErrorMsgs);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DCompile2"]/*' />
	[LibraryImport("D3DCOMPILER_47.dll")]
	public static partial HResult D3DCompile2(void* pSrcData, nuint SrcDataSize, byte* pSourceName, Graphics.Direct3D.ShaderMacro* pDefines, Graphics.Direct3D.ID3DInclude* pInclude, byte* pEntrypoint, byte* pTarget, CompileFlags Flags1, uint Flags2, uint SecondaryDataFlags, void* pSecondaryData, nuint SecondaryDataSize, Graphics.Direct3D.ID3DBlob** ppCode, Graphics.Direct3D.ID3DBlob** ppErrorMsgs);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DCompileFromFile"]/*' />
	[LibraryImport("D3DCOMPILER_47.dll")]
	public static partial HResult D3DCompileFromFile(char* pFileName, Graphics.Direct3D.ShaderMacro* pDefines, Graphics.Direct3D.ID3DInclude* pInclude, byte* pEntrypoint, byte* pTarget, CompileFlags Flags1, uint Flags2, Graphics.Direct3D.ID3DBlob** ppCode, Graphics.Direct3D.ID3DBlob** ppErrorMsgs);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DPreprocess"]/*' />
	[LibraryImport("D3DCOMPILER_47.dll")]
	public static partial HResult D3DPreprocess(void* pSrcData, nuint SrcDataSize, byte* pSourceName, Graphics.Direct3D.ShaderMacro* pDefines, Graphics.Direct3D.ID3DInclude* pInclude, Graphics.Direct3D.ID3DBlob** ppCodeText, Graphics.Direct3D.ID3DBlob** ppErrorMsgs);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DGetDebugInfo"]/*' />
	[LibraryImport("D3DCOMPILER_47.dll")]
	public static partial HResult D3DGetDebugInfo(void* pSrcData, nuint SrcDataSize, Graphics.Direct3D.ID3DBlob** ppDebugInfo);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DReflect"]/*' />
	[LibraryImport("D3DCOMPILER_47.dll")]
	public static partial HResult D3DReflect(void* pSrcData, nuint SrcDataSize, Guid* pInterface, void** ppReflector);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DReflectLibrary"]/*' />
	[LibraryImport("D3DCOMPILER_47.dll")]
	public static partial HResult D3DReflectLibrary(void* pSrcData, nuint SrcDataSize, Guid* riid, void** ppReflector);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DDisassemble"]/*' />
	[LibraryImport("D3DCOMPILER_47.dll")]
	public static partial HResult D3DDisassemble(void* pSrcData, nuint SrcDataSize, DisasmFlags Flags, byte* szComments, Graphics.Direct3D.ID3DBlob** ppDisassembly);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DDisassembleRegion"]/*' />
	[LibraryImport("D3DCOMPILER_47.dll")]
	public static partial HResult D3DDisassembleRegion(void* pSrcData, nuint SrcDataSize, uint Flags, byte* szComments, nuint StartByteOffset, nuint NumInsts, nuint* pFinishByteOffset, Graphics.Direct3D.ID3DBlob** ppDisassembly);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DGetTraceInstructionOffsets"]/*' />
	[LibraryImport("D3DCOMPILER_47.dll")]
	public static partial HResult D3DGetTraceInstructionOffsets(void* pSrcData, nuint SrcDataSize, uint Flags, nuint StartInstIndex, nuint NumInsts, nuint* pOffsets, nuint* pTotalInsts);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DGetInputSignatureBlob"]/*' />
	[LibraryImport("D3DCOMPILER_47.dll")]
	public static partial HResult D3DGetInputSignatureBlob(void* pSrcData, nuint SrcDataSize, Graphics.Direct3D.ID3DBlob** ppSignatureBlob);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DGetOutputSignatureBlob"]/*' />
	[LibraryImport("D3DCOMPILER_47.dll")]
	public static partial HResult D3DGetOutputSignatureBlob(void* pSrcData, nuint SrcDataSize, Graphics.Direct3D.ID3DBlob** ppSignatureBlob);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DGetInputAndOutputSignatureBlob"]/*' />
	[LibraryImport("D3DCOMPILER_47.dll")]
	public static partial HResult D3DGetInputAndOutputSignatureBlob(void* pSrcData, nuint SrcDataSize, Graphics.Direct3D.ID3DBlob** ppSignatureBlob);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DStripShader"]/*' />
	[LibraryImport("D3DCOMPILER_47.dll")]
	public static partial HResult D3DStripShader(void* pShaderBytecode, nuint BytecodeLength, uint uStripFlags, Graphics.Direct3D.ID3DBlob** ppStrippedBlob);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DGetBlobPart"]/*' />
	[LibraryImport("D3DCOMPILER_47.dll")]
	public static partial HResult D3DGetBlobPart(void* pSrcData, nuint SrcDataSize, BlobPart Part, uint Flags, Graphics.Direct3D.ID3DBlob** ppPart);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DSetBlobPart"]/*' />
	[LibraryImport("D3DCOMPILER_47.dll")]
	public static partial HResult D3DSetBlobPart(void* pSrcData, nuint SrcDataSize, BlobPart Part, uint Flags, void* pPart, nuint PartSize, Graphics.Direct3D.ID3DBlob** ppNewShader);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DCreateBlob"]/*' />
	[LibraryImport("D3DCOMPILER_47.dll")]
	public static partial HResult D3DCreateBlob(nuint Size, Graphics.Direct3D.ID3DBlob** ppBlob);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DCompressShaders"]/*' />
	[LibraryImport("D3DCOMPILER_47.dll")]
	public static partial HResult D3DCompressShaders(uint uNumShaders, ShaderData* pShaderData, CompressShaderFlags uFlags, Graphics.Direct3D.ID3DBlob** ppCompressedData);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DDecompressShaders"]/*' />
	[LibraryImport("D3DCOMPILER_47.dll")]
	public static partial HResult D3DDecompressShaders(void* pSrcData, nuint SrcDataSize, uint uNumShaders, uint uStartIndex, uint* pIndices, uint uFlags, Graphics.Direct3D.ID3DBlob** ppShaders, uint* pTotalShaders);
}
