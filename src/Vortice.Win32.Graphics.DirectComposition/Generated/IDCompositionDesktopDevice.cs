// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Graphics.DirectComposition;

/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDesktopDevice"]/*' />
/// <unmanaged>IDCompositionDesktopDevice</unmanaged>
[Guid("5f4633fe-1e08-4cb8-8c75-ce24333f5602")]
[NativeTypeName("struct IDCompositionDesktopDevice : IDCompositionDevice2")]
[NativeInheritance("IDCompositionDevice2")]
public unsafe partial struct IDCompositionDesktopDevice : INativeGuid
{
	public static ref readonly Guid IID_IDCompositionDesktopDevice
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			ReadOnlySpan<byte> data = new byte[] {
				0xFE, 0x33, 0x46, 0x5F,
				0x08, 0x1E,
				0xB8, 0x4C,
				0x8C,
				0x75,
				0xCE,
				0x24,
				0x33,
				0x3F,
				0x56,
				0x02
			};

			Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
			return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
		}
	}

#if NET6_0_OR_GREATER
	static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionDesktopDevice));
#else
	public static Guid* NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionDesktopDevice));
#endif

	public void** lpVtbl;

	/// <inheritdoc cref="IUnknown.QueryInterface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
	}

	/// <inheritdoc cref="IUnknown.AddRef" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	[return: NativeTypeName("ULONG")]
	public uint AddRef()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, uint>)(lpVtbl[1]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IUnknown.Release" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	[return: NativeTypeName("ULONG")]
	public uint Release()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, uint>)(lpVtbl[2]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDCompositionDevice2.Commit" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult Commit()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, int>)(lpVtbl[3]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDCompositionDevice2.WaitForCommitCompletion" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult WaitForCommitCompletion()
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, int>)(lpVtbl[4]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this));
	}

	/// <inheritdoc cref="IDCompositionDevice2.GetFrameStatistics" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public HResult GetFrameStatistics(FrameStatistics* statistics)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, FrameStatistics*, int>)(lpVtbl[5]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), statistics);
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateVisual" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult CreateVisual(IDCompositionVisual2** visual)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionVisual2**, int>)(lpVtbl[6]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), visual);
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateSurfaceFactory" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult CreateSurfaceFactory(IUnknown* renderingDevice, IDCompositionSurfaceFactory** surfaceFactory)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IUnknown*, IDCompositionSurfaceFactory**, int>)(lpVtbl[7]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), renderingDevice, surfaceFactory);
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateSurface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult CreateSurface(uint width, uint height, Graphics.Dxgi.Common.Format pixelFormat, Graphics.Dxgi.Common.AlphaMode alphaMode, IDCompositionSurface** surface)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, uint, uint, Graphics.Dxgi.Common.Format, Graphics.Dxgi.Common.AlphaMode, IDCompositionSurface**, int>)(lpVtbl[8]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), width, height, pixelFormat, alphaMode, surface);
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateVirtualSurface" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public HResult CreateVirtualSurface(uint initialWidth, uint initialHeight, Graphics.Dxgi.Common.Format pixelFormat, Graphics.Dxgi.Common.AlphaMode alphaMode, IDCompositionVirtualSurface** virtualSurface)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, uint, uint, Graphics.Dxgi.Common.Format, Graphics.Dxgi.Common.AlphaMode, IDCompositionVirtualSurface**, int>)(lpVtbl[9]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), initialWidth, initialHeight, pixelFormat, alphaMode, virtualSurface);
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateTranslateTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult CreateTranslateTransform(IDCompositionTranslateTransform** translateTransform)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionTranslateTransform**, int>)(lpVtbl[10]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), translateTransform);
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateScaleTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public HResult CreateScaleTransform(IDCompositionScaleTransform** scaleTransform)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionScaleTransform**, int>)(lpVtbl[11]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), scaleTransform);
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateRotateTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult CreateRotateTransform(IDCompositionRotateTransform** rotateTransform)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionRotateTransform**, int>)(lpVtbl[12]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), rotateTransform);
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateSkewTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public HResult CreateSkewTransform(IDCompositionSkewTransform** skewTransform)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionSkewTransform**, int>)(lpVtbl[13]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), skewTransform);
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateMatrixTransform" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult CreateMatrixTransform(IDCompositionMatrixTransform** matrixTransform)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionMatrixTransform**, int>)(lpVtbl[14]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), matrixTransform);
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateTransformGroup" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public HResult CreateTransformGroup(IDCompositionTransform** transforms, uint elements, IDCompositionTransform** transformGroup)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionTransform**, uint, IDCompositionTransform**, int>)(lpVtbl[15]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), transforms, elements, transformGroup);
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateTranslateTransform3D" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult CreateTranslateTransform3D(IDCompositionTranslateTransform3D** translateTransform3D)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionTranslateTransform3D**, int>)(lpVtbl[16]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), translateTransform3D);
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateScaleTransform3D" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public HResult CreateScaleTransform3D(IDCompositionScaleTransform3D** scaleTransform3D)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionScaleTransform3D**, int>)(lpVtbl[17]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), scaleTransform3D);
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateRotateTransform3D" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public HResult CreateRotateTransform3D(IDCompositionRotateTransform3D** rotateTransform3D)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionRotateTransform3D**, int>)(lpVtbl[18]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), rotateTransform3D);
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateMatrixTransform3D" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult CreateMatrixTransform3D(IDCompositionMatrixTransform3D** matrixTransform3D)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionMatrixTransform3D**, int>)(lpVtbl[19]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), matrixTransform3D);
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateTransform3DGroup" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(20)]
	public HResult CreateTransform3DGroup(IDCompositionTransform3D** transforms3D, uint elements, IDCompositionTransform3D** transform3DGroup)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionTransform3D**, uint, IDCompositionTransform3D**, int>)(lpVtbl[20]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), transforms3D, elements, transform3DGroup);
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateEffectGroup" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(21)]
	public HResult CreateEffectGroup(IDCompositionEffectGroup** effectGroup)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionEffectGroup**, int>)(lpVtbl[21]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), effectGroup);
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateRectangleClip" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(22)]
	public HResult CreateRectangleClip(IDCompositionRectangleClip** clip)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionRectangleClip**, int>)(lpVtbl[22]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), clip);
	}

	/// <inheritdoc cref="IDCompositionDevice2.CreateAnimation" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(23)]
	public HResult CreateAnimation(IDCompositionAnimation** animation)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IDCompositionAnimation**, int>)(lpVtbl[23]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), animation);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDesktopDevice::CreateTargetForHwnd"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(24)]
	public HResult CreateTargetForHwnd(IntPtr hwnd, Bool32 topmost, IDCompositionTarget** target)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IntPtr, Bool32, IDCompositionTarget**, int>)(lpVtbl[24]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), hwnd, topmost, target);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDesktopDevice::CreateSurfaceFromHandle"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(25)]
	public HResult CreateSurfaceFromHandle(Handle handle, IUnknown** surface)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, Handle, IUnknown**, int>)(lpVtbl[25]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), handle, surface);
	}

	/// <include file='../DirectComposition.xml' path='doc/member[@name="IDCompositionDesktopDevice::CreateSurfaceFromHwnd"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(26)]
	public HResult CreateSurfaceFromHwnd(IntPtr hwnd, IUnknown** surface)
	{
		return ((delegate* unmanaged[Stdcall]<IDCompositionDesktopDevice*, IntPtr, IUnknown**, int>)(lpVtbl[26]))((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), hwnd, surface);
	}
}

