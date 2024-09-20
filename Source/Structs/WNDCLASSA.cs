using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SpicyFramework.Windows
{
    [StructLayout(LayoutKind.Sequential)]
    public struct WNDCLASSA
    {
        public DWORD style;
        public WNDPROC lpfnWndProc;
        public int cbClsExtra;
        public int cbWndExtra;
        public HINSTANCE hInstance;
        public HICON hIcon;
        public HCURSOR hCursor;
        public HBRUSH hbrBackground;
        public LPCSTR lpszMenuName;
        public LPCSTR lpszClassName;
    }
}
