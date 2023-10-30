// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D.Dxc;

/// <unmanaged>IDxcBlobUtf16</unmanaged>
[Guid("a3f84eab-0faa-497e-a39c-ee6ed60b2d84")]
[NativeTypeName("struct IDxcBlobUtf16 : IDxcBlobEncoding")]
[NativeInheritance("IDxcBlobEncoding")]
public unsafe partial struct IDxcBlobUtf16 : IDxcBlobUtf16.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDxcBlobUtf16
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xAB, 0x4E, 0xF8, 0xA3,
				0xAA, 0x0F,
				0x7E, 0x49,
				0xA3,
				0x9C,
				0xEE,
				0x6E,
				0xD6,
				0x0B,
				0x2D,
				0x84
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcBlobUtf16));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcBlobUtf16*, Guid*, void**, int>)(lpVtbl[0]))((IDxcBlobUtf16*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcBlobUtf16*, uint>)(lpVtbl[1]))((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcBlobUtf16*, uint>)(lpVtbl[2]))((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDxcBlob.GetBufferPointer" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void* GetBufferPointer()
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcBlobUtf16*, void*>)(lpVtbl[3]))((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDxcBlob.GetBufferSize" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public nuint GetBufferSize()
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcBlobUtf16*, nuint>)(lpVtbl[4]))((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDxcBlobEncoding.GetEncoding" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetEncoding(Bool32* pKnown, DxcCp* pCodePage)
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcBlobUtf16*, Bool32*, DxcCp*, int>)(lpVtbl[5]))((IDxcBlobUtf16*)Unsafe.AsPointer(ref this), pKnown, pCodePage);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public ushort* GetStringPointer()
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcBlobUtf16*, ushort*>)(lpVtbl[6]))((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public nuint GetStringLength()
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcBlobUtf16*, nuint>)(lpVtbl[7]))((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
	}

	public interface Interface : IDxcBlobEncoding.Interface
	{
		[VtblIndex(6)]
		ushort* GetStringPointer();

		[VtblIndex(7)]
		nuint GetStringLength();
	}
}

