// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D12;

/// <unmanaged>D3D12_BARRIER_GROUP</unmanaged>
public unsafe partial struct BarrierGroup
{
    [NativeTypeName("D3D12_BARRIER_TYPE")]
    public BarrierType Type;

    [NativeTypeName("UINT32")]
    public uint NumBarriers;

    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref GlobalBarrier* pGlobalBarriers
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pGlobalBarriers;
        }
    }

    [UnscopedRef]
    public ref TextureBarrier* pTextureBarriers
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pTextureBarriers;
        }
    }

    [UnscopedRef]
    public ref BufferBarrier* pBufferBarriers
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pBufferBarriers;
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("const D3D12_GLOBAL_BARRIER *")]
        public GlobalBarrier* pGlobalBarriers;

        [FieldOffset(0)]
        [NativeTypeName("const D3D12_TEXTURE_BARRIER *")]
        public TextureBarrier* pTextureBarriers;

        [FieldOffset(0)]
        [NativeTypeName("const D3D12_BUFFER_BARRIER *")]
        public BufferBarrier* pBufferBarriers;
    }
}
