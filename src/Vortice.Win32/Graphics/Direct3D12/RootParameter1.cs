// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct3D12;

public unsafe partial struct RootParameter1
{
    public static void InitAsDescriptorTable(
        out RootParameter1 rootParam,
        uint numDescriptorRanges,
        DescriptorRange1* pDescriptorRanges,
        ShaderVisibility visibility = ShaderVisibility.All)
    {
        rootParam = default;

        rootParam.ParameterType = RootParameterType.DescriptorTable;
        rootParam.ShaderVisibility = visibility;
        RootDescriptorTable1.Init(out rootParam.Anonymous.DescriptorTable, numDescriptorRanges, pDescriptorRanges);
    }

    public static void InitAsConstants(
        out RootParameter1 rootParam,
        uint num32BitValues,
        uint shaderRegister,
        uint registerSpace = 0,
        ShaderVisibility visibility = ShaderVisibility.All)
    {
        rootParam = default;

        rootParam.ParameterType = RootParameterType.T32BitConstants;
        rootParam.ShaderVisibility = visibility;
        RootConstants.Init(out rootParam.Anonymous.Constants, num32BitValues, shaderRegister, registerSpace);
    }

    public static void InitAsConstantBufferView(
        out RootParameter1 rootParam,
        uint shaderRegister,
        uint registerSpace = 0,
        ShaderVisibility visibility = ShaderVisibility.All)
    {
        rootParam = default;

        rootParam.ParameterType = RootParameterType.Cbv;
        rootParam.ShaderVisibility = visibility;
        RootDescriptor1.Init(out rootParam.Anonymous.Descriptor, shaderRegister, registerSpace);
    }

    public static void InitAsShaderResourceView(
        out RootParameter1 rootParam,
        uint shaderRegister,
        uint registerSpace = 0,
        ShaderVisibility visibility = ShaderVisibility.All)
    {
        rootParam = default;

        rootParam.ParameterType = RootParameterType.Srv;
        rootParam.ShaderVisibility = visibility;
        RootDescriptor1.Init(out rootParam.Anonymous.Descriptor, shaderRegister, registerSpace);
    }

    public static void InitAsUnorderedAccessView(
        out RootParameter1 rootParam,
        uint shaderRegister,
        uint registerSpace = 0,
        ShaderVisibility visibility = ShaderVisibility.All)
    {
        rootParam = default;

        rootParam.ParameterType = RootParameterType.Uav;
        rootParam.ShaderVisibility = visibility;
        RootDescriptor1.Init(out rootParam.Anonymous.Descriptor, shaderRegister, registerSpace);
    }

    public void InitAsDescriptorTable(
        uint numDescriptorRanges,
        DescriptorRange1* pDescriptorRanges,
        ShaderVisibility visibility = ShaderVisibility.All)
    {
        InitAsDescriptorTable(out this, numDescriptorRanges, pDescriptorRanges, visibility);
    }

    public void InitAsConstants(
        uint num32BitValues,
        uint shaderRegister,
        uint registerSpace = 0,
        ShaderVisibility visibility = ShaderVisibility.All)
    {
        InitAsConstants(out this, num32BitValues, shaderRegister, registerSpace, visibility);
    }

    public void InitAsConstantBufferView(
        uint shaderRegister,
        uint registerSpace = 0,
        ShaderVisibility visibility = ShaderVisibility.All)
    {
        InitAsConstantBufferView(out this, shaderRegister, registerSpace, visibility);
    }

    public void InitAsShaderResourceView(
        uint shaderRegister,
        uint registerSpace = 0,
        ShaderVisibility visibility = ShaderVisibility.All)
    {
        InitAsShaderResourceView(out this, shaderRegister, registerSpace, visibility);
    }

    public void InitAsUnorderedAccessView(
        uint shaderRegister,
        uint registerSpace = 0,
        ShaderVisibility visibility = ShaderVisibility.All)
    {
        InitAsUnorderedAccessView(out this, shaderRegister, registerSpace, visibility);
    }
}
