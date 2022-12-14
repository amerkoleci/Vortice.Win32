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
	[DllImport("D3DCOMPILER_47.dll", ExactSpelling = true)]
	public static extern HResult D3DReadFileToBlob(ushort* pFileName, Graphics.Direct3D.ID3DBlob** ppContents);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DWriteBlobToFile"]/*' />
	[DllImport("D3DCOMPILER_47.dll", ExactSpelling = true)]
	public static extern HResult D3DWriteBlobToFile(Graphics.Direct3D.ID3DBlob* pBlob, ushort* pFileName, Bool32 bOverwrite);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DCompile"]/*' />
	[DllImport("D3DCOMPILER_47.dll", ExactSpelling = true)]
	public static extern HResult D3DCompile(void* pSrcData, nuint SrcDataSize, sbyte* pSourceName, Graphics.Direct3D.ShaderMacro* pDefines, Graphics.Direct3D.ID3DInclude* pInclude, sbyte* pEntrypoint, sbyte* pTarget, CompileFlags Flags1, uint Flags2, Graphics.Direct3D.ID3DBlob** ppCode, Graphics.Direct3D.ID3DBlob** ppErrorMsgs);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DCompile2"]/*' />
	[DllImport("D3DCOMPILER_47.dll", ExactSpelling = true)]
	public static extern HResult D3DCompile2(void* pSrcData, nuint SrcDataSize, sbyte* pSourceName, Graphics.Direct3D.ShaderMacro* pDefines, Graphics.Direct3D.ID3DInclude* pInclude, sbyte* pEntrypoint, sbyte* pTarget, CompileFlags Flags1, uint Flags2, uint SecondaryDataFlags, void* pSecondaryData, nuint SecondaryDataSize, Graphics.Direct3D.ID3DBlob** ppCode, Graphics.Direct3D.ID3DBlob** ppErrorMsgs);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DCompileFromFile"]/*' />
	[DllImport("D3DCOMPILER_47.dll", ExactSpelling = true)]
	public static extern HResult D3DCompileFromFile(ushort* pFileName, Graphics.Direct3D.ShaderMacro* pDefines, Graphics.Direct3D.ID3DInclude* pInclude, sbyte* pEntrypoint, sbyte* pTarget, CompileFlags Flags1, uint Flags2, Graphics.Direct3D.ID3DBlob** ppCode, Graphics.Direct3D.ID3DBlob** ppErrorMsgs);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DPreprocess"]/*' />
	[DllImport("D3DCOMPILER_47.dll", ExactSpelling = true)]
	public static extern HResult D3DPreprocess(void* pSrcData, nuint SrcDataSize, sbyte* pSourceName, Graphics.Direct3D.ShaderMacro* pDefines, Graphics.Direct3D.ID3DInclude* pInclude, Graphics.Direct3D.ID3DBlob** ppCodeText, Graphics.Direct3D.ID3DBlob** ppErrorMsgs);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DGetDebugInfo"]/*' />
	[DllImport("D3DCOMPILER_47.dll", ExactSpelling = true)]
	public static extern HResult D3DGetDebugInfo(void* pSrcData, nuint SrcDataSize, Graphics.Direct3D.ID3DBlob** ppDebugInfo);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DReflect"]/*' />
	[DllImport("D3DCOMPILER_47.dll", ExactSpelling = true)]
	public static extern HResult D3DReflect(void* pSrcData, nuint SrcDataSize, Guid* pInterface, void** ppReflector);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DReflectLibrary"]/*' />
	[DllImport("D3DCOMPILER_47.dll", ExactSpelling = true)]
	public static extern HResult D3DReflectLibrary(void* pSrcData, nuint SrcDataSize, Guid* riid, void** ppReflector);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DDisassemble"]/*' />
	[DllImport("D3DCOMPILER_47.dll", ExactSpelling = true)]
	public static extern HResult D3DDisassemble(void* pSrcData, nuint SrcDataSize, DisasmFlags Flags, sbyte* szComments, Graphics.Direct3D.ID3DBlob** ppDisassembly);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DDisassembleRegion"]/*' />
	[DllImport("D3DCOMPILER_47.dll", ExactSpelling = true)]
	public static extern HResult D3DDisassembleRegion(void* pSrcData, nuint SrcDataSize, uint Flags, sbyte* szComments, nuint StartByteOffset, nuint NumInsts, nuint* pFinishByteOffset, Graphics.Direct3D.ID3DBlob** ppDisassembly);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DGetTraceInstructionOffsets"]/*' />
	[DllImport("D3DCOMPILER_47.dll", ExactSpelling = true)]
	public static extern HResult D3DGetTraceInstructionOffsets(void* pSrcData, nuint SrcDataSize, uint Flags, nuint StartInstIndex, nuint NumInsts, nuint* pOffsets, nuint* pTotalInsts);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DGetInputSignatureBlob"]/*' />
	[DllImport("D3DCOMPILER_47.dll", ExactSpelling = true)]
	public static extern HResult D3DGetInputSignatureBlob(void* pSrcData, nuint SrcDataSize, Graphics.Direct3D.ID3DBlob** ppSignatureBlob);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DGetOutputSignatureBlob"]/*' />
	[DllImport("D3DCOMPILER_47.dll", ExactSpelling = true)]
	public static extern HResult D3DGetOutputSignatureBlob(void* pSrcData, nuint SrcDataSize, Graphics.Direct3D.ID3DBlob** ppSignatureBlob);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DGetInputAndOutputSignatureBlob"]/*' />
	[DllImport("D3DCOMPILER_47.dll", ExactSpelling = true)]
	public static extern HResult D3DGetInputAndOutputSignatureBlob(void* pSrcData, nuint SrcDataSize, Graphics.Direct3D.ID3DBlob** ppSignatureBlob);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DStripShader"]/*' />
	[DllImport("D3DCOMPILER_47.dll", ExactSpelling = true)]
	public static extern HResult D3DStripShader(void* pShaderBytecode, nuint BytecodeLength, uint uStripFlags, Graphics.Direct3D.ID3DBlob** ppStrippedBlob);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DGetBlobPart"]/*' />
	[DllImport("D3DCOMPILER_47.dll", ExactSpelling = true)]
	public static extern HResult D3DGetBlobPart(void* pSrcData, nuint SrcDataSize, BlobPart Part, uint Flags, Graphics.Direct3D.ID3DBlob** ppPart);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DSetBlobPart"]/*' />
	[DllImport("D3DCOMPILER_47.dll", ExactSpelling = true)]
	public static extern HResult D3DSetBlobPart(void* pSrcData, nuint SrcDataSize, BlobPart Part, uint Flags, void* pPart, nuint PartSize, Graphics.Direct3D.ID3DBlob** ppNewShader);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DCreateBlob"]/*' />
	[DllImport("D3DCOMPILER_47.dll", ExactSpelling = true)]
	public static extern HResult D3DCreateBlob(nuint Size, Graphics.Direct3D.ID3DBlob** ppBlob);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DCompressShaders"]/*' />
	[DllImport("D3DCOMPILER_47.dll", ExactSpelling = true)]
	public static extern HResult D3DCompressShaders(uint uNumShaders, ShaderData* pShaderData, CompressShaderFlags uFlags, Graphics.Direct3D.ID3DBlob** ppCompressedData);

	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DDecompressShaders"]/*' />
	[DllImport("D3DCOMPILER_47.dll", ExactSpelling = true)]
	public static extern HResult D3DDecompressShaders(void* pSrcData, nuint SrcDataSize, uint uNumShaders, uint uStartIndex, uint* pIndices, uint uFlags, Graphics.Direct3D.ID3DBlob** ppShaders, uint* pTotalShaders);
}
