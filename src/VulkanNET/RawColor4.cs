﻿// Copyright (c) 2010-2013 SharpDX - Alexandre Mutel
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System.Diagnostics;
using System.Runtime.InteropServices;

namespace VulkanNET
{
    /// <summary>
    /// Interop type for a Color4 (RGBA, 4 floats).
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    [DebuggerDisplay("R:{R} G:{G} B:{B} A:{A}")]
    public struct RawColor4
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RawColor4"/> struct.
        /// </summary>
        /// <param name="r">The r.</param>
        /// <param name="g">The g.</param>
        /// <param name="b">The b.</param>
        /// <param name="a">A.</param>
        public RawColor4(float r, float g, float b, float a)
        {
            R = r;
            G = g;
            B = b;
            A = a;
        }

        /// <summary>
        /// The red component of the color.
        /// </summary>
        public float R;

        /// <summary>
        /// The green component of the color.
        /// </summary>
        public float G;

        /// <summary>
        /// The blue component of the color.
        /// </summary>
        public float B;

        /// <summary>
        /// The alpha component of the color.
        /// </summary>
        public float A;

        public static unsafe implicit operator ClearColorValue(RawColor4 colorValue)
        {
            return *(ClearColorValue*)&colorValue;
        }
    }
}
