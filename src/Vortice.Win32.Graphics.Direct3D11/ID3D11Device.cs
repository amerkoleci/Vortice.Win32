// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Vortice.Win32.Graphics.Direct3D11;
using static Vortice.Win32.Graphics.D3D11;

namespace Vortice.Win32.Graphics;

public static unsafe class ID3D11DeviceExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TFeature CheckFeatureSupport<TD3D11Device, TFeature>(ref this TD3D11Device self, D3D11_FEATURE feature)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
        where TFeature : unmanaged
    {
        TFeature featureData = default;
        self.CheckFeatureSupport(feature, &featureData, sizeof(TFeature)).ThrowIfFailed();
        return featureData;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static HResult CheckFeatureSupport<TD3D11Device, TFeature>(ref this TD3D11Device self, D3D11_FEATURE feature, ref TFeature featureData)
       where TD3D11Device : unmanaged, ID3D11Device.Interface
       where TFeature : unmanaged
    {
        fixed (TFeature* featureDataPtr = &featureData)
        {
            return self.CheckFeatureSupport(feature, featureDataPtr, sizeof(TFeature));
        }
    }

    public static ComPtr<ID3D11Buffer> CreateBuffer<TD3D11Device>(ref this TD3D11Device self, D3D11_BUFFER_DESC* description, D3D11_SUBRESOURCE_DATA* initialData = default)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
    {
        using ComPtr<ID3D11Buffer> buffer = default;
        self.CreateBuffer(description, initialData, buffer.GetAddressOf()).ThrowIfFailed();
        return buffer.Move();
    }


    public static ComPtr<ID3D11Buffer> CreateBuffer<TD3D11Device, T>(
        ref this TD3D11Device self,
        in T data,
        D3D11_BUFFER_DESC description)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
        where T : unmanaged
    {
        if (description.ByteWidth == 0)
            description.ByteWidth = (uint)sizeof(T);

        fixed (T* dataPtr = &data)
        {
            D3D11_SUBRESOURCE_DATA subresourceData = new()
            {
                pSysMem = dataPtr
            };

            using ComPtr<ID3D11Buffer> buffer = default;
            self.CreateBuffer(&description, &subresourceData, buffer.GetAddressOf()).ThrowIfFailed();
            return buffer.Move();
        }
    }

    public static ComPtr<ID3D11Buffer> CreateBuffer<TD3D11Device, T>(
        ref this TD3D11Device self,
        ReadOnlySpan<T> data, D3D11_BUFFER_DESC description)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
        where T : unmanaged
    {
        if (description.ByteWidth == 0)
            description.ByteWidth = (uint)(sizeof(T) * data.Length);

        fixed (T* dataPtr = data)
        {
            D3D11_SUBRESOURCE_DATA subresourceData = new()
            {
                pSysMem = dataPtr
            };

            using ComPtr<ID3D11Buffer> buffer = default;
            self.CreateBuffer(&description, &subresourceData, buffer.GetAddressOf()).ThrowIfFailed();
            return buffer.Move();
        }
    }

    /// <summary>
    /// Creates a new instance of the <see cref="ID3D11Buffer"/> class.
    /// </summary>
    /// <typeparam name="TD3D11Device">ID3D11Device type</typeparam>
    /// <typeparam name="T">Type of the data to upload</typeparam>
    /// <param name="self">The instace type of <see cref="ID3D11Device"/>.</param>
    /// <param name="bindFlags">Flags specifying how the buffer will be bound to the pipeline.</param>
    /// <param name="data">Initial data used to initialize the buffer.</param>
    /// <param name="sizeInBytes">The size, in bytes, of the buffer. If 0 is specified, sizeof(T) * data.Length is used.</param>
    /// <param name="usage">The usage pattern for the buffer.</param>
    /// <param name="accessFlags">Flags specifying how the buffer will be accessible from the CPU.</param>
    /// <param name="miscFlags">Miscellaneous resource options.</param>
    /// <param name="structureByteStride">The size (in bytes) of the structure element for structured buffers.</param>
    /// <returns>An initialized buffer</returns>
    public static ComPtr<ID3D11Buffer> CreateBuffer<TD3D11Device, T>(
        ref this TD3D11Device self,
        ReadOnlySpan<T> data,
        D3D11_BIND_FLAG bindFlags,
        D3D11_USAGE usage = D3D11_USAGE_DEFAULT,
        D3D11_CPU_ACCESS_FLAG accessFlags = D3D11_CPU_ACCESS_FLAG_NONE,
        D3D11_RESOURCE_MISC_FLAG miscFlags = D3D11_RESOURCE_MISC_FLAG_NONE,
        uint sizeInBytes = 0,
        uint structureByteStride = 0)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
        where T : unmanaged
    {
        D3D11_BUFFER_DESC description = new()
        {
            ByteWidth = sizeInBytes == 0 ? (uint)(sizeof(T) * data.Length) : sizeInBytes,
            BindFlags = bindFlags,
            CPUAccessFlags = accessFlags,
            MiscFlags = miscFlags,
            Usage = usage,
            StructureByteStride = structureByteStride == 0 ? (uint)sizeof(T) : structureByteStride,
        };

        fixed (T* dataPtr = data)
        {
            D3D11_SUBRESOURCE_DATA subresourceData = new()
            {
                pSysMem = dataPtr
            };

            using ComPtr<ID3D11Buffer> buffer = default;
            self.CreateBuffer(&description, &subresourceData, buffer.GetAddressOf()).ThrowIfFailed();
            return buffer.Move();
        }
    }


    public static ComPtr<ID3D11DeviceContext> CreateDeferredContext<TD3D11Device>(ref this ID3D11Device self)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
    {
        using ComPtr<ID3D11DeviceContext> deferredContext = default;
        self.CreateDeferredContext(0u, deferredContext.GetAddressOf()).ThrowIfFailed();
        return deferredContext.Move();
    }

    public static ComPtr<ID3D11RenderTargetView> CreateRenderTargetView<TD3D11Device>(ref this ID3D11Device self,
        ID3D11Resource* resource,
        RenderTargetViewDescription* description)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
    {
        using ComPtr<ID3D11RenderTargetView> view = default;
        self.CreateRenderTargetView(resource, description, view.GetAddressOf()).ThrowIfFailed();
        return view.Move();
    }

    public static ComPtr<ID3D11DepthStencilView> CreateDepthStencilView<TD3D11Device>(ref this ID3D11Device self,
        ID3D11Resource* resource,
        DepthStencilViewDescription* description)
         where TD3D11Device : unmanaged, ID3D11Device.Interface
    {
        using ComPtr<ID3D11DepthStencilView> view = default;
        self.CreateDepthStencilView(resource, description, view.GetAddressOf()).ThrowIfFailed();

        return view.Move();
    }

    public static ComPtr<ID3D11ShaderResourceView> CreateShaderResourceView<TD3D11Device>(ref this ID3D11Device self,
        ID3D11Resource* resource,
        ShaderResourceViewDescription* description)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
    {
        using ComPtr<ID3D11ShaderResourceView> view = default;
        self.CreateShaderResourceView(resource, description, view.GetAddressOf()).ThrowIfFailed();

        return view.Move();
    }

    public static ComPtr<ID3D11UnorderedAccessView> CreateUnorderedAccessView<TD3D11Device>(ref this ID3D11Device self,
        ID3D11Resource* resource,
        UnorderedAccessViewDescription* description)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
    {
        using ComPtr<ID3D11UnorderedAccessView> view = default;
        self.CreateUnorderedAccessView(resource, description, view.GetAddressOf()).ThrowIfFailed();

        return view.Move();
    }

    public static ComPtr<ID3D11BlendState> CreateBlendState<TD3D11Device>(ref this ID3D11Device self, BlendDescription* description)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
    {
        using ComPtr<ID3D11BlendState> state = default;
        self.CreateBlendState(description, state.GetAddressOf()).ThrowIfFailed();

        return state.Move();
    }

    public static ComPtr<ID3D11BlendState> CreateBlendState<TD3D11Device>(ref this ID3D11Device self, BlendDescription description)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
    {
        using ComPtr<ID3D11BlendState> state = default;
        self.CreateBlendState(&description, state.GetAddressOf()).ThrowIfFailed();

        return state.Move();
    }

    public static ComPtr<ID3D11DepthStencilState> CreateDepthStencilState<TD3D11Device>(ref this ID3D11Device self, DepthStencilDescription* description)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
    {
        using ComPtr<ID3D11DepthStencilState> state = default;
        self.CreateDepthStencilState(description, state.GetAddressOf()).ThrowIfFailed();

        return state.Move();
    }

    public static ComPtr<ID3D11DepthStencilState> CreateDepthStencilState<TD3D11Device>(ref this ID3D11Device self, DepthStencilDescription description)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
    {
        using ComPtr<ID3D11DepthStencilState> state = default;
        self.CreateDepthStencilState(&description, state.GetAddressOf()).ThrowIfFailed();

        return state.Move();
    }

    public static ComPtr<ID3D11RasterizerState> CreateRasterizerState<TD3D11Device>(ref this ID3D11Device self, RasterizerDescription* description)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
    {
        using ComPtr<ID3D11RasterizerState> state = default;
        self.CreateRasterizerState(description, state.GetAddressOf()).ThrowIfFailed();

        return state.Move();
    }

    public static ComPtr<ID3D11RasterizerState> CreateRasterizerState<TD3D11Device>(ref this ID3D11Device self, D3D11_RASTERIZER_DESC description)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
    {
        using ComPtr<ID3D11RasterizerState> state = default;
        self.CreateRasterizerState(&description, state.GetAddressOf()).ThrowIfFailed();

        return state.Move();
    }

    public static ComPtr<ID3D11SamplerState> CreateSamplerState<TD3D11Device>(ref this ID3D11Device self, D3D11_SAMPLER_DESC* description)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
    {
        using ComPtr<ID3D11SamplerState> state = default;
        self.CreateSamplerState(description, state.GetAddressOf()).ThrowIfFailed();

        return state.Move();
    }

    public static ComPtr<ID3D11SamplerState> CreateSamplerState<TD3D11Device>(ref this ID3D11Device self, D3D11_SAMPLER_DESC description)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
    {
        using ComPtr<ID3D11SamplerState> state = default;
        self.CreateSamplerState(&description, state.GetAddressOf()).ThrowIfFailed(  );

        return state.Move();
    }

    public static ComPtr<ID3D11Texture1D> CreateTexture1D<TD3D11Device>(ref this TD3D11Device self, Texture1DDescription* description, D3D11_SUBRESOURCE_DATA* initialData = default)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
    {
        using ComPtr<ID3D11Texture1D> texture = default;
        self.CreateTexture1D(description, initialData, texture.GetAddressOf()).ThrowIfFailed();

        return texture.Move();
    }

    public static ComPtr<ID3D11Texture1D> CreateTexture1D<TD3D11Device>(ref this TD3D11Device self, Texture1DDescription description, D3D11_SUBRESOURCE_DATA* initialData = default)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
    {
        using ComPtr<ID3D11Texture1D> texture = default;
        self.CreateTexture1D(&description, initialData, texture.GetAddressOf()).ThrowIfFailed();

        return texture.Move();
    }

    public static ComPtr<ID3D11Texture2D> CreateTexture2D<TD3D11Device>(ref this TD3D11Device self, Texture2DDescription* description, D3D11_SUBRESOURCE_DATA* initialData = default)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
    {
        using ComPtr<ID3D11Texture2D> texture = default;
        self.CreateTexture2D(description, initialData, texture.GetAddressOf()).ThrowIfFailed();

        return texture.Move();
    }

    public static ComPtr<ID3D11Texture2D> CreateTexture2D<TD3D11Device>(ref this TD3D11Device self, Texture2DDescription description, D3D11_SUBRESOURCE_DATA* initialData = default)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
    {
        using ComPtr<ID3D11Texture2D> texture = default;
        self.CreateTexture2D(&description, initialData, texture.GetAddressOf()).ThrowIfFailed();

        return texture.Move();
    }

    public static ComPtr<ID3D11Texture3D> CreateTexture3D<TD3D11Device>(ref this TD3D11Device self, Texture3DDescription* description, D3D11_SUBRESOURCE_DATA* initialData = default)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
    {
        using ComPtr<ID3D11Texture3D> texture = default;
        self.CreateTexture3D(description, initialData, texture.GetAddressOf()).ThrowIfFailed();

        return texture.Move();
    }

    public static ComPtr<ID3D11Texture3D> CreateTexture3D<TD3D11Device>(ref this TD3D11Device self, Texture3DDescription description, D3D11_SUBRESOURCE_DATA* initialData = default)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
    {
        using ComPtr<ID3D11Texture3D> texture = default;
        self.CreateTexture3D(&description, initialData, texture.GetAddressOf()).ThrowIfFailed();

        return texture.Move();
    }

    public static HResult CreateVertexShader<TD3D11Device>(ref this TD3D11Device self, ReadOnlySpan<byte> shaderBytecode, ID3D11ClassLinkage* pClassLinkage, ID3D11VertexShader** ppVertexShader)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
    {
        fixed (byte* pShaderBytecode = shaderBytecode)
        {
            return self.CreateVertexShader(pShaderBytecode, (nuint)shaderBytecode.Length, pClassLinkage, ppVertexShader);
        }
    }

    public static ComPtr<ID3D11VertexShader> CreateVertexShader<TD3D11Device>(ref this TD3D11Device self,
        ReadOnlySpan<byte> shaderBytecode,
        ID3D11ClassLinkage* classLinkage = default)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
    {
        using ComPtr<ID3D11VertexShader> shader = default;
        fixed (byte* pShaderBytecode = shaderBytecode)
        {
            self.CreateVertexShader(pShaderBytecode, (nuint)shaderBytecode.Length, classLinkage, shader.GetAddressOf()).ThrowIfFailed();
        }

        return shader.Move();
    }

    public static HResult CreatePixelShader<TD3D11Device>(ref this TD3D11Device self, ReadOnlySpan<byte> shaderBytecode, ID3D11ClassLinkage* pClassLinkage, ID3D11PixelShader** ppPixelShader)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
    {
        fixed (byte* pShaderBytecode = shaderBytecode)
        {
            return self.CreatePixelShader(pShaderBytecode, (nuint)shaderBytecode.Length, pClassLinkage, ppPixelShader);
        }
    }

    public static ComPtr<ID3D11PixelShader> CreatePixelShader<TD3D11Device>(ref this TD3D11Device self,
        ReadOnlySpan<byte> shaderBytecode,
        ID3D11ClassLinkage* classLinkage = default)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
    {
        using ComPtr<ID3D11PixelShader> shader = default;
        fixed (byte* pShaderBytecode = shaderBytecode)
        {
            self.CreatePixelShader(pShaderBytecode, (nuint)shaderBytecode.Length, classLinkage, shader.GetAddressOf()).ThrowIfFailed();
        }

        return shader.Move();
    }

    public static HResult CreateComputeShader<TD3D11Device>(ref this TD3D11Device self, ReadOnlySpan<byte> shaderBytecode, ID3D11ClassLinkage* pClassLinkage, ID3D11ComputeShader** ppComputeShader)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
    {
        fixed (byte* pShaderBytecode = shaderBytecode)
        {
            return self.CreateComputeShader(pShaderBytecode, (nuint)shaderBytecode.Length, pClassLinkage, ppComputeShader);
        }
    }

    public static ComPtr<ID3D11ComputeShader> CreateComputeShader<TD3D11Device>(ref this TD3D11Device self,
        ReadOnlySpan<byte> shaderBytecode,
        ID3D11ClassLinkage* classLinkage = default)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
    {
        using ComPtr<ID3D11ComputeShader> shader = default;
        fixed (byte* pShaderBytecode = shaderBytecode)
        {
            self.CreateComputeShader(pShaderBytecode, (nuint)shaderBytecode.Length, classLinkage, shader.GetAddressOf()).ThrowIfFailed();
        }

        return shader.Move();
    }

    public static HResult CreateInputLayout<TD3D11Device>(ref this TD3D11Device self,
        ReadOnlySpan<D3D11_INPUT_ELEMENT_DESC> inputElements,
        ReadOnlySpan<byte> shaderBytecode,
        ID3D11InputLayout** ppInputLayout)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
    {
        fixed (D3D11_INPUT_ELEMENT_DESC* pInputElements = inputElements)
        fixed (byte* pShaderBytecode = shaderBytecode)
        {
            return self.CreateInputLayout(
                pInputElements, (uint)inputElements.Length,
                pShaderBytecode, (nuint)shaderBytecode.Length,
                ppInputLayout);
        }
    }

    public static HResult CreateInputLayout<TD3D11Device>(ref this TD3D11Device self,
        ReadOnlySpan<D3D11_INPUT_ELEMENT_DESC> inputElements,
        uint inputElementsCount,
        ReadOnlySpan<byte> shaderBytecode,
        ID3D11InputLayout** ppInputLayout)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
    {
        fixed (D3D11_INPUT_ELEMENT_DESC* pInputElements = inputElements)
        fixed (byte* pShaderBytecode = shaderBytecode)
        {
            return self.CreateInputLayout(
                pInputElements, inputElementsCount,
                pShaderBytecode, (nuint)shaderBytecode.Length,
                ppInputLayout);
        }
    }

    public static ComPtr<ID3D11InputLayout> CreateInputLayout<TD3D11Device>(ref this TD3D11Device self,
        ReadOnlySpan<D3D11_INPUT_ELEMENT_DESC> inputElements,
        ReadOnlySpan<byte> shaderBytecode)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
    {
        using ComPtr<ID3D11InputLayout> inputLayout = default;

        fixed (D3D11_INPUT_ELEMENT_DESC* pInputElements = inputElements)
        fixed (byte* pShaderBytecode = shaderBytecode)
        {
            self.CreateInputLayout(
                pInputElements, (uint)inputElements.Length,
                pShaderBytecode, (nuint)shaderBytecode.Length,
                inputLayout.GetAddressOf())
                .ThrowIfFailed();
        }

        return inputLayout.Move();
    }

    public static ComPtr<ID3D11InputLayout> CreateInputLayout<TD3D11Device>(ref this TD3D11Device self,
        ReadOnlySpan<D3D11_INPUT_ELEMENT_DESC> inputElements,
        uint inputElementsCount,
        ReadOnlySpan<byte> shaderBytecode)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
    {
        using ComPtr<ID3D11InputLayout> inputLayout = default;

        fixed (D3D11_INPUT_ELEMENT_DESC* pInputElements = inputElements)
        fixed (byte* pShaderBytecode = shaderBytecode)
        {
            self.CreateInputLayout(
                pInputElements, inputElementsCount,
                pShaderBytecode, (nuint)shaderBytecode.Length,
                inputLayout.GetAddressOf())
                .ThrowIfFailed();
        }

        return inputLayout.Move();
    }
}
