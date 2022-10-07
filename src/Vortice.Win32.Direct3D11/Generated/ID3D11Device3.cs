// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct3D11;

/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Device3"]/*' />
/// <unmanaged>ID3D11Device3</unmanaged>
[Guid("a05c8c37-d2c6-4732-b3a0-9ce0b0dc9ae6")]
[NativeTypeName("struct ID3D11Device3 : ID3D11Device2")]
[NativeInheritance("ID3D11Device2")]
public unsafe partial struct ID3D11Device3 : INativeGuid
{
	public static ref readonly Guid IID_ID3D11Device3
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0x37, 0x8C, 0x5C, 0xA0,
				0xC6, 0xD2,
				0x32, 0x47,
				0xB3,
				0xA0,
				0x9C,
				0xE0,
				0xB0,
				0xDC,
				0x9A,
				0xE6
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Device3));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Device3));
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

	/// <inheritdoc cref="ID3D11Device.CreateBuffer" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult CreateBuffer(BufferDescription* pDesc, SubresourceData* pInitialData, ID3D11Buffer** ppBuffer)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, BufferDescription*, SubresourceData*, ID3D11Buffer**, int>)(lpVtbl[3]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppBuffer);
	}

	/// <inheritdoc cref="ID3D11Device.CreateTexture1D" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult CreateTexture1D(Texture1DDescription* pDesc, SubresourceData* pInitialData, ID3D11Texture1D** ppTexture1D)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, Texture1DDescription*, SubresourceData*, ID3D11Texture1D**, int>)(lpVtbl[4]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppTexture1D);
	}

	/// <inheritdoc cref="ID3D11Device.CreateTexture2D" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult CreateTexture2D(Texture2DDescription* pDesc, SubresourceData* pInitialData, ID3D11Texture2D** ppTexture2D)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, Texture2DDescription*, SubresourceData*, ID3D11Texture2D**, int>)(lpVtbl[5]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppTexture2D);
	}

	/// <inheritdoc cref="ID3D11Device.CreateTexture3D" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult CreateTexture3D(Texture3DDescription* pDesc, SubresourceData* pInitialData, ID3D11Texture3D** ppTexture3D)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, Texture3DDescription*, SubresourceData*, ID3D11Texture3D**, int>)(lpVtbl[6]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppTexture3D);
	}

	/// <inheritdoc cref="ID3D11Device.CreateShaderResourceView" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CreateShaderResourceView(ID3D11Resource* pResource, ShaderResourceViewDescription* pDesc, ID3D11ShaderResourceView** ppSRView)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, ID3D11Resource*, ShaderResourceViewDescription*, ID3D11ShaderResourceView**, int>)(lpVtbl[7]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pResource, pDesc, ppSRView);
	}

	/// <inheritdoc cref="ID3D11Device.CreateUnorderedAccessView" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateUnorderedAccessView(ID3D11Resource* pResource, UnorderedAccessViewDescription* pDesc, ID3D11UnorderedAccessView** ppUAView)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, ID3D11Resource*, UnorderedAccessViewDescription*, ID3D11UnorderedAccessView**, int>)(lpVtbl[8]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pResource, pDesc, ppUAView);
	}

	/// <inheritdoc cref="ID3D11Device.CreateRenderTargetView" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult CreateRenderTargetView(ID3D11Resource* pResource, RenderTargetViewDescription* pDesc, ID3D11RenderTargetView** ppRTView)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, ID3D11Resource*, RenderTargetViewDescription*, ID3D11RenderTargetView**, int>)(lpVtbl[9]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pResource, pDesc, ppRTView);
	}

	/// <inheritdoc cref="ID3D11Device.CreateDepthStencilView" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult CreateDepthStencilView(ID3D11Resource* pResource, DepthStencilViewDescription* pDesc, ID3D11DepthStencilView** ppDepthStencilView)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, ID3D11Resource*, DepthStencilViewDescription*, ID3D11DepthStencilView**, int>)(lpVtbl[10]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pResource, pDesc, ppDepthStencilView);
	}

	/// <inheritdoc cref="ID3D11Device.CreateInputLayout" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult CreateInputLayout(InputElementDescription* pInputElementDescs, uint NumElements, void* pShaderBytecodeWithInputSignature, nuint BytecodeLength, ID3D11InputLayout** ppInputLayout)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, InputElementDescription*, uint, void*, nuint, ID3D11InputLayout**, int>)(lpVtbl[11]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pInputElementDescs, NumElements, pShaderBytecodeWithInputSignature, BytecodeLength, ppInputLayout);
	}

	/// <inheritdoc cref="ID3D11Device.CreateVertexShader" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult CreateVertexShader(void* pShaderBytecode, nuint BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11VertexShader** ppVertexShader)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, void*, nuint, ID3D11ClassLinkage*, ID3D11VertexShader**, int>)(lpVtbl[12]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppVertexShader);
	}

	/// <inheritdoc cref="ID3D11Device.CreateGeometryShader" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult CreateGeometryShader(void* pShaderBytecode, nuint BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11GeometryShader** ppGeometryShader)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, void*, nuint, ID3D11ClassLinkage*, ID3D11GeometryShader**, int>)(lpVtbl[13]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppGeometryShader);
	}

	/// <inheritdoc cref="ID3D11Device.CreateGeometryShaderWithStreamOutput" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult CreateGeometryShaderWithStreamOutput(void* pShaderBytecode, nuint BytecodeLength, SODeclarationEntry* pSODeclaration, uint NumEntries, uint* pBufferStrides, uint NumStrides, uint RasterizedStream, ID3D11ClassLinkage* pClassLinkage, ID3D11GeometryShader** ppGeometryShader)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, void*, nuint, SODeclarationEntry*, uint, uint*, uint, uint, ID3D11ClassLinkage*, ID3D11GeometryShader**, int>)(lpVtbl[14]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pSODeclaration, NumEntries, pBufferStrides, NumStrides, RasterizedStream, pClassLinkage, ppGeometryShader);
	}

	/// <inheritdoc cref="ID3D11Device.CreatePixelShader" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult CreatePixelShader(void* pShaderBytecode, nuint BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11PixelShader** ppPixelShader)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, void*, nuint, ID3D11ClassLinkage*, ID3D11PixelShader**, int>)(lpVtbl[15]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppPixelShader);
	}

	/// <inheritdoc cref="ID3D11Device.CreateHullShader" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult CreateHullShader(void* pShaderBytecode, nuint BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11HullShader** ppHullShader)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, void*, nuint, ID3D11ClassLinkage*, ID3D11HullShader**, int>)(lpVtbl[16]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppHullShader);
	}

	/// <inheritdoc cref="ID3D11Device.CreateDomainShader" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult CreateDomainShader(void* pShaderBytecode, nuint BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11DomainShader** ppDomainShader)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, void*, nuint, ID3D11ClassLinkage*, ID3D11DomainShader**, int>)(lpVtbl[17]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppDomainShader);
	}

	/// <inheritdoc cref="ID3D11Device.CreateComputeShader" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult CreateComputeShader(void* pShaderBytecode, nuint BytecodeLength, ID3D11ClassLinkage* pClassLinkage, ID3D11ComputeShader** ppComputeShader)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, void*, nuint, ID3D11ClassLinkage*, ID3D11ComputeShader**, int>)(lpVtbl[18]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppComputeShader);
	}

	/// <inheritdoc cref="ID3D11Device.CreateClassLinkage" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult CreateClassLinkage(ID3D11ClassLinkage** ppLinkage)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, ID3D11ClassLinkage**, int>)(lpVtbl[19]))((ID3D11Device3*)Unsafe.AsPointer(ref this), ppLinkage);
	}

	/// <inheritdoc cref="ID3D11Device.CreateBlendState" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult CreateBlendState(BlendDescription* pBlendStateDesc, ID3D11BlendState** ppBlendState)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, BlendDescription*, ID3D11BlendState**, int>)(lpVtbl[20]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pBlendStateDesc, ppBlendState);
	}

	/// <inheritdoc cref="ID3D11Device.CreateDepthStencilState" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult CreateDepthStencilState(DepthStencilDescription* pDepthStencilDesc, ID3D11DepthStencilState** ppDepthStencilState)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, DepthStencilDescription*, ID3D11DepthStencilState**, int>)(lpVtbl[21]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pDepthStencilDesc, ppDepthStencilState);
	}

	/// <inheritdoc cref="ID3D11Device.CreateRasterizerState" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult CreateRasterizerState(RasterizerDescription* pRasterizerDesc, ID3D11RasterizerState** ppRasterizerState)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, RasterizerDescription*, ID3D11RasterizerState**, int>)(lpVtbl[22]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pRasterizerDesc, ppRasterizerState);
	}

	/// <inheritdoc cref="ID3D11Device.CreateSamplerState" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public HResult CreateSamplerState(SamplerDescription* pSamplerDesc, ID3D11SamplerState** ppSamplerState)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, SamplerDescription*, ID3D11SamplerState**, int>)(lpVtbl[23]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pSamplerDesc, ppSamplerState);
	}

	/// <inheritdoc cref="ID3D11Device.CreateQuery" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult CreateQuery(QueryDescription* pQueryDesc, ID3D11Query** ppQuery)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, QueryDescription*, ID3D11Query**, int>)(lpVtbl[24]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pQueryDesc, ppQuery);
	}

	/// <inheritdoc cref="ID3D11Device.CreatePredicate" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public HResult CreatePredicate(QueryDescription* pPredicateDesc, ID3D11Predicate** ppPredicate)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, QueryDescription*, ID3D11Predicate**, int>)(lpVtbl[25]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pPredicateDesc, ppPredicate);
	}

	/// <inheritdoc cref="ID3D11Device.CreateCounter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public HResult CreateCounter(CounterDescription* pCounterDesc, ID3D11Counter** ppCounter)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, CounterDescription*, ID3D11Counter**, int>)(lpVtbl[26]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pCounterDesc, ppCounter);
	}

	/// <inheritdoc cref="ID3D11Device.CreateDeferredContext" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(27)]
	public HResult CreateDeferredContext(uint ContextFlags, ID3D11DeviceContext** ppDeferredContext)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, uint, ID3D11DeviceContext**, int>)(lpVtbl[27]))((ID3D11Device3*)Unsafe.AsPointer(ref this), ContextFlags, ppDeferredContext);
	}

	/// <inheritdoc cref="ID3D11Device.OpenSharedResource" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(28)]
	public HResult OpenSharedResource(Handle hResource, Guid* ReturnedInterface, void** ppResource)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, Handle, Guid*, void**, int>)(lpVtbl[28]))((ID3D11Device3*)Unsafe.AsPointer(ref this), hResource, ReturnedInterface, ppResource);
	}

	/// <inheritdoc cref="ID3D11Device.CheckFormatSupport" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(29)]
	public HResult CheckFormatSupport(Graphics.Dxgi.Common.Format Format, uint* pFormatSupport)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, Graphics.Dxgi.Common.Format, uint*, int>)(lpVtbl[29]))((ID3D11Device3*)Unsafe.AsPointer(ref this), Format, pFormatSupport);
	}

	/// <inheritdoc cref="ID3D11Device.CheckMultisampleQualityLevels" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(30)]
	public HResult CheckMultisampleQualityLevels(Graphics.Dxgi.Common.Format Format, uint SampleCount, uint* pNumQualityLevels)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, Graphics.Dxgi.Common.Format, uint, uint*, int>)(lpVtbl[30]))((ID3D11Device3*)Unsafe.AsPointer(ref this), Format, SampleCount, pNumQualityLevels);
	}

	/// <inheritdoc cref="ID3D11Device.CheckCounterInfo" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(31)]
	public void CheckCounterInfo(CounterInfo* pCounterInfo)
	{
		((delegate* unmanaged[Stdcall]<ID3D11Device3*, CounterInfo*, void>)(lpVtbl[31]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pCounterInfo);
	}

	/// <inheritdoc cref="ID3D11Device.CheckCounter" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(32)]
	public HResult CheckCounter(CounterDescription* pDesc, CounterType* pType, uint* pActiveCounters, byte* szName, uint* pNameLength, byte* szUnits, uint* pUnitsLength, byte* szDescription, uint* pDescriptionLength)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, CounterDescription*, CounterType*, uint*, byte*, uint*, byte*, uint*, byte*, uint*, int>)(lpVtbl[32]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pDesc, pType, pActiveCounters, szName, pNameLength, szUnits, pUnitsLength, szDescription, pDescriptionLength);
	}

	/// <inheritdoc cref="ID3D11Device.CheckFeatureSupport" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(33)]
	public HResult CheckFeatureSupport(Feature Feature, void* pFeatureSupportData, uint FeatureSupportDataSize)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, Feature, void*, uint, int>)(lpVtbl[33]))((ID3D11Device3*)Unsafe.AsPointer(ref this), Feature, pFeatureSupportData, FeatureSupportDataSize);
	}

	/// <inheritdoc cref="ID3D11Device.GetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(34)]
	public HResult GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, Guid*, uint*, void*, int>)(lpVtbl[34]))((ID3D11Device3*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
	}

	/// <inheritdoc cref="ID3D11Device.SetPrivateData" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(35)]
	public HResult SetPrivateData(Guid* guid, uint DataSize, void* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, Guid*, uint, void*, int>)(lpVtbl[35]))((ID3D11Device3*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
	}

	/// <inheritdoc cref="ID3D11Device.SetPrivateDataInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(36)]
	public HResult SetPrivateDataInterface(Guid* guid, IUnknown* pData)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, Guid*, IUnknown*, int>)(lpVtbl[36]))((ID3D11Device3*)Unsafe.AsPointer(ref this), guid, pData);
	}

	/// <inheritdoc cref="ID3D11Device.GetFeatureLevel" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(37)]
	public Graphics.Direct3D.FeatureLevel GetFeatureLevel()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, Graphics.Direct3D.FeatureLevel>)(lpVtbl[37]))((ID3D11Device3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D11Device.GetCreationFlags" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(38)]
	public uint GetCreationFlags()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, uint>)(lpVtbl[38]))((ID3D11Device3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D11Device.GetDeviceRemovedReason" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(39)]
	public HResult GetDeviceRemovedReason()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, int>)(lpVtbl[39]))((ID3D11Device3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D11Device.GetImmediateContext" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(40)]
	public void GetImmediateContext(ID3D11DeviceContext** ppImmediateContext)
	{
		((delegate* unmanaged[Stdcall]<ID3D11Device3*, ID3D11DeviceContext**, void>)(lpVtbl[40]))((ID3D11Device3*)Unsafe.AsPointer(ref this), ppImmediateContext);
	}

	/// <inheritdoc cref="ID3D11Device.SetExceptionMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(41)]
	public HResult SetExceptionMode(uint RaiseFlags)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, uint, int>)(lpVtbl[41]))((ID3D11Device3*)Unsafe.AsPointer(ref this), RaiseFlags);
	}

	/// <inheritdoc cref="ID3D11Device.GetExceptionMode" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(42)]
	public uint GetExceptionMode()
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, uint>)(lpVtbl[42]))((ID3D11Device3*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="ID3D11Device1.GetImmediateContext1" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(43)]
	public void GetImmediateContext1(ID3D11DeviceContext1** ppImmediateContext)
	{
		((delegate* unmanaged[Stdcall]<ID3D11Device3*, ID3D11DeviceContext1**, void>)(lpVtbl[43]))((ID3D11Device3*)Unsafe.AsPointer(ref this), ppImmediateContext);
	}

	/// <inheritdoc cref="ID3D11Device1.CreateDeferredContext1" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(44)]
	public HResult CreateDeferredContext1(uint ContextFlags, ID3D11DeviceContext1** ppDeferredContext)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, uint, ID3D11DeviceContext1**, int>)(lpVtbl[44]))((ID3D11Device3*)Unsafe.AsPointer(ref this), ContextFlags, ppDeferredContext);
	}

	/// <inheritdoc cref="ID3D11Device1.CreateBlendState1" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(45)]
	public HResult CreateBlendState1(BlendDescription1* pBlendStateDesc, ID3D11BlendState1** ppBlendState)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, BlendDescription1*, ID3D11BlendState1**, int>)(lpVtbl[45]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pBlendStateDesc, ppBlendState);
	}

	/// <inheritdoc cref="ID3D11Device1.CreateRasterizerState1" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(46)]
	public HResult CreateRasterizerState1(RasterizerDescription1* pRasterizerDesc, ID3D11RasterizerState1** ppRasterizerState)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, RasterizerDescription1*, ID3D11RasterizerState1**, int>)(lpVtbl[46]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pRasterizerDesc, ppRasterizerState);
	}

	/// <inheritdoc cref="ID3D11Device1.CreateDeviceContextState" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(47)]
	public HResult CreateDeviceContextState(uint Flags, Graphics.Direct3D.FeatureLevel* pFeatureLevels, uint FeatureLevels, uint SDKVersion, Guid* EmulatedInterface, Graphics.Direct3D.FeatureLevel* pChosenFeatureLevel, ID3DDeviceContextState** ppContextState)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, uint, Graphics.Direct3D.FeatureLevel*, uint, uint, Guid*, Graphics.Direct3D.FeatureLevel*, ID3DDeviceContextState**, int>)(lpVtbl[47]))((ID3D11Device3*)Unsafe.AsPointer(ref this), Flags, pFeatureLevels, FeatureLevels, SDKVersion, EmulatedInterface, pChosenFeatureLevel, ppContextState);
	}

	/// <inheritdoc cref="ID3D11Device1.OpenSharedResource1" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(48)]
	public HResult OpenSharedResource1(Handle hResource, Guid* returnedInterface, void** ppResource)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, Handle, Guid*, void**, int>)(lpVtbl[48]))((ID3D11Device3*)Unsafe.AsPointer(ref this), hResource, returnedInterface, ppResource);
	}

	/// <inheritdoc cref="ID3D11Device1.OpenSharedResourceByName" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(49)]
	public HResult OpenSharedResourceByName(ushort* lpName, uint dwDesiredAccess, Guid* returnedInterface, void** ppResource)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, ushort*, uint, Guid*, void**, int>)(lpVtbl[49]))((ID3D11Device3*)Unsafe.AsPointer(ref this), lpName, dwDesiredAccess, returnedInterface, ppResource);
	}

	/// <inheritdoc cref="ID3D11Device2.GetImmediateContext2" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(50)]
	public void GetImmediateContext2(ID3D11DeviceContext2** ppImmediateContext)
	{
		((delegate* unmanaged[Stdcall]<ID3D11Device3*, ID3D11DeviceContext2**, void>)(lpVtbl[50]))((ID3D11Device3*)Unsafe.AsPointer(ref this), ppImmediateContext);
	}

	/// <inheritdoc cref="ID3D11Device2.CreateDeferredContext2" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(51)]
	public HResult CreateDeferredContext2(uint ContextFlags, ID3D11DeviceContext2** ppDeferredContext)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, uint, ID3D11DeviceContext2**, int>)(lpVtbl[51]))((ID3D11Device3*)Unsafe.AsPointer(ref this), ContextFlags, ppDeferredContext);
	}

	/// <inheritdoc cref="ID3D11Device2.GetResourceTiling" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(52)]
	public void GetResourceTiling(ID3D11Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipDescription* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
	{
		((delegate* unmanaged[Stdcall]<ID3D11Device3*, ID3D11Resource*, uint*, PackedMipDescription*, TileShape*, uint*, uint, SubresourceTiling*, void>)(lpVtbl[52]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
	}

	/// <inheritdoc cref="ID3D11Device2.CheckMultisampleQualityLevels1" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(53)]
	public HResult CheckMultisampleQualityLevels1(Graphics.Dxgi.Common.Format Format, uint SampleCount, uint Flags, uint* pNumQualityLevels)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, Graphics.Dxgi.Common.Format, uint, uint, uint*, int>)(lpVtbl[53]))((ID3D11Device3*)Unsafe.AsPointer(ref this), Format, SampleCount, Flags, pNumQualityLevels);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Device3::CreateTexture2D1"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(54)]
	public HResult CreateTexture2D1(Texture2DDescription1* pDesc1, SubresourceData* pInitialData, ID3D11Texture2D1** ppTexture2D)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, Texture2DDescription1*, SubresourceData*, ID3D11Texture2D1**, int>)(lpVtbl[54]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pDesc1, pInitialData, ppTexture2D);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Device3::CreateTexture3D1"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(55)]
	public HResult CreateTexture3D1(Texture3DDescription1* pDesc1, SubresourceData* pInitialData, ID3D11Texture3D1** ppTexture3D)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, Texture3DDescription1*, SubresourceData*, ID3D11Texture3D1**, int>)(lpVtbl[55]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pDesc1, pInitialData, ppTexture3D);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Device3::CreateRasterizerState2"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(56)]
	public HResult CreateRasterizerState2(RasterizerDescription2* pRasterizerDesc, ID3D11RasterizerState2** ppRasterizerState)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, RasterizerDescription2*, ID3D11RasterizerState2**, int>)(lpVtbl[56]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pRasterizerDesc, ppRasterizerState);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Device3::CreateShaderResourceView1"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(57)]
	public HResult CreateShaderResourceView1(ID3D11Resource* pResource, ShaderResourceViewDescription1* pDesc1, ID3D11ShaderResourceView1** ppSRView1)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, ID3D11Resource*, ShaderResourceViewDescription1*, ID3D11ShaderResourceView1**, int>)(lpVtbl[57]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pResource, pDesc1, ppSRView1);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Device3::CreateUnorderedAccessView1"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(58)]
	public HResult CreateUnorderedAccessView1(ID3D11Resource* pResource, UnorderedAccessViewDescription1* pDesc1, ID3D11UnorderedAccessView1** ppUAView1)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, ID3D11Resource*, UnorderedAccessViewDescription1*, ID3D11UnorderedAccessView1**, int>)(lpVtbl[58]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pResource, pDesc1, ppUAView1);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Device3::CreateRenderTargetView1"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(59)]
	public HResult CreateRenderTargetView1(ID3D11Resource* pResource, RenderTargetViewDescription1* pDesc1, ID3D11RenderTargetView1** ppRTView1)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, ID3D11Resource*, RenderTargetViewDescription1*, ID3D11RenderTargetView1**, int>)(lpVtbl[59]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pResource, pDesc1, ppRTView1);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Device3::CreateQuery1"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(60)]
	public HResult CreateQuery1(QueryDescription1* pQueryDesc1, ID3D11Query1** ppQuery1)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, QueryDescription1*, ID3D11Query1**, int>)(lpVtbl[60]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pQueryDesc1, ppQuery1);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Device3::GetImmediateContext3"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(61)]
	public void GetImmediateContext3(ID3D11DeviceContext3** ppImmediateContext)
	{
		((delegate* unmanaged[Stdcall]<ID3D11Device3*, ID3D11DeviceContext3**, void>)(lpVtbl[61]))((ID3D11Device3*)Unsafe.AsPointer(ref this), ppImmediateContext);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Device3::CreateDeferredContext3"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(62)]
	public HResult CreateDeferredContext3(uint ContextFlags, ID3D11DeviceContext3** ppDeferredContext)
	{
		return ((delegate* unmanaged[Stdcall]<ID3D11Device3*, uint, ID3D11DeviceContext3**, int>)(lpVtbl[62]))((ID3D11Device3*)Unsafe.AsPointer(ref this), ContextFlags, ppDeferredContext);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Device3::WriteToSubresource"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(63)]
	public void WriteToSubresource(ID3D11Resource* pDstResource, uint DstSubresource, Box* pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
	{
		((delegate* unmanaged[Stdcall]<ID3D11Device3*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)(lpVtbl[63]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
	}

	/// <include file='../Direct3D11.xml' path='doc/member[@name="ID3D11Device3::ReadFromSubresource"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(64)]
	public void ReadFromSubresource(void* pDstData, uint DstRowPitch, uint DstDepthPitch, ID3D11Resource* pSrcResource, uint SrcSubresource, Box* pSrcBox)
	{
		((delegate* unmanaged[Stdcall]<ID3D11Device3*, void*, uint, uint, ID3D11Resource*, uint, Box*, void>)(lpVtbl[64]))((ID3D11Device3*)Unsafe.AsPointer(ref this), pDstData, DstRowPitch, DstDepthPitch, pSrcResource, SrcSubresource, pSrcBox);
	}
}
