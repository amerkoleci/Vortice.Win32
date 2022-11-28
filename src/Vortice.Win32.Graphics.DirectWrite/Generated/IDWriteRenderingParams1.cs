// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectWrite;

/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteRenderingParams1"]/*' />
/// <unmanaged>IDWriteRenderingParams1</unmanaged>
[Guid("94413cf4-a6fc-4248-8b50-6674348fcad3")]
[NativeTypeName("struct IDWriteRenderingParams1 : IDWriteRenderingParams")]
[NativeInheritance("IDWriteRenderingParams")]
public unsafe partial struct IDWriteRenderingParams1 : INativeGuid
{
	public static ref readonly Guid IID_IDWriteRenderingParams1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xF4, 0x3C, 0x41, 0x94,
				0xFC, 0xA6,
				0x48, 0x42,
				0x8B,
				0x50,
				0x66,
				0x74,
				0x34,
				0x8F,
				0xCA,
				0xD3
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteRenderingParams1));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteRenderingParams1));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams1*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteRenderingParams1*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams1*, uint>)(lpVtbl[1]))((IDWriteRenderingParams1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams1*, uint>)(lpVtbl[2]))((IDWriteRenderingParams1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteRenderingParams.GetGamma" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public float GetGamma()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams1*, float>)(lpVtbl[3]))((IDWriteRenderingParams1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteRenderingParams.GetEnhancedContrast" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public float GetEnhancedContrast()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams1*, float>)(lpVtbl[4]))((IDWriteRenderingParams1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteRenderingParams.GetClearTypeLevel" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public float GetClearTypeLevel()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams1*, float>)(lpVtbl[5]))((IDWriteRenderingParams1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteRenderingParams.GetPixelGeometry" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public PixelGeometry GetPixelGeometry()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams1*, PixelGeometry>)(lpVtbl[6]))((IDWriteRenderingParams1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDWriteRenderingParams.GetRenderingMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public RenderingMode GetRenderingMode()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams1*, RenderingMode>)(lpVtbl[7]))((IDWriteRenderingParams1*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectWrite.xml' path='doc/member[@name="IDWriteRenderingParams1::GetGrayscaleEnhancedContrast"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public float GetGrayscaleEnhancedContrast()
	{
		return ((delegate* unmanaged[Stdcall]<IDWriteRenderingParams1*, float>)(lpVtbl[8]))((IDWriteRenderingParams1*)Unsafe.AsPointer(ref this));
	}
}

