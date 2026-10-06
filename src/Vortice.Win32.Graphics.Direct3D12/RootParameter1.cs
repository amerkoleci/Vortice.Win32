// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.Direct3D12.Apis;

namespace Vortice.Win32.Graphics.Direct3D12;

public unsafe partial struct RootParameter1
{
    public static void InitAsDescriptorTable(
        out RootParameter1 rootParam,
        uint numDescriptorRanges,
        DescriptorRange1* pDescriptorRanges,
        D3D12_SHADER_VISIBILITY visibility = D3D12_SHADER_VISIBILITY_ALL)
    {
        rootParam = default;

        rootParam.ParameterType = D3D12_ROOT_PARAMETER_TYPE_DESCRIPTOR_TABLE;
        rootParam.ShaderVisibility = visibility;
        RootDescriptorTable1.Init(out rootParam.Anonymous.DescriptorTable, numDescriptorRanges, pDescriptorRanges);
    }

    public static void InitAsConstants(
        out RootParameter1 rootParam,
        uint num32BitValues,
        uint shaderRegister,
        uint registerSpace = 0,
        D3D12_SHADER_VISIBILITY visibility = D3D12_SHADER_VISIBILITY_ALL)
    {
        rootParam = default;

        rootParam.ParameterType = D3D12_ROOT_PARAMETER_TYPE_32BIT_CONSTANTS;
        rootParam.ShaderVisibility = visibility;
        RootConstants.Init(out rootParam.Anonymous.Constants, num32BitValues, shaderRegister, registerSpace);
    }

    public static void InitAsConstantBufferView(
        out RootParameter1 rootParam,
        uint shaderRegister,
        uint registerSpace = 0,
        D3D12_SHADER_VISIBILITY visibility = D3D12_SHADER_VISIBILITY_ALL)
    {
        rootParam = default;

        rootParam.ParameterType = D3D12_ROOT_PARAMETER_TYPE_CBV;
        rootParam.ShaderVisibility = visibility;
        RootDescriptor1.Init(out rootParam.Anonymous.Descriptor, shaderRegister, registerSpace);
    }

    public static void InitAsShaderResourceView(
        out RootParameter1 rootParam,
        uint shaderRegister,
        uint registerSpace = 0,
        D3D12_SHADER_VISIBILITY visibility = D3D12_SHADER_VISIBILITY_ALL)
    {
        rootParam = default;

        rootParam.ParameterType = D3D12_ROOT_PARAMETER_TYPE_SRV;
        rootParam.ShaderVisibility = visibility;
        RootDescriptor1.Init(out rootParam.Anonymous.Descriptor, shaderRegister, registerSpace);
    }

    public static void InitAsUnorderedAccessView(
        out RootParameter1 rootParam,
        uint shaderRegister,
        uint registerSpace = 0,
        D3D12_SHADER_VISIBILITY visibility = D3D12_SHADER_VISIBILITY_ALL)
    {
        rootParam = default;

        rootParam.ParameterType = D3D12_ROOT_PARAMETER_TYPE_UAV;
        rootParam.ShaderVisibility = visibility;
        RootDescriptor1.Init(out rootParam.Anonymous.Descriptor, shaderRegister, registerSpace);
    }

    public void InitAsDescriptorTable(
        uint numDescriptorRanges,
        DescriptorRange1* pDescriptorRanges,
        D3D12_SHADER_VISIBILITY visibility = D3D12_SHADER_VISIBILITY_ALL)
    {
        InitAsDescriptorTable(out this, numDescriptorRanges, pDescriptorRanges, visibility);
    }

    public void InitAsConstants(
        uint num32BitValues,
        uint shaderRegister,
        uint registerSpace = 0,
        D3D12_SHADER_VISIBILITY visibility = D3D12_SHADER_VISIBILITY_ALL)
    {
        InitAsConstants(out this, num32BitValues, shaderRegister, registerSpace, visibility);
    }

    public void InitAsConstantBufferView(
        uint shaderRegister,
        uint registerSpace = 0,
        D3D12_SHADER_VISIBILITY visibility = D3D12_SHADER_VISIBILITY_ALL)
    {
        InitAsConstantBufferView(out this, shaderRegister, registerSpace, visibility);
    }

    public void InitAsShaderResourceView(
        uint shaderRegister,
        uint registerSpace = 0,
        D3D12_SHADER_VISIBILITY visibility = D3D12_SHADER_VISIBILITY_ALL)
    {
        InitAsShaderResourceView(out this, shaderRegister, registerSpace, visibility);
    }

    public void InitAsUnorderedAccessView(
        uint shaderRegister,
        uint registerSpace = 0,
        D3D12_SHADER_VISIBILITY visibility = D3D12_SHADER_VISIBILITY_ALL)
    {
        InitAsUnorderedAccessView(out this, shaderRegister, registerSpace, visibility);
    }
}
