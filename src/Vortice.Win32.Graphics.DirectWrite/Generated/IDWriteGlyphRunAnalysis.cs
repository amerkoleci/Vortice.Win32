// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteGlyphRunAnalysis"]/*' />
/// <unmanaged>IDWriteGlyphRunAnalysis</unmanaged>
[Guid("7d97dbf7-e085-42d4-81e3-6a883bded118")]
[NativeTypeName("struct IDWriteGlyphRunAnalysis : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteGlyphRunAnalysis : IDWriteGlyphRunAnalysis.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDWriteGlyphRunAnalysis
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xF7, 0xDB, 0x97, 0x7D,
				0x85, 0xE0,
				0xD4, 0x42,
				0x81,
				0xE3,
				0x6A,
				0x88,
				0x3B,
				0xDE,
				0xD1,
				0x18
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteGlyphRunAnalysis));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteGlyphRunAnalysis));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteGlyphRunAnalysis*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, uint>)(lpVtbl[1]))((IDWriteGlyphRunAnalysis*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, uint>)(lpVtbl[2]))((IDWriteGlyphRunAnalysis*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteGlyphRunAnalysis::GetAlphaTextureBounds"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetAlphaTextureBounds(TextureType textureType, RawRect* textureBounds)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, TextureType, RawRect*, int>)(lpVtbl[3]))((IDWriteGlyphRunAnalysis*)Unsafe.AsPointer(ref this), textureType, textureBounds);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteGlyphRunAnalysis::CreateAlphaTexture"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult CreateAlphaTexture(TextureType textureType, RawRect* textureBounds, byte* alphaValues, uint bufferSize)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, TextureType, RawRect*, byte*, uint, int>)(lpVtbl[4]))((IDWriteGlyphRunAnalysis*)Unsafe.AsPointer(ref this), textureType, textureBounds, alphaValues, bufferSize);
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteGlyphRunAnalysis::GetAlphaBlendParams"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetAlphaBlendParams(IDWriteRenderingParams* renderingParams, float* blendGamma, float* blendEnhancedContrast, float* blendClearTypeLevel)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteGlyphRunAnalysis*, IDWriteRenderingParams*, float*, float*, float*, int>)(lpVtbl[5]))((IDWriteGlyphRunAnalysis*)Unsafe.AsPointer(ref this), renderingParams, blendGamma, blendEnhancedContrast, blendClearTypeLevel);
	}
	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult GetAlphaTextureBounds(TextureType textureType, RawRect* textureBounds);

		[VtblIndex(4)]
		HResult CreateAlphaTexture(TextureType textureType, RawRect* textureBounds, byte* alphaValues, uint bufferSize);

		[VtblIndex(5)]
		HResult GetAlphaBlendParams(IDWriteRenderingParams* renderingParams, float* blendGamma, float* blendEnhancedContrast, float* blendClearTypeLevel);
	}
}

