// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System;
using System.Globalization;
using System.Text;
using Newtonsoft.Json;

namespace Generator;

public static class Program
{
    private static readonly string[] jsons = new[]
    {
        "Graphics.json",
        "Graphics.Dxgi.Common.json",
        "Graphics.Dxgi.json",
        "Graphics.Direct3D.json",
        "Graphics.Direct3D11.json",
        "Graphics.Direct3D12.json",
        "Graphics.Direct3D.Dxc.json",
        "Graphics.Direct2D.Common.json",
        "Graphics.Imaging.json",
        "Graphics.DirectWrite.json",
        "Graphics.Direct2D.json",
        "Graphics.Imaging.D2D.json",
    };

    private static readonly Dictionary<string, string> s_csNameMappings = new()
    {
        {"Void", "void" },
        {"Byte", "byte" },
        {"SByte", "sbyte" },
        {"Int8", "sbyte" },
        {"Int16", "short" },
        {"Int32", "int" },
        {"Int64", "long" },
        {"UInt8", "byte" },
        {"UInt16", "ushort" },
        {"UInt32", "uint" },
        {"UInt64", "ulong" },
        {"Single", "float" },
        {"Double", "double" },

        {"IntPtr", "nint" },
        {"UIntPtr", "nuint" },

        {"Char", "ushort" },

        { "Foundation.BOOL", "Bool32" },
        { "Foundation.BOOLEAN", "byte" },
        { "Foundation.BSTR", "char*" },
        { "Foundation.HANDLE", "IntPtr" },
        { "Foundation.HINSTANCE", "IntPtr" },
        { "Foundation.HRESULT", "HResult" },
        { "Foundation.HWND", "IntPtr" },
        { "Foundation.LPARAM", "IntPtr" },
        { "Foundation.LRESULT", "IntPtr" },
        { "Foundation.WPARAM", "UIntPtr" },
        { "Foundation.PSTR", "sbyte*" },
        { "Foundation.PWSTR", "ushort*" },
        { "Foundation.CHAR", "byte" },

        { "Foundation.LUID", "Luid" },
        { "Foundation.LARGE_INTEGER", "LargeInteger" },
        { "Foundation.ULARGE_INTEGER", "ULargeInteger" },
        { "Foundation.FILETIME", "ulong" },

        { "System.Com.IUnknown", "IUnknown" },
        { "System.Com.ISequentialStream", "Com.ISequentialStream" },
        { "System.Com.IStream", "Com.IStream" },
        { "System.Com.IMalloc", "Com.IMalloc" },
        { "System.Com.IEnumUnknown", "Com.IEnumUnknown" },
        { "System.Com.IEnumString", "Com.IEnumString" },
        { "System.Com.StructuredStorage.PROPVARIANT", "Com.Variant" },
        { "System.Com.StructuredStorage.PROPBAG2", "Com.PropertyBagMetadata" },
        { "System.Com.StructuredStorage.IPropertyBag2", "Com.IPropertyBag2" },

        { "Graphics.Gdi.HMONITOR", "IntPtr" },
        { "Graphics.Gdi.HDC", "IntPtr" },
        { "Graphics.Gdi.HBITMAP", "IntPtr" },
        { "Graphics.Gdi.HPALETTE", "IntPtr" },
        { "UI.WindowsAndMessaging.HICON", "IntPtr" },
        { "Globalization.FONTSIGNATURE", "Win32.Graphics.Gdi.FontSignature" },
        { "Graphics.Gdi.LOGFONTA", "Win32.Graphics.Gdi.LogFontA" },
        { "Graphics.Gdi.LOGFONTW", "Win32.Graphics.Gdi.LogFontW" },

        { "Graphics.Direct3D.D3DVECTOR", "Vector3" },
        { "Graphics.Direct3D.D3DMATRIX", "Matrix4x4" },
        { "Graphics.Direct2D.Common.D2D_MATRIX_3X2_F", "Matrix3x2" },
        { "Graphics.Direct2D.Common.D2D_MATRIX_4X3_F", "Win32.Graphics.Direct2D.Common.Matrix4x3" },
        { "Graphics.Direct2D.Common.D2D_MATRIX_4X4_F", "Matrix4x4" },
        { "Graphics.Direct2D.Common.D2D_MATRIX_5X4_F", "Win32.Graphics.Direct2D.Common.Matrix5x4" },
        { "Graphics.Direct2D.Common.D2D_POINT_2F", "System.Drawing.PointF" },
        { "Graphics.Direct2D.Common.D2D_VECTOR_2F", "Vector2" },
        { "Graphics.Direct2D.Common.D2D_VECTOR_3F", "Vector3" },
        { "Graphics.Direct2D.Common.D2D_VECTOR_4F", "Vector4" },
        { "Graphics.Direct2D.Common.D2D_SIZE_F", "System.Drawing.SizeF" },
        { "Graphics.Direct2D.Common.D2D_POINT_2U", "System.Drawing.Point" },
        { "Graphics.Direct2D.Common.D2D_SIZE_U", "System.Drawing.Size" },

        { "Graphics.Imaging.WICRect", "System.Drawing.Rectangle" },

        { "Graphics.DirectWrite.DWRITE_COLOR_F", "Win32.Graphics.Direct2D.Common.ColorF" },
        { "Graphics.Direct2D.Matrix4x3F", "Win32.Graphics.Direct2D.Common.Matrix4x3" },
        { "Graphics.Direct2D.Matrix4x4F", "Matrix4x4" },
        { "Graphics.Direct2D.Matrix5x4F", "Win32.Graphics.Direct2D.Common.Matrix5x4" },

        // TODO: Understand those ->
        { "Foundation.RECT", "RawRect" },
        { "Foundation.RECTL", "RawRect" },
        { "Foundation.POINT", "System.Drawing.Point" },
        { "Foundation.POINTL", "System.Drawing.Point" },
        { "Foundation.SIZE", "System.Drawing.Size" },
    };

    private static readonly Dictionary<string, string> s_partRenames = new()
    {
        { "NONPREROTATED", "NonPrerotated" },
        { "POINTLIST", "PointList" },
        { "LINELIST", "LineList" },
        { "LINESTRIP", "LineStrip" },
        { "TRIANGLELIST", "TriangleList" },
        { "TRIANGLESTRIP", "TriangleStrip" },
        { "PATCHLIST", "PatchList" },

        { "CBUFFER", "CBuffer" },
        { "TBUFFER", "TBuffer" },
        { "NOPERSPECTIVE", "NoPerspective" },
        { "TEXTURE1D", "Texture1D" },
        { "TEXTURE1DARRAY", "Texture1DArray" },
        { "TEXTURE2D", "Texture2D" },
        { "TEXTURE2DARRAY", "Texture2DArray" },
        { "TEXTURE2DMS", "Texture2DMs" },
        { "TEXTURE2DMSARRAY", "Texture2DMsArray" },
        { "TEXTURE3D", "Texture3D" },
        { "TEXTURECUBE", "TextureCube" },
        { "TEXTURECUBEARRAY", "TextureCubeArray" },
        { "RWTEXTURE1D", "RwTexture1D" },
        { "RWTEXTURE1DARRAY", "RwTexture1DArray" },
        { "RWTEXTURE2D", "RwTexture2D" },
        { "RWTEXTURE2DARRAY", "RwTexture2DArray" },
        { "RWTEXTURE3D", "RwTexture3D" },
        { "RWBUFFER", "RwBuffer" },
        { "BUFFEREX", "BufferExtended" },
        { "USERPACKED", "UserPacked" },
        { "SAMPLER1D", "Sampler1D" },
        { "SAMPLER2D", "Sampler2D" },
        { "SAMPLER3D", "Sampler3D" },
        { "SAMPLERCUBE", "SamplerCube" },
        { "RWTYPED", "RwTyped" },
        { "RWSTRUCTURED", "RwStructured" },
        { "BYTEADDRESS", "ByteAddress" },
        { "RWBYTEADDRESS", "RwByteAddress" },
        { "RTACCELERATIONSTRUCTURE", "RtAccelerationStructure" },
        { "FEEDBACKTEXTURE", "FeedbackTexture" },
        { "TESSFACTOR", "TessFactor" },
        { "SHADINGRATE", "ShadingRate" },
        { "CULLPRIMITIVE", "CullPrimitive" },
        { "VERTEXSHADER", "VertexShader" },
        { "PIXELSHADER", "PixelShader" },
        { "VERTEXFRAGMENT", "VertexFragment" },
        { "PIXELFRAGMENT", "PixelFragment" },
        { "GEOMETRYSHADER", "GeometryShader" },
        { "DOMAINSHADER", "DomainShader" },
        { "COMPUTESHADER", "ComputeShader" },
        { "DEPTHSTENCIL", "DepthStencil" },
        { "RENDERTARGETVIEW", "RenderTargetView" },
        { "DEPTHSTENCILVIEW", "DepthStencilView" },
        { "MIN8FLOAT", "Min8Float" },
        { "MIN10FLOAT", "Min10Float" },
        { "MIN16FLOAT", "Min16Float" },
        { "MIN12INT", "Min12Int" },
        { "MIN16INT", "Min16Int" },
        { "MIN16UINT", "Min16Uint" },
        { "KEYEDMUTEX", "KeyedMutex" },
        { "GETDATA", "GetData" },
        { "DONOTFLUSH", "DoNotFlush" },
        { "PREDICATEHINT", "PredicateHint" },
        { "TEX1D", "Texture1D" },
        { "TEX2D", "Texture2D" },
        { "TEX3D", "Texture3D" },
        { "TEX2DMS", "Texture2DMs" },
        { "TEXCUBE", "TexureCube" },

        //{ "IB", "Ib" },
        { "SINGLETHREADED", "SingleThreaded" },
        { "SUBOBJECT", "SubObject" },
        { "GROUPSHARED", "GroupShared" },
        { "DEVICEMEMORY", "DeviceMemory" },
        { "WRITEBUFFERIMMEDIATE", "WriteBufferImmediate" },
        { "OVERBUDGET", "OverBudget" },
        { "SETMARKER", "SetMarker" },
        { "BEGINEVENT", "BeginEvent" },
        { "ENDEVENT", "EndEvent" },
        { "CRYPTOSESSION", "CryptoSession" },
        { "CRYPTOSESSIONPOLICY", "CryptoSessionPolicy" },
        { "PROTECTEDRESOURCESESSION", "ProtectedResourceSession" },
        { "METACOMMAND", "MetaCommand" },
        { "SCHEDULINGGROUP", "SchedulingGroup" },
    };

    private static readonly HashSet<string> s_partRenamesSet = new(StringComparer.OrdinalIgnoreCase)
    {
        "DispatchMesh",
        "EncodeFrame",
        "DrawInstanced",
        "DrawIndexedInstanced",
        "ExecuteIndirect",
        "CopyBufferRegion",
        "CopyTextureRegion",
        "CopyResource",
        "CopyTiles",
        "ResolveSubresource",
        "ClearRenderTargetView",
        "ClearUnorderedAccessView",
        "ClearDepthStencilView",
        "ResourceBarrier",
        "ExecuteBundle",
        "ResolveQueryData",
        "BeginSubmission",
        "EndSubmission",
        "DecodeFrame",
        "DecodeFrame1",
        "DecodeFrame2",
        "ProcessFrames",
        "ProcessFrames1",
        "AtomicCopyBufferUInt",
        "AtomicCopyBufferUInt64",
        "DispatchRays",
        "InitializeMetaCommand",
        "ExecuteMetaCommand",
        "SetProtectedResourceSession",
        "BuildRaytracingAccelerationStructure",
        "EmitRaytracingAccelerationStructurePostBuildInfo",
        "CopyRaytracingAccelerationStructure",
        "EstimateMotion",
        "ResolveMotionVectorHeap",
        "SetPipelineState1",
        "InitializeExtensionCommand",
        "ExecuteExtensionCommand",
        "ResolveEncoderOutputMetadata",
        "ResolveSubresourceRegion",
        "InPlaceEdit",
        "RootSignatureOnly",
        "ModuleOnly",
        "ValidMask",
        "OutOfMemory",
        "MoreData",
        "GetPrivateData",
        "SetPrivateData",
        "ChangingParams",
        "InvalidFreeData",
        "InvalidIUnknown",
        "InvalidFlags",
        "InvalidSamples",
        "CreateBuffer",
        "CreateTexture1D",
        "CreateTexture2D",
        "CreateTexture3D",
        "CreateShaderResourceView",
        "CreateRenderTargetView",
        "CreateDepthStencilView",
        "CreateInputLayout",
        "CreateVertexShader",
        "CreatePixelShader",
        "CreateGeometryShader",
        "CreateGeometryShaderWithStreamOutput",
        "CreateQuery",
        "CreateRasterizerState",
        "CreateDepthStencilState",
        "CreateBlendState",
        "CreateSamplerState",
        "CreateQueryOrPredicate",
        "TooManyElements",
        "InvalidDesc",
        "InvalidFormat",
        "InvalidResource",
        "TooManyObjects",
        "UnrecognizedUsage",
        "UnrecognizedBindFlags",
        "UnrecognizedCPUAccessFlags",
        "UnrecognizedMiscFlags",
        "UnrecognizedFormat",
        "UnexpectedMiscFlags",
        "InvalidCPUAccessFlags",
        "InvalidBindFlags",
        "InvalidInitialData",
        "InvalidDimensions",
        "InvalidMipLevels",
        "InvalidMiscFlags",
        "InvalidArg",
        "NullDesc",
        "InvalidConstantBufferBindings",
        "LargeAllocation",
        "UnsupportedFormat",
        "IncompatibleFormat",
        "InvalidSlot",
        "InvalidInputSlotClass",
        "InvalidShaderBytecode",
        "InvalidNumEntries",
        "UnexpectedDecl",
        "ExpectedDecl",
        "InvalidOutputSlot",
        "InvalidComponentCount",
        "InvalidStartComponentAndComponentCount",
        "InvalidGapDefinition",
        "InvalidShaderType",
        "RepeatedOutput",
        "InvalidOutputStreamStride",
        "OutputMaskMismatch",
        "InvalidFillMode",
        "InvalidCullMode",
        "InvalidDepthBiasClamp",
        "InvalidSlopeScaledDepthBias",
        "InvalidFilter",
        "InvalidAddressU",
        "InvalidAddressV",
        "InvalidAddressW",
        "InvalidMaxAnisotropy",
        "InvalidComparisonFunc",
        "InvalidMinLod",
        "InvalidMaxLod",
        "InvalidQuery",
        "InvalidDestinationSubresource",
        "GenerateMips",
        "CopySubresourceRegion",
        "CopySubresource",
        "InvalidSource",
        "InvalidDestinationState",
        "InvalidSourceState",
        "InvalidSubresource",
        "UpdateSubresource",
        "AlreadyMapped",
        "InvalidMapType",
        "DeviceRemoved",
        "NotMapped",
        "SetExceptionMode",
        "VertexPos",
        "IndexPos",
        "InstancePos",
        "RegisterIndex",
        "ComponentType",
        "RegisterMask",
        "SystemValue",
        "NeverWritten",
        "AlwaysReads",
        "InputLayout",
        "ShaderResourceView",
        "BlendState",
        "GetDesc",
        "OMSetRenderTargets",
        "IASetVertexBuffers",
        "IASetIndexBuffer",
        "VSSetShader",
        "VSSetShaderResources",
        "VSSetConstantBuffers",
        "VSSetSamplers",
        "GSSetShader",
        "GSSetShaderResources",
        "GSSetConstantBuffers",
        "GSSetSamplers",
        "PSSetShader",
        "PSSetShaderResources",
        "PSSetConstantBuffers",
        "PSSetSamplers",
        "SOSetTargets",
        "IASetInputLayout",
        "UnbindDeletingObject",
        "RSSetState",
        "OMSetBlendState",
        "OMSetDepthStencilState",
        "SetPredication",
        "MissingOutputSignature",
        "InvalidDepthWriteMask",
        "InvalidDepthFunc",
        "InvalidFrontFaceStencilFailOp",
        "InvalidFrontFaceStencilZFailOp",
        "InvalidFrontFaceStencilPassOp",
        "InvalidFrontFaceStencilFunc",
        "InvalidBackFaceStencilFailOp",
        "InvalidBackFaceStencilZFailOp",
        "InvalidBackFaceStencilPassOp",
        "InvalidBackFaceStencilFunc",
        "InvalidSrcBlend",
        "InvalidDestBlend",
        "InvalidBlendOp",
        "InvalidSrcBlendAlpha",
        "InvalidDestBlendAlpha",
        "InvalidBlendOpAlpha",
        "InvalidRenderTargetWriteMask",
        "InvalidBuffer",
        "IASetPrimitiveTopology",
        "RSSetViewports",
        "RSSetScissorRects",
        "DenormFlush",
        "IAGetVertexBuffers",
        "VSGetShaderResources",
        "VSGetConstantBuffers",
        "VSGetSamplers",
        "GSGetShaderResources",
        "GSGetConstantBuffers",
        "GSGetSamplers",
        "PSGetShaderResources",
        "PSGetConstantBuffers",
        "PSGetSamplers",
        "SOGetTargets",
        "RSGetViewports",
        "RSGetScissorRects",
        "InvalidDestinationBox",
        "CheckFormatSupport",
        "CheckMultisampleQualityLevels",
        "SemanticName",
        "CreatePredicate",
        "CreateCounter",
        "OutOfRange",
        "NonExclusive",
        "CheckCounter",
        "CreateResource",
        "MirrorOnce",
        "InvalidNumStreams",
        "InvalidStreamToRasterizer",
        "UnexpectedStreams",
        "InvalidClassLinkage",
        "CommandListFlags",
        "CreateDeferredContext",
        "FinishDisplayList",
        "OnImmediateContext",
        "InvalidStream",
        "UnexpectedEntries",
        "UnexpectedStrides",
        "InvalidNumStrides",
        "CreateHullShader",
        "HSSetShader",
        "HSSetShaderResources",
        "HSSetConstantBuffers",
        "HSSetSamplers",
        "HSGetShaderResources",
        "HSGetConstantBuffers",
        "HSGetSamplers",
        "CreateDomainShader",
        "DSSetShader",
        "DSSetShaderResources",
        "DSSetConstantBuffers",
        "DSSetSamplers",
        "DSGetShaderResources",
        "DSGetConstantBuffers",
        "DSGetSamplers",
        "CreateComputeShader",
        "CSSetShader",
        "CSSetShaderResources",
        "CSSetConstantBuffers",
        "CSSetSamplers",
        "CSGetShaderResources",
        "CSGetConstantBuffers",
        "CSGetSamplers",
        "DrawIndirect",
        "ClassInstance",
        "ClassLinkage",
        "UnorderedAccessView",
        "CreateUnorderedAccessView",
        "SetShader",
        "DoubleFloatOpsNotSupported",
        "OMSetRenderTargetsAndUnorderedAccessViews",
        "CSSetUnorderedAccessViews",
        "PSSetUnorderedAccessViews",
        "CSSetUnorderedAccesss",
        "CSGetUnorderedAccesss",
        "CreateShaderResesourceView",
        "DispatchIndirect",
        "InvalidView",
        "InvalidOffset",
        "LargeOffset",
        "CopyStructureCount",
        "ClearUnorderedAccessView",
        "ClearUnorderedAccessViewFloat",
        "OfferResources",
        "EnqueueSetEvent",
        "VideoDecoder",
        "VideoProcessor",
        "VideoProcessorEnum",
        "DecoderOutputView",
        "ProcessorInputView",
        "ProcessorOutputView",
        "DeviceContextState",
        "CreateDeviceContextState",
        "UpdateSubresource1",
        "CreateVideoDecoder",
        "ZeroWidthHeight",
        "InvalidBufferSize",
        "InvalidBufferUsage",
        "InvalidSize",
        "DecryptionBlt",
        "NullParam",
        "InvalidBufferOffsetOrCount",
        "ShaderExtensionsNotSupported",
        "DoubleExtensionsNotSupported",
        "UAVsNotSupported",
        "SwapDeviceContextState",
        "ClearView",
        "NotSupported",
        "PreferUpdateSubresource1",
        "GetDC",
        "InvalidRect",
        "InvalidUsage",
        "StepRate",
        "UpdateTiles",
        "UpdateTileMappings",
        "CopyTiles",
        "CopyTileMappings",
        "AuthenticatedChannel",
        "ConservativeRasterMode",
        "InvalidContextType",
        "JpegDecode",
        "JpegEncode",
        "InvalidScanDataOffset",
        "InvalidComponents",
        "SourceNot2D",
        "DestinationNot2D",
        "CreateFence",
        "SynchronizedChannel",
        "DecoderBeginFrame",
        "VideoProcessorGetStreamMirror",
        "BackbufferNotSupported",
        "DimensionsTooLarge",
        "InvalidMipLevel",
        "ColorMatrix",
        "StencilOp",
        "InvalidPlaneSlice",
        "InvalidVideoPlaneSlice",
        "InvalidSlotClassChange",
        "StepRateSlotClassMismatch",
        "InvalidStepRateChange",
        "InvalidAlignment",
        "DuplicateSemantic",
        "UnparseableInputSignature",
        "NullSemantic",
        "MissingElement",
        "OutputStreamStrideUnused",
        "OutputSlot0Expected",
        "EmptyRect",
        "InvalidArgs",
        "CreateDevice",
        "CommandQueue",
        "CommandAllocator",
        "PipelineState",
        "CommandList12",
        "DescriptorHeap",
        "RootSignature",
        "MonitoredFence",
        "QueryHeap",
        "CommandSignature",
        "CreateShader",
        "CreateHeap",
        "InvalidBytecode",
        "UnrecognizedHeapType",
        "UnrecognizedCPUPageProperties",
        "UnrecognizedMemoryPool",
        "InvalidProperties",
        "CreateResourceAndHeap",
        "NullHeapProperties",
        "InvalidHeapProperties",
        "UnrecognizedHeapMiscFlags",
        "InvalidHeapMiscFlags",
        "GetCustomHeapProperties",
        "InvalidHeapType",
        "UnorderedAccess",
        "CreateGraphicsPipelineState",
        "MinPrecision",
        "MakeResident",
        "NullObjectArray",
        "GetResourceAllocationInfo",
        "InvalidDimensionality",
        "InvalidSampleDesc",
        "GetCopyableFootprints",
        "InvalidSubresourceRange",
        "InvalidBaseOffset",
        "GetCopyableLayout",
        "CreateCommandSignature",
        "GetGPUVirtualAddress",
        "InvalidClearValue",
        "InvalidClearValueFormat",
        "UnrecognizedClearValueFormat",
        "ClearValueDenormFlush",
        "MismatchingClearValue",
        "InvalidHeap",
        "InvalidRange",
        "BundleNotSupported",
        "ExecuteCommandLists",
        "CommandListMismatch",
        "OpenCommandList",
        "FailedCommandList",
        "NullDst",
        "NullSrc",
        "InvalidSrcResourceDimension",
        "InvalidDstResourceDimension",
        "SrcRangeOutOfBounds",
        "DstRangeOutOfBounds",
        "InvalidCopyFlags",
        "UnrecognizedDstType",
        "InvalidDstResource",
        "InvalidDstSubresource",
        "InvalidDstOffset",
        "UnrecognizedDstOffset",
        "InvalidDstFormat",
        "FormatMismatch",
        "EmptyBox",
        "CreateComputePipelineState",
        "CreatePipelineState",
        "InvalidCachedBlob",
        "InvalidBox",
        "CachedBlobDriverVersionMismatch",
        "CachedBlobDescMismatch",
        "CachedBlobIgnored",
        "WriteToSubresource",
        "ReadFromSubresource",
        "WrongSwapchainBufferReference",
        "InvalidNumRenderTargets",
        "SetRenderTargets",
        "CreateSharedResource",
        "ExifColorSpace",
        "NoCache",
        "CacheOnDemand",
        "CacheOnLoad",
    };

    private static readonly HashSet<string> s_preserveCaps = new(StringComparer.OrdinalIgnoreCase)
    {
        "HW",
        "YUV",
        "GDI",
        "IA",
        "SO",
        "VS",
        "PS",
        "DS",
        "GS",
        "HS",
        "CS",
        //"AS",
        "MS",
        "RS",
        "OM",
        "VB",
        "IB",
        "1D",
        "2D",
        "3D",
        "MRT",
        "D3D",
        "D3D11",
        "D3D12",
        "D2D",
        "D2D1",
        "DWRITE",
    };


    private static readonly Dictionary<string, string> s_knownTypesPrefixes = new()
    {
        { "DXGI_COLOR_SPACE_TYPE", "DXGI_COLOR_SPACE" },
        { "DXGI_GRAPHICS_PREEMPTION_GRANULARITY", "DXGI_GRAPHICS_PREEMPTION" },
        { "DXGI_COMPUTE_PREEMPTION_GRANULARITY", "DXGI_COMPUTE_PREEMPTION" },
        { "DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS", "DXGI_MULTIPLANE_OVERLAY" },
        { "DXGI_RECLAIM_RESOURCE_RESULTS", "DXGI_RECLAIM_RESOURCE_RESULT" },
        { "DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAGS", "DXGI_HARDWARE_COMPOSITION_SUPPORT_FLAG" },
        { "DXGI_DEBUG_RLO_FLAGS", "DXGI_DEBUG_RLO" },
        { "DXGI_OFFER_RESOURCE_FLAGS", "DXGI_OFFER_RESOURCE_FLAG" },

        // D3D
        { "D3D_INTERPOLATION_MODE", "D3D_INTERPOLATION" },
        { "D3D_PARAMETER_FLAGS", "D3D" },
        { "D3D_TESSELLATOR_OUTPUT_PRIMITIVE", "D3D_TESSELLATOR_OUTPUT" },
        { "D3D_REGISTER_COMPONENT_TYPE", "D3D_REGISTER_COMPONENT" },
        { "D3D_RESOURCE_RETURN_TYPE", "D3D_RETURN_TYPE" },
        { "D3D_CBUFFER_TYPE", "D3D_CT" },
        { "D3D_INCLUDE_TYPE", "D3D_INCLUDE" },
        { "D3D_SHADER_VARIABLE_CLASS", "D3D_SVC" },
        { "D3D_SHADER_VARIABLE_FLAGS", "D3D_SVF" },
        { "D3D_SHADER_VARIABLE_TYPE", "D3D_SVT" },
        { "D3D_SHADER_INPUT_FLAGS", "D3D_SIF" },
        { "D3D_SHADER_INPUT_TYPE", "D3D_SIT" },
        { "D3D_SHADER_CBUFFER_FLAGS", "D3D_CBF" },

        // D3D11 -> most is handled in code
        { "D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE", "D3D11_PROCESSIDTYPE" },

        // D3D12 -> most is handled in code
        { "D3D12_MULTISAMPLE_QUALITY_LEVEL_FLAGS", "D3D12_MULTISAMPLE_QUALITY_LEVELS_FLAG" },
        { "D3D12_SHADER_CACHE_SUPPORT_FLAGS", "D3D12_SHADER_CACHE_SUPPORT" },
        { "D3D12_RESOURCE_STATES", "D3D12_RESOURCE_STATE" },
        { "D3D12_GRAPHICS_STATES", "D3D12_GRAPHICS_STATE" },
        { "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_TYPE", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO" },
        { "D3D12_SERIALIZED_DATA_TYPE", "D3D12_SERIALIZED_DATA" },
        { "D3D12_DRIVER_MATCHING_IDENTIFIER_STATUS", "D3D12_DRIVER_MATCHING_IDENTIFIER" },
        { "D3D12_RLDO_FLAGS", "D3D12_RLDO" },
        { "D3D12_DEBUG_DEVICE_PARAMETER_TYPE", "D3D12_DEBUG_DEVICE_PARAMETER" },
        { "D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE", "D3D12_DEBUG_COMMAND_LIST_PARAMETER" },
        { "D3D12_SHADER_VERSION_TYPE", "D3D12_SHVER" },

        // Dxc
        { "DXC_OUT_KIND", "DXC_OUT" },

        // WIC
        { "WICColorContextType", "WICColorContext" },
        { "WICBitmapCreateCacheOption", "WICBitmap" },
        { "WICDecodeOptions", "WICDecodeMetadata" },
        { "WICBitmapEncoderCacheOption", "WICBitmapEncoder" },
        { "WICComponentType", "WIC" },
        { "WICComponentEnumerateOptions", "WICComponentEnumerate" },
        { "WICBitmapInterpolationMode", "WICBitmapInterpolation" },
        { "WICBitmapPaletteType", "WICBitmapPaletteType" },
        { "WICBitmapDitherType", "WICBitmapDitherType" },
        { "WICBitmapAlphaChannelOption", "WICBitmap" },
        { "WICBitmapTransformOptions", "WICBitmapTransform" },
        { "WICBitmapLockFlags", "WICBitmapLock" },
        { "WICBitmapDecoderCapabilities", "WICBitmapDecoderCapability" },
        { "WICProgressOperation", "WICProgressOperation" },
        { "WICProgressNotification", "WICProgressNotification" },
        { "WICComponentSigning", "WICComponent" },
        { "WICPixelFormatNumericRepresentation", "WICPixelFormatNumericRepresentation" },
        { "WICPlanarOptions", "WICPlanarOptions" },
    };

    private static readonly Dictionary<string, string> s_knownEnumValueNames = new()
    {
        { "DXGI_FORMAT_420_OPAQUE", "Opaque420" },
        { "DXGI_OUTDUPL_COMPOSITED_UI_CAPTURE_ONLY", "CompositedUICaptureOnly" },
        { "D3D_FEATURE_LEVEL_9_1", "Level_9_1" },

        // D3D11
        { "D3D11_STANDARD_MULTISAMPLE_PATTERN", "Standard" },
        { "D3D11_CENTER_MULTISAMPLE_PATTERN", "Center" },
        { "D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE_16_235", "Range_16_235" },
        { "D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE_0_255", "Range_0_255" },

        // D3D12
        { "D3D12_INDEX_BUFFER_STRIP_CUT_VALUE_0xFFFF", "I16Bits" },
        { "D3D12_INDEX_BUFFER_STRIP_CUT_VALUE_0xFFFFFFFF", "I32Bits" },
        { "D3D_ROOT_SIGNATURE_VERSION_1_0", "V1_0" },
        { "D3D_ROOT_SIGNATURE_VERSION_1_1", "V1_1" },
        { "D3D12_TEXTURE_LAYOUT_64KB_UNDEFINED_SWIZZLE", "L64KbUndefinedSwizzle" },
        { "D3D12_TEXTURE_LAYOUT_64KB_STANDARD_SWIZZLE", "L64KbStandardSwizzle" },
        { "D3D12_ROOT_PARAMETER_TYPE_32BIT_CONSTANTS", "T32BitConstants" },
        { "NUM_D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODES", "Count" },
        { "D3D12_MESSAGE_CALLBACK_IGNORE_FILTERS", "IgnoreFilters" },
        { "D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_AS", "AS" },
    };

    private static readonly Dictionary<string, bool> s_generatedEnums = new()
    {
        {"DXGI_CPU_ACCESS", false },
        {"DXGI_USAGE", true },
        {"DXGI_MAP", true },
        {"DXGI_PRESENT", true },
        {"DXGI_MWA", true },
        {"DXGI_ENUM_MODES", true },
        {"DXC_HASHFLAG", true },
        {"DxcValidatorFlags", true },
        {"DxcVersionInfoFlags", true },
    };

    private static readonly HashSet<string> s_ignoredStartParts = new(StringComparer.OrdinalIgnoreCase)
    {
        "DXGI",
        "D3D",
        "D3D10",
        "D3D11",
        "D3D12",
        "D2D",
        "D2D1",
        "DWRITE",
    };

    private static readonly HashSet<string> s_ignoredParts = new(StringComparer.OrdinalIgnoreCase)
    {
        "PF" // D3D_PF_
    };


    private static readonly Dictionary<string, string> s_typesNameRemap = new()
    {
        // Generated
        { "DXGI_MAP", "MapFlags" },
        { "DXGI_ENUM_MODES", "EnumModesFlags" },
        { "DXGI_MWA", "WindowAssociationFlags" },

        // D3D11
        { "D3D11_RLDO_FLAGS", "ReportLiveDeviceObjectFlags" },
        { "D3D11_1_CREATE_DEVICE_CONTEXT_STATE_FLAG", "CreateDeviceContextStateFlags" },

        // D3D12
        { "D3D12_RLDO_FLAGS", "ReportLiveDeviceObjectFlags" },

        // D2D1
        { "D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE", "AffineTransform2DInterpolationMode" },

        // Dxc
        { "DXC_HASHFLAG", "DxcHashFlags" },
        { "DxcValidatorFlags", "DxcValidatorFlags" },
        { "DxcVersionInfoFlags", "DxcVersionInfoFlags" },
    };

    private static readonly Dictionary<string, string> s_structFieldTypeRemap = new()
    {
        { "DXGI_ADAPTER_DESC1::Flags", "DXGI_ADAPTER_FLAG" },
        { "DXGI_ADAPTER_DESC3::Flags", "DXGI_ADAPTER_FLAG3" },
        { "DXGI_SWAP_CHAIN_DESC::BufferUsage", "Usage" },
        { "DXGI_SWAP_CHAIN_DESC::Flags", "DXGI_SWAP_CHAIN_FLAG" },
        { "DXGI_SWAP_CHAIN_DESC1::BufferUsage", "Usage" },
        { "DXGI_SWAP_CHAIN_DESC1::Flags", "DXGI_SWAP_CHAIN_FLAG" },

        // D3D11
        { "D3D11_BUFFER_DESC::BindFlags", "D3D11_BIND_FLAG" },
        { "D3D11_BUFFER_DESC::CPUAccessFlags", "D3D11_CPU_ACCESS_FLAG" },
        { "D3D11_BUFFER_DESC::MiscFlags", "D3D11_RESOURCE_MISC_FLAG" },

        { "D3D11_TEXTURE1D_DESC::BindFlags", "D3D11_BIND_FLAG" },
        { "D3D11_TEXTURE1D_DESC::CPUAccessFlags", "D3D11_CPU_ACCESS_FLAG" },
        { "D3D11_TEXTURE1D_DESC::MiscFlags", "D3D11_RESOURCE_MISC_FLAG" },

        { "D3D11_TEXTURE2D_DESC::BindFlags", "D3D11_BIND_FLAG" },
        { "D3D11_TEXTURE2D_DESC::CPUAccessFlags", "D3D11_CPU_ACCESS_FLAG" },
        { "D3D11_TEXTURE2D_DESC::MiscFlags", "D3D11_RESOURCE_MISC_FLAG" },

        { "D3D11_TEXTURE3D_DESC::BindFlags", "D3D11_BIND_FLAG" },
        { "D3D11_TEXTURE3D_DESC::CPUAccessFlags", "D3D11_CPU_ACCESS_FLAG" },
        { "D3D11_TEXTURE3D_DESC::MiscFlags", "D3D11_RESOURCE_MISC_FLAG" },

        { "D3D11_FEATURE_DATA_FORMAT_SUPPORT::OutFormatSupport", "D3D11_FORMAT_SUPPORT" },
        { "D3D11_FEATURE_DATA_FORMAT_SUPPORT2::OutFormatSupport2", "D3D11_FORMAT_SUPPORT2" },

        { "D3D11_RENDER_TARGET_BLEND_DESC::RenderTargetWriteMask", "D3D11_COLOR_WRITE_ENABLE" },
        { "D3D11_RENDER_TARGET_BLEND_DESC1::RenderTargetWriteMask", "D3D11_COLOR_WRITE_ENABLE" },
        { "D3D11_DEPTH_STENCIL_VIEW_DESC::Flags", "D3D11_DSV_FLAG" },
        { "D3D11_BUFFER_UAV::Flags", "D3D11_BUFFER_UAV_FLAG" },
        { "D3D11_BUFFEREX_SRV::Flags", "D3D11_BUFFEREX_SRV_FLAG" },

        // D3D12
        { "D3D12_RENDER_TARGET_BLEND_DESC::RenderTargetWriteMask", "D3D12_COLOR_WRITE_ENABLE" },

        // Dxc
        { "DxcShaderHash::Flags", "DXC_HASHFLAG" },
    };

    private static readonly Dictionary<string, string> s_mapFunctionParameters = new()
    {
        // DXGI
        { "IDXGIDevice::CreateSurface::Usage", "DXGI_USAGE" },
        { "IDXGIOutput::GetDisplayModeList::Flags", "DXGI_ENUM_MODES" },

        // D3D11
        { "ID3D11DeviceContext::Map::MapFlags", "D3D11_MAP_FLAG" },

        // D3D12

        // Dxc
        { "IDxcValidator::Validate::Flags", "DxcValidatorFlags" },
        { "IDxcValidator2::Validate::Flags", "DxcValidatorFlags" },
        { "IDxcValidator2::ValidateWithDebug::Flags", "DxcValidatorFlags" },
        { "IDxcVersionInfo::GetFlags::pFlags", "DxcVersionInfoFlags" },
        { "IDxcVersionInfo2::GetFlags::pFlags", "DxcVersionInfoFlags" },

        // WIC
        { "IWICImagingFactory::CreateDecoderFromFilename::dwDesiredAccess", "NativeFileAccess" },
        { "IWICBitmap::Lock::flags", "WICBitmapLockFlags" },
    };

    private static readonly HashSet<string> s_visitedEnums = new();
    private static readonly HashSet<string> s_visitedStructs = new();
    private static readonly Dictionary<string, List<KeyValuePair<ApiType, string>>> s_visitedComTypes = new();

    private static bool s_generateUnmanagedDocs = true;

    public static int Main(string[] args)
    {
        string outputPath = AppContext.BaseDirectory;
        if (args.Length > 0)
        {
            outputPath = args[0];
        }

        if (!Path.IsPathRooted(outputPath))
        {
            outputPath = Path.Combine(AppContext.BaseDirectory, outputPath);
        }

        if (!Directory.Exists(outputPath))
        {
            Directory.CreateDirectory(outputPath);
        }

        foreach (string jsonFile in jsons)
        {
            string finalPath = Path.Combine(AppContext.BaseDirectory, "win32json", "api", jsonFile);
            string jsonData = File.ReadAllText(finalPath);
            ApiData? api = JsonConvert.DeserializeObject<ApiData>(jsonData);
            Generate(api!, outputPath, jsonFile);
        }

        // Generate docs
        //DocGenerator.Generate(new[] { "D2D1" }, Path.Combine(outputPath, "Direct2D.xml"));
        //DocGenerator.Generate(new[] { "DWRITE" }, Path.Combine(outputPath, "DirectWrite.xml"));
        //DocGenerator.Generate(new[] { "D3D" }, Path.Combine(outputPath, "Direct3D.xml"));
        //DocGenerator.Generate(new[] { "DXGI" }, Path.Combine(outputPath, "Dxgi.xml"));
        //DocGenerator.Generate(new[] { "D3D11" }, Path.Combine(outputPath, "Direct3D11.xml"));
        return 0;
    }

    private static void Generate(ApiData api, string outputPath, string jsonFile)
    {
        string[] splits = jsonFile.Split(".", StringSplitOptions.RemoveEmptyEntries);
        string folderRoot = splits[0];
        string outputFolder = Path.Combine(outputPath, folderRoot);

        if (!Directory.Exists(outputFolder))
        {
            Directory.CreateDirectory(outputFolder);
        }

        string docFile = splits[1];
        string fileName = string.Empty;
        for (int i = 1; i < splits.Length - 1; i++)
        {
            if (string.IsNullOrEmpty(fileName) == false)
            {
                fileName += ".";
            }

            fileName += splits[i];
        }

        string ns = string.Empty;
        if (string.IsNullOrWhiteSpace(fileName) == true)
        {
            fileName = splits[0];
            ns = folderRoot;
        }
        else
        {
            ns = $"{folderRoot}.{fileName}";
        }

        fileName += ".cs";

        using var writer = new CodeWriter(
            Path.Combine(outputFolder, fileName),
            ns,
            docFile,
            $"Win32.{ns}");

        GenerateConstants(writer, api);
        GenerateTypes(writer, api);
        GenerateFunctions(writer, api);
    }

    private static void GenerateConstants(CodeWriter writer, ApiData api)
    {
        using (writer.PushBlock($"public static partial class Apis"))
        {
            foreach (var constant in api.Constants)
            {
                if (ShouldSkipConstant(constant))
                    continue;

                bool skipValue = false;
                foreach (var enumToGenerate in s_generatedEnums)
                {
                    if (constant.Name.StartsWith(enumToGenerate.Key))
                    {
                        skipValue = true;
                        break;
                    }
                }

                if (skipValue)
                    continue;

                string typeName = GetTypeName(constant.Type);
                if (typeName == "Guid")
                {
                    WriteGuid(writer, constant.Value!.ToString(), constant.Name);
                    writer.WriteLine();
                }
                else if (typeName == "HResult")
                {
                    writer.WriteLine($"public static readonly HResult {constant.Name} = {constant.Value};");
                }
                else if (typeName == "float")
                {
                    float floatValue = Convert.ToSingle(constant.Value);
                    writer.WriteLine($"public const float {constant.Name} = {floatValue.ToString(CultureInfo.InvariantCulture)}f;");
                }
                else if (typeName == "double")
                {
                    double dblValue = Convert.ToDouble(constant.Value);
                    writer.WriteLine($"public const double {constant.Name} = {dblValue.ToString(CultureInfo.InvariantCulture)};");
                }
                else
                {
                    writer.WriteLine($"public const {typeName} {constant.Name} = {constant.Value};");
                }
            }
        }
        writer.WriteLine();
    }

    private static void GenerateTypes(CodeWriter writer, ApiData api)
    {
        bool regionWritten = false;
        foreach (ApiType enumType in api.Types.Where(item => item.Kind.ToLowerInvariant() == "enum"))
        {
            if (enumType.Name.StartsWith("D3DX11"))
            {
                continue;
            }

            if (!regionWritten)
            {
                writer.WriteLine($"#region Enums");
                regionWritten = true;
            }

            GenerateEnum(writer, enumType, false);

            s_visitedEnums.Add($"{writer.Api}.{enumType.Name}");
        }

        if (regionWritten)
        {
            writer.WriteLine("#endregion Enums");
            writer.WriteLine();
        }

        // Generated enums -> from constants
        regionWritten = false;
        Dictionary<string, ApiType> createdEnums = new();

        foreach (ApiDataConstant constant in api.Constants)
        {
            if (ShouldSkipConstant(constant))
                continue;

            foreach (var enumToGenerate in s_generatedEnums)
            {
                if (constant.Name.StartsWith(enumToGenerate.Key))
                {
                    ApiType createdEnumType;
                    if (!createdEnums.ContainsKey(enumToGenerate.Key))
                    {
                        ApiType apiType = new()
                        {
                            Name = enumToGenerate.Key,
                            Kind = "Enum",
                            Flags = enumToGenerate.Value,
                            Scoped = false,
                            IntegerBase = constant.Type.Name
                        };
                        createdEnums.Add(enumToGenerate.Key, apiType);
                        createdEnumType = apiType;
                    }
                    else
                    {
                        createdEnumType = createdEnums[enumToGenerate.Key];
                    }

                    ApiEnumValue enumValue = new ApiEnumValue
                    {
                        Name = constant.Name,
                        Value = constant.Value
                    };
                    createdEnumType.Values.Add(enumValue);

                    //string enumValueName = GetPrettyFieldName(constant.Name, createdEnumName);
                    //writer.WriteLine($"{enumValueName} = {constant.Value},");
                }
            }
        }

        foreach (ApiType enumType in createdEnums.Values)
        {
            if (!regionWritten)
            {
                writer.WriteLine($"#region Generated Enums");
                regionWritten = true;
            }

            GenerateEnum(writer, enumType, true);
        }

        if (regionWritten)
        {
            writer.WriteLine($"#endregion Generated Enums");
            writer.WriteLine();
        }

        // Unions
        regionWritten = false;

        foreach (ApiType structType in api.Types.Where(item => item.Kind.ToLowerInvariant() == "union"))
        {
            if (structType.Name.StartsWith("D3DX11") ||
                structType.Name.StartsWith("CD3D11"))
            {
                continue;
            }

            if (s_csNameMappings.ContainsKey($"{writer.Api}.{structType.Name}"))
            {
                continue;
            }

            if (!regionWritten)
            {
                writer.WriteLine($"#region Unions");
                regionWritten = true;
            }

            GenerateStruct(api, writer, structType);

            s_visitedStructs.Add($"{writer.Api}.{structType.Name}");
        }

        if (regionWritten)
        {
            writer.WriteLine($"#endregion Unions");
            writer.WriteLine();
        }

        // Structs
        regionWritten = false;
        foreach (ApiType structType in api.Types.Where(item => item.Kind.ToLowerInvariant() == "struct"))
        {
            if (structType.Name.StartsWith("D3DX11") ||
                structType.Name.StartsWith("CD3D11") ||
                structType.Name == "D2D_COLOR_F")
            {
                continue;
            }

            if (s_csNameMappings.ContainsKey($"{writer.Api}.{structType.Name}"))
            {
                continue;
            }

            if (!regionWritten)
            {
                writer.WriteLine($"#region Structs");
                regionWritten = true;
            }

            GenerateStruct(api, writer, structType);

            s_visitedStructs.Add($"{writer.Api}.{structType.Name}");
        }
        if (regionWritten)
        {
            writer.WriteLine("#endregion Structs");
            writer.WriteLine();
        }

        // Com types
        regionWritten = false;
        foreach (ApiType comType in api.Types.Where(item => item.Kind.ToLowerInvariant() == "com"))
        {
            if (comType.Name.StartsWith("ID3DX11"))
            {
                continue;
            }

            if (!regionWritten)
            {
                writer.WriteLine("#region COM Types");
                regionWritten = true;
            }

            // Generate methods
            // TODO: FIX broken VTable ID3D12Heap, ID2D1Factory2
            List<KeyValuePair<ApiType, string>> methodsToGenerate = new();
            ApiType iterateType = comType;
            while (iterateType.Interface != null
                && iterateType.Interface.Name != "IUnknown"
                && iterateType.Interface.Name != "IStream"
                && iterateType.Interface.Name != "IPersistStream")
            {
                string fullTypeName = $"{iterateType.Interface.Api}.{iterateType.Interface.Name}";
                iterateType = api.Types.FirstOrDefault(item => item.Name == iterateType.Interface.Name);

                if (iterateType != null)
                {
                    foreach (ApiType method in iterateType.Methods)
                    {
                        // Until we add Storage.Xps.Printing.IPrintDocumentPackageTarget
                        if (method.Name == "CreatePrintControl")
                            continue;

                        methodsToGenerate.Add(new(method, iterateType.Name));
                    }
                }
                else
                {
                    var knownMethods = s_visitedComTypes.First(item => item.Key == fullTypeName).Value;

                    foreach (var knownMethod in knownMethods)
                    {
                        methodsToGenerate.Add(knownMethod);
                    }

                    break;
                }
            }

            foreach (ApiType method in comType.Methods)
            {
                // Until we add Storage.Xps.Printing.IPrintDocumentPackageTarget
                if (method.Name == "CreatePrintControl")
                    continue;

                methodsToGenerate.Add(new(method, comType.Name));
            }

            GenerateComType(api, writer, comType, methodsToGenerate);
        }

        if (regionWritten)
        {
            writer.WriteLine("#endregion Com Types");
            writer.WriteLine();
        }
    }

    private static void GenerateFunctions(CodeWriter writer, ApiData api)
    {
        if (api.Functions.Length == 0)
            return;

        writer.WriteLine($"#region Functions");
        using (writer.PushBlock($"public static unsafe partial class Apis"))
        {
            foreach (ApiType function in api.Functions)
            {
                if (function.Name.StartsWith("D3DX11") ||
                    function.Name == "D3DDisassemble11Trace")
                {
                    continue;
                }

                WriteFunction(writer, api, function, string.Empty, false);
                writer.WriteLine();
            }
        }

        writer.WriteLine($"#endregion Functions");
    }

    private static void WriteFunction(
        CodeWriter writer,
        ApiData api,
        ApiType function,
        string functionName,
        bool asCallback)
    {
        string returnType = GetTypeName(function.ReturnType);
        string functionSuffix = string.Empty;

        if (string.IsNullOrEmpty(function.DllImport) == false)
        {
            functionSuffix = "static extern ";
            writer.WriteLine($"[DllImport(\"{function.DllImport}\", ExactSpelling = true)]");
        }

        StringBuilder argumentBuilder = new();
        StringBuilder argumentsTypesBuilder = new();
        StringBuilder argumentsNameBuilder = new();
        int parameterIndex = 0;
        foreach (ApiParameter parameter in function.Params)
        {
            bool asPointer = false;
            string parameterType = string.Empty;
            if (parameter.Type.Kind == "ApiRef")
            {
                if (parameter.Type.TargetKind == "FunctionPointer")
                {
                    ApiType functionType = api.Types.First(item => item.Name == parameter.Type.Name && item.Kind == "FunctionPointer");
                    parameterType = "delegate* unmanaged[Stdcall]<void*, void>";
                }
                else
                {
                    string fullTypeName = $"{parameter.Type.Api}.{parameter.Type.Name}";
                    if (!IsPrimitive(parameter.Type) && !IsEnum(fullTypeName))
                    {
                        asPointer = true;
                    }
                }
            }

            if (string.IsNullOrEmpty(parameterType))
            {
                parameterType = GetTypeName(parameter.Type, asPointer);
            }

            parameterType = NormalizeTypeName(writer.Api, parameterType);
            string parameterName = parameter.Name;

            bool isOptional = parameter.Attrs.Any(item => item is string str && str == "Optional");
            if (parameter.Attrs.Any(item => item is string str && str == "ComOutPtr"))
            {
                if (!IsPrimitive(parameter.Type))
                {
                    parameterType += "*";
                }
            }

            argumentBuilder.Append(parameterType);

            if (asCallback == false)
            {
                argumentBuilder.Append(' ').Append(parameterName);
            }

            if (isOptional == true)
            {
                //argumentBuilder.Append(" = default");
            }

            argumentsTypesBuilder.Append(parameterType);
            argumentsNameBuilder.Append(parameterName);

            if (parameterIndex < function.Params.Count - 1)
            {
                argumentBuilder.Append(", ");
                argumentsTypesBuilder.Append(", ");
                argumentsNameBuilder.Append(", ");
            }

            parameterIndex++;
        }

        string argumentsString = argumentBuilder.ToString();
        if (string.IsNullOrEmpty(functionName))
        {
            functionName = function.Name;
        }

        writer.Write("public ");
        if (asCallback)
        {
            writer.Write($"unsafe delegate* unmanaged[Stdcall]<{argumentsString}, {returnType}> {functionName}");
        }
        else
        {
            writer.Write($"{functionSuffix}{returnType} {functionName}({argumentsString})");
        }

        writer.WriteLine(";");
    }

    private static void GenerateEnum(CodeWriter writer, ApiType enumType, bool autoGenerated)
    {
        string csTypeName;
        string enumPrefix = string.Empty;
        bool skipPrettify = false;

        if (enumType.Name.StartsWith("WIC"))
        {
            csTypeName = enumType.Name;

            if (s_knownTypesPrefixes.TryGetValue(enumType.Name, out string? knowPrefix))
            {
                enumPrefix = knowPrefix!;
                skipPrettify = true;
            }
        }
        else
        {
            csTypeName = GetDataTypeName(enumType.Name, out enumPrefix);
            AddCsMapping(writer.Api, enumType.Name, csTypeName);
        }

        string baseTypeName = GetTypeName(enumType.IntegerBase);

        if (!autoGenerated)
        {
            writer.WriteLine($"/// <include file='../{writer.DocFileName}.xml' path='doc/member[@name=\"{enumType.Name}\"]/*' />");
        }

        if (s_generateUnmanagedDocs)
            writer.WriteLine($"/// <unmanaged>{enumType.Name}</unmanaged>");

        bool isFlags = false;
        if (enumType.Flags ||
            csTypeName.EndsWith("Flag") ||
            csTypeName.EndsWith("Flags"))
        {
            isFlags = true;

        }

        // Know flag members
        if (enumType.Name == "D3D11_FORMAT_SUPPORT" ||
            enumType.Name == "D3D11_FORMAT_SUPPORT2" ||
            enumType.Name == "D3D11_COLOR_WRITE_ENABLE" ||
            enumType.Name == "D3D12_COLOR_WRITE_ENABLE")
        {
            isFlags = true;
        }

        if (isFlags)
        {
            writer.WriteLine("[Flags]");
        }

        if (enumType.Name == "D3D11_COLOR_WRITE_ENABLE" ||
            enumType.Name == "D3D12_COLOR_WRITE_ENABLE")
        {
            baseTypeName = "byte";
        }

        if (enumType.Name == "WICColorContextType")
        {

        }

        using (writer.PushBlock($"public enum {csTypeName} : {baseTypeName}"))
        {
            if (isFlags &&
                !enumType.Values.Any(item => GetEnumItemName(enumType, item, enumPrefix, skipPrettify) == "None"))
            {
                writer.WriteLine("None = 0,");
            }

            foreach (ApiEnumValue enumItem in enumType.Values)
            {
                if (enumItem.Name.EndsWith("_FORCE_DWORD") ||
                    enumItem.Name.EndsWith("_FORCE_UINT") ||
                    enumItem.Name == "D3D_ROOT_SIGNATURE_VERSION_1")
                {
                    continue;
                }

                // Ignore D3D10, D3D11 and D3D12 in D3D
                if (enumType.Name.StartsWith("D3D_"))
                {
                    if (enumItem.Name.StartsWith("D3D10_") ||
                        enumItem.Name.StartsWith("D3D11_") ||
                        enumItem.Name.StartsWith("D3D12_"))
                    {
                        continue;
                    }
                }

                if (enumItem.Name.EndsWith("_MESSAGES_START") ||
                    enumItem.Name.EndsWith("_MESSAGES_END"))
                {
                    continue;
                }

                string enumValueName = GetEnumItemName(enumType, enumItem, enumPrefix, skipPrettify);

                if (!autoGenerated)
                {
                    writer.WriteLine($"/// <include file='../{writer.DocFileName}.xml' path='doc/member[@name=\"{enumType.Name}::{enumItem.Name}\"]/*' />");
                }

                if (s_generateUnmanagedDocs)
                {
                    writer.WriteLine($"/// <unmanaged>{enumItem.Name}</unmanaged>");
                }

                if (enumValueName.StartsWith("DXGI_MSG_"))
                {
                    enumValueName = enumValueName.Substring("DXGI_MSG_".Length);
                }

                writer.WriteLine($"{enumValueName} = {enumItem.Value},");
            }
        }

        writer.WriteLine();
    }

    private static string GetEnumItemName(ApiType enumType, ApiEnumValue enumItem, string enumPrefix, bool skipPrettify)
    {
        if (string.IsNullOrEmpty(enumPrefix))
        {
            return enumItem.Name;
        }

        string enumValueName = GetPrettyFieldName(enumItem.Name, enumPrefix, skipPrettify);

        // D3D11 has some enum name "issues"
        // D3D11_FILL_MODE -> D3D11_FILL_*
        if (enumValueName.StartsWith("D3D11_"))
        {
            string[] parts = enumType.Name.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
            enumPrefix = string.Join("_", parts.Take(parts.Length - 1));
            enumValueName = GetPrettyFieldName(enumItem.Name, enumPrefix, skipPrettify);
        }

        // D3D12 FLAGS/FLAG
        // D3D12_COMMAND_QUEUE_FLAGS -> D3D12_COMMAND_QUEUE_FLAG_NONE
        if (enumValueName.StartsWith("D3D12_") && enumType.Name.EndsWith("FLAGS"))
        {
            enumPrefix = enumType.Name.Substring(0, enumType.Name.Length - 1);
            enumValueName = GetPrettyFieldName(enumItem.Name, enumPrefix, skipPrettify);
        }

        return enumValueName;
    }

    private static void GenerateStruct(ApiData api, CodeWriter writer, ApiType structType, bool nestedType = false)
    {
        string csTypeName;
        string structPrefix = string.Empty;

        if (nestedType)
        {
            csTypeName = structType.Name;
        }
        else
        {
            if (structType.Name.StartsWith("Dxc") ||
                structType.Name.StartsWith("WIC"))
            {
                csTypeName = structType.Name;
            }
            else
            {
                csTypeName = GetDataTypeName(structType.Name, out structPrefix);
                AddCsMapping(writer.Api, structType.Name, csTypeName);
            }

            writer.WriteLine($"/// <include file='../{writer.DocFileName}.xml' path='doc/member[@name=\"{structType.Name}\"]/*' />");

            if (s_generateUnmanagedDocs)
            {
                writer.WriteLine($"/// <unmanaged>{structType.Name}</unmanaged>");
            }
        }

        bool isUnion = structType.Kind == "Union";
        if (isUnion)
        {
            writer.WriteLine("[StructLayout(LayoutKind.Explicit)]");
        }

        using (writer.PushBlock($"public partial struct {csTypeName}"))
        {
            int fieldIndex = 0;
            foreach (ApiStructField field in structType.Fields)
            {
                if (field.Name.EndsWith("_FORCE_DWORD"))
                {
                    continue;
                }

                string fieldValueName = field.Name;

                if (structType.Name == "D3D11_OMAC")
                {
                    fieldValueName = "Buffer";
                }
                else if (structType.Name == "D3D12_NODE_MASK")
                {
                    fieldValueName = "Mask";
                }

                if (structType.Name == "D2D1_LAYER_PARAMETERS")
                {
                }

                bool asPointer = false;
                if (field.Type.Kind == "ApiRef")
                {
                    string apiName = GetApiName(field.Type);
                    string fullTypeName = $"{apiName}.{field.Type.Name}";

                    if (s_visitedComTypes.ContainsKey(fullTypeName) ||
                        api.Types.Any(item => item.Name == field.Type.Name && item.Kind.ToLowerInvariant() == "com"))
                    {
                        asPointer = true;
                    }
                }

                string fieldTypeName = GetTypeName(field.Type, asPointer);

                writer.WriteLine($"/// <include file='../{writer.DocFileName}.xml' path='doc/member[@name=\"{structType.Name}::{field.Name}\"]/*' />");

                if (s_generateUnmanagedDocs)
                {
                    //writer.WriteLine($"/// <unmanaged>{field.Name}</unmanaged>");
                }

                string remapFieldLookUp = $"{structType.Name}::{field.Name}";
                if (s_structFieldTypeRemap.TryGetValue(remapFieldLookUp, out string? remapType))
                {
                    fieldTypeName = GetTypeName($"{writer.Api}.{remapType}");
                }

                if (fieldTypeName == "Array")
                {
                    bool canUseFixed = false;
                    if (field.Type.Child.Kind == "Native")
                    {
                        canUseFixed = true;
                    }

                    fieldTypeName = GetTypeName(field.Type.Child);
                    fieldTypeName = NormalizeTypeName(writer.Api, fieldTypeName);

                    if (canUseFixed)
                    {
                        if (isUnion)
                        {
                            writer.WriteLine("[FieldOffset(0)]");
                        }

                        int arraySize = field.Type.Shape != null ? field.Type.Shape.Size : 1;
                        writer.WriteLine($"public unsafe fixed {fieldTypeName} {fieldValueName}[{arraySize}];");
                    }
                    else
                    {
                        writer.WriteLine($"public {fieldValueName}__FixedBuffer {fieldValueName};");
                        writer.WriteLine();

                        using (writer.PushBlock($"public unsafe struct {fieldValueName}__FixedBuffer"))
                        {
                            int arraySize = field.Type.Shape != null ? field.Type.Shape.Size : 1;

                            for (int i = 0; i < arraySize; i++)
                            {
                                writer.WriteLine($"public {fieldTypeName} e{i};");
                            }
                            writer.WriteLine();

                            writer.WriteLine("[UnscopedRef]");
                            using (writer.PushBlock($"public ref {fieldTypeName} this[int index]"))
                            {
                                writer.WriteLine("[MethodImpl(MethodImplOptions.AggressiveInlining)]");
                                using (writer.PushBlock("get"))
                                {
                                    writer.WriteLine($"return ref AsSpan()[index];");
                                }
                            }
                            writer.WriteLine();

                            writer.WriteLine("[UnscopedRef]");
                            writer.WriteLine("[MethodImpl(MethodImplOptions.AggressiveInlining)]");
                            using (writer.PushBlock($"public Span<{fieldTypeName}> AsSpan()"))
                            {
                                writer.WriteLine($"return MemoryMarshal.CreateSpan(ref e0, {arraySize});");
                            }
                        }
                    }
                }
                else
                {
                    string unsafePrefix = string.Empty;

                    if (field.Type.TargetKind == "FunctionPointer")
                    {
                        ApiType functionType = api.Types.First(item => item.Name == field.Type.Name && item.Kind == "FunctionPointer");
                        WriteFunction(writer, api, functionType, field.Name, true);
                    }
                    else
                    {
                        fieldTypeName = NormalizeTypeName(writer.Api, fieldTypeName);
                        if (fieldTypeName.EndsWith("*"))
                        {
                            unsafePrefix += "unsafe ";
                        }

                        if (isUnion)
                        {
                            writer.WriteLine("[FieldOffset(0)]");
                        }

                        fieldValueName = CleanupName(fieldValueName);
                        writer.WriteLine($"public {unsafePrefix}{fieldTypeName} {fieldValueName};");
                    }
                }

                if (fieldIndex < structType.Fields.Length - 1)
                {
                    writer.WriteLine();
                }

                fieldIndex++;
            }

            // Generate nested types
            if (structType.NestedTypes.Length > 0)
            {
                writer.WriteLine();

                if (isUnion == false)
                {
                    foreach (ApiType nestedTypeToGenerate in structType.NestedTypes)
                    {
                        foreach (ApiStructField field in nestedTypeToGenerate.Fields)
                        {
                            ApiStructField parentMemberAccess = structType.Fields.First(item => item.Type.Name == nestedTypeToGenerate.Name);
                            string fieldTypeName = GetTypeName(field.Type);
                            fieldTypeName = NormalizeTypeName(writer.Api, fieldTypeName);

                            string fieldName = GetPrettyFieldName(field.Name, structPrefix, false);

                            writer.WriteLine("[UnscopedRef]");
                            if (fieldTypeName == "Array")
                            {
                                fieldTypeName = GetTypeName(field.Type.Child);

                                using (writer.PushBlock($"public unsafe Span<{fieldTypeName}> {fieldName}"))
                                {
                                    writer.WriteLine("[MethodImpl(MethodImplOptions.AggressiveInlining)]");
                                    using (writer.PushBlock("get"))
                                    {
                                        writer.WriteLine($"return MemoryMarshal.CreateSpan(ref {parentMemberAccess.Name}.{fieldName}[0], {field.Type.Shape.Size});");
                                    }
                                }
                            }
                            else
                            {
                                if (fieldName == "pGeometryDescs")
                                {

                                }

                                string unsafePrefix = string.Empty;
                                if (fieldTypeName.EndsWith("*"))
                                {
                                    unsafePrefix += "unsafe ";
                                }

                                using (writer.PushBlock($"public {unsafePrefix}ref {fieldTypeName} {fieldName}"))
                                {
                                    writer.WriteLine("[MethodImpl(MethodImplOptions.AggressiveInlining)]");
                                    using (writer.PushBlock("get"))
                                    {
                                        writer.WriteLineUndindented("#if NET7_0_OR_GREATER");
                                        writer.WriteLine($"return ref {parentMemberAccess.Name}.{fieldName};");
                                        writer.WriteLineUndindented("#else");
                                        if (fieldTypeName.EndsWith("*"))
                                        {
                                            writer.WriteLine($"return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).{parentMemberAccess.Name}.{fieldName};");
                                        }
                                        else
                                        {
                                            writer.WriteLine($"return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref {parentMemberAccess.Name}.{fieldName}, 1));");
                                        }

                                        writer.WriteLineUndindented("#endif");
                                    }
                                }
                            }

                            writer.WriteLine();
                        }
                    }
                }

                foreach (ApiType nestedTypeToGenerate in structType.NestedTypes)
                {
                    GenerateStruct(api, writer, nestedTypeToGenerate, true);
                }
            }
        }

        writer.WriteLine();
    }

    private static void GenerateComType(
        ApiData api,
        CodeWriter writer,
        ApiType comType,
        List<KeyValuePair<ApiType, string>> methodsToGenerate)
    {
        string csTypeName = comType.Name;

        writer.WriteLine($"/// <include file='../{writer.DocFileName}.xml' path='doc/member[@name=\"{comType.Name}\"]/*' />");

        if (s_generateUnmanagedDocs)
        {
            writer.WriteLine($"/// <unmanaged>{comType.Name}</unmanaged>");
        }

        if (comType.Guid != null)
        {
            writer.WriteLine($"[Guid(\"{comType.Guid}\")]");
        }

        if (comType.Interface != null)
        {
            writer.WriteLine($"[NativeTypeName(\"struct {comType.Name} : {comType.Interface.Name}\")]");
            writer.WriteLine($"[NativeInheritance(\"{comType.Interface.Name}\")]");
        }

        using (writer.PushBlock($"public unsafe partial struct {csTypeName}"))
        {
            if (comType.Guid != null)
            {
                // Generate IID
                WriteGuid(writer, comType.Guid, $"IID_{csTypeName}");
                writer.WriteLine();

                writer.WriteLine($"public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_{csTypeName}));");
                writer.WriteLine();
            }

            writer.WriteLine($"public void** lpVtbl;");
            writer.WriteLine();

            int vtblIndex = 0;

            bool generateIUnknown = false;
            var iterateType = comType;

            while (iterateType != null)
            {
                if (iterateType.Interface == null)
                    break;

                generateIUnknown = iterateType.Interface.Name == "IUnknown";
                iterateType = api.Types.FirstOrDefault(item => item.Name == iterateType.Interface.Name);
            }

            if (generateIUnknown)
            {
                writer.WriteLine("/// <inheritdoc cref=\"IUnknown.QueryInterface\" />");
                writer.WriteLine("[MethodImpl(MethodImplOptions.AggressiveInlining)]");
                writer.WriteLine("[VtblIndex(0)]");
                using (writer.PushBlock($"public HResult QueryInterface([NativeTypeName(\"const IID &\")] Guid* riid, void** ppvObject)"))
                {
                    writer.WriteLine("return ((delegate* unmanaged[Stdcall]<IUnknown*, Guid*, void**, int>)(lpVtbl[0]))((IUnknown*)Unsafe.AsPointer(ref this), riid, ppvObject);");
                }
                writer.WriteLine();

                // AddRef
                writer.WriteLine("/// <inheritdoc cref=\"IUnknown.AddRef\" />");
                writer.WriteLine("[MethodImpl(MethodImplOptions.AggressiveInlining)]");
                writer.WriteLine("[VtblIndex(1)]");
                writer.WriteLine("[return: NativeTypeName(\"ULONG\")]");
                using (writer.PushBlock($"public uint AddRef()"))
                {
                    writer.WriteLine("return ((delegate* unmanaged[Stdcall]<IUnknown*, uint>)(lpVtbl[1]))((IUnknown*)Unsafe.AsPointer(ref this));");
                }
                writer.WriteLine();

                // Release
                writer.WriteLine("/// <inheritdoc cref=\"IUnknown.Release\" />");
                writer.WriteLine("[MethodImpl(MethodImplOptions.AggressiveInlining)]");
                writer.WriteLine("[VtblIndex(2)]");
                writer.WriteLine("[return: NativeTypeName(\"ULONG\")]");
                using (writer.PushBlock($"public uint Release()"))
                {
                    writer.WriteLine("return ((delegate* unmanaged[Stdcall]<IUnknown*, uint>)(lpVtbl[2]))((IUnknown*)Unsafe.AsPointer(ref this));");
                }
                writer.WriteLine();
                vtblIndex = 3;
            }

            bool needNewLine = false;
            foreach (KeyValuePair<ApiType, string> methodPair in methodsToGenerate)
            {
                if (needNewLine)
                {
                    writer.WriteLine();
                }

                ApiType method = methodPair.Key;
                string docName = methodPair.Value;

                // TODO: Handle inherit
                string returnType = GetTypeName(method.ReturnType);

                StringBuilder argumentBuilder = new();
                StringBuilder argumentsTypesBuilder = new();
                StringBuilder argumentsNameBuilder = new();
                int parameterIndex = 0;

                bool allOptional = false;

                if (method.Name == "EndDraw")
                {
                    allOptional =
                        method.Params.All(item => item.Attrs.Any(attr => attr is string str && str == "Optional"));
                }

                bool useReturnAsParameter = false;
                if (returnType != "void" &&
                    method.ReturnType.TargetKind != "Com" &&
                    method.ReturnType.Kind == "ApiRef" &&
                    !IsPrimitive(method.ReturnType) &&
                    !IsEnum(method.ReturnType))
                {
                    useReturnAsParameter = true;
                }

                // Return type
                returnType = NormalizeTypeName(writer.Api, returnType);

                string returnMarshalType = returnType;
                if (returnMarshalType.ToLower() == "hresult")
                {
                    returnMarshalType = "int";
                }

                if (useReturnAsParameter)
                {
                    argumentsTypesBuilder.Append(returnMarshalType);
                    argumentsTypesBuilder.Append('*');

                    if (method.Params.Count > 0)
                    {
                        argumentsTypesBuilder.Append(", ");
                    }
                }

                foreach (ApiParameter parameter in method.Params)
                {
                    bool asPointer = false;
                    string parameterType = string.Empty;

                    if (parameter.Type.Kind == "ApiRef")
                    {
                        if (parameter.Type.TargetKind == "FunctionPointer")
                        {
                            ApiType functionType = api.Types.First(item => item.Name == parameter.Type.Name && item.Kind == "FunctionPointer");
                            parameterType = "delegate* unmanaged[Stdcall]<void*, void>";
                        }
                        else
                        {
                            string fullTypeName = $"{parameter.Type.Api}.{parameter.Type.Name}";
                            if (!IsPrimitive(parameter.Type) && !IsEnum(fullTypeName))
                            {
                                asPointer = true;
                            }
                        }
                    }

                    if (string.IsNullOrEmpty(parameterType))
                    {
                        string parameterNameLookup = $"{comType.Name}::{method.Name}::{parameter.Name}";
                        if (s_mapFunctionParameters.TryGetValue(parameterNameLookup, out string? remapType))
                        {
                            parameterType = GetTypeName($"{writer.Api}.{remapType}");
                            if (parameter.Attrs.Any(item => item is string str && str == "Out"))
                            {
                                parameterType += "*";
                            }
                        }
                        else
                        {
                            parameterType = GetTypeName(parameter.Type, asPointer);
                        }
                    }

                    parameterType = NormalizeTypeName(writer.Api, parameterType);
                    string parameterName = parameter.Name;

                    bool isOptional = parameter.Attrs.Any(item => item is string str && str == "Optional");
                    if (parameter.Attrs.Any(item => item is string str && str == "ComOutPtr"))
                    {
                        if (!IsPrimitive(parameter.Type))
                        {
                            parameterType += "*";
                        }
                    }
                    else if (parameterType.EndsWith("**") == false &&
                        parameter.Attrs.Any(item => item is string str && (str == "RetVal" || str == "Out")))
                    {
                        if (parameter.Type.Child == null)
                        {
                            //if (!IsPrimitive(parameter.Type))
                            //{
                            //    parameterType += "*";
                            //}
                        }
                        else if (parameter.Type.Child.Kind != "ApiRef")
                        {
                            if (!IsPrimitive(parameter.Type))
                            {
                                parameterType += "*";
                            }
                        }
                        else
                        {
                            string apiName = GetApiName(parameter.Type.Child);
                            string fullTypeName = $"{apiName}.{parameter.Type.Child.Name}";

                            if (!IsPrimitive(parameter.Type) && !IsStruct(fullTypeName) && !IsEnum(fullTypeName))
                            {
                                parameterType += "*";
                            }
                        }
                    }

                    parameterName = CleanupName(parameterName);
                    parameterType = NormalizeTypeName(writer.Api, parameterType);

                    argumentBuilder.Append(parameterType).Append(' ').Append(parameterName);
                    if (allOptional == true && isOptional == true)
                    {
                        argumentBuilder.Append(" = null");
                    }

                    argumentsTypesBuilder.Append(parameterType);
                    argumentsNameBuilder.Append(parameterName);

                    if (parameterIndex < method.Params.Count - 1)
                    {
                        argumentBuilder.Append(", ");
                        argumentsTypesBuilder.Append(", ");
                        argumentsNameBuilder.Append(", ");
                    }

                    parameterIndex++;
                }

                if (method.Params.Count > 0 || useReturnAsParameter)
                {
                    argumentsTypesBuilder.Append(", ");
                }

                argumentsTypesBuilder.Append(returnMarshalType);
                if (useReturnAsParameter)
                {
                    argumentsTypesBuilder.Append('*');
                }

                string argumentsString = argumentBuilder.ToString();
                string argumentTypesString = argumentsTypesBuilder.ToString();
                string argumentNamesString = argumentsNameBuilder.ToString();
                if (method.Params.Count > 0)
                {
                    argumentNamesString = ", " + argumentNamesString;
                }

                if (comType.Name == docName)
                {
                    writer.WriteLine($"/// <include file='../{writer.DocFileName}.xml' path='doc/member[@name=\"{comType.Name}::{method.Name}\"]/*' />");
                }
                else
                {
                    writer.WriteLine($"/// <inheritdoc cref=\"{docName}.{method.Name}\" />");
                }

                writer.WriteLine("[MethodImpl(MethodImplOptions.AggressiveInlining)]");
                writer.WriteLine($"[VtblIndex({vtblIndex})]");

                string methodSuffix = string.Empty;
                if (method.Name == "GetType")
                {
                    if (string.IsNullOrEmpty(argumentsString))
                    {
                        methodSuffix = "new ";
                    }
                }

                using (writer.PushBlock($"public {methodSuffix}{returnType} {method.Name}({argumentsString})"))
                {
                    if (returnType != "void")
                    {
                        if (useReturnAsParameter)
                        {
                            writer.WriteLine($"{returnType} result;");
                            writer.Write("return ");
                            writer.WriteLine($"*((delegate* unmanaged[Stdcall]<{comType.Name}*, {argumentTypesString}>)(lpVtbl[{vtblIndex}]))(({comType.Name}*)Unsafe.AsPointer(ref this), &result{argumentNamesString});");
                        }
                        else
                        {
                            writer.Write("return ");
                        }
                    }

                    if (!useReturnAsParameter)
                    {
                        writer.WriteLine($"((delegate* unmanaged[Stdcall]<{comType.Name}*, {argumentTypesString}>)(lpVtbl[{vtblIndex}]))(({comType.Name}*)Unsafe.AsPointer(ref this){argumentNamesString});");
                    }
                }

                needNewLine = true;
                vtblIndex++;
            }
        }

        writer.WriteLine();
        s_visitedComTypes.Add($"{writer.Api}.{comType.Name}", methodsToGenerate);
    }

    private static bool ShouldSkipConstant(ApiDataConstant constant)
    {
        if (constant.Name == "_FACDXGI" ||
            constant.Name == "DXGI_FORMAT_DEFINED" ||
            constant.Name == "D3D11_FLOAT32_MAX" ||
            constant.Name.StartsWith("D3DX11_"))
        {
            return true;
        }

        return false;
    }

    private static string NormalizeTypeName(string api, string typeName)
    {
        if (!typeName.StartsWith(api))
        {
            return typeName;
        }

        return typeName.Replace(api + ".", "");
    }

    private static string CleanupName(string name)
    {
        if (name == "string")
        {
            return "@string";
        }

        return name;
    }

    private static string GetDataTypeName(string typeName, out string prefix)
    {
        prefix = typeName;
        if (s_knownTypesPrefixes.TryGetValue(typeName, out string? knowPrefix))
        {
            prefix = knowPrefix!;
        }

        if (s_typesNameRemap.TryGetValue(typeName, out string? remapName))
        {
            return remapName!;
        }

        string[] parts = typeName.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries);

        var sb = new StringBuilder();
        for (int i = 0; i < parts.Length; i++)
        {
            string part = parts[i];

            if (i == 0 && s_ignoredStartParts.Contains(part))
            {
                continue;
            }

            if (s_ignoredParts.Contains(part))
            {
                continue;
            }

            if (s_preserveCaps.Contains(part))
            {
                sb.Append(part);
            }
            else
            {
                if (s_partRenames.TryGetValue(part, out string? partRemap))
                {
                    sb.Append(partRemap!);
                }
                else if (s_partRenamesSet.Contains(part))
                {
                    partRemap = s_partRenamesSet.First(item => item.Equals(part, StringComparison.OrdinalIgnoreCase));
                    sb.Append(partRemap!);
                }
                else if (part == "DESC")
                {
                    sb.Append("Description");
                }
                else if (part == "DESC1")
                {
                    sb.Append("Description1");
                }
                else if (part == "DESC2")
                {
                    sb.Append("Description2");
                }
                else if (part == "DESC3")
                {
                    sb.Append("Description3");
                }
                else if (part == "FLAG")
                {
                    sb.Append("Flags");
                }
                else
                {
                    sb.Append(char.ToUpper(part[0]));
                    for (int j = 1; j < part.Length; j++)
                    {
                        sb.Append(char.ToLower(part[j]));
                    }
                }
            }
        }

        string prettyName = sb.ToString();
        if (char.IsNumber(prettyName[0]))
        {
            return "_" + prettyName;
        }

        return prettyName;
    }

    private static string GetPrettyFieldName(string value, string enumPrefix, bool skipPrettify)
    {
        if (s_knownEnumValueNames.TryGetValue(value, out string? knownName))
        {
            return knownName;
        }

        if (value.IndexOf(enumPrefix) != 0)
        {
            return value;
        }

        bool isFeatureLevel = enumPrefix == "D3D_FEATURE_LEVEL";
        bool isDXGIFormat = enumPrefix == "DXGI_FORMAT";

        string[] parts = value[enumPrefix.Length..].Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries);

        StringBuilder sb = new();

        bool appendUnderscore = false;
        if (isFeatureLevel)
        {
            sb.Append("Level").Append('_');
            appendUnderscore = true;
        }
        else if (enumPrefix == "D3D_PRIMITIVE_TOPOLOGY"
            && value.EndsWith("_CONTROL_POINT_PATCHLIST"))
        {
            sb.Append('P');
        }
        else if (enumPrefix == "D3D_PRIMITIVE"
            && value.EndsWith("_CONTROL_POINT_PATCH"))
        {
            sb.Append('P');
        }

        for (int i = 0; i < parts.Length; i++)
        {
            string part = parts[i];

            if (i == 0 && s_ignoredStartParts.Contains(part))
            {
                continue;
            }

            if (s_ignoredParts.Contains(part))
            {
                continue;
            }

            if (s_preserveCaps.Contains(part) || skipPrettify)
            {
                sb.Append(part);
            }
            else
            {
                if (isDXGIFormat)
                {
                    if (part.Equals("UNKNOWN", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("Unknown");
                    }
                    else if (part.Equals("TYPELESS", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("Typeless");
                    }
                    else if (part.Equals("UNORM", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("Unorm");
                    }
                    else if (part.Equals("SNORM", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("Snorm");
                    }
                    else if (part.Equals("UINT", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("Uint");
                    }
                    else if (part.Equals("SINT", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("Sint");
                    }
                    else if (part.Equals("FLOAT", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("Float");
                    }
                    else if (part.Equals("SRGB", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("Srgb");
                    }
                    else if (part.Equals("SHAREDEXP", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("SharedExp");
                    }
                    else if (part.Equals("SAMPLER", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("Sampler");
                    }
                    else if (part.Equals("FEEDBACK", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("Feedback");
                    }
                    else if (part.Equals("MIN", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("Min");
                    }
                    else if (part.Equals("MIP", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("Mip");
                    }
                    else if (part.Equals("OPAQUE", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("Opaque");
                    }
                    else if (part.Equals("REGION", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("Region");
                    }
                    else if (part.Equals("USED", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("Used");
                    }
                    else
                    {
                        sb.Append(part);
                    }
                }
                else
                {
                    if (s_partRenames.TryGetValue(part, out string? partRemap))
                    {
                        sb.Append(partRemap!);
                    }
                    else if (s_partRenamesSet.Contains(part))
                    {
                        partRemap = s_partRenamesSet.First(item => item.Equals(part, StringComparison.OrdinalIgnoreCase));
                        sb.Append(partRemap!);
                    }
                    else
                    {
                        sb.Append(char.ToUpper(part[0]));
                        for (int j = 1; j < part.Length; j++)
                        {
                            sb.Append(char.ToLower(part[j]));
                        }
                    }
                }
            }

            if (appendUnderscore)
            {
                if (i < parts.Length - 1)
                {
                    sb.Append('_');
                }
            }
        }

        string prettyName = sb.ToString();
        if (string.IsNullOrEmpty(prettyName))
        {
            return parts[0];
        }

        if (char.IsNumber(prettyName[0]))
        {
            if (enumPrefix.EndsWith("_TIER"))
            {
                if (prettyName.Length == 2) // D3D12_RAYTRACING_TIER_1_0
                    return "Tier" + prettyName[0] + "_" + prettyName[1];

                return "Tier" + prettyName;
            }
            else if (value.EndsWith("_BIT")) // D3D11_SHADER_MIN_PRECISION_10_BIT
            {
                return "P" + prettyName;
            }
            else if (enumPrefix.EndsWith("_ROTATION")) // D3D11_VIDEO_PROCESSOR_ROTATION
            {
                return "Rotation" + prettyName;
            }
            else if (enumPrefix.EndsWith("_SHADER_MODEL")) // D3D_SHADER_MODEL
            {
                return "SM_" + prettyName[0] + "_" + prettyName[1];
            }
            else if (enumPrefix.EndsWith("_VERSION"))
            {
                if (prettyName.Length == 2) // D3D12_DRED_VERSION_1_0
                    return "V" + prettyName[0] + "_" + prettyName[1];

                return "V" + prettyName;
            }
            else if (enumPrefix.EndsWith("_RATE"))
            {
                return "Rate" + prettyName;
            }
            else if (enumPrefix.Contains("_LEVEL"))
            {
                return "Level_" + prettyName;
            }
            else if (enumPrefix.Contains("_GAMMA"))
            {
                return "Gamma_" + prettyName[0] + "_" + prettyName[1];
            }

            return "_" + prettyName;
        }

        return prettyName;
    }

    private static void WriteGuid(CodeWriter writer, string guidValue, string guidName)
    {
        using (writer.PushBlock($"public static ref readonly Guid {guidName}"))
        {
            writer.WriteLine("[MethodImpl(MethodImplOptions.AggressiveInlining)]");
            using (writer.PushBlock("get"))
            {
                var guid = Guid.Parse(guidValue).ToString("N");
                var _1 = "0x" + guid.Substring(6, 2).ToUpperInvariant();
                var _2 = "0x" + guid.Substring(4, 2).ToUpperInvariant();
                var _3 = "0x" + guid.Substring(2, 2).ToUpperInvariant();
                var _4 = "0x" + guid.Substring(0, 2).ToUpperInvariant();

                var _5 = "0x" + guid.Substring(10, 2).ToUpperInvariant();
                var _6 = "0x" + guid.Substring(8, 2).ToUpperInvariant();

                var _7 = "0x" + guid.Substring(14, 2).ToUpperInvariant();
                var _8 = "0x" + guid.Substring(12, 2).ToUpperInvariant();

                var d = "0x" + guid.Substring(16, 2).ToUpperInvariant();
                var e = "0x" + guid.Substring(18, 2).ToUpperInvariant();
                var f = "0x" + guid.Substring(20, 2).ToUpperInvariant();
                var g = "0x" + guid.Substring(22, 2).ToUpperInvariant();
                var h = "0x" + guid.Substring(24, 2).ToUpperInvariant();
                var i = "0x" + guid.Substring(26, 2).ToUpperInvariant();
                var j = "0x" + guid.Substring(28, 2).ToUpperInvariant();
                var k = "0x" + guid.Substring(30, 2).ToUpperInvariant();

                writer.WriteLine("ReadOnlySpan<byte> data = new byte[] {");
                writer.WriteLine($"{'\t'}{_1}, {_2}, {_3}, {_4},");
                writer.WriteLine($"{'\t'}{_5}, {_6},");
                writer.WriteLine($"{'\t'}{_7}, {_8},");
                writer.WriteLine($"{'\t'}{d},");
                writer.WriteLine($"{'\t'}{e},");
                writer.WriteLine($"{'\t'}{f},");
                writer.WriteLine($"{'\t'}{g},");
                writer.WriteLine($"{'\t'}{h},");
                writer.WriteLine($"{'\t'}{i},");
                writer.WriteLine($"{'\t'}{j},");
                writer.WriteLine($"{'\t'}{k}");
                writer.WriteLine("};");
                writer.WriteLine();

                writer.WriteLine("Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());");
                writer.WriteLine("return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));");
            }
        }
    }

    private static string GetApiName(ApiDataType dataType)
    {
        if (dataType.Kind != "ApiRef")
        {
            throw new InvalidOperationException();
        }

        string apiName = dataType.Api;
        if (dataType.Parents?.Length > 0)
        {
            apiName += ".";
            apiName += string.Join(".", dataType.Parents);
        }

        return apiName;
    }

    private static string GetTypeName(ApiDataType dataType, bool asPointer = false)
    {
        if (dataType.Kind == "ApiRef")
        {
            string apiName = GetApiName(dataType);
            string fullTypeName = $"{apiName}.{dataType.Name}";
            string typeName = GetTypeName(fullTypeName);
            return asPointer ? typeName + "*" : typeName;
        }
        else if (dataType.Kind == "Array")
        {
            return "Array";
        }
        else if (dataType.Kind == "LPArray")
        {
            if (dataType.Child.Kind == "ApiRef")
            {
                string apiName = GetApiName(dataType.Child);
                string fullTypeName = $"{apiName}.{dataType.Child.Name}";
                if (!IsPrimitive(dataType) && !IsStruct(fullTypeName) && !IsEnum(fullTypeName))
                {
                    asPointer = true;
                }
            }

            return GetTypeName(dataType.Child, asPointer) + "*";
        }
        else if (dataType.Kind == "PointerTo")
        {
            return GetTypeName(dataType.Child) + "*";
        }

        return GetTypeName(dataType.Name);
    }

    private static bool IsPrimitive(string typeName)
    {
        if (typeName.EndsWith("*"))
        {
            typeName = typeName.Substring(0, typeName.Length - 1);
        }

        switch (typeName)
        {
            case "void":
            case "bool":
            case "byte":
            case "sbyte":
            case "int":
            case "uint":
            case "short":
            case "ushort":
            case "long":
            case "ulong":
            case "float":
            case "double":
                return true;

            case "nint":
            case "nuint":
            case "IntPtr":
            case "UIntPtr":
            case "Guid":
                return true;

            case "Bool32":
            case "LargeInteger":
            case "ULargeInteger":
            case "Luid":
            case "HResult":
                return true;

            case "System.Drawing.Size":
            case "System.Drawing.SizeF":
                return true;
        }

        return false;
    }

    private static bool IsPrimitive(ApiDataType dataType)
    {
        if (dataType.Kind == "ApiRef")
        {
            string apiRefType = GetTypeName($"{dataType.Api}.{dataType.Name}");
            return IsPrimitive(apiRefType);
        }
        else if (dataType.Kind == "PointerTo")
        {
            return IsPrimitive(dataType.Child);
        }
        else if (dataType.Kind == "LPArray")
        {
            return IsPrimitive(dataType.Child);
        }

        if (dataType.Kind != "Native")
        {
            return false;
        }

        string typeName = GetTypeName(dataType.Name);
        return IsPrimitive(typeName);
    }

    private static bool IsEnum(ApiDataType dataType)
    {
        if (dataType.Kind == "ApiRef")
        {
            string apiRefType = $"{dataType.Api}.{dataType.Name}";
            return IsEnum(apiRefType);
        }

        return false;
    }

    private static bool IsEnum(string typeName)
    {
        return s_visitedEnums.Contains(typeName);
    }

    private static bool IsStruct(string typeName)
    {
        switch (typeName)
        {
            case "Foundation.RECT":
                return true;

            default:
                return s_visitedStructs.Contains(typeName);
        }

    }

    private static void AddCsMapping(string api, string typeName, string csTypeName)
    {
        s_csNameMappings[$"{api}.{typeName}"] = $"{api}.{csTypeName}";
    }

    private static string GetTypeName(string name)
    {
        string? mappedName;
        if (s_csNameMappings.TryGetValue(name, out mappedName))
        {
            return mappedName!;
        }
        else if (s_typesNameRemap.TryGetValue(name, out mappedName))
        {
            return mappedName!;
        }

        return name;
    }
}
