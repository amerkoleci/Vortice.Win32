// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Direct3D;
using Win32.Graphics.Dxgi.Common;
using static Win32.Apis;

namespace Win32.Graphics.Direct3D12;

public static unsafe partial class ID3D12DeviceExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TFeature CheckFeatureSupport<TD3D12Device, TFeature>(ref this TD3D12Device self, Feature feature)
        where TD3D12Device : unmanaged, ID3D12Device.Interface
        where TFeature : unmanaged
    {
        TFeature featureData = default;
        ThrowIfFailed(self.CheckFeatureSupport(feature, &featureData, sizeof(TFeature)));
        return featureData;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static HResult CheckFeatureSupport<TD3D12Device, TFeature>(ref this TD3D12Device self, Feature feature, ref TFeature featureData)
       where TD3D12Device : unmanaged, ID3D12Device.Interface
       where TFeature : unmanaged
    {
        fixed (TFeature* featureDataPtr = &featureData)
        {
            return self.CheckFeatureSupport(feature, featureDataPtr, sizeof(TFeature));
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static HResult CreateCommittedResource<TD3D12Device>(ref this TD3D12Device self, HeapType heapType, ResourceDescription* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource)
        where TD3D12Device : unmanaged, ID3D12Device.Interface
    {
        HeapProperties heapProperties = new(heapType);
        return self.CreateCommittedResource(&heapProperties, HeapFlags.None, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static FeatureLevel CheckMaxSupportedFeatureLevel<TD3D12Device>(ref this TD3D12Device self)
        where TD3D12Device : unmanaged, ID3D12Device.Interface
    {
        ReadOnlySpan<FeatureLevel> featureLevels = stackalloc FeatureLevel[4]
        {
            FeatureLevel.Level_12_2,
            FeatureLevel.Level_12_1,
            FeatureLevel.Level_11_1,
            FeatureLevel.Level_11_0
        };

        fixed (FeatureLevel* pFeatureLevels = featureLevels)
        {
            FeatureDataFeatureLevels featureData = new()
            {
                NumFeatureLevels = (uint)featureLevels.Length,
                pFeatureLevelsRequested = pFeatureLevels,
                MaxSupportedFeatureLevel = FeatureLevel.Level_11_0
            };

            if (self.CheckFeatureSupport(Feature.FeatureLevels, &featureData, sizeof(FeatureDataFeatureLevels)).Success)
            {
                return featureData.MaxSupportedFeatureLevel;
            }

            return FeatureLevel.Level_11_0;
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static FeatureLevel CheckMaxSupportedFeatureLevel<TD3D12Device>(
        ref this TD3D12Device self, ReadOnlySpan<FeatureLevel> featureLevels)
        where TD3D12Device : unmanaged, ID3D12Device.Interface
    {
        fixed (FeatureLevel* pFeatureLevels = featureLevels)
        {
            var featureData = new FeatureDataFeatureLevels
            {
                NumFeatureLevels = (uint)featureLevels.Length,
                pFeatureLevelsRequested = pFeatureLevels,
                MaxSupportedFeatureLevel = FeatureLevel.Level_11_0
            };

            if (self.CheckFeatureSupport(Feature.FeatureLevels, &featureData, sizeof(FeatureDataFeatureLevels)).Success)
            {
                return featureData.MaxSupportedFeatureLevel;
            }

            return FeatureLevel.Level_11_0;
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static RootSignatureVersion CheckHighestRootSignatureVersionl<TD3D12Device>(
        ref this TD3D12Device self,
        RootSignatureVersion highestVersion = RootSignatureVersion.V1_1)
        where TD3D12Device : unmanaged, ID3D12Device.Interface
    {
        var featureData = new FeatureDataRootSignature
        {
            HighestVersion = highestVersion
        };

        if (self.CheckFeatureSupport(Feature.RootSignature, &featureData, sizeof(FeatureDataRootSignature)).Success)
        {
            return featureData.HighestVersion;
        }

        return RootSignatureVersion.V1_0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ShaderModel CheckHighestShaderModel<TD3D12Device>(ref this TD3D12Device self, ShaderModel highestShaderModel)
         where TD3D12Device : unmanaged, ID3D12Device.Interface
    {
        var featureData = new FeatureDataShaderModel
        {
            HighestShaderModel = highestShaderModel
        };

        if (self.CheckFeatureSupport(Feature.ShaderModel, &featureData, sizeof(FeatureDataShaderModel)).Success)
        {
            return featureData.HighestShaderModel;
        }

        return ShaderModel.SM_5_1;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool CheckFormatSupport<TD3D12Device>(ref this TD3D12Device self,
        Format format, out FormatSupport1 formatSupport1, out FormatSupport2 formatSupport2)
        where TD3D12Device : unmanaged, ID3D12Device.Interface
    {
        FeatureDataFormatSupport featureData = new()
        {
            Format = format
        };

        if (self.CheckFeatureSupport(Feature.FormatSupport, &featureData, sizeof(FeatureDataFormatSupport)).Failure)
        {
            formatSupport1 = FormatSupport1.None;
            formatSupport2 = FormatSupport2.None;
            return false;
        }

        formatSupport1 = featureData.Support1;
        formatSupport2 = featureData.Support2;
        return true;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte GetFormatPlaneCount<TD3D12Device>(ref this TD3D12Device self, Format format)
        where TD3D12Device : unmanaged, ID3D12Device.Interface
    {
        var featureData = new FeatureDataFormatInfo
        {
            Format = format
        };

        if (self.CheckFeatureSupport(Feature.FormatInfo, &featureData, sizeof(FeatureDataFormatInfo)).Failure)
        {
            return 0;
        }

        return featureData.PlaneCount;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static FeatureDataCommandQueuePriority CheckCommandQueuePriority<TD3D12Device>(ref this TD3D12Device self, CommandListType commandListType)
        where TD3D12Device : unmanaged, ID3D12Device.Interface
    {
        FeatureDataCommandQueuePriority featureData = new()
        {
            CommandListType = commandListType,
        };

        if (self.CheckFeatureSupport(Feature.CommandQueuePriority, &featureData, sizeof(FeatureDataFormatInfo)).Failure)
        {
            return default;
        }

        return featureData;
    }

}
