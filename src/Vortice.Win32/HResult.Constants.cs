// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32;

public readonly partial struct HResult
{
    /// <unmanaged>S_OK</unmanaged>
    public static readonly HResult Ok = 0;

    /// <unmanaged>S_FALSE</unmanaged>
    public static readonly HResult False = 1;

    /// <unmanaged>E_ABORT</unmanaged>
    public static readonly HResult Abort = unchecked((int)0x80004004);

    /// <unmanaged>E_ACCESSDENIED</unmanaged>
    public static readonly HResult AccessDenied = unchecked((int)0x80070005);

    /// <unmanaged>E_FAIL</unmanaged>
    public static readonly HResult Fail = unchecked((int)0x80004005);

    /// <unmanaged>E_HANDLE</unmanaged>
    public static readonly HResult Handle = unchecked((int)0x80070006);

    /// <unmanaged>E_INVALIDARG</unmanaged>
    public static readonly HResult InvalidArg = unchecked((int)0x80070057);

    /// <unmanaged>E_NOINTERFACE</unmanaged>
    public static readonly HResult NoInterface = unchecked((int)0x80004002);

    /// <unmanaged>E_NOTIMPL</unmanaged>
    public static readonly HResult NotImplemented = unchecked((int)0x80004001);

    /// <unmanaged>E_OUTOFMEMORY</unmanaged>
    public static readonly HResult OutOfMemory = unchecked((int)0x8007000E);

    /// <unmanaged>E_POINTER</unmanaged>
    public static readonly HResult InvalidPointer = unchecked((int)0x80004003);

    /// <unmanaged>E_UNEXPECTED</unmanaged>
    public static readonly HResult UnexpectedFailure = unchecked((int)0x8000FFFF);

    /// <unmanaged>WAIT_ABANDONED</unmanaged>
    public static readonly HResult WaitAbandoned = unchecked((int)0x00000080);

    /// <unmanaged>WAIT_TIMEOUT</unmanaged>
    public static readonly HResult WaitTimeout = unchecked((int)0x00000102);

    /// <summary>
    /// The data necessary to complete this operation is not yet available.
    /// </summary>
    /// <unmanaged>E_PENDING</unmanaged>
    public static readonly HResult Pending = unchecked((int)0x8000000A);

    /// <summary>
    /// The data area passed to a system call is too small.
    /// </summary>
    /// <unmanaged>E_NOT_SUFFICIENT_BUFFER</unmanaged>
    public static readonly HResult InsufficientBuffer = unchecked((int)0x8007007A);
}
