// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------


#if !NET6_0_OR_GREATER
using MemoryMarshal = Win32.MemoryMarshal;
#endif

namespace Win32.Graphics.Direct2D;

/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1Properties"]/*' />
/// <unmanaged>ID2D1Properties</unmanaged>
[Guid("483473d7-cd46-4f9d-9d3a-3112aa80159d")]
[NativeTypeName("struct ID2D1Properties : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID2D1Properties
{
	public static ref readonly Guid IID_ID2D1Properties
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xD7, 0x73, 0x34, 0x48,
				0x46, 0xCD,
				0x9D, 0x4F,
				0x9D,
				0x3A,
				0x31,
				0x12,
				0xAA,
				0x80,
				0x15,
				0x9D
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1Properties));

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IUnknown*, Guid*, void**, int>)(lpVtbl[0]))((IUnknown*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IUnknown*, uint>)(lpVtbl[1]))((IUnknown*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IUnknown*, uint>)(lpVtbl[2]))((IUnknown*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1Properties::GetPropertyCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public uint GetPropertyCount()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Properties*, uint>)(lpVtbl[3]))((ID2D1Properties*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1Properties::GetPropertyName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult GetPropertyName(uint index, ushort* name, uint nameCount)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Properties*, uint, ushort*, uint, int>)(lpVtbl[4]))((ID2D1Properties*)Unsafe.AsPointer(ref this), index, name, nameCount);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1Properties::GetPropertyNameLength"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public uint GetPropertyNameLength(uint index)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Properties*, uint, uint>)(lpVtbl[5]))((ID2D1Properties*)Unsafe.AsPointer(ref this), index);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1Properties::GetType"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public PropertyType GetType(uint index)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Properties*, uint, PropertyType>)(lpVtbl[6]))((ID2D1Properties*)Unsafe.AsPointer(ref this), index);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1Properties::GetPropertyIndex"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public uint GetPropertyIndex(ushort* name)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Properties*, ushort*, uint>)(lpVtbl[7]))((ID2D1Properties*)Unsafe.AsPointer(ref this), name);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1Properties::SetValueByName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult SetValueByName(ushort* name, PropertyType type, byte* data, uint dataSize)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Properties*, ushort*, PropertyType, byte*, uint, int>)(lpVtbl[8]))((ID2D1Properties*)Unsafe.AsPointer(ref this), name, type, data, dataSize);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1Properties::SetValue"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult SetValue(uint index, PropertyType type, byte* data, uint dataSize)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Properties*, uint, PropertyType, byte*, uint, int>)(lpVtbl[9]))((ID2D1Properties*)Unsafe.AsPointer(ref this), index, type, data, dataSize);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1Properties::GetValueByName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult GetValueByName(ushort* name, PropertyType type, byte* data, uint dataSize)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Properties*, ushort*, PropertyType, byte*, uint, int>)(lpVtbl[10]))((ID2D1Properties*)Unsafe.AsPointer(ref this), name, type, data, dataSize);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1Properties::GetValue"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult GetValue(uint index, PropertyType type, byte* data, uint dataSize)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Properties*, uint, PropertyType, byte*, uint, int>)(lpVtbl[11]))((ID2D1Properties*)Unsafe.AsPointer(ref this), index, type, data, dataSize);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1Properties::GetValueSize"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public uint GetValueSize(uint index)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Properties*, uint, uint>)(lpVtbl[12]))((ID2D1Properties*)Unsafe.AsPointer(ref this), index);
	}

	/// <include file='../../Direct2D.xml' path='doc/member[@name="ID2D1Properties::GetSubProperties"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult GetSubProperties(uint index, ID2D1Properties** subProperties)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1Properties*, uint, ID2D1Properties**, int>)(lpVtbl[13]))((ID2D1Properties*)Unsafe.AsPointer(ref this), index, subProperties);
	}
}

