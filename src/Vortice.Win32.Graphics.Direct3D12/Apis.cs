// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in DirectX-Graphics-Samples commit a7a87f1853b5540f10920518021d91ae641033fb
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Win32.Graphics.Direct3D;
using Win32.Graphics.Dxgi.Common;
using static Win32.Apis;

namespace Win32.Graphics.Direct3D12;

public static unsafe partial class Apis
{
    public static uint D3D12CalcSubresource(uint MipSlice, uint ArraySlice, uint PlaneSlice, uint MipLevels, uint ArraySize)
    {
        return MipSlice + ArraySlice * MipLevels + PlaneSlice * MipLevels * ArraySize;
    }

    public static bool D3D12IsLayoutOpaque(TextureLayout Layout)
    {
        return Layout == TextureLayout.Unknown || Layout == TextureLayout.L64KbUndefinedSwizzle;
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
        FeatureDataFormatInfo formatInfo = new FeatureDataFormatInfo
        {
            Format = format,
            PlaneCount = 0,
        };

        if (device->CheckFeatureSupport(Feature.FormatInfo, &formatInfo, sizeof(FeatureDataFormatInfo)).Failure)
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

        if (IntermediateDesc.Dimension != ResourceDimension.Buffer ||
            IntermediateDesc.Width < RequiredSize + pLayouts[0].Offset ||
            RequiredSize > unchecked((ulong)-1) ||
            (DestinationDesc.Dimension == ResourceDimension.Buffer && (FirstSubresource != 0 || NumSubresources != 1)))
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
        if (DestinationDesc.Dimension == ResourceDimension.Buffer)
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

        if (IntermediateDesc.Dimension != ResourceDimension.Buffer ||
            IntermediateDesc.Width < RequiredSize + pLayouts[0].Offset ||
            RequiredSize > unchecked((nuint)(-1)) ||
            (DestinationDesc.Dimension == ResourceDimension.Buffer && (FirstSubresource != 0 || NumSubresources != 1)))
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

        if (DestinationDesc.Dimension == ResourceDimension.Buffer)
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
        RootSignatureVersion MaxVersion,
        ID3DBlob** ppBlob,
        ID3DBlob** ppErrorBlob)
    {
        if (ppErrorBlob != null)
        {
            *ppErrorBlob = null;
        }

        switch (MaxVersion)
        {
            case RootSignatureVersion.V1_0:
                switch (pRootSignatureDesc->Version)
                {
                    case RootSignatureVersion.V1_0:
                        return D3D12SerializeRootSignature(&pRootSignatureDesc->Anonymous.Desc_1_0, RootSignatureVersion.V1_0, ppBlob, ppErrorBlob);

                    case RootSignatureVersion.V1_1:
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
                                        case RootParameterType.T32BitConstants:
                                            pParameters_1_0[n].Anonymous.Constants.Num32BitValues = desc_1_1.pParameters[n].Anonymous.Constants.Num32BitValues;
                                            pParameters_1_0[n].Anonymous.Constants.RegisterSpace = desc_1_1.pParameters[n].Anonymous.Constants.RegisterSpace;
                                            pParameters_1_0[n].Anonymous.Constants.ShaderRegister = desc_1_1.pParameters[n].Anonymous.Constants.ShaderRegister;
                                            break;

                                        case RootParameterType.Cbv:
                                        case RootParameterType.Srv:
                                        case RootParameterType.Uav:
                                            pParameters_1_0[n].Anonymous.Descriptor.RegisterSpace = desc_1_1.pParameters[n].Anonymous.Descriptor.RegisterSpace;
                                            pParameters_1_0[n].Anonymous.Descriptor.ShaderRegister = desc_1_1.pParameters[n].Anonymous.Descriptor.ShaderRegister;
                                            break;

                                        case RootParameterType.DescriptorTable:
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
                                hr = D3D12SerializeRootSignature(&desc_1_0, RootSignatureVersion.V1_0 , ppBlob, ppErrorBlob);
                            }

                            if (pParameters != null)
                            {
                                for (uint n = 0; n < desc_1_1.NumParameters; n++)
                                {
                                    if (desc_1_1.pParameters[n].ParameterType == RootParameterType.DescriptorTable)
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

            case RootSignatureVersion.V1_1:
                return D3D12SerializeVersionedRootSignature(pRootSignatureDesc, ppBlob, ppErrorBlob);
        }

        return HResult.InvalidArg;
    }
}
