// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1DrawingStateBlock1"]/*' />
/// <unmanaged>ID2D1DrawingStateBlock1</unmanaged>
[Guid("689f1f85-c72e-4e33-8f19-85754efd5ace")]
[NativeTypeName("struct ID2D1DrawingStateBlock1 : ID2D1DrawingStateBlock")]
[NativeInheritance("ID2D1DrawingStateBlock")]
public unsafe partial struct ID2D1DrawingStateBlock1 : ID2D1DrawingStateBlock1.Interface, INativeGuid
{
	public static ref readonly Guid IID_ID2D1DrawingStateBlock1
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x85, 0x1F, 0x9F, 0x68,
				0x2E, 0xC7,
				0x33, 0x4E,
				0x8F,
				0x19,
				0x85,
				0x75,
				0x4E,
				0xFD,
				0x5A,
				0xCE
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1DrawingStateBlock1));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1DrawingStateBlock1));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, uint>)(lpVtbl[1]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, uint>)(lpVtbl[2]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1Resource.GetFactory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetFactory(ID2D1Factory** factory)
	{
		((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), factory);
	}

	/// <inheritdoc cref="ID2D1DrawingStateBlock.GetDescription" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void GetDescription(DrawingStateDescription* stateDescription)
	{
		((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, DrawingStateDescription*, void>)(lpVtbl[4]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), stateDescription);
	}

	/// <inheritdoc cref="ID2D1DrawingStateBlock.SetDescription" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public void SetDescription(DrawingStateDescription* stateDescription)
	{
		((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, DrawingStateDescription*, void>)(lpVtbl[5]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), stateDescription);
	}

	/// <inheritdoc cref="ID2D1DrawingStateBlock.SetTextRenderingParams" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public void SetTextRenderingParams(Graphics.DirectWrite.IDWriteRenderingParams* textRenderingParams)
	{
		((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, Graphics.DirectWrite.IDWriteRenderingParams*, void>)(lpVtbl[6]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), textRenderingParams);
	}

	/// <inheritdoc cref="ID2D1DrawingStateBlock.GetTextRenderingParams" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public void GetTextRenderingParams(Graphics.DirectWrite.IDWriteRenderingParams** textRenderingParams)
	{
		((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, Graphics.DirectWrite.IDWriteRenderingParams**, void>)(lpVtbl[7]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), textRenderingParams);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1DrawingStateBlock1::GetDescription"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public void GetDescription(DrawingStateDescription1* stateDescription)
	{
		((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, DrawingStateDescription1*, void>)(lpVtbl[8]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), stateDescription);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1DrawingStateBlock1::SetDescription"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public void SetDescription(DrawingStateDescription1* stateDescription)
	{
		((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, DrawingStateDescription1*, void>)(lpVtbl[9]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), stateDescription);
	}
	public interface Interface : ID2D1DrawingStateBlock.Interface
	{
		[VtblIndex(8)]
		void GetDescription(DrawingStateDescription1* stateDescription);

		[VtblIndex(9)]
		void SetDescription(DrawingStateDescription1* stateDescription);
	}
}

