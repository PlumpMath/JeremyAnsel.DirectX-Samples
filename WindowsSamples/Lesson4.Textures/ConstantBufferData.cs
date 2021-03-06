﻿using System.Runtime.InteropServices;
using BasicMaths;

namespace Lesson4.Textures
{
    [StructLayout(LayoutKind.Sequential)]
    struct ConstantBufferData
    {
        public Float4X4 Model;

        public Float4X4 View;

        public Float4X4 Projection;

        public static uint Size = (uint)Marshal.SizeOf(typeof(ConstantBufferData));
    }
}
