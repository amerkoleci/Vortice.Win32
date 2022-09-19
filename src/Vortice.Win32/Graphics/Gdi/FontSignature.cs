// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Gdi;

/// <unmanaged>FONTSIGNATURE</unmanaged>
public partial struct FontSignature
{
    public unsafe fixed uint fsUsb[4];

    public unsafe fixed uint fsCsb[2];
}
