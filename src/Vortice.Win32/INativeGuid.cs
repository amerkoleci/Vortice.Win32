// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32;

public interface INativeGuid
{
    protected internal static abstract unsafe Guid* NativeGuid { get; }
}
