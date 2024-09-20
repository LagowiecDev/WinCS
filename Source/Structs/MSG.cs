using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SpicyFramework.Windows
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MSG
    {
        public HWND hwnd;
        public uint message;
        public WPARAM wParam;
        public LPARAM lParam;
        public uint time;
        public POINT pt;
        public uint lPrivate;
    }
}
