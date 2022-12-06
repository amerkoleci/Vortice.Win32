// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Win32.Graphics.Direct2D;

public unsafe partial struct ID2D1Effect
{
    public uint PropertyCount => GetPropertyCount();

    public void SetInput(uint index, ID2D1Image* input)
    {
        SetInput(index, input, 1);
    }

    public void SetInputEffect(uint index, ID2D1Effect* inputEffect, bool invalidate = true)
    {
        ID2D1Image* output = null;

        if (inputEffect != null)
        {
            inputEffect->GetOutput(&output);
        }

        SetInput(index, output, invalidate);
        if (output != null)
        {
            _ = output->Release();
        }
    }
}
