// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D.Dxc;

/// <unmanaged>IDxcOptimizerPass</unmanaged>
[Guid("ae2cd79f-cc22-453f-9b6b-b124e7a5204c")]
[NativeTypeName("struct IDxcOptimizerPass : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxcOptimizerPass : IDxcOptimizerPass.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDxcOptimizerPass
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x9F, 0xD7, 0x2C, 0xAE,
				0x22, 0xCC,
				0x3F, 0x45,
				0x9B,
				0x6B,
				0xB1,
				0x24,
				0xE7,
				0xA5,
				0x20,
				0x4C
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcOptimizerPass));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcOptimizerPass*, Guid*, void**, int>)(lpVtbl[0]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcOptimizerPass*, uint>)(lpVtbl[1]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcOptimizerPass*, uint>)(lpVtbl[2]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult GetOptionName(char** ppResult)
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcOptimizerPass*, char**, int>)(lpVtbl[3]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), ppResult);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetDescription(char** ppResult)
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcOptimizerPass*, char**, int>)(lpVtbl[4]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), ppResult);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetOptionArgCount(uint* pCount)
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcOptimizerPass*, uint*, int>)(lpVtbl[5]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), pCount);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult GetOptionArgName(uint argIndex, char** ppResult)
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcOptimizerPass*, uint, char**, int>)(lpVtbl[6]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), argIndex, ppResult);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetOptionArgDescription(uint argIndex, char** ppResult)
	{
		return ((delegate* unmanaged[MemberFunction]<IDxcOptimizerPass*, uint, char**, int>)(lpVtbl[7]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), argIndex, ppResult);
	}

	public interface Interface : IUnknown.Interface
	{
		[VtblIndex(3)]
		HResult GetOptionName(char** ppResult);

		[VtblIndex(4)]
		HResult GetDescription(char** ppResult);

		[VtblIndex(5)]
		HResult GetOptionArgCount(uint* pCount);

		[VtblIndex(6)]
		HResult GetOptionArgName(uint argIndex, char** ppResult);

		[VtblIndex(7)]
		HResult GetOptionArgDescription(uint argIndex, char** ppResult);
	}
}

