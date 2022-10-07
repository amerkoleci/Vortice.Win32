// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D;

public static partial class Apis
{
	public const uint D3D_FL9_1_REQ_TEXTURE1D_U_DIMENSION = 2048;

	public const uint D3D_FL9_3_REQ_TEXTURE1D_U_DIMENSION = 4096;

	public const uint D3D_FL9_1_REQ_TEXTURE2D_U_OR_V_DIMENSION = 2048;

	public const uint D3D_FL9_3_REQ_TEXTURE2D_U_OR_V_DIMENSION = 4096;

	public const uint D3D_FL9_1_REQ_TEXTURECUBE_DIMENSION = 512;

	public const uint D3D_FL9_3_REQ_TEXTURECUBE_DIMENSION = 4096;

	public const uint D3D_FL9_1_REQ_TEXTURE3D_U_V_OR_W_DIMENSION = 256;

	public const uint D3D_FL9_1_DEFAULT_MAX_ANISOTROPY = 2;

	public const uint D3D_FL9_1_IA_PRIMITIVE_MAX_COUNT = 65535;

	public const uint D3D_FL9_2_IA_PRIMITIVE_MAX_COUNT = 1048575;

	public const uint D3D_FL9_1_SIMULTANEOUS_RENDER_TARGET_COUNT = 1;

	public const uint D3D_FL9_3_SIMULTANEOUS_RENDER_TARGET_COUNT = 4;

	public const uint D3D_FL9_1_MAX_TEXTURE_REPEAT = 128;

	public const uint D3D_FL9_2_MAX_TEXTURE_REPEAT = 2048;

	public const uint D3D_FL9_3_MAX_TEXTURE_REPEAT = 8192;

	public const uint D3D_SHADER_FEATURE_DOUBLES = 1;

	public const uint D3D_SHADER_FEATURE_COMPUTE_SHADERS_PLUS_RAW_AND_STRUCTURED_BUFFERS_VIA_SHADER_4_X = 2;

	public const uint D3D_SHADER_FEATURE_UAVS_AT_EVERY_STAGE = 4;

	public const uint D3D_SHADER_FEATURE_64_UAVS = 8;

	public const uint D3D_SHADER_FEATURE_MINIMUM_PRECISION = 16;

	public const uint D3D_SHADER_FEATURE_11_1_DOUBLE_EXTENSIONS = 32;

	public const uint D3D_SHADER_FEATURE_11_1_SHADER_EXTENSIONS = 64;

	public const uint D3D_SHADER_FEATURE_LEVEL_9_COMPARISON_FILTERING = 128;

	public const uint D3D_SHADER_FEATURE_TILED_RESOURCES = 256;

	public const uint D3D_SHADER_FEATURE_STENCIL_REF = 512;

	public const uint D3D_SHADER_FEATURE_INNER_COVERAGE = 1024;

	public const uint D3D_SHADER_FEATURE_TYPED_UAV_LOAD_ADDITIONAL_FORMATS = 2048;

	public const uint D3D_SHADER_FEATURE_ROVS = 4096;

	public const uint D3D_SHADER_FEATURE_VIEWPORT_AND_RT_ARRAY_INDEX_FROM_ANY_SHADER_FEEDING_RASTERIZER = 8192;

	public const uint D3D_SHADER_FEATURE_WAVE_OPS = 16384;

	public const uint D3D_SHADER_FEATURE_INT64_OPS = 32768;

	public const uint D3D_SHADER_FEATURE_VIEW_ID = 65536;

	public const uint D3D_SHADER_FEATURE_BARYCENTRICS = 131072;

	public const uint D3D_SHADER_FEATURE_NATIVE_16BIT_OPS = 262144;

	public const uint D3D_SHADER_FEATURE_SHADING_RATE = 524288;

	public const uint D3D_SHADER_FEATURE_RAYTRACING_TIER_1_1 = 1048576;

	public const uint D3D_SHADER_FEATURE_SAMPLER_FEEDBACK = 2097152;

	public const uint D3D_SHADER_FEATURE_ATOMIC_INT64_ON_TYPED_RESOURCE = 4194304;

	public const uint D3D_SHADER_FEATURE_ATOMIC_INT64_ON_GROUP_SHARED = 8388608;

	public const uint D3D_SHADER_FEATURE_DERIVATIVES_IN_MESH_AND_AMPLIFICATION_SHADERS = 16777216;

	public const uint D3D_SHADER_FEATURE_RESOURCE_DESCRIPTOR_HEAP_INDEXING = 33554432;

	public const uint D3D_SHADER_FEATURE_SAMPLER_DESCRIPTOR_HEAP_INDEXING = 67108864;

	public const uint D3D_SHADER_FEATURE_WAVE_MMA = 134217728;

	public const uint D3D_SHADER_FEATURE_ATOMIC_INT64_ON_DESCRIPTOR_HEAP_RESOURCE = 268435456;

	public static ref readonly Guid WKPDID_D3DDebugObjectName
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x22, 0x8C, 0x9B, 0x42,
				0x88, 0x91,
				0x0C, 0x4B,
				0x87,
				0x42,
				0xAC,
				0xB0,
				0xBF,
				0x85,
				0xC2,
				0x00
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static ref readonly Guid WKPDID_D3DDebugObjectNameW
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xD8, 0x5F, 0xCA, 0x4C,
				0x1F, 0x92,
				0xC8, 0x42,
				0x85,
				0x66,
				0x70,
				0xCA,
				0xF2,
				0xA9,
				0xB7,
				0x41
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static ref readonly Guid WKPDID_CommentStringW
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xC0, 0x9D, 0x14, 0xD0,
				0xE8, 0x90,
				0xC8, 0x4E,
				0x81,
				0x44,
				0xE9,
				0x00,
				0xAD,
				0x26,
				0x6B,
				0xB2
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static ref readonly Guid WKPDID_D3D12UniqueObjectId
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x15, 0xDE, 0x39, 0x1B,
				0x04, 0xEC,
				0xAE, 0x4B,
				0xBA,
				0x4D,
				0x8C,
				0xEF,
				0x79,
				0xFC,
				0x04,
				0xC1
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public const uint D3D_COMPONENT_MASK_X = 1;

	public const uint D3D_COMPONENT_MASK_Y = 2;

	public const uint D3D_COMPONENT_MASK_Z = 4;

	public const uint D3D_COMPONENT_MASK_W = 8;

	public static ref readonly Guid D3D_TEXTURE_LAYOUT_ROW_MAJOR
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x4F, 0x23, 0xDC, 0xB5,
				0xBB, 0x72,
				0xEC, 0x4B,
				0x97,
				0x05,
				0x8C,
				0xF2,
				0x58,
				0xDF,
				0x6B,
				0x6C
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static ref readonly Guid D3D_TEXTURE_LAYOUT_64KB_STANDARD_SWIZZLE
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xE3, 0x29, 0x0F, 0x4C,
				0x5F, 0x3F,
				0x35, 0x4D,
				0x84,
				0xC9,
				0xBC,
				0x09,
				0x83,
				0xB6,
				0x2C,
				0x28
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}
}

