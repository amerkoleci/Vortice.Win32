// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D11;

/// <summary>
/// A <see langword="class"/> with extensions for the <see cref="ID3D11Device"/> type.
/// </summary>
public static unsafe class ID3D11DeviceExtensions
{
    public static ComPtr<ID3D11Buffer> CreateBuffer<T>(
        this ref ID3D11Device device,
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
            device.CreateBuffer(&description, &subresourceData, buffer.GetAddressOf()).ThrowIfFailed();
            return buffer.Move();
        }
    }

    public static ComPtr<ID3D11Buffer> CreateBuffer<T>(this ref ID3D11Device device, ReadOnlySpan<T> data, BufferDescription description) where T : unmanaged
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
            device.CreateBuffer(&description, &subresourceData, buffer.GetAddressOf()).ThrowIfFailed();
            return buffer.Move();
        }
    }

    /// <summary>
    /// Creates a new instance of the <see cref="ID3D11Buffer"/> class.
    /// </summary>
    /// <typeparam name="T">Type of the data to upload</typeparam>
    /// <param name="device">The <see cref="ID3D11Device"/> instance.</param>
    /// <param name="bindFlags">Flags specifying how the buffer will be bound to the pipeline.</param>
    /// <param name="data">Initial data used to initialize the buffer.</param>
    /// <param name="sizeInBytes">The size, in bytes, of the buffer. If 0 is specified, sizeof(T) * data.Length is used.</param>
    /// <param name="usage">The usage pattern for the buffer.</param>
    /// <param name="accessFlags">Flags specifying how the buffer will be accessible from the CPU.</param>
    /// <param name="miscFlags">Miscellaneous resource options.</param>
    /// <param name="structureByteStride">The size (in bytes) of the structure element for structured buffers.</param>
    /// <returns>An initialized buffer</returns>
    public static ComPtr<ID3D11Buffer> CreateBuffer<T>(
        this ref ID3D11Device device,
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
            device.CreateBuffer(&description, &subresourceData, buffer.GetAddressOf()).ThrowIfFailed();
            return buffer.Move();
        }
    }
}
