// Copyright (c) Amer Koleci and contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static Vortice.Win32.Graphics.Direct3D12.Apis;

namespace Vortice.Win32.Graphics.Direct3D12;

public partial struct CommandQueueDescription
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CommandQueueDescription"/> struct.
    /// </summary>
    public CommandQueueDescription(D3D12_COMMAND_LIST_TYPE type, int priority = 0, D3D12_COMMAND_QUEUE_FLAGS flags = D3D12_COMMAND_QUEUE_FLAG_NONE, uint nodeMask = 0)
    {
        Type = type;
        Priority = priority;
        Flags = flags;
        NodeMask = nodeMask;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CommandQueueDescription"/> struct.
    /// </summary>
    /// <param name="type">The queue type.</param>
    /// <param name="priority">The priority.</param>
    /// <param name="flags">Options flags.</param>
    /// <param name="nodeMask">Node mask.</param>
    public CommandQueueDescription(D3D12_COMMAND_LIST_TYPE type, D3D12_COMMAND_QUEUE_PRIORITY priority, D3D12_COMMAND_QUEUE_FLAGS flags = D3D12_COMMAND_QUEUE_FLAG_NONE, uint nodeMask = 0)
    {
        Type = type;
        Priority = (int)priority;
        Flags = flags;
        NodeMask = nodeMask;
    }
}
