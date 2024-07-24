// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Buffers;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using static Win32.Apis;

namespace Win32.Graphics.Direct3D.Fxc;

public static unsafe partial class Apis
{
    public static ID3DInclude* D3D_COMPILE_STANDARD_FILE_INCLUDE => (ID3DInclude*)(nuint)1;

    public static ComPtr<ID3DBlob> D3DCompile(
        string source,
        string entryPoint,
        string target,
        string? sourceName = default,
        ShaderMacro* pDefines = default,
        ID3DInclude* includeHandler = default,
        CompileFlags flags = CompileFlags.None,
        CompileFlags2 flags2 = CompileFlags2.None)
    {
        scoped Utf8StringMarshaller.ManagedToUnmanagedIn __source__marshaller = new();
        scoped Utf8StringMarshaller.ManagedToUnmanagedIn __sourceName__marshaller = new();
        scoped Utf8StringMarshaller.ManagedToUnmanagedIn __entryPoint__marshaller = new();
        scoped Utf8StringMarshaller.ManagedToUnmanagedIn __target__marshaller = new();
        try
        {
            __source__marshaller.FromManaged(source, stackalloc byte[Utf8StringMarshaller.ManagedToUnmanagedIn.BufferSize]);
            __sourceName__marshaller.FromManaged(sourceName, stackalloc byte[Utf8StringMarshaller.ManagedToUnmanagedIn.BufferSize]);
            __entryPoint__marshaller.FromManaged(entryPoint, stackalloc byte[Utf8StringMarshaller.ManagedToUnmanagedIn.BufferSize]);
            __target__marshaller.FromManaged(target, stackalloc byte[Utf8StringMarshaller.ManagedToUnmanagedIn.BufferSize]);

            byte* sourcePtr = __source__marshaller.ToUnmanaged();
            byte* sourceNamePtr = __sourceName__marshaller.ToUnmanaged();
            byte* entryPointPtr = __entryPoint__marshaller.ToUnmanaged();
            byte* targetPtr = __target__marshaller.ToUnmanaged();

            using ComPtr<ID3DBlob> d3dBlobBytecode = default;
            using ComPtr<ID3DBlob> d3dBlobErrors = default;

            HResult hr = D3DCompile(
                pSrcData: sourcePtr,
                SrcDataSize: (nuint)source.Length,
                pSourceName: sourceNamePtr,
                pDefines: pDefines,
                pInclude: includeHandler != null ? includeHandler : D3D_COMPILE_STANDARD_FILE_INCLUDE,
                pEntrypoint: entryPointPtr,
                pTarget: targetPtr,
                Flags1: flags,
                Flags2: (uint)flags2,
                ppCode: d3dBlobBytecode.GetAddressOf(),
                ppErrorMsgs: d3dBlobErrors.GetAddressOf()
                );

            if (hr.Failure)
            {
                // Throw if an error was retrieved, then also double check the HRESULT
                if (d3dBlobErrors.Get() is not null)
                {
                    ThrowHslsCompilationException(d3dBlobErrors.Get());
                }
            }

            ThrowIfFailed(hr);

            return d3dBlobBytecode.Move();
        }
        finally
        {
            __source__marshaller.Free();
            __entryPoint__marshaller.Free();
            __target__marshaller.Free();
        }
    }

    public static HResult D3DCompile(
        ReadOnlySpan<byte> source,
        ReadOnlySpan<byte> entryPoint,
        ReadOnlySpan<byte> target,
        CompileFlags flags,
        ID3DBlob** byteCode,
        ID3DBlob** errorMessage)
    {
        fixed (byte* sourcePtr = source)
        fixed (byte* entryPointPtr = entryPoint)
        fixed (byte* targetPtr = target)
        {
            HResult hr = D3DCompile(
                pSrcData: sourcePtr,
                SrcDataSize: (nuint)source.Length,
                pSourceName: null,
                pDefines: null,
                pInclude: D3D_COMPILE_STANDARD_FILE_INCLUDE,
                pEntrypoint: entryPointPtr,
                pTarget: targetPtr,
                Flags1: flags,
                Flags2: 0u,
                ppCode: byteCode,
                ppErrorMsgs: errorMessage);
            return hr;
        }
    }

    public static HResult D3DCompile(
        ReadOnlySpan<byte> source,
        ReadOnlySpan<byte> entryPoint,
        ReadOnlySpan<byte> target,
        ID3DInclude* includeHandler,
        CompileFlags flags,
        ID3DBlob** byteCode,
        ID3DBlob** errorMessage)
    {
        fixed (byte* sourcePtr = source)
        fixed (byte* entryPointPtr = entryPoint)
        fixed (byte* targetPtr = target)
        {
            HResult hr = D3DCompile(
                pSrcData: sourcePtr,
                SrcDataSize: (nuint)source.Length,
                pSourceName: null,
                pDefines: null,
                pInclude: includeHandler,
                pEntrypoint: entryPointPtr,
                pTarget: targetPtr,
                Flags1: flags,
                Flags2: 0u,
                ppCode: byteCode,
                ppErrorMsgs: errorMessage);
            return hr;
        }
    }

    [DoesNotReturn]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void ThrowHslsCompilationException(ID3DBlob* d3DOperationResult)
    {
        string message = new((sbyte*)d3DOperationResult->GetBufferPointer());

        throw new ExternalException(message);
    }
}
