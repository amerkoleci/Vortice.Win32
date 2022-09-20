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

namespace Win32.Graphics.Direct3D11;

/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11FunctionLinkingGraph"]/*' />
/// <unmanaged>ID3D11FunctionLinkingGraph</unmanaged>
[Guid("54133220-1ce8-43d3-8236-9855c5ceecff")]
[NativeTypeName("struct ID3D11FunctionLinkingGraph : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D11FunctionLinkingGraph
{
	public static ref readonly Guid IID_ID3D11FunctionLinkingGraph
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x20, 0x32, 0x13, 0x54,
				0xE8, 0x1C,
				0xD3, 0x43,
				0x82,
				0x36,
				0x98,
				0x55,
				0xC5,
				0xCE,
				0xEC,
				0xFF
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11FunctionLinkingGraph));

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

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11FunctionLinkingGraph::CreateModuleInstance"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult CreateModuleInstance(ID3D11ModuleInstance** ppModuleInstance, Graphics.Direct3D.ID3DBlob** ppErrorBuffer)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11ModuleInstance**, Graphics.Direct3D.ID3DBlob**, int>)(lpVtbl[3]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), ppModuleInstance, ppErrorBuffer);
	}

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11FunctionLinkingGraph::SetInputSignature"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult SetInputSignature(ParameterDescription* pInputParameters, uint cInputParameters, ID3D11LinkingNode** ppInputNode)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ParameterDescription*, uint, ID3D11LinkingNode**, int>)(lpVtbl[4]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), pInputParameters, cInputParameters, ppInputNode);
	}

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11FunctionLinkingGraph::SetOutputSignature"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult SetOutputSignature(ParameterDescription* pOutputParameters, uint cOutputParameters, ID3D11LinkingNode** ppOutputNode)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ParameterDescription*, uint, ID3D11LinkingNode**, int>)(lpVtbl[5]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), pOutputParameters, cOutputParameters, ppOutputNode);
	}

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11FunctionLinkingGraph::CallFunction"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult CallFunction(sbyte* pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, sbyte* pFunctionName, ID3D11LinkingNode** ppCallNode)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, sbyte*, ID3D11Module*, sbyte*, ID3D11LinkingNode**, int>)(lpVtbl[6]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionName, ppCallNode);
	}

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11FunctionLinkingGraph::PassValue"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult PassValue(ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, ID3D11LinkingNode* pDstNode, int DstParameterIndex)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, ID3D11LinkingNode*, int, int>)(lpVtbl[7]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), pSrcNode, SrcParameterIndex, pDstNode, DstParameterIndex);
	}

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11FunctionLinkingGraph::PassValueWithSwizzle"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult PassValueWithSwizzle(ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, sbyte* pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, sbyte* pDstSwizzle)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, sbyte*, ID3D11LinkingNode*, int, sbyte*, int>)(lpVtbl[8]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzle);
	}

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11FunctionLinkingGraph::GetLastError"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult GetLastError(Graphics.Direct3D.ID3DBlob** ppErrorBuffer)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, Graphics.Direct3D.ID3DBlob**, int>)(lpVtbl[9]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), ppErrorBuffer);
	}

	/// <include file='../../Direct3D11.xml' path='doc/member[@name="ID3D11FunctionLinkingGraph::GenerateHlsl"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult GenerateHlsl(uint uFlags, Graphics.Direct3D.ID3DBlob** ppBuffer)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, uint, Graphics.Direct3D.ID3DBlob**, int>)(lpVtbl[10]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), uFlags, ppBuffer);
	}
}

