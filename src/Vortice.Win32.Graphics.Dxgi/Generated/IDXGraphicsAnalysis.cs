// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Dxgi;

/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGraphicsAnalysis"]/*' />
/// <unmanaged>IDXGraphicsAnalysis</unmanaged>
[Guid("9f251514-9d4d-4902-9d60-18988ab7d4b5")]
[NativeTypeName("struct IDXGraphicsAnalysis : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDXGraphicsAnalysis : IDXGraphicsAnalysis.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDXGraphicsAnalysis
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x14, 0x15, 0x25, 0x9F,
				0x4D, 0x9D,
				0x02, 0x49,
				0x9D,
				0x60,
				0x18,
				0x98,
				0x8A,
				0xB7,
				0xD4,
				0xB5
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGraphicsAnalysis));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGraphicsAnalysis*, Guid*, void**, int>)(lpVtbl[0]))((IDXGraphicsAnalysis*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGraphicsAnalysis*, uint>)(lpVtbl[1]))((IDXGraphicsAnalysis*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<IDXGraphicsAnalysis*, uint>)(lpVtbl[2]))((IDXGraphicsAnalysis*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGraphicsAnalysis::BeginCapture"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void BeginCapture()
	{
		((delegate* unmanaged[MemberFunction]<IDXGraphicsAnalysis*, void>)(lpVtbl[3]))((IDXGraphicsAnalysis*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Dxgi.xml' path='doc/member[@name="IDXGraphicsAnalysis::EndCapture"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void EndCapture()
	{
		((delegate* unmanaged[MemberFunction]<IDXGraphicsAnalysis*, void>)(lpVtbl[4]))((IDXGraphicsAnalysis*)Unsafe.AsPointer(ref this));
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		void BeginCapture();

		[VtblIndex(4)]
		void EndCapture();
	}
}

