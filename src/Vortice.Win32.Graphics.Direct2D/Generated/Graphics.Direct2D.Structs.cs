// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.Direct2D;

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_BITMAP_PROPERTIES"]/*' />
/// <unmanaged>D2D1_BITMAP_PROPERTIES</unmanaged>
public partial struct BitmapProperties
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_BITMAP_PROPERTIES::pixelFormat"]/*' />
	public Common.PixelFormat pixelFormat;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_BITMAP_PROPERTIES::dpiX"]/*' />
	public float dpiX;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_BITMAP_PROPERTIES::dpiY"]/*' />
	public float dpiY;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_BRUSH_PROPERTIES"]/*' />
/// <unmanaged>D2D1_BRUSH_PROPERTIES</unmanaged>
public partial struct BrushProperties
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_BRUSH_PROPERTIES::opacity"]/*' />
	public float opacity;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_BRUSH_PROPERTIES::transform"]/*' />
	public Matrix3x2 transform;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_BITMAP_BRUSH_PROPERTIES"]/*' />
/// <unmanaged>D2D1_BITMAP_BRUSH_PROPERTIES</unmanaged>
public partial struct BitmapBrushProperties
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_BITMAP_BRUSH_PROPERTIES::extendModeX"]/*' />
	public ExtendMode extendModeX;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_BITMAP_BRUSH_PROPERTIES::extendModeY"]/*' />
	public ExtendMode extendModeY;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_BITMAP_BRUSH_PROPERTIES::interpolationMode"]/*' />
	public BitmapInterpolationMode interpolationMode;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES"]/*' />
/// <unmanaged>D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES</unmanaged>
public partial struct LinearGradientBrushProperties
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES::startPoint"]/*' />
	public Vector2 startPoint;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES::endPoint"]/*' />
	public Vector2 endPoint;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES"]/*' />
/// <unmanaged>D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES</unmanaged>
public partial struct RadialGradientBrushProperties
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES::center"]/*' />
	public Vector2 center;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES::gradientOriginOffset"]/*' />
	public Vector2 gradientOriginOffset;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES::radiusX"]/*' />
	public float radiusX;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES::radiusY"]/*' />
	public float radiusY;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_TRIANGLE"]/*' />
/// <unmanaged>D2D1_TRIANGLE</unmanaged>
public partial struct Triangle
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_TRIANGLE::point1"]/*' />
	public Vector2 point1;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_TRIANGLE::point2"]/*' />
	public Vector2 point2;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_TRIANGLE::point3"]/*' />
	public Vector2 point3;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_ARC_SEGMENT"]/*' />
/// <unmanaged>D2D1_ARC_SEGMENT</unmanaged>
public partial struct ArcSegment
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_ARC_SEGMENT::point"]/*' />
	public Vector2 point;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_ARC_SEGMENT::size"]/*' />
	public System.Drawing.SizeF size;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_ARC_SEGMENT::rotationAngle"]/*' />
	public float rotationAngle;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_ARC_SEGMENT::sweepDirection"]/*' />
	public SweepDirection sweepDirection;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_ARC_SEGMENT::arcSize"]/*' />
	public ArcSize arcSize;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_QUADRATIC_BEZIER_SEGMENT"]/*' />
/// <unmanaged>D2D1_QUADRATIC_BEZIER_SEGMENT</unmanaged>
public partial struct QuadraticBezierSegment
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_QUADRATIC_BEZIER_SEGMENT::point1"]/*' />
	public Vector2 point1;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_QUADRATIC_BEZIER_SEGMENT::point2"]/*' />
	public Vector2 point2;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_ELLIPSE"]/*' />
/// <unmanaged>D2D1_ELLIPSE</unmanaged>
public partial struct Ellipse
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_ELLIPSE::point"]/*' />
	public Vector2 point;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_ELLIPSE::radiusX"]/*' />
	public float radiusX;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_ELLIPSE::radiusY"]/*' />
	public float radiusY;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_ROUNDED_RECT"]/*' />
/// <unmanaged>D2D1_ROUNDED_RECT</unmanaged>
public partial struct RoundedRect
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_ROUNDED_RECT::rect"]/*' />
	public Win32.Numerics.RectF rect;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_ROUNDED_RECT::radiusX"]/*' />
	public float radiusX;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_ROUNDED_RECT::radiusY"]/*' />
	public float radiusY;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_STROKE_STYLE_PROPERTIES"]/*' />
/// <unmanaged>D2D1_STROKE_STYLE_PROPERTIES</unmanaged>
public partial struct StrokeStyleProperties
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_STROKE_STYLE_PROPERTIES::startCap"]/*' />
	public CapStyle startCap;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_STROKE_STYLE_PROPERTIES::endCap"]/*' />
	public CapStyle endCap;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_STROKE_STYLE_PROPERTIES::dashCap"]/*' />
	public CapStyle dashCap;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_STROKE_STYLE_PROPERTIES::lineJoin"]/*' />
	public LineJoin lineJoin;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_STROKE_STYLE_PROPERTIES::miterLimit"]/*' />
	public float miterLimit;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_STROKE_STYLE_PROPERTIES::dashStyle"]/*' />
	public DashStyle dashStyle;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_STROKE_STYLE_PROPERTIES::dashOffset"]/*' />
	public float dashOffset;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_LAYER_PARAMETERS"]/*' />
/// <unmanaged>D2D1_LAYER_PARAMETERS</unmanaged>
public partial struct LayerParameters
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_LAYER_PARAMETERS::contentBounds"]/*' />
	public Win32.Numerics.RectF contentBounds;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_LAYER_PARAMETERS::geometricMask"]/*' />
	public unsafe ID2D1Geometry* geometricMask;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_LAYER_PARAMETERS::maskAntialiasMode"]/*' />
	public AntialiasMode maskAntialiasMode;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_LAYER_PARAMETERS::maskTransform"]/*' />
	public Matrix3x2 maskTransform;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_LAYER_PARAMETERS::opacity"]/*' />
	public float opacity;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_LAYER_PARAMETERS::opacityBrush"]/*' />
	public unsafe ID2D1Brush* opacityBrush;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_LAYER_PARAMETERS::layerOptions"]/*' />
	public LayerOptions layerOptions;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_RENDER_TARGET_PROPERTIES"]/*' />
/// <unmanaged>D2D1_RENDER_TARGET_PROPERTIES</unmanaged>
public partial struct RenderTargetProperties
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_RENDER_TARGET_PROPERTIES::type"]/*' />
	public RenderTargetType type;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_RENDER_TARGET_PROPERTIES::pixelFormat"]/*' />
	public Common.PixelFormat pixelFormat;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_RENDER_TARGET_PROPERTIES::dpiX"]/*' />
	public float dpiX;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_RENDER_TARGET_PROPERTIES::dpiY"]/*' />
	public float dpiY;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_RENDER_TARGET_PROPERTIES::usage"]/*' />
	public RenderTargetUsage usage;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_RENDER_TARGET_PROPERTIES::minLevel"]/*' />
	public FeatureLevel minLevel;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_HWND_RENDER_TARGET_PROPERTIES"]/*' />
/// <unmanaged>D2D1_HWND_RENDER_TARGET_PROPERTIES</unmanaged>
public partial struct HwndRenderTargetProperties
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_HWND_RENDER_TARGET_PROPERTIES::hwnd"]/*' />
	public nint hwnd;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_HWND_RENDER_TARGET_PROPERTIES::pixelSize"]/*' />
	public System.Drawing.Size pixelSize;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_HWND_RENDER_TARGET_PROPERTIES::presentOptions"]/*' />
	public PresentOptions presentOptions;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_DRAWING_STATE_DESCRIPTION"]/*' />
/// <unmanaged>D2D1_DRAWING_STATE_DESCRIPTION</unmanaged>
public partial struct DrawingStateDescription
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_DRAWING_STATE_DESCRIPTION::antialiasMode"]/*' />
	public AntialiasMode antialiasMode;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_DRAWING_STATE_DESCRIPTION::textAntialiasMode"]/*' />
	public TextAntialiasMode textAntialiasMode;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_DRAWING_STATE_DESCRIPTION::tag1"]/*' />
	public ulong tag1;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_DRAWING_STATE_DESCRIPTION::tag2"]/*' />
	public ulong tag2;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_DRAWING_STATE_DESCRIPTION::transform"]/*' />
	public Matrix3x2 transform;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_FACTORY_OPTIONS"]/*' />
/// <unmanaged>D2D1_FACTORY_OPTIONS</unmanaged>
public partial struct FactoryOptions
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_FACTORY_OPTIONS::debugLevel"]/*' />
	public DebugLevel debugLevel;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_BITMAP_PROPERTIES1"]/*' />
/// <unmanaged>D2D1_BITMAP_PROPERTIES1</unmanaged>
public partial struct BitmapProperties1
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_BITMAP_PROPERTIES1::pixelFormat"]/*' />
	public Common.PixelFormat pixelFormat;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_BITMAP_PROPERTIES1::dpiX"]/*' />
	public float dpiX;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_BITMAP_PROPERTIES1::dpiY"]/*' />
	public float dpiY;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_BITMAP_PROPERTIES1::bitmapOptions"]/*' />
	public BitmapOptions bitmapOptions;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_BITMAP_PROPERTIES1::colorContext"]/*' />
	public unsafe ID2D1ColorContext* colorContext;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_MAPPED_RECT"]/*' />
/// <unmanaged>D2D1_MAPPED_RECT</unmanaged>
public partial struct MappedRect
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_MAPPED_RECT::pitch"]/*' />
	public uint pitch;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_MAPPED_RECT::bits"]/*' />
	public unsafe byte* bits;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_RENDERING_CONTROLS"]/*' />
/// <unmanaged>D2D1_RENDERING_CONTROLS</unmanaged>
public partial struct RenderingControls
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_RENDERING_CONTROLS::bufferPrecision"]/*' />
	public BufferPrecision bufferPrecision;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_RENDERING_CONTROLS::tileSize"]/*' />
	public System.Drawing.Size tileSize;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_EFFECT_INPUT_DESCRIPTION"]/*' />
/// <unmanaged>D2D1_EFFECT_INPUT_DESCRIPTION</unmanaged>
public partial struct EffectInputDescription
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_EFFECT_INPUT_DESCRIPTION::effect"]/*' />
	public unsafe ID2D1Effect* effect;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_EFFECT_INPUT_DESCRIPTION::inputIndex"]/*' />
	public uint inputIndex;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_EFFECT_INPUT_DESCRIPTION::inputRectangle"]/*' />
	public Win32.Numerics.RectF inputRectangle;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_POINT_DESCRIPTION"]/*' />
/// <unmanaged>D2D1_POINT_DESCRIPTION</unmanaged>
public partial struct PointDescription
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_POINT_DESCRIPTION::point"]/*' />
	public Vector2 point;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_POINT_DESCRIPTION::unitTangentVector"]/*' />
	public Vector2 unitTangentVector;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_POINT_DESCRIPTION::endSegment"]/*' />
	public uint endSegment;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_POINT_DESCRIPTION::endFigure"]/*' />
	public uint endFigure;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_POINT_DESCRIPTION::lengthToEndSegment"]/*' />
	public float lengthToEndSegment;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_IMAGE_BRUSH_PROPERTIES"]/*' />
/// <unmanaged>D2D1_IMAGE_BRUSH_PROPERTIES</unmanaged>
public partial struct ImageBrushProperties
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_IMAGE_BRUSH_PROPERTIES::sourceRectangle"]/*' />
	public Win32.Numerics.RectF sourceRectangle;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_IMAGE_BRUSH_PROPERTIES::extendModeX"]/*' />
	public ExtendMode extendModeX;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_IMAGE_BRUSH_PROPERTIES::extendModeY"]/*' />
	public ExtendMode extendModeY;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_IMAGE_BRUSH_PROPERTIES::interpolationMode"]/*' />
	public InterpolationMode interpolationMode;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_BITMAP_BRUSH_PROPERTIES1"]/*' />
/// <unmanaged>D2D1_BITMAP_BRUSH_PROPERTIES1</unmanaged>
public partial struct BitmapBrushProperties1
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_BITMAP_BRUSH_PROPERTIES1::extendModeX"]/*' />
	public ExtendMode extendModeX;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_BITMAP_BRUSH_PROPERTIES1::extendModeY"]/*' />
	public ExtendMode extendModeY;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_BITMAP_BRUSH_PROPERTIES1::interpolationMode"]/*' />
	public InterpolationMode interpolationMode;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_STROKE_STYLE_PROPERTIES1"]/*' />
/// <unmanaged>D2D1_STROKE_STYLE_PROPERTIES1</unmanaged>
public partial struct StrokeStyleProperties1
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_STROKE_STYLE_PROPERTIES1::startCap"]/*' />
	public CapStyle startCap;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_STROKE_STYLE_PROPERTIES1::endCap"]/*' />
	public CapStyle endCap;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_STROKE_STYLE_PROPERTIES1::dashCap"]/*' />
	public CapStyle dashCap;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_STROKE_STYLE_PROPERTIES1::lineJoin"]/*' />
	public LineJoin lineJoin;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_STROKE_STYLE_PROPERTIES1::miterLimit"]/*' />
	public float miterLimit;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_STROKE_STYLE_PROPERTIES1::dashStyle"]/*' />
	public DashStyle dashStyle;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_STROKE_STYLE_PROPERTIES1::dashOffset"]/*' />
	public float dashOffset;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_STROKE_STYLE_PROPERTIES1::transformType"]/*' />
	public StrokeTransformType transformType;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_LAYER_PARAMETERS1"]/*' />
/// <unmanaged>D2D1_LAYER_PARAMETERS1</unmanaged>
public partial struct LayerParameters1
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_LAYER_PARAMETERS1::contentBounds"]/*' />
	public Win32.Numerics.RectF contentBounds;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_LAYER_PARAMETERS1::geometricMask"]/*' />
	public unsafe ID2D1Geometry* geometricMask;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_LAYER_PARAMETERS1::maskAntialiasMode"]/*' />
	public AntialiasMode maskAntialiasMode;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_LAYER_PARAMETERS1::maskTransform"]/*' />
	public Matrix3x2 maskTransform;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_LAYER_PARAMETERS1::opacity"]/*' />
	public float opacity;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_LAYER_PARAMETERS1::opacityBrush"]/*' />
	public unsafe ID2D1Brush* opacityBrush;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_LAYER_PARAMETERS1::layerOptions"]/*' />
	public LayerOptions1 layerOptions;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_DRAWING_STATE_DESCRIPTION1"]/*' />
/// <unmanaged>D2D1_DRAWING_STATE_DESCRIPTION1</unmanaged>
public partial struct DrawingStateDescription1
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_DRAWING_STATE_DESCRIPTION1::antialiasMode"]/*' />
	public AntialiasMode antialiasMode;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_DRAWING_STATE_DESCRIPTION1::textAntialiasMode"]/*' />
	public TextAntialiasMode textAntialiasMode;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_DRAWING_STATE_DESCRIPTION1::tag1"]/*' />
	public ulong tag1;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_DRAWING_STATE_DESCRIPTION1::tag2"]/*' />
	public ulong tag2;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_DRAWING_STATE_DESCRIPTION1::transform"]/*' />
	public Matrix3x2 transform;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_DRAWING_STATE_DESCRIPTION1::primitiveBlend"]/*' />
	public PrimitiveBlend primitiveBlend;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_DRAWING_STATE_DESCRIPTION1::unitMode"]/*' />
	public UnitMode unitMode;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_PRINT_CONTROL_PROPERTIES"]/*' />
/// <unmanaged>D2D1_PRINT_CONTROL_PROPERTIES</unmanaged>
public partial struct PrintControlProperties
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_PRINT_CONTROL_PROPERTIES::fontSubset"]/*' />
	public PrintFontSubsetMode fontSubset;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_PRINT_CONTROL_PROPERTIES::rasterDPI"]/*' />
	public float rasterDPI;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_PRINT_CONTROL_PROPERTIES::colorSpace"]/*' />
	public ColorSpace colorSpace;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_CREATION_PROPERTIES"]/*' />
/// <unmanaged>D2D1_CREATION_PROPERTIES</unmanaged>
public partial struct CreationProperties
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_CREATION_PROPERTIES::threadingMode"]/*' />
	public ThreadingMode threadingMode;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_CREATION_PROPERTIES::debugLevel"]/*' />
	public DebugLevel debugLevel;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_CREATION_PROPERTIES::options"]/*' />
	public DeviceContextOptions options;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_PROPERTY_BINDING"]/*' />
/// <unmanaged>D2D1_PROPERTY_BINDING</unmanaged>
public partial struct PropertyBinding
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_PROPERTY_BINDING::propertyName"]/*' />
	public unsafe char* propertyName;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_PROPERTY_BINDING::setFunction"]/*' />
	public unsafe delegate* unmanaged[Stdcall]<IUnknown*, byte*, uint, HResult> setFunction;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_PROPERTY_BINDING::getFunction"]/*' />
	public unsafe delegate* unmanaged[Stdcall]<IUnknown*, byte*, uint, uint*, HResult> getFunction;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_RESOURCE_TEXTURE_PROPERTIES"]/*' />
/// <unmanaged>D2D1_RESOURCE_TEXTURE_PROPERTIES</unmanaged>
public partial struct ResourceTextureProperties
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_RESOURCE_TEXTURE_PROPERTIES::extents"]/*' />
	public unsafe uint* extents;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_RESOURCE_TEXTURE_PROPERTIES::dimensions"]/*' />
	public uint dimensions;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_RESOURCE_TEXTURE_PROPERTIES::bufferPrecision"]/*' />
	public BufferPrecision bufferPrecision;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_RESOURCE_TEXTURE_PROPERTIES::channelDepth"]/*' />
	public ChannelDepth channelDepth;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_RESOURCE_TEXTURE_PROPERTIES::filter"]/*' />
	public Filter filter;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_RESOURCE_TEXTURE_PROPERTIES::extendModes"]/*' />
	public unsafe ExtendMode* extendModes;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_INPUT_ELEMENT_DESC"]/*' />
/// <unmanaged>D2D1_INPUT_ELEMENT_DESC</unmanaged>
public partial struct InputElementDescription
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_INPUT_ELEMENT_DESC::semanticName"]/*' />
	public unsafe sbyte* semanticName;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_INPUT_ELEMENT_DESC::semanticIndex"]/*' />
	public uint semanticIndex;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_INPUT_ELEMENT_DESC::format"]/*' />
	public Graphics.Dxgi.Common.Format format;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_INPUT_ELEMENT_DESC::inputSlot"]/*' />
	public uint inputSlot;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_INPUT_ELEMENT_DESC::alignedByteOffset"]/*' />
	public uint alignedByteOffset;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_VERTEX_BUFFER_PROPERTIES"]/*' />
/// <unmanaged>D2D1_VERTEX_BUFFER_PROPERTIES</unmanaged>
public partial struct VertexBufferProperties
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_VERTEX_BUFFER_PROPERTIES::inputCount"]/*' />
	public uint inputCount;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_VERTEX_BUFFER_PROPERTIES::usage"]/*' />
	public VertexUsage usage;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_VERTEX_BUFFER_PROPERTIES::data"]/*' />
	public unsafe byte* data;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_VERTEX_BUFFER_PROPERTIES::byteWidth"]/*' />
	public uint byteWidth;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES"]/*' />
/// <unmanaged>D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES</unmanaged>
public partial struct CustomVertexBufferProperties
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES::shaderBufferWithInputSignature"]/*' />
	public unsafe byte* shaderBufferWithInputSignature;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES::shaderBufferSize"]/*' />
	public uint shaderBufferSize;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES::inputElements"]/*' />
	public unsafe InputElementDescription* inputElements;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES::elementCount"]/*' />
	public uint elementCount;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES::stride"]/*' />
	public uint stride;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_VERTEX_RANGE"]/*' />
/// <unmanaged>D2D1_VERTEX_RANGE</unmanaged>
public partial struct VertexRange
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_VERTEX_RANGE::startVertex"]/*' />
	public uint startVertex;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_VERTEX_RANGE::vertexCount"]/*' />
	public uint vertexCount;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_BLEND_DESCRIPTION"]/*' />
/// <unmanaged>D2D1_BLEND_DESCRIPTION</unmanaged>
public partial struct BlendDescription
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_BLEND_DESCRIPTION::sourceBlend"]/*' />
	public Blend sourceBlend;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_BLEND_DESCRIPTION::destinationBlend"]/*' />
	public Blend destinationBlend;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_BLEND_DESCRIPTION::blendOperation"]/*' />
	public BlendOperation blendOperation;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_BLEND_DESCRIPTION::sourceBlendAlpha"]/*' />
	public Blend sourceBlendAlpha;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_BLEND_DESCRIPTION::destinationBlendAlpha"]/*' />
	public Blend destinationBlendAlpha;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_BLEND_DESCRIPTION::blendOperationAlpha"]/*' />
	public BlendOperation blendOperationAlpha;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_BLEND_DESCRIPTION::blendFactor"]/*' />
	public unsafe fixed float blendFactor[4];
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_INPUT_DESCRIPTION"]/*' />
/// <unmanaged>D2D1_INPUT_DESCRIPTION</unmanaged>
public partial struct InputDescription
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_INPUT_DESCRIPTION::filter"]/*' />
	public Filter filter;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_INPUT_DESCRIPTION::levelOfDetailCount"]/*' />
	public uint levelOfDetailCount;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_FEATURE_DATA_DOUBLES"]/*' />
/// <unmanaged>D2D1_FEATURE_DATA_DOUBLES</unmanaged>
public partial struct FeatureDataDoubles
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_FEATURE_DATA_DOUBLES::doublePrecisionFloatShaderOps"]/*' />
	public Bool32 doublePrecisionFloatShaderOps;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_FEATURE_DATA_D3D10_X_HARDWARE_OPTIONS"]/*' />
/// <unmanaged>D2D1_FEATURE_DATA_D3D10_X_HARDWARE_OPTIONS</unmanaged>
public partial struct FeatureDataD3D10XHardwareOptions
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_FEATURE_DATA_D3D10_X_HARDWARE_OPTIONS::computeShaders_Plus_RawAndStructuredBuffers_Via_Shader_4_x"]/*' />
	public Bool32 computeShaders_Plus_RawAndStructuredBuffers_Via_Shader_4_x;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_SVG_LENGTH"]/*' />
/// <unmanaged>D2D1_SVG_LENGTH</unmanaged>
public partial struct SvgLength
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_SVG_LENGTH::value"]/*' />
	public float value;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_SVG_LENGTH::units"]/*' />
	public SvgLengthUnits units;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_SVG_PRESERVE_ASPECT_RATIO"]/*' />
/// <unmanaged>D2D1_SVG_PRESERVE_ASPECT_RATIO</unmanaged>
public partial struct SvgPreserveAspectRatio
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_SVG_PRESERVE_ASPECT_RATIO::defer"]/*' />
	public Bool32 defer;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_SVG_PRESERVE_ASPECT_RATIO::align"]/*' />
	public SvgAspectAlign align;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_SVG_PRESERVE_ASPECT_RATIO::meetOrSlice"]/*' />
	public SvgAspectScaling meetOrSlice;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_SVG_VIEWBOX"]/*' />
/// <unmanaged>D2D1_SVG_VIEWBOX</unmanaged>
public partial struct SvgViewbox
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_SVG_VIEWBOX::x"]/*' />
	public float x;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_SVG_VIEWBOX::y"]/*' />
	public float y;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_SVG_VIEWBOX::width"]/*' />
	public float width;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_SVG_VIEWBOX::height"]/*' />
	public float height;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES"]/*' />
/// <unmanaged>D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES</unmanaged>
public partial struct TransformedImageSourceProperties
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES::orientation"]/*' />
	public Orientation orientation;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES::scaleX"]/*' />
	public float scaleX;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES::scaleY"]/*' />
	public float scaleY;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES::interpolationMode"]/*' />
	public InterpolationMode interpolationMode;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES::options"]/*' />
	public TransformedImageSourceOptions options;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_INK_POINT"]/*' />
/// <unmanaged>D2D1_INK_POINT</unmanaged>
public partial struct InkPoint
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_INK_POINT::x"]/*' />
	public float x;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_INK_POINT::y"]/*' />
	public float y;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_INK_POINT::radius"]/*' />
	public float radius;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_INK_BEZIER_SEGMENT"]/*' />
/// <unmanaged>D2D1_INK_BEZIER_SEGMENT</unmanaged>
public partial struct InkBezierSegment
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_INK_BEZIER_SEGMENT::point1"]/*' />
	public InkPoint point1;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_INK_BEZIER_SEGMENT::point2"]/*' />
	public InkPoint point2;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_INK_BEZIER_SEGMENT::point3"]/*' />
	public InkPoint point3;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_INK_STYLE_PROPERTIES"]/*' />
/// <unmanaged>D2D1_INK_STYLE_PROPERTIES</unmanaged>
public partial struct InkStyleProperties
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_INK_STYLE_PROPERTIES::nibShape"]/*' />
	public InkNibShape nibShape;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_INK_STYLE_PROPERTIES::nibTransform"]/*' />
	public Matrix3x2 nibTransform;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH"]/*' />
/// <unmanaged>D2D1_GRADIENT_MESH_PATCH</unmanaged>
public partial struct GradientMeshPatch
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH::point00"]/*' />
	public Vector2 point00;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH::point01"]/*' />
	public Vector2 point01;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH::point02"]/*' />
	public Vector2 point02;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH::point03"]/*' />
	public Vector2 point03;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH::point10"]/*' />
	public Vector2 point10;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH::point11"]/*' />
	public Vector2 point11;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH::point12"]/*' />
	public Vector2 point12;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH::point13"]/*' />
	public Vector2 point13;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH::point20"]/*' />
	public Vector2 point20;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH::point21"]/*' />
	public Vector2 point21;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH::point22"]/*' />
	public Vector2 point22;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH::point23"]/*' />
	public Vector2 point23;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH::point30"]/*' />
	public Vector2 point30;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH::point31"]/*' />
	public Vector2 point31;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH::point32"]/*' />
	public Vector2 point32;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH::point33"]/*' />
	public Vector2 point33;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH::color00"]/*' />
	public Color4 color00;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH::color03"]/*' />
	public Color4 color03;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH::color30"]/*' />
	public Color4 color30;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH::color33"]/*' />
	public Color4 color33;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH::topEdgeMode"]/*' />
	public PatchEdgeMode topEdgeMode;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH::leftEdgeMode"]/*' />
	public PatchEdgeMode leftEdgeMode;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH::bottomEdgeMode"]/*' />
	public PatchEdgeMode bottomEdgeMode;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_GRADIENT_MESH_PATCH::rightEdgeMode"]/*' />
	public PatchEdgeMode rightEdgeMode;
}

/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_SIMPLE_COLOR_PROFILE"]/*' />
/// <unmanaged>D2D1_SIMPLE_COLOR_PROFILE</unmanaged>
public partial struct SimpleColorProfile
{
	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_SIMPLE_COLOR_PROFILE::redPrimary"]/*' />
	public Vector2 redPrimary;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_SIMPLE_COLOR_PROFILE::greenPrimary"]/*' />
	public Vector2 greenPrimary;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_SIMPLE_COLOR_PROFILE::bluePrimary"]/*' />
	public Vector2 bluePrimary;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_SIMPLE_COLOR_PROFILE::whitePointXZ"]/*' />
	public Vector2 whitePointXZ;

	/// <include file='../Direct2D.xml' path='doc/member[@name="D2D1_SIMPLE_COLOR_PROFILE::gamma"]/*' />
	public Gamma1 gamma;
}
