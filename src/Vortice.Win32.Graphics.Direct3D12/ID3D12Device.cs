// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Dxgi;

namespace Win32.Graphics.Direct3D12;

public unsafe partial struct ID3D12Device
{
    public TFeature CheckFeatureSupport<TFeature>(Feature feature)
        where TFeature : unmanaged
    {
        TFeature featureData = default;
        CheckFeatureSupport(feature, &featureData, sizeof(TFeature)).ThrowIfFailed();
        return featureData;
    }

    public HResult CheckFeatureSupport<TFeature>(Feature feature, ref TFeature featureData)
        where TFeature : unmanaged
    {
        fixed (TFeature* featureDataPtr = &featureData)
        {
            return CheckFeatureSupport(feature, featureDataPtr, sizeof(TFeature));
        }
    }

    public HResult CreateCommittedResource(HeapType heapType, ResourceDescription* pDesc, ResourceStates InitialResourceState, ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource)
    {
        HeapProperties heapProperties = new(heapType);
        return CreateCommittedResource(&heapProperties, HeapFlags.None, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
    }
}
