// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D.Fxc;

/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DCOMPILER_STRIP_FLAGS"]/*' />
/// <unmanaged>D3DCOMPILER_STRIP_FLAGS</unmanaged>
[Flags]
public enum StripFlags
{
	None = 0,
	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DCOMPILER_STRIP_FLAGS::D3DCOMPILER_STRIP_REFLECTION_DATA"]/*' />
	/// <unmanaged>D3DCOMPILER_STRIP_REFLECTION_DATA</unmanaged>
	ReflectionData = 1,
	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DCOMPILER_STRIP_FLAGS::D3DCOMPILER_STRIP_DEBUG_INFO"]/*' />
	/// <unmanaged>D3DCOMPILER_STRIP_DEBUG_INFO</unmanaged>
	DebugInfo = 2,
	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DCOMPILER_STRIP_FLAGS::D3DCOMPILER_STRIP_TEST_BLOBS"]/*' />
	/// <unmanaged>D3DCOMPILER_STRIP_TEST_BLOBS</unmanaged>
	TestBlobs = 4,
	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DCOMPILER_STRIP_FLAGS::D3DCOMPILER_STRIP_PRIVATE_DATA"]/*' />
	/// <unmanaged>D3DCOMPILER_STRIP_PRIVATE_DATA</unmanaged>
	PrivateData = 8,
	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3DCOMPILER_STRIP_FLAGS::D3DCOMPILER_STRIP_ROOT_SIGNATURE"]/*' />
	/// <unmanaged>D3DCOMPILER_STRIP_ROOT_SIGNATURE</unmanaged>
	RootSignature = 16,
}

/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3D_BLOB_PART"]/*' />
/// <unmanaged>D3D_BLOB_PART</unmanaged>
public enum BlobPart
{
	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3D_BLOB_PART::D3D_BLOB_INPUT_SIGNATURE_BLOB"]/*' />
	/// <unmanaged>D3D_BLOB_INPUT_SIGNATURE_BLOB</unmanaged>
	InputSignatureBlob = 0,
	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3D_BLOB_PART::D3D_BLOB_OUTPUT_SIGNATURE_BLOB"]/*' />
	/// <unmanaged>D3D_BLOB_OUTPUT_SIGNATURE_BLOB</unmanaged>
	OutputSignatureBlob = 1,
	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3D_BLOB_PART::D3D_BLOB_INPUT_AND_OUTPUT_SIGNATURE_BLOB"]/*' />
	/// <unmanaged>D3D_BLOB_INPUT_AND_OUTPUT_SIGNATURE_BLOB</unmanaged>
	InputAndOutputSignatureBlob = 2,
	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3D_BLOB_PART::D3D_BLOB_PATCH_CONSTANT_SIGNATURE_BLOB"]/*' />
	/// <unmanaged>D3D_BLOB_PATCH_CONSTANT_SIGNATURE_BLOB</unmanaged>
	PatchConstantSignatureBlob = 3,
	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3D_BLOB_PART::D3D_BLOB_ALL_SIGNATURE_BLOB"]/*' />
	/// <unmanaged>D3D_BLOB_ALL_SIGNATURE_BLOB</unmanaged>
	AllSignatureBlob = 4,
	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3D_BLOB_PART::D3D_BLOB_DEBUG_INFO"]/*' />
	/// <unmanaged>D3D_BLOB_DEBUG_INFO</unmanaged>
	DebugInfo = 5,
	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3D_BLOB_PART::D3D_BLOB_LEGACY_SHADER"]/*' />
	/// <unmanaged>D3D_BLOB_LEGACY_SHADER</unmanaged>
	LegacyShader = 6,
	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3D_BLOB_PART::D3D_BLOB_XNA_PREPASS_SHADER"]/*' />
	/// <unmanaged>D3D_BLOB_XNA_PREPASS_SHADER</unmanaged>
	XNAPrepassShader = 7,
	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3D_BLOB_PART::D3D_BLOB_XNA_SHADER"]/*' />
	/// <unmanaged>D3D_BLOB_XNA_SHADER</unmanaged>
	XNAShader = 8,
	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3D_BLOB_PART::D3D_BLOB_PDB"]/*' />
	/// <unmanaged>D3D_BLOB_PDB</unmanaged>
	Pdb = 9,
	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3D_BLOB_PART::D3D_BLOB_PRIVATE_DATA"]/*' />
	/// <unmanaged>D3D_BLOB_PRIVATE_DATA</unmanaged>
	PrivateData = 10,
	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3D_BLOB_PART::D3D_BLOB_ROOT_SIGNATURE"]/*' />
	/// <unmanaged>D3D_BLOB_ROOT_SIGNATURE</unmanaged>
	RootSignature = 11,
	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3D_BLOB_PART::D3D_BLOB_DEBUG_NAME"]/*' />
	/// <unmanaged>D3D_BLOB_DEBUG_NAME</unmanaged>
	DebugName = 12,
	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3D_BLOB_PART::D3D_BLOB_TEST_ALTERNATE_SHADER"]/*' />
	/// <unmanaged>D3D_BLOB_TEST_ALTERNATE_SHADER</unmanaged>
	TestAlternateShader = 32768,
	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3D_BLOB_PART::D3D_BLOB_TEST_COMPILE_DETAILS"]/*' />
	/// <unmanaged>D3D_BLOB_TEST_COMPILE_DETAILS</unmanaged>
	TestCompileDetails = 32769,
	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3D_BLOB_PART::D3D_BLOB_TEST_COMPILE_PERF"]/*' />
	/// <unmanaged>D3D_BLOB_TEST_COMPILE_PERF</unmanaged>
	TestCompilePerf = 32770,
	/// <include file='../../Vortice.Win32/Generated/Graphics/Direct3D.xml' path='doc/member[@name="D3D_BLOB_PART::D3D_BLOB_TEST_COMPILE_REPORT"]/*' />
	/// <unmanaged>D3D_BLOB_TEST_COMPILE_REPORT</unmanaged>
	TestCompileReport = 32771,
}
/// <unmanaged>D3DCOMPILE</unmanaged>
[Flags]
public enum CompileFlags : uint
{
	None = 0,
	/// <unmanaged>D3DCOMPILE_DEBUG</unmanaged>
	Debug = 1,
	/// <unmanaged>D3DCOMPILE_SKIP_VALIDATION</unmanaged>
	SkipValidation = 2,
	/// <unmanaged>D3DCOMPILE_SKIP_OPTIMIZATION</unmanaged>
	SkipOptimization = 4,
	/// <unmanaged>D3DCOMPILE_PACK_MATRIX_ROW_MAJOR</unmanaged>
	PackMatrixRowMajor = 8,
	/// <unmanaged>D3DCOMPILE_PACK_MATRIX_COLUMN_MAJOR</unmanaged>
	PackMatrixColumnMajor = 16,
	/// <unmanaged>D3DCOMPILE_PARTIAL_PRECISION</unmanaged>
	PartialPrecision = 32,
	/// <unmanaged>D3DCOMPILE_FORCE_VS_SOFTWARE_NO_OPT</unmanaged>
	ForceVSSoftwareNoOpt = 64,
	/// <unmanaged>D3DCOMPILE_FORCE_PS_SOFTWARE_NO_OPT</unmanaged>
	ForcePSSoftwareNoOpt = 128,
	/// <unmanaged>D3DCOMPILE_NO_PRESHADER</unmanaged>
	NoPreshader = 256,
	/// <unmanaged>D3DCOMPILE_AVOID_FLOW_CONTROL</unmanaged>
	AvoidFlowControl = 512,
	/// <unmanaged>D3DCOMPILE_PREFER_FLOW_CONTROL</unmanaged>
	PreferFlowControl = 1024,
	/// <unmanaged>D3DCOMPILE_ENABLE_STRICTNESS</unmanaged>
	EnableStrictness = 2048,
	/// <unmanaged>D3DCOMPILE_ENABLE_BACKWARDS_COMPATIBILITY</unmanaged>
	EnableBackwardsCompatibility = 4096,
	/// <unmanaged>D3DCOMPILE_IEEE_STRICTNESS</unmanaged>
	IeeeStrictness = 8192,
	/// <unmanaged>D3DCOMPILE_OPTIMIZATION_LEVEL0</unmanaged>
	OptimizationLevel0 = 16384,
	/// <unmanaged>D3DCOMPILE_OPTIMIZATION_LEVEL1</unmanaged>
	OptimizationLevel1 = 0,
	/// <unmanaged>D3DCOMPILE_OPTIMIZATION_LEVEL2</unmanaged>
	OptimizationLevel2 = 49152,
	/// <unmanaged>D3DCOMPILE_OPTIMIZATION_LEVEL3</unmanaged>
	OptimizationLevel3 = 32768,
	/// <unmanaged>D3DCOMPILE_RESERVED16</unmanaged>
	Reserved16 = 65536,
	/// <unmanaged>D3DCOMPILE_RESERVED17</unmanaged>
	Reserved17 = 131072,
	/// <unmanaged>D3DCOMPILE_WARNINGS_ARE_ERRORS</unmanaged>
	WarningsAreErrors = 262144,
	/// <unmanaged>D3DCOMPILE_RESOURCES_MAY_ALIAS</unmanaged>
	ResourcesMayAlias = 524288,
	/// <unmanaged>D3DCOMPILE_ENABLE_UNBOUNDED_DESCRIPTOR_TABLES</unmanaged>
	EnableUnboundedDescriptorTables = 1048576,
	/// <unmanaged>D3DCOMPILE_ALL_RESOURCES_BOUND</unmanaged>
	AllResourcesBound = 2097152,
	/// <unmanaged>D3DCOMPILE_DEBUG_NAME_FOR_SOURCE</unmanaged>
	DebugNameForSource = 4194304,
	/// <unmanaged>D3DCOMPILE_DEBUG_NAME_FOR_BINARY</unmanaged>
	DebugNameForBinary = 8388608,
}

/// <unmanaged>D3DCOMPILE_EFFECT</unmanaged>
[Flags]
public enum CompileEffectFlags : uint
{
	None = 0,
	/// <unmanaged>D3DCOMPILE_EFFECT_CHILD_EFFECT</unmanaged>
	ChildEffect = 1,
	/// <unmanaged>D3DCOMPILE_EFFECT_ALLOW_SLOW_OPS</unmanaged>
	AllowSlowOps = 2,
}

/// <unmanaged>D3DCOMPILE_FLAGS2</unmanaged>
[Flags]
public enum CompileFlags2 : uint
{
	None = 0,
	/// <unmanaged>D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_LATEST</unmanaged>
	ForceRootSignatureLatest = 0,
	/// <unmanaged>D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_1_0</unmanaged>
	ForceRootSignature10 = 16,
	/// <unmanaged>D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_1_1</unmanaged>
	ForceRootSignature11 = 32,
}

/// <unmanaged>D3DCOMPILE_SECDATA</unmanaged>
[Flags]
public enum CompileSecondaryFlags : uint
{
	None = 0,
	/// <unmanaged>D3DCOMPILE_SECDATA_MERGE_UAV_SLOTS</unmanaged>
	MergeUavSlots = 1,
	/// <unmanaged>D3DCOMPILE_SECDATA_PRESERVE_TEMPLATE_SLOTS</unmanaged>
	PreserveTemplateSlots = 2,
	/// <unmanaged>D3DCOMPILE_SECDATA_REQUIRE_TEMPLATE_MATCH</unmanaged>
	RequireTemplateMatch = 4,
}

/// <unmanaged>D3D_DISASM</unmanaged>
[Flags]
public enum DisasmFlags : uint
{
	None = 0,
	/// <unmanaged>D3D_DISASM_ENABLE_COLOR_CODE</unmanaged>
	EnableColorCode = 1,
	/// <unmanaged>D3D_DISASM_ENABLE_DEFAULT_VALUE_PRINTS</unmanaged>
	EnableDefaultValuePrints = 2,
	/// <unmanaged>D3D_DISASM_ENABLE_INSTRUCTION_NUMBERING</unmanaged>
	EnableInstructionNumbering = 4,
	/// <unmanaged>D3D_DISASM_ENABLE_INSTRUCTION_CYCLE</unmanaged>
	EnableInstructionCycle = 8,
	/// <unmanaged>D3D_DISASM_DISABLE_DEBUG_INFO</unmanaged>
	DisableDebugInfo = 16,
	/// <unmanaged>D3D_DISASM_ENABLE_INSTRUCTION_OFFSET</unmanaged>
	EnableInstructionOffset = 32,
	/// <unmanaged>D3D_DISASM_INSTRUCTION_ONLY</unmanaged>
	InstructionOnly = 64,
	/// <unmanaged>D3D_DISASM_PRINT_HEX_LITERALS</unmanaged>
	PrintHexLiterals = 128,
}

/// <unmanaged>D3D_COMPRESS_SHADER</unmanaged>
[Flags]
public enum CompressShaderFlags : uint
{
	None = 0,
	/// <unmanaged>D3D_COMPRESS_SHADER_KEEP_ALL_PARTS</unmanaged>
	KeepAllParts = 1,
}
