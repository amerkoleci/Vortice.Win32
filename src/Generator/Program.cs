// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Generator;

public static class Program
{
    private static readonly string[] s_jsons =
    [
        "Graphics.Dxgi.Common.json",
        "Graphics.Dxgi.json",
        "Graphics.Direct3D.json",
        "Graphics.Direct3D11.json",
        "Graphics.Direct3D12.json",
        "Graphics.Direct3D11on12.json",
        "Graphics.Direct3D.Dxc.json",
        "Graphics.Direct3D.Fxc.json",
        "Graphics.Direct2D.Common.json",
        "Graphics.Imaging.json",
        "Graphics.DirectWrite.json",
        "Graphics.Direct2D.json",
        "Graphics.Imaging.D2D.json",
        "Graphics.DirectComposition.json",
        //"Graphics.Direct3D9.json",

        // Media
        //"Media.Audio.json",
        "Media.Audio.XAudio2.json",
    ];

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

        {"Char", "char" },

        { "Foundation.BOOL", "Bool32" },
        { "Foundation.BOOLEAN", "byte" },
        { "Foundation.BSTR", "char*" },
        { "Foundation.HANDLE", "Handle" },
        { "Foundation.HINSTANCE", "nint" },
        { "Foundation.HMODULE", "nint" },
        { "Foundation.HRESULT", "HResult" },
        { "Foundation.HWND", "nint" },
        { "Foundation.LPARAM", "nint" },
        { "Foundation.LRESULT", "nint" },
        { "Foundation.WPARAM", "nuint" },
        { "Foundation.PSTR", "byte*" },
        { "Foundation.PWSTR", "char*" },
        { "Foundation.CHAR", "byte" },
        { "Foundation.COLORREF", "uint" },

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
        { "Graphics.Gdi.RGNDATA", "Win32.Graphics.Gdi.RgnData" },
        { "Graphics.Gdi.PALETTEENTRY", "Win32.Graphics.Gdi.PaletteEntry" },

        { "Graphics.Direct3D.D3DVECTOR", "Vector3" },
        { "Graphics.Direct3D.D3DMATRIX", "Matrix4x4" },
        { "Graphics.Dxgi.DXGI_MATRIX_3X2_F", "Matrix3x2" },
        { "Graphics.Direct2D.Common.D2D_MATRIX_3X2_F", "Matrix3x2" },
        { "Graphics.DirectWrite.DWRITE_MATRIX", "Matrix3x2" },
        { "Graphics.Direct2D.Common.D2D_MATRIX_4X3_F", "Matrix4x3" },
        { "Graphics.Direct2D.Common.D2D_MATRIX_4X4_F", "Matrix4x4" },
        { "Graphics.Direct2D.Common.D2D_MATRIX_5X4_F", "Matrix5x4" },
        { "Graphics.Direct2D.Common.D2D_POINT_2F", "Vector2" },
        { "Graphics.Direct2D.Common.D2D_VECTOR_2F", "Vector2" },
        { "Graphics.Direct2D.Common.D2D_VECTOR_3F", "Vector3" },
        { "Graphics.Direct2D.Common.D2D_VECTOR_4F", "Vector4" },
        { "Graphics.Direct2D.Common.D2D_SIZE_F", "System.Drawing.SizeF" },
        { "Graphics.Direct2D.Common.D2D_POINT_2U", "System.Drawing.Point" },
        { "Graphics.Direct2D.Common.D2D_SIZE_U", "System.Drawing.Size" },
        { "Graphics.Direct2D.Common.D2D_RECT_U", "Win32.Numerics.Rect" },
        { "Graphics.Direct2D.Common.D2D_RECT_F", "Win32.Numerics.RectF" },

        { "Graphics.Imaging.WICRect", "System.Drawing.Rectangle" },

        { "Graphics.Dxgi.DXGI_RGBA", "Color4" },
        { "Graphics.Direct2D.Common.D2D1_COLOR_F", "Color4" },
        { "Graphics.DirectWrite.DWRITE_COLOR_F", "Color4" },
        { "Graphics.Direct2D.Matrix4x3F", "Matrix4x3" },
        { "Graphics.Direct2D.Matrix4x4F", "Matrix4x4" },
        { "Graphics.Direct2D.Matrix5x4F", "Matrix5x4" },

        { "Graphics.Direct3D11.D3D11_VIEWPORT", "Viewport" },
        { "Graphics.Direct3D12.D3D12_VIEWPORT", "Viewport" },

        // Media
        { "Media.Audio.AUDIO_STREAM_CATEGORY", "Media.Audio.AudioStreamCategory" },
        { "Media.Audio.WAVEFORMATEX", "Media.Audio.WaveFormatEx" },
        //{ "Media.Audio.XAudio2.HrtfPosition", "Vector3" },

        // TODO: Understand those ->
        { "Foundation.RECT", "Rect" },
        { "Foundation.RECTL", "Rect" },
        { "Foundation.POINT", "System.Drawing.Point" },
        { "Foundation.POINTL", "System.Drawing.Point" },
        { "Foundation.SIZE", "System.Drawing.Size" },
    };

    private static readonly Dictionary<string, string> s_partRenames = new()
    {
        { "CBUFFER", "ConstantBuffer" },
        { "TBUFFER", "TextureBuffer" },
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
        { "INCR", "Increment" },
        { "DECR", "Decrement" },
        { "SAT", "Saturate" },
        { "INV", "Inverse" },
        { "REV", "Reverse" },
        { "XAUDIO2FX", "FX" },
    };

    private static readonly HashSet<string> s_partRenamesSet = new(StringComparer.OrdinalIgnoreCase)
    {
        "Int16",
        "UInt16",
        "Int32",
        "UInt32",
        "Int64",
        "UInt64",
        "IUnknown",
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
        "DecoderEndFrame",
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
        "DpiCompensation",
        "ArithmeticComposite",
        "BitmapSource",
        "ChromaKey",
        "ColorManagement",
        "ConvolveMatrix",
        "DirectionalBlur",
        "DiscreteTransfer",
        "DisplacementMap",
        "DistantDiffuse",
        "DistantSpecular",
        "EdgeDetection",
        "GammaTransfer",
        "GaussianBlur",
        "HDRTonemap",
        "HighlightSandShadows",
        "HueRotation",
        "HueToRgb",
        "LinearTransfer",
        "OpacityMetadata",
        "PointDiffuse",
        "PointSpecular",
        "SpotDiffuse",
        "SpotSpecular",
        "RgbToHue",
        "SubProperty",
        "TableTransfer",
        "WhiteLevelAdjustment",
        "LookupTable3D",
        "NonPrerotated",
        "PointList",
        "LineList",
        "LineStrip",
        "TriangleList",
        "TriangleStrip",
        "PatchList",
        "MissingSemantic",
        "MaskmisMatch",
        "CantHaveOnlyGaps",
        "DeclTooComplex",
        "InvalidSourceRect",
        "PrimitiveTopology",
        "UnrecognizedDstFormat",
        "InvalidDstDimensions",
        "InvalidDstRowPitch",
        "InvalidDstPlacement",
        "InvalidDstdsPlacedFootPrintFormat",
        "DstRegionOutOfBounds",
        "UnrecognizedSrcType",
        "InvalidSrcResource",
        "InvalidSrcSubresource",
        "InvalidSrcOffset",
        "NullRange",
        "VideoDecodeStream",
        "VideoDecodeCommandList",
        "SetResidencyPriority",
        "AtomicCopyBuffer",
        "VideoProcessCommandQueue",
        "VideoProcessStream",
        "OpenExistingHeap",
        "RSSetShading",
        "RSSetShadingRate",
        "RSSetShadingRateImage",
        "CreateMeshShader",
        "GroupSharedExceedsMaxSize",
        "MismatchedASMSPayloadSize",
        "CreateAmplificationShader",
        "ShaderCacheSession",
        "CreateShaderCacheSession",
        "AlreadyOpen",
        "DeveloperMode",
        "ShaderCacheControl",
        "StateAlreadySet",
        "IgnoredFlag",
        "StoreValue",
        "StoreValueAlreadyPresent",
        "HashCollision",
        "CacheFull",
        "NotFound",
        "FindValue",
        "VideoEncoder",
        "VideoEncoderHeap",
        "ShaderCacheDelete",
        "ShaderCacheClear",
        "VideoExtensionCommand",
        "VideoMotionEstimator",
        "LockForProcess",
        "FxMasteringLimiter",
        "FxReverb",
        "FxEcho",
        "InitData",
        "VolumeMeter",
        "HrtfDirectivityType",
        "HrtfEnvironment",
        "HrtfDistanceDecayType",
        "HrtfPosition",
        "HrtfOrientation",
        "HrtfDirectivity",
        "HrtfDirectivityCardioid",
        "HrtfDirectivityCone",
        "HrtfDistanceDecay",
        "HrtfApoInit",
        "CreatePipelinelibrary",
        "InvalidLibraryBlob",
        "DriverVersionMismatch",
        "AdapterVersionMismatch",
        "StorePipeline",
        "LoadPipeline",
        "DuplicateName",
        "NameNotFound",
        "NotEnoughMemory",
        "SetEventOnMultipleFenceCompletion",
        "SamplePositions",
        "SetSamplePositions",
        "VideoDecodeCommandQueue",
        "VideoProcessCommandList",
        "VideoDecoderHeap",
        "VideoEncodeCommandList",
        "VideoEncodeCommandQueue",
        "CommandRecorder",
        "CommandPool",
        "CreatePlacedResourceOnBuffer",
        "VideoMotionVectorHeap",
        "CreateCommandList",
        "BlendOp",
        "BlendOpAlpha",
        "BlendOpAlpha",
        "SetBlendState",
        "OMSetDepthStencil",
        "VSShaderResources",
        "NegativeScissor",
        "NumUAVs",
        "RefCount",
        "DiscardView",
        "NtHandle",
        "DrawIndexed",
        "CopySubresourceRegion1",
        "GetVideoDecoderProfile",
        "GetVideoDecoderProfileCount",
        "CheckVideoDecoderFormat",
        "GetVideoDecoderConfig",
        "GetVideoDecoderConfigCount",
        "InvalidIndex",
        "InvalidType",
        "InvalidArray",
        "GetDecoderCreationParams",
        "GetDecoderDriverHandle",
        "GetDecoderBuffer",
        "ReleaseDecoderBuffer",
        "SubmitDecoderBuffers",
        "DecoderExtension",
        "CreateVideoProcessorEnumerator",
        "GetVideoProcessorContentDesc",
        "CheckVideoProcessorFormat",
        "GetVideoProcessorCaps",
        "GetVideoProcessorCustomRate",
        "GetVideoProcessorRateConversionCaps",
        "CreateAuthenticatedChannel",
        "AcquireHandleForCapture",
        "CreateVideoProcessorInputView",
        "CreateVideoProcessorOutputView",
        "InvalidMsaa",
        "EmptySourceBox",
        "EmptyDestBox",
        "NegotiateCryptoSessionKeyExchangeMt",
        "InvalidKeyExchangeType",
        "InvalidContext",
        "SetHardwareProtection",
        "UnsupportedContexttTypeForQuery",
        "VideoProcessorSetOutputHDRMetadata",
        "VideoProcessorGetOutputHDRMetadata",
        "VideoProcessorSetStreamHDRMetadata",
        "VideoProcessorGetStreamHDRMetadata",
        "VideoProcessorGetStreamColorSpace",
        "VideoProcessorGetStreamFrameFormat",
        "VideoProcessorSetStreamColorSpace",
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
        "D3D10",
        "D3D11",
        "D3D12",
        "D2D",
        "D2D1",
        "DWRITE",
        "HDR",
        "DC",
        "XNA",
        "XAPO",
        "FXEQ",
        "I3DL2",
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
        { "DXGI_SHARED_RESOURCE_RW", "DXGI_SHARED_RESOURCE" },
        { "DXGI_CREATE_FACTORY_FLAGS", "DXGI_CREATE_FACTORY" },

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
        { "D3D11_SHADER_VERSION_TYPE", "D3D11_SHVER" },
        { "D3D11_SHADER_TYPE", "D3D11" },
        { "D3D11_TRACE_REGISTER_TYPE", "D3D11_TRACE" },

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
        { "WICPersistOptions", "WICPersistOption" },

        // FXC
        { "D3DCOMPILER_STRIP_FLAGS", "D3DCOMPILER_STRIP" },
        { "D3D_BLOB_PART", "D3D_BLOB" },

        // DirectComposition
        { "COMPOSITION_FRAME_ID_TYPE", "COMPOSITION_FRAME_ID" },
    };

    private static readonly Dictionary<string, string> s_knownEnumValueNames = new()
    {
        { "DXGI_FORMAT_420_OPAQUE", "Opaque420" },
        { "DXGI_FORMAT_R8G8_B8G8_UNORM", "R8G8_B8G8Unorm" },
        { "DXGI_FORMAT_G8R8_G8B8_UNORM", "G8R8_G8B8Unorm" },

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

        // D2D1
        { "D2D1_BUFFER_PRECISION_8BPC_UNORM", "Precision8BitUnorm" },
        { "D2D1_BUFFER_PRECISION_8BPC_UNORM_SRGB", "Precision8BitUnormSrgb" },
        { "D2D1_BUFFER_PRECISION_16BPC_UNORM", "Precision16BitUnorm" },
        { "D2D1_BUFFER_PRECISION_16BPC_FLOAT", "Precision16BitFloat" },
        { "D2D1_BUFFER_PRECISION_32BPC_FLOAT", "Precision32BitFloat" },

        // XAudio2
        { "XAPO_BUFFER_SILENT", "Silent" },
        { "XAPO_BUFFER_VALID", "Valid" },
    };

    private static readonly Dictionary<string, bool> s_generatedEnums = new()
    {
        {"DXGI_CPU_ACCESS", false },
        {"DXGI_USAGE", true },
        {"DXGI_MAP", true },
        {"DXGI_PRESENT", true },
        {"DXGI_MWA_FLAGS", true },
        {"DXGI_ENUM_MODES", true },
        {"DXC_HASHFLAG", true },
        {"DxcValidatorFlags", true },
        {"DxcVersionInfoFlags", true },

        // FXC
        {"D3DCOMPILE_EFFECT", true },
        {"D3DCOMPILE", true },
        {"D3DCOMPILE_FLAGS2", true },
        {"D3DCOMPILE_SECDATA", true },
        {"D3D_COMPRESS_SHADER", true },
        {"D3D_DISASM", true },
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
        "D3DCOMPILER",
        "DCOMPOSITION",
        "D3DADAPTER",
        "XAUDIO2",
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
        { "DXGI_MWA_FLAGS", "WindowAssociationFlags" },
        { "DXGI_PRESENT", "PresentFlags" },
        { "DXGI_DEBUG_RLO_FLAGS", "ReportLiveObjectFlags" },

        // D3D11
        { "D3D11_MAP", "MapMode" },
        { "D3D11_RLDO_FLAGS", "ReportLiveDeviceObjectFlags" },
        { "D3D11_1_CREATE_DEVICE_CONTEXT_STATE_FLAG", "CreateDeviceContextStateFlags" },
        { "D3D11_QUERY", "QueryType" },
        { "D3D11_COMPARISON_FUNC", "ComparisonFunction" },
        { "D3D11_STENCIL_OP", "StencilOperation" },
        { "D3D11_BLEND_OP", "BlendOperation" },
        { "D3D11_LOGIC_OP", "LogicOperation" },
        { "D3D11_DEPTH_STENCILOP_DESC", "DepthStencilOperationDescription" },

        // D3D12
        { "D3D12_RLDO_FLAGS", "ReportLiveDeviceObjectFlags" },
        { "D3D12_COMPARISON_FUNC", "ComparisonFunction" },
        { "D3D12_STENCIL_OP", "StencilOperation" },
        { "D3D12_BLEND_OP", "BlendOperation" },
        { "D3D12_LOGIC_OP", "LogicOperation" },
        { "D3D12_PREDICATION_OP", "PredicationOperation" },
        { "D3D12_AUTO_BREADCRUMB_OP", "AutoBreadcrumbOperation" },
        { "D3D12_DEPTH_STENCILOP_DESC", "DepthStencilOperationDescription" },

        // D2D1
        { "D2D1_2DAFFINETRANSFORM_INTERPOLATION_MODE", "AffineTransform2DInterpolationMode" },
        { "D2D1_3DTRANSFORM_PROP", "Transform3DProperties" },
        { "D2D1_3DTRANSFORM_INTERPOLATION_MODE", "Transform3DInterpolationMode" },
        { "D2D1_3DPERSPECTIVETRANSFORM_PROP", "PerspectiveTransform3DProperties" },
        { "D2D1_3DPERSPECTIVETRANSFORM_INTERPOLATION_MODE", "PerspectiveTransform3DInteroplationMode" },
        { "D2D1_2DAFFINETRANSFORM_PROP", "AffineTransform2DProperties" },

        // Dxc
        { "DXC_HASHFLAG", "DxcHashFlags" },
        { "DxcValidatorFlags", "DxcValidatorFlags" },
        { "DxcVersionInfoFlags", "DxcVersionInfoFlags" },

        // FXC
        {"D3DCOMPILE", "CompileFlags" },
        {"D3DCOMPILE_FLAGS2", "CompileFlags2" },
        {"D3DCOMPILE_EFFECT", "CompileEffectFlags" },
        {"D3DCOMPILE_SECDATA", "CompileSecondaryFlags" },
        {"D3D_COMPRESS_SHADER", "CompressShaderFlags" },
        {"D3D_DISASM", "DisasmFlags" },
    };

    private static readonly Dictionary<string, string> s_structFieldTypeRemap = new()
    {
        { "DXGI_ADAPTER_DESC1::Flags", "DXGI_ADAPTER_FLAG" },
        { "DXGI_ADAPTER_DESC3::Flags", "DXGI_ADAPTER_FLAG3" },
        { "DXGI_SWAP_CHAIN_DESC::BufferUsage", "Usage" },
        { "DXGI_SWAP_CHAIN_DESC::Flags", "DXGI_SWAP_CHAIN_FLAG" },
        { "DXGI_SWAP_CHAIN_DESC1::BufferUsage", "Usage" },
        { "DXGI_SWAP_CHAIN_DESC1::Flags", "DXGI_SWAP_CHAIN_FLAG" },
        { "DXGI_DECODE_SWAP_CHAIN_DESC::Flags", "DXGI_SWAP_CHAIN_FLAG" },

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
        { "D3D11_TEXTURE2D_DESC1::BindFlags", "D3D11_BIND_FLAG" },
        { "D3D11_TEXTURE2D_DESC1::CPUAccessFlags", "D3D11_CPU_ACCESS_FLAG" },
        { "D3D11_TEXTURE2D_DESC1::MiscFlags", "D3D11_RESOURCE_MISC_FLAG" },

        { "D3D11_TEXTURE3D_DESC::BindFlags", "D3D11_BIND_FLAG" },
        { "D3D11_TEXTURE3D_DESC::CPUAccessFlags", "D3D11_CPU_ACCESS_FLAG" },
        { "D3D11_TEXTURE3D_DESC::MiscFlags", "D3D11_RESOURCE_MISC_FLAG" },
        { "D3D11_TEXTURE3D_DESC1::BindFlags", "D3D11_BIND_FLAG" },
        { "D3D11_TEXTURE3D_DESC1::CPUAccessFlags", "D3D11_CPU_ACCESS_FLAG" },
        { "D3D11_TEXTURE3D_DESC1::MiscFlags", "D3D11_RESOURCE_MISC_FLAG" },

        { "D3D11_QUERY_DESC::MiscFlags", "D3D11_QUERY_MISC_FLAG" },
        { "D3D11_QUERY_DESC1::MiscFlags", "D3D11_QUERY_MISC_FLAG" },

        { "D3D11_FEATURE_DATA_FORMAT_SUPPORT::OutFormatSupport", "D3D11_FORMAT_SUPPORT" },
        { "D3D11_FEATURE_DATA_FORMAT_SUPPORT2::OutFormatSupport2", "D3D11_FORMAT_SUPPORT2" },

        { "D3D11_RENDER_TARGET_BLEND_DESC::RenderTargetWriteMask", "D3D11_COLOR_WRITE_ENABLE" },
        { "D3D11_RENDER_TARGET_BLEND_DESC1::RenderTargetWriteMask", "D3D11_COLOR_WRITE_ENABLE" },
        { "D3D11_DEPTH_STENCIL_VIEW_DESC::Flags", "D3D11_DSV_FLAG" },
        { "D3D11_BUFFER_UAV::Flags", "D3D11_BUFFER_UAV_FLAG" },
        { "D3D11_BUFFEREX_SRV::Flags", "D3D11_BUFFEREX_SRV_FLAG" },

        { "D3D11_RESOURCE_FLAGS::BindFlags", "Graphics.Direct3D11.D3D11_BIND_FLAG" },
        { "D3D11_RESOURCE_FLAGS::CPUAccessFlags", "Graphics.Direct3D11.D3D11_CPU_ACCESS_FLAG" },
        { "D3D11_RESOURCE_FLAGS::MiscFlags", "Graphics.Direct3D11.D3D11_RESOURCE_MISC_FLAG" },

        // D3D12
        { "D3D12_RENDER_TARGET_BLEND_DESC::RenderTargetWriteMask", "D3D12_COLOR_WRITE_ENABLE" },

        // Dxc
        { "DxcBuffer::Encoding", "DXC_CP" },
        { "DxcShaderHash::Flags", "DXC_HASHFLAG" },

        // XAudio2
        { "XAUDIO2_DEBUG_CONFIGURATION::TraceMask", "LogType" },
        { "XAUDIO2_DEBUG_CONFIGURATION::BreakMask", "LogType" },
    };

    private static readonly Dictionary<string, string> s_structFieldNameRemap = new()
    {
        { "D3D12_SAMPLE_MASK::SampleMask", "Mask" },
        { "D3D12_DEPTH_STENCIL_FORMAT::DepthStencilFormat", "Format" },
    };

    private static readonly Dictionary<string, string> s_mapFunctionParameters = new()
    {
        // DXGI
        { "IDXGIDevice::CreateSurface::Usage", "DXGI_USAGE" },
        { "IDXGIOutput::GetDisplayModeList::Flags", "DXGI_ENUM_MODES" },
        { "IDXGISwapChain::Present::Flags", "DXGI_PRESENT" },
        { "IDXGISwapChain::ResizeBuffers::SwapChainFlags", "DXGI_SWAP_CHAIN_FLAG" },
        { "IDXGIFactory::MakeWindowAssociation::Flags", "DXGI_MWA_FLAGS" },

        // D3D11
        { "ID3D11DeviceContext::Map::MapFlags", "D3D11_MAP_FLAG" },
        { "ID3D11DeviceContext::ClearDepthStencilView::ClearFlags", "D3D11_CLEAR_FLAG" },
        { "ID3D11DeviceContext1::Map::MapFlags", "D3D11_MAP_FLAG" },
        { "ID3D11DeviceContext1::ClearDepthStencilView::ClearFlags", "D3D11_CLEAR_FLAG" },
        { "ID3D11DeviceContext2::Map::MapFlags", "D3D11_MAP_FLAG" },
        { "ID3D11DeviceContext2::ClearDepthStencilView::ClearFlags", "D3D11_CLEAR_FLAG" },
        { "ID3D11DeviceContext3::Map::MapFlags", "D3D11_MAP_FLAG" },
        { "ID3D11DeviceContext3::ClearDepthStencilView::ClearFlags", "D3D11_CLEAR_FLAG" },

        // D3D12

        // Dxc
        { "IDxcValidator::Validate::Flags", "DxcValidatorFlags" },
        { "IDxcValidator2::Validate::Flags", "DxcValidatorFlags" },
        { "IDxcValidator2::ValidateWithDebug::Flags", "DxcValidatorFlags" },
        { "IDxcVersionInfo::GetFlags::pFlags", "DxcVersionInfoFlags" },
        { "IDxcVersionInfo2::GetFlags::pFlags", "DxcVersionInfoFlags" },

        // WIC
        { "IWICImagingFactory::CreateDecoderFromFilename::dwDesiredAccess", "NativeFileAccess" },
        { "IWICComponentFactory::CreateDecoderFromFilename::dwDesiredAccess", "NativeFileAccess" },
        { "IWICBitmap::Lock::flags", "WICBitmapLockFlags" },
        { "IWICPersistStream::LoadEx::dwPersistOptions", "WICPersistOptions" },
        { "IWICPersistStream::SaveEx::dwPersistOptions", "WICPersistOptions" },

        // FXC
        { "D3DCompile::Flags1", "D3DCOMPILE" },
        { "D3DCompile2::Flags1", "D3DCOMPILE" },
        { "D3DCompileFromFile::Flags1", "D3DCOMPILE" },
        { "D3DCompressShaders::uFlags", "D3D_COMPRESS_SHADER" },
        { "D3DDisassemble::Flags", "D3D_DISASM" },

        { "D3D11On12CreateDevice::Flags", "Graphics.Direct3D11.D3D11_CREATE_DEVICE_FLAG" },
    };

    private static readonly HashSet<string> s_visitedEnums = new();
    private static readonly HashSet<string> s_visitedStructs = new();
    private static readonly Dictionary<string, Dictionary<string, List<ApiType>>> s_visitedComTypes = new();
    private static readonly HashSet<string> s_enumConstants = [];

    private static bool s_generateUnmanagedDocs = true;

    public static string FindRepoRoot()
    {
        string currentDir = Directory.GetCurrentDirectory();
        Console.WriteLine("cwd is '{0}'", currentDir);
        while (true)
        {
            string repoDir = Path.Combine(currentDir, "Vortice.Win32");
            Console.WriteLine("looking for Vortice.Win32 at '{0}'", repoDir);
            if (Directory.Exists(repoDir))
            {
                return repoDir;
            }

            string? nextDir = Path.GetDirectoryName(currentDir);
            if (nextDir == null || nextDir == currentDir)
            {
                Console.WriteLine("Error: failed to find the 'Vortice.Win32' repository in any of the parent directories");
                Console.WriteLine("       feel free to clone it so one of the directories that were searched above");
                Environment.Exit(1);
            }

            currentDir = nextDir;
        }
    }

    public static int Main()
    {
        string repoRoot = FindRepoRoot();
        string rootPath = new DirectoryInfo(repoRoot).Parent!.FullName;
        string dxgiPath = Path.Combine(rootPath, "Vortice.Win32.Graphics.Dxgi");
        string d3d9Path = Path.Combine(rootPath, "Vortice.Win32.Graphics.Direct3D9");
        string d3d11Path = Path.Combine(rootPath, "Vortice.Win32.Graphics.Direct3D11");
        string d3d12Path = Path.Combine(rootPath, "Vortice.Win32.Graphics.Direct3D12");
        string d3d11on12Path = Path.Combine(rootPath, "Vortice.Win32.Graphics.Direct3D11on12");
        string dwritePath = Path.Combine(rootPath, "Vortice.Win32.Graphics.DirectWrite");
        string wicPath = Path.Combine(rootPath, "Vortice.Win32.Graphics.Imaging");
        string d2dPath = Path.Combine(rootPath, "Vortice.Win32.Graphics.Direct2D");
        string dxcPath = Path.Combine(rootPath, "Vortice.Win32.Graphics.Direct3D.Dxc");
        string fxcPath = Path.Combine(rootPath, "Vortice.Win32.Graphics.Direct3D.Fxc");
        string directCompositionPath = Path.Combine(rootPath, "Vortice.Win32.Graphics.DirectComposition");
        string XAudio2Path = Path.Combine(rootPath, "Vortice.Win32.Media.Audio.XAudio2");

        // Generate docs
        //DocGenerator.Generate(new[] { "DXGI" }, Path.Combine(repoRoot, "Generated", "Graphics", "Dxgi.xml"));
        //DocGenerator.Generate(new[] { "D3D" }, Path.Combine(repoRoot, "Generated", "Graphics", "Direct3D.xml"));
        //DocGenerator.Generate(new[] { "D2D1" }, Path.Combine(repoRoot, "Generated", "Graphics", "Direct2D.xml"));
        //DocGenerator.Generate(new[] { "DWRITE" }, Path.Combine(repoRoot, "Generated", "Graphics", "DirectWrite.xml"));
        //DocGenerator.Generate(new[] { "WIC" }, Path.Combine(repoRoot, "Generated", "Graphics", "Imaging.xml"));

        //DocGenerator.Generate(new[] { "D3D9" }, Path.Combine(d3d9Path, "Direct3D9.xml"));
        //DocGenerator.Generate(new[] { "D3D11" }, Path.Combine(d3d11Path, "Direct3D11.xml"));
        //DocGenerator.Generate(new[] { "D3D12" }, Path.Combine(d3d12Path, "Direct3D12.xml"));
        //DocGenerator.Generate(new[] { "DComposition" }, Path.Combine(directCompositionPath, "DirectComposition.xml"));
        //DocGenerator.Generate(rootPath, new[] { "XAudio2", "XAUDIO2", "Hrtf", "XAPO", "X3DAUDIO" }, Path.Combine(XAudio2Path, "XAudio2.xml"));

        foreach (string jsonFile in s_jsons)
        {
            string finalPath = Path.Combine(AppContext.BaseDirectory, "win32json", "api", jsonFile);
            string jsonData = File.ReadAllText(finalPath);
            ApiData? api = JsonConvert.DeserializeObject<ApiData>(jsonData);

            string outputPath = repoRoot;
            bool useSubFolders = true;
            bool cleanFolder = true;

            if (jsonFile == "Graphics.Dxgi.json")
            {
                outputPath = dxgiPath;
                useSubFolders = false;
            }
            else if (jsonFile.EndsWith("Direct3D11.json"))
            {
                outputPath = d3d11Path;
                useSubFolders = false;
            }
            else if (jsonFile.EndsWith("Direct3D12.json"))
            {
                outputPath = d3d12Path;
                useSubFolders = false;
            }
            else if (jsonFile.EndsWith("Direct3D11on12.json"))
            {
                outputPath = d3d11on12Path;
                useSubFolders = false;
            }
            else if (jsonFile == "Graphics.Imaging.json")
            {
                outputPath = wicPath;
                useSubFolders = false;
            }
            else if (jsonFile == "Graphics.Direct2D.json")
            {
                outputPath = d2dPath;
                useSubFolders = false;
            }
            else if (jsonFile == "Graphics.Imaging.D2D.json")
            {
                outputPath = d2dPath;
                useSubFolders = false;
                cleanFolder = false;
            }
            else if (jsonFile == "Graphics.DirectWrite.json")
            {
                outputPath = dwritePath;
                useSubFolders = false;
            }
            else if (jsonFile == "Graphics.Direct3D.Dxc.json")
            {
                outputPath = dxcPath;
                useSubFolders = false;
            }
            else if (jsonFile == "Graphics.Direct3D.Fxc.json")
            {
                outputPath = fxcPath;
                useSubFolders = false;
            }
            else if (jsonFile == "Graphics.DirectComposition.json")
            {
                outputPath = directCompositionPath;
                useSubFolders = false;
            }
            else if (jsonFile == "Graphics.Direct3D9.json")
            {
                outputPath = d3d9Path;
                useSubFolders = false;
            }
            else if (jsonFile == "Media.Audio.XAudio2.json")
            {
                outputPath = XAudio2Path;
                useSubFolders = false;
            }

            outputPath = Path.Combine(outputPath, "Generated");

            if (!Directory.Exists(outputPath))
            {
                Directory.CreateDirectory(outputPath);
            }

            Generate(api!, outputPath, jsonFile, useSubFolders, cleanFolder);
        }

        return 0;
    }

    private static void Generate(ApiData api, string outputPath, string jsonFile, bool useSubFolders, bool cleanFolder)
    {
        string[] splits = jsonFile.Split(".", StringSplitOptions.RemoveEmptyEntries);
        string folderRoot = splits[0];
        string outputFolder = Path.Combine(outputPath, folderRoot);

        string docFile = splits[1];
        string subFolderName = string.Empty;
        for (int i = 1; i < splits.Length - 1; i++)
        {
            if (string.IsNullOrEmpty(subFolderName) == false)
            {
                subFolderName += ".";
            }

            subFolderName += splits[i];
        }

        string fileName = subFolderName;
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

        if (docFile == "json" || jsonFile == "Graphics.Direct3D.Dxc.json")
        {
            docFile = string.Empty;
        }

        if (jsonFile == "Graphics.Dxgi.Common.json")
        {
            docFile = $"../../../Vortice.Win32.Graphics.Dxgi/Dxgi";
        }
        else if (jsonFile == "Graphics.Direct2D.Common.json")
        {
            docFile = $"../../../Vortice.Win32.Graphics.Direct2D/Direct2D";
        }
        else if (jsonFile == "Graphics.Imaging.D2D.json")
        {
            docFile = $"../Vortice.Win32.Graphics.Imaging/Imaging";
        }
        else if (jsonFile == "Graphics.Direct3D11on12.json")
        {
            docFile = $"../Vortice.Win32.Graphics.Direct3D11/Direct3D11";
        }
        else if (jsonFile == "Graphics.Direct3D.Fxc.json")
        {
            docFile = $"../Vortice.Win32/Generated/Graphics/Direct3D";
        }
        else if (jsonFile == "Media.Audio.XAudio2.json")
        {
            docFile = "XAudio2";
        }

        string apiName = ns;
        string apiFolder;
        if (useSubFolders)
        {
            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);
            }

            apiFolder = Path.Combine(outputFolder, subFolderName);
        }
        else
        {
            apiFolder = outputPath;
        }

        if (cleanFolder)
        {
            if (Directory.Exists(apiFolder))
            {
                Directory.Delete(apiFolder, true);
            }
        }

        if (!Directory.Exists(apiFolder))
        {
            Directory.CreateDirectory(apiFolder);
        }

        if (string.IsNullOrWhiteSpace(docFile) == false)
        {
            docFile = $"../{docFile}";
        }

        GenerateTypes(apiFolder, apiName, docFile, api);
        GenerateConstants(apiFolder, apiName, docFile, api);
        GenerateFunctions(apiFolder, apiName, docFile, api);
    }

    private static void GenerateConstants(string folder, string apiName, string docFileName, ApiData api)
    {
        bool generateFile = false;

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

            generateFile = true;
            break;
        }

        if (!generateFile)
            return;

        string[] usingNamespaces = apiName == "Graphics.Imaging" ? ["Win32.Graphics.Direct2D.Common"] : [];
        using CodeWriter writer = new(
            Path.Combine(folder, $"{apiName}.Apis.cs"),
            apiName,
            docFileName,
            $"Win32.{apiName}",
            usingNamespaces);

        bool needNewLine = false;
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

                if (needNewLine)
                {
                    writer.WriteLine();
                }

                string typeName = GetTypeName(constant.Type);
                if (typeName == "Guid")
                {
                    WriteGuid(writer, constant.Value!.ToString(), constant.Name);
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
                else if (typeName == "String")
                {
                    string strValue = constant.Value.ToString();
                    strValue = strValue.Replace(@"\", @"\\");
                    writer.WriteLine($"public const string {constant.Name} = \"{strValue}\";");
                }
                else
                {
                    writer.WriteLine($"public const {typeName} {constant.Name} = {constant.Value};");
                }

                needNewLine = true;
            }

            if (s_enumConstants.Count > 0)
            {
                writer.WriteLine();

                foreach (string enumConstant in s_enumConstants)
                {
                    writer.WriteLine($"public const {enumConstant};");
                }

                s_enumConstants.Clear();
            }
        }
        writer.WriteLine();
    }

    private static void GenerateTypes(string folder, string apiName, string docFileName, ApiData api)
    {
        using CodeWriter writer = new(
            Path.Combine(folder, $"{apiName}.Enums.cs"),
            apiName,
            docFileName,
            $"Win32.{apiName}");

        bool needNewLine = false;
        foreach (ApiType enumType in api.Types.Where(item => item.Kind.Equals("enum", StringComparison.InvariantCultureIgnoreCase)))
        {
            if (enumType.Name.StartsWith("D3DX11"))
            {
                continue;
            }

            if (needNewLine)
            {
                writer.WriteLine();
            }

            GenerateEnum(writer, enumType, false);
            s_visitedEnums.Add($"{apiName}.{enumType.Name}");
            needNewLine = true;
        }

        // Generated enums -> from constants

        Dictionary<string, ApiType> createdEnums = [];
        needNewLine = false;

        foreach (ApiDataConstant constant in api.Constants)
        {
            if (ShouldSkipConstant(constant))
            {
                continue;
            }

            foreach (KeyValuePair<string, bool> enumToGenerate in s_generatedEnums)
            {
                if (constant.Name.StartsWith(enumToGenerate.Key))
                {
                    ApiType createdEnumType;
                    if (!createdEnums.TryGetValue(enumToGenerate.Key, out ApiType? apiType))
                    {
                        apiType = new()
                        {
                            Name = enumToGenerate.Key,
                            Kind = "Enum",
                            Flags = enumToGenerate.Value,
                            Scoped = false,
                            IntegerBase = enumToGenerate.Key == "D3DCOMPILE" ? "UInt32" : constant.Type.Name
                        };

                        createdEnums.Add(enumToGenerate.Key, apiType);
                        createdEnumType = apiType;
                    }
                    else
                    {
                        createdEnumType = apiType;
                    }

                    ApiEnumValue enumValue = new ApiEnumValue
                    {
                        Name = constant.Name,
                        Value = constant.Value
                    };
                    createdEnumType.Values.Add(enumValue);
                }
            }
        }

        foreach (ApiType enumType in createdEnums.Values)
        {
            if (needNewLine)
            {
                writer.WriteLine();
            }

            GenerateEnum(writer, enumType, true);
            needNewLine = true;
        }

        using var structWriter = new CodeWriter(
            Path.Combine(folder, $"{apiName}.Structs.cs"),
            apiName,
            docFileName,
            $"Win32.{apiName}");
        needNewLine = true;

        // Unions
        foreach (ApiType structType in api.Types.Where(item => item.Kind.ToLowerInvariant() == "union"))
        {
            if (structType.Name.StartsWith("D3DX11") ||
                structType.Name.StartsWith("CD3D11"))
            {
                continue;
            }

            if (s_csNameMappings.ContainsKey($"{apiName}.{structType.Name}"))
            {
                continue;
            }

            if (needNewLine)
            {
                structWriter.WriteLine();
            }

            string structCsTypeName = GetCsStructTypeName(structType, apiName);
            GenerateStruct(structWriter, api, structType);
            s_visitedStructs.Add($"{apiName}.{structType.Name}");
            needNewLine = true;
        }

        // Structs
        needNewLine = false;
        foreach (ApiType structType in api.Types.Where(item => item.Kind.ToLowerInvariant() == "struct"))
        {
            if (structType.Name.StartsWith("D3DX11") ||
                structType.Name.StartsWith("CD3D11") ||
                structType.Name == "D2D_COLOR_F")
            {
                continue;
            }

            if (s_csNameMappings.ContainsKey($"{apiName}.{structType.Name}"))
            {
                continue;
            }

            if (needNewLine)
            {
                structWriter.WriteLine();
            }

            string structCsTypeName = GetCsStructTypeName(structType, apiName);
            GenerateStruct(structWriter, api, structType);
            s_visitedStructs.Add($"{apiName}.{structType.Name}");
            needNewLine = true;
        }

        // Com types
        foreach (ApiType comType in api.Types.Where(item => item.Kind.ToLowerInvariant() == "com"))
        {
            if (comType.Name.StartsWith("ID3DX11"))
            {
                continue;
            }

            // Generate methods
            // TODO: FIX broken VTable ID3D12Heap, ID2D1Factory2
            if (comType.Name == "ID3D12Pageable")
            {

            }

            Dictionary<string, List<ApiType>> methodsToGenerate = new();

            // We must generate from lower to upper
            ApiType iterateType = comType;
            List<ApiType> typesToGenerate = new();
            while (iterateType.Interface != null
                && iterateType.Interface.Name != "IUnknown"
                && iterateType.Interface.Name != "IStream"
                && iterateType.Interface.Name != "IPersistStream")
            {
                string fullTypeName = $"{iterateType.Interface.Api}.{iterateType.Interface.Name}";
                iterateType = api.Types.FirstOrDefault(item => item.Name == iterateType.Interface.Name);

                if (iterateType != null)
                {
                    typesToGenerate.Add(iterateType);
                }
                else
                {
                    var knownMethods = s_visitedComTypes.First(item => item.Key == fullTypeName).Value;

                    foreach (var knownMethod in knownMethods)
                    {
                        methodsToGenerate.Add(knownMethod.Key, knownMethod.Value);
                    }

                    break;
                }
            }

            if (typesToGenerate.Count > 1)
            {
                typesToGenerate.Reverse();
            }

            foreach (ApiType type in typesToGenerate)
            {
                foreach (ApiType method in type.Methods)
                {
                    // Until we add Storage.Xps.Printing.IPrintDocumentPackageTarget
                    if (method.Name == "CreatePrintControl")
                        continue;

                    if (methodsToGenerate.TryGetValue(type.Name, out List<ApiType>? functions) == false)
                    {
                        functions = new List<ApiType>();
                        methodsToGenerate.Add(type.Name, functions);
                    }

                    functions.Add(method);
                }
            }

            foreach (ApiType method in comType.Methods)
            {
                // Until we add Storage.Xps.Printing.IPrintDocumentPackageTarget
                if (method.Name == "CreatePrintControl")
                    continue;

                if (methodsToGenerate.TryGetValue(comType.Name, out List<ApiType>? functions) == false)
                {
                    functions = new List<ApiType>();
                    methodsToGenerate.Add(comType.Name, functions);
                }

                functions.Add(method);
            }

            GenerateComType(folder, apiName, docFileName, api, comType, methodsToGenerate);
        }
    }

    private static string GetCsStructTypeName(ApiType structType, string apiName)
    {
        if (structType.Name.StartsWith("Dxc") ||
            structType.Name.StartsWith("WIC"))
        {
            return structType.Name;
        }
        else
        {
            string csTypeName = GetDataTypeName(structType.Name, out _);
            AddCsMapping(apiName, structType.Name, csTypeName);
            return csTypeName;
        }
    }

    private static void GenerateFunctions(string folder, string apiName, string docFileName, ApiData api)
    {
        if (api.Functions.Length == 0)
            return;

        using CodeWriter writer = new(
            Path.Combine(folder, $"{apiName}.Apis.Functions.cs"),
            apiName,
            docFileName,
            $"Win32.{apiName}");

        using (writer.PushBlock($"public static unsafe partial class Apis"))
        {
            bool needNewLine = false;
            foreach (ApiType function in api.Functions)
            {
                if (function.Name.StartsWith("D3DX11") ||
                    function.Name == "D3DDisassemble11Trace" ||
                    function.Name == "D3DDisassemble10Effect" ||
                    function.Name == "D3DCreateLinker" ||
                    function.Name == "D3DLoadModule" ||
                    function.Name == "D3DCreateFunctionLinkingGraph")
                {
                    continue;
                }

                if (needNewLine)
                {
                    writer.WriteLine();
                }

                WriteFunction(writer, api, function, string.Empty, false, false, true);
                needNewLine = true;
            }
        }
    }

    private static string WriteFunction(
        CodeWriter writer,
        ApiData api,
        ApiType function,
        string functionName,
        bool asCallback,
        bool asParameter = false,
        bool skipUnsafe = false)
    {
        string returnType = GetTypeName(function.ReturnType);
        string functionSuffix = string.Empty;
        StringBuilder functionSignature = new();

        if (string.IsNullOrEmpty(functionName))
        {
            functionName = function.Name;
        }

        if (string.IsNullOrEmpty(writer.DocFileName) == false && !asParameter && !asCallback)
        {
            writer.WriteLine($"/// <include file='{writer.DocFileName}.xml' path='doc/member[@name=\"{functionName}\"]/*' />");
        }

        if (string.IsNullOrEmpty(function.DllImport) == false)
        {
            functionSuffix = "static partial ";
            string dllImport = function.DllImport;
            if (dllImport == "XAudio2_8.dll")
            {
                dllImport = "xaudio2_9";
            }

            writer.WriteLine($"[LibraryImport(\"{dllImport}\")]");
        }

        StringBuilder argumentBuilder = new();
        StringBuilder argumentsTypesBuilder = new();
        StringBuilder argumentsNameBuilder = new();
        int parameterIndex = 0;
        foreach (ApiParameter parameter in function.Params)
        {
            GetParameterSignature(api, writer, parameter,
                function.Name,
                out string parameterType,
                out string parameterName);

            argumentBuilder.Append(parameterType);

            if (asCallback == false)
            {
                argumentBuilder.Append(' ').Append(parameterName);
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


        if (!asParameter)
        {
            writer.Write("public ");
            functionSignature.Append("public ");
        }

        string signature = string.Empty;
        if (!skipUnsafe)
        {
            if (!asParameter || asCallback)
            {
                signature = "unsafe ";
            }
        }

        if (asCallback)
        {
            signature += $"delegate* unmanaged[Stdcall]<{argumentsString}, {returnType}>";

            if (!asParameter)
            {
                signature += $" {functionName}";
            }
        }
        else
        {
            signature += $"{functionSuffix}{returnType} {functionName}({argumentsString})";
        }

        functionSignature.Append(signature);
        if (!asParameter)
        {
            writer.Write(signature);
            writer.WriteLine(";");
        }

        return functionSignature.ToString();
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
        else if (enumType.Name.StartsWith("D3D")
            && !enumType.Name.StartsWith("D3D_")
            && !enumType.Name.StartsWith("D3D11_")
            && !enumType.Name.StartsWith("D3D12_")
            && !enumType.Name.StartsWith("D3DCOMPILER_")
            && !enumType.Name.StartsWith("D3DCOMPILE")
            && !enumType.Name.StartsWith("XAUDIO2_"))
        {
            csTypeName = enumType.Name.Substring(3);
            skipPrettify = true;

            if (s_knownTypesPrefixes.TryGetValue(enumType.Name, out string? knowPrefix))
            {
                enumPrefix = knowPrefix!;
            }
            else
            {
                enumPrefix = "D3D";
            }
        }
        else
        {
            csTypeName = GetDataTypeName(enumType.Name, out enumPrefix);
            AddCsMapping(writer.Api, enumType.Name, csTypeName);
        }

        string baseTypeName = GetTypeName(enumType.IntegerBase);

        if (!autoGenerated && string.IsNullOrEmpty(writer.DocFileName) == false)
        {
            writer.WriteLine($"/// <include file='{writer.DocFileName}.xml' path='doc/member[@name=\"{enumType.Name}\"]/*' />");
        }

        if (s_generateUnmanagedDocs)
        {
            writer.WriteLine($"/// <unmanaged>{enumType.Name}</unmanaged>");
        }

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

        string baseTypeDeclaration = $" : {baseTypeName}";
        if (enumType.Name == "DXGI_FORMAT")
        {
            baseTypeDeclaration = $" : uint";
        }
        else if (baseTypeName == "int")
        {
            baseTypeDeclaration = string.Empty;
        }

        using (writer.PushBlock($"public enum {csTypeName}{baseTypeDeclaration}"))
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

                if (autoGenerated &&
                    enumType.Name == "D3DCOMPILE" &&
                    (enumItem.Name.StartsWith("D3DCOMPILE_EFFECT_") ||
                    enumItem.Name.StartsWith("D3DCOMPILE_FLAGS2_") ||
                    enumItem.Name.StartsWith("D3DCOMPILE_SECDATA_") ||
                    enumItem.Name.StartsWith("D3DCOMPILER_DLL_")))
                {
                    continue;
                }

                string enumValueName = GetEnumItemName(enumType, enumItem, enumPrefix, skipPrettify);

                if (!autoGenerated && string.IsNullOrEmpty(writer.DocFileName) == false)
                {
                    writer.WriteLine($"/// <include file='{writer.DocFileName}.xml' path='doc/member[@name=\"{enumType.Name}::{enumItem.Name}\"]/*' />");
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

                // We need to manually add D3DCOMPILE_OPTIMIZATION_LEVEL2
                if (autoGenerated &&
                    enumType.Name == "D3DCOMPILE" &&
                    enumValueName == "OptimizationLevel1")
                {
                    writer.WriteLine("/// <unmanaged>D3DCOMPILE_OPTIMIZATION_LEVEL2</unmanaged>");
                    writer.WriteLine($"OptimizationLevel2 = 49152,");
                }

                s_enumConstants.Add($"{csTypeName} {enumItem.Name} = {csTypeName}.{enumValueName}");

                if (autoGenerated &&
                    enumType.Name == "D3DCOMPILE" &&
                    enumValueName == "OptimizationLevel1")
                {
                    s_enumConstants.Add($"{csTypeName} D3DCOMPILE_OPTIMIZATION_LEVEL2 = {csTypeName}.OptimizationLevel2");
                }
            }

            if (enumType.Name == "DXGI_FORMAT")
            {
                // Add Xbox enums
                writer.WriteLine("/// <unmanaged>DXGI_FORMAT_R10G10B10_7E3_A2_FLOAT</unmanaged>");
                writer.WriteLine($"Xbox_R10G10B10_7E3_A2Float = 116u,");
                s_enumConstants.Add($"{csTypeName} DXGI_FORMAT_R10G10B10_7E3_A2_FLOAT = {csTypeName}.Xbox_R10G10B10_7E3_A2Float");

                writer.WriteLine("/// <unmanaged>DXGI_FORMAT_R10G10B10_6E4_A2_FLOAT</unmanaged>");
                writer.WriteLine($"Xbox_R10G10B10_6E4_A2Float = 117u,");
                s_enumConstants.Add($"{csTypeName} DXGI_FORMAT_R10G10B10_6E4_A2_FLOAT = {csTypeName}.Xbox_R10G10B10_6E4_A2Float");

                writer.WriteLine("/// <unmanaged>DXGI_FORMAT_D16_UNORM_S8_UINT</unmanaged>");
                writer.WriteLine($"Xbox_D16Unorm_S8Uint = 118u,");
                s_enumConstants.Add($"{csTypeName} DXGI_FORMAT_D16_UNORM_S8_UINT = {csTypeName}.Xbox_D16Unorm_S8Uint");

                writer.WriteLine("/// <unmanaged>DXGI_FORMAT_R16_UNORM_X8_TYPELESS</unmanaged>");
                writer.WriteLine($"Xbox_R16Unorm_X8Typeless = 119u,");
                s_enumConstants.Add($"{csTypeName} DXGI_FORMAT_R16_UNORM_X8_TYPELESS = {csTypeName}.Xbox_R16Unorm_X8Typeless");

                writer.WriteLine("/// <unmanaged>DXGI_FORMAT_X16_TYPELESS_G8_UINT</unmanaged>");
                writer.WriteLine($"Xbox_X16Typeless_G8Uint = 120u,");
                s_enumConstants.Add($"{csTypeName} DXGI_FORMAT_X16_TYPELESS_G8_UINT = {csTypeName}.Xbox_X16Typeless_G8Uint");

                writer.WriteLine("/// <unmanaged>DXGI_FORMAT_R10G10B10_SNORM_A2_UNORM</unmanaged>");
                writer.WriteLine($"Xbox_R10G10B10Snorm_A2Unorm = 189u,");
                s_enumConstants.Add($"{csTypeName} DXGI_FORMAT_R10G10B10_SNORM_A2_UNORM = {csTypeName}.Xbox_R10G10B10Snorm_A2Unorm");

                writer.WriteLine("/// <unmanaged>DXGI_FORMAT_R4G4_UNORM</unmanaged>");
                writer.WriteLine($"Xbox_R4G4Unorm = 190u,");
                s_enumConstants.Add($"{csTypeName} DXGI_FORMAT_R4G4_UNORM = {csTypeName}.Xbox_R4G4Unorm");
            }
        }
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

    private static void GenerateStruct(CodeWriter writer, ApiData api, ApiType structType, bool nestedType = false)
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
            else if (structType.Name.StartsWith("DComposition"))
            {
                csTypeName = structType.Name.Substring("DComposition".Length);
                AddCsMapping(writer.Api, structType.Name, csTypeName);
            }
            else
            {
                csTypeName = GetDataTypeName(structType.Name, out structPrefix);
                AddCsMapping(writer.Api, structType.Name, csTypeName);
            }
        }

        if (!nestedType)
        {
            if (string.IsNullOrEmpty(writer.DocFileName) == false)
            {
                writer.WriteLine($"/// <include file='{writer.DocFileName}.xml' path='doc/member[@name=\"{structType.Name}\"]/*' />");
            }

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

                if (structType.Name == "D3D11_OMAC" || structType.Name == "D3D_OMAC")
                {
                    fieldValueName = "Buffer";
                }
                else if (structType.Name == "D3D12_NODE_MASK")
                {
                    fieldValueName = "Mask";
                }
                else if (s_structFieldNameRemap.TryGetValue($"{structType.Name}::{field.Name}", out string? remapFieldName))
                {
                    fieldValueName = remapFieldName;
                }

                string fieldTypeName = GetTypeNameWithPointerCheck(api, field.Type);
                if (string.IsNullOrEmpty(writer.DocFileName) == false)
                {
                    writer.WriteLine($"/// <include file='{writer.DocFileName}.xml' path='doc/member[@name=\"{structType.Name}::{field.Name}\"]/*' />");
                }

                string remapFieldLookUp = $"{structType.Name}::{field.Name}";
                if (s_structFieldTypeRemap.TryGetValue(remapFieldLookUp, out string? remapType))
                {
                    if (remapType.Contains('.'))
                    {
                        fieldTypeName = GetTypeName($"{remapType}");
                    }
                    else
                    {
                        fieldTypeName = GetTypeName($"{writer.Api}.{remapType}");
                    }
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
                        WriteFunction(writer, api, functionType, field.Name, true, false, false);
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
                                        writer.WriteLine($"return ref {parentMemberAccess.Name}.{fieldName};");
                                    }
                                }
                            }

                            writer.WriteLine();
                        }
                    }
                }

                foreach (ApiType nestedTypeToGenerate in structType.NestedTypes)
                {
                    GenerateStruct(writer, api, nestedTypeToGenerate, true);
                }
            }
        }
    }

    private static void GenerateComType(
        string folder, string apiName, string docFileName,
        ApiData api,
        ApiType comType,
        Dictionary<string, List<ApiType>> methodsToGenerate)
    {
        string csTypeName = comType.Name;
        List<string> namespaces = [];

        if (comType.Name == "ID2D1GeometrySink")
        {
            namespaces.Add("Win32.Graphics.Direct2D.Common");
        }

        using CodeWriter writer = new(
            Path.Combine(folder, $"{csTypeName}.cs"),
            apiName,
            docFileName,
            $"Win32.{apiName}",
            namespaces.ToArray()
            );

        if (string.IsNullOrEmpty(writer.DocFileName) == false)
        {
            writer.WriteLine($"/// <include file='{writer.DocFileName}.xml' path='doc/member[@name=\"{comType.Name}\"]/*' />");
        }

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

        string baseType = string.Empty;
        if (comType.Guid != null)
        {
            baseType += ", INativeGuid";
        }

        using (writer.PushBlock($"public unsafe partial struct {csTypeName} : {csTypeName}.Interface{baseType}"))
        {
            if (comType.Guid != null)
            {
                // Generate IID
                WriteGuid(writer, comType.Guid, $"IID_{csTypeName}");
                writer.WriteLine();

                writer.WriteLine($"static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_{csTypeName}));");
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

            if (!generateIUnknown)
            {
                if (csTypeName == "ID2D1GeometrySink" ||
                    csTypeName == "IWICStream" ||
                    csTypeName == "IWICPersistStream" ||
                    csTypeName == "IWICImagingFactory2")
                {
                    generateIUnknown = true;
                }
            }

            if (generateIUnknown)
            {
                writer.WriteLine("/// <inheritdoc cref=\"IUnknown.QueryInterface\" />");
                writer.WriteLine("[MethodImpl(MethodImplOptions.AggressiveInlining)]");
                writer.WriteLine("[VtblIndex(0)]");
                using (writer.PushBlock($"public HResult QueryInterface([NativeTypeName(\"const IID &\")] Guid* riid, void** ppvObject)"))
                {
                    writer.WriteLine($"return ((delegate* unmanaged[MemberFunction]<{comType.Name}*, Guid*, void**, int>)(lpVtbl[0]))(({comType.Name}*)Unsafe.AsPointer(ref this), riid, ppvObject);");
                }
                writer.WriteLine();

                // AddRef
                writer.WriteLine("/// <inheritdoc cref=\"IUnknown.AddRef\" />");
                writer.WriteLine("[MethodImpl(MethodImplOptions.AggressiveInlining)]");
                writer.WriteLine("[VtblIndex(1)]");
                writer.WriteLine("[return: NativeTypeName(\"ULONG\")]");
                using (writer.PushBlock($"public uint AddRef()"))
                {
                    writer.WriteLine($"return ((delegate* unmanaged[MemberFunction]<{comType.Name}*, uint>)(lpVtbl[1]))(({comType.Name}*)Unsafe.AsPointer(ref this));");
                }
                writer.WriteLine();

                // Release
                writer.WriteLine("/// <inheritdoc cref=\"IUnknown.Release\" />");
                writer.WriteLine("[MethodImpl(MethodImplOptions.AggressiveInlining)]");
                writer.WriteLine("[VtblIndex(2)]");
                writer.WriteLine("[return: NativeTypeName(\"ULONG\")]");
                using (writer.PushBlock($"public uint Release()"))
                {
                    writer.WriteLine($"return ((delegate* unmanaged[MemberFunction]<{comType.Name}*, uint>)(lpVtbl[2]))(({comType.Name}*)Unsafe.AsPointer(ref this));");
                }
                writer.WriteLine();
                vtblIndex = 3;
            }

            // Offset some hacks
            if (csTypeName == "IWICStream")
                vtblIndex = 14;
            if (csTypeName == "IWICPersistStream")
                vtblIndex = 8;

            bool needNewLine = false;
            List<Tuple<int, string>> interfaceMethods = [];
            foreach (KeyValuePair<string, List<ApiType>> methodPair in methodsToGenerate)
            {
                string docName = methodPair.Key;

                foreach (ApiType method in methodPair.Value)
                {
                    if (needNewLine)
                    {
                        writer.WriteLine();
                    }

                    // TODO: Handle inherit
                    string returnType = GetTypeNameWithPointerCheck(api, method.ReturnType);

                    StringBuilder argumentBuilder = new();
                    StringBuilder argumentsTypesBuilder = new();
                    StringBuilder argumentsNameBuilder = new();
                    int parameterIndex = 0;

                    bool useReturnAsParameter = false;
                    if (returnType != "void" &&
                        method.ReturnType.TargetKind != "Com" &&
                        method.ReturnType.Kind == "ApiRef" &&
                        !IsEnum(method.ReturnType) &&
                        IsStructAsReturnMarshal(method.ReturnType)
                        )
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
                        GetParameterSignature(api, writer, parameter,
                            $"{comType.Name}::{method.Name}",
                            out string parameterType,
                            out string parameterName);

                        if (method.Name == "CheckFeatureSupport" &&
                            parameterName == "FeatureSupportDataSize")
                        {
                            parameterType = "int";
                        }

                        argumentBuilder
                            .Append(parameterType)
                            .Append(' ')
                            .Append(parameterName);

                        if (method.Name == "EndDraw")
                        {
                            argumentBuilder.Append(" = null");
                        }
                        else if (method.Name.EndsWith("SetShader") && comType.Name.StartsWith("ID3D11DeviceContext"))
                        {
                            if (parameterName.EndsWith("Shader"))
                            {
                                argumentBuilder.Append(" = null");
                            }
                            else if (parameterName == "ppClassInstances")
                            {
                                argumentBuilder.Append(" = null");
                            }
                            else if (parameterName == "NumClassInstances")
                            {
                                argumentBuilder.Append(" = 0");
                            }
                        }
                        else if (method.Name == "OMSetBlendState" && comType.Name.StartsWith("ID3D11DeviceContext"))
                        {
                            if (parameterName == "pBlendState")
                            {
                                argumentBuilder.Append(" = default");
                            }
                            else if (parameterName == "BlendFactor")
                            {
                                argumentBuilder.Append(" = null");
                            }
                            else if (parameterName == "SampleMask")
                            {
                                argumentBuilder.Append(" = 0xffffffff");
                            }
                        }

                        if (parameterName == "pReserved")
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

                    bool needToAddInterfaceMethod = true;
                    if (comType.Name == docName)
                    {
                        if (string.IsNullOrEmpty(writer.DocFileName) == false)
                        {
                            writer.WriteLine($"/// <include file='{writer.DocFileName}.xml' path='doc/member[@name=\"{comType.Name}::{method.Name}\"]/*' />");
                        }
                    }
                    else
                    {
                        if (docName == "ID2D1SimplifiedGeometrySink")
                        {
                            docName = "Win32.Graphics.Direct2D.Common.ID2D1SimplifiedGeometrySink";
                        }

                        writer.WriteLine($"/// <inheritdoc cref=\"{docName}.{method.Name}\" />");
                        needToAddInterfaceMethod = false;
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
                        bool writeReturn = false;
                        if (returnType != "void")
                        {
                            if (useReturnAsParameter)
                            {
                                writer.WriteLine($"{returnType} result;");
                                writer.Write("return ");
                                writer.WriteLine($"*((delegate* unmanaged[MemberFunction]<{comType.Name}*, {argumentTypesString}>)(lpVtbl[{vtblIndex}]))(({comType.Name}*)Unsafe.AsPointer(ref this), &result{argumentNamesString});");
                            }
                            else
                            {
                                writeReturn = true;
                            }
                        }

                        if (!useReturnAsParameter)
                        {
                            if (writeReturn)
                                writer.Write("return ");
                            writer.WriteLine($"((delegate* unmanaged[MemberFunction]<{comType.Name}*, {argumentTypesString}>)(lpVtbl[{vtblIndex}]))(({comType.Name}*)Unsafe.AsPointer(ref this){argumentNamesString});");
                        }
                    }

                    if (needToAddInterfaceMethod)
                    {
                        string interfaceMethodDecl = $"{returnType} {method.Name}({argumentsString})";
                        interfaceMethods.Add(Tuple.Create(vtblIndex, interfaceMethodDecl));
                    }

                    needNewLine = true;
                    vtblIndex++;
                }
            }

            // Generate interface
            string baseInterfaceDecl = string.Empty;
            if (comType.Interface != null)
            {
                string baseInterfacePrefix = string.Empty;
                if (comType.Interface.Name == "IStream" ||
                    comType.Interface.Name == "IPersistStream")
                {
                    baseInterfacePrefix = "Win32.Com.";
                }
                baseInterfaceDecl += $": {baseInterfacePrefix}{comType.Interface.Name}.Interface";
            }

            writer.WriteLine();
            needNewLine = false;
            using (writer.PushBlock($"public interface Interface {baseInterfaceDecl}"))
            {
                foreach (var item in interfaceMethods)
                {
                    if (needNewLine)
                    {
                        writer.WriteLine();
                    }

                    writer.WriteLine($"[VtblIndex({item.Item1})]");
                    writer.WriteLine($"{item.Item2};");
                    needNewLine = true;
                }
            }
        }

        writer.WriteLine();
        s_visitedComTypes.Add($"{writer.Api}.{comType.Name}", methodsToGenerate);
    }

    private static void GetParameterSignature(
        ApiData api,
        CodeWriter writer,
        ApiParameter parameter,
        string memberLookup,
        out string parameterType,
        out string parameterName)
    {
        bool asPointer = false;
        parameterType = string.Empty;

        if (parameter.Type.Kind == "ApiRef")
        {
            if (parameter.Type.TargetKind == "FunctionPointer")
            {
                ApiType functionType = api.Types.First(item => item.Name == parameter.Type.Name && item.Kind == "FunctionPointer");
                parameterType = WriteFunction(writer, api, functionType, parameter.Name, true, true, true);
            }
            else
            {
                string fullTypeName = $"{parameter.Type.Api}.{parameter.Type.Name}";
                if (!IsPrimitive(parameter.Type) && !IsStruct(fullTypeName) && !IsEnum(fullTypeName))
                {
                    asPointer = true;
                }
            }
        }

        if (string.IsNullOrEmpty(parameterType))
        {
            if (string.IsNullOrEmpty(memberLookup) == false)
            {
                string interfaceType = memberLookup.Split("::")[0];

                string parameterNameLookup = $"{memberLookup}::{parameter.Name}";
            retryLookup:
                if (s_mapFunctionParameters.TryGetValue(parameterNameLookup, out string? remapType))
                {
                    if (remapType.Contains('.'))
                    {
                        parameterType = GetTypeName($"{remapType}");
                    }
                    else
                    {
                        parameterType = GetTypeName($"{writer.Api}.{remapType}");
                    }

                    if (parameter.Attrs.Any(item => item is string str && str == "Out"))
                    {
                        parameterType += "*";
                    }
                }
                else
                {
                    var result = Regex.Match(interfaceType, @"\d+$", RegexOptions.RightToLeft);
                    if (result.Success)
                    {
                        string interfaceTypeNoNumber = interfaceType.Replace(result.Value, string.Empty);
                        memberLookup = memberLookup.Replace(interfaceType, interfaceTypeNoNumber);
                        parameterNameLookup = $"{memberLookup}::{parameter.Name}";
                        interfaceType = interfaceTypeNoNumber;
                        goto retryLookup;
                    }

                    parameterType = GetTypeName(parameter.Type, asPointer);
                }
            }
            else
            {
                parameterType = GetTypeName(parameter.Type, asPointer);
            }
        }

        parameterType = NormalizeTypeName(writer.Api, parameterType);

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

        parameterType = NormalizeTypeName(writer.Api, parameterType);
        parameterName = parameter.Name;
        parameterName = CleanupName(parameterName);
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
                else if (part == "FLAG2")
                {
                    sb.Append("Flags2");
                }
                else if (part == "FLAG3")
                {
                    sb.Append("Flags3");
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
                    else if (part.Equals("BIAS", StringComparison.OrdinalIgnoreCase))
                    {
                        sb.Append("Bias");
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

    private static string GetTypeNameWithPointerCheck(ApiData api, ApiDataType dataType)
    {
        bool asPointer = false;
        if (dataType.Kind == "ApiRef")
        {
            string lookupApiName = GetApiName(dataType);
            string fullTypeName = $"{lookupApiName}.{dataType.Name}";

            if (IsKnownComType(fullTypeName) ||
                s_visitedComTypes.ContainsKey(fullTypeName) ||
                api.Types.Any(item => item.Name == dataType.Name && item.Kind.ToLowerInvariant() == "com"))
            {
                asPointer = true;
            }
        }

        return GetTypeName(dataType, asPointer);
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
            case "char":
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
            case "Handle":
                return true;

            case "System.Drawing.Point":
            case "System.Drawing.PointF":
            case "System.Drawing.Size":
            case "System.Drawing.SizeF":
            case "System.Drawing.Rectangle":
            case "System.Drawing.RectangleF":
                return true;

            case "Vector2":
            case "Vector3":
            case "Vector4":
            case "Matrix3x2":
            case "Matrix4x4":
                return true;

            case "Matrix4x3":
            case "Matrix5x4":
            case "Viewport":
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

    private static bool IsStructAsReturnMarshal(ApiDataType dataType)
    {
        if (dataType.Kind != "ApiRef")
        {
            throw new InvalidOperationException();
        }

        string apiRefType = GetTypeName($"{dataType.Api}.{dataType.Name}");
        if (apiRefType.EndsWith("*"))
        {
            apiRefType = apiRefType.Substring(0, apiRefType.Length - 1);
        }

        switch (apiRefType)
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
                return false;

            case "nint":
            case "nuint":
            case "IntPtr":
            case "UIntPtr":
            case "Guid":
                return false;

            case "Bool32":
            case "HResult":
            case "Handle":
                return false;

            case "LargeInteger":
            case "ULargeInteger":
                return true;

            case "Luid":
                return true;

            default:
                return true;
        }
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
        switch (typeName)
        {
            case "Media.Audio.AUDIO_STREAM_CATEGORY":
                return true;

            default:
                return s_visitedEnums.Contains(typeName);
        }
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

    private static bool IsKnownComType(string typeName)
    {
        switch (typeName)
        {
            case "System.Com.IUnknown":
                return true;

            default:
                return false;
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

