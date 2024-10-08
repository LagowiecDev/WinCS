﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinCS
{
    public static partial class WindowStylesFlags
    {
        // Extended Window Styles
        public const uint WS_EX_ACCEPTFILES = 0x00000010;
        public const uint WS_EX_APPWINDOW = 0x00040000;
        public const uint WS_EX_CLIENTEDGE = 0x00000200;
        public const uint WS_EX_COMPOSITED = 0x02000000;
        public const uint WS_EX_CONTEXTHELP = 0x00000400;
        public const uint WS_EX_CONTROLPARENT = 0x00010000;
        public const uint WS_EX_DLGMODALFRAME = 0x00000001;
        public const uint WS_EX_LAYERED = 0x00080000;
        public const uint WS_EX_LAYOUTRTL = 0x00400000;
        public const uint WS_EX_LEFT = 0x00000000;
        public const uint WS_EX_LEFTSCROLLBAR = 0x00004000;
        public const uint WS_EX_LTRREADING = 0x00000000;
        public const uint WS_EX_MDICHILD = 0x00000040;
        public const uint WS_EX_NOACTIVATE = 0x08000000;
        public const uint WS_EX_NOINHERITLAYOUT = 0x00100000;
        public const uint WS_EX_NOPARENTNOTIFY = 0x00000004;
        public const uint WS_EX_NOREDIRECTIONBITMAP = 0x00200000;
        public const uint WS_EX_OVERLAPPEDWINDOW =
            WS_EX_WINDOWEDGE | WS_EX_CLIENTEDGE;
        public const uint WS_EX_PALETTEWINDOW =
            WS_EX_WINDOWEDGE | WS_EX_TOOLWINDOW | WS_EX_TOPMOST;
        public const uint WS_EX_RIGHT = 0x00001000;
        public const uint WS_EX_RIGHTSCROLLBAR = 0x00000000;
        public const uint WS_EX_RTLREADING = 0x00002000;
        public const uint WS_EX_STATICEDGE = 0x00020000;
        public const uint WS_EX_TOOLWINDOW = 0x00000080;
        public const uint WS_EX_TOPMOST = 0x00000008;
        public const uint WS_EX_TRANSPARENT = 0x00000020;
        public const uint WS_EX_WINDOWEDGE = 0x00000100;
    }
}
