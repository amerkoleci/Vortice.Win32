// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Win32.Apis;

namespace Win32.Graphics.Direct3D11;

public static unsafe class ID3D11DeviceExtension
{
    public static ComPtr<ID3D11Buffer> CheckFeatureSupport<TD3D11Device>(ref this ID3D11Device self, BufferDescription* description, SubresourceData* initialData = default)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
    {
        using ComPtr<ID3D11Buffer> buffer = default;
        ThrowIfFailed(self.CreateBuffer(description, initialData, buffer.GetAddressOf()));
        return buffer.Move();
    }

    public static ComPtr<ID3D11Buffer> CreateBuffer<TD3D11Device, T>(
        ref this ID3D11Device self,
        in T data,
        BufferDescription description)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
        where T : unmanaged
    {
        if (description.ByteWidth == 0)
            description.ByteWidth = (uint)sizeof(T);

        fixed (T* dataPtr = &data)
        {
            SubresourceData subresourceData = new()
            {
                pSysMem = dataPtr
            };

            using ComPtr<ID3D11Buffer> buffer = default;
            ThrowIfFailed(self.CreateBuffer(&description, &subresourceData, buffer.GetAddressOf()));
            return buffer.Move();
        }
    }

    public static ComPtr<ID3D11DeviceContext> CreateDeferredContext<TD3D11Device>(ref this ID3D11Device self)
        where TD3D11Device : unmanaged, ID3D11Device.Interface
    {
        using ComPtr<ID3D11DeviceContext> deferredContext = default;
        ThrowIfFailed(self.CreateDeferredContext(0u, deferredContext.GetAddressOf()));
        return deferredContext.Move();
    }
}


public unsafe partial struct ID3D11Device
{

    public ComPtr<ID3D11Buffer> CreateBuffer<T>(ReadOnlySpan<T> data, BufferDescription description) where T : unmanaged
    {
        if (description.ByteWidth == 0)
            description.ByteWidth = (uint)(sizeof(T) * data.Length);

        fixed (T* dataPtr = data)
        {
            SubresourceData subresourceData = new()
            {
                pSysMem = dataPtr
            };

            using ComPtr<ID3D11Buffer> buffer = default;
            ThrowIfFailed(CreateBuffer(&description, &subresourceData, buffer.GetAddressOf()));
            return buffer.Move();
        }
    }

    /// <summary>
    /// Creates a new instance of the <see cref="ID3D11Buffer"/> class.
    /// </summary>
    /// <typeparam name="T">Type of the data to upload</typeparam>
    /// <param name="bindFlags">Flags specifying how the buffer will be bound to the pipeline.</param>
    /// <param name="data">Initial data used to initialize the buffer.</param>
    /// <param name="sizeInBytes">The size, in bytes, of the buffer. If 0 is specified, sizeof(T) * data.Length is used.</param>
    /// <param name="usage">The usage pattern for the buffer.</param>
    /// <param name="accessFlags">Flags specifying how the buffer will be accessible from the CPU.</param>
    /// <param name="miscFlags">Miscellaneous resource options.</param>
    /// <param name="structureByteStride">The size (in bytes) of the structure element for structured buffers.</param>
    /// <returns>An initialized buffer</returns>
    public ComPtr<ID3D11Buffer> CreateBuffer<T>(
        ReadOnlySpan<T> data,
        BindFlags bindFlags,
        Usage usage = Usage.Default,
        CpuAccessFlags accessFlags = CpuAccessFlags.None,
        ResourceMiscFlags miscFlags = ResourceMiscFlags.None,
        uint sizeInBytes = 0,
        uint structureByteStride = 0) where T : unmanaged
    {
        BufferDescription description = new()
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
            SubresourceData subresourceData = new()
            {
                pSysMem = dataPtr
            };

            using ComPtr<ID3D11Buffer> buffer = default;
            ThrowIfFailed(CreateBuffer(&description, &subresourceData, buffer.GetAddressOf()));
            return buffer.Move();
        }
    }

    public ComPtr<ID3D11RenderTargetView> CreateRenderTargetView(
        ID3D11Resource* resource,
        RenderTargetViewDescription* description)
    {
        using ComPtr<ID3D11RenderTargetView> view = default;
        ThrowIfFailed(CreateRenderTargetView(resource, description, view.GetAddressOf()));

        return view.Move();
    }

    public ComPtr<ID3D11DepthStencilView> CreateDepthStencilView(
        ID3D11Resource* resource,
        DepthStencilViewDescription* description)
    {
        using ComPtr<ID3D11DepthStencilView> view = default;
        ThrowIfFailed(CreateDepthStencilView(resource, description, view.GetAddressOf()));

        return view.Move();
    }

    public ComPtr<ID3D11ShaderResourceView> CreateShaderResourceView(
        ID3D11Resource* resource,
        ShaderResourceViewDescription* description)
    {
        using ComPtr<ID3D11ShaderResourceView> view = default;
        ThrowIfFailed(CreateShaderResourceView(resource, description, view.GetAddressOf()));

        return view.Move();
    }

    public ComPtr<ID3D11UnorderedAccessView> CreateUnorderedAccessView(
        ID3D11Resource* resource,
        UnorderedAccessViewDescription* description)
    {
        using ComPtr<ID3D11UnorderedAccessView> view = default;
        ThrowIfFailed(CreateUnorderedAccessView(resource, description, view.GetAddressOf()));

        return view.Move();
    }

    public ComPtr<ID3D11BlendState> CreateBlendState(BlendDescription* description)
    {
        using ComPtr<ID3D11BlendState> state = default;
        ThrowIfFailed(CreateBlendState(description, state.GetAddressOf()));

        return state.Move();
    }

    public ComPtr<ID3D11BlendState> CreateBlendState(BlendDescription description)
    {
        using ComPtr<ID3D11BlendState> state = default;
        ThrowIfFailed(CreateBlendState(&description, state.GetAddressOf()));

        return state.Move();
    }

    public ComPtr<ID3D11DepthStencilState> CreateDepthStencilState(DepthStencilDescription* description)
    {
        using ComPtr<ID3D11DepthStencilState> state = default;
        ThrowIfFailed(CreateDepthStencilState(description, state.GetAddressOf()));

        return state.Move();
    }

    public ComPtr<ID3D11DepthStencilState> CreateDepthStencilState(DepthStencilDescription description)
    {
        using ComPtr<ID3D11DepthStencilState> state = default;
        ThrowIfFailed(CreateDepthStencilState(&description, state.GetAddressOf()));

        return state.Move();
    }

    public ComPtr<ID3D11RasterizerState> CreateRasterizerState(RasterizerDescription* description)
    {
        using ComPtr<ID3D11RasterizerState> state = default;
        ThrowIfFailed(CreateRasterizerState(description, state.GetAddressOf()));

        return state.Move();
    }

    public ComPtr<ID3D11RasterizerState> CreateRasterizerState(RasterizerDescription description)
    {
        using ComPtr<ID3D11RasterizerState> state = default;
        ThrowIfFailed(CreateRasterizerState(&description, state.GetAddressOf()));

        return state.Move();
    }

    public ComPtr<ID3D11SamplerState> CreateSamplerState(SamplerDescription* description)
    {
        using ComPtr<ID3D11SamplerState> state = default;
        ThrowIfFailed(CreateSamplerState(description, state.GetAddressOf()));

        return state.Move();
    }

    public ComPtr<ID3D11SamplerState> CreateSamplerState(SamplerDescription description)
    {
        using ComPtr<ID3D11SamplerState> state = default;
        ThrowIfFailed(CreateSamplerState(&description, state.GetAddressOf()));

        return state.Move();
    }

    public ComPtr<ID3D11Texture1D> CreateTexture1D(Texture1DDescription* description, SubresourceData* initialData = default)
    {
        using ComPtr<ID3D11Texture1D> texture = default;
        ThrowIfFailed(CreateTexture1D(description, initialData, texture.GetAddressOf()));

        return texture.Move();
    }

    public ComPtr<ID3D11Texture1D> CreateTexture1D(Texture1DDescription description, SubresourceData* initialData = default)
    {
        using ComPtr<ID3D11Texture1D> texture = default;
        ThrowIfFailed(CreateTexture1D(&description, initialData, texture.GetAddressOf()));

        return texture.Move();
    }

    public ComPtr<ID3D11Texture2D> CreateTexture2D(Texture2DDescription* description, SubresourceData* initialData = default)
    {
        using ComPtr<ID3D11Texture2D> texture = default;
        ThrowIfFailed(CreateTexture2D(description, initialData, texture.GetAddressOf()));

        return texture.Move();
    }

    public ComPtr<ID3D11Texture2D> CreateTexture2D(Texture2DDescription description, SubresourceData* initialData = default)
    {
        using ComPtr<ID3D11Texture2D> texture = default;
        ThrowIfFailed(CreateTexture2D(&description, initialData, texture.GetAddressOf()));

        return texture.Move();
    }

    public ComPtr<ID3D11Texture3D> CreateTexture3D(Texture3DDescription* description, SubresourceData* initialData = default)
    {
        using ComPtr<ID3D11Texture3D> texture = default;
        ThrowIfFailed(CreateTexture3D(description, initialData, texture.GetAddressOf()));

        return texture.Move();
    }

    public ComPtr<ID3D11Texture3D> CreateTexture3D(Texture3DDescription description, SubresourceData* initialData = default)
    {
        using ComPtr<ID3D11Texture3D> texture = default;
        ThrowIfFailed(CreateTexture3D(&description, initialData, texture.GetAddressOf()));

        return texture.Move();
    }
}
