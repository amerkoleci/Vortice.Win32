// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1ColorContext"]/*' />
/// <unmanaged>ID2D1ColorContext</unmanaged>
[Guid("1c4820bb-5771-4518-a581-2fe4dd0ec657")]
[NativeTypeName("struct ID2D1ColorContext : ID2D1Resource")]
[NativeInheritance("ID2D1Resource")]
public unsafe partial struct ID2D1ColorContext : INativeGuid
{
	public static ref readonly Guid IID_ID2D1ColorContext
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xBB, 0x20, 0x48, 0x1C,
				0x71, 0x57,
				0x18, 0x45,
				0xA5,
				0x81,
				0x2F,
				0xE4,
				0xDD,
				0x0E,
				0xC6,
				0x57
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1ColorContext));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1ColorContext));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ColorContext*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1ColorContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ColorContext*, uint>)(lpVtbl[1]))((ID2D1ColorContext*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ColorContext*, uint>)(lpVtbl[2]))((ID2D1ColorContext*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID2D1Resource.GetFactory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetFactory(ID2D1Factory** factory)
	{
		((delegate* unmanaged[Stdcall]<ID2D1ColorContext*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1ColorContext*)Unsafe.AsPointer(ref this), factory);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1ColorContext::GetColorSpace"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public ColorSpace GetColorSpace()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ColorContext*, ColorSpace>)(lpVtbl[4]))((ID2D1ColorContext*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1ColorContext::GetProfileSize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public uint GetProfileSize()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ColorContext*, uint>)(lpVtbl[5]))((ID2D1ColorContext*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1ColorContext::GetProfile"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetProfile(byte* profile, uint profileSize)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1ColorContext*, byte*, uint, int>)(lpVtbl[6]))((ID2D1ColorContext*)Unsafe.AsPointer(ref this), profile, profileSize);
	}
}

