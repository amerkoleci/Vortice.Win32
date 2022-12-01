// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectComposition;

/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionMatrixTransform"]/*' />
/// <unmanaged>IDCompositionMatrixTransform</unmanaged>
[Guid("16cdff07-c503-419c-83f2-0965c7af1fa6")]
[NativeTypeName("struct IDCompositionMatrixTransform : IDCompositionTransform")]
[NativeInheritance("IDCompositionTransform")]
public unsafe partial struct IDCompositionMatrixTransform : IDCompositionMatrixTransform.Interface, INativeGuid
{
	public static ref readonly Guid IID_IDCompositionMatrixTransform
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x07, 0xFF, 0xCD, 0x16,
				0x03, 0xC5,
				0x9C, 0x41,
				0x83,
				0xF2,
				0x09,
				0x65,
				0xC7,
				0xAF,
				0x1F,
				0xA6
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionMatrixTransform));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionMatrixTransform));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionMatrixTransform*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionMatrixTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionMatrixTransform*, uint>)(lpVtbl[1]))((IDCompositionMatrixTransform*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionMatrixTransform*, uint>)(lpVtbl[2]))((IDCompositionMatrixTransform*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionMatrixTransform::SetMatrix"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult SetMatrix(Matrix3x2* matrix)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionMatrixTransform*, Matrix3x2*, int>)(lpVtbl[3]))((IDCompositionMatrixTransform*)Unsafe.AsPointer(ref this), matrix);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionMatrixTransform::SetMatrixElement"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetMatrixElement(int row, int column, IDCompositionAnimation* animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionMatrixTransform*, int, int, IDCompositionAnimation*, int>)(lpVtbl[4]))((IDCompositionMatrixTransform*)Unsafe.AsPointer(ref this), row, column, animation);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionMatrixTransform::SetMatrixElement"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetMatrixElement(int row, int column, float value)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionMatrixTransform*, int, int, float, int>)(lpVtbl[5]))((IDCompositionMatrixTransform*)Unsafe.AsPointer(ref this), row, column, value);
	}
	public interface Interface : IDCompositionTransform.Interface
	{
		[VtblIndex(3)]
		HResult SetMatrix(Matrix3x2* matrix);

		[VtblIndex(4)]
		HResult SetMatrixElement(int row, int column, IDCompositionAnimation* animation);

		[VtblIndex(5)]
		HResult SetMatrixElement(int row, int column, float value);
	}
}

