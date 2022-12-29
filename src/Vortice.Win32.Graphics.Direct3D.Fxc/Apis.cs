// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Buffers;
using System.Text.RegularExpressions;
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
        CompileFlags flags = CompileFlags.None)
    {
        byte[] sourceUtf8 = Encoding.UTF8.GetBytes(source);
        byte[] entryPointUtf8 = Encoding.UTF8.GetBytes(entryPoint);
        byte[] targetUtf8 = Encoding.UTF8.GetBytes(target);

        using ComPtr<ID3DBlob> d3dBlobBytecode = default;
        using ComPtr<ID3DBlob> d3dBlobErrors = default;

        fixed (byte* sourcePtr = sourceUtf8)
        fixed (byte* entryPointPtr = entryPointUtf8)
        fixed (byte* targetPtr = targetUtf8)
        {
            HResult hr = D3DCompile(
                pSrcData: sourcePtr,
                SrcDataSize: (nuint)sourceUtf8.Length,
                pSourceName: null,
                pDefines: null,
                pInclude: D3D_COMPILE_STANDARD_FILE_INCLUDE,
                pEntrypoint: (sbyte*)entryPointPtr,
                pTarget: (sbyte*)targetPtr,
                Flags1: flags,
                Flags2: 0u,
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
    }

    public static ComPtr<ID3DBlob> D3DCompile(
        ReadOnlySpan<char> source,
        ReadOnlySpan<char> entryPoint,
        ReadOnlySpan<char> target,
        CompileFlags flags = CompileFlags.None)
    {
        int maxLength = Encoding.UTF8.GetMaxByteCount(source.Length);
        byte[] sourceBuffer = ArrayPool<byte>.Shared.Rent(maxLength);
        int writtenBytes = Encoding.UTF8.GetBytes(source, sourceBuffer);

        maxLength = Encoding.UTF8.GetMaxByteCount(entryPoint.Length);
        byte[] entryPointBuffer = ArrayPool<byte>.Shared.Rent(maxLength);
        int entryPointWrittenBytes = Encoding.UTF8.GetBytes(entryPoint, entryPointBuffer);

        maxLength = Encoding.UTF8.GetMaxByteCount(target.Length);
        byte[] targetBuffer = ArrayPool<byte>.Shared.Rent(maxLength);
        int targetWrittenBytes = Encoding.UTF8.GetBytes(target, targetBuffer);

        try
        {
            using ComPtr<ID3DBlob> d3dBlobBytecode = default;
            using ComPtr<ID3DBlob> d3dBlobErrors = default;

            HResult hr = D3DCompile(
                sourceBuffer.AsSpan(0, writtenBytes),
                entryPointBuffer.AsSpan(0, entryPointWrittenBytes),
                targetBuffer.AsSpan(0, targetWrittenBytes),
                flags,
                d3dBlobBytecode.GetAddressOf(),
                d3dBlobErrors.GetAddressOf());

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

            ArrayPool<byte>.Shared.Return(sourceBuffer);
            ArrayPool<byte>.Shared.Return(entryPointBuffer);
            ArrayPool<byte>.Shared.Return(targetBuffer);
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
                pEntrypoint: (sbyte*)entryPointPtr,
                pTarget: (sbyte*)targetPtr,
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
                pEntrypoint: (sbyte*)entryPointPtr,
                pTarget: (sbyte*)targetPtr,
                Flags1: flags,
                Flags2: 0u,
                ppCode: byteCode,
                ppErrorMsgs: errorMessage);
            return hr;
        }
    }

#if NET6_0_OR_GREATER
    [DoesNotReturn]
#endif
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void ThrowHslsCompilationException(ID3DBlob* d3DOperationResult)
    {
        string message = new((sbyte*)d3DOperationResult->GetBufferPointer());

        // The error message will be in a format like this:
        // "C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\Roslyn\Shader@0x0000019AD1B4BA70(22,32-35): error X3004: undeclared identifier 'this'"
        // This regex tries to match the unnecessary header and remove it, if present. This doesn't need to be bulletproof, and this regex should match all cases anyway.
        message = Regex.Replace(message, @"^[A-Z]:\\[^:]+: (\w+ \w+:)", static m => m.Groups[1].Value, RegexOptions.Multiline).Trim();

        // Add a trailing '.' if not present
        if (message is { Length: > 0 } &&
            message[message.Length - 1] != '.')
        {
            message += '.';
        }

        throw new FxcCompilationException(message);
    }
}
