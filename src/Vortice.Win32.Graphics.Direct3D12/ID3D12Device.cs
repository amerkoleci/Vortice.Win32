// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

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
}
