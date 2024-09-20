﻿using System;

namespace WinCS
{
    public static partial class WindowClassStylesFlags
    {
        public const uint CS_BYTEALIGNCLIENT = 0x1000;
        public const uint CS_BYTEALIGNWINDOW = 0x2000;
        public const uint CS_CLASSDC = 0x0040;
        public const uint CS_DBLCLKS = 0x0008;
        public const uint CS_DROPSHADOW = 0x00020000;
        public const uint CS_GLOBALCLASS = 0x4000;
        public const uint CS_HREDRAW = 0x0002;
        public const uint CS_NOCLOSE = 0x0200;
        public const uint CS_OWNDC = 0x0020;
        public const uint CS_PARENTDC = 0x0080;
        public const uint CS_SAVEBITS = 0x0800;
        public const uint CS_VREDRAW = 0x0001;

        // Additional flags can be added here if necessary
    }
}