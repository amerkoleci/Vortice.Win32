// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgElement"]/*' />
/// <unmanaged>ID2D1SvgElement</unmanaged>
[Guid("ac7b67a6-183e-49c1-a823-0ebe40b0db29")]
[NativeTypeName("struct ID2D1SvgElement : ID2D1Resource")]
[NativeInheritance("ID2D1Resource")]
public unsafe partial struct ID2D1SvgElement : INativeGuid
{
	public static ref readonly Guid IID_ID2D1SvgElement
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xA6, 0x67, 0x7B, 0xAC,
				0x3E, 0x18,
				0xC1, 0x49,
				0xA8,
				0x23,
				0x0E,
				0xBE,
				0x40,
				0xB0,
				0xDB,
				0x29
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1SvgElement));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1SvgElement));
#endif

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

	/// <inheritdoc cref="ID2D1Resource.GetFactory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public void GetFactory(ID2D1Factory** factory)
	{
		((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), factory);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgElement::GetDocument"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public void GetDocument(ID2D1SvgDocument** document)
	{
		((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgDocument**, void>)(lpVtbl[4]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), document);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgElement::GetTagName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetTagName(ushort* name, uint nameCount)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ushort*, uint, int>)(lpVtbl[5]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, nameCount);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgElement::GetTagNameLength"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public uint GetTagNameLength()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint>)(lpVtbl[6]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgElement::IsTextContent"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public Bool32 IsTextContent()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, Bool32>)(lpVtbl[7]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgElement::GetParent"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public void GetParent(ID2D1SvgElement** parent)
	{
		((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement**, void>)(lpVtbl[8]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), parent);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgElement::HasChildren"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public Bool32 HasChildren()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, Bool32>)(lpVtbl[9]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgElement::GetFirstChild"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public void GetFirstChild(ID2D1SvgElement** child)
	{
		((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement**, void>)(lpVtbl[10]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), child);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgElement::GetLastChild"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public void GetLastChild(ID2D1SvgElement** child)
	{
		((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement**, void>)(lpVtbl[11]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), child);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgElement::GetPreviousChild"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult GetPreviousChild(ID2D1SvgElement* referenceChild, ID2D1SvgElement** previousChild)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int>)(lpVtbl[12]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), referenceChild, previousChild);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgElement::GetNextChild"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult GetNextChild(ID2D1SvgElement* referenceChild, ID2D1SvgElement** nextChild)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement**, int>)(lpVtbl[13]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), referenceChild, nextChild);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgElement::InsertChildBefore"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult InsertChildBefore(ID2D1SvgElement* newChild, ID2D1SvgElement* referenceChild)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int>)(lpVtbl[14]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), newChild, referenceChild);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgElement::AppendChild"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult AppendChild(ID2D1SvgElement* newChild)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, int>)(lpVtbl[15]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), newChild);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgElement::ReplaceChild"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult ReplaceChild(ID2D1SvgElement* newChild, ID2D1SvgElement* oldChild)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, ID2D1SvgElement*, int>)(lpVtbl[16]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), newChild, oldChild);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgElement::RemoveChild"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult RemoveChild(ID2D1SvgElement* oldChild)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ID2D1SvgElement*, int>)(lpVtbl[17]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), oldChild);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgElement::CreateChild"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult CreateChild(ushort* tagName, ID2D1SvgElement** newChild)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ushort*, ID2D1SvgElement**, int>)(lpVtbl[18]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), tagName, newChild);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgElement::IsAttributeSpecified"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public Bool32 IsAttributeSpecified(ushort* name, Bool32* inherited)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ushort*, Bool32*, Bool32>)(lpVtbl[19]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, inherited);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgElement::GetSpecifiedAttributeCount"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public uint GetSpecifiedAttributeCount()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint>)(lpVtbl[20]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgElement::GetSpecifiedAttributeName"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult GetSpecifiedAttributeName(uint index, ushort* name, uint nameCount, Bool32* inherited)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, ushort*, uint, Bool32*, int>)(lpVtbl[21]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), index, name, nameCount, inherited);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgElement::GetSpecifiedAttributeNameLength"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult GetSpecifiedAttributeNameLength(uint index, uint* nameLength, Bool32* inherited)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint, uint*, Bool32*, int>)(lpVtbl[22]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), index, nameLength, inherited);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgElement::RemoveAttribute"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public HResult RemoveAttribute(ushort* name)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ushort*, int>)(lpVtbl[23]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgElement::SetTextValue"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult SetTextValue(ushort* name, uint nameCount)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ushort*, uint, int>)(lpVtbl[24]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, nameCount);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgElement::GetTextValue"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public HResult GetTextValue(ushort* name, uint nameCount)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ushort*, uint, int>)(lpVtbl[25]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, nameCount);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgElement::GetTextValueLength"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public uint GetTextValueLength()
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, uint>)(lpVtbl[26]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgElement::SetAttributeValue"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public HResult SetAttributeValue(ushort* name, ID2D1SvgAttribute* value)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ushort*, ID2D1SvgAttribute*, int>)(lpVtbl[27]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, value);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgElement::SetAttributeValue"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public HResult SetAttributeValue(ushort* name, SvgAttributePodType type, void* value, uint valueSizeInBytes)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ushort*, SvgAttributePodType, void*, uint, int>)(lpVtbl[28]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, type, value, valueSizeInBytes);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgElement::SetAttributeValue"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(29)]
	public HResult SetAttributeValue(ushort* name, SvgAttributeStringType type, ushort* value)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ushort*, SvgAttributeStringType, ushort*, int>)(lpVtbl[29]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, type, value);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgElement::GetAttributeValue"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(30)]
	public HResult GetAttributeValue(ushort* name, Guid* riid, void** value)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ushort*, Guid*, void**, int>)(lpVtbl[30]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, riid, value);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgElement::GetAttributeValue"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(31)]
	public HResult GetAttributeValue(ushort* name, SvgAttributePodType type, void* value, uint valueSizeInBytes)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ushort*, SvgAttributePodType, void*, uint, int>)(lpVtbl[31]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, type, value, valueSizeInBytes);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgElement::GetAttributeValue"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(32)]
	public HResult GetAttributeValue(ushort* name, SvgAttributeStringType type, ushort* value, uint valueCount)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ushort*, SvgAttributeStringType, ushort*, uint, int>)(lpVtbl[32]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, type, value, valueCount);
	}

	/// <include file='../Direct2D.xml' path='doc/member[@name="ID2D1SvgElement::GetAttributeValueLength"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(33)]
	public HResult GetAttributeValueLength(ushort* name, SvgAttributeStringType type, uint* valueLength)
	{
		return ((delegate* unmanaged[Stdcall]<ID2D1SvgElement*, ushort*, SvgAttributeStringType, uint*, int>)(lpVtbl[33]))((ID2D1SvgElement*)Unsafe.AsPointer(ref this), name, type, valueLength);
	}
}
