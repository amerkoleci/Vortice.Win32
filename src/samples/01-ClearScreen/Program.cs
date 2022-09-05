// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Runtime.InteropServices;
using Win32;
using Win32.Graphics.Dxgi;
using static Win32.Apis;

namespace ClearScreen;

public static unsafe class Program
{
    public static void Main()
    {
        string test = StringUtilities.GetString(new sbyte[] { (sbyte)'A', (sbyte)'B', (sbyte)'C' });
        test = StringUtilities.GetString(new ushort[] { 'A', 'B', 'C' });

        using ComPtr<IDXGIFactory1> factory = default;
        HResult hr = CreateDXGIFactory1(__uuidof<IDXGIFactory4>(), (void**)&factory);

        {
            using ComPtr<IDXGIFactory5> factory5 = default;
            if (factory.CopyTo(&factory5).Success)
            {
                Bool32 isTearingSupported = factory5.Get()->CheckFeatureSupport<Bool32>(Feature.PresentAllowTearing);
            }
        }

        using ComPtr<IDXGIAdapter1> adapter = default;

        using ComPtr<IDXGIFactory6> factory6 = default;
        if (factory.CopyTo(&factory6).Success)
        {
            for (uint adapterIndex = 0;
                factory6.Get()->EnumAdapterByGpuPreference(
                    adapterIndex,
                    GpuPreference.HighPerformance,
                    __uuidof<IDXGIAdapter1>(),
                    (void**)adapter.ReleaseAndGetAddressOf()).Success;
                adapterIndex++)
            {
                AdapterDescription1 desc = default;
                adapter.Get()->GetDesc1(&desc);

                string name = desc.DescriptionStr;
            }
        }

        for (uint adapterIndex = 0;
            factory.Get()->EnumAdapters1(adapterIndex, adapter.ReleaseAndGetAddressOf()).Success;
            adapterIndex++)
        {
            AdapterDescription1 desc = default;
            adapter.Get()->GetDesc1(&desc);

            string name = desc.DescriptionStr;
        }
    }

    [DllImport("dxgi", ExactSpelling = true)]
    public static extern HResult CreateDXGIFactory1(Guid* riid, void** ppFactory);
}
