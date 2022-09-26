// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D11;

public unsafe partial struct ID3D11Device
{
    public ComPtr<ID3D11Buffer> CreateBuffe(BufferDescription* description, SubresourceData* initialData = default)
    {
        using ComPtr<ID3D11Buffer> buffer = default;
        CreateBuffer(description, initialData, buffer.GetAddressOf()).ThrowIfFailed();
        return buffer.Move();
    }

    public ComPtr<ID3D11Buffer> CreateBuffer<T>(
        in T data,
        BufferDescription description) where T : unmanaged
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
            CreateBuffer(&description, &subresourceData, buffer.GetAddressOf()).ThrowIfFailed();
            return buffer.Move();
        }
    }

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
            CreateBuffer(&description, &subresourceData, buffer.GetAddressOf()).ThrowIfFailed();
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
            CreateBuffer(&description, &subresourceData, buffer.GetAddressOf()).ThrowIfFailed();
            return buffer.Move();
        }
    }

    public ComPtr<ID3D11RenderTargetView> CreateRenderTargetView(
        ID3D11Resource* resource,
        RenderTargetViewDescription* description)
    {
        using ComPtr<ID3D11RenderTargetView> view = default;
        CreateRenderTargetView(resource, description, view.GetAddressOf()).ThrowIfFailed();

        return view.Move();
    }

    public ComPtr<ID3D11DepthStencilView> CreateDepthStencilView(
        ID3D11Resource* resource,
        DepthStencilViewDescription* description)
    {
        using ComPtr<ID3D11DepthStencilView> view = default;
        CreateDepthStencilView(resource, description, view.GetAddressOf()).ThrowIfFailed();

        return view.Move();
    }

    public ComPtr<ID3D11ShaderResourceView> CreateShaderResourceView(
        ID3D11Resource* resource,
        ShaderResourceViewDescription* description)
    {
        using ComPtr<ID3D11ShaderResourceView> view = default;
        CreateShaderResourceView(resource, description, view.GetAddressOf()).ThrowIfFailed();

        return view.Move();
    }

    public ComPtr<ID3D11UnorderedAccessView> CreateUnorderedAccessView(
        ID3D11Resource* resource,
        UnorderedAccessViewDescription* description)
    {
        using ComPtr<ID3D11UnorderedAccessView> view = default;
        CreateUnorderedAccessView(resource, description, view.GetAddressOf()).ThrowIfFailed();

        return view.Move();
    }

    public ComPtr<ID3D11BlendState> CreateBlendState(BlendDescription* description)
    {
        using ComPtr<ID3D11BlendState> state = default;
        CreateBlendState(description, state.GetAddressOf()).ThrowIfFailed();

        return state.Move();
    }

    public ComPtr<ID3D11BlendState> CreateBlendState(BlendDescription description)
    {
        using ComPtr<ID3D11BlendState> state = default;
        CreateBlendState(&description, state.GetAddressOf()).ThrowIfFailed();

        return state.Move();
    }

    public ComPtr<ID3D11DepthStencilState> CreateDepthStencilState(DepthStencilDescription* description)
    {
        using ComPtr<ID3D11DepthStencilState> state = default;
        CreateDepthStencilState(description, state.GetAddressOf()).ThrowIfFailed();

        return state.Move();
    }

    public ComPtr<ID3D11DepthStencilState> CreateDepthStencilState(DepthStencilDescription description)
    {
        using ComPtr<ID3D11DepthStencilState> state = default;
        CreateDepthStencilState(&description, state.GetAddressOf()).ThrowIfFailed();

        return state.Move();
    }

    public ComPtr<ID3D11RasterizerState> CreateRasterizerState(RasterizerDescription* description)
    {
        using ComPtr<ID3D11RasterizerState> state = default;
        CreateRasterizerState(description, state.GetAddressOf()).ThrowIfFailed();

        return state.Move();
    }

    public ComPtr<ID3D11RasterizerState> CreateRasterizerState(RasterizerDescription description)
    {
        using ComPtr<ID3D11RasterizerState> state = default;
        CreateRasterizerState(&description, state.GetAddressOf()).ThrowIfFailed();

        return state.Move();
    }

    public ComPtr<ID3D11SamplerState> CreateSamplerState(SamplerDescription* description)
    {
        using ComPtr<ID3D11SamplerState> state = default;
        CreateSamplerState(description, state.GetAddressOf()).ThrowIfFailed();

        return state.Move();
    }

    public ComPtr<ID3D11SamplerState> CreateSamplerState(SamplerDescription description)
    {
        using ComPtr<ID3D11SamplerState> state = default;
        CreateSamplerState(&description, state.GetAddressOf()).ThrowIfFailed();

        return state.Move();
    }

    public ComPtr<ID3D11Texture1D> CreateTexture1D(Texture1DDescription* description, SubresourceData* initialData = default)
    {
        using ComPtr<ID3D11Texture1D> texture = default;
        CreateTexture1D(description, initialData, texture.GetAddressOf()).ThrowIfFailed();

        return texture.Move();
    }

    public ComPtr<ID3D11Texture1D> CreateTexture1D(Texture1DDescription description, SubresourceData* initialData = default)
    {
        using ComPtr<ID3D11Texture1D> texture = default;
        CreateTexture1D(&description, initialData, texture.GetAddressOf()).ThrowIfFailed();

        return texture.Move();
    }

    public ComPtr<ID3D11Texture2D> CreateTexture2D(Texture2DDescription* description, SubresourceData* initialData = default)
    {
        using ComPtr<ID3D11Texture2D> texture = default;
        CreateTexture2D(description, initialData, texture.GetAddressOf()).ThrowIfFailed();

        return texture.Move();
    }

    public ComPtr<ID3D11Texture2D> CreateTexture2D(Texture2DDescription description, SubresourceData* initialData = default)
    {
        using ComPtr<ID3D11Texture2D> texture = default;
        CreateTexture2D(&description, initialData, texture.GetAddressOf()).ThrowIfFailed();

        return texture.Move();
    }

    public ComPtr<ID3D11Texture3D> CreateTexture3D(Texture3DDescription* description, SubresourceData* initialData = default)
    {
        using ComPtr<ID3D11Texture3D> texture = default;
        CreateTexture3D(description, initialData, texture.GetAddressOf()).ThrowIfFailed();

        return texture.Move();
    }

    public ComPtr<ID3D11Texture3D> CreateTexture3D(Texture3DDescription description, SubresourceData* initialData = default)
    {
        using ComPtr<ID3D11Texture3D> texture = default;
        CreateTexture3D(&description, initialData, texture.GetAddressOf()).ThrowIfFailed();

        return texture.Move();
    }
}
