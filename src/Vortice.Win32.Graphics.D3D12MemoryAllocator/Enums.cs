// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.D3D12MemoryAllocator;

/// <unmanaged>D3D12MA_ALLOCATOR_FLAGS</unmanaged>
[Flags]
public enum AllocatorFlags
{
    /// <unmanaged>D3D12MA_ALLOCATOR_FLAG_NONE</unmanaged>
    None = 0x00,
    /// <unmanaged>D3D12MA_ALLOCATOR_FLAG_SINGLETHREADED</unmanaged>
    SingleThreaded = 0x01,
    /// <unmanaged>D3D12MA_ALLOCATOR_FLAG_ALWAYS_COMMITTED</unmanaged>
    AlwaysCommitted = 0x02,
    /// <unmanaged>D3D12MA_ALLOCATOR_FLAG_DEFAULT_POOLS_NOT_ZEROED</unmanaged>
    DefaultPoolsNotZeroed = 0x04,
    /// <unmanaged>D3D12MA_ALLOCATOR_FLAG_MSAA_TEXTURES_ALWAYS_COMMITTED</unmanaged>
    MSAATexturesAlwaysCommitted = 0x08,
    /// <unmanaged>D3D12MA_ALLOCATOR_FLAG_DONT_PREFER_SMALL_BUFFERS_COMMITTED</unmanaged>
    DontPreferSmallBuffersCommitted = 0x10
}

/// <unmanaged>D3D12MA_POOL_FLAGS</unmanaged>
[Flags]
public enum PoolFlags
{
    /// <unmanaged>D3D12MA_POOL_FLAG_NONE</unmanaged>
    None = 0x0,
    /// <unmanaged>D3D12MA_POOL_FLAG_ALGORITHM_LINEAR</unmanaged>
    AlgorithmLinear = 0x1,
    /// <unmanaged>D3D12MA_POOL_FLAG_MSAA_TEXTURES_ALWAYS_COMMITTED</unmanaged>
    MSAATexturesAlwaysCommitted = 0x2,
    /// <unmanaged>D3D12MA_POOL_FLAG_ALGORITHM_MASK</unmanaged>
    AlgorithmMask = AlgorithmLinear,
}

/// <unmanaged>D3D12MA_ALLOCATION_FLAGS</unmanaged>
[Flags]
public enum AllocationFlags
{
    /// <unmanaged>D3D12MA_ALLOCATION_FLAG_NONE</unmanaged>
    None = 0x00000000,
    /// <unmanaged>D3D12MA_ALLOCATION_FLAG_COMMITTED</unmanaged>
    Committed = 0x00000001,
    /// <unmanaged>D3D12MA_ALLOCATION_FLAG_NEVER_ALLOCATE</unmanaged>
    NeverAllocate = 0x00000002,
    /// <unmanaged>D3D12MA_ALLOCATION_FLAG_WITHIN_BUDGET</unmanaged>
    WithinBudget = 0x00000004,
    /// <unmanaged>D3D12MA_ALLOCATION_FLAG_UPPER_ADDRESS</unmanaged>
    UpperAddress = 0x00000008,
    /// <unmanaged>D3D12MA_ALLOCATION_FLAG_CAN_ALIAS</unmanaged>
    CanAlias = 0x00000010,
    /// <unmanaged>D3D12MA_ALLOCATION_FLAG_STRATEGY_MIN_MEMORY</unmanaged>
    StrategyMinMemory = 0x00010000,
    /// <unmanaged>D3D12MA_ALLOCATION_FLAG_STRATEGY_MIN_TIME</unmanaged>
    StrategyMinTime = 0x00020000,
    /// <unmanaged>D3D12MA_ALLOCATION_FLAG_STRATEGY_MIN_OFFSET</unmanaged>
    StrategyMinOffset = 0x0004000,
    /// <unmanaged>D3D12MA_ALLOCATION_FLAG_STRATEGY_BEST_FIT</unmanaged>
    StrategyBestFit = StrategyMinMemory,
    /// <unmanaged>D3D12MA_ALLOCATION_FLAG_STRATEGY_FIRST_FIT</unmanaged>
    StrategyFirstFit = StrategyMinTime,
    /// <unmanaged>D3D12MA_ALLOCATION_FLAG_STRATEGY_MASK</unmanaged>
    StrategyMask = StrategyMinMemory | StrategyMinTime | StrategyMinOffset
}

/// <unmanaged>D3D12MA_ALLOCATION_FLAGS</unmanaged>
[Flags]
public enum VirtualBlockFlags
{
    /// <unmanaged>D3D12MA_VIRTUAL_BLOCK_FLAG_NONE</unmanaged>
    None = 0,
    /// <unmanaged>D3D12MA_VIRTUAL_BLOCK_FLAG_ALGORITHM_LINEAR</unmanaged>
    AlgorithmLinear = PoolFlags.AlgorithmLinear,
    /// <unmanaged>D3D12MA_VIRTUAL_BLOCK_FLAG_ALGORITHM_MASK</unmanaged>
    AlgorithmMask = PoolFlags.AlgorithmMask,
}

/// <unmanaged>D3D12MA_DEFRAGMENTATION_FLAGS</unmanaged>
[Flags]
public enum DefragmentationFlags
{
    /// <unmanaged>D3D12MA_DEFRAGMENTATION_FLAG_ALGORITHM_FAST</unmanaged>
    AlgorithmFast = 0x1,
    /// <unmanaged>D3D12MA_DEFRAGMENTATION_FLAG_ALGORITHM_BALANCED</unmanaged>
    AlgorithmBalanced = 0x2,
    /// <unmanaged>D3D12MA_DEFRAGMENTATION_FLAG_ALGORITHM_FULL</unmanaged>
    AlgorithmFull = 0x4,
    /// <unmanaged>D3D12MA_DEFRAGMENTATION_FLAG_ALGORITHM_MASK</unmanaged>
    AlgorithmMask = AlgorithmFast | AlgorithmBalanced | AlgorithmFull,
}

/// <unmanaged>D3D12MA_DEFRAGMENTATION_MOVE_OPERATION</unmanaged>
public enum DefragmentationMoveOperation
{
    /// <unmanaged>D3D12MA_DEFRAGMENTATION_MOVE_OPERATION_COPY</unmanaged>
    Copy = 0,
    /// <unmanaged>D3D12MA_DEFRAGMENTATION_MOVE_OPERATION_IGNORE</unmanaged>
    Ignore = 1,
    /// <unmanaged>D3D12MA_DEFRAGMENTATION_MOVE_OPERATION_DESTROY</unmanaged>
    Destroy = 2,
}

/// <unmanaged>D3D12MA_VIRTUAL_ALLOCATION_FLAGS</unmanaged>
[Flags]
public enum VirtualAllocationFlags
{
    /// <unmanaged>D3D12MA_VIRTUAL_ALLOCATION_FLAG_NONE</unmanaged>
    None = 0,
    /// <unmanaged>D3D12MA_VIRTUAL_ALLOCATION_FLAG_UPPER_ADDRESS</unmanaged>
    UpperAddress = AllocationFlags.UpperAddress,
    /// <unmanaged>D3D12MA_VIRTUAL_ALLOCATION_FLAG_STRATEGY_MIN_MEMORY</unmanaged>
    StrategyMinMemory = AllocationFlags.StrategyMinMemory,
    /// <unmanaged>D3D12MA_VIRTUAL_ALLOCATION_FLAG_STRATEGY_MIN_TIME</unmanaged>
    StrategyMinTime = AllocationFlags.StrategyMinTime,
    /// <unmanaged>D3D12MA_VIRTUAL_ALLOCATION_FLAG_STRATEGY_MIN_OFFSET</unmanaged>
    StrategyMinOffset = AllocationFlags.StrategyMinOffset,
    /// <unmanaged>D3D12MA_ALLOCATION_FLAG_STRATEGY_MASK</unmanaged>
    StrategyMask = AllocationFlags.StrategyMask,
}
