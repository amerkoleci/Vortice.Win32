// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Apis;
using static Vortice.Win32.Graphics.D3D12;
using static Vortice.Win32.Graphics.D3D;

namespace Vortice.Win32.Graphics;

public static unsafe partial class ID3D12DeviceExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TFeature CheckFeatureSupport<TD3D12Device, TFeature>(ref this TD3D12Device self, D3D12_FEATURE feature)
        where TD3D12Device : unmanaged, ID3D12Device.Interface
        where TFeature : unmanaged
    {
        TFeature featureData = default;
        self.CheckFeatureSupport(feature, &featureData, sizeof(TFeature)).ThrowIfFailed();
        return featureData;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static HRESULT CheckFeatureSupport<TD3D12Device, TFeature>(ref this TD3D12Device self, D3D12_FEATURE feature, ref TFeature featureData)
       where TD3D12Device : unmanaged, ID3D12Device.Interface
       where TFeature : unmanaged
    {
        fixed (TFeature* featureDataPtr = &featureData)
        {
            return self.CheckFeatureSupport(feature, featureDataPtr, sizeof(TFeature));
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static HRESULT CreateCommittedResource<TD3D12Device>(ref this TD3D12Device self, D3D12_HEAP_TYPE heapType, D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialResourceState, D3D12_CLEAR_VALUE* pOptimizedClearValue, Guid* riidResource, void** ppvResource)
        where TD3D12Device : unmanaged, ID3D12Device.Interface
    {
        D3D12_HEAP_PROPERTIES heapProperties = new(heapType);
        return self.CreateCommittedResource(&heapProperties, D3D12_HEAP_FLAG_NONE, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static D3D_FEATURE_LEVEL CheckMaxSupportedFeatureLevel<TD3D12Device>(ref this TD3D12Device self)
        where TD3D12Device : unmanaged, ID3D12Device.Interface
    {
        ReadOnlySpan<D3D_FEATURE_LEVEL> featureLevels =
        [
            D3D_FEATURE_LEVEL_12_2,
            D3D_FEATURE_LEVEL_12_1,
            D3D_FEATURE_LEVEL_11_1,
            D3D_FEATURE_LEVEL_11_0
        ];

        fixed (D3D_FEATURE_LEVEL* pFeatureLevels = featureLevels)
        {
            D3D12_FEATURE_DATA_FEATURE_LEVELS featureData = new()
            {
                NumFeatureLevels = (uint)featureLevels.Length,
                pFeatureLevelsRequested = pFeatureLevels,
                MaxSupportedFeatureLevel = D3D_FEATURE_LEVEL_11_0
            };

            if (self.CheckFeatureSupport(D3D12_FEATURE_FEATURE_LEVELS, &featureData, sizeof(D3D12_FEATURE_DATA_FEATURE_LEVELS)).Success)
            {
                return featureData.MaxSupportedFeatureLevel;
            }

            return D3D_FEATURE_LEVEL_11_0;
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static D3D_FEATURE_LEVEL CheckMaxSupportedFeatureLevel<TD3D12Device>(
        ref this TD3D12Device self, ReadOnlySpan<D3D_FEATURE_LEVEL> featureLevels)
        where TD3D12Device : unmanaged, ID3D12Device.Interface
    {
        fixed (D3D_FEATURE_LEVEL* pFeatureLevels = featureLevels)
        {
            var featureData = new D3D12_FEATURE_DATA_FEATURE_LEVELS
            {
                NumFeatureLevels = (uint)featureLevels.Length,
                pFeatureLevelsRequested = pFeatureLevels,
                MaxSupportedFeatureLevel = D3D_FEATURE_LEVEL_11_0
            };

            if (self.CheckFeatureSupport(D3D12_FEATURE_FEATURE_LEVELS, &featureData, sizeof(D3D12_FEATURE_DATA_FEATURE_LEVELS)).Success)
            {
                return featureData.MaxSupportedFeatureLevel;
            }

            return D3D_FEATURE_LEVEL_11_0;
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static D3D_ROOT_SIGNATURE_VERSION CheckHighestRootSignatureVersionl<TD3D12Device>(
        ref this TD3D12Device self,
        D3D_ROOT_SIGNATURE_VERSION highestVersion = D3D_ROOT_SIGNATURE_VERSION_1_1)
        where TD3D12Device : unmanaged, ID3D12Device.Interface
    {
        var featureData = new D3D12_FEATURE_DATA_ROOT_SIGNATURE
        {
            HighestVersion = highestVersion
        };

        if (self.CheckFeatureSupport(D3D12_FEATURE_ROOT_SIGNATURE, &featureData, sizeof(D3D12_FEATURE_DATA_ROOT_SIGNATURE)).Success)
        {
            return featureData.HighestVersion;
        }

        return D3D_ROOT_SIGNATURE_VERSION_1_0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static D3D_SHADER_MODEL CheckHighestShaderModel<TD3D12Device>(ref this TD3D12Device self, D3D_SHADER_MODEL highestShaderModel)
         where TD3D12Device : unmanaged, ID3D12Device.Interface
    {
        var featureData = new D3D12_FEATURE_DATA_SHADER_MODEL
        {
            HighestShaderModel = highestShaderModel
        };

        if (self.CheckFeatureSupport(D3D12_FEATURE_SHADER_MODEL, &featureData, sizeof(D3D12_FEATURE_DATA_SHADER_MODEL)).Success)
        {
            return featureData.HighestShaderModel;
        }

        return D3D_SHADER_MODEL_5_1;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool CheckFormatSupport<TD3D12Device>(ref this TD3D12Device self,
        DXGI_FORMAT format, out D3D12_FORMAT_SUPPORT1 formatSupport1, out D3D12_FORMAT_SUPPORT2 formatSupport2)
        where TD3D12Device : unmanaged, ID3D12Device.Interface
    {
        D3D12_FEATURE_DATA_FORMAT_SUPPORT featureData = new()
        {
            Format = format
        };

        if (self.CheckFeatureSupport(D3D12_FEATURE_FORMAT_SUPPORT, &featureData, sizeof(D3D12_FEATURE_DATA_FORMAT_SUPPORT)).Failure)
        {
            formatSupport1 = D3D12_FORMAT_SUPPORT1_NONE;
            formatSupport2 = D3D12_FORMAT_SUPPORT2_NONE;
            return false;
        }

        formatSupport1 = featureData.Support1;
        formatSupport2 = featureData.Support2;
        return true;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte GetFormatPlaneCount<TD3D12Device>(ref this TD3D12Device self, DXGI_FORMAT format)
        where TD3D12Device : unmanaged, ID3D12Device.Interface
    {
        D3D12_FEATURE_DATA_FORMAT_INFO featureData = new()
        {
            Format = format
        };

        if (self.CheckFeatureSupport(D3D12_FEATURE_FORMAT_INFO, &featureData, sizeof(D3D12_FEATURE_DATA_FORMAT_INFO)).Failure)
        {
            return 0;
        }

        return featureData.PlaneCount;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static D3D12_FEATURE_DATA_COMMAND_QUEUE_PRIORITY CheckCommandQueuePriority<TD3D12Device>(ref this TD3D12Device self, D3D12_COMMAND_LIST_TYPE commandListType)
        where TD3D12Device : unmanaged, ID3D12Device.Interface
    {
        D3D12_FEATURE_DATA_COMMAND_QUEUE_PRIORITY featureData = new()
        {
            CommandListType = commandListType,
        };

        if (self.CheckFeatureSupport(D3D12_FEATURE_COMMAND_QUEUE_PRIORITY, &featureData, sizeof(D3D12_FEATURE_DATA_COMMAND_QUEUE_PRIORITY)).Failure)
        {
            return default;
        }

        return featureData;
    }

}
