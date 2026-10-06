// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in DirectX-Graphics-Samples commit a7a87f1853b5540f10920518021d91ae641033fb
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Vortice.Win32.Graphics.Direct3D;
using Vortice.Win32.Graphics.Dxgi.Common;
using static Vortice.Win32.Apis;

namespace Vortice.Win32.Graphics.Direct3D12;

public static unsafe partial class Apis
{
    public static uint D3D12CalcSubresource(uint MipSlice, uint ArraySlice, uint PlaneSlice, uint MipLevels, uint ArraySize)
    {
        return MipSlice + ArraySlice * MipLevels + PlaneSlice * MipLevels * ArraySize;
    }

    public static bool D3D12IsLayoutOpaque(D3D12_TEXTURE_LAYOUT Layout)
    {
        return Layout == D3D12_TEXTURE_LAYOUT_UNKNOWN || Layout == D3D12_TEXTURE_LAYOUT_64KB_UNDEFINED_SWIZZLE;
    }

    public static void D3D12DecomposeSubresource(
        uint Subresource,
        uint MipLevels,
        uint ArraySize,
        out uint MipSlice,
        out uint ArraySlice,
        out uint PlaneSlice)
    {
        MipSlice = Subresource % MipLevels;
        ArraySlice = (Subresource / MipLevels) % ArraySize;
        PlaneSlice = Subresource / (MipLevels * ArraySize);
    }

    public static void MemcpySubresource(
        MemcpyDest* pDest,
        SubresourceData* pSrc,
        nuint RowSizeInBytes,
        uint NumRows,
        uint NumSlices)
    {
        for (var z = 0u; z < NumSlices; ++z)
        {
            var pDestSlice = (byte*)pDest->pData + pDest->SlicePitch * z;
            var pSrcSlice = (byte*)pSrc->pData + pSrc->SlicePitch * (nint)z;

            for (var y = 0u; y < NumRows; ++y)
            {
                Buffer.MemoryCopy(
                    pSrcSlice + pSrc->RowPitch * (nint)y,
                    pDestSlice + pDest->RowPitch * y,
                    RowSizeInBytes,
                    RowSizeInBytes
                );
            }
        }
    }

    public static void MemcpySubresource(
        MemcpyDest* pDest,
        void* pResourceData,
        SubresourceInfo* pSrc,
        nuint RowSizeInBytes, uint NumRows, uint NumSlices)
    {
        for (var z = 0u; z < NumSlices; ++z)
        {
            var pDestSlice = (byte*)pDest->pData + pDest->SlicePitch * z;
            var pSrcSlice = ((byte*)pResourceData + pSrc->Offset) + pSrc->DepthPitch * (nint)z;

            for (var y = 0u; y < NumRows; ++y)
            {
                Buffer.MemoryCopy(
                    pSrcSlice + pSrc->RowPitch * (nint)y,
                    pDestSlice + pDest->RowPitch * y,
                    (ulong)RowSizeInBytes,
                    (ulong)RowSizeInBytes
                );
            }
        }
    }

    public static byte D3D12GetFormatPlaneCount(ID3D12Device* device, Format format)
    {
        FeatureDataFormatInfo formatInfo = new()
        {
            Format = format,
            PlaneCount = 0,
        };

        if (device->CheckFeatureSupport(D3D12_FEATURE_FORMAT_INFO, &formatInfo, sizeof(FeatureDataFormatInfo)).Failure)
        {
            return 0;
        }

        return formatInfo.PlaneCount;
    }

    public static ulong GetRequiredIntermediateSize(ID3D12Resource* pDestinationResource, uint FirstSubresource, uint NumSubresources)
    {
        var Desc = pDestinationResource->GetDesc();
        ulong RequiredSize = 0;

        ID3D12Device* pDevice = null;
        _ = pDestinationResource->GetDevice(__uuidof<ID3D12Device>(), (void**)&pDevice);

        pDevice->GetCopyableFootprints(&Desc, FirstSubresource, NumSubresources, 0, null, null, null, &RequiredSize);
        _ = pDevice->Release();

        return RequiredSize;
    }



    public static ulong UpdateSubresources(
        ID3D12GraphicsCommandList* pCmdList,
        ID3D12Resource* pDestinationResource,
        ID3D12Resource* pIntermediate,
        uint FirstSubresource,
        uint NumSubresources,
        ulong RequiredSize,
        PlacedSubresourceFootprint* pLayouts,
        uint* pNumRows,
        ulong* pRowSizesInBytes,
        SubresourceData* pSrcData)
    {
        ResourceDescription IntermediateDesc = pIntermediate->GetDesc();
        ResourceDescription DestinationDesc = pDestinationResource->GetDesc();

        if (IntermediateDesc.Dimension != D3D12_RESOURCE_DIMENSION_BUFFER ||
            IntermediateDesc.Width < RequiredSize + pLayouts[0].Offset ||
            RequiredSize > unchecked((ulong)-1) ||
            (DestinationDesc.Dimension == D3D12_RESOURCE_DIMENSION_BUFFER && (FirstSubresource != 0 || NumSubresources != 1)))
        {
            return 0;
        }

        byte* pData;
        HResult hr = pIntermediate->Map(0, null, (void**)(&pData));

        if (hr.Failure)
        {
            return 0;
        }

        for (uint i = 0; i < NumSubresources; ++i)
        {
            if (pRowSizesInBytes[i] > unchecked((nuint)(-1)))
            {
                return 0;
            }

            MemcpyDest DestData = new MemcpyDest
            {
                pData = pData + pLayouts[i].Offset,
                RowPitch = pLayouts[i].Footprint.RowPitch,
                SlicePitch = pLayouts[i].Footprint.RowPitch * pNumRows[i],
            };
            MemcpySubresource(&DestData, &pSrcData[i], unchecked((nuint)(pRowSizesInBytes[i])), pNumRows[i], pLayouts[i].Footprint.Depth);
        }

        pIntermediate->Unmap(0, null);
        if (DestinationDesc.Dimension == D3D12_RESOURCE_DIMENSION_BUFFER)
        {
            pCmdList->CopyBufferRegion(pDestinationResource, 0, pIntermediate, pLayouts[0].Offset, pLayouts[0].Footprint.Width);
        }
        else
        {
            for (uint i = 0; i < NumSubresources; ++i)
            {
                TextureCopyLocation Dst = new(pDestinationResource, i + FirstSubresource);
                TextureCopyLocation Src = new(pIntermediate, pLayouts[i]);

                pCmdList->CopyTextureRegion(&Dst, 0, 0, 0, &Src, null);
            }
        }

        return RequiredSize;
    }

    public static ulong UpdateSubresources(
        ID3D12GraphicsCommandList* pCmdList,
        ID3D12Resource* pDestinationResource,
        ID3D12Resource* pIntermediate,
        uint FirstSubresource,
        uint NumSubresources,
        ulong RequiredSize,
        PlacedSubresourceFootprint* pLayouts,
        uint* pNumRows,
        ulong* pRowSizesInBytes,
        void* pResourceData,
        SubresourceInfo* pSrcData)
    {
        var IntermediateDesc = pIntermediate->GetDesc();
        var DestinationDesc = pDestinationResource->GetDesc();

        if (IntermediateDesc.Dimension != D3D12_RESOURCE_DIMENSION_BUFFER ||
            IntermediateDesc.Width < RequiredSize + pLayouts[0].Offset ||
            RequiredSize > unchecked((nuint)(-1)) ||
            (DestinationDesc.Dimension == D3D12_RESOURCE_DIMENSION_BUFFER && (FirstSubresource != 0 || NumSubresources != 1)))
        {
            return 0;
        }

        byte* pData;
        HResult hr = pIntermediate->Map(0, null, (void**)&pData);

        if (hr.Failure)
        {
            return 0;
        }

        for (var i = 0u; i < NumSubresources; ++i)
        {
            if (pRowSizesInBytes[i] > unchecked((nuint)(-1)))
            {
                return 0;
            }

            MemcpyDest DestData = new MemcpyDest
            {
                pData = pData + pLayouts[i].Offset,
                RowPitch = (nuint)pLayouts[i].Footprint.RowPitch,
                SlicePitch = (nuint)(pLayouts[i].Footprint.RowPitch * pNumRows[i])
            };

            MemcpySubresource(&DestData, pResourceData, &pSrcData[i], (nuint)pRowSizesInBytes[i], pNumRows[i], pLayouts[i].Footprint.Depth);
        }
        pIntermediate->Unmap(0, null);

        if (DestinationDesc.Dimension == D3D12_RESOURCE_DIMENSION_BUFFER)
        {
            pCmdList->CopyBufferRegion(pDestinationResource, 0, pIntermediate, pLayouts[0].Offset, pLayouts[0].Footprint.Width);
        }
        else
        {
            for (var i = 0u; i < NumSubresources; ++i)
            {
                TextureCopyLocation Dst = new(pDestinationResource, i + FirstSubresource);
                TextureCopyLocation Src = new(pIntermediate, pLayouts[i]);
                pCmdList->CopyTextureRegion(&Dst, 0, 0, 0, &Src, null);
            }
        }
        return RequiredSize;
    }

    public static ulong UpdateSubresources(
        ID3D12GraphicsCommandList* pCmdList,
        ID3D12Resource* pDestinationResource,
        ID3D12Resource* pIntermediate,
        ulong IntermediateOffset,
        uint FirstSubresource,
        uint NumSubresources,
        SubresourceData* pSrcData)
    {
        ulong RequiredSize = 0;
        ulong MemToAlloc = (ulong)(sizeof(PlacedSubresourceFootprint) + sizeof(uint) + sizeof(ulong)) * NumSubresources;

        if (MemToAlloc > unchecked((nuint)(-1)))
        {
            return 0;
        }

        var pMem = HeapAlloc(GetProcessHeap(), 0, (nuint)MemToAlloc);

        if (pMem == null)
        {
            return 0;
        }

        var pLayouts = (PlacedSubresourceFootprint*)pMem;
        ulong* pRowSizesInBytes = (ulong*)(pLayouts + NumSubresources);
        uint* pNumRows = (uint*)(pRowSizesInBytes + NumSubresources);

        var Desc = pDestinationResource->GetDesc();

        ID3D12Device* pDevice = null;
        _ = pDestinationResource->GetDevice(__uuidof<ID3D12Device>(), (void**)&pDevice);

        pDevice->GetCopyableFootprints(&Desc, FirstSubresource, NumSubresources, IntermediateOffset, pLayouts, pNumRows, pRowSizesInBytes, &RequiredSize);
        _ = pDevice->Release();

        ulong Result = UpdateSubresources(pCmdList, pDestinationResource, pIntermediate, FirstSubresource, NumSubresources, RequiredSize, pLayouts, pNumRows, pRowSizesInBytes, pSrcData);
        _ = HeapFree(GetProcessHeap(), 0, pMem);
        return Result;
    }

    public static ulong UpdateSubresources(
        ID3D12GraphicsCommandList* pCmdList,
        ID3D12Resource* pDestinationResource,
        ID3D12Resource* pIntermediate,
        ulong IntermediateOffset,
        uint FirstSubresource,
        uint NumSubresources,
        void* pResourceData,
        SubresourceInfo* pSrcData)
    {
        ulong RequiredSize = 0;
        ulong MemToAlloc = (ulong)(sizeof(PlacedSubresourceFootprint) + sizeof(uint) + sizeof(ulong)) * NumSubresources;

        if (MemToAlloc > unchecked((nuint)(-1)))
        {
            return 0;
        }

        var pMem = HeapAlloc(GetProcessHeap(), 0, (nuint)MemToAlloc);

        if (pMem == null)
        {
            return 0;
        }

        var pLayouts = (PlacedSubresourceFootprint*)pMem;
        ulong* pRowSizesInBytes = (ulong*)(pLayouts + NumSubresources);
        uint* pNumRows = (uint*)(pRowSizesInBytes + NumSubresources);

        var Desc = pDestinationResource->GetDesc();

        ID3D12Device* pDevice = null;
        _ = pDestinationResource->GetDevice(__uuidof<ID3D12Device>(), (void**)&pDevice);

        pDevice->GetCopyableFootprints(&Desc, FirstSubresource, NumSubresources, IntermediateOffset, pLayouts, pNumRows, pRowSizesInBytes, &RequiredSize);
        _ = pDevice->Release();

        ulong Result = UpdateSubresources(pCmdList, pDestinationResource, pIntermediate, FirstSubresource, NumSubresources, RequiredSize, pLayouts, pNumRows, pRowSizesInBytes, pResourceData, pSrcData);
        _ = HeapFree(GetProcessHeap(), 0, pMem);
        return Result;
    }

    public static ulong UpdateSubresources(
        uint MaxSubresources,
        ID3D12GraphicsCommandList* pCmdList,
        ID3D12Resource* pDestinationResource,
        ID3D12Resource* pIntermediate,
        ulong IntermediateOffset,
        uint FirstSubresource,
        uint NumSubresources,
        SubresourceData* pSrcData)
    {
        ulong RequiredSize = 0;
        PlacedSubresourceFootprint* Layouts = stackalloc PlacedSubresourceFootprint[(int)MaxSubresources];
        uint* NumRows = stackalloc uint[(int)MaxSubresources];
        ulong* RowSizesInBytes = stackalloc ulong[(int)MaxSubresources];

        var Desc = pDestinationResource->GetDesc();

        ID3D12Device* pDevice = null;
        _ = pDestinationResource->GetDevice(__uuidof<ID3D12Device>(), (void**)&pDevice);

        pDevice->GetCopyableFootprints(&Desc, FirstSubresource, NumSubresources, IntermediateOffset, Layouts, NumRows, RowSizesInBytes, &RequiredSize);
        _ = pDevice->Release();

        return UpdateSubresources(pCmdList, pDestinationResource, pIntermediate, FirstSubresource, NumSubresources, RequiredSize, Layouts, NumRows, RowSizesInBytes, pSrcData);
    }

    public static ulong UpdateSubresources(
        uint MaxSubresources,
        ID3D12GraphicsCommandList* pCmdList,
        ID3D12Resource* pDestinationResource,
        ID3D12Resource* pIntermediate,
        ulong IntermediateOffset,
        uint FirstSubresource,
        uint NumSubresources,
        void* pResourceData,
        SubresourceInfo* pSrcData)
    {
        ulong RequiredSize = 0;
        PlacedSubresourceFootprint* Layouts = stackalloc PlacedSubresourceFootprint[(int)MaxSubresources];
        uint* NumRows = stackalloc uint[(int)MaxSubresources];
        ulong* RowSizesInBytes = stackalloc ulong[(int)MaxSubresources];

        var Desc = pDestinationResource->GetDesc();

        ID3D12Device* pDevice = null;
        _ = pDestinationResource->GetDevice(__uuidof<ID3D12Device>(), (void**)&pDevice);

        pDevice->GetCopyableFootprints(&Desc, FirstSubresource, NumSubresources, IntermediateOffset, Layouts, NumRows, RowSizesInBytes, &RequiredSize);
        _ = pDevice->Release();

        return UpdateSubresources(pCmdList, pDestinationResource, pIntermediate, FirstSubresource, NumSubresources, RequiredSize, Layouts, NumRows, RowSizesInBytes, pResourceData, pSrcData);
    }

    public static ID3D12CommandList** CommandListCast([NativeTypeName("ID3D12GraphicsCommandList * const *")] ID3D12GraphicsCommandList** pp)
    {
        return (ID3D12CommandList**)pp;
    }

    public static HResult D3D12SerializeVersionedRootSignature(
        VersionedRootSignatureDescription* pRootSignatureDesc,
        D3D_ROOT_SIGNATURE_VERSION MaxVersion,
        ID3DBlob** ppBlob,
        ID3DBlob** ppErrorBlob)
    {
        if (ppErrorBlob != null)
        {
            *ppErrorBlob = null;
        }

        switch (MaxVersion)
        {
            case D3D_ROOT_SIGNATURE_VERSION_1_0:
                switch (pRootSignatureDesc->Version)
                {
                    case D3D_ROOT_SIGNATURE_VERSION_1_0:
                        return D3D12SerializeRootSignature(&pRootSignatureDesc->Anonymous.Desc_1_0, D3D_ROOT_SIGNATURE_VERSION_1_0, ppBlob, ppErrorBlob);

                    case D3D_ROOT_SIGNATURE_VERSION_1_1:
                        {
                            HResult hr = HResult.Ok;
                            ref readonly RootSignatureDescription1 desc_1_1 = ref pRootSignatureDesc->Anonymous.Desc_1_1;

                            nuint ParametersSize = (uint)sizeof(RootParameter) * desc_1_1.NumParameters;
                            void* pParameters = ((ulong)ParametersSize > 0) ? HeapAlloc(GetProcessHeap(), 0, ParametersSize) : null;

                            if ((ulong)ParametersSize > 0 && pParameters == null)
                            {
                                hr = HResult.OutOfMemory;
                            }

                            var pParameters_1_0 = (RootParameter*)pParameters;

                            if (hr.Success)
                            {
                                for (uint n = 0; n < desc_1_1.NumParameters; n++)
                                {
                                    Debug.Assert((long)ParametersSize == (sizeof(RootParameter) * desc_1_1.NumParameters));

                                    pParameters_1_0[n].ParameterType = desc_1_1.pParameters[n].ParameterType;
                                    pParameters_1_0[n].ShaderVisibility = desc_1_1.pParameters[n].ShaderVisibility;

                                    switch (desc_1_1.pParameters[n].ParameterType)
                                    {
                                        case D3D12_ROOT_PARAMETER_TYPE_32BIT_CONSTANTS:
                                            pParameters_1_0[n].Anonymous.Constants.Num32BitValues = desc_1_1.pParameters[n].Anonymous.Constants.Num32BitValues;
                                            pParameters_1_0[n].Anonymous.Constants.RegisterSpace = desc_1_1.pParameters[n].Anonymous.Constants.RegisterSpace;
                                            pParameters_1_0[n].Anonymous.Constants.ShaderRegister = desc_1_1.pParameters[n].Anonymous.Constants.ShaderRegister;
                                            break;

                                        case D3D12_ROOT_PARAMETER_TYPE_CBV:
                                        case D3D12_ROOT_PARAMETER_TYPE_SRV:
                                        case D3D12_ROOT_PARAMETER_TYPE_UAV:
                                            pParameters_1_0[n].Anonymous.Descriptor.RegisterSpace = desc_1_1.pParameters[n].Anonymous.Descriptor.RegisterSpace;
                                            pParameters_1_0[n].Anonymous.Descriptor.ShaderRegister = desc_1_1.pParameters[n].Anonymous.Descriptor.ShaderRegister;
                                            break;

                                        case D3D12_ROOT_PARAMETER_TYPE_DESCRIPTOR_TABLE:
                                            ref readonly RootDescriptorTable1 table_1_1 = ref desc_1_1.pParameters[n].Anonymous.DescriptorTable;

                                            nuint DescriptorRangesSize = (uint)sizeof(DescriptorRange) * table_1_1.NumDescriptorRanges;
                                            void* pDescriptorRanges = ((ulong)DescriptorRangesSize > 0 && hr.Success) ? HeapAlloc(GetProcessHeap(), 0, DescriptorRangesSize) : null;

                                            if ((ulong)DescriptorRangesSize > 0 && pDescriptorRanges == null)
                                            {
                                                hr = HResult.OutOfMemory;
                                            }

                                            var pDescriptorRanges_1_0 = (DescriptorRange*)pDescriptorRanges;

                                            if (hr.Success)
                                            {
                                                for (uint x = 0; x < table_1_1.NumDescriptorRanges; x++)
                                                {
                                                    Debug.Assert((long)DescriptorRangesSize == (sizeof(DescriptorRange) * table_1_1.NumDescriptorRanges));

                                                    pDescriptorRanges_1_0[x].BaseShaderRegister = table_1_1.pDescriptorRanges[x].BaseShaderRegister;
                                                    pDescriptorRanges_1_0[x].NumDescriptors = table_1_1.pDescriptorRanges[x].NumDescriptors;
                                                    pDescriptorRanges_1_0[x].OffsetInDescriptorsFromTableStart = table_1_1.pDescriptorRanges[x].OffsetInDescriptorsFromTableStart;
                                                    pDescriptorRanges_1_0[x].RangeType = table_1_1.pDescriptorRanges[x].RangeType;
                                                    pDescriptorRanges_1_0[x].RegisterSpace = table_1_1.pDescriptorRanges[x].RegisterSpace;
                                                }
                                            }

                                            ref RootDescriptorTable table_1_0 = ref pParameters_1_0[n].Anonymous.DescriptorTable;
                                            table_1_0.NumDescriptorRanges = table_1_1.NumDescriptorRanges;
                                            table_1_0.pDescriptorRanges = pDescriptorRanges_1_0;
                                            break;
                                    }
                                }
                            }

                            if (hr.Success)
                            {
                                RootSignatureDescription desc_1_0 = new RootSignatureDescription(desc_1_1.NumParameters, pParameters_1_0, desc_1_1.NumStaticSamplers, desc_1_1.pStaticSamplers, desc_1_1.Flags);
                                hr = D3D12SerializeRootSignature(&desc_1_0, D3D_ROOT_SIGNATURE_VERSION_1_0 , ppBlob, ppErrorBlob);
                            }

                            if (pParameters != null)
                            {
                                for (uint n = 0; n < desc_1_1.NumParameters; n++)
                                {
                                    if (desc_1_1.pParameters[n].ParameterType == D3D12_ROOT_PARAMETER_TYPE_DESCRIPTOR_TABLE)
                                    {
                                        _ = HeapFree(GetProcessHeap(), 0, (void*)pParameters_1_0[n].Anonymous.DescriptorTable.pDescriptorRanges);
                                    }
                                }

                                _ = HeapFree(GetProcessHeap(), 0, pParameters);
                            }

                            return hr;
                        }
                }
                break;

            case D3D_ROOT_SIGNATURE_VERSION_1_1:
                return D3D12SerializeVersionedRootSignature(pRootSignatureDesc, ppBlob, ppErrorBlob);
        }

        return HResult.InvalidArg;
    }

    public static uint D3D12_ENCODE_SHADER_4_COMPONENT_MAPPING(D3D12_SHADER_COMPONENT_MAPPING Src0, D3D12_SHADER_COMPONENT_MAPPING Src1, D3D12_SHADER_COMPONENT_MAPPING Src2, D3D12_SHADER_COMPONENT_MAPPING Src3)
    {
        return ((uint)Src0 & D3D12_SHADER_COMPONENT_MAPPING_MASK)
            | (((uint)Src1 & D3D12_SHADER_COMPONENT_MAPPING_MASK) << unchecked((int)D3D12_SHADER_COMPONENT_MAPPING_SHIFT))
            | (((uint)Src2 & D3D12_SHADER_COMPONENT_MAPPING_MASK) << (unchecked((int)D3D12_SHADER_COMPONENT_MAPPING_SHIFT) * 2))
            | (((uint)Src3 & D3D12_SHADER_COMPONENT_MAPPING_MASK) << (unchecked((int)D3D12_SHADER_COMPONENT_MAPPING_SHIFT) * 3))
            | D3D12_SHADER_COMPONENT_MAPPING_ALWAYS_SET_BIT_AVOIDING_ZEROMEM_MISTAKES;
    }

    public static D3D12_SHADER_COMPONENT_MAPPING D3D12_DECODE_SHADER_4_COMPONENT_MAPPING(int ComponentToExtract, uint Mapping) => (D3D12_SHADER_COMPONENT_MAPPING)((Mapping >> (unchecked((int)D3D12_SHADER_COMPONENT_MAPPING_SHIFT) * ComponentToExtract)) & D3D12_SHADER_COMPONENT_MAPPING_MASK);

    public static D3D12_FILTER D3D12_ENCODE_BASIC_FILTER(D3D12_FILTER_TYPE min, D3D12_FILTER_TYPE mag, D3D12_FILTER_TYPE mip, D3D12_FILTER_REDUCTION_TYPE reduction)
    {
        return (D3D12_FILTER)((((uint)min & D3D12_FILTER_TYPE_MASK) << unchecked((int)D3D12_MIN_FILTER_SHIFT))
                            | (((uint)mag & D3D12_FILTER_TYPE_MASK) << unchecked((int)D3D12_MAG_FILTER_SHIFT))
                            | (((uint)mip & D3D12_FILTER_TYPE_MASK) << unchecked((int)D3D12_MIP_FILTER_SHIFT))
                            | (((uint)reduction & D3D12_FILTER_REDUCTION_TYPE_MASK) << unchecked((int)D3D12_FILTER_REDUCTION_TYPE_SHIFT)));
    }

    public static D3D12_FILTER D3D12_ENCODE_ANISOTROPIC_FILTER(D3D12_FILTER_REDUCTION_TYPE reduction) => (D3D12_FILTER)(D3D12_ANISOTROPIC_FILTERING_BIT | (uint)D3D12_ENCODE_BASIC_FILTER(D3D12_FILTER_TYPE_LINEAR, D3D12_FILTER_TYPE_LINEAR, D3D12_FILTER_TYPE_LINEAR, reduction));

    public static D3D12_FILTER D3D12_ENCODE_MIN_MAG_ANISOTROPIC_MIP_POINT_FILTER(D3D12_FILTER_REDUCTION_TYPE reduction) => (D3D12_FILTER)(D3D12_ANISOTROPIC_FILTERING_BIT) | D3D12_ENCODE_BASIC_FILTER(D3D12_FILTER_TYPE_LINEAR, D3D12_FILTER_TYPE_LINEAR, D3D12_FILTER_TYPE_POINT, reduction);

    public static D3D12_FILTER_TYPE D3D12_DECODE_MIN_FILTER(D3D12_FILTER D3D12Filter) => (D3D12_FILTER_TYPE)(((uint)D3D12Filter >> unchecked((int)D3D12_MIN_FILTER_SHIFT)) & D3D12_FILTER_TYPE_MASK);

    public static D3D12_FILTER_TYPE D3D12_DECODE_MAG_FILTER(D3D12_FILTER D3D12Filter) => (D3D12_FILTER_TYPE)(((uint)D3D12Filter >> unchecked((int)D3D12_MAG_FILTER_SHIFT)) & D3D12_FILTER_TYPE_MASK);

    public static D3D12_FILTER_TYPE D3D12_DECODE_MIP_FILTER(D3D12_FILTER D3D12Filter) => (D3D12_FILTER_TYPE)(((uint)D3D12Filter >> unchecked((int)D3D12_MIP_FILTER_SHIFT)) & D3D12_FILTER_TYPE_MASK);

    public static D3D12_FILTER_REDUCTION_TYPE D3D12_DECODE_FILTER_REDUCTION(D3D12_FILTER D3D12Filter) => (D3D12_FILTER_REDUCTION_TYPE)(((uint)D3D12Filter >> unchecked((int)D3D12_FILTER_REDUCTION_TYPE_SHIFT)) & D3D12_FILTER_REDUCTION_TYPE_MASK);

    public static bool D3D12_DECODE_IS_COMPARISON_FILTER(D3D12_FILTER D3D12Filter) => D3D12_DECODE_FILTER_REDUCTION(D3D12Filter) == D3D12_FILTER_REDUCTION_TYPE_COMPARISON;

    public static bool D3D12_DECODE_IS_ANISOTROPIC_FILTER(D3D12_FILTER D3D12Filter)
    {
        return (((uint)D3D12Filter & D3D12_ANISOTROPIC_FILTERING_BIT) != 0)
            && (D3D12_FILTER_TYPE_LINEAR == D3D12_DECODE_MIN_FILTER(D3D12Filter))
            && (D3D12_FILTER_TYPE_LINEAR == D3D12_DECODE_MAG_FILTER(D3D12Filter))
            && (D3D12_FILTER_TYPE_LINEAR == D3D12_DECODE_MIP_FILTER(D3D12Filter));
    }

    public static uint D3D12_MAKE_COARSE_SHADING_RATE(uint x, uint y) => (x << unchecked((int)D3D12_SHADING_RATE_X_AXIS_SHIFT)) | y;

    public static uint D3D12_GET_COARSE_SHADING_RATE_X_AXIS(uint x) => (x >> unchecked((int)D3D12_SHADING_RATE_X_AXIS_SHIFT)) & D3D12_SHADING_RATE_VALID_MASK;

    public static uint D3D12_GET_COARSE_SHADING_RATE_Y_AXIS(uint y) => y & D3D12_SHADING_RATE_VALID_MASK;
}
