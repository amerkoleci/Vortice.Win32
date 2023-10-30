// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

namespace Win32.Media.Audio.XAudio2;

/// <include file='../XAudio2.xml' path='doc/member[@name="IXAudio2MasteringVoice"]/*' />
/// <unmanaged>IXAudio2MasteringVoice</unmanaged>
[NativeTypeName("struct IXAudio2MasteringVoice : IXAudio2Voice")]
[NativeInheritance("IXAudio2Voice")]
public unsafe partial struct IXAudio2MasteringVoice : IXAudio2MasteringVoice.Interface
{
	public void** lpVtbl;

	/// <inheritdoc cref="IXAudio2Voice.GetVoiceDetails" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(0)]
	public void GetVoiceDetails(VoiceDetails* pVoiceDetails)
	{
		((delegate* unmanaged[MemberFunction]<IXAudio2MasteringVoice*, VoiceDetails*, void>)(lpVtbl[0]))((IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this), pVoiceDetails);
	}

	/// <inheritdoc cref="IXAudio2Voice.SetOutputVoices" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(1)]
	public HResult SetOutputVoices(VoiceSends* pSendList)
	{
		return ((delegate* unmanaged[MemberFunction]<IXAudio2MasteringVoice*, VoiceSends*, int>)(lpVtbl[1]))((IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this), pSendList);
	}

	/// <inheritdoc cref="IXAudio2Voice.SetEffectChain" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(2)]
	public HResult SetEffectChain(EffectChain* pEffectChain)
	{
		return ((delegate* unmanaged[MemberFunction]<IXAudio2MasteringVoice*, EffectChain*, int>)(lpVtbl[2]))((IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this), pEffectChain);
	}

	/// <inheritdoc cref="IXAudio2Voice.EnableEffect" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(3)]
	public HResult EnableEffect(uint EffectIndex, uint OperationSet)
	{
		return ((delegate* unmanaged[MemberFunction]<IXAudio2MasteringVoice*, uint, uint, int>)(lpVtbl[3]))((IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this), EffectIndex, OperationSet);
	}

	/// <inheritdoc cref="IXAudio2Voice.DisableEffect" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(4)]
	public HResult DisableEffect(uint EffectIndex, uint OperationSet)
	{
		return ((delegate* unmanaged[MemberFunction]<IXAudio2MasteringVoice*, uint, uint, int>)(lpVtbl[4]))((IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this), EffectIndex, OperationSet);
	}

	/// <inheritdoc cref="IXAudio2Voice.GetEffectState" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(5)]
	public void GetEffectState(uint EffectIndex, Bool32* pEnabled)
	{
		((delegate* unmanaged[MemberFunction]<IXAudio2MasteringVoice*, uint, Bool32*, void>)(lpVtbl[5]))((IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this), EffectIndex, pEnabled);
	}

	/// <inheritdoc cref="IXAudio2Voice.SetEffectParameters" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(6)]
	public HResult SetEffectParameters(uint EffectIndex, void* pParameters, uint ParametersByteSize, uint OperationSet)
	{
		return ((delegate* unmanaged[MemberFunction]<IXAudio2MasteringVoice*, uint, void*, uint, uint, int>)(lpVtbl[6]))((IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this), EffectIndex, pParameters, ParametersByteSize, OperationSet);
	}

	/// <inheritdoc cref="IXAudio2Voice.GetEffectParameters" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(7)]
	public HResult GetEffectParameters(uint EffectIndex, void* pParameters, uint ParametersByteSize)
	{
		return ((delegate* unmanaged[MemberFunction]<IXAudio2MasteringVoice*, uint, void*, uint, int>)(lpVtbl[7]))((IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this), EffectIndex, pParameters, ParametersByteSize);
	}

	/// <inheritdoc cref="IXAudio2Voice.SetFilterParameters" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(8)]
	public HResult SetFilterParameters(FilterParameters* pParameters, uint OperationSet)
	{
		return ((delegate* unmanaged[MemberFunction]<IXAudio2MasteringVoice*, FilterParameters*, uint, int>)(lpVtbl[8]))((IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this), pParameters, OperationSet);
	}

	/// <inheritdoc cref="IXAudio2Voice.GetFilterParameters" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(9)]
	public void GetFilterParameters(FilterParameters* pParameters)
	{
		((delegate* unmanaged[MemberFunction]<IXAudio2MasteringVoice*, FilterParameters*, void>)(lpVtbl[9]))((IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this), pParameters);
	}

	/// <inheritdoc cref="IXAudio2Voice.SetOutputFilterParameters" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(10)]
	public HResult SetOutputFilterParameters(IXAudio2Voice* pDestinationVoice, FilterParameters* pParameters, uint OperationSet)
	{
		return ((delegate* unmanaged[MemberFunction]<IXAudio2MasteringVoice*, IXAudio2Voice*, FilterParameters*, uint, int>)(lpVtbl[10]))((IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this), pDestinationVoice, pParameters, OperationSet);
	}

	/// <inheritdoc cref="IXAudio2Voice.GetOutputFilterParameters" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(11)]
	public void GetOutputFilterParameters(IXAudio2Voice* pDestinationVoice, FilterParameters* pParameters)
	{
		((delegate* unmanaged[MemberFunction]<IXAudio2MasteringVoice*, IXAudio2Voice*, FilterParameters*, void>)(lpVtbl[11]))((IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this), pDestinationVoice, pParameters);
	}

	/// <inheritdoc cref="IXAudio2Voice.SetVolume" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(12)]
	public HResult SetVolume(float Volume, uint OperationSet)
	{
		return ((delegate* unmanaged[MemberFunction]<IXAudio2MasteringVoice*, float, uint, int>)(lpVtbl[12]))((IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this), Volume, OperationSet);
	}

	/// <inheritdoc cref="IXAudio2Voice.GetVolume" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(13)]
	public void GetVolume(float* pVolume)
	{
		((delegate* unmanaged[MemberFunction]<IXAudio2MasteringVoice*, float*, void>)(lpVtbl[13]))((IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this), pVolume);
	}

	/// <inheritdoc cref="IXAudio2Voice.SetChannelVolumes" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(14)]
	public HResult SetChannelVolumes(uint Channels, float* pVolumes, uint OperationSet)
	{
		return ((delegate* unmanaged[MemberFunction]<IXAudio2MasteringVoice*, uint, float*, uint, int>)(lpVtbl[14]))((IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this), Channels, pVolumes, OperationSet);
	}

	/// <inheritdoc cref="IXAudio2Voice.GetChannelVolumes" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(15)]
	public void GetChannelVolumes(uint Channels, float* pVolumes)
	{
		((delegate* unmanaged[MemberFunction]<IXAudio2MasteringVoice*, uint, float*, void>)(lpVtbl[15]))((IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this), Channels, pVolumes);
	}

	/// <inheritdoc cref="IXAudio2Voice.SetOutputMatrix" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(16)]
	public HResult SetOutputMatrix(IXAudio2Voice* pDestinationVoice, uint SourceChannels, uint DestinationChannels, float* pLevelMatrix, uint OperationSet)
	{
		return ((delegate* unmanaged[MemberFunction]<IXAudio2MasteringVoice*, IXAudio2Voice*, uint, uint, float*, uint, int>)(lpVtbl[16]))((IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this), pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrix, OperationSet);
	}

	/// <inheritdoc cref="IXAudio2Voice.GetOutputMatrix" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(17)]
	public void GetOutputMatrix(IXAudio2Voice* pDestinationVoice, uint SourceChannels, uint DestinationChannels, float* pLevelMatrix)
	{
		((delegate* unmanaged[MemberFunction]<IXAudio2MasteringVoice*, IXAudio2Voice*, uint, uint, float*, void>)(lpVtbl[17]))((IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this), pDestinationVoice, SourceChannels, DestinationChannels, pLevelMatrix);
	}

	/// <inheritdoc cref="IXAudio2Voice.DestroyVoice" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(18)]
	public void DestroyVoice()
	{
		((delegate* unmanaged[MemberFunction]<IXAudio2MasteringVoice*, void>)(lpVtbl[18]))((IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this));
	}

	/// <include file='../XAudio2.xml' path='doc/member[@name="IXAudio2MasteringVoice::GetChannelMask"]/*' />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[VtblIndex(19)]
	public HResult GetChannelMask(uint* pChannelmask)
	{
		return ((delegate* unmanaged[MemberFunction]<IXAudio2MasteringVoice*, uint*, int>)(lpVtbl[19]))((IXAudio2MasteringVoice*)Unsafe.AsPointer(ref this), pChannelmask);
	}

	public interface Interface : IXAudio2Voice.Interface
	{
		[VtblIndex(19)]
		HResult GetChannelMask(uint* pChannelmask);
	}
}

