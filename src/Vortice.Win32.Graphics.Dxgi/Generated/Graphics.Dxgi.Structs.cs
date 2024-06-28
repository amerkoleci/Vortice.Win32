// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Dxgi;

/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS"]/*' />
/// <unmanaged>DXGI_FRAME_STATISTICS</unmanaged>
public partial struct FrameStatistics
{
	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS::PresentCount"]/*' />
	public uint PresentCount;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS::PresentRefreshCount"]/*' />
	public uint PresentRefreshCount;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS::SyncRefreshCount"]/*' />
	public uint SyncRefreshCount;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS::SyncQPCTime"]/*' />
	public long SyncQPCTime;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS::SyncGPUTime"]/*' />
	public long SyncGPUTime;
}

/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_MAPPED_RECT"]/*' />
/// <unmanaged>DXGI_MAPPED_RECT</unmanaged>
public partial struct MappedRect
{
	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_MAPPED_RECT::Pitch"]/*' />
	public int Pitch;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_MAPPED_RECT::pBits"]/*' />
	public unsafe byte* pBits;
}

/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC"]/*' />
/// <unmanaged>DXGI_ADAPTER_DESC</unmanaged>
public partial struct AdapterDescription
{
	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC::Description"]/*' />
	public unsafe fixed char Description[128];

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC::VendorId"]/*' />
	public uint VendorId;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC::DeviceId"]/*' />
	public uint DeviceId;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC::SubSysId"]/*' />
	public uint SubSysId;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC::Revision"]/*' />
	public uint Revision;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC::DedicatedVideoMemory"]/*' />
	public nuint DedicatedVideoMemory;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC::DedicatedSystemMemory"]/*' />
	public nuint DedicatedSystemMemory;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC::SharedSystemMemory"]/*' />
	public nuint SharedSystemMemory;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC::AdapterLuid"]/*' />
	public Luid AdapterLuid;
}

/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTPUT_DESC"]/*' />
/// <unmanaged>DXGI_OUTPUT_DESC</unmanaged>
public partial struct OutputDescription
{
	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTPUT_DESC::DeviceName"]/*' />
	public unsafe fixed char DeviceName[32];

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTPUT_DESC::DesktopCoordinates"]/*' />
	public Rect DesktopCoordinates;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTPUT_DESC::AttachedToDesktop"]/*' />
	public Bool32 AttachedToDesktop;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTPUT_DESC::Rotation"]/*' />
	public Common.ModeRotation Rotation;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTPUT_DESC::Monitor"]/*' />
	public IntPtr Monitor;
}

/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_SHARED_RESOURCE"]/*' />
/// <unmanaged>DXGI_SHARED_RESOURCE</unmanaged>
public partial struct SharedResource
{
	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_SHARED_RESOURCE::Handle"]/*' />
	public Handle Handle;
}

/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_SURFACE_DESC"]/*' />
/// <unmanaged>DXGI_SURFACE_DESC</unmanaged>
public partial struct SurfaceDescription
{
	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_SURFACE_DESC::Width"]/*' />
	public uint Width;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_SURFACE_DESC::Height"]/*' />
	public uint Height;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_SURFACE_DESC::Format"]/*' />
	public Common.Format Format;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_SURFACE_DESC::SampleDesc"]/*' />
	public Common.SampleDescription SampleDesc;
}

/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC"]/*' />
/// <unmanaged>DXGI_SWAP_CHAIN_DESC</unmanaged>
public partial struct SwapChainDescription
{
	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC::BufferDesc"]/*' />
	public Common.ModeDescription BufferDesc;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC::SampleDesc"]/*' />
	public Common.SampleDescription SampleDesc;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC::BufferUsage"]/*' />
	public Usage BufferUsage;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC::BufferCount"]/*' />
	public uint BufferCount;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC::OutputWindow"]/*' />
	public nint OutputWindow;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC::Windowed"]/*' />
	public Bool32 Windowed;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC::SwapEffect"]/*' />
	public SwapEffect SwapEffect;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC::Flags"]/*' />
	public SwapChainFlags Flags;
}

/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1"]/*' />
/// <unmanaged>DXGI_ADAPTER_DESC1</unmanaged>
public partial struct AdapterDescription1
{
	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1::Description"]/*' />
	public unsafe fixed char Description[128];

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1::VendorId"]/*' />
	public uint VendorId;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1::DeviceId"]/*' />
	public uint DeviceId;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1::SubSysId"]/*' />
	public uint SubSysId;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1::Revision"]/*' />
	public uint Revision;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1::DedicatedVideoMemory"]/*' />
	public nuint DedicatedVideoMemory;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1::DedicatedSystemMemory"]/*' />
	public nuint DedicatedSystemMemory;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1::SharedSystemMemory"]/*' />
	public nuint SharedSystemMemory;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1::AdapterLuid"]/*' />
	public Luid AdapterLuid;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1::Flags"]/*' />
	public AdapterFlags Flags;
}

/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_DISPLAY_COLOR_SPACE"]/*' />
/// <unmanaged>DXGI_DISPLAY_COLOR_SPACE</unmanaged>
public partial struct DisplayColorSpace
{
	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_DISPLAY_COLOR_SPACE::PrimaryCoordinates"]/*' />
	public unsafe fixed float PrimaryCoordinates[16];

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_DISPLAY_COLOR_SPACE::WhitePoints"]/*' />
	public unsafe fixed float WhitePoints[32];
}

/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTDUPL_MOVE_RECT"]/*' />
/// <unmanaged>DXGI_OUTDUPL_MOVE_RECT</unmanaged>
public partial struct OutduplMoveRect
{
	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTDUPL_MOVE_RECT::SourcePoint"]/*' />
	public System.Drawing.Point SourcePoint;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTDUPL_MOVE_RECT::DestinationRect"]/*' />
	public Rect DestinationRect;
}

/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTDUPL_DESC"]/*' />
/// <unmanaged>DXGI_OUTDUPL_DESC</unmanaged>
public partial struct OutduplDescription
{
	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTDUPL_DESC::ModeDesc"]/*' />
	public Common.ModeDescription ModeDesc;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTDUPL_DESC::Rotation"]/*' />
	public Common.ModeRotation Rotation;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTDUPL_DESC::DesktopImageInSystemMemory"]/*' />
	public Bool32 DesktopImageInSystemMemory;
}

/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTDUPL_POINTER_POSITION"]/*' />
/// <unmanaged>DXGI_OUTDUPL_POINTER_POSITION</unmanaged>
public partial struct OutduplPointerPosition
{
	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTDUPL_POINTER_POSITION::Position"]/*' />
	public System.Drawing.Point Position;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTDUPL_POINTER_POSITION::Visible"]/*' />
	public Bool32 Visible;
}

/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTDUPL_POINTER_SHAPE_INFO"]/*' />
/// <unmanaged>DXGI_OUTDUPL_POINTER_SHAPE_INFO</unmanaged>
public partial struct OutduplPointerShapeInfo
{
	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTDUPL_POINTER_SHAPE_INFO::Type"]/*' />
	public uint Type;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTDUPL_POINTER_SHAPE_INFO::Width"]/*' />
	public uint Width;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTDUPL_POINTER_SHAPE_INFO::Height"]/*' />
	public uint Height;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTDUPL_POINTER_SHAPE_INFO::Pitch"]/*' />
	public uint Pitch;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTDUPL_POINTER_SHAPE_INFO::HotSpot"]/*' />
	public System.Drawing.Point HotSpot;
}

/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTDUPL_FRAME_INFO"]/*' />
/// <unmanaged>DXGI_OUTDUPL_FRAME_INFO</unmanaged>
public partial struct OutduplFrameInfo
{
	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTDUPL_FRAME_INFO::LastPresentTime"]/*' />
	public long LastPresentTime;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTDUPL_FRAME_INFO::LastMouseUpdateTime"]/*' />
	public long LastMouseUpdateTime;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTDUPL_FRAME_INFO::AccumulatedFrames"]/*' />
	public uint AccumulatedFrames;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTDUPL_FRAME_INFO::RectsCoalesced"]/*' />
	public Bool32 RectsCoalesced;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTDUPL_FRAME_INFO::ProtectedContentMaskedOut"]/*' />
	public Bool32 ProtectedContentMaskedOut;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTDUPL_FRAME_INFO::PointerPosition"]/*' />
	public OutduplPointerPosition PointerPosition;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTDUPL_FRAME_INFO::TotalMetadataBufferSize"]/*' />
	public uint TotalMetadataBufferSize;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTDUPL_FRAME_INFO::PointerShapeBufferSize"]/*' />
	public uint PointerShapeBufferSize;
}

/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_MODE_DESC1"]/*' />
/// <unmanaged>DXGI_MODE_DESC1</unmanaged>
public partial struct ModeDescription1
{
	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_MODE_DESC1::Width"]/*' />
	public uint Width;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_MODE_DESC1::Height"]/*' />
	public uint Height;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_MODE_DESC1::RefreshRate"]/*' />
	public Common.Rational RefreshRate;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_MODE_DESC1::Format"]/*' />
	public Common.Format Format;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_MODE_DESC1::ScanlineOrdering"]/*' />
	public Common.ModeScanlineOrder ScanlineOrdering;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_MODE_DESC1::Scaling"]/*' />
	public Common.ModeScaling Scaling;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_MODE_DESC1::Stereo"]/*' />
	public Bool32 Stereo;
}

/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC1"]/*' />
/// <unmanaged>DXGI_SWAP_CHAIN_DESC1</unmanaged>
public partial struct SwapChainDescription1
{
	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC1::Width"]/*' />
	public uint Width;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC1::Height"]/*' />
	public uint Height;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC1::Format"]/*' />
	public Common.Format Format;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC1::Stereo"]/*' />
	public Bool32 Stereo;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC1::SampleDesc"]/*' />
	public Common.SampleDescription SampleDesc;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC1::BufferUsage"]/*' />
	public Usage BufferUsage;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC1::BufferCount"]/*' />
	public uint BufferCount;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC1::Scaling"]/*' />
	public Scaling Scaling;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC1::SwapEffect"]/*' />
	public SwapEffect SwapEffect;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC1::AlphaMode"]/*' />
	public Common.AlphaMode AlphaMode;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_DESC1::Flags"]/*' />
	public SwapChainFlags Flags;
}

/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FULLSCREEN_DESC"]/*' />
/// <unmanaged>DXGI_SWAP_CHAIN_FULLSCREEN_DESC</unmanaged>
public partial struct SwapChainFullscreenDescription
{
	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FULLSCREEN_DESC::RefreshRate"]/*' />
	public Common.Rational RefreshRate;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FULLSCREEN_DESC::ScanlineOrdering"]/*' />
	public Common.ModeScanlineOrder ScanlineOrdering;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FULLSCREEN_DESC::Scaling"]/*' />
	public Common.ModeScaling Scaling;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_SWAP_CHAIN_FULLSCREEN_DESC::Windowed"]/*' />
	public Bool32 Windowed;
}

/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_PRESENT_PARAMETERS"]/*' />
/// <unmanaged>DXGI_PRESENT_PARAMETERS</unmanaged>
public partial struct PresentParameters
{
	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_PRESENT_PARAMETERS::DirtyRectsCount"]/*' />
	public uint DirtyRectsCount;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_PRESENT_PARAMETERS::pDirtyRects"]/*' />
	public unsafe Rect* pDirtyRects;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_PRESENT_PARAMETERS::pScrollRect"]/*' />
	public unsafe Rect* pScrollRect;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_PRESENT_PARAMETERS::pScrollOffset"]/*' />
	public unsafe System.Drawing.Point* pScrollOffset;
}

/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC2"]/*' />
/// <unmanaged>DXGI_ADAPTER_DESC2</unmanaged>
public partial struct AdapterDescription2
{
	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC2::Description"]/*' />
	public unsafe fixed char Description[128];

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC2::VendorId"]/*' />
	public uint VendorId;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC2::DeviceId"]/*' />
	public uint DeviceId;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC2::SubSysId"]/*' />
	public uint SubSysId;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC2::Revision"]/*' />
	public uint Revision;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC2::DedicatedVideoMemory"]/*' />
	public nuint DedicatedVideoMemory;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC2::DedicatedSystemMemory"]/*' />
	public nuint DedicatedSystemMemory;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC2::SharedSystemMemory"]/*' />
	public nuint SharedSystemMemory;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC2::AdapterLuid"]/*' />
	public Luid AdapterLuid;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC2::Flags"]/*' />
	public uint Flags;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC2::GraphicsPreemptionGranularity"]/*' />
	public GraphicsPreemptionGranularity GraphicsPreemptionGranularity;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC2::ComputePreemptionGranularity"]/*' />
	public ComputePreemptionGranularity ComputePreemptionGranularity;
}

/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_DECODE_SWAP_CHAIN_DESC"]/*' />
/// <unmanaged>DXGI_DECODE_SWAP_CHAIN_DESC</unmanaged>
public partial struct DecodeSwapChainDescription
{
	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_DECODE_SWAP_CHAIN_DESC::Flags"]/*' />
	public SwapChainFlags Flags;
}

/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS_MEDIA"]/*' />
/// <unmanaged>DXGI_FRAME_STATISTICS_MEDIA</unmanaged>
public partial struct FrameStatisticsMedia
{
	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS_MEDIA::PresentCount"]/*' />
	public uint PresentCount;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS_MEDIA::PresentRefreshCount"]/*' />
	public uint PresentRefreshCount;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS_MEDIA::SyncRefreshCount"]/*' />
	public uint SyncRefreshCount;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS_MEDIA::SyncQPCTime"]/*' />
	public long SyncQPCTime;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS_MEDIA::SyncGPUTime"]/*' />
	public long SyncGPUTime;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS_MEDIA::CompositionMode"]/*' />
	public FramePresentationMode CompositionMode;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_FRAME_STATISTICS_MEDIA::ApprovedPresentDuration"]/*' />
	public uint ApprovedPresentDuration;
}

/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_QUERY_VIDEO_MEMORY_INFO"]/*' />
/// <unmanaged>DXGI_QUERY_VIDEO_MEMORY_INFO</unmanaged>
public partial struct QueryVideoMemoryInfo
{
	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_QUERY_VIDEO_MEMORY_INFO::Budget"]/*' />
	public ulong Budget;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_QUERY_VIDEO_MEMORY_INFO::CurrentUsage"]/*' />
	public ulong CurrentUsage;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_QUERY_VIDEO_MEMORY_INFO::AvailableForReservation"]/*' />
	public ulong AvailableForReservation;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_QUERY_VIDEO_MEMORY_INFO::CurrentReservation"]/*' />
	public ulong CurrentReservation;
}

/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_HDR_METADATA_HDR10"]/*' />
/// <unmanaged>DXGI_HDR_METADATA_HDR10</unmanaged>
public partial struct HDRMetadataHdr10
{
	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_HDR_METADATA_HDR10::RedPrimary"]/*' />
	public unsafe fixed ushort RedPrimary[2];

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_HDR_METADATA_HDR10::GreenPrimary"]/*' />
	public unsafe fixed ushort GreenPrimary[2];

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_HDR_METADATA_HDR10::BluePrimary"]/*' />
	public unsafe fixed ushort BluePrimary[2];

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_HDR_METADATA_HDR10::WhitePoint"]/*' />
	public unsafe fixed ushort WhitePoint[2];

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_HDR_METADATA_HDR10::MaxMasteringLuminance"]/*' />
	public uint MaxMasteringLuminance;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_HDR_METADATA_HDR10::MinMasteringLuminance"]/*' />
	public uint MinMasteringLuminance;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_HDR_METADATA_HDR10::MaxContentLightLevel"]/*' />
	public ushort MaxContentLightLevel;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_HDR_METADATA_HDR10::MaxFrameAverageLightLevel"]/*' />
	public ushort MaxFrameAverageLightLevel;
}

/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_HDR_METADATA_HDR10PLUS"]/*' />
/// <unmanaged>DXGI_HDR_METADATA_HDR10PLUS</unmanaged>
public partial struct HDRMetadataHdr10plus
{
	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_HDR_METADATA_HDR10PLUS::Data"]/*' />
	public unsafe fixed byte Data[72];
}

/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3"]/*' />
/// <unmanaged>DXGI_ADAPTER_DESC3</unmanaged>
public partial struct AdapterDescription3
{
	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3::Description"]/*' />
	public unsafe fixed char Description[128];

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3::VendorId"]/*' />
	public uint VendorId;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3::DeviceId"]/*' />
	public uint DeviceId;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3::SubSysId"]/*' />
	public uint SubSysId;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3::Revision"]/*' />
	public uint Revision;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3::DedicatedVideoMemory"]/*' />
	public nuint DedicatedVideoMemory;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3::DedicatedSystemMemory"]/*' />
	public nuint DedicatedSystemMemory;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3::SharedSystemMemory"]/*' />
	public nuint SharedSystemMemory;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3::AdapterLuid"]/*' />
	public Luid AdapterLuid;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3::Flags"]/*' />
	public AdapterFlags3 Flags;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3::GraphicsPreemptionGranularity"]/*' />
	public GraphicsPreemptionGranularity GraphicsPreemptionGranularity;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3::ComputePreemptionGranularity"]/*' />
	public ComputePreemptionGranularity ComputePreemptionGranularity;
}

/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1"]/*' />
/// <unmanaged>DXGI_OUTPUT_DESC1</unmanaged>
public partial struct OutputDescription1
{
	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1::DeviceName"]/*' />
	public unsafe fixed char DeviceName[32];

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1::DesktopCoordinates"]/*' />
	public Rect DesktopCoordinates;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1::AttachedToDesktop"]/*' />
	public Bool32 AttachedToDesktop;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1::Rotation"]/*' />
	public Common.ModeRotation Rotation;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1::Monitor"]/*' />
	public IntPtr Monitor;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1::BitsPerColor"]/*' />
	public uint BitsPerColor;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1::ColorSpace"]/*' />
	public Common.ColorSpaceType ColorSpace;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1::RedPrimary"]/*' />
	public unsafe fixed float RedPrimary[2];

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1::GreenPrimary"]/*' />
	public unsafe fixed float GreenPrimary[2];

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1::BluePrimary"]/*' />
	public unsafe fixed float BluePrimary[2];

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1::WhitePoint"]/*' />
	public unsafe fixed float WhitePoint[2];

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1::MinLuminance"]/*' />
	public float MinLuminance;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1::MaxLuminance"]/*' />
	public float MaxLuminance;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1::MaxFullFrameLuminance"]/*' />
	public float MaxFullFrameLuminance;
}

/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_INFO_QUEUE_MESSAGE"]/*' />
/// <unmanaged>DXGI_INFO_QUEUE_MESSAGE</unmanaged>
public partial struct InfoQueueMessage
{
	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_INFO_QUEUE_MESSAGE::Producer"]/*' />
	public Guid Producer;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_INFO_QUEUE_MESSAGE::Category"]/*' />
	public InfoQueueMessageCategory Category;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_INFO_QUEUE_MESSAGE::Severity"]/*' />
	public InfoQueueMessageSeverity Severity;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_INFO_QUEUE_MESSAGE::ID"]/*' />
	public int ID;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_INFO_QUEUE_MESSAGE::pDescription"]/*' />
	public unsafe byte* pDescription;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_INFO_QUEUE_MESSAGE::DescriptionByteLength"]/*' />
	public nuint DescriptionByteLength;
}

/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_INFO_QUEUE_FILTER_DESC"]/*' />
/// <unmanaged>DXGI_INFO_QUEUE_FILTER_DESC</unmanaged>
public partial struct InfoQueueFilterDescription
{
	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_INFO_QUEUE_FILTER_DESC::NumCategories"]/*' />
	public uint NumCategories;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_INFO_QUEUE_FILTER_DESC::pCategoryList"]/*' />
	public unsafe InfoQueueMessageCategory* pCategoryList;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_INFO_QUEUE_FILTER_DESC::NumSeverities"]/*' />
	public uint NumSeverities;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_INFO_QUEUE_FILTER_DESC::pSeverityList"]/*' />
	public unsafe InfoQueueMessageSeverity* pSeverityList;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_INFO_QUEUE_FILTER_DESC::NumIDs"]/*' />
	public uint NumIDs;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_INFO_QUEUE_FILTER_DESC::pIDList"]/*' />
	public unsafe int* pIDList;
}

/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_INFO_QUEUE_FILTER"]/*' />
/// <unmanaged>DXGI_INFO_QUEUE_FILTER</unmanaged>
public partial struct InfoQueueFilter
{
	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_INFO_QUEUE_FILTER::AllowList"]/*' />
	public InfoQueueFilterDescription AllowList;

	/// <include file='../Dxgi.xml' path='doc/member[@name="DXGI_INFO_QUEUE_FILTER::DenyList"]/*' />
	public InfoQueueFilterDescription DenyList;
}
