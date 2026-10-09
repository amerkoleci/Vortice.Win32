// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.ComponentModel;

namespace Vortice.Win32;

public static unsafe partial class Apis
{
    [NativeTypeName("#define S_OK ((HRESULT)0L)")]
    public const int S_OK = 0;

    [NativeTypeName("#define S_FALSE ((HRESULT)1L)")]
    public const int S_FALSE = 1;

    [NativeTypeName("#define E_UNEXPECTED _HRESULT_TYPEDEF_(0x8000FFFFL)")]
    public const int E_UNEXPECTED = unchecked((int)(0x8000FFFF));

    [NativeTypeName("#define E_NOTIMPL _HRESULT_TYPEDEF_(0x80004001L)")]
    public const int E_NOTIMPL = unchecked((int)(0x80004001));

    [NativeTypeName("#define E_OUTOFMEMORY _HRESULT_TYPEDEF_(0x8007000EL)")]
    public const int E_OUTOFMEMORY = unchecked((int)(0x8007000E));
    [NativeTypeName("#define E_NOINTERFACE _HRESULT_TYPEDEF_(0x80004002L)")]
    public const int E_NOINTERFACE = unchecked((int)(0x80004002));

    [NativeTypeName("#define E_POINTER _HRESULT_TYPEDEF_(0x80004003L)")]
    public const int E_POINTER = unchecked((int)(0x80004003));

    [NativeTypeName("#define E_INVALIDARG _HRESULT_TYPEDEF_(0x80070057L)")]
    public const int E_INVALIDARG = unchecked((int)(0x80070057));

    [NativeTypeName("#define E_HANDLE _HRESULT_TYPEDEF_(0x80070006L)")]
    public const int E_HANDLE = unchecked((int)(0x80070006));

    [NativeTypeName("#define E_ABORT _HRESULT_TYPEDEF_(0x80004004L)")]
    public const int E_ABORT = unchecked((int)(0x80004004));

    [NativeTypeName("#define E_FAIL _HRESULT_TYPEDEF_(0x80004005L)")]
    public const int E_FAIL = unchecked((int)(0x80004005));

    [NativeTypeName("#define E_ACCESSDENIED _HRESULT_TYPEDEF_(0x80070005L)")]
    public const int E_ACCESSDENIED = unchecked((int)(0x80070005));

    [NativeTypeName("#define E_PENDING _HRESULT_TYPEDEF_(0x8000000AL)")]
    public const int E_PENDING = unchecked((int)(0x8000000A));

    [NativeTypeName("#define E_NOT_SUFFICIENT_BUFFER HRESULT_FROM_WIN32(ERROR_INSUFFICIENT_BUFFER)")]
    public const int E_NOT_SUFFICIENT_BUFFER = -2147024774;

    [NativeTypeName("#define WAIT_TIMEOUT 258L")]
    public const int WAIT_TIMEOUT = 258;

    [NativeTypeName("#define WAIT_FAILED ((DWORD)0xFFFFFFFF)")]
    public const uint WAIT_FAILED = 0xFFFFFFFF;

    [NativeTypeName("#define WAIT_OBJECT_0 ((STATUS_WAIT_0 ) + 0 )")]
    public const int WAIT_OBJECT_0 = (0x00000000 + 0);

    [NativeTypeName("#define WAIT_ABANDONED ((STATUS_ABANDONED_WAIT_0 ) + 0 )")]
    public const int WAIT_ABANDONED = (0x00000080 + 0);

    [NativeTypeName("#define WAIT_ABANDONED_0 ((STATUS_ABANDONED_WAIT_0 ) + 0 )")]
    public const int WAIT_ABANDONED_0 = (0x00000080 + 0);

    [NativeTypeName("#define WAIT_IO_COMPLETION STATUS_USER_APC")]
    public const int WAIT_IO_COMPLETION = (0x000000C0);

    public static bool SUCCEEDED(HRESULT hr)
    {
        return hr.Value >= 0;
    }

    public static bool FAILED(HRESULT hr)
    {
        return hr.Value < 0;
    }

    [DoesNotReturn]
    public static void ThrowExternalException(string methodName, int errorCode)
    {
        string message = string.Format("'{0}' failed with an error code of '{1}'", methodName, errorCode);
        throw new ExternalException(message, errorCode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ThrowIfFailed(this HRESULT value, [CallerArgumentExpression("value")] string? valueExpression = null)
    {
        if (value.Failure)
        {
            ThrowExternalException(valueExpression ?? "Method", value);
        }
    }

    /// <summary>Retrieves the GUID of of a specified type.</summary>
    /// <param name="value">A value of type <typeparamref name="T"/>.</param>
    /// <typeparam name="T">The type to retrieve the GUID for.</typeparam>
    /// <returns>A <see cref="UuidOfType"/> value wrapping a pointer to the GUID data for the input type. This value can be either converted to a <see cref="Guid"/> pointer, or implicitly assigned to a <see cref="Guid"/> value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static UuidOfType __uuidof<T>(T value) // for type inference similar to C++'s __uuidof
        where T : unmanaged, INativeGuid
    {
        return new UuidOfType(T.NativeGuid);
    }

    /// <summary>Retrieves the GUID of of a specified type.</summary>
    /// <param name="value">A pointer to a value of type <typeparamref name="T"/>.</param>
    /// <typeparam name="T">The type to retrieve the GUID for.</typeparam>
    /// <returns>A <see cref="UuidOfType"/> value wrapping a pointer to the GUID data for the input type. This value can be either converted to a <see cref="Guid"/> pointer, or implicitly assigned to a <see cref="Guid"/> value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static UuidOfType __uuidof<T>(T* value) // for type inference similar to C++'s __uuidof
        where T : unmanaged, INativeGuid
    {
        return new UuidOfType(T.NativeGuid);
    }

    /// <summary>Retrieves the GUID of of a specified type.</summary>
    /// <typeparam name="T">The type to retrieve the GUID for.</typeparam>
    /// <returns>A <see cref="UuidOfType"/> value wrapping a pointer to the GUID data for the input type. This value can be either converted to a <see cref="Guid"/> pointer, or implicitly assigned to a <see cref="Guid"/> value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static UuidOfType __uuidof<T>()
        where T : unmanaged, INativeGuid
    {
        return new UuidOfType(T.NativeGuid);
    }

    /// <summary>A proxy type that wraps a pointer to GUID data. Values of this type can be implicitly converted to and assigned to <see cref="Guid"/>* or <see cref="Guid"/> parameters.</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public readonly unsafe ref struct UuidOfType
    {
        private readonly Guid* _value;

        internal UuidOfType(Guid* value)
        {
            _value = value;
        }

        /// <summary>Reads a <see cref="Guid"/> value from the GUID buffer for a given <see cref="UuidOfType"/> instance.</summary>
        /// <param name="guid">The input <see cref="UuidOfType"/> instance to read data for.</param>
        public static implicit operator Guid(UuidOfType guid) => *guid._value;

        /// <summary>Returns the <see cref="Guid"/>* pointer to the GUID buffer for a given <see cref="UuidOfType"/> instance.</summary>
        /// <param name="guid">The input <see cref="UuidOfType"/> instance to read data for.</param>
        public static implicit operator Guid*(UuidOfType guid) => guid._value;
    }

    public const int CLSCTX_INPROC_SERVER = 0x1;
    public const int CLSCTX_INPROC_HANDLER = 0x2;
    public const int CLSCTX_LOCAL_SERVER = 0x4;
    public const int CLSCTX_INPROC_SERVER16 = 0x8;
    public const int CLSCTX_REMOTE_SERVER = 0x10;
    public const int CLSCTX_INPROC_HANDLER16 = 0x20;

    [LibraryImport("ole32")]
    public static partial HRESULT CoCreateInstance(Guid* rclsid, IUnknown* pUnkOuter, uint dwClsContext, Guid* riid, void** ppv);

    [LibraryImport("kernel32")]
    public static partial HANDLE HeapCreate(uint flOptions, nuint dwInitialSize, nuint dwMaximumSize);

    [LibraryImport("kernel32")]
    public static partial Bool32 HeapDestroy(void* hHeap);

    [LibraryImport("kernel32")]
    public static partial void* HeapAlloc(HANDLE hHeap, uint dwFlags, nuint dwBytes);

    [LibraryImport("kernel32")]
    [return: NativeTypeName("LPVOID")]
    public static partial void* HeapReAlloc(HANDLE hHeap, uint dwFlags, void* lpMem, nuint dwBytes);

    [LibraryImport("kernel32")]
    public static partial Bool32 HeapFree(HANDLE hHeap, uint dwFlags, void* lpMem);

    [LibraryImport("kernel32")]
    public static partial nuint HeapSize(HANDLE hHeap, uint dwFlags, void* lpMem);

    [LibraryImport("kernel32")]
    public static partial HANDLE GetProcessHeap();

    public const int RDH_RECTANGLES = 1;
}
