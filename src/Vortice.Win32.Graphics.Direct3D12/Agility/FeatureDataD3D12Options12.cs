// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D12;

/// <unmanaged>D3D12_FEATURE_DATA_D3D12_OPTIONS12</unmanaged>
public partial struct FeatureDataD3D12Options12
{
    public TriState MSPrimitivesPipelineStatisticIncludesCulledPrimitives;
    public Bool32 EnhancedBarriersSupported;
    public Bool32 RelaxedFormatCastingSupported;
}
