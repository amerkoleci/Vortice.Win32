// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Reflection;

namespace Win32.Graphics.Direct3D.Dxc;

public static unsafe partial class Apis
{
    public static ref readonly Guid CLSID_DxcUtils => ref CLSID_DxcLibrary;

#if NET6_0_OR_GREATER
    static Apis()
    {
        NativeLibrary.SetDllImportResolver(Assembly.GetExecutingAssembly(), OnDllImport);
    }

    private static IntPtr OnDllImport(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
    {
        if (TryResolveLibrary(libraryName, assembly, searchPath, out IntPtr nativeLibrary))
        {
            return nativeLibrary;
        }

        return NativeLibrary.Load(libraryName, assembly, searchPath);
    }

    private static bool TryResolveLibrary(string libraryName, Assembly assembly, DllImportSearchPath? searchPath, out IntPtr nativeLibrary)
    {
        nativeLibrary = IntPtr.Zero;
        if (libraryName is not "dxcompiler.dll")
            return false;

        string rid = RuntimeInformation.RuntimeIdentifier;

        string nugetNativeLibsPath = Path.Combine(AppContext.BaseDirectory, "runtimes", rid, "native");
        bool isNuGetRuntimeLibrariesDirectoryPresent = Directory.Exists(nugetNativeLibsPath);

        string dxilLibName = "dxil";
        string dxcompilerName = "dxcompiler";

        if (OperatingSystem.IsWindows())
        {
            dxilLibName = "dxil.dll";
            dxcompilerName = "dxcompiler.dll";

            if (!isNuGetRuntimeLibrariesDirectoryPresent)
            {
                rid = RuntimeInformation.ProcessArchitecture switch
                {
                    Architecture.X64 => "win-x64",
                    Architecture.Arm64 => "win-arm64",
                    _ => "win-x64"
                };

                nugetNativeLibsPath = Path.Combine(AppContext.BaseDirectory, "runtimes", rid, "native");
                isNuGetRuntimeLibrariesDirectoryPresent = Directory.Exists(nugetNativeLibsPath);
            }
        }
        else if (OperatingSystem.IsLinux())
        {
            dxilLibName = "libdxil.so";
            dxcompilerName = "libdxcompiler.so";
        }
        else if (OperatingSystem.IsMacOS() || OperatingSystem.IsMacCatalyst())
        {
            dxilLibName = "libdxil.dylib";
            dxcompilerName = "libdxcompiler.dylib";
        }

        if (isNuGetRuntimeLibrariesDirectoryPresent)
        {
            string dxilLibPath = Path.Combine(AppContext.BaseDirectory, "runtimes", rid, "native", dxilLibName);
            string dxcompilerPath = Path.Combine(AppContext.BaseDirectory, "runtimes", rid, "native", dxcompilerName);

            if (NativeLibrary.TryLoad(dxilLibPath, assembly, searchPath, out _) &&
                NativeLibrary.TryLoad(dxcompilerPath, assembly, searchPath, out nativeLibrary))
            {
                return true;
            }
        }

        // Search root path
        if (NativeLibrary.TryLoad(dxilLibName, assembly, searchPath, out _) &&
            NativeLibrary.TryLoad(dxcompilerName, assembly, searchPath, out nativeLibrary))
        {
            return true;
        }

        nativeLibrary = IntPtr.Zero;
        return false;
    }
#endif

    public static HResult DxcCreateInstance(in Guid rclsid, Guid* riid, void** ppv)
    {
        return DxcCreateInstance(
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in rclsid)),
            riid,
            ppv);
    }

    public static HResult DxcCreateInstance2(Com.IMalloc* pMalloc, in Guid rclsid, Guid* riid, void** ppv)
    {
        return DxcCreateInstance2(
            pMalloc,
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in rclsid)),
            riid,
            ppv);
    }
}
