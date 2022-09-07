// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Runtime.CompilerServices;
using Win32.Graphics.Direct3D;
using Win32.Graphics.Dxgi;
using Win32.Graphics.Dxgi.Common;
using static Win32.Graphics.Direct3D11.Apis;
using static Win32.StringUtilities;

namespace Win32.Graphics.Direct3D11;

public partial struct AuthenticatedProtectionFlags
{
    public partial struct _Flags_e__Struct
    {
        public uint ProtectionEnabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield & 0x1u;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
            }
        }

        public uint OverlayOrFullscreenRequired
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 1) & 0x1u;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
            }
        }

        [NativeTypeName("uint : 30")]
        public uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 2) & 0x3FFFFFFFu;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x3FFFFFFFu << 2)) | ((value & 0x3FFFFFFFu) << 2);
            }
        }
    }
}


public static unsafe partial class Apis
{
    public static HResult D3D11CreateDevice(
        IDXGIAdapter* pAdapter,
        DriverType driverType,
        CreateDeviceFlag flags,
        ReadOnlySpan<FeatureLevel> featureLevels,
        ID3D11Device** ppDevice,
        FeatureLevel* pFeatureLevel,
        ID3D11DeviceContext** ppImmediateContext)
    {
        fixed (FeatureLevel* pfeatureLevels = featureLevels)
        {
            return D3D11CreateDevice(
                pAdapter,
                driverType,
                IntPtr.Zero,
                flags,
                pfeatureLevels,
                (uint)featureLevels.Length,
                D3D11_SDK_VERSION,
                ppDevice,
                pFeatureLevel,
                ppImmediateContext);
        }
    }
}
